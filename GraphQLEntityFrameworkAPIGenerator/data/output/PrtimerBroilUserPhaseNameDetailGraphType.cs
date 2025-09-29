
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
    public partial class PrtimerBroilUserPhaseNameDetailGraphType : ObjectGraphType<PrtimerBroilUserPhaseNameDetail>
    {
        public PrtimerBroilUserPhaseNameDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerBroilUserPhaseNameDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TimerIncrement, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimit, type: typeof(ByteGraphType), nullable: False);
            
            Field<PrtimerBroilUserPhaseNameConfigurationGraphType, PrtimerBroilUserPhaseNameConfiguration>("PrtimerBroilUserPhaseNameConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerBroilUserPhaseNameConfigurationGraphType>>(
                        "PrtimerBroilUserPhaseNameDetail-PrtimerBroilUserPhaseNameConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail
                                .Where(x => x.PrtimerBroilUserPhaseNameConfigId != null && ids.Contains((Guid)x.PrtimerBroilUserPhaseNameConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerBroilUserPhaseNameConfigId!,
                                    Value = x.PrtimerBroilUserPhaseNameConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerBroilUserPhaseNameConfigurations);
                });
            
        }
    }
}
            