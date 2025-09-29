
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
    public partial class LoadGraphType : ObjectGraphType<Load>
    {
        public LoadGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LoadId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.LoadsControl, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsSafetyRelevant, type: typeof(BoolGraphType), nullable: False);
            
            Field<CrossLoadDetailGraphType, CrossLoadDetail>("CrossLoadDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CrossLoadDetailGraphType>>(
                        "Load-CrossLoadDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.CrossLoadDetails
                                .Where(x => x.CrossLoadDetail != null && ids.Contains((Guid)x.CrossLoadDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CrossLoadDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.CrossLoadDetails);
                });
            
			
            Field<LoadDetailGraphType, LoadDetail>("LoadDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LoadDetailGraphType>>(
                        "Load-LoadDetail-loader",
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
            
			
            Field<LoadTypeGraphType, LoadType>("LoadTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, LoadTypeGraphType>(
                        "Load-LoadType-loader",
                        async ids => 
                        {
                            var data = await dbContext.LoadTypes
                                .Where(x => x.LoadType != null && ids.Contains((byte)x.LoadType))
                                .Select(x => new
                                {
                                    Key = (byte)x.LoadType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.LoadType);
                });
            
			
            Field<LoadsControlPilotParameterGraphType, LoadsControlPilotParameter>("LoadsControlPilotParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LoadsControlPilotParameterGraphType>>(
                        "Load-LoadsControlPilotParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.LoadsControlPilotParameters
                                .Where(x => x.LoadsControlPilotParameter != null && ids.Contains((Guid)x.LoadsControlPilotParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.LoadsControlPilotParameter!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.LoadsControlPilotParameters);
                });
            
			
            Field<LoadGroupGraphType, LoadGroup>("LoadGroups")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, LoadGroupGraphType>(
                        "Load-LoadGroup-loader",
                        async ids => 
                        {
                            var data = await dbContext.LoadGroups
                                .Where(x => x.LoadGroup.Any(c => ids.Contains(c.LoadGroupId)))
                                .Select(x => new
                                {
                                    Key = x,
                                    Values = x.LoadGroup,
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.Values.Select(v => new { Key = v.LoadGroupId, Value = x.Key }))
                                .ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.LoadGroups);
                });
            
        }
    }
}
            