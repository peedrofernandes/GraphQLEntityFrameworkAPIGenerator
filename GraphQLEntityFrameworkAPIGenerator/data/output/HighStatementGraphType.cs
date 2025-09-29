
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
    public partial class HighStatementGraphType : ObjectGraphType<HighStatement>
    {
        public HighStatementGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.HighStatementId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Priority, type: typeof(ByteGraphType), nullable: False);
            
            Field<OpCodeGraphType, OpCode>("OpCodes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<OpCodeGraphType>>(
                        "HighStatement-OpCode-loader",
                        async ids => 
                        {
                            var data = await dbContext.ProductTypesHighStatement
                                .Where(x => x.ProductTypeId != null && ids.Contains((byte)x.ProductTypeId))
                                .Select(x => new
                                {
                                    Key = (byte)x.ProductTypeId!,
                                    Value = x.OpCodeNavigation,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.OpCodes);
                });
            
			
            Field<ProductTypeGraphType, ProductType>("ProductTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<ProductTypeGraphType>>(
                        "HighStatement-ProductType-loader",
                        async ids => 
                        {
                            var data = await dbContext.ProductTypesHighStatement
                                .Where(x => x.ProductTypeId != null && ids.Contains((byte)x.ProductTypeId))
                                .Select(x => new
                                {
                                    Key = (byte)x.ProductTypeId!,
                                    Value = x.ProductType,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.ProductTypes);
                });
            
        }
    }
}
            