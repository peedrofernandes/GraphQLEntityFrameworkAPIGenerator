
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
    public partial class UioperatorGraphType : ObjectGraphType<Uioperator>
    {
        public UioperatorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UioperatorId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Uioperator1, type: typeof(StringGraphType), nullable: False);
            
            Field<UiconditionBlockGraphType, UiconditionBlock>("UiconditionBlocks")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiconditionBlockGraphType>>(
                        "Uioperator-UiconditionBlock-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiconditionBlocks
                                .Where(x => x.UiconditionBlock != null && ids.Contains((Guid)x.UiconditionBlock))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiconditionBlock!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UiconditionBlocks);
                });
            
        }
    }
}
            