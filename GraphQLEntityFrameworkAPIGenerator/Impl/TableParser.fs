namespace GraphQLEntityFrameworkAPIGenerator.Impl

open GraphQLEntityFrameworkAPIGenerator.Interfaces
open GraphQLEntityFrameworkAPIGenerator.Types

// File example:

// using System;
// using System.Collections.Generic;

// namespace WP.Cooking.GESE.WebAPI.Models;

// public partial class Board
// {
//     [Key]
//     public Guid BoardId { get; set; }

//     public string Code { get; set; } = null!;

//     public string Description { get; set; } = null!;

//     public byte Status { get; set; }

//     public string Owner { get; set; } = null!;

//     public DateTime Timestamp { get; set; }

//     public Guid RevisionGroup { get; set; }

//     public int Revision { get; set; }

//     public byte TableTarget { get; set; }

//     public string? Notes { get; set; }

//     public Guid? LoadConfigurationId { get; set; }

//     public Guid? LowLevelInputConfigurationId { get; set; }

//     public Guid? GenericInputConfigurationId { get; set; }

//     public Guid? CrossLoadConfigurationId { get; set; }

//     public Guid? ACUExpansionBoardConfigurationId { get; set; }

//     public byte NodeAddress { get; set; }

//     public long StartPosition { get; set; }

//     public int Size { get; set; }

//     public Guid? DefaultPinConfigurationId { get; set; }

//     public virtual ACUExpansionBoardConfiguration? ACUExpansionBoardConfiguration { get; set; }

//     public virtual ICollection<ACUExpansionBoardConfigurations_Board> ACUExpansionBoardConfigurations_Boards { get; set; } = new List<ACUExpansionBoardConfigurations_Board>();

//     public virtual CrossLoadConfiguration? CrossLoadConfiguration { get; set; }

//     public virtual DefaultPinConfiguration? DefaultPinConfiguration { get; set; }

//     public virtual GenericInputConfiguration? GenericInputConfiguration { get; set; }

//     public virtual LoadConfiguration? LoadConfiguration { get; set; }

//     public virtual LowLevelInputConfiguration? LowLevelInputConfiguration { get; set; }

//     public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

//     public virtual TableTarget TableTargetNavigation { get; set; } = null!;
// }

type TableParser() =
    interface ITableParser with
        member _.ParseTable(fileContent: string) : Table =
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

                let matches = System.Text.RegularExpressions.Regex.Matches(content, pattern);

                let properties : Property list =
                    matches
                    |> Seq.choose (fun match' ->
                        let attributesStr = match'.Groups.[1].Value.Trim()
                        let typeStr = match'.Groups.[4].Value.Trim()
                        let propName = match'.Groups.[5].Value.Trim()
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
                            match hasMultipleKeyAttributes with
                            | false -> 
                                matches
                                |> Seq.exists (fun m -> m.Groups.[1].Value.Trim().ToString().Contains $"[ForeignKey(\"{propName}\")]")
                            | true ->
                                hasKeyAttribute && propName.ToLower().Trim() <> "index"

                        let isNavigationProperty = hasVirtualKeyword && not isPrimaryKey && not isForeignKey
                        let isPrimitiveProperty = not hasVirtualKeyword && not isPrimaryKey && not isForeignKey

                        let foreignKeyAttributeMatch = System.Text.RegularExpressions.Regex.Match(attributesStr, @"\[ForeignKey\(""(.*?)""\)\]")
                        let foreignKeyValue = foreignKeyAttributeMatch.Groups.[1].Value.Trim()
                        let existsCorrespondingForeignKeyWithKeyAttribute =
                            matches
                            |> Seq.exists (fun m -> 
                                m.Groups.[1].Value.Trim().ToString().Contains("[Key]")
                                && m.Groups.[5].Value.Trim().ToString().ToLower() = foreignKeyValue.ToLower())

                        if hasMultipleKeyAttributes && isPrimitiveProperty then
                            None
                        elif hasMultipleKeyAttributes && isNavigationProperty && not existsCorrespondingForeignKeyWithKeyAttribute then
                            None
                        elif isPrimaryKey then
                            Some (PrimaryKey { Type = mapIdType cleanType; Name = propName; IsNullable = isNullable })
                        elif isForeignKey then
                            Some (ForeignKey { Type = mapIdType cleanType; Name = propName; IsNullable = isNullable })
                        elif isNavigationProperty then
                            Some (Navigation { Type = TableName cleanType; Name = propName; IsNullable = isNullable; IsCollection = isCollection })
                        elif isPrimitiveProperty then
                            Some (Primitive { Type = mapPrimitiveType cleanType; Name = propName; IsNullable = isNullable })
                        else
                            failwith $"Property '{propName}' in table '{tableName}' was not able to be classified")
                    |> List.ofSeq

                let primaryKeys = 
                    properties
                    |> Seq.choose (fun property ->
                        match property with
                        | PrimaryKey(p) -> Some p
                        | _ -> None)
                    |> Seq.toList
                let foreignKeys = 
                    properties
                    |> Seq.choose (fun property ->
                        match property with
                        | ForeignKey(p) -> Some p
                        | _ -> None)
                    |> Seq.toList
                let navigationPropertiesNotCollection = 
                    properties
                    |> Seq.choose (fun property ->
                        match property with
                        | Navigation(p) -> Some p
                        | _ -> None)
                    |> Seq.filter (fun np -> not np.IsCollection)
                    |> Seq.toList

                // Validations

                if primaryKeys.Length > 1 then
                    failwith $"Table '{tableName}' has more than 1 primary key"
                if foreignKeys.Length <> navigationPropertiesNotCollection.Length then
                    failwith $"Table '{tableName}' has a different number of foreign keys and navigation properties"
                else

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
                        | Primitive(p) -> p.Name <> "Index"
                        | _ -> false)
                    |> Seq.isEmpty

                let isJoinTable : bool = (not hasPrimaryKey) || (hasOnlyTwoNavigationProperties && hasOnlyTwoForeignKeys && hasNoOtherPropertiesOtherThanIndexAndPrimaryKey)
            
                if isJoinTable then
                    let primaryKey = properties |> Seq.choose (fun property -> match property with | PrimaryKey(p) -> Some p | _ -> None) |> Seq.tryHead
                    let foreignKeysList = properties |> Seq.choose (fun property -> match property with | ForeignKey(p) -> Some p | _ -> None) |> Seq.toList
                    let navigationPropertiesList = properties |> Seq.choose (fun property -> match property with | Navigation(p) -> Some p | _ -> None) |> Seq.toList

                    let (foreignKeyT1, foreignKeyT2) = 
                        match foreignKeysList with
                        | [fk1; fk2] -> (fk1, fk2)
                        | _ -> failwith $"Join table must have exactly 2 foreign keys. isJoinTable: {isJoinTable}, hasPrimaryKey: {hasPrimaryKey}, hasOnlyTwoNavigationProperties: {hasOnlyTwoNavigationProperties}, hasOnlyTwoForeignKeys: {hasOnlyTwoForeignKeys}, hasNoOtherPropertiesOtherThanIndexAndPrimaryKey: {hasNoOtherPropertiesOtherThanIndexAndPrimaryKey}"
                    
                    let (navigationPropertyT1, navigationPropertyT2) = 
                        match navigationPropertiesList with
                        | [np1; np2] -> (np1, np2)
                        | _ -> failwith "Join table must have exactly 2 navigation properties"

                    Join { Name = tableName; PrimaryKey = primaryKey; ForeignKeyT1 = foreignKeyT1; ForeignKeyT2 = foreignKeyT2; NavigationPropertyT1 = navigationPropertyT1; NavigationPropertyT2 = navigationPropertyT2 }
                else
                    let primaryKey = properties |> Seq.choose (fun property -> match property with | PrimaryKey(p) -> Some p | _ -> None) |> Seq.tryHead
                    let foreignKeys = properties |> Seq.choose (fun property -> match property with | ForeignKey(p) -> Some p | _ -> None) |> Seq.toList
                    let navigationProperties = properties |> Seq.choose (fun property -> match property with | Navigation(p) -> Some p | _ -> None) |> Seq.toList
                    let primitiveProperties = properties |> Seq.choose (fun property -> match property with | Primitive(p) -> Some p | _ -> None) |> Seq.toList

                    if primaryKey.IsNone then
                        failwith $"Regular table '{tableName}' does not have a primary key"
                    else

                    Regular { Name = tableName; PrimaryKey = primaryKey.Value; ForeignKeys = foreignKeys; NavigationProperties = navigationProperties; PrimitiveProperties = primitiveProperties }
