
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
    public partial class PrtimerBroilTimerLimitConfigurationGraphType : ObjectGraphType<PrtimerBroilTimerLimitConfiguration>
    {
        public PrtimerBroilTimerLimitConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerBroilTimerLimitConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfLevels, type: typeof(ByteGraphType), nullable: False);
            
            Field<PrtimerBroilConfigurationGraphType, PrtimerBroilConfiguration>("PrtimerBroilConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerBroilConfigurationGraphType>>(
                        "PrtimerBroilTimerLimitConfiguration-PrtimerBroilConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerBroilConfigurations
                                .Where(x => x.PrtimerBroilConfiguration != null && ids.Contains((Guid)x.PrtimerBroilConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerBroilConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.PrtimerBroilConfigurations);
                });
            
			
            Field<PrtimerBroilTimerLimitDetailGraphType, PrtimerBroilTimerLimitDetail>("PrtimerBroilTimerLimitDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerBroilTimerLimitDetailGraphType>>(
                        "PrtimerBroilTimerLimitConfiguration-PrtimerBroilTimerLimitDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail
                                .Where(x => x.PrtimerBroilTimerLimitConfigId != null && ids.Contains((Guid)x.PrtimerBroilTimerLimitConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerBroilTimerLimitConfigId!,
                                    Value = x.PrtimerBroilTimerLimitDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerBroilTimerLimitDetails);
                });
            
        }
    }
}
            