
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
    public partial class PowerReductionTimerConfigurationGraphType : ObjectGraphType<PowerReductionTimerConfiguration>
    {
        public PowerReductionTimerConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PowerReductionTimerConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Compartment, type: typeof(StringGraphType), nullable: False);
            
            Field<MonitorPowerReductionGraphType, MonitorPowerReduction>("MonitorPowerReductions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorPowerReductionGraphType>>(
                        "PowerReductionTimerConfiguration-MonitorPowerReduction-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorPowerReductions
                                .Where(x => x.MonitorPowerReduction != null && ids.Contains((Guid)x.MonitorPowerReduction))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorPowerReduction!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.MonitorPowerReductions);
                });
            
			
            Field<PrtimerBroilConfigurationGraphType, PrtimerBroilConfiguration>("PrtimerBroilConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerBroilConfigurationGraphType>(
                        "PowerReductionTimerConfiguration-PrtimerBroilConfiguration-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerBroilConfiguration);
                });
            
			
            Field<PrtimerBroilTimerDecrementGraphType, PrtimerBroilTimerDecrement>("PrtimerBroilTimerDecrements")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerBroilTimerDecrementGraphType>(
                        "PowerReductionTimerConfiguration-PrtimerBroilTimerDecrement-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerBroilTimerDecrements
                                .Where(x => x.PrtimerBroilTimerDecrement != null && ids.Contains((Guid)x.PrtimerBroilTimerDecrement))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerBroilTimerDecrement!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerBroilTimerDecrement);
                });
            
			
            Field<PrtimerConvectConfigurationGraphType, PrtimerConvectConfiguration>("PrtimerConvectConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerConvectConfigurationGraphType>(
                        "PowerReductionTimerConfiguration-PrtimerConvectConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerConvectConfigurations
                                .Where(x => x.PrtimerConvectConfiguration != null && ids.Contains((Guid)x.PrtimerConvectConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerConvectConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerConvectConfiguration);
                });
            
			
            Field<PrtimerConvectTimerDecrementGraphType, PrtimerConvectTimerDecrement>("PrtimerConvectTimerDecrements")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerConvectTimerDecrementGraphType>(
                        "PowerReductionTimerConfiguration-PrtimerConvectTimerDecrement-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerConvectTimerDecrements
                                .Where(x => x.PrtimerConvectTimerDecrement != null && ids.Contains((Guid)x.PrtimerConvectTimerDecrement))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerConvectTimerDecrement!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerConvectTimerDecrement);
                });
            
			
            Field<PrtimerMagnetronConfigurationGraphType, PrtimerMagnetronConfiguration>("PrtimerMagnetronConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerMagnetronConfigurationGraphType>(
                        "PowerReductionTimerConfiguration-PrtimerMagnetronConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerMagnetronConfigurations
                                .Where(x => x.PrtimerMagnetronConfiguration != null && ids.Contains((Guid)x.PrtimerMagnetronConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerMagnetronConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerMagnetronConfiguration);
                });
            
			
            Field<PrtimerMagnetronTimerDecrementGraphType, PrtimerMagnetronTimerDecrement>("PrtimerMagnetronTimerDecrements")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerMagnetronTimerDecrementGraphType>(
                        "PowerReductionTimerConfiguration-PrtimerMagnetronTimerDecrement-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerMagnetronTimerDecrements
                                .Where(x => x.PrtimerMagnetronTimerDecrement != null && ids.Contains((Guid)x.PrtimerMagnetronTimerDecrement))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerMagnetronTimerDecrement!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerMagnetronTimerDecrement);
                });
            
        }
    }
}
            