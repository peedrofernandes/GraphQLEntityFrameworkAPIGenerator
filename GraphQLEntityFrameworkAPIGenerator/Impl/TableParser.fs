namespace GraphQLEntityFrameworkAPIGenerator.Impl

open GraphQLEntityFrameworkAPIGenerator.Interfaces
open GraphQLEntityFrameworkAPIGenerator.Types
open System.Text.RegularExpressions

type ExtractedData = {
    PropName: string
    ColumnName: string
    Type: string
    IsNullable: bool
    IsCollection: bool
    IsPrimaryKey: bool
    IsForeignKey: bool
    IsNavigationProperty: bool
    IsPrimitiveProperty: bool
    InverseName: string // Exclusive for navigation properties
    CorrespondingForeignKeyNames: string list // Exclusive for single (not collection) navigation properties
}

type TableParser() =
    interface ITableParser with
        member _.ParseTable(ignoredProperties: Map<TableName, string list>, fileContent: string) : Table =
            let parseTableName (content: string) : TableName =
                let pattern = @"public\s+partial\s+class\s+(\w+)"
                let match' = System.Text.RegularExpressions.Regex.Match(content, pattern)
                if match'.Success then
                    TableName match'.Groups.[1].Value
                else
                    failwith "Could not find class name"
            
            let isKeylessEntity (content: string) : bool =
                content.Contains("[Keyless]")

            let tableName = parseTableName fileContent
            
            let isKeyless = isKeylessEntity fileContent

            //let hasMultipleKeyAttributes = 
            //    System.Text.RegularExpressions.Regex.Matches(fileContent, @"\[Key\]")
            //    |> Seq.length
            //    |> (<) 1

            let mapPrimitiveType (typeStr: string) : PrimitiveType =
                match typeStr.ToLower() with
                | "int" -> PrimitiveType.Int
                | "byte" -> PrimitiveType.Byte
                | "byte[]" -> PrimitiveType.ByteArr
                | "string" -> PrimitiveType.String
                | "guid" -> PrimitiveType.Guid
                | "decimal" -> PrimitiveType.Decimal
                | "double" -> PrimitiveType.Double
                | "float" -> PrimitiveType.Float
                | "long" -> PrimitiveType.Long
                | "short" -> PrimitiveType.Short
                | "bool" -> PrimitiveType.Bool
                | "ushort" -> PrimitiveType.Ushort
                | "uint" -> PrimitiveType.Uint
                | "ulong" -> PrimitiveType.Ulong
                | "sbyte" -> PrimitiveType.Sbyte
                | "char" -> PrimitiveType.Char
                | "datetime" -> PrimitiveType.DateTime
                | "datetimeoffset" -> PrimitiveType.DateTimeOffset
                | "timespan" -> PrimitiveType.TimeSpan
                | _ -> failwith $"Unknown primitive type: {typeStr}"

            let mapIdType (typeStr: string) : SingleIdType =
                match typeStr.ToLower() with
                | "int" -> SingleIdType.Int
                | "byte" -> SingleIdType.Byte
                | "string" -> SingleIdType.String
                | "guid" -> SingleIdType.Guid
                | "short" -> SingleIdType.Short
                | "bool" -> SingleIdType.Bool
                | "float" -> SingleIdType.Float
                | _ -> failwith $"Unknown ID type: {typeStr}"

            let parseProperties (content: string) : Property list =
                let pattern  = @"((?:\[.*?\]\s*\n*)*)(public (virtual )?(.*?) (.*?) { get; set; })"
        
                // Match groups
                // $1 = Attributes
                // $2 = Entire property
                // $3 = Virtual keyword
                // $4 = Type
                // $5 = Name

                let extractDataFromMatches (matches : MatchCollection) : ExtractedData list =
                    let extractDataFromMatch (matches : MatchCollection, match': Match) : ExtractedData =
                        let attributesStr = match'.Groups.[1].Value.Trim()
                        let propName = match'.Groups.[5].Value.Trim();
                        let columnName = 
                                let columnStr = Regex.Match(attributesStr, @"\[Column\(""(.*?)""\)\]").Groups.[1].Value.Trim()
                                if columnStr.Length > 0 then 
                                    columnStr 
                                else 
                                    propName

                        let typeStr = match'.Groups.[4].Value.Trim()
                        let cleanType = typeStr.Replace("?", "").Replace("<", "").Replace(">", "").Replace("ICollection", "").Trim()

                        let hasVirtualKeyword = match'.Groups.[3].Value.Trim() <> ""
                        let hasKeyAttribute = attributesStr.Contains("[Key]")
                        let isNullable = typeStr.Contains("?")
                        let isCollection = typeStr.Contains("ICollection")

                        let isPrimaryKey = hasKeyAttribute

                        let isForeignKey =
                            matches
                            |> Seq.exists (fun m ->
                                let foreignKeyAttributeMatch = Regex.Match(m.Groups.[1].Value.Trim().ToString(), $@"\[ForeignKey\(""(.*?)""\)\]")
                                let foreignKeyInnerValue = foreignKeyAttributeMatch.Groups.[1].Value.Trim().ToString()
                                let containsForeignKeyAttributeWithCorrespondingValue = 
                                    if foreignKeyInnerValue.Contains(",") then 
                                        foreignKeyInnerValue.Split(", ")
                                        |> Seq.exists (fun ls -> ls = columnName)
                                    else
                                        foreignKeyInnerValue = columnName
                                let containsICollection = m.Groups.[4].Value.Trim().ToString().Contains("ICollection")
                                containsForeignKeyAttributeWithCorrespondingValue && not containsICollection)

                        let isNavigationProperty = hasVirtualKeyword && not isPrimaryKey && not isForeignKey
                        let isPrimitiveProperty = not hasVirtualKeyword && not isPrimaryKey && not isForeignKey

                        let inverseName = // Get from [InverseProperty("...")]
                            System.Text.RegularExpressions.Regex.Match(attributesStr, @"\[InverseProperty\(""(.*?)""\)\]")
                            |> fun m -> m.Groups.[1].Value.ToString()

                        let correspondingForeignKeyNames : string list = // Get from [ForeignKey("[f1]", "[f2]", "...")]
                            let foreignKeyAttributeInsideParenthesis = Regex.Match(attributesStr, @"\[ForeignKey\(""(.*)""\)\]").Groups.[1].Value.ToString()
                            let foreignKeyAttributeInternalValues = 
                                Regex.Matches(foreignKeyAttributeInsideParenthesis, "\"?(\w+)[\",]?")
                                |> Seq.map (fun x -> x.Groups.[1].Value)
                                |> List.ofSeq
                            foreignKeyAttributeInternalValues

                        {
                            PropName = propName
                            ColumnName = columnName
                            Type = cleanType
                            
                            IsNullable = isNullable
                            IsCollection = isCollection
                            IsPrimaryKey = isPrimaryKey
                            IsForeignKey = isForeignKey
                            IsNavigationProperty = isNavigationProperty
                            IsPrimitiveProperty = isPrimitiveProperty
                            
                            InverseName = inverseName
                            CorrespondingForeignKeyNames = correspondingForeignKeyNames
                        }

                    matches |> Seq.map (fun m -> extractDataFromMatch(matches, m)) |> List.ofSeq

                let matches = Regex.Matches(content, pattern);

                let extractedData = 
                    extractDataFromMatches matches
                    |> List.filter (fun m -> (not (ignoredProperties.ContainsKey(tableName)) || (not (ignoredProperties[tableName] |> List.exists (fun n -> n = m.PropName.ToString() || n = m.ColumnName.ToString())))))

                let primaryKeys : SinglePrimaryKeyProperty list =
                    extractedData
                    |> List.filter (fun m -> m.IsPrimaryKey)
                    |> List.map (fun m -> { Type = mapIdType m.Type; PropName = PropName m.PropName; ColumnName = ColumnName m.ColumnName; })

                let finalGroupedPrimaryKey : PrimaryKeyProperty option =
                    primaryKeys
                    |> (fun pks ->
                        if pks.Length = 0 then
                            None
                        elif pks.Length = 1 then
                            Some (PrimaryKeyProperty.Single pks.Head)
                        else
                            Some (PrimaryKeyProperty.Composite { Keys = pks }))

                let foreignKeys : SingleForeignKeyProperty list =
                    extractedData
                    |> List.filter (fun m -> m.IsForeignKey)
                    |> List.map (fun m -> { Type = mapIdType m.Type; PropName = PropName m.PropName; ColumnName = ColumnName m.ColumnName; IsNullable = m.IsNullable })

                let navigationProperties : NavigationProperty list =
                    extractedData
                    |> List.filter (fun m -> m.IsNavigationProperty)
                    |> List.map (fun m -> 
                        if m.InverseName = "" then
                            failwith $"No inverse name for {m.PropName} navigation property"
                        else
                        
                        if m.IsCollection then
                            NavigationProperty.Collection { Type = TableName m.Type; PropName = PropName m.PropName; ColumnName = ColumnName m.ColumnName; IsNullable = m.IsNullable; InverseName = PropName m.InverseName }
                        else

                        if m.CorrespondingForeignKeyNames.Length = 0 then
                            // If this is a navigation property without at least one corresponding foreign key name, then the foreign key is the primary key itself.
                            // (very rare case - Only available for PilotTypes -> MultiDriverPilotTypes and ReadTypes -> MultiInputReadTypes)
                            let foreignKey : ForeignKeyProperty =
                                let fk = 
                                    match finalGroupedPrimaryKey with
                                    | Some pk ->
                                        match pk with
                                        | PrimaryKeyProperty.Single s -> ForeignKeyProperty.Single { Type = s.Type; PropName = s.PropName; ColumnName = s.ColumnName; IsNullable = false }
                                        | PrimaryKeyProperty.Composite c -> failwith $"The {m.PropName} navigation property on table '{tableName}' has no [ForeignKey] attribute. The default behavior on this case is to assign the primary key itself as the foreign key, but it seems like the primary key of this table is composite (this case is unhandled)."
                                    | _ -> failwith $"The {m.PropName} navigation property on table '{tableName}' has no [ForeignKey] attribute. The default behavior on this case is to assign the primary key itself as the foreign key, but it seems like the primary key of this table is composite (this case is unhandled)."

                                fk

                            NavigationProperty.Single { Type = TableName m.Type; PropName = PropName m.PropName; ColumnName = ColumnName m.ColumnName; IsNullable = m.IsNullable; InverseName = PropName m.InverseName; ForeignKey = foreignKey }
                        else

                        let foreignKey : ForeignKeyProperty =
                            let correspondingSingleForeignKeys =
                                foreignKeys
                                |> List.filter (fun fk -> 
                                    m.CorrespondingForeignKeyNames 
                                    |> List.exists (fun n -> n = fk.ColumnName.ToString()))
                                |> List.ofSeq

                            if correspondingSingleForeignKeys.Length = 0 then
                                failwith $"""No corresponding foreign keys were found for names {m.CorrespondingForeignKeyNames |> String.concat ", "} for table {tableName}"""
                            elif correspondingSingleForeignKeys.Length = 1 then
                                ForeignKeyProperty.Single correspondingSingleForeignKeys.Head
                            else
                                ForeignKeyProperty.Composite { Keys = correspondingSingleForeignKeys }

                        NavigationProperty.Single { Type = TableName m.Type; PropName = PropName m.PropName; ColumnName = ColumnName m.ColumnName; IsNullable = m.IsNullable; InverseName = PropName m.InverseName; ForeignKey = foreignKey }
                    )

                let primitiveProperties : PrimitiveProperty list =
                    extractedData
                    |> List.filter (fun m -> m.IsPrimitiveProperty)
                    |> List.map (fun m -> 
                        { Type = mapPrimitiveType m.Type; PropName = PropName m.PropName; ColumnName = ColumnName m.ColumnName; IsNullable = m.IsNullable })
                
                let finalGroupedForeignKeys : ForeignKeyProperty list =
                    navigationProperties
                    |> List.choose (fun n -> 
                        match n with
                        | NavigationProperty.Single s -> Some s.ForeignKey
                        | NavigationProperty.Collection _ -> None)

                let properties : Property list = 
                    let pk =
                        match finalGroupedPrimaryKey with
                        | Some pk -> [Property.PrimaryKey pk]
                        | None -> []

                    pk
                    |> List.append (primitiveProperties |> List.map (fun x -> Property.Primitive x))
                    |> List.append (navigationProperties |> List.map (fun x -> Property.Navigation x))
                    |> List.append (finalGroupedForeignKeys |> List.map (fun x -> Property.ForeignKey x))

                properties

            let properties = parseProperties fileContent

            // If it's a keyless entity, create a View table with only primitive properties
            if isKeyless then
                let primitiveProps = 
                    properties
                    |> List.choose (fun property ->
                        match property with
                        | Property.Primitive(p) -> Some p
                        | _ -> None)
                View { Name = tableName; PrimitiveProperties = primitiveProps }
            else

            let hasPrimaryKey =
                properties
                |> Seq.choose (fun property ->
                    match property with
                    | PrimaryKey(p) -> Some p
                    | _ -> None)
                |> Seq.isEmpty
                |> not

            let hasOnlyTwoNavigationProperties = 
                properties
                |> Seq.choose (fun property ->
                    match property with
                    | Navigation(p) -> Some p
                    | _ -> None)
                |> Seq.length = 2
            let hasOnlyTwoForeignKeys =
                properties
                |> Seq.choose (fun property ->
                    match property with
                    | ForeignKey(p) -> Some p
                    | _ -> None)
                |> Seq.length = 2
            let hasNoOtherPropertiesOtherThanIndexAndPrimaryKey = 
                properties
                |> Seq.filter (fun property ->
                    match property with
                    | Property.Primitive(p) -> p.PropName.ToString() <> "Index"
                    | _ -> false)
                |> Seq.isEmpty

            let isJoinTable : bool = tableName.ToString().Contains("_") || (hasOnlyTwoNavigationProperties && hasOnlyTwoForeignKeys && hasNoOtherPropertiesOtherThanIndexAndPrimaryKey)

            if isJoinTable then
                let primaryKey = properties |> Seq.choose (fun property -> match property with | PrimaryKey(p) -> Some p | _ -> None) |> Seq.tryHead
                let foreignKeys = properties |> Seq.choose (fun property -> match property with | ForeignKey(p) -> Some p | _ -> None) |> Seq.toList
                let navigationProperties = properties |> Seq.choose (fun property -> match property with | Navigation(p) -> Some p | _ -> None) |> Seq.toList

                Join {
                    Name = tableName;
                    PrimaryKey = primaryKey;
                    ForeignKeys = foreignKeys;
                    NavigationProperties = navigationProperties;
                }
            else
                let primaryKey = properties |> Seq.choose (fun property -> match property with | Property.PrimaryKey(p) -> Some p | _ -> None) |> Seq.tryHead
                let foreignKeys = properties |> Seq.choose (fun property -> match property with | Property.ForeignKey(p) -> Some p | _ -> None) |> Seq.toList
                let navigationProperties = properties |> Seq.choose (fun property -> match property with | Property.Navigation(p) -> Some p | _ -> None) |> Seq.toList
                let primitiveProperties = properties |> Seq.choose (fun property -> match property with | Property.Primitive(p) -> Some p | _ -> None) |> Seq.toList

                if primaryKey.IsNone then
                    failwith $"Regular table '{tableName}' does not have a primary key"
                else
                    
                Regular {
                    Name = tableName;
                    PrimaryKey = primaryKey.Value;
                    ForeignKeys = foreignKeys;
                    NavigationProperties = navigationProperties;
                    PrimitiveProperties = primitiveProperties;
                }