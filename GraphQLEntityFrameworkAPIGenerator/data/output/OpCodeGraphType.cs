
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
    public partial class OpCodeGraphType : ObjectGraphType<OpCode>
    {
        public OpCodeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.OpCode1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Statement, type: typeof(StringGraphType), nullable: False);
            
            Field<HighStatementGraphType, HighStatement>("HighStatements")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, IEnumerable<HighStatementGraphType>>(
                        "OpCode-HighStatement-loader",
                        async ids => 
                        {
                            var data = await dbContext.ProductTypesHighStatement
                                .Where(x => x.HighStatementId != null && ids.Contains((int)x.HighStatementId))
                                .Select(x => new
                                {
                                    Key = (int)x.HighStatementId!,
                                    Value = x.HighStatement,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.HighStatements);
                });
            
			
            Field<ProductTypeGraphType, ProductType>("ProductTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<ProductTypeGraphType>>(
                        "OpCode-ProductType-loader",
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
            