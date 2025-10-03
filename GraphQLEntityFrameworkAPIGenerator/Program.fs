module GraphQLEntityFrameworkAPIGenerator.Program

open System.IO
open GraphQLEntityFrameworkAPIGenerator.Interfaces
open GraphQLEntityFrameworkAPIGenerator.Impl
open GraphQLEntityFrameworkAPIGenerator.Types
open Microsoft.Extensions.Configuration

let processEntityFiles (category: Category) (sourcePath: string) (destinationPath: string) =
    // Initialize parsers and generators
    let tableParser = TableParser() :> ITableParser
    let relationParser = RelationParser() :> IRelationParser
    let contentGenerator = ContentGenerator(category) :> IContentGenerator
    
    try
        // Validate source directory exists
        if not (Directory.Exists sourcePath) then
            failwith $"Source directory does not exist: {sourcePath}"
        
        // Create destination directory if it doesn't exist
        if not (Directory.Exists destinationPath) then
            Directory.CreateDirectory destinationPath |> ignore
            printfn $"Created destination directory: {destinationPath}"



        let ignoredFiles : string list = 
            let allIgnoredFiles : string list = []

            let categorySpecificIgnoredFiles : string list =
                let cookingIgnoredFiles : string list = [
                    "GESE_CookingContext"
                    "CodeBuilder"
                    "CodeBuilderContainer"
                    "CodeBuilderContainersElement"
                    "CodeBuildersCodeBuilderContainer"
                    "MultiDriverPilotType"
                    "MultiSequencePilotType"
                    "MultiInputReadType"
                    "PrmPilotMultiSequence"
                    "PilotMultiSequenceConfig"
                    "PilotMultiSequenceConfigDetail"
                    "PilotMultiSequenceDetail"
                    "PilotMultiSequenceDetailsStep"
                    "PilotMultiSequenceStep"
                ]
                let refrigerationIgnoredFiles : string list = [
                    "GESE_RefrigerationContext"
                    "FaultSubCode"
                    "FaultCode"
                    "FaultPrioritiesDetail"
                    "FaultPrioritiesConfigurations_FaultPrioritiesDetail"
                    "FaultPrioritiesConfiguration"
                ]
                let dryerIgnoredFiles : string list = [
                    "GESE_DryerContext"
                    "AdditionalRelationshipStatement"
                    "CategoryAdditionalRelationshipXMLConfiguration"
                    "PlatformAdditionalRelationshipsXMLConfiguration"
                ]

                match category with
                    | Cooking -> cookingIgnoredFiles
                    | Refrigeration -> refrigerationIgnoredFiles
                    | Dryer -> dryerIgnoredFiles
                    | _ -> []

            allIgnoredFiles @ categorySpecificIgnoredFiles

        let ignoredProperties : Map<TableName, string list> =
            let allIgnoredProperties : (TableName * string list) list = [
                TableName "Display", [ "HMIExpansionBoardConfigurations"; "HMIExpansionBoardConfigurationsId" ] // Ignored because there's a join table HMIExpansionBoardConfigurations_Display that results in a mapping of the same name.
                TableName "HMIExpansionBoardConfiguration", [ "Displays" ] // Inverse of the above
                TableName "ACUExpansionBoardConfiguration", [ "Boards" ] // Ignored because there's a join table ACUExpansionBoardConfigurations_Board that results in a mapping of the same name.
                TableName "Board", [ "ACUExpansionBoardConfiguration" ] // Inverse of the above
            ]

            let categorySpecificIgnoredProperties : (TableName * string list) list = []

            Map (allIgnoredProperties @ categorySpecificIgnoredProperties)
        
        // Get all .cs files from source directory
        let efModelFiles = 
            Directory.GetFiles(sourcePath, "*.cs", SearchOption.AllDirectories)
            |> Array.filter (fun filePath -> 
                ignoredFiles
                |> List.exists filePath.Contains
                |> not)
            
        if efModelFiles.Length = 0 then
            printfn "No .cs files found in source directory"
            0
        else

        printfn $"Found {efModelFiles.Length} EF Model"

        let mutable fileParseSuccessCount = 0
        let mutable fileParseErrorCount = 0

        // Step 1: Parse all entity files to create Table objects
        let tables = 
            efModelFiles
            |> Seq.choose (fun filePath ->
                try
                    printfn $"Parsing file: {Path.GetFileName filePath}"
                    let fileContent = File.ReadAllText filePath
                    let table = tableParser.ParseTable (ignoredProperties, fileContent)
                    fileParseSuccessCount <- fileParseSuccessCount + 1
                    Some table
                with
                | ex ->
                    printfn $"Error parsing file {Path.GetFileName filePath}: {ex.Message}"
                    fileParseErrorCount <- fileParseErrorCount + 1
                    None)
            |> List.ofSeq
            
        printfn $"Successfully parsed {tables.Length} tables"

        // Step 2: Convert the tables to a map
        let tablesMap =
            tables
            |> List.map (fun t -> t.Name, t)
            |> Map.ofList

        // Step 3: Use RelationParser to create Entity objects
        let entities = relationParser.ParseEntities tablesMap
        printfn $"Generated {entities.Length} entities"
            
        // Step 4: Generate GraphQL type content for each entity and write to files
        let mutable entityParseSuccessCount = 0
        let mutable entityParseErrorCount = 0

        // Remove all files from destination path (except the folder itself)
        if Directory.Exists(destinationPath) then
            //Directory.GetFiles(destinationPath, "*GraphType.cs", SearchOption.AllDirectories)
            //|> Array.iter File.Delete
            Directory.GetFiles(destinationPath, "*GraphType.Generated.cs", SearchOption.AllDirectories)
            |> Array.iter File.Delete

        entities
        |> List.iter (fun entity ->
            try
                let (EntityName entityName) = entity.Name
                let content = contentGenerator.GenerateContent(entity)

                let sourceOutputFileName = $"{entityName}GraphType.cs"
                let sourceOutputPath = Path.Combine(destinationPath, sourceOutputFileName)

                let generatedOutputFileName = $"{entityName}GraphType.Generated.cs"
                let generatedOutputPath = Path.Combine(destinationPath, generatedOutputFileName)
                    
                // Write content to file (overwrite if exists)
                if not (File.Exists(sourceOutputPath)) then
                    File.WriteAllText(sourceOutputPath, content.SourceFile)

                File.WriteAllText(generatedOutputPath, content.GeneratedFile)
                // printfn $"Generated: {outputFileName}"
                entityParseSuccessCount <- entityParseSuccessCount + 1
            with
            | ex ->
                let (EntityName entityName) = entity.Name
                printfn $"Error generating content for entity {entityName}: {ex.Message}"
                entityParseErrorCount <- entityParseErrorCount + 1)
            
        printfn $"\nGeneration complete!"
        printfn $"EF Models result - Total: {efModelFiles.Length}; Success: {fileParseSuccessCount}; Failure: {fileParseErrorCount}"
        printfn $"Entities result - Total: {entities.Length}; Success: {entityParseSuccessCount}; Failure: {entityParseErrorCount}"

        if fileParseSuccessCount < ((tables.Length) / 2) then
            printfn $"A lot of tables were not able to be parsed. Please verify whether you scaffolded the database correctly. This script needs data annotations on EF entities to work properly. It's HIGHLY ENCOURAGED that you use this command: `dotnet ef dbcontext scaffold \"<CONNECTION_STRING_HERE>\" Microsoft.EntityFrameworkCore.SqlServer --output-dir ./Models --data-annotations --force --no-build --use-database-names`"
            
        if (entityParseErrorCount = 0 && fileParseErrorCount = 0) then 0 else 1
            
    with
    | ex ->
        printfn $"Fatal error: {ex.Message}"
        1

[<EntryPoint>]
let main args =
    let getCategoryFromConfig (config: IConfiguration) : Category =
        let categoryString = config.GetValue<string>("CATEGORY")
    
        match categoryString.ToLower() with
        | "cooking" -> Category.Cooking
        | "cook" -> Category.Cooking
        
        | "dishwasher" -> Category.Dishwasher
        | "dishwash" -> Category.Dishwasher
        | "dish" -> Category.Dishwasher
        
        | "dryer" -> Category.Dryer
        | "dry" -> Category.Dryer

        | "washer" -> Category.HAWasher
        | "washing" -> Category.HAWasher
        | "wash" -> Category.HAWasher
        | "hawasher" -> Category.HAWasher
        | "hawashing" -> Category.HAWasher
        | "hawash" -> Category.HAWasher
        | "ha" -> Category.HAWasher
        
        | "refrigeration" -> Category.Refrigeration
        | "refri" -> Category.Refrigeration
        | "refrigerator" -> Category.Refrigeration

        | "vawasher" -> Category.VAWasher
        | "vawashing" -> Category.VAWasher
        | "vawash" -> Category.VAWasher
        | "va" -> Category.VAWasher
        | value -> 
            failwithf "Invalid or missing 'CATEGORY' configuration value: %s. Check launchSettings.json or environment variables." value

    let getPathFromConfig (config: IConfiguration) : string =
        let pathString = 
            config.GetValue<string>("SOURCE_PATH")
            |> Option.ofObj

        if pathString.IsNone then
            failwithf "No SOURCE_PATH. Please insert a valid directory path at launchSettings.json or environment variables that points to WP.GESE.WebAPIs project on your computer."
        elif (not (pathString.Value.Replace("/", "").Replace("\\", "").ToLower().EndsWith("wp.gese.webapis"))) then
            failwithf $"Invalid SOURCE_PATH {pathString}. Please insert a valid directory path at launchSettings.json or environment variables that points to WP.GESE.WebAPIs project on your computer."
        else
            pathString.Value

    try
        let configuration =
            ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build()

        printfn "GraphQL Entity Framework API Generator"

        let category = getCategoryFromConfig configuration
        let path = getPathFromConfig configuration

        let categoryNamespace : string =
            match category with
            | Cooking -> "Cooking"
            | Dishwasher -> "Dish"
            | Dryer -> "Dryer"
            | HAWasher -> "HA"
            | Refrigeration -> "Refrigeration"
            | VAWasher -> "VA"

        let sourcePath = Path.Combine(path, $"WP.{categoryNamespace}.GESE.WebAPI", "Models")
        let destinationPath = Path.Combine(path, $"WP.{categoryNamespace}.GESE.WebAPI", "GraphQL", "Types")
            
        processEntityFiles category sourcePath destinationPath
    with
    | ex ->
        printfn $"Application error: {ex.Message}"
        1
