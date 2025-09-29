
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
    public partial class CycleHeadingGraphType : ObjectGraphType<CycleHeading>
    {
        public CycleHeadingGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleHeading1, type: typeof(StringGraphType), nullable: False);
            
            Field<CycleNameGraphType, CycleName>("CycleNames")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, IEnumerable<CycleNameGraphType>>(
                        "CycleHeading-CycleName-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleNames
                                .Where(x => x.CycleName != null && ids.Contains((int)x.CycleName))
                                .Select(x => new
                                {
                                    Key = (int)x.CycleName!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.CycleNames);
                });
            
        }
    }
}
            