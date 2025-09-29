
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
    public partial class PrtimerBroilConfigurationGraphType : ObjectGraphType<PrtimerBroilConfiguration>
    {
        public PrtimerBroilConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerBroilConfigId, type: typeof(GuidGraphType), nullable: False);
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
            
            Field<PowerReductionTimerConfigurationGraphType, PowerReductionTimerConfiguration>("PowerReductionTimerConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PowerReductionTimerConfigurationGraphType>>(
                        "PrtimerBroilConfiguration-PowerReductionTimerConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PowerReductionTimerConfigurations
                                .Where(x => x.PowerReductionTimerConfiguration != null && ids.Contains((Guid)x.PowerReductionTimerConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PowerReductionTimerConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.PowerReductionTimerConfigurations);
                });
            
			
            Field<PrtimerBroilUserPhaseNameConfigurationGraphType, PrtimerBroilUserPhaseNameConfiguration>("PrtimerBroilUserPhaseNameConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerBroilUserPhaseNameConfigurationGraphType>>(
                        "PrtimerBroilConfiguration-PrtimerBroilUserPhaseNameConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration
                                .Where(x => x.PrtimerBroilConfigId != null && ids.Contains((Guid)x.PrtimerBroilConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerBroilConfigId!,
                                    Value = x.PrtimerBroilUserPhaseNameConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerBroilUserPhaseNameConfigurations);
                });
            
			
            Field<PrtimerBroilTimerLimitConfigurationGraphType, PrtimerBroilTimerLimitConfiguration>("PrtimerBroilTimerLimitConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerBroilTimerLimitConfigurationGraphType>(
                        "PrtimerBroilConfiguration-PrtimerBroilTimerLimitConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerBroilTimerLimitConfigurations
                                .Where(x => x.PrtimerBroilTimerLimitConfiguration != null && ids.Contains((Guid)x.PrtimerBroilTimerLimitConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerBroilTimerLimitConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerBroilTimerLimitConfiguration);
                });
            
        }
    }
}
            