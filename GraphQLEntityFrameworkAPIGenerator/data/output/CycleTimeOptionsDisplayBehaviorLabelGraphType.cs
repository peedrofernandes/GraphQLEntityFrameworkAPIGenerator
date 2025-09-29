
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
    public partial class CycleTimeOptionsDisplayBehaviorLabelGraphType : ObjectGraphType<CycleTimeOptionsDisplayBehaviorLabel>
    {
        public CycleTimeOptionsDisplayBehaviorLabelGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Behavior, type: typeof(StringGraphType), nullable: False);
            
            Field<CycleOptionsPrmTimeGraphType, CycleOptionsPrmTime>("CycleOptionsPrmTimes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsPrmTimeGraphType>>(
                        "CycleTimeOptionsDisplayBehaviorLabel-CycleOptionsPrmTime-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleOptionsPrmTimes
                                .Where(x => x.CycleOptionsPrmTime != null && ids.Contains((Guid)x.CycleOptionsPrmTime))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleOptionsPrmTime!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.CycleOptionsPrmTimes);
                });
            
        }
    }
}
            