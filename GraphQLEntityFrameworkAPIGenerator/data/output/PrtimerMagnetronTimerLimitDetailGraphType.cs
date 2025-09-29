
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
    public partial class PrtimerMagnetronTimerLimitDetailGraphType : ObjectGraphType<PrtimerMagnetronTimerLimitDetail>
    {
        public PrtimerMagnetronTimerLimitDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerMagnetronTimerLimitDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TimerLimit, type: typeof(LongGraphType), nullable: False);
            
            Field<PrtimerMagnetronTimerLimitConfigurationGraphType, PrtimerMagnetronTimerLimitConfiguration>("PrtimerMagnetronTimerLimitConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerMagnetronTimerLimitConfigurationGraphType>>(
                        "PrtimerMagnetronTimerLimitDetail-PrtimerMagnetronTimerLimitConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail
                                .Where(x => x.PrtimerMagnetronTimerLimitConfigId != null && ids.Contains((Guid)x.PrtimerMagnetronTimerLimitConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerMagnetronTimerLimitConfigId!,
                                    Value = x.PrtimerMagnetronTimerLimitConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerMagnetronTimerLimitConfigurations);
                });
            
        }
    }
}
            