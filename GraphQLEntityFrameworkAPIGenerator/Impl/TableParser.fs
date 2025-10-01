namespace GraphQLEntityFrameworkAPIGenerator.Impl

open GraphQLEntityFrameworkAPIGenerator.Interfaces
open GraphQLEntityFrameworkAPIGenerator.Types
open System.Text.RegularExpressions

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

            let hasMultipleKeyAttributes = 
                System.Text.RegularExpressions.Regex.Matches(fileContent, @"\[Key\]")
                |> Seq.length
                |> (<) 1

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

            let mapIdType (typeStr: string) : IdType =
                match typeStr.ToLower() with
                | "int" -> IdType.Int
                | "byte" -> IdType.Byte
                | "string" -> IdType.String
                | "guid" -> IdType.Guid
                | "short" -> IdType.Short
                | "bool" -> IdType.Bool
                | "float" -> IdType.Float
                | _ -> failwith $"Unknown ID type: {typeStr}"

            let parseProperties (content: string) : Property list =
                let pattern  = @"((?:\[.*?\]\s*\n*)*)(public (virtual )?(.*?) (.*?) { get; set; })"
        
                // Match groups
                // $1 = Attributes
                // $2 = Entire property
                // $3 = Virtual keyword
                // $4 = Type
                // $5 = Name

                let matches = Regex.Matches(content, pattern);

                let properties : Property list =
                    matches
                    |> Seq.collect (fun match' ->
                        let attributesStr = match'.Groups.[1].Value.Trim()

                        let propName = match'.Groups.[5].Value.Trim();
                        let columnName = 
                            let columnStr = Regex.Match(attributesStr, @"\[Column\(""(.*?)""\)\]").Groups.[1].Value.Trim()
                            if columnStr.Length > 0 then 
                                columnStr 
                            else 
                                propName

                        if ignoredProperties.ContainsKey(tableName) && ignoredProperties[tableName] |> List.exists (fun x -> x = propName) then
                            []
                        else
                        
                        let typeStr = match'.Groups.[4].Value.Trim()
                        let cleanType = typeStr.Replace("?", "").Replace("<", "").Replace(">", "").Replace("ICollection", "").Trim()
                        
                        let hasVirtualKeyword = match'.Groups.[3].Value.Trim() <> ""
                        let hasKeyAttribute = attributesStr.Contains("[Key]")
                        let isNullable = typeStr.Contains("?")
                        let isCollection = typeStr.Contains("ICollection")

                        let isPrimaryKey = 
                            match hasMultipleKeyAttributes with
                                | false -> 
                                    hasKeyAttribute
                                | true -> // Use heuristic here to detrermine if it's a primary key or not
                                    propName.ToLower().Trim() = "id" 
                                    || propName.ToLower().Trim() = tableName.ToString().ToLower().Trim() + "id" 
                                    || propName.ToLower().Trim() = tableName.Pluralize().ToString().ToLower().Trim() + "id"   

                        let isForeignKey =
                            matches
                            |> Seq.exists (fun m -> 
                                let containsForeignKeyAttribute = m.Groups.[1].Value.Trim().ToString().Contains($"[ForeignKey(\"{propName}\")]")
                                let containsICollection = m.Groups.[4].Value.Trim().ToString().Contains("ICollection")
                                
                                containsForeignKeyAttribute && not containsICollection)

                        let isNavigationProperty = hasVirtualKeyword && not isPrimaryKey && not isForeignKey
                        let isPrimitiveProperty = not hasVirtualKeyword && not isPrimaryKey && not isForeignKey

                        if isPrimaryKey && isForeignKey then
                            let primaryKey = PrimaryKey { Type = mapIdType cleanType; PropName = PropName propName; ColumnName = ColumnName columnName; IsNullable = isNullable };
                            let foreignKey = 
                                let correspondingNavPropName =
                                    matches
                                    |> Seq.filter (fun m -> m.Groups.[1].Value.Trim().ToString().Contains $"[ForeignKey(\"{propName}\")]")
                                    |> Seq.map (fun m -> m.Groups.[5].Value.Trim().ToString())
                                    |> Seq.tryHead

                                if correspondingNavPropName.IsNone then
                                    failwith $"No corresponding nav prop name for {propName} foreign key"
                                else
                                    ForeignKey { Type = mapIdType cleanType; PropName = PropName propName; ColumnName = ColumnName columnName; IsNullable = isNullable; NavPropName = PropName correspondingNavPropName.Value }
                            [primaryKey; foreignKey]
                        elif isPrimaryKey then
                            PrimaryKey { Type = mapIdType cleanType; PropName = PropName propName; ColumnName = ColumnName columnName; IsNullable = isNullable }
                            |> List.singleton
                        elif isForeignKey then
                            let correspondingNavPropName =
                                matches
                                |> Seq.filter (fun m -> m.Groups.[1].Value.Trim().ToString().Contains $"[ForeignKey(\"{propName}\")]")
                                |> Seq.map (fun m -> m.Groups.[5].Value.Trim().ToString())
                                |> Seq.tryHead

                            if correspondingNavPropName.IsNone then
                                failwith $"No corresponding nav prop name for {propName} foreign key"
                            else
                                ForeignKey { Type = mapIdType cleanType; PropName = PropName propName; ColumnName = ColumnName columnName; IsNullable = isNullable; NavPropName = PropName correspondingNavPropName.Value }
                            |> List.singleton
                        elif isNavigationProperty then
                            let inverseName = // Get from [InverseProperty("...")]
                                System.Text.RegularExpressions.Regex.Match(attributesStr, @"\[InverseProperty\(""(.*?)""\)\]")
                                |> fun m -> m.Groups.[1].Value.ToString()

                            if inverseName = "" then
                                failwith $"No inverse name for {propName} navigation property"
                            else

                            if isCollection then
                                Navigation (Collection { Type = TableName cleanType; PropName = PropName propName; ColumnName = ColumnName columnName; IsNullable = isNullable; InverseName = PropName inverseName })
                                |> List.singleton
                            else
                                let correspondingForeignKeyName = 
                                    System.Text.RegularExpressions.Regex.Match(attributesStr, @"\[ForeignKey\(""(.*?)""\)\]")
                                    |> (fun m -> m.Groups.[1].Value.ToString())

                                if correspondingForeignKeyName = "" then
                                    failwith $"No corresponding foreign key name for {propName} single navigation property"
                                else
                                    Navigation (Single { Type = TableName cleanType; PropName = PropName propName; ColumnName = ColumnName columnName; IsNullable = isNullable; FKeyName = PropName correspondingForeignKeyName; InverseName = PropName inverseName })
                                |> List.singleton
                        elif isPrimitiveProperty then
                            Primitive { Type = mapPrimitiveType cleanType; PropName = PropName propName; ColumnName = ColumnName columnName; IsNullable = isNullable }
                            |> List.singleton
                        else
                            failwith $"Property '{propName}' in table '{tableName}' was not able to be classified")
                    |> List.ofSeq
                    |> (fun props -> // Final validation
                        let primaryKeys = 
                            props
                            |> Seq.choose (fun property ->
                                match property with
                                | PrimaryKey(p) -> Some p
                                | _ -> None)
                            |> Seq.toList

                        if primaryKeys.Length > 1 then
                            failwith $"Table '{tableName}' has more than 1 primary key"
                        else

                        props)
                    |> List.ofSeq

                properties

            let properties = parseProperties fileContent

            // If it's a keyless entity, create a View table with only primitive properties
            if isKeyless then
                let primitiveProps = 
                    properties
                    |> List.choose (fun property ->
                        match property with
                        | Primitive(p) -> Some p
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
                        | Primitive(p) -> p.PropName.ToString() <> "Index"
                        | _ -> false)
                    |> Seq.isEmpty

                let isJoinTable : bool = (not hasPrimaryKey) || (hasOnlyTwoNavigationProperties && hasOnlyTwoForeignKeys && hasNoOtherPropertiesOtherThanIndexAndPrimaryKey)
            
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
                    let primaryKey = properties |> Seq.choose (fun property -> match property with | PrimaryKey(p) -> Some p | _ -> None) |> Seq.tryHead
                    let foreignKeys = properties |> Seq.choose (fun property -> match property with | ForeignKey(p) -> Some p | _ -> None) |> Seq.toList
                    let navigationProperties = properties |> Seq.choose (fun property -> match property with | Navigation(p) -> Some p | _ -> None) |> Seq.toList
                    let primitiveProperties = properties |> Seq.choose (fun property -> match property with | Primitive(p) -> Some p | _ -> None) |> Seq.toList

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