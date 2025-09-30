namespace GraphQLEntityFrameworkAPIGenerator.Impl

open GraphQLEntityFrameworkAPIGenerator.Interfaces
open GraphQLEntityFrameworkAPIGenerator.Types

type RelationParser() =
    //let (|IsRegularTable|_|) : Table -> RegularTable option = function | Regular(r) -> Some r | _ -> None
    //let isRegularTable table = match table with | Regular(_) -> true | _ -> false

    member private this.ParseRegularTable(tables: Map<TableName, Table>, table: RegularTable) : Entity =
        let fields: Field list =
            table.Properties
            |> List.choose (fun property  ->
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

        let relations: Relation list =
            table.Properties
            |> Seq.choose (fun property ->
                match property with
                | Navigation(n) -> Some n
                | _ -> None)
            |> Seq.groupBy (fun navigationProperty -> 
                (navigationProperty.Type, 
                 match navigationProperty with 
                 | Single(_) -> "Single" 
                 | Collection(_) -> "Collection"))
            |> Seq.collect (fun ((navPropName, _), navProps) ->
                let thisNavProp = 
                    match List.ofSeq navProps with
                    | [] -> failwith $"No navigation properties found for type '{navPropName}'"
                    | head :: _ -> head
                let otherTable = 
                    match tables.TryFind navPropName with
                    | Some table -> table
                    | None -> 
                        let availableTables = tables.Keys |> Seq.map (fun k -> k.ToString()) |> String.concat ", "
                        failwith $"Table '{navPropName}', required for {table.Name}, not found in tables map."
                let thatNavProp =
                    otherTable.NavigationProperties
                    |> Seq.filter (fun otherNavProp ->
                        otherNavProp.Type = table.Name)
                    |> (fun n ->
                        match Seq.tryHead n with
                            | Some v -> v
                            | _ -> failwith $"No backwards navigation property for {table.Name} table")

                //let hereIsSingle = not mainNavProp.IsCollection
                //let thereIsSingle =
                //    otherTable.NavigationProperties
                //    |> Seq.exists (fun otherNavProp ->
                //        otherNavProp.Type = table.Name && not otherNavProp.IsCollection)
                //let hereIsCollection = mainNavProp.IsCollection
                //let thereIsCollection = 
                //    otherTable.NavigationProperties
                //    |> Seq.exists (fun otherNavProp -> 
                //        otherNavProp.Type = table.Name && otherNavProp.IsCollection)

                let repeats = navProps |> Seq.length > 1

                match otherTable, thisNavProp, thatNavProp with
                | Regular(otherTable), Single(thisNavProp), Single(thatNavProp) when not repeats ->
                    OneToOne {
                        Name = RelationName (navPropName.ToString());
                        KeyType = otherTable.PrimaryKey.Type;
                        NavProp = thisNavProp;
                        BackwardsNavProp = thatNavProp;
                        SourceTable = table;
                        TargetTable = otherTable;
                        Destination = EntityName (navPropName.ToString());
                        IsNullable = thisNavProp.IsNullable;
                    } |> List.singleton
                | Regular(otherTable), Single(thisNavProp), Collection(thatNavProp) when not repeats ->
                    SingleManyToOne { 
                        Name = RelationName (navPropName.ToString()); 
                        KeyType = otherTable.PrimaryKey.Type;
                        NavProp = thisNavProp;
                        BackwardsNavProp = thatNavProp;
                        SourceTable = table;
                        TargetTable = otherTable;
                        Destination = EntityName (navPropName.ToString());
                        IsNullable = thisNavProp.IsNullable;
                    } |> List.singleton
                | Regular(otherTable), Single(thisNavProp), Collection(thatNavProp) when repeats ->
                    let forwardNavigationProperties =
                        navProps
                        |> Seq.choose (fun navProp -> 
                            match navProp with
                            | Single(n) -> Some n
                            | _ -> None)
                        |> List.ofSeq
                    let backwardsNavigationProperties =
                        otherTable.NavigationProperties
                        |> Seq.choose (fun navProp -> 
                            match navProp with
                            | Collection(n) -> if n.Type = table.Name then Some n else None
                            | _ -> None)
                        |> List.ofSeq

                    if forwardNavigationProperties.Length <> backwardsNavigationProperties.Length then
                        failwith $"Forward navigation properties length ({forwardNavigationProperties.Length}) does not match backwards navigation properties length ({backwardsNavigationProperties.Length}) for table {table.Name}"
                    else

                    MultipleManyToOne {
                        Names = 
                            forwardNavigationProperties 
                            |> Seq.map (fun navProp -> RelationName navProp.Name) 
                            |> List.ofSeq;
                        KeyType = otherTable.PrimaryKey.Type;
                        NavProps = forwardNavigationProperties;
                        BackwardsNavProps = backwardsNavigationProperties;
                        SourceTable = table;
                        TargetTable = otherTable;
                        Destination = EntityName (navPropName.ToString());
                        IsNullable = thisNavProp.IsNullable;
                    } |> List.singleton
                | Regular(otherTable), Collection(thisNavProp), Single(thatNavProp) when not repeats ->
                    SingleOneToMany {
                        Name = RelationName (navPropName.ToString());
                        KeyType = otherTable.PrimaryKey.Type;
                        NavProp = thisNavProp;
                        BackwardsNavProp = thatNavProp;
                        SourceTable = table;
                        TargetTable = otherTable;
                        Destination = EntityName (navPropName.ToString());
                        IsNullable = thisNavProp.IsNullable;
                    } |> List.singleton
                | Regular(otherTable), Collection(thisNavProp), Single(thatNavProp) when repeats ->
                    let forwardNavigationProperties =
                        navProps
                        |> Seq.choose (fun navProp -> 
                            match navProp with
                            | Collection(n) -> Some n
                            | _ -> None)
                        |> List.ofSeq
                    let backwardsNavigationProperties =
                        otherTable.NavigationProperties
                        |> Seq.choose (fun navProp -> 
                            match navProp with
                            | Single(n) -> if n.Type = table.Name then Some n else None
                            | _ -> None)
                        |> List.ofSeq
                    if forwardNavigationProperties.Length <> backwardsNavigationProperties.Length then
                        failwith $"Forward navigation properties length ({forwardNavigationProperties.Length}) does not match backwards navigation properties length ({backwardsNavigationProperties.Length}) for table {table.Name}"
                    else

                    MultipleOneToMany {
                        Names =
                            forwardNavigationProperties
                            |> Seq.map (fun navProp -> RelationName navProp.Name)
                            |> List.ofSeq
                        KeyType = otherTable.PrimaryKey.Type;
                        NavProps = forwardNavigationProperties;
                        BackwardsNavProps = backwardsNavigationProperties;
                        SourceTable = table;
                        TargetTable = otherTable;
                        Destination = EntityName (navPropName.ToString());
                        IsNullable = thisNavProp.IsNullable;
                    } |> List.singleton
                //| Join(joinTable) when hereIsSingle && not repeats && thereIsCollection ->
                //    // Single navigation property pointing to a join table.
                //    let trueNavigationProperty = 
                //        let filteredNavProps = 
                //            joinTable.Properties
                //            |> List.choose (function | Navigation(nav) -> Some nav | _ -> None)
                //            |> List.filter (fun nav -> nav.Type <> table.Name)
                //        match filteredNavProps with
                //        | [] -> failwith $"Join table '{joinTable.Name}' has no navigation properties pointing to other tables"
                //        | head :: _ -> head

                //    match tables.TryFind trueNavigationProperty.Type with
                //    | Some table -> 
                //        match table with
                //        | Regular(trueDestinationTable) ->
                //            ManyToManyWithJoinTable {
                //                Name = RelationName (navPropName.ToString());
                //                JoinTable = joinTable;
                //                Destination = EntityName (trueNavigationProperty.Type.ToString());
                //                KeyType = trueDestinationTable.PrimaryKey.Type;
                //                TargetTable = trueDestinationTable;
                //            } |> List.singleton
                //        | _ -> failwith $"Destination table '{trueNavigationProperty.Type}', for origin table '{table.Name}' and origin destination '{navPropName}' is not a regular table (debug: 1)"
                //    | None -> 
                //        let availableTables = tables.Keys |> Seq.map (fun k -> k.ToString()) |> String.concat ", "
                //        failwith $"Table '{trueNavigationProperty.Type}', required for {table.Name}, not found in tables map for join table relation. Available tables: {availableTables}"
                | Join(joinTable), Collection(thisNavProp), Single(thatNavProp) ->
                    // Collection navigation property pointing to a join table (default case for a join table)
                    // Here, every navigation property of the join table must be directly mapped as a ManyToManyWithJoinTable relation

                    //let trueNavigationProperty = 
                    //    let filteredNavProps = 
                    //        joinTable.Properties
                    //        |> List.choose (function | Navigation(nav) -> Some nav | _ -> None)
                    //        |> List.filter (fun nav -> nav.Type <> table.Name)
                    //    match filteredNavProps with
                    //    | [] -> failwith $"Join table '{joinTable.Name}' has no navigation properties pointing to other tables"
                    //    | head :: _ -> head

                    //match tables.TryFind trueNavigationProperty.Type with
                    //| Some table -> 
                    //    match table with
                    //    | IsRegularTable(trueDestinationTable) ->
                    //        ManyToManyWithJoinTable {
                    //            Name = RelationName (navPropName.ToString());
                    //            JoinTable = joinTable;
                    //            Destination = EntityName (trueNavigationProperty.Type.ToString());
                    //            KeyType = trueDestinationTable.PrimaryKey.Type;
                    //            TargetTable = trueDestinationTable;
                    //        }
                    //    | _ -> failwith $"Destination table '{trueNavigationProperty.Type}', for origin table '{table.Name}' and origin destination '{navPropName}' is not a regular table (debug: 2)"
                    //| None -> 
                    //    let availableTables = tables.Keys |> Seq.map (fun k -> k.ToString()) |> String.concat ", "
                    //    failwith $"Table '{trueNavigationProperty.Type}', required for {table.Name}, not found in tables map for second join table relation. Available tables: {availableTables}"

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
                                    Name = RelationName (nav.Name.ToString());
                                    KeyType = destination.PrimaryKey.Type;
                                    NavProp = thisNavProp;
                                    JoinTableNavProp = nav;
                                    JoinTableBackwardsNavProp = thatNavProp;
                                    SourceTable = table;
                                    JoinTable = joinTable;
                                    TargetTable = destination;
                                    Destination = EntityName (nav.Type.ToString());
                                    IsNullable = thisNavProp.IsNullable;
                                }
                            | _ -> failwith $"Destination table '{nav.Type}', for origin table '{table.Name}' and origin destination '{navPropName}' is not a regular table (debug: 2)")
                    relations
                | Regular(regularTable), Collection(thisNavProp), Collection(thatNavProp) when not repeats ->
                    // Many to many relation without join table (collection both sides)
                    ManyToMany {
                        Name = RelationName (navPropName.ToString());
                        KeyType = regularTable.PrimaryKey.Type;
                        NavProp = thisNavProp;
                        BackwardsNavProp = thatNavProp;
                        Destination = EntityName (navPropName.ToString());
                        SourceTable = table;
                        TargetTable = regularTable;
                    } |> List.singleton
                | _ -> 
                    failwith 
                        $$"""
                            Default case should not be reached:
                            repeats = {{repeats}},
                            IsJoinTable = {{match otherTable with | Join(_) -> true | _ -> false}},
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
