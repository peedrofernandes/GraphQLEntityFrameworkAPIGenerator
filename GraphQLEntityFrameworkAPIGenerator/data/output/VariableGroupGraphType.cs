
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
    public partial class VariableGroupGraphType : ObjectGraphType<VariableGroup>
    {
        public VariableGroupGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.VariableGroupId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VariableGroupDescription, type: typeof(StringGraphType), nullable: False);
            
            Field<VariableGraphType, Variable>("Variables")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, VariableGraphType>(
                        "VariableGroup-Variable-loader",
                        async ids => 
                        {
                            var data = await dbContext.Variables
                                .Where(x => x.Variable.Any(c => ids.Contains(c.VariableId)))
                                .Select(x => new
                                {
                                    Key = x,
                                    Values = x.Variable,
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.Values.Select(v => new { Key = v.VariableId, Value = x.Key }))
                                .ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Variables);
                });
            
        }
    }
}
            