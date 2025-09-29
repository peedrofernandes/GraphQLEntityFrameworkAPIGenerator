
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
    public partial class PrtimerBroilTimerLimitDetailGraphType : ObjectGraphType<PrtimerBroilTimerLimitDetail>
    {
        public PrtimerBroilTimerLimitDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerBroilTimerLimitDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TimerLimit, type: typeof(LongGraphType), nullable: False);
            
            Field<PrtimerBroilTimerLimitConfigurationGraphType, PrtimerBroilTimerLimitConfiguration>("PrtimerBroilTimerLimitConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerBroilTimerLimitConfigurationGraphType>>(
                        "PrtimerBroilTimerLimitDetail-PrtimerBroilTimerLimitConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail
                                .Where(x => x.PrtimerBroilTimerLimitConfigId != null && ids.Contains((Guid)x.PrtimerBroilTimerLimitConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerBroilTimerLimitConfigId!,
                                    Value = x.PrtimerBroilTimerLimitConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerBroilTimerLimitConfigurations);
                });
            
        }
    }
}
            