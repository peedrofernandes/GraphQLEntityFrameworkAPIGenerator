namespace GraphQLEntityFrameworkAPIGenerator.Impl

open GraphQLEntityFrameworkAPIGenerator.Interfaces
open GraphQLEntityFrameworkAPIGenerator.Types

// using GraphQL.Types;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using WP.Cooking.GESE.WebAPI.Models;
// using GraphQL.DataLoader;
// using WP.Cooking.GESE.WebAPI.Repositories; 


// namespace WP.Cooking.GESE.WebAPI.GraphQL.Types
// {
//     public partial class ApplianceConfigurationGraphType : ObjectGraphType<ApplianceConfiguration>
//     {
//         public ApplianceConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
//         {
//             Field(t => t.ApplianceConfigurationID, type: typeof(IdGraphType)); 
//             Field(t => t.MinimumOnTime, type: typeof(ByteGraphType)); 
//             Field(t => t.MinimumOffTime, type: typeof(ByteGraphType)); 
//             Field(t => t.Description, type: typeof(StringGraphType)); 
//             Field(t => t.Status, type: typeof(ByteGraphType)); 
//             Field(t => t.Owner, type: typeof(StringGraphType)); 
//             Field(t => t.Timestamp, type: typeof(DateTimeGraphType)); 
//             Field(t => t.RevisionGroup, type: typeof(IdGraphType)); 
//             Field(t => t.Revision, type: typeof(IntGraphType)); 
//             Field(t => t.TableTarget, type: typeof(ByteGraphType)); 
//             Field(t => t.Notes, type: typeof(StringGraphType), nullable: true); 

            
//                         Field<ListGraphType<AppConfigCompartmentDetailGraphType>, IEnumerable<AppConfigCompartmentDetail>>("AppConfigCompartmentDetails")
//                 .ResolveAsync(context =>
//                 {
//                     var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, AppConfigCompartmentDetail>("GetAppConfigCompartmentDetailsByApplianceConfigurationIds",
//                         dbContext.GetAppConfigCompartmentDetailsByApplianceConfigurationIds);
//                     return loader.LoadAsync(context.Source.ApplianceConfigurationID);
//                 }); 
//             Field<ListGraphType<MachineConfigurationGraphType>, IEnumerable<MachineConfiguration>>("MachineConfigurations")
//                 .ResolveAsync(context =>
//                 {
//                     var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MachineConfiguration>("GetMachineConfigurationsByApplianceConfigurationIds",
//                         dbContext.GetMachineConfigurationsByApplianceConfigurationIds);
//                     return loader.LoadAsync(context.Source.ApplianceConfigurationID);
//                 }); 

            
//             PartialApplianceConfigurationGraphType(dbContext, dataLoaderAccessor);
//         }
//     }
// }

// ==================================================================================================================================================================

//TEMPLATE 1 - SINGLE MANY-TO-ONE RELATION            

//var data = await dbContext.MachineConfigurations
//    .Where(x => x.IsofrequencyTableId != null && inductionIsofrequencyConfigurationIds.Contains((Guid)x.IsofrequencyTableId))
//    .Select(x => new
//    {
//        Key = (Guid)x.IsofrequencyTableId!,
//        Value = x,
//    })
//        .ToListAsync();

//return data.ToLookup(x => x.Key, x => x.Value);

// ==================================================================================================================================================================

//TEMPLATE 2 - MULTIPLE MANY-TO-ONE RELATION


//Expression<Func<InductionCoilConfig, bool>> expr = x => !inductionCoilNTCSpecificIds.Any()
//    || (x.ACNTCSpecificId != null && inductionCoilNTCSpecificIds.Contains((Guid)x.ACNTCSpecificId))
//    || (x.CoilNTCSpecificId != null && inductionCoilNTCSpecificIds.Contains((Guid)x.CoilNTCSpecificId))
//    || (x.IgbtSafetyParamsId != null && inductionCoilNTCSpecificIds.Contains((Guid)x.IgbtSafetyParamsId))
//    || (x.InductionCoilHeatsinkNTCSpecificId != null && inductionCoilNTCSpecificIds.Contains((Guid)x.InductionCoilHeatsinkNTCSpecificId));

//var data = await dbContext.InductionCoilConfigs
//    .Where(expr)
//    .ToListAsync();

//var lookup = data
//    .SelectMany(x => new List<Guid?>()
//    {
//        x.ACNTCSpecificId,
//        x.CoilNTCSpecificId,
//        x.IgbtSafetyParamsId,
//        x.InductionCoilHeatsinkNTCSpecificId,
//    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
//    .ToLookup(x => x.Key, x => x.Value);

//return lookup;

// ==================================================================================================================================================================

//TEMPLATE 3 - ONE-TO-MANY RELATION // TODO

// ==================================================================================================================================================================

//TEMPLATE 4 - MANY-TO-MANY RELATION (WITH JOIN TABLE)

//var data = await dbContext.PilotMultiSequenceConfig_Details
//    .Where(x => x.ConfigId != null && (pilotMultiSequenceConfigIds.Contains((Guid)x.ConfigId)))
//    .Select(x => new
//    {
//        Key = x.ConfigId,
//        Value = x.Details,
//    })
//    .ToListAsync();

//return data.ToLookup(x => x.Key, x => x.Value);

// ==================================================================================================================================================================

//TEMPLATE 5 - MANY-TO-MANY RELATION (WITHOUT JOIN TABLE)

//var data = await dbContext.LoadGroups
//    .Where(x => x.Loads.Any(l => loadIds.Contains(l.LoadId)))
//    .Select(x => new
//    {
//        LoadGroup = x,
//        x.Loads,
//    })
//    .ToListAsync();

//var lookup = data
//    .SelectMany(x => x.Loads.Select(l => new { Key = l.LoadId, Value = x.LoadGroup }))
//    .ToLookup(x => x.Key, x => x.Value);

//return lookup;

// ==================================================================================================================================================================

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
        | SingleManyToOne(r) ->
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
        // | MultipleManyToOne(r) ->
        //     let sourceTable = r.SourceTable.Name
        //     let targetTable = r.TargetTable.Name
        //     let keyType = r.KeyType
        //     let appliedKey = r.SourceTable.PrimaryKey.Name

        //     // Generate individual field mappings
        //     let fieldMappings = 
        //         List.zip r.Names r.NavProps
        //         |> List.map (fun (name, navProp) ->
        //             $$"""
        //     Field<{{targetTable}}GraphType, {{targetTable}}>("{{name}}")
        //         .ResolveAsync(context => 
        //         {
        //             var loader = dataLoaderAccessor.Context.GetOrAddBatchLoader<{{keyType}}, {{targetTable}}>(
        //                 "{{sourceTable}}-{{targetTable}}-{{name}}-loader",
        //                 async ids => 
        //                 {
        //                     var data = await dbContext.{{sourceTable.Pluralize()}}
        //                         .Where(x => ids.Contains(x.{{appliedKey}}))
        //                         .Select(x => new 
        //                         {
        //                             Key = x.{{appliedKey}},
        //                             Value = x.{{navProp.Name}},
        //                         })
        //                         .ToListAsync();

        //                     return data.ToDictionary(x => x.Key, x => x.Value);
        //                 });

        //             return loader.LoadAsync(context.Source.{{appliedKey}});
        //         });
        //             """)
        //         |> String.concat ""

        //     fieldMappings
        | SingleOneToMany(r) ->
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
        // | MultipleOneToMany(r) ->
        //     let sourceTable = r.SourceTable.Name
        //     let targetTable = r.TargetTable.Name
        //     let keyType = r.KeyType
        //     let appliedKey = r.SourceTable.PrimaryKey.Name

        //     // Generate individual collection field mappings
        //     let fieldMappings = 
        //         List.zip r.Names r.BackwardsNavProps
        //         |> List.map (fun (name, backwardsNavProp) ->
        //             $$"""
        //     Field<ListGraphType<{{targetTable}}GraphType>, IEnumerable<{{targetTable}}>>("{{name}}")
        //         .ResolveAsync(context => 
        //         {
        //             var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{keyType}}, {{targetTable}}>(
        //                 "{{sourceTable}}-{{targetTable}}-{{name}}-loader",
        //                 async ids => 
        //                 {
        //                     var data = await dbContext.{{targetTable.Pluralize()}}
        //                         .Where(x => x.{{backwardsNavProp.FKeyName}} != null && ids.Contains(({{keyType}})x.{{backwardsNavProp.FKeyName}}))
        //                         .Select(x => new
        //                         {
        //                             Key = ({{keyType}})x.{{backwardsNavProp.FKeyName}}!,
        //                             Value = x,
        //                         })
        //                         .ToListAsync();

        //                     return data.ToLookup(x => x.Key, x => x.Value);
        //                 });

        //             return loader.LoadAsync(context.Source.{{appliedKey}});
        //         });
        //             """)
        //         |> String.concat ""

        //     fieldMappings
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