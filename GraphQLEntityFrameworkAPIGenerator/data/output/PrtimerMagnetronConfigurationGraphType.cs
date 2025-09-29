
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
    public partial class PrtimerMagnetronConfigurationGraphType : ObjectGraphType<PrtimerMagnetronConfiguration>
    {
        public PrtimerMagnetronConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerMagnetronConfigId, type: typeof(GuidGraphType), nullable: False);
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
                        "PrtimerMagnetronConfiguration-PowerReductionTimerConfiguration-loader",
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
            
			
            Field<PrtimerMagnetronUserPhaseNameConfigurationGraphType, PrtimerMagnetronUserPhaseNameConfiguration>("PrtimerMagnetronUserPhaseNameConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerMagnetronUserPhaseNameConfigurationGraphType>>(
                        "PrtimerMagnetronConfiguration-PrtimerMagnetronUserPhaseNameConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration
                                .Where(x => x.PrtimerMagnetronConfigId != null && ids.Contains((Guid)x.PrtimerMagnetronConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerMagnetronConfigId!,
                                    Value = x.PrtimerMagnetronUserPhaseNameConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerMagnetronUserPhaseNameConfigurations);
                });
            
			
            Field<PrtimerMagnetronTimerLimitConfigurationGraphType, PrtimerMagnetronTimerLimitConfiguration>("PrtimerMagnetronTimerLimitConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerMagnetronTimerLimitConfigurationGraphType>(
                        "PrtimerMagnetronConfiguration-PrtimerMagnetronTimerLimitConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerMagnetronTimerLimitConfigurations
                                .Where(x => x.PrtimerMagnetronTimerLimitConfiguration != null && ids.Contains((Guid)x.PrtimerMagnetronTimerLimitConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerMagnetronTimerLimitConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerMagnetronTimerLimitConfiguration);
                });
            
        }
    }
}
            