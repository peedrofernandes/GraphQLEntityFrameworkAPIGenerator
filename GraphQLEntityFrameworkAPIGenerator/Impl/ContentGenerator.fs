namespace GraphQLEntityFrameworkAPIGenerator.Impl

open GraphQLEntityFrameworkAPIGenerator.Interfaces
open GraphQLEntityFrameworkAPIGenerator.Types

type ContentGenerator() =
    // private method, given a field, return the corresponding GraphQL field
    member private this.MapField(field: Field) : string =
        let mapBool(v: bool) =
            match v with
            | true -> "true"
            | false -> "false"

        match field.Type with
        | Type.Primitive(primitiveType) ->
            match primitiveType with
            | PrimitiveType.Int -> $$"""Field(t => t.{{field.Name}}, type: typeof(IdGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.String -> $$"""Field(t => t.{{field.Name}}, type: typeof(StringGraphType), nullable: {{mapBool(field.IsNullable)}});"""  
            | PrimitiveType.Guid -> $$"""Field(t => t.{{field.Name}}, type: typeof(GuidGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.DateTime -> $$"""Field(t => t.{{field.Name}}, type: typeof(DateTimeGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.DateTimeOffset -> $$"""Field(t => t.{{field.Name}}, type: typeof(DateTimeOffsetGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.TimeSpan -> $$"""Field(t => t.{{field.Name}}, type: typeof(TimeSpanGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.Decimal -> $$"""Field(t => t.{{field.Name}}, type: typeof(DecimalGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.Double -> $$"""Field(t => t.{{field.Name}}, type: typeof(DoubleGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.Float -> $$"""Field(t => t.{{field.Name}}, type: typeof(FloatGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.Long -> $$"""Field(t => t.{{field.Name}}, type: typeof(LongGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.Short -> $$"""Field(t => t.{{field.Name}}, type: typeof(ShortGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.Ushort -> $$"""Field(t => t.{{field.Name}}, type: typeof(UshortGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.Uint -> $$"""Field(t => t.{{field.Name}}, type: typeof(UintGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.Ulong -> $$"""Field(t => t.{{field.Name}}, type: typeof(UlongGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.Sbyte -> $$"""Field(t => t.{{field.Name}}, type: typeof(SbyteGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.Char -> $$"""Field(t => t.{{field.Name}}, type: typeof(CharGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.Byte -> $$"""Field(t => t.{{field.Name}}, type: typeof(ByteGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.Bool -> $$"""Field(t => t.{{field.Name}}, type: typeof(BooleanGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | PrimitiveType.ByteArr -> $$"""Field(t => t.{{field.Name}}, type: typeof(ListGraphType<ByteGraphType>), nullable: {{mapBool(field.IsNullable)}});"""
        | Type.Id(idType) ->
            match idType with
            | IdType.Int -> $$"""Field(t => t.{{field.Name}}, type: typeof(IdGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | IdType.String -> $$"""Field(t => t.{{field.Name}}, type: typeof(StringGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | IdType.Guid -> $$"""Field(t => t.{{field.Name}}, type: typeof(GuidGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | IdType.Byte -> $$"""Field(t => t.{{field.Name}}, type: typeof(ByteGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | IdType.Bool -> $$"""Field(t => t.{{field.Name}}, type: typeof(BooleanGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | IdType.Float -> $$"""Field(t => t.{{field.Name}}, type: typeof(FloatGraphType), nullable: {{mapBool(field.IsNullable)}});"""
            | IdType.Short -> $$"""Field(t => t.{{field.Name}}, type: typeof(ShortGraphType), nullable: {{mapBool(field.IsNullable)}});"""

    member private this.MapRelation(entity: Entity, relation: Relation) : string =

        match relation with
        | OneToOne(r) ->
            let sourceTable = r.SourceTable.Name
            let targetTable = r.TargetTable.Name
            let searchKey = r.BackwardsNavProp.FKeyName
            let appliedKey = r.SourceTable.PrimaryKey.Name
            let keyType = r.KeyType

            $$"""
            Field<{{targetTable}}GraphType, {{targetTable}}>("{{targetTable}}")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{keyType}}, {{targetTable}}>(
                        "{{sourceTable}}-{{targetTable}}-loader",
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
                });
            """
        | ManyToOne(r) ->
            let sourceTable = r.SourceTable.Name
            let targetTable = r.TargetTable.Name
            let searchKey = r.SourceTable.PrimaryKey.Name
            let appliedKey = r.SourceTable.PrimaryKey.Name
            let keyType = r.KeyType
            let targetNavigationProperty = r.NavProp.Name

            $$"""
            Field<{{targetTable}}GraphType, {{targetTable}}>("{{targetTable}}")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddBatchLoader<{{keyType}}, {{targetTable}}>(
                        "{{sourceTable}}-{{targetTable}}-loader",
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
                });
            """
        | OneToMany(r) ->
            let sourceTable = r.SourceTable.Name
            let targetTable = r.TargetTable.Name
            let keyType = r.KeyType
            let appliedKey = r.SourceTable.PrimaryKey.Name
            let backwardsForeignKeyName = r.BackwardsNavProp.FKeyName

            $$"""
            Field<ListGraphType<{{targetTable}}GraphType>, IEnumerable<{{targetTable}}>>("{{r.Destination.Pluralize()}}")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{keyType}}, {{targetTable}}>(
                        "{{sourceTable}}-{{targetTable}}-loader",
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
                });
            """
        | ManyToManyWithJoinTable(r) ->
            let sourceTable = r.SourceTable.Name
            let joinTable = r.JoinTable.Name
            let targetTable = r.TargetTable.Name
            let keyType = r.KeyType
            let appliedKey = r.SourceTable.PrimaryKey.Name
            let joinTableBackwardsFKey = r.JoinTableBackwardsNavProp.FKeyName
            let joinTableNavProp = r.JoinTableNavProp.Name

            $$"""
            Field<ListGraphType<{{targetTable}}GraphType>, IEnumerable<{{targetTable}}>>("{{r.Destination.Pluralize()}}")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{keyType}}, {{targetTable}}>(
                        "{{sourceTable}}-{{targetTable}}-loader",
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
                });
            """
        | ManyToMany(r) ->
            let sourceTable = r.SourceTable.Name
            let targetTable = r.TargetTable.Name
            let keyType = r.KeyType
            let appliedKey = r.SourceTable.PrimaryKey.Name
            let navPropName = r.NavProp.Name
            let targetPrimaryKey = r.TargetTable.PrimaryKey.Name

            $$"""
            Field<ListGraphType<{{targetTable}}GraphType>, IEnumerable<{{targetTable}}>>("{{r.Destination.Pluralize()}}")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{keyType}}, {{targetTable}}>(
                        "{{sourceTable}}-{{targetTable}}-loader",
                        async ids => 
                        {
                            var data = await dbContext.{{targetTable.Pluralize()}}
                                .Where(x => x.{{navPropName}}.Any(c => ids.Contains(c.{{targetPrimaryKey}})))
                                .Select(x => new
                                {
                                    LoadGroup = x,
                                    x.{{navPropName}},
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.{{navPropName}}.Select(c => new { Key = c.{{targetPrimaryKey}}, Value = x.LoadGroup }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.{{appliedKey}});
                });
            """

    interface IContentGenerator with
        member _.GenerateContent(entity: Entity) : string =
            let (entityName, entityFields, entityRelations, table) = (entity.Name, entity.Fields, entity.Relations, entity.CorrespondingTable)

            let mappedFields : string list = 
                entityFields 
                |> Seq.map (ContentGenerator().MapField) 
                |> List.ofSeq

            let mappedRelations : string list = 
                entityRelations 
                |> Seq.map (fun relation -> ContentGenerator().MapRelation(entity, relation)) 
                |> List.ofSeq

            let content = $$"""
using GraphQL.DataLoader;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using WP.Cooking.GESE.WebAPI.Models;


namespace WP.Cooking.GESE.WebAPI.GraphQL.Types
{
    public partial class {{entity.Name}}GraphType : ObjectGraphType<{{entity.Name}}>
    {
        public {{entity.Name}}GraphType(GeseCookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            {{mappedFields |> String.concat "\n\t\t\t"}}
            {{mappedRelations |> String.concat "\n\t\t\t"}}
        }
    }
}
            """

            content