module GraphQLEntityFrameworkAPIGenerator.Program

open System.IO
open GraphQLEntityFrameworkAPIGenerator.Interfaces
open GraphQLEntityFrameworkAPIGenerator.Impl
open GraphQLEntityFrameworkAPIGenerator.Types

let processEntityFiles (sourcePath: string) (destinationPath: string) =
    // Initialize parsers and generators
    let tableParser = TableParser() :> ITableParser
    let relationParser = RelationParser() :> IRelationParser
    let contentGenerator = ContentGenerator() :> IContentGenerator
    
    try
        // Validate source directory exists
        if not (Directory.Exists sourcePath) then
            failwith $"Source directory does not exist: {sourcePath}"
        
        // Create destination directory if it doesn't exist
        if not (Directory.Exists destinationPath) then
            Directory.CreateDirectory destinationPath |> ignore
            printfn $"Created destination directory: {destinationPath}"

        let ignoredTables : string list = [
            // Cooking tables
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
            // Refrigeration files
            "GESE_RefrigerationContext"
            "FaultSubCode"
            "FaultCode"
            "FaultPrioritiesDetail"
            "FaultPrioritiesConfigurations_FaultPrioritiesDetail"
            "FaultPrioritiesConfiguration"
        ]

        let ignoredProperties : Map<TableName, string list> =
            Map [
                TableName "Modifier", [ "ModifierType51"; "ModifierType61" ]
                TableName "ModifierType", [ "ModifierModifierType51s"; "ModifierModifierType61s" ]
                TableName "PilotType", [ "MultiDriverPilotType"; "MultiSequencePilotType" ]
                TableName "ReadType", [ "MultiInputReadType" ]
                TableName "PrmPilotMultiSequence", [ "MultiSequencePilotType" ]
                TableName "ACUExpansionBoardConfiguration", [ "Boards" ]
                TableName "Board", [ "ACUExpansionBoardConfiguration" ]
                TableName "HMIExpansionBoardConfiguration", [ "Displays" ]
                TableName "Display", [ "HMIExpansionBoardConfigurations" ]
            ]
        
        // Get all .cs files from source directory
        let entityFiles = 
            Directory.GetFiles(sourcePath, "*.cs", SearchOption.AllDirectories)
            |> Array.filter (fun filePath -> 
                ignoredTables
                |> List.exists filePath.Contains
                |> not)
            
        if entityFiles.Length = 0 then
            printfn "No .cs files found in source directory"
            0
        else
            printfn $"Found {entityFiles.Length} entity files"
            
            // Step 1: Parse all entity files to create Table objects
            let tables = 
                entityFiles
                |> Seq.choose (fun filePath ->
                    try
                        printfn $"Parsing file: {Path.GetFileName filePath}"
                        let fileContent = File.ReadAllText filePath
                        let table = tableParser.ParseTable (ignoredProperties, fileContent)
                        Some table
                    with
                    | ex ->
                        printfn $"Error parsing file {Path.GetFileName filePath}: {ex.Message}"
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
            let mutable successCount = 0
            let mutable errorCount = 0

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
                    successCount <- successCount + 1
                with
                | ex ->
                    let (EntityName entityName) = entity.Name
                    printfn $"Error generating content for entity {entityName}: {ex.Message}"
                    errorCount <- errorCount + 1)
            
            printfn $"\nGeneration complete!"
            printfn $"Success: {successCount} files"
            printfn $"Errors: {errorCount} files"
            
            if errorCount = 0 then 0 else 1
            
    with
    | ex ->
        printfn $"Fatal error: {ex.Message}"
        1

[<EntryPoint>]
let main args =
    try
        match args with
        | [| sourcePath; destinationPath |] ->
            printfn "GraphQL Entity Framework API Generator"
            printfn $"Source: {sourcePath}"
            printfn $"Destination: {destinationPath}"
            printfn ""
            
            processEntityFiles sourcePath destinationPath
            
        | _ ->
            printfn "Usage: GraphQLEntityFrameworkAPIGenerator.exe <source-folder> <destination-folder>"
            printfn ""
            printfn "Arguments:"
            printfn "  source-folder      Path to folder containing Entity Framework entity files (.cs)"
            printfn "  destination-folder Path to folder where GraphQL types will be generated"
            printfn ""
            printfn "Example:"
            printfn "  GraphQLEntityFrameworkAPIGenerator.exe ./Models ./GraphQL/Types"
            1
    with
    | ex ->
        printfn $"Application error: {ex.Message}"
        1
