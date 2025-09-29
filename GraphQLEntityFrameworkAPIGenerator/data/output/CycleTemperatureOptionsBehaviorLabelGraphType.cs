
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
    public partial class CycleTemperatureOptionsBehaviorLabelGraphType : ObjectGraphType<CycleTemperatureOptionsBehaviorLabel>
    {
        public CycleTemperatureOptionsBehaviorLabelGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Behavior, type: typeof(StringGraphType), nullable: False);
            
            Field<CycleOptionsPrmTemperatureGraphType, CycleOptionsPrmTemperature>("CycleOptionsPrmTemperatures")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsPrmTemperatureGraphType>>(
                        "CycleTemperatureOptionsBehaviorLabel-CycleOptionsPrmTemperature-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleOptionsPrmTemperatures
                                .Where(x => x.CycleOptionsPrmTemperature != null && ids.Contains((Guid)x.CycleOptionsPrmTemperature))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleOptionsPrmTemperature!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.CycleOptionsPrmTemperatures);
                });
            
        }
    }
}
            