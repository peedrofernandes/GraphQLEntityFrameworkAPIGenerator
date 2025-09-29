
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
    public partial class TaskGraphType : ObjectGraphType<Task>
    {
        public TaskGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Task1, type: typeof(StringGraphType), nullable: False);
			Field(t => t.TaskParametersNeeded, type: typeof(BoolGraphType), nullable: False);
            
            Field<ProductTypeGraphType, ProductType>("ProductTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<ProductTypeGraphType>>(
                        "Task-ProductType-loader",
                        async ids => 
                        {
                            var data = await dbContext.ProductTypesTask
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
            