
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
    public partial class UianimationConfigurationGraphType : ObjectGraphType<UianimationConfiguration>
    {
        public UianimationConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UianimationConfigurationId, type: typeof(GuidGraphType), nullable: False);
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
                        "UianimationConfiguration-Display-loader",
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
            
			
            Field<UianimationDetailGraphType, UianimationDetail>("UianimationDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UianimationDetailGraphType>>(
                        "UianimationConfiguration-UianimationDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UianimationConfigurationsUianimationDetail
                                .Where(x => x.UianimationConfigurationId != null && ids.Contains((Guid)x.UianimationConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UianimationConfigurationId!,
                                    Value = x.UianimationDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UianimationDetails);
                });
            
        }
    }
}
            