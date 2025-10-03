# GraphQL Entity Framework API Generator

A code generator that automatically creates GraphQL schemas from Entity Framework models. This tool parses EF model files and generates corresponding GraphQL type definitions with proper relationships, data loaders, and field mappings.

## ⚠️ Important Usage Notice

**This project is designed for LOCAL DEVELOPMENT ONLY and should NOT be used in production environments.**

- **IDE Recommended**: This tool works best when run from within an IDE (Visual Studio, VS Code, etc.)
- **Local Development Only**: Intended for generating source code during development
- **Not Production Ready**: Do not deploy or run this in production environments

## Overview

This F# application analyzes Entity Framework model files (`.cs` files) and generates GraphQL schema files that include:

- **GraphQL Type Definitions**: Automatically generated from EF entities
- **Relationship Mapping**: One-to-One, One-to-Many, Many-to-One, and Many-to-Many relationships
- **Data Loaders**: Optimized data loading with GraphQL DataLoader pattern
- **Field Mapping**: Proper GraphQL field types based on C# property types
- **Navigation Properties**: Automatic handling of EF navigation properties

## Prerequisites

### Required Setup

Before using this generator, ensure your Entity Framework models are properly scaffolded with data annotations. The generator relies heavily on EF data annotations to understand relationships and constraints.

**Recommended EF Scaffolding Command:**
```bash
dotnet ef dbcontext scaffold "<CONNECTION_STRING_HERE>" Microsoft.EntityFrameworkCore.SqlServer --output-dir ./Models --data-annotations --force --no-build --use-database-names
```

**Critical Requirements:**
- `--data-annotations` flag is **ESSENTIAL** - the generator needs data annotations to work properly
- `--use-database-names` ensures proper table and column naming
- Models must be in the correct directory structure (see Configuration section)

## Configuration

### Environment Variables

The application requires two environment variables:

1. **`CATEGORY`**: Specifies the appliance category
   - Valid values: `cooking`, `dishwasher`, `dryer`, `washer`, `refrigeration`, `vawasher`
   - Aliases: `cook`, `dish`, `dry`, `wash`, `ha`, `refri`, `va`

2. **`SOURCE_PATH`**: Path to the WP.GESE.WebAPIs project directory
   - Must point to a directory ending with "WP.GESE.WebAPIs"
   - Example: `C:\projects\whirlpool\WP.GESE.WebAPIs`

### Launch Settings

Configure these in `Properties/launchSettings.json`:

```json
{
  "profiles": {
    "Run": {
      "commandName": "Project",
      "environmentVariables": {
        "CATEGORY": "dryer",
        "SOURCE_PATH": "C:\\projects\\whirlpool\\WP.GESE.WebAPIs"
      }
    }
  }
}
```

## Project Structure

The generator expects the following directory structure:

```
WP.GESE.WebAPIs/
├── WP.{Category}.GESE.WebAPI/
│   ├── Models/           # Source: EF model files (.cs)
│   └── GraphQL/
│       └── Types/       # Destination: Generated GraphQL types
```

Where `{Category}` is one of: `Cooking`, `Dish`, `Dryer`, `HA`, `Refrigeration`, `VA`

## Usage

### Running the Generator

1. **Set Environment Variables** (via launchSettings.json or system environment)
2. **Run from IDE** (recommended) or command line:
   ```bash
   dotnet run
   ```

### Generated Files

The generator creates two types of files for each entity:

1. **`{EntityName}GraphType.cs`** - Source file (created once, safe to modify)
2. **`{EntityName}GraphType.Generated.cs`** - Generated file (overwritten on each run)

**Important**: Only modify the `.cs` files, never the `.Generated.cs` files.

## Supported Entity Framework Features

### Table Types
- **Regular Tables**: Standard entities with primary keys
- **Join Tables**: Many-to-many relationship tables
- **View Tables**: Keyless entities (database views)

### Relationship Types
- **One-to-One**: Direct entity relationships
- **One-to-Many**: Parent-child relationships
- **Many-to-One**: Child-parent relationships  
- **Many-to-Many**: Complex relationships with or without join tables

### Data Types
Supports all common .NET primitive types:
- Numeric: `int`, `long`, `short`, `byte`, `decimal`, `double`, `float`
- Text: `string`, `char`
- Date/Time: `DateTime`, `DateTimeOffset`, `TimeSpan`
- Other: `bool`, `Guid`, `byte[]`

## Error Handling and Validation

The generator includes comprehensive error handling:

### Common Error Scenarios
- **Missing Data Annotations**: If EF models lack proper `[Key]`, `[ForeignKey]`, or `[InverseProperty]` attributes
- **Invalid Source Path**: When `SOURCE_PATH` doesn't point to the correct directory
- **Missing Navigation Properties**: When relationships are incomplete
- **Parse Failures**: When EF model files can't be parsed correctly

### Validation Messages
The generator provides detailed feedback:
- File parsing success/failure counts
- Entity generation statistics
- Specific error messages for troubleshooting
- Recommendations for fixing common issues

## Troubleshooting

### High Parse Failure Rate
If many tables fail to parse, the error message will suggest:
```
A lot of tables were not able to be parsed. Please verify whether you scaffolded the database correctly. This script needs data annotations on EF entities to work properly. It's HIGHLY ENCOURAGED that you use this command: `dotnet ef dbcontext scaffold "<CONNECTION_STRING_HERE>" Microsoft.EntityFrameworkCore.SqlServer --output-dir ./Models --data-annotations --force --no-build --use-database-names`
```

### Missing Navigation Properties
Ensure all navigation properties have corresponding `[InverseProperty]` attributes and that both sides of relationships are properly configured.

### Configuration Issues
- Verify `SOURCE_PATH` points to a directory ending with "WP.GESE.WebAPIs"
- Check that `CATEGORY` matches one of the supported values
- Ensure the target project structure exists

## Technical Architecture

### Core Components
- **TableParser**: Parses EF model files and extracts table information
- **RelationParser**: Analyzes relationships between tables
- **ContentGenerator**: Generates GraphQL schema code
- **Type System**: Comprehensive F# type definitions for tables, entities, and relationships

### Key Features
- **Pluralization Logic**: Intelligent handling of entity name pluralization
- **Type Mapping**: Automatic conversion from C# types to GraphQL types
- **Relationship Detection**: Automatic detection of EF relationships
- **DataLoader Integration**: Optimized data loading patterns

## Development Notes

- Built with F# and .NET 8.0
- Uses Microsoft.Extensions.Configuration for settings
- Generates code compatible with GraphQL.NET
- Designed for use with Entity Framework Core
- Optimized for Whirlpool's GESE (Global Engineering Support Environment) architecture

## License

This project is part of Whirlpool's internal development tools and is not intended for public distribution.
