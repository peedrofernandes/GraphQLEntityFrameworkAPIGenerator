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
        match field.Type with
        | Type.Primitive(primitiveType) ->
            match primitiveType with
            | PrimitiveType.Int -> $$"""Field(t => t.{{field.Name}}, type: typeof(IdGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.String -> $$"""Field(t => t.{{field.Name}}, type: typeof(StringGraphType), nullable: {{field.IsNullable}});"""  
            | PrimitiveType.Guid -> $$"""Field(t => t.{{field.Name}}, type: typeof(GuidGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.DateTime -> $$"""Field(t => t.{{field.Name}}, type: typeof(DateTimeGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.DateTimeOffset -> $$"""Field(t => t.{{field.Name}}, type: typeof(DateTimeOffsetGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.TimeSpan -> $$"""Field(t => t.{{field.Name}}, type: typeof(TimeSpanGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.Decimal -> $$"""Field(t => t.{{field.Name}}, type: typeof(DecimalGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.Double -> $$"""Field(t => t.{{field.Name}}, type: typeof(DoubleGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.Float -> $$"""Field(t => t.{{field.Name}}, type: typeof(FloatGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.Long -> $$"""Field(t => t.{{field.Name}}, type: typeof(LongGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.Short -> $$"""Field(t => t.{{field.Name}}, type: typeof(ShortGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.Ushort -> $$"""Field(t => t.{{field.Name}}, type: typeof(UshortGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.Uint -> $$"""Field(t => t.{{field.Name}}, type: typeof(UintGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.Ulong -> $$"""Field(t => t.{{field.Name}}, type: typeof(UlongGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.Sbyte -> $$"""Field(t => t.{{field.Name}}, type: typeof(SbyteGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.Char -> $$"""Field(t => t.{{field.Name}}, type: typeof(CharGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.Byte -> $$"""Field(t => t.{{field.Name}}, type: typeof(ByteGraphType), nullable: {{field.IsNullable}});"""
            | PrimitiveType.Bool -> $$"""Field(t => t.{{field.Name}}, type: typeof(BoolGraphType), nullable: {{field.IsNullable}});"""
        | Type.Id(idType) ->
            match idType with
            | IdType.Int -> $$"""Field(t => t.{{field.Name}}, type: typeof(IdGraphType), nullable: {{field.IsNullable}});"""
            | IdType.String -> $$"""Field(t => t.{{field.Name}}, type: typeof(StringGraphType), nullable: {{field.IsNullable}});"""
            | IdType.Guid -> $$"""Field(t => t.{{field.Name}}, type: typeof(GuidGraphType), nullable: {{field.IsNullable}});"""
            | IdType.Byte -> $$"""Field(t => t.{{field.Name}}, type: typeof(ByteGraphType), nullable: {{field.IsNullable}});"""
            | IdType.Bool -> $$"""Field(t => t.{{field.Name}}, type: typeof(BoolGraphType), nullable: {{field.IsNullable}});"""
            | IdType.Float -> $$"""Field(t => t.{{field.Name}}, type: typeof(FloatGraphType), nullable: {{field.IsNullable}});"""
            | IdType.Short -> $$"""Field(t => t.{{field.Name}}, type: typeof(ShortGraphType), nullable: {{field.IsNullable}});"""

    member private this.MapRelation(entity: Entity, relation: Relation) : string =

        let getExpressionStatements(names : RelationName list, r : MultipleManyToOneRelation) : string =
            names
            |> List.map (fun name -> $$"""\|\| (x.{{name}} != null && ids.Contains(({{r.KeyType.ToString()}})x.{{name}}))""")
            |> String.concat "\n"

        let getMappingStatements(names : RelationName list, r : MultipleManyToOneRelation) : string =
            names
            |> List.map (fun name -> $$"""x.{{name}}""")
            |> String.concat ",\n"

        match relation with
        | OneToOne(r) -> 
            $$"""
                Field<{{r.Destination}}GraphType, {{r.Destination}}>("{{r.Destination.Pluralize()}}")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{r.KeyType.ToString()}}, {{r.Destination}}GraphType>(
                            "{{entity}}-{{r.Destination}}-loader",
                            async ids => 
                            {
                                var data = await dbContext.{{r.Destination.Pluralize()}}
                                    .Where(x => x.{{r.Name}} != null && ids.Contains(({{r.KeyType.ToString()}})x.{{r.Name}}))
                                    .Select(x => new
                                    {
                                        Key = ({{r.KeyType.ToString()}})x.{{r.Name}}!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.{{r.Destination.Pluralize()}});
                    });
            """
        | SingleManyToOne(r) -> 
            $$"""
                Field<{{r.Destination}}GraphType, {{r.Destination}}>("{{r.Destination.Pluralize()}}")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{r.KeyType.ToString()}}, {{r.Destination}}GraphType>(
                            "{{entity}}-{{r.Destination}}-loader",
                            async ids => 
                            {
                                var data = await dbContext.{{r.Destination.Pluralize()}}
                                    .Where(x => x.{{r.Name}} != null && ids.Contains(({{r.KeyType.ToString()}})x.{{r.Name}}))
                                    .Select(x => new
                                    {
                                        Key = ({{r.KeyType.ToString()}})x.{{r.Name}}!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.{{r.Name}});
                });
            """
        | MultipleManyToOne(r) -> 
            $$"""
                Field<{{r.Destination}}GraphType, {{r.Destination}}>("{{r.Destination.Pluralize()}}")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{r.KeyType.ToString()}}, {{r.Destination}}GraphType>(
                            "{{entity}}-{{r.Destination}}-loader",
                            async ids => 
                            {
                                Expression<Func<{{r.Destination}}, bool>> expr = x => !ids.Any()
                                    {{getExpressionStatements(r.Names, r)}};

                                var data = await dbContext.{{r.Destination.Pluralize()}}
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<{{r.KeyType.ToString()}}?>()
                                    {
                                        {{getMappingStatements(r.Names, r)}}
                                    }.OfType<{{r.KeyType.ToString()}}>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.{{r.Destination.Pluralize()}});
                    });
            """
        | OneToMany(r) -> 
            $$"""
                Field<{{r.Destination}}GraphType, {{r.Destination}}>("{{r.Destination.Pluralize()}}")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{r.KeyType.ToString()}}, IEnumerable<{{r.Destination}}GraphType>>(
                            "{{entity}}-{{r.Destination}}-loader",
                            async ids => 
                            {
                                var data = await dbContext.{{r.Destination.Pluralize()}}
                                    .Where(x => x.{{r.Name}} != null && ids.Contains(({{r.KeyType.ToString()}})x.{{r.Name}}))
                                    .Select(x => new
                                    {
                                        Key = ({{r.KeyType.ToString()}})x.{{r.Name}}!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.{{r.Destination.Pluralize()}});
                    });
            """
        | ManyToManyWithJoinTable(r) -> 
            let destinationForeignKeyOnJoinTable = 
                let filteredFks = r.JoinTable.ForeignKeys |> List.filter (fun fk -> fk.Type = r.KeyType)
                match filteredFks with
                | [] -> failwith $$"""No foreign keys found on join table '{{r.JoinTable.Name}}' with type '{{r.KeyType}}'. Available foreign keys: {{r.JoinTable.ForeignKeys |> List.map (fun fk -> $"{fk.Name}:{fk.Type}") |> String.concat ", "}}"""
                | head :: _ -> head.Name
            let destinationNavigationPropertyOnJoinTable =
                let filteredNavProps = r.JoinTable.NavigationProperties |> List.filter (fun nav -> nav.Type.ToString() = r.Destination.ToString())
                match filteredNavProps with
                | [] -> failwith $$"""No navigation properties found on join table '{{r.JoinTable.Name}}' pointing to '{{r.Destination}}'. Available navigation properties: {{r.JoinTable.NavigationProperties |> List.map (fun nav -> $"{nav.Name}:{nav.Type}") |> String.concat ", "}}"""
                | head :: _ -> head.Name
            
            $$"""
                Field<{{r.Destination}}GraphType, {{r.Destination}}>("{{r.Destination.Pluralize()}}")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{r.KeyType.ToString()}}, IEnumerable<{{r.Destination}}GraphType>>(
                            "{{entity}}-{{r.Destination}}-loader",
                            async ids => 
                            {
                                var data = await dbContext.{{r.JoinTable.Name}}
                                    .Where(x => x.{{destinationForeignKeyOnJoinTable}} != null && ids.Contains(({{r.KeyType.ToString()}})x.{{destinationForeignKeyOnJoinTable}}))
                                    .Select(x => new
                                    {
                                        Key = ({{r.KeyType.ToString()}})x.{{destinationForeignKeyOnJoinTable}}!,
                                        Value = x.{{destinationNavigationPropertyOnJoinTable}},
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.{{r.Destination.Pluralize()}});
                    });
            """
        | ManyToMany(r) -> 
            $$"""
                Field<{{r.Destination}}GraphType, {{r.Destination}}>("{{r.Destination.Pluralize()}}")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<{{r.KeyType.ToString()}}, {{r.Destination}}GraphType>(
                            "{{entity}}-{{r.Destination}}-loader",
                            async ids => 
                            {
                                var data = await dbContext.{{r.Destination.Pluralize()}}
                                    .Where(x => x.{{r.Name}}.Any(c => ids.Contains(c.{{r.TargetTable.PrimaryKey.Name}})))
                                    .Select(x => new
                                    {
                                        Key = x,
                                        Values = x.{{r.Name}},
                                    })
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => x.Values.Select(v => new { Key = v.{{r.TargetTable.PrimaryKey.Name}}, Value = x.Key }))
                                    .ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.{{r.Destination.Pluralize()}});
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
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WP.Cooking.GESE.WebAPI.Models;
using GraphQL.DataLoader;
using WP.Cooking.GESE.WebAPI.Repositories; 


namespace WP.Cooking.GESE.WebAPI.GraphQL.Types
{
    public partial class {{entity.Name}}GraphType : ObjectGraphType<{{entity.Name}}>
    {
        public {{entity.Name}}GraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            {{mappedFields |> String.concat "\n\t\t\t"}}
            {{mappedRelations |> String.concat "\n\t\t\t"}}
        }
    }
}
            """

            content