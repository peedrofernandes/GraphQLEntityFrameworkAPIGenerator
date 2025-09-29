
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
    public partial class StmSetupTempSelectorGraphType : ObjectGraphType<StmSetupTempSelector>
    {
        public StmSetupTempSelectorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
            
            Field<HeatInitializeGraphType, HeatInitialize>("HeatInitializes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, HeatInitializeGraphType>(
                        "StmSetupTempSelector-HeatInitialize-loader",
                        async ids => 
                        {
                            var data = await dbContext.HeatInitializes
                                .Where(x => x.HeatInitialize != null && ids.Contains((Guid)x.HeatInitialize))
                                .Select(x => new
                                {
                                    Key = (Guid)x.HeatInitialize!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.HeatInitialize);
                });
            
        }
    }
}
            