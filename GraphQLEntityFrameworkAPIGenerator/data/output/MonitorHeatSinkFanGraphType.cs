
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
    public partial class MonitorHeatSinkFanGraphType : ObjectGraphType<MonitorHeatSinkFan>
    {
        public MonitorHeatSinkFanGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorHeatSinkFanId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.StructureVersion, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfFans, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadIndexFan00, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadIndexFan01, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadIndexFan02, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadIndexFan03, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadIndexFan04, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadIndexFan05, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadIndexFan06, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadIndexFan07, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadIndexFan08, type: typeof(ByteGraphType), nullable: False);
            
            Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                        "MonitorHeatSinkFan-MachineConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MachineConfigurations
                                .Where(x => x.MachineConfiguration != null && ids.Contains((Guid)x.MachineConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MachineConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.MachineConfigurations);
                });
            
			
            Field<MonitorHeatSinkFanTemperatureGraphType, MonitorHeatSinkFanTemperature>("MonitorHeatSinkFanTemperatures")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorHeatSinkFanTemperatureGraphType>(
                        "MonitorHeatSinkFan-MonitorHeatSinkFanTemperature-loader",
                        async ids => 
                        {
                            Expression<Func<MonitorHeatSinkFanTemperature, bool>> expr = x => !ids.Any()
                                \|\| (x.TemperatureDsp00ldNavigation != null && ids.Contains((Guid)x.TemperatureDsp00ldNavigation))
\|\| (x.TemperatureDsp01ldNavigation != null && ids.Contains((Guid)x.TemperatureDsp01ldNavigation))
\|\| (x.TemperatureDsp02ldNavigation != null && ids.Contains((Guid)x.TemperatureDsp02ldNavigation))
\|\| (x.TemperatureDsp03ldNavigation != null && ids.Contains((Guid)x.TemperatureDsp03ldNavigation))
\|\| (x.TemperatureDsp04ldNavigation != null && ids.Contains((Guid)x.TemperatureDsp04ldNavigation))
\|\| (x.TemperatureDsp05ldNavigation != null && ids.Contains((Guid)x.TemperatureDsp05ldNavigation))
\|\| (x.TemperatureDsp06ldNavigation != null && ids.Contains((Guid)x.TemperatureDsp06ldNavigation))
\|\| (x.TemperatureDsp07ldNavigation != null && ids.Contains((Guid)x.TemperatureDsp07ldNavigation))
\|\| (x.TemperatureDsp08ldNavigation != null && ids.Contains((Guid)x.TemperatureDsp08ldNavigation));

                            var data = await dbContext.MonitorHeatSinkFanTemperatures
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.TemperatureDsp00ldNavigation,
x.TemperatureDsp01ldNavigation,
x.TemperatureDsp02ldNavigation,
x.TemperatureDsp03ldNavigation,
x.TemperatureDsp04ldNavigation,
x.TemperatureDsp05ldNavigation,
x.TemperatureDsp06ldNavigation,
x.TemperatureDsp07ldNavigation,
x.TemperatureDsp08ldNavigation
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.MonitorHeatSinkFanTemperatures);
                });
            
        }
    }
}
            