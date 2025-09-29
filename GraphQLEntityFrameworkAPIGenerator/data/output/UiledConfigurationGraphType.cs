
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
    public partial class UiledConfigurationGraphType : ObjectGraphType<UiledConfiguration>
    {
        public UiledConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<UiledDriverParameterGraphType, UiledDriverParameter>("UiledDriverParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledDriverParameterGraphType>>(
                        "UiledConfiguration-UiledDriverParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiledConfigurationsUiledDriverParameter
                                .Where(x => x.UiledConfigurationsId != null && ids.Contains((Guid)x.UiledConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiledConfigurationsId!,
                                    Value = x.UiledDriverParameters,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiledDriverParameters);
                });
            
			
            Field<UiledFunctionMappingConfigurationGraphType, UiledFunctionMappingConfiguration>("UiledFunctionMappingConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiledFunctionMappingConfigurationGraphType>(
                        "UiledConfiguration-UiledFunctionMappingConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiledFunctionMappingConfigurations
                                .Where(x => x.UiledFunctionMappingConfiguration != null && ids.Contains((Guid)x.UiledFunctionMappingConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiledFunctionMappingConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiledFunctionMappingConfiguration);
                });
            
			
            Field<UiledGroupsConfigurationGraphType, UiledGroupsConfiguration>("UiledGroupsConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledGroupsConfigurationGraphType>>(
                        "UiledConfiguration-UiledGroupsConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiledGroupsConfigurations
                                .Where(x => x.UiledGroupsConfiguration != null && ids.Contains((Guid)x.UiledGroupsConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiledGroupsConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UiledGroupsConfigurations);
                });
            
        }
    }
}
            