
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
    public partial class UiledGroupGraphType : ObjectGraphType<UiledGroup>
    {
        public UiledGroupGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledGroupsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.LedFunctionId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
            
            Field<UiledGroupsConfigurationGraphType, UiledGroupsConfiguration>("UiledGroupsConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledGroupsConfigurationGraphType>>(
                        "UiledGroup-UiledGroupsConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiledGroupsConfigurationsUiledGroup
                                .Where(x => x.UiledGroupsConfigurationsId != null && ids.Contains((Guid)x.UiledGroupsConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiledGroupsConfigurationsId!,
                                    Value = x.UiledGroupsConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiledGroupsConfigurations);
                });
            
			
            Field<UiledGroupsDetailGraphType, UiledGroupsDetail>("UiledGroupsDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledGroupsDetailGraphType>>(
                        "UiledGroup-UiledGroupsDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiledGroupsUiledGroupsDetail
                                .Where(x => x.UiledGroupsId != null && ids.Contains((Guid)x.UiledGroupsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiledGroupsId!,
                                    Value = x.UiledGroupsDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiledGroupsDetails);
                });
            
        }
    }
}
            