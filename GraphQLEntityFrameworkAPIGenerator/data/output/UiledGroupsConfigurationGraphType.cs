
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
    public partial class UiledGroupsConfigurationGraphType : ObjectGraphType<UiledGroupsConfiguration>
    {
        public UiledGroupsConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledGroupsConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<DisplayGraphType, Display>("Displays")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DisplayGraphType>>(
                        "UiledGroupsConfiguration-Display-loader",
                        async ids => 
                        {
                            var data = await dbContext.Displays
                                .Where(x => x.Display != null && ids.Contains((Guid)x.Display))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Display!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Displays);
                });
            
			
            Field<UiledConfigurationGraphType, UiledConfiguration>("UiledConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiledConfigurationGraphType>(
                        "UiledGroupsConfiguration-UiledConfiguration-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiledConfiguration);
                });
            
			
            Field<UiledGroupGraphType, UiledGroup>("UiledGroups")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledGroupGraphType>>(
                        "UiledGroupsConfiguration-UiledGroup-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiledGroupsConfigurationsUiledGroup
                                .Where(x => x.UiledGroupsConfigurationsId != null && ids.Contains((Guid)x.UiledGroupsConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiledGroupsConfigurationsId!,
                                    Value = x.UiledGroups,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiledGroups);
                });
            
        }
    }
}
            