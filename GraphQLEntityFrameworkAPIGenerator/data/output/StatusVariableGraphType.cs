
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
    public partial class StatusVariableGraphType : ObjectGraphType<StatusVariable>
    {
        public StatusVariableGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.StatusVariableId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.StatusVariables, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.StatusVariableGroups, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
            
            Field<DisplayGraphType, Display>("Displays")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DisplayGraphType>>(
                        "StatusVariable-Display-loader",
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
            
			
            Field<ProductTypeGraphType, ProductType>("ProductTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ProductTypeGraphType>(
                        "StatusVariable-ProductType-loader",
                        async ids => 
                        {
                            var data = await dbContext.ProductTypes
                                .Where(x => x.ProductType != null && ids.Contains((byte)x.ProductType))
                                .Select(x => new
                                {
                                    Key = (byte)x.ProductType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.ProductType);
                });
            
        }
    }
}
            