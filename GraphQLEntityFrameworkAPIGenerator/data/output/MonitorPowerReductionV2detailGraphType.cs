
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
    public partial class MonitorPowerReductionV2detailGraphType : ObjectGraphType<MonitorPowerReductionV2detail>
    {
        public MonitorPowerReductionV2detailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorPowerReductionV2detailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.TemperatureNodeNameId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureCalculationParametersType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Slope, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Offset, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempSensorId, type: typeof(FloatGraphType), nullable: False);
            
            Field<MonitorPowerReductionV2configurationGraphType, MonitorPowerReductionV2configuration>("MonitorPowerReductionV2configurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorPowerReductionV2configurationGraphType>>(
                        "MonitorPowerReductionV2detail-MonitorPowerReductionV2configuration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorPowerReductionV2configurationMonitorPowerReductionV2detail
                                .Where(x => x.MonitorPowerReductionV2configurationId != null && ids.Contains((Guid)x.MonitorPowerReductionV2configurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorPowerReductionV2configurationId!,
                                    Value = x.MonitorPowerReductionV2configuration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorPowerReductionV2configurations);
                });
            
			
            Field<MonitorPowerReductionV2estimatedTempConfigurationGraphType, MonitorPowerReductionV2estimatedTempConfiguration>("MonitorPowerReductionV2estimatedTempConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorPowerReductionV2estimatedTempConfigurationGraphType>(
                        "MonitorPowerReductionV2detail-MonitorPowerReductionV2estimatedTempConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorPowerReductionV2estimatedTempConfigurations
                                .Where(x => x.MonitorPowerReductionV2estimatedTempConfiguration != null && ids.Contains((Guid)x.MonitorPowerReductionV2estimatedTempConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorPowerReductionV2estimatedTempConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorPowerReductionV2estimatedTempConfiguration);
                });
            
			
            Field<MonitorPowerReductionV2powerRedConfigurationGraphType, MonitorPowerReductionV2powerRedConfiguration>("MonitorPowerReductionV2powerRedConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorPowerReductionV2powerRedConfigurationGraphType>(
                        "MonitorPowerReductionV2detail-MonitorPowerReductionV2powerRedConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorPowerReductionV2powerRedConfigurations
                                .Where(x => x.MonitorPowerReductionV2powerRedConfiguration != null && ids.Contains((Guid)x.MonitorPowerReductionV2powerRedConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorPowerReductionV2powerRedConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorPowerReductionV2powerRedConfiguration);
                });
            
        }
    }
}
            