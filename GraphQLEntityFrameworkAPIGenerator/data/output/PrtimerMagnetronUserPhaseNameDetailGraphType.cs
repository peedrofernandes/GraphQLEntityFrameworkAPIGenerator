
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
    public partial class PrtimerMagnetronUserPhaseNameDetailGraphType : ObjectGraphType<PrtimerMagnetronUserPhaseNameDetail>
    {
        public PrtimerMagnetronUserPhaseNameDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerMagnetronUserPhaseNameDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TimerIncrement, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimit, type: typeof(ByteGraphType), nullable: False);
            
            Field<PrtimerMagnetronUserPhaseNameConfigurationGraphType, PrtimerMagnetronUserPhaseNameConfiguration>("PrtimerMagnetronUserPhaseNameConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerMagnetronUserPhaseNameConfigurationGraphType>>(
                        "PrtimerMagnetronUserPhaseNameDetail-PrtimerMagnetronUserPhaseNameConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail
                                .Where(x => x.PrtimerMagnetronUserPhaseNameConfigId != null && ids.Contains((Guid)x.PrtimerMagnetronUserPhaseNameConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerMagnetronUserPhaseNameConfigId!,
                                    Value = x.PrtimerMagnetronUserPhaseNameConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerMagnetronUserPhaseNameConfigurations);
                });
            
        }
    }
}
            