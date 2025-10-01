namespace GraphQLEntityFrameworkAPIGenerator.Impl

open GraphQLEntityFrameworkAPIGenerator.Interfaces
open GraphQLEntityFrameworkAPIGenerator.Types

type ContentGenerator() =
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
    member private this.MapField(field: Field) : string =
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
        | Type.Primitive(primitiveType) ->
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
        | Type.Id(idType) ->
            match idType with
            | IdType.Int -> $$"""Field(t => t.{{propName}}, type: typeof(IntGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | IdType.String -> $$"""Field(t => t.{{propName}}, type: typeof(StringGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | IdType.Guid -> $$"""Field(t => t.{{propName}}, type: typeof(GuidGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | IdType.Byte -> $$"""Field(t => t.{{propName}}, type: typeof(ByteGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | IdType.Bool -> $$"""Field(t => t.{{propName}}, type: typeof(BooleanGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | IdType.Float -> $$"""Field(t => t.{{propName}}, type: typeof(FloatGraphType), nullable: {{nullable}}).Name("{{name}}");"""
            | IdType.Short -> $$"""Field(t => t.{{propName}}, type: typeof(ShortGraphType), nullable: {{nullable}}).Name("{{name}}");"""

    member private this.MapRelation(entity: Entity, relation: Relation) : string =


        match relation with
        | OneToOne(r) ->
            let sourceTable = r.SourceTable.Name
            let targetTable = r.TargetTable.Name
            let searchKey = r.BackwardsNavProp.FKeyName
            let appliedKey = r.SourceTable.PrimaryKey.PropName
            let keyType = r.KeyType
            let targetNavigationProperty = r.NavProp.ColumnName

            $$"""
            Field<{{targetTable}}GraphType, {{resolveTableName targetTable}}>("{{targetNavigationProperty}}") // Debug: OneToOne relation
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{keyType}}, {{resolveTableName targetTable}}>(
                        "{{targetNavigationProperty}} by {{sourceTable}} DataLoader",
                        async ids => 
                        {
                            var data = await dbContext.{{targetTable.Pluralize()}}
                                .Where(x => x.{{searchKey}} != null && ids.Contains(({{keyType}})x.{{searchKey}}))
                                .Select(x => new
                                {
                                    Key = ({{keyType}})x.{{searchKey}}!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.{{appliedKey}});
                });"""
        | ManyToOne(r) ->
            let sourceTable = r.SourceTable.Name
            let targetTable = r.TargetTable.Name
            let searchKey = r.SourceTable.PrimaryKey.PropName
            let appliedKey = r.SourceTable.PrimaryKey.PropName
            let keyType = r.SourceTable.PrimaryKey.Type
            let targetNavigationProperty = r.NavProp.ColumnName

            $$"""
            Field<{{targetTable}}GraphType, {{resolveTableName targetTable}}>("{{targetNavigationProperty}}") // Debug: ManyToOne relation
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddBatchLoader<{{keyType}}, {{resolveTableName targetTable}}>(
                        "{{targetNavigationProperty}} by {{sourceTable}} DataLoader",
                        async ids => 
                        {
                            var data = await dbContext.{{sourceTable.Pluralize()}}
                                .Where(x => ids.Contains(x.{{searchKey}}))
                                .Select(x => new 
                                {
                                    Key = x.{{searchKey}},
                                    Value = x.{{targetNavigationProperty}},
                                })
                                .ToListAsync();

                            return data.ToDictionary(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.{{appliedKey}});
                });"""
        | OneToMany(r) ->
            let sourceTable = r.SourceTable.Name
            let targetTable = r.TargetTable.Name
            let keyType = r.SourceTable.PrimaryKey.Type
            let appliedKey = r.SourceTable.PrimaryKey.PropName
            let backwardsForeignKeyName = r.BackwardsNavProp.FKeyName
            let targetNavigationProperty = r.NavProp.ColumnName

            $$"""
            Field<ListGraphType<{{targetTable}}GraphType>, IEnumerable<{{resolveTableName targetTable}}>>("{{targetNavigationProperty}}") // Debug: OneToMany relation
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{keyType}}, {{resolveTableName targetTable}}>(
                        "{{targetNavigationProperty}} by {{sourceTable}} DataLoader",
                        async ids => 
                        {
                            var data = await dbContext.{{targetTable.Pluralize()}}
                                .Where(x => x.{{backwardsForeignKeyName}} != null && ids.Contains(({{keyType}})x.{{backwardsForeignKeyName}}))
                                .Select(x => new
                                {
                                    Key = ({{keyType}})x.{{backwardsForeignKeyName}}!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.{{appliedKey}});
                });"""
        | ManyToManyWithJoinTable(r) ->
            let sourceTable = r.SourceTable.Name
            let joinTable = r.JoinTable.Name
            let targetTable = r.TargetTable.Name
            let keyType = r.SourceTable.PrimaryKey.Type;
            let appliedKey = r.SourceTable.PrimaryKey.PropName
            let joinTableBackwardsFKey = r.JoinTableBackwardsNavProp.FKeyName
            let joinTableNavProp = r.JoinTableNavProp.PropName
            let targetNavigationProperty = r.JoinTableNavProp.ColumnName.Pluralize();

            $$"""
            Field<ListGraphType<{{targetTable}}GraphType>, IEnumerable<{{resolveTableName targetTable}}>>("{{targetNavigationProperty}}") // Debug: ManyToManyWithJoinTable relation
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{keyType}}, {{resolveTableName targetTable}}>(
                        "{{targetNavigationProperty}} by {{sourceTable}} DataLoader",
                        async ids => 
                        {
                            var data = await dbContext.{{joinTable.Pluralize()}}
                                .Where(x => x.{{joinTableBackwardsFKey}} != null && ids.Contains(({{keyType}})x.{{joinTableBackwardsFKey}}))
                                .Select(x => new
                                {
                                    Key = ({{keyType}})x.{{joinTableBackwardsFKey}}!,
                                    Value = x.{{joinTableNavProp}},
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.{{appliedKey}});
                });"""
        | ManyToMany(r) ->
            let sourceTable = r.SourceTable.Name
            let targetTable = r.TargetTable.Name
            let searchKey = r.SourceTable.PrimaryKey.PropName
            let keyType = r.SourceTable.PrimaryKey.Type
            let appliedKey = r.SourceTable.PrimaryKey.PropName
            let navPropName = r.NavProp.PropName
            let targetNavigationProperty = r.NavProp.ColumnName

            $$"""
            Field<ListGraphType<{{targetTable}}GraphType>, IEnumerable<{{resolveTableName targetTable}}>>("{{targetNavigationProperty}}") // Debug: ManyToMany relation
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{keyType}}, {{resolveTableName targetTable}}>(
                        "{{targetNavigationProperty}} by {{sourceTable}} DataLoader",
                        async ids => 
                        {
                            var data = await dbContext.{{sourceTable.Pluralize()}}
                                .Where(x => ids.Contains(x.{{searchKey}}))
                                .Select(x => new
                                {
                                    Key = x.{{searchKey}},
                                    Value = x.{{navPropName}},
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.Value.Select(n => new { Key = x.Key, Value = n }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.{{appliedKey}});
                });"""

    interface IContentGenerator with
        member _.GenerateContent(entity: Entity) : GeneratedContent =
            let (entityName, entityFields, entityRelations, table) = (entity.Name, entity.Fields, entity.Relations, entity.CorrespondingTable)

            let mappedFields : string list = 
                entityFields 
                |> Seq.map (ContentGenerator().MapField) 
                |> List.ofSeq

            let mappedRelations : string list = 
                entityRelations 
                |> Seq.map (fun relation -> ContentGenerator().MapRelation(entity, relation)) 
                |> List.ofSeq

            let generatedFile = $$"""
using GraphQL.DataLoader;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using WP.VA.GESE.WebAPI.Models;
#pragma warning disable CS8604, CS8073, CS8619

namespace WP.VA.GESE.WebAPI.GraphQL.Types
{
    public partial class {{entity.Name}}GraphType : ObjectGraphType<{{resolveEntityName entity.Name}}>
    {
        public {{entity.Name}}GraphType(GESE_VAWasherContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
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
using WP.VA.GESE.WebAPI.Models;
#pragma warning disable CS8604, CS8073, CS8619

namespace WP.VA.GESE.WebAPI.GraphQL.Types
{
    public partial class {{entity.Name}}GraphType : ObjectGraphType<{{resolveEntityName entity.Name}}>
    {
        public void Partial{{entity.Name}}GraphType(GESE_VAWasherContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            // Your code goes here. Avoid modifying the .Generated.cs files.
        }
    }
}
            """

            { GeneratedFile = generatedFile; SourceFile = sourceFile }