namespace GraphQLEntityFrameworkAPIGenerator.Impl

open GraphQLEntityFrameworkAPIGenerator.Interfaces
open GraphQLEntityFrameworkAPIGenerator.Types

type RelationParser() =
    let (|IsRegularTable|_|) : Table -> RegularTable option = function | Regular(r) -> Some r | _ -> None
    let isRegularTable table = match table with | Regular(_) -> true | _ -> false

    member private this.ParseRegularTable(tables: Map<TableName, Table>, table: RegularTable) : Entity =
        let fields: Field list =
            table.Properties
            |> Seq.choose (fun property  ->
                match property with
                | PrimaryKey(p) -> 
                    Some { 
                        Name = p.Name;
                        Type = Type.Id p.Type;
                        IsNullable = p.IsNullable
                    }
                | Primitive(p) -> 
                    Some { 
                        Name = p.Name;
                        Type = Type.Primitive p.Type;
                        IsNullable = p.IsNullable
                    }
                | _ -> None)
            |> List.ofSeq

        let relations: Relation list =
            table.Properties
            |> Seq.choose (fun property ->
                match property with
                | Navigation(n) -> Some n
                | _ -> None)
            |> Seq.groupBy (fun navigationProperty -> navigationProperty.Type)
            |> Seq.map (fun (navPropName, navProps) ->
                let mainNavProp = 
                    match List.ofSeq navProps with
                    | [] -> failwith $"No navigation properties found for type '{navPropName}'"
                    | head :: _ -> head
                let otherTable = 
                    match tables.TryFind navPropName with
                    | Some table -> table
                    | None -> 
                        let availableTables = tables.Keys |> Seq.map (fun k -> k.ToString()) |> String.concat ", "
                        failwith $"Table '{navPropName}', required for {table.Name}, not found in tables map. Available tables: {availableTables}"

                let hereIsSingle = not mainNavProp.IsCollection
                let thereIsSingle =
                    otherTable.NavigationProperties
                    |> Seq.exists (fun otherNavProp ->
                        otherNavProp.Type = table.Name && not otherNavProp.IsCollection)
                let hereIsCollection = mainNavProp.IsCollection
                let thereIsCollection = 
                    otherTable.NavigationProperties
                    |> Seq.exists (fun otherNavProp -> 
                        otherNavProp.Type = table.Name && otherNavProp.IsCollection)

                let repeats = navProps |> Seq.length > 1

                match otherTable with
                | IsRegularTable(regularTable) when hereIsSingle && not repeats && thereIsSingle ->
                    OneToOne {
                        Name = RelationName (navPropName.ToString());
                        Destination = EntityName (navPropName.ToString());
                        IsNullable = mainNavProp.IsNullable;
                        KeyType = regularTable.PrimaryKey.Type;
                        TargetTable = regularTable;
                    }
                | IsRegularTable(regularTable) when hereIsSingle && not repeats && thereIsCollection ->
                    SingleManyToOne { 
                        Name = RelationName (navPropName.ToString()); 
                        Destination = EntityName (navPropName.ToString());
                        IsNullable = mainNavProp.IsNullable;
                        KeyType = regularTable.PrimaryKey.Type;
                        TargetTable = regularTable;
                    }
                | IsRegularTable(regularTable) when hereIsSingle && repeats && thereIsCollection ->
                    MultipleManyToOne {
                        Names = 
                            navProps 
                            |> Seq.map (fun navProp -> RelationName navProp.Name) 
                            |> List.ofSeq;
                        Destination = EntityName (navPropName.ToString());
                        IsNullable = mainNavProp.IsNullable;
                        KeyType = regularTable.PrimaryKey.Type;
                        TargetTable = regularTable;
                    }
                | IsRegularTable(regularTable) when hereIsCollection && thereIsSingle ->
                    OneToMany {
                        Name = RelationName (navPropName.ToString());
                        Destination = EntityName (navPropName.ToString());
                        KeyType = regularTable.PrimaryKey.Type;
                        TargetTable = regularTable;
                    }
                | Join(joinTable) when hereIsSingle && not repeats && thereIsCollection ->
                    // Single navigation property pointing to a join table - this is a many-to-many relationship
                    let trueNavigationProperty = 
                        let filteredNavProps = 
                            joinTable.Properties
                            |> List.choose (function | Navigation(nav) -> Some nav | _ -> None)
                            |> List.filter (fun nav -> nav.Type <> table.Name)
                        match filteredNavProps with
                        | [] -> failwith $"Join table '{joinTable.Name}' has no navigation properties pointing to other tables"
                        | head :: _ -> head

                    match tables.TryFind trueNavigationProperty.Type with
                    | Some table -> 
                        match table with
                        | IsRegularTable(trueDestinationTable) ->
                            ManyToManyWithJoinTable {
                                Name = RelationName (navPropName.ToString());
                                JoinTable = joinTable;
                                Destination = EntityName (trueNavigationProperty.Type.ToString());
                                KeyType = trueDestinationTable.PrimaryKey.Type;
                                TargetTable = trueDestinationTable;
                            }
                        | _ -> failwith $"Destination table '{trueNavigationProperty.Type}', for origin table '{table.Name}' and origin destination '{navPropName}' is not a regular table (debug: 1)"
                    | None -> 
                        let availableTables = tables.Keys |> Seq.map (fun k -> k.ToString()) |> String.concat ", "
                        failwith $"Table '{trueNavigationProperty.Type}', required for {table.Name}, not found in tables map for join table relation. Available tables: {availableTables}"
                | Join(joinTable) when hereIsCollection && thereIsSingle ->
                    // Collection navigation property pointing to a join table
                    let trueNavigationProperty = 
                        let filteredNavProps = 
                            joinTable.Properties
                            |> List.choose (function | Navigation(nav) -> Some nav | _ -> None)
                            |> List.filter (fun nav -> nav.Type <> table.Name)
                        match filteredNavProps with
                        | [] -> failwith $"Join table '{joinTable.Name}' has no navigation properties pointing to other tables"
                        | head :: _ -> head

                    match tables.TryFind trueNavigationProperty.Type with
                    | Some table -> 
                        match table with
                        | IsRegularTable(trueDestinationTable) ->
                            ManyToManyWithJoinTable {
                                Name = RelationName (navPropName.ToString());
                                JoinTable = joinTable;
                                Destination = EntityName (trueNavigationProperty.Type.ToString());
                                KeyType = trueDestinationTable.PrimaryKey.Type;
                                TargetTable = trueDestinationTable;
                            }
                        | _ -> failwith $"Destination table '{trueNavigationProperty.Type}', for origin table '{table.Name}' and origin destination '{navPropName}' is not a regular table (debug: 2)"
                    | None -> 
                        let availableTables = tables.Keys |> Seq.map (fun k -> k.ToString()) |> String.concat ", "
                        failwith $"Table '{trueNavigationProperty.Type}', required for {table.Name}, not found in tables map for second join table relation. Available tables: {availableTables}"
                | IsRegularTable(regularTable) when hereIsCollection && thereIsCollection ->
                    ManyToMany {
                        Name = RelationName (navPropName.ToString());
                        Destination = EntityName (navPropName.ToString());
                        KeyType = regularTable.PrimaryKey.Type;
                        TargetTable = regularTable;
                    }
                | _ -> 
                    failwith 
                        $$"""
                            Default case should not be reached: 
                            thereIsCollection = {{thereIsCollection}},
                            thereIsSingle = {{thereIsSingle}},
                            hereIsCollection = {{hereIsCollection}},
                            hereIsSingle = {{hereIsSingle}},
                            repeats = {{repeats}},
                            IsJoinTable = {{match otherTable with | Join(_) -> true | _ -> false}},
                            table.Name = {{table.Name}},
                            otherTable.Name = {{otherTable.Name}},
                            table.NavigationProperties = {{table.NavigationProperties}},
                            otherTable.NavigationProperties = {{otherTable.NavigationProperties}},

                        """
                            )
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
                Name = p.Name;
                Type = Type.Primitive p.Type;
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
