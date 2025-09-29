
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
    public partial class UiledFunctionMappingConfigurationGraphType : ObjectGraphType<UiledFunctionMappingConfiguration>
    {
        public UiledFunctionMappingConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledFunctionMappingConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<UiledConfigurationGraphType, UiledConfiguration>("UiledConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledConfigurationGraphType>>(
                        "UiledFunctionMappingConfiguration-UiledConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiledConfigurations
                                .Where(x => x.UiledConfiguration != null && ids.Contains((Guid)x.UiledConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiledConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UiledConfigurations);
                });
            
			
            Field<UiledFunctionMappingDetailGraphType, UiledFunctionMappingDetail>("UiledFunctionMappingDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledFunctionMappingDetailGraphType>>(
                        "UiledFunctionMappingConfiguration-UiledFunctionMappingDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiledFunctionMappingConfigurationsUiledFunctionMappingDetail
                                .Where(x => x.UiledFunctionMappingConfigId != null && ids.Contains((Guid)x.UiledFunctionMappingConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiledFunctionMappingConfigId!,
                                    Value = x.UiledFunctionMappingDetail,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiledFunctionMappingDetails);
                });
            
        }
    }
}
            