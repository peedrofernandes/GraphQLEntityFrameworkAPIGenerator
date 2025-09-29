
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
    public partial class CycleMappingUriGraphType : ObjectGraphType<CycleMappingUri>
    {
        public CycleMappingUriGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UriTreeId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfTrees, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SetCycleTreeLevels1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.SetCycleTree1, type: typeof(ListGraphType<ByteGraphType>), nullable: True);
			Field(t => t.SetCycleTreeLevels2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.SetCycleTree2, type: typeof(ListGraphType<ByteGraphType>), nullable: True);
			Field(t => t.SetCycleTreeLevels3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.SetCycleTree3, type: typeof(ListGraphType<ByteGraphType>), nullable: True);
			Field(t => t.SetCycleTreeLevels4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.SetCycleTree4, type: typeof(ListGraphType<ByteGraphType>), nullable: True);
            
            Field<CycleMappingGraphType, CycleMapping>("CycleMappings")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingGraphType>>(
                        "CycleMappingUri-CycleMapping-loader",
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
            
			
            Field<CycleOptionsConfigurationGraphType, CycleOptionsConfiguration>("CycleOptionsConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsConfigurationGraphType>>(
                        "CycleMappingUri-CycleOptionsConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappingCycleOptionsConfiguration
                                .Where(x => x.CycleMappingId != null && ids.Contains((Guid)x.CycleMappingId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleMappingId!,
                                    Value = x.CycleOptionsConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleOptionsConfigurations);
                });
            
        }
    }
}
            