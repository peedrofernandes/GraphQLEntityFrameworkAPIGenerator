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
                // Pattern to match properties with optional attributes (including [Key])
                // This pattern captures: any attributes (including [Key]), property type, and property name
                // (?:\s*\[[^\]]+\]\s*)* matches zero or more attributes like [Key], [Column("...")], etc.
                let propertyWithAttributePattern = @"((?:\s*\[[^\]]+\]\s*)*)\s*public\s+(?!virtual\s)([?\w<>,\s]+)\s+(\w+)\s*\{\s*get;\s*set;\s*\}"
                // Pattern for virtual navigation properties (with optional attributes)
                let navigationPattern = @"(?:\s*\[[^\]]+\]\s*)*\s*public\s+virtual\s+([?\w<>,\s]+)\s+(\w+)\s*\{\s*get;\s*set;\s*\}"
                
                let navigationProperties = System.Text.RegularExpressions.Regex.Matches(content, navigationPattern)
                let properties = System.Text.RegularExpressions.Regex.Matches(content, propertyWithAttributePattern)

                let hasMultipleKeyAttributes = 
                    System.Text.RegularExpressions.Regex.Matches(content, @"\[Key\]")
                    |> Seq.length
                    |> (>) 1
                
                let regularProps = 
                    [for match' in properties do
                        let attributesStr = match'.Groups.[1].Value.Trim()
                        let typeStr = match'.Groups.[2].Value.Trim()
                        let propName = match'.Groups.[3].Value.Trim()
                        let isNullable = typeStr.Contains("?")
                        let cleanType = typeStr.Replace("?", "").Trim()
                        
                        let isPrimaryKey = 
                            match hasMultipleKeyAttributes with
                            | true -> 
                                propName.ToLower().Trim() = "id"
                                    || propName.ToLower().Trim() = tableName.ToString().ToLower().Trim() + "id"
                                    || propName.ToLower().Trim() = tableName.Pluralize().ToString().ToLower().Trim() + "id"
                            | false -> attributesStr.Contains("[Key]")
                        
                        let isForeignKey = propName.ToLower().Trim().EndsWith("id") && not isPrimaryKey
                        
                        if isPrimaryKey then
                            PrimaryKey { 
                                Type = mapIdType cleanType
                                Name = propName
                                IsNullable = isNullable 
                            }
                        elif isForeignKey then
                            ForeignKey { 
                                Type = mapIdType cleanType
                                Name = propName
                                IsNullable = isNullable 
                            }
                        else
                            Primitive { 
                                Type = mapPrimitiveType cleanType
                                Name = propName
                                IsNullable = isNullable 
                            }
                    ]
                
                let navProps = 
                    [for match' in navigationProperties do
                        let typeStr = match'.Groups.[1].Value.Trim()
                        let propName = match'.Groups.[2].Value.Trim()
                        let isNullable = typeStr.Contains("?")
                        let cleanType = typeStr.Replace("?", "").Trim()
                        
                        // Check if it's a collection type
                        let isCollection = cleanType.StartsWith("ICollection<") || cleanType.StartsWith("List<")
                        let actualType = 
                            if isCollection then
                                // Extract type from ICollection<Type> or List<Type>
                                let genericPattern = @"(?:ICollection|List)<(\w+)>"
                                let genericMatch = System.Text.RegularExpressions.Regex.Match(cleanType, genericPattern)
                                if genericMatch.Success then
                                    genericMatch.Groups.[1].Value
                                else
                                    cleanType
                            else
                                cleanType
                        
                        Navigation { 
                            Type = TableName actualType
                            Name = propName
                            IsNullable = isNullable
                            IsCollection = isCollection 
                        }
                    ]
                
                regularProps @ navProps

            // If it's a keyless entity, create a View table with only primitive properties
            if isKeyless then
                let properties = parseProperties fileContent
                let primitiveProps = 
                    properties
                    |> List.choose (fun property ->
                        match property with
                        | Primitive(p) -> Some p
                        | _ -> None)
                View { Name = tableName; Properties = primitiveProps }
            else
                let properties = parseProperties fileContent

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

                let isJoinTable : bool = not hasPrimaryKey || hasOnlyTwoNavigationProperties && hasOnlyTwoForeignKeys && hasNoOtherPropertiesOtherThanIndexAndPrimaryKey
            
                if isJoinTable then
                    Join { Name = tableName; Properties = properties }
                else
                    Regular { Name = tableName; Properties = properties }
