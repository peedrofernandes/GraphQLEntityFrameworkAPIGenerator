
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
    public partial class MonitorHeatSinkFanTemperatureGraphType : ObjectGraphType<MonitorHeatSinkFanTemperature>
    {
        public MonitorHeatSinkFanTemperatureGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorHeatSinkFanTemperatureId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.StructureVersion, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PostMinimum, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PostTimeout, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Hysteresis, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SoftThreshold0, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SoftThreshold1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SoftThreshold2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SoftThreshold3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SoftThreshold4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.HardThreshold0, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.HardThreshold1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.HardThreshold2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.HardThreshold3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.HardThreshold4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PostThreshold, type: typeof(FloatGraphType), nullable: False);
            
            Field<MonitorHeatSinkFanGraphType, MonitorHeatSinkFan>("MonitorHeatSinkFans")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorHeatSinkFanGraphType>>(
                        "MonitorHeatSinkFanTemperature-MonitorHeatSinkFan-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorHeatSinkFans
                                .Where(x => x.MonitorHeatSinkFan != null && ids.Contains((Guid)x.MonitorHeatSinkFan))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorHeatSinkFan!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.MonitorHeatSinkFans);
                });
            
        }
    }
}
            