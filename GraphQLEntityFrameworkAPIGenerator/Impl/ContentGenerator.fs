namespace GraphQLEntityFrameworkAPIGenerator.Impl

open GraphQLEntityFrameworkAPIGenerator.Interfaces
open GraphQLEntityFrameworkAPIGenerator.Types

type ContentGenerator(category : Category) =
    let resolveTableName(name: TableName) : TableName =
        match name.ToString() with
        | "Attribute" -> TableName "Models.Attribute"
        | "Task" -> TableName "Models.Task"
        | _ -> name
    let resolveEntityName(name: EntityName) : EntityName =
        match name.ToString() with
        | "Attribute" -> EntityName "Models.Attribute"
        | "Task" -> EntityName "Models.Task"
        | _ -> name

    // private method, given a field, return the corresponding GraphQL field
    member private _.MapField(field: Field) : string =
        let mapBool(v: bool) =
            match v with
            | true -> "true"
            | false -> "false"

        let mapColumnName(v: ColumnName): ColumnName =
            let (ColumnName name) = v
            if not (System.String.IsNullOrEmpty(name)) && System.Char.IsDigit(name.[0]) then
                ColumnName ("_" + name)
            else
                v

        let propName = field.PropName
        let nullable = mapBool(field.IsNullable)
        let name = mapColumnName(field.ColumnName)

        match field.Type with
        | FieldType.Primitive(primitiveType) ->
            match primitiveType with
            | PrimitiveType.Int -> $$"""Field(t => t.{{propName}}, type: typeof(IntGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.String -> $$"""Field(t => t.{{propName}}, type: typeof(StringGraphType), nullable: {{nullable}}).Name("{{name}}");"""  
            | PrimitiveType.Guid -> $$"""Field(t => t.{{propName}}, type: typeof(GuidGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.DateTime -> $$"""Field(t => t.{{propName}}, type: typeof(DateTimeGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.DateTimeOffset -> $$"""Field(t => t.{{propName}}, type: typeof(DateTimeOffsetGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.TimeSpan -> $$"""Field(t => t.{{propName}}, type: typeof(TimeSpanGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.Decimal -> $$"""Field(t => t.{{propName}}, type: typeof(DecimalGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.Double -> $$"""Field(t => t.{{propName}}, type: typeof(FloatGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.Float -> $$"""Field(t => t.{{propName}}, type: typeof(FloatGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.Long -> $$"""Field(t => t.{{propName}}, type: typeof(LongGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.Short -> $$"""Field(t => t.{{propName}}, type: typeof(ShortGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.Ushort -> $$"""Field(t => t.{{propName}}, type: typeof(UshortGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.Uint -> $$"""Field(t => t.{{propName}}, type: typeof(UintGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.Ulong -> $$"""Field(t => t.{{propName}}, type: typeof(UlongGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.Sbyte -> $$"""Field(t => t.{{propName}}, type: typeof(SbyteGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.Char -> $$"""Field(t => t.{{propName}}, type: typeof(CharGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.Byte -> $$"""Field(t => t.{{propName}}, type: typeof(ByteGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.Bool -> $$"""Field(t => t.{{propName}}, type: typeof(BooleanGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | PrimitiveType.ByteArr -> $$"""Field(t => t.{{propName}}, type: typeof(ListGraphType<ByteGraphType>), nullable: {{nullable}}).Name("{{name}}");"""
        | FieldType.Id(idType) ->
            match idType with
            | SingleIdType.Int -> $$"""Field(t => t.{{propName}}, type: typeof(IntGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | SingleIdType.String -> $$"""Field(t => t.{{propName}}, type: typeof(StringGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | SingleIdType.Guid -> $$"""Field(t => t.{{propName}}, type: typeof(GuidGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | SingleIdType.Byte -> $$"""Field(t => t.{{propName}}, type: typeof(ByteGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | SingleIdType.Bool -> $$"""Field(t => t.{{propName}}, type: typeof(BooleanGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | SingleIdType.Float -> $$"""Field(t => t.{{propName}}, type: typeof(FloatGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | SingleIdType.Short -> $$"""Field(t => t.{{propName}}, type: typeof(ShortGraphType), nullable: {{nullable}}).Name("{{name}}");"""

    member private _.MapRelation(entity: Entity, relation: Relation) : string =
        let resolveInputFormatWithPrimaryKey (pk: PrimaryKeyProperty) : string =
            match pk with
            | PrimaryKeyProperty.Single s -> $"var {s.ColumnName.Pluralize()} = inputs;"
            | PrimaryKeyProperty.Composite c ->
                let mappedVarTuple = 
                    c.Keys 
                    |> List.map (fun x -> x.ColumnName.Pluralize().ToString())
                    |> String.concat ", "
                    |> (fun finalStr -> $"({finalStr})")
                let mappedSeedTuple =
                    c.Keys 
                    |> List.map (fun x -> $"new List<{x.Type}>()")
                    |> String.concat ", "
                    |> (fun finalStr -> $"({finalStr})")
                let mappedAdditions =
                    c.Keys
                    |> List.mapi (fun i _ -> $"acc.Item{i + 1}.Add(cur.Item{i + 1});")
                    |> String.concat "\n\t\t\t\t\t\t\t\t\t"

                $$"""var {{mappedVarTuple}} = inputs.Aggregate(
                                seed: {{mappedSeedTuple}},
                                func: (acc, cur) =>
                                {
                                    {{mappedAdditions}}
                                    return acc;
                                }
                            );"""

        let resolveInputFormatWithForeignKey (fk: ForeignKeyProperty) : string =
            match fk with
            | ForeignKeyProperty.Single s -> $"var {s.ColumnName.Pluralize()} = inputs;"
            | ForeignKeyProperty.Composite c ->
                let mappedVarTuple = 
                    c.Keys 
                    |> List.map (fun x -> x.ColumnName.Pluralize().ToString())
                    |> String.concat ", "
                    |> (fun finalStr -> $"({finalStr})")
                let mappedSeedTuple =
                    c.Keys 
                    |> List.map (fun x -> $"new List<{x.Type}>()")
                    |> String.concat ", "
                    |> (fun finalStr -> $"({finalStr})")
                let mappedAdditions =
                    c.Keys
                    |> List.mapi (fun i _ -> $"acc.Item{i + 1}.Add(cur.Item{i + 1});")
                    |> String.concat "\n\t\t\t\t\t\t\t\t\t\t"

                $$"""var {{mappedVarTuple}} = inputs.Aggregate(
                                seed: {{mappedSeedTuple}},
                                func: (acc, cur) =>
                                {
                                    {{mappedAdditions}}
                                    return acc;
                                }
                            );"""

        let resolveAppliedKey (pk: PrimaryKeyProperty) : string =
            let resolveAppliedKeyWithSinglePrimaryKey (pk: SinglePrimaryKeyProperty) =
                $"context.Source.{pk.PropName}"
            match pk with
            | PrimaryKeyProperty.Single(pk) -> resolveAppliedKeyWithSinglePrimaryKey pk
            | PrimaryKeyProperty.Composite(pk) -> 
                pk.Keys
                |> List.map (fun pk -> resolveAppliedKeyWithSinglePrimaryKey pk)
                |> String.concat ", "
                |> fun finalStr -> $"({finalStr})"

        let resolveKeyType (pk: PrimaryKeyProperty) : string =
            let resolveKeyTypeWithSinglePrimaryKey (pk: SinglePrimaryKeyProperty) =
                $"{pk.Type}"
            match pk with
            | PrimaryKeyProperty.Single pk -> resolveKeyTypeWithSinglePrimaryKey pk
            | PrimaryKeyProperty.Composite pk ->
                pk.Keys
                |> List.map (fun pk -> resolveKeyTypeWithSinglePrimaryKey pk)
                |> String.concat ", "
                |> fun finalStr -> $"({finalStr})"

        let resolveWhereExprWithPrimaryKey (pk: PrimaryKeyProperty) : string =
            let resolveWhereExprWithSinglePrimaryKey (pk: SinglePrimaryKeyProperty) =
                $"{pk.ColumnName.Pluralize()}.Contains(x.{pk.PropName})"
            match pk with
            | PrimaryKeyProperty.Single pk -> $"x => {resolveWhereExprWithSinglePrimaryKey pk}"
            | PrimaryKeyProperty.Composite pk ->
                pk.Keys
                |> List.map (fun fk -> $"({resolveWhereExprWithSinglePrimaryKey fk})")
                |> String.concat " || "
                |> fun finalStr -> $"x => {finalStr}"

        let resolveKeyMappingWithPrimaryKey (pk: PrimaryKeyProperty) : string =
            let resolveKeyMappingWithSinglePrimaryKey (pk: SinglePrimaryKeyProperty) =
                $"x.{pk.PropName}"
            match pk with
            | PrimaryKeyProperty.Single pk -> resolveKeyMappingWithSinglePrimaryKey pk
            | PrimaryKeyProperty.Composite pk ->
                pk.Keys
                |> List.map (fun pk -> $"{pk.ColumnName} = {resolveKeyMappingWithSinglePrimaryKey pk},")
                |> String.concat "\n\t\t\t\t\t\t\t\t\t\t"
                |> fun finalStr -> $$"""new
                                    {
                                        {{finalStr}}
                                    }"""

        let resolveWhereExprWithForeignKey (fk: ForeignKeyProperty) : string =
            let resolveWhereExprWithSingleForeignKey (fk: SingleForeignKeyProperty) =
                $"x.{fk.ColumnName} != null && {fk.ColumnName.Pluralize()}.Contains(({fk.Type})x.{fk.ColumnName})"
            match fk with
            | ForeignKeyProperty.Single fk -> $"x => {resolveWhereExprWithSingleForeignKey fk}"
            | ForeignKeyProperty.Composite fk ->
                fk.Keys
                |> List.map (fun fk -> $"({resolveWhereExprWithSingleForeignKey fk})")
                |> String.concat " || "
                |> fun finalStr -> $"x => {finalStr}"

        let resolveKeyMappingWithForeignKey (fk: ForeignKeyProperty) : string =
            let resolveKeyMappingWithSingleForeignKey (fk: SingleForeignKeyProperty) =
                $"({fk.Type})x.{fk.ColumnName}!"
            match fk with
            | ForeignKeyProperty.Single fk -> $"{resolveKeyMappingWithSingleForeignKey fk}"
            | ForeignKeyProperty.Composite fk ->
                fk.Keys
                |> List.map (fun fk -> $"{fk.ColumnName} = {resolveKeyMappingWithSingleForeignKey fk},")
                |> String.concat "\n\t\t\t\t\t\t\t\t\t\t"
                |> fun finalStr -> $$"""new 
                                    {
                                        {{finalStr}}
                                    }"""

        let resolveOutputWithPrimaryKey (pk: PrimaryKeyProperty) : string =
            match pk with
            | PrimaryKeyProperty.Single _ -> "x => x.Key"
            | PrimaryKeyProperty.Composite pk ->
                pk.Keys
                |> List.map (fun pk -> $"x.Key.{pk.ColumnName}")
                |> String.concat ", "
                |> fun finalStr -> $"x => ({finalStr})"

        let resolveOutputWithForeignKey (fk: ForeignKeyProperty) : string =
            match fk with
            | ForeignKeyProperty.Single _ -> "x => x.Key"
            | ForeignKeyProperty.Composite fk ->
                fk.Keys
                |> List.map (fun fk -> $"x.Key.{fk.ColumnName}")
                |> String.concat ", "
                |> fun finalStr -> $"x => ({finalStr})"

        match relation with
        | OneToOne(r) ->
            $$"""
            Field<{{r.TargetTable.Name}}GraphType, {{resolveTableName r.TargetTable.Name}}>("{{r.NavProp.ColumnName}}") // Debug: OneToOne relation
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{resolveKeyType r.SourceTable.PrimaryKey}}, {{resolveTableName r.TargetTable.Name}}>(
                        "{{r.NavProp.ColumnName}} by {{r.SourceTable.Name}} DataLoader",
                        async inputs => 
                        {
                            {{resolveInputFormatWithForeignKey r.BackwardsNavProp.ForeignKey}}

                            var data = await dbContext.{{r.TargetTable.Name.Pluralize()}}
                                .Where({{resolveWhereExprWithForeignKey r.BackwardsNavProp.ForeignKey}})
                                .Select(x => new
                                {
                                    Key = {{resolveKeyMappingWithForeignKey r.BackwardsNavProp.ForeignKey}},
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup({{resolveOutputWithForeignKey r.BackwardsNavProp.ForeignKey}}, x => x.Value);
                        });

                    return loader.LoadAsync({{resolveAppliedKey r.SourceTable.PrimaryKey}}).Then(r => r.FirstOrDefault());
                });"""
        | ManyToOne(r) ->
            $$"""
            Field<{{r.TargetTable.Name}}GraphType, {{resolveTableName r.TargetTable.Name}}>("{{r.NavProp.ColumnName}}") // Debug: ManyToOne relation
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddBatchLoader<{{resolveKeyType r.SourceTable.PrimaryKey}}, {{resolveTableName r.TargetTable.Name}}>(
                        "{{r.NavProp.ColumnName}} by {{r.SourceTable.Name}} DataLoader",
                        async inputs => 
                        {
                            {{resolveInputFormatWithPrimaryKey r.SourceTable.PrimaryKey}}

                            var data = await dbContext.{{r.SourceTable.Name.Pluralize()}}
                                .Where({{resolveWhereExprWithPrimaryKey r.SourceTable.PrimaryKey}})
                                .Select(x => new 
                                {
                                    Key = {{resolveKeyMappingWithPrimaryKey r.SourceTable.PrimaryKey}},
                                    Value = x.{{r.NavProp.PropName}},
                                })
                                .ToListAsync();

                            return data.ToDictionary({{resolveOutputWithPrimaryKey r.SourceTable.PrimaryKey}}, x => x.Value);
                        });

                    return loader.LoadAsync({{resolveAppliedKey r.SourceTable.PrimaryKey}});
                });"""
        | OneToMany(r) ->
            $$"""
            Field<ListGraphType<{{r.TargetTable.Name}}GraphType>, IEnumerable<{{resolveTableName r.TargetTable.Name}}>>("{{r.NavProp.ColumnName}}") // Debug: OneToMany relation
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{resolveKeyType r.SourceTable.PrimaryKey}}, {{resolveTableName r.TargetTable.Name}}>(
                        "{{r.NavProp.ColumnName}} by {{r.SourceTable.Name}} DataLoader",
                        async inputs => 
                        {
                            {{resolveInputFormatWithForeignKey r.BackwardsNavProp.ForeignKey}}

                            var data = await dbContext.{{r.TargetTable.Name.Pluralize()}}
                                .Where({{resolveWhereExprWithForeignKey r.BackwardsNavProp.ForeignKey}})
                                .Select(x => new
                                {
                                    Key = {{resolveKeyMappingWithForeignKey r.BackwardsNavProp.ForeignKey}},
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup({{resolveOutputWithForeignKey r.BackwardsNavProp.ForeignKey}}, x => x.Value);
                        });

                    return loader.LoadAsync({{resolveAppliedKey r.SourceTable.PrimaryKey}});
                });"""
        | ManyToManyWithJoinTable(r) ->
            $$"""
            Field<ListGraphType<{{r.TargetTable.Name}}GraphType>, IEnumerable<{{resolveTableName r.TargetTable.Name}}>>("{{r.JoinTableNavProp.ColumnName.Pluralize()}}") // Debug: ManyToManyWithJoinTable relation
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{resolveKeyType r.SourceTable.PrimaryKey}}, {{resolveTableName r.TargetTable.Name}}>(
                        "{{r.JoinTableNavProp.ColumnName.Pluralize()}} by {{r.SourceTable.Name}} DataLoader",
                        async inputs => 
                        {
                            {{resolveInputFormatWithForeignKey r.JoinTableBackwardsNavProp.ForeignKey}}
                            var data = await dbContext.{{r.JoinTable.Name.Pluralize()}}
                                .Where({{resolveWhereExprWithForeignKey r.JoinTableBackwardsNavProp.ForeignKey}})
                                .Select(x => new
                                {
                                    Key = {{resolveKeyMappingWithForeignKey r.JoinTableBackwardsNavProp.ForeignKey}},
                                    Value = x.{{r.JoinTableNavProp.PropName}},
                                })
                                .ToListAsync();

                            return data.ToLookup({{resolveOutputWithForeignKey r.JoinTableBackwardsNavProp.ForeignKey}}, x => x.Value);
                        });

                    return loader.LoadAsync({{resolveAppliedKey r.SourceTable.PrimaryKey}});
                });"""
        | ManyToMany(r) ->
            $$"""
            Field<ListGraphType<{{r.TargetTable.Name}}GraphType>, IEnumerable<{{resolveTableName r.TargetTable.Name}}>>("{{r.NavProp.ColumnName}}") // Debug: ManyToMany relation
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{resolveKeyType r.SourceTable.PrimaryKey}}, {{resolveTableName r.TargetTable.Name}}>(
                        "{{r.NavProp.ColumnName}} by {{r.SourceTable.Name}} DataLoader",
                        async inputs => 
                        {
                            {{resolveInputFormatWithPrimaryKey r.SourceTable.PrimaryKey}}

                            var data = await dbContext.{{r.SourceTable.Name.Pluralize()}}
                                .Where({{resolveWhereExprWithPrimaryKey r.SourceTable.PrimaryKey}})
                                .Select(x => new
                                {
                                    Key = {{resolveKeyMappingWithPrimaryKey r.SourceTable.PrimaryKey}},
                                    Value = x.{{r.NavProp.PropName}},
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.Value.Select(n => new { Key = x.Key, Value = n }))
                                .ToLookup({{resolveOutputWithPrimaryKey r.SourceTable.PrimaryKey}}, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync({{resolveAppliedKey r.SourceTable.PrimaryKey}});
                });"""

    interface IContentGenerator with
        member _.Category = category

        member _.GenerateContent(entity: Entity) : GeneratedContent =
            let (entityFields, entityRelations) = (entity.Fields, entity.Relations)

            let mappedFields : string list = 
                entityFields 
                |> Seq.map (ContentGenerator(category).MapField) 
                |> List.ofSeq

            let mappedRelations : string list = 
                entityRelations 
                |> Seq.map (fun relation -> ContentGenerator(category).MapRelation(entity, relation)) 
                |> List.ofSeq

            let categoryNamespace : string =
                match category with
                | Cooking -> "Cooking"
                | Dishwasher -> "Dish"
                | Dryer -> "Dryer"
                | HAWasher -> "HA"
                | Refrigeration -> "Refrigeration"
                | VAWasher -> "VA"

            let categoryDbContext : string =
                match category with
                | Cooking -> "GESE_CookingContext"
                | Dishwasher -> "GESE_DishwasherContext"
                | Dryer -> "GESE_DryerContext"
                | HAWasher -> "GESE_HAWasherContext"
                | Refrigeration -> "GESE_RefrigerationContext"
                | VAWasher -> "GESE_VAWasherContext"

            let generatedFile = $$"""
using GraphQL.DataLoader;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using WP.{{categoryNamespace}}.GESE.WebAPI.Models;
#pragma warning disable CS8604, CS8073, CS8619, CS0472

namespace WP.{{categoryNamespace}}.GESE.WebAPI.GraphQL.Types
{
    public partial class {{entity.Name}}GraphType : ObjectGraphType<{{resolveEntityName entity.Name}}>
    {
        public {{entity.Name}}GraphType({{categoryDbContext}} dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            {{(mappedFields @ mappedRelations) |> String.concat "\n\t\t\t"}}

            Partial{{entity.Name}}GraphType(dbContext, dataLoaderAccessor);
        }
    }
}
            """

            let sourceFile = $$"""
using GraphQL.DataLoader;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using WP.{{categoryNamespace}}.GESE.WebAPI.Models;
#pragma warning disable CS8604, CS8073, CS8619

namespace WP.{{categoryNamespace}}.GESE.WebAPI.GraphQL.Types
{
    public partial class {{entity.Name}}GraphType : ObjectGraphType<{{resolveEntityName entity.Name}}>
    {
        public void Partial{{entity.Name}}GraphType({{categoryDbContext}} dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            // Your code goes here. Avoid modifying the .Generated.cs files.
        }
    }
}
            """

            { GeneratedFile = generatedFile; SourceFile = sourceFile }