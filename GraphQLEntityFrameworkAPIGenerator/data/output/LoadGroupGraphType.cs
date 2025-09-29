
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
    public partial class LoadGroupGraphType : ObjectGraphType<LoadGroup>
    {
        public LoadGroupGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LoadGroupId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadGroupDsc, type: typeof(StringGraphType), nullable: False);
            
            Field<LoadGraphType, Load>("Loads")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, LoadGraphType>(
                        "LoadGroup-Load-loader",
                        async ids => 
                        {
                            var data = await dbContext.Loads
                                .Where(x => x.Load.Any(c => ids.Contains(c.LoadId)))
                                .Select(x => new
                                {
                                    Key = x,
                                    Values = x.Load,
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.Values.Select(v => new { Key = v.LoadId, Value = x.Key }))
                                .ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Loads);
                });
            
        }
    }
}
            