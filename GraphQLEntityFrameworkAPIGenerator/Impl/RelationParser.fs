namespace GraphQLEntityFrameworkAPIGenerator.Impl

open GraphQLEntityFrameworkAPIGenerator.Interfaces
open GraphQLEntityFrameworkAPIGenerator.Types

type RelationParser() =
    //let (|IsRegularTable|_|) : Table -> RegularTable option = function | Regular(r) -> Some r | _ -> None
    //let isRegularTable table = match table with | Regular(_) -> true | _ -> false

    member private this.ParseRegularTable(tables: Map<TableName, Table>, table: RegularTable) : Entity =
        let fields: Field list =
            table.Properties
            |> List.collect (fun property  ->
                match property with
                | Property.PrimaryKey pk ->
                    match pk with
                    | PrimaryKeyProperty.Single pk -> 
                        { 
                            PropName = pk.PropName;
                            ColumnName = pk.ColumnName;
                            Type = FieldType.Id pk.Type;
                            IsNullable = false;
                        } |> List.singleton
                    | PrimaryKeyProperty.Composite pk ->
                        pk.Keys
                        |> List.map (fun pk -> 
                            { 
                                PropName = pk.PropName;
                                ColumnName = pk.ColumnName;
                                Type = FieldType.Id pk.Type;
                                IsNullable = false;
                            })
                        |> List.ofSeq
                | Property.ForeignKey p -> 
                    match p with
                    | ForeignKeyProperty.Single fk ->
                        { 
                            PropName = fk.PropName;
                            ColumnName = fk.ColumnName;
                            Type = FieldType.Id fk.Type;
                            IsNullable = false;
                        } |> List.singleton
                    | ForeignKeyProperty.Composite fk ->
                        fk.Keys
                        |> List.map (fun fk ->
                        {
                            PropName = fk.PropName;
                            ColumnName = fk.ColumnName;
                            Type = FieldType.Id fk.Type;
                            IsNullable = false;
                        }) |> List.ofSeq
                | Property.Primitive(p) -> 
                    { 
                        PropName = p.PropName;
                        ColumnName = p.ColumnName;
                        Type = FieldType.Primitive p.Type;
                        IsNullable = p.IsNullable;
                    } |> List.singleton
                | _ -> [])
            |> List.distinctBy (fun field -> field.PropName)

        let relations: Relation list =
            table.Properties
            |> Seq.choose (fun property ->
                match property with
                | Navigation(n) -> Some n
                | _ -> None)
            |> Seq.collect (fun thisNavProp ->
                let otherTable = 
                    match tables.TryFind thisNavProp.Type with
                    | Some table -> table
                    | None -> failwith $"Table '{thisNavProp.Type}', required for {table.Name}, not found in tables map."
                let thatNavProp =
                    otherTable.NavigationProperties
                    |> Seq.tryFind (fun otherNavProp ->
                        otherNavProp.Name.ToString() = thisNavProp.InverseName.ToString())
                    |> fun n ->
                        match n with
                        | Some v -> v
                        | None -> failwith $"Expected '{thisNavProp.InverseName}' backwards navigation property for table '{otherTable.Name}'. If you changed the 'IgnoredTables', please make sure to always ignore backwards navigation properties on tables since every navigation property must have a backwards counterpart."

                match otherTable, thisNavProp, thatNavProp with
                | Regular(otherTable), Single(thisNavProp), Single(thatNavProp) ->
                    OneToOne {
                        Name = RelationName (thisNavProp.PropName.ToString());
                        NavProp = thisNavProp;
                        BackwardsNavProp = thatNavProp;
                        SourceTable = table;
                        TargetTable = otherTable;
                        Destination = EntityName (thisNavProp.PropName.ToString());
                        IsNullable = thisNavProp.IsNullable;
                    } |> Seq.singleton
                | Regular(otherTable), Single(thisNavProp), Collection(thatNavProp) ->
                    ManyToOne { 
                        Name = RelationName (thisNavProp.PropName.ToString());
                        NavProp = thisNavProp;
                        BackwardsNavProp = thatNavProp;
                        SourceTable = table;
                        TargetTable = otherTable;
                        Destination = EntityName (thisNavProp.PropName.ToString());
                        IsNullable = thisNavProp.IsNullable;
                    } |> Seq.singleton
                | Regular(otherTable), Collection(thisNavProp), Single(thatNavProp) ->
                    OneToMany {
                        Name = RelationName (thisNavProp.PropName.ToString());
                        // KeyType = otherTable.PrimaryKey.Type;
                        NavProp = thisNavProp;
                        BackwardsNavProp = thatNavProp;
                        SourceTable = table;
                        TargetTable = otherTable;
                        Destination = EntityName (thisNavProp.PropName.ToString());
                        IsNullable = thisNavProp.IsNullable;
                    } |> Seq.singleton
                | Join(joinTable), Collection(thisNavProp), Single(thatNavProp) ->
                    let trueNavigationProperties =
                        joinTable.NavigationProperties
                        |> List.choose (fun nav -> 
                            match nav with
                            | Single(n) -> if nav.Type <> table.Name then Some n else None
                            | _ -> None)

                    let relations =
                        trueNavigationProperties
                        |> List.map (fun nav ->
                            match tables.TryFind nav.Type with
                            | Some (Regular(destination)) ->
                                ManyToManyWithJoinTable {
                                    Name = RelationName (nav.PropName.ToString());
                                    // KeyType = destination.PrimaryKey.Type;
                                    NavProp = thisNavProp;
                                    JoinTableNavProp = nav;
                                    JoinTableBackwardsNavProp = thatNavProp;
                                    SourceTable = table;
                                    JoinTable = joinTable;
                                    TargetTable = destination;
                                    Destination = EntityName (nav.Type.ToString());
                                    IsNullable = thisNavProp.IsNullable;
                                }
                            | _ -> failwith $"Destination table '{nav.Type}', for origin table '{table.Name}' and origin destination '{thisNavProp.PropName}' is not a regular table (debug: 2)")
                    relations
                | Regular(regularTable), Collection(thisNavProp), Collection(thatNavProp) ->
                    // Many to many relation without join table (collection both sides)
                    ManyToMany {
                        Name = RelationName (thisNavProp.PropName.ToString());
                        // KeyType = regularTable.PrimaryKey.Type;
                        NavProp = thisNavProp;
                        BackwardsNavProp = thatNavProp;
                        Destination = EntityName (thisNavProp.PropName.ToString());
                        SourceTable = table;
                        TargetTable = regularTable;
                    } |> Seq.singleton
                | _ -> 
                    failwith 
                        $$"""
                            Default case should not be reached:
                            Other table is Join Table = {{match otherTable with | Join(_) -> true | _ -> false}},
                            table.Name = {{table.Name}},
                            otherTable.Name = {{otherTable.Name}},
                            table.NavigationProperties = {{table.NavigationProperties}},
                            otherTable.NavigationProperties = {{otherTable.NavigationProperties}},

                        """)
            |> List.ofSeq

        let entity: Entity = {
            Name = EntityName (table.Name.ToString());
            CorrespondingTable = table |> Regular
            Fields = fields
            Relations = relations
        }

        entity

    member private _.ParseViewTable(table: ViewTable) : Entity =
        let fields: Field list =
            table.PrimitiveProperties
            |> Seq.map (fun p  ->
            {
                PropName = p.PropName;
                ColumnName = p.ColumnName;
                Type = FieldType.Primitive p.Type;
                IsNullable = p.IsNullable
            })
            |> List.ofSeq

        let entity: Entity = {
            Name = EntityName (table.Name.ToString());
            CorrespondingTable = table |> View
            Fields = fields
            Relations = []
        }
        entity


    interface IRelationParser with
        member _.ParseEntities(tables: Map<TableName, Table>) : Entity list =
            tables.Values
            |> Seq.choose (fun table -> 
                match table with
                | Join(j) -> None
                | Regular(r) -> Some (RelationParser().ParseRegularTable(tables, r))
                | View(v) -> Some (RelationParser().ParseViewTable(v)))
            |> List.ofSeq
