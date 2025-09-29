
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
    public partial class UitouchDeviceGraphType : ObjectGraphType<UitouchDevice>
    {
        public UitouchDeviceGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UitouchDevicesId, type: typeof(GuidGraphType), nullable: False);
            
            Field<DisplayGraphType, Display>("Displays")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DisplayGraphType>>(
                        "UitouchDevice-Display-loader",
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
            
			
            Field<UicypressTouchParameterGraphType, UicypressTouchParameter>("UicypressTouchParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UicypressTouchParameterGraphType>(
                        "UitouchDevice-UicypressTouchParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.UicypressTouchParameters
                                .Where(x => x.UicypressTouchParameter != null && ids.Contains((Guid)x.UicypressTouchParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UicypressTouchParameter!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UicypressTouchParameter);
                });
            
			
            Field<UitouchLeanGraphType, UitouchLean>("UitouchLeans")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UitouchLeanGraphType>(
                        "UitouchDevice-UitouchLean-loader",
                        async ids => 
                        {
                            var data = await dbContext.UitouchLeans
                                .Where(x => x.UitouchLean != null && ids.Contains((Guid)x.UitouchLean))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UitouchLean!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UitouchLean);
                });
            
        }
    }
}
            