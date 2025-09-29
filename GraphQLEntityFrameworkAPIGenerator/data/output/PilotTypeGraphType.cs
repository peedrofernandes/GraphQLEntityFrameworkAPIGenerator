
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
    public partial class PilotTypeGraphType : ObjectGraphType<PilotType>
    {
        public PilotTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PilotTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PilotTypeDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.NumPins, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NeedParams, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.NeedFeedbacks, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsSafetyRelevant, type: typeof(BoolGraphType), nullable: False);
            
            Field<LoadDetailGraphType, LoadDetail>("LoadDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LoadDetailGraphType>>(
                        "PilotType-LoadDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.LoadDetails
                                .Where(x => x.LoadDetail != null && ids.Contains((Guid)x.LoadDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.LoadDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.LoadDetails);
                });
            
			
            Field<MultiDriverPilotTypeGraphType, MultiDriverPilotType>("MultiDriverPilotTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, MultiDriverPilotTypeGraphType>(
                        "PilotType-MultiDriverPilotType-loader",
                        async ids => 
                        {
                            var data = await dbContext.MultiDriverPilotTypes
                                .Where(x => x.MultiDriverPilotType != null && ids.Contains((byte)x.MultiDriverPilotType))
                                .Select(x => new
                                {
                                    Key = (byte)x.MultiDriverPilotType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MultiDriverPilotTypes);
                });
            
			
            Field<MultiSequencePilotTypeGraphType, MultiSequencePilotType>("MultiSequencePilotTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, MultiSequencePilotTypeGraphType>(
                        "PilotType-MultiSequencePilotType-loader",
                        async ids => 
                        {
                            var data = await dbContext.MultiSequencePilotTypes
                                .Where(x => x.MultiSequencePilotType != null && ids.Contains((byte)x.MultiSequencePilotType))
                                .Select(x => new
                                {
                                    Key = (byte)x.MultiSequencePilotType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MultiSequencePilotTypes);
                });
            
			
            Field<PrmPilotMultiDriverGraphType, PrmPilotMultiDriver>("PrmPilotMultiDrivers")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmPilotMultiDriverGraphType>>(
                        "PilotType-PrmPilotMultiDriver-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrmPilotMultiDrivers
                                .Where(x => x.PrmPilotMultiDriver != null && ids.Contains((Guid)x.PrmPilotMultiDriver))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrmPilotMultiDriver!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.PrmPilotMultiDrivers);
                });
            
			
            Field<LoadTypeGraphType, LoadType>("LoadTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, LoadTypeGraphType>(
                        "PilotType-LoadType-loader",
                        async ids => 
                        {
                            var data = await dbContext.LoadTypes
                                .Where(x => x.LoadType.Any(c => ids.Contains(c.LoadTypeId)))
                                .Select(x => new
                                {
                                    Key = x,
                                    Values = x.LoadType,
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.Values.Select(v => new { Key = v.LoadTypeId, Value = x.Key }))
                                .ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.LoadTypes);
                });
            
        }
    }
}
            