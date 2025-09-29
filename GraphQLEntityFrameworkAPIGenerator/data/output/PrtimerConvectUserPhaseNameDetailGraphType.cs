
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
    public partial class PrtimerConvectUserPhaseNameDetailGraphType : ObjectGraphType<PrtimerConvectUserPhaseNameDetail>
    {
        public PrtimerConvectUserPhaseNameDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerConvectUserPhaseNameDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TimerIncrement, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimit, type: typeof(ByteGraphType), nullable: False);
            
            Field<PrtimerConvectUserPhaseNameConfigurationGraphType, PrtimerConvectUserPhaseNameConfiguration>("PrtimerConvectUserPhaseNameConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerConvectUserPhaseNameConfigurationGraphType>>(
                        "PrtimerConvectUserPhaseNameDetail-PrtimerConvectUserPhaseNameConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail
                                .Where(x => x.PrtimerConvectUserPhaseNameConfigId != null && ids.Contains((Guid)x.PrtimerConvectUserPhaseNameConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerConvectUserPhaseNameConfigId!,
                                    Value = x.PrtimerConvectUserPhaseNameConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerConvectUserPhaseNameConfigurations);
                });
            
        }
    }
}
            