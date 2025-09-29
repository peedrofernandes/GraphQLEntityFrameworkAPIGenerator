
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
    public partial class UiledFunctionMappingDetailGraphType : ObjectGraphType<UiledFunctionMappingDetail>
    {
        public UiledFunctionMappingDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledFunctionMappingDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.LedName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.LedFunctionId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
            
            Field<UiledFunctionMappingConfigurationGraphType, UiledFunctionMappingConfiguration>("UiledFunctionMappingConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledFunctionMappingConfigurationGraphType>>(
                        "UiledFunctionMappingDetail-UiledFunctionMappingConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiledFunctionMappingConfigurationsUiledFunctionMappingDetail
                                .Where(x => x.UiledFunctionMappingConfigId != null && ids.Contains((Guid)x.UiledFunctionMappingConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiledFunctionMappingConfigId!,
                                    Value = x.UiledFunctionMappingConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiledFunctionMappingConfigurations);
                });
            
        }
    }
}
            