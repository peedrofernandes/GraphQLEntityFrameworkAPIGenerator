
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
    public partial class CycleOptionsConfigurationGraphType : ObjectGraphType<CycleOptionsConfiguration>
    {
        public CycleOptionsConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleOptionsConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<CycleMappingGraphType, CycleMapping>("CycleMappings")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingGraphType>>(
                        "CycleOptionsConfiguration-CycleMapping-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappingCycleOptionsConfiguration
                                .Where(x => x.CycleMappingId != null && ids.Contains((Guid)x.CycleMappingId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleMappingId!,
                                    Value = x.CycleMapping,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleMappings);
                });
            
			
            Field<CycleMappingUriGraphType, CycleMappingUri>("CycleMappingUris")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingUriGraphType>>(
                        "CycleOptionsConfiguration-CycleMappingUri-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappingCycleOptionsConfiguration
                                .Where(x => x.CycleMappingId != null && ids.Contains((Guid)x.CycleMappingId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleMappingId!,
                                    Value = x.UriTree,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleMappingUris);
                });
            
			
            Field<CycleOptionsDetailGraphType, CycleOptionsDetail>("CycleOptionsDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsDetailGraphType>>(
                        "CycleOptionsConfiguration-CycleOptionsDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleOptionsConfigurationsCycleOptionsDetail
                                .Where(x => x.CycleOptionsConfigurationsId != null && ids.Contains((Guid)x.CycleOptionsConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleOptionsConfigurationsId!,
                                    Value = x.CycleOptionsDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleOptionsDetails);
                });
            
        }
    }
}
            