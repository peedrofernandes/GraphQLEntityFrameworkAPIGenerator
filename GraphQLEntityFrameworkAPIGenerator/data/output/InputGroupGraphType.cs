
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
    public partial class InputGroupGraphType : ObjectGraphType<InputGroup>
    {
        public InputGroupGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InputGroupId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputGroupDesc, type: typeof(StringGraphType), nullable: False);
            
            Field<InputGraphType, Input>("Inputs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, InputGraphType>(
                        "InputGroup-Input-loader",
                        async ids => 
                        {
                            var data = await dbContext.Inputs
                                .Where(x => x.Input.Any(c => ids.Contains(c.InputId)))
                                .Select(x => new
                                {
                                    Key = x,
                                    Values = x.Input,
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.Values.Select(v => new { Key = v.InputId, Value = x.Key }))
                                .ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Inputs);
                });
            
        }
    }
}
            