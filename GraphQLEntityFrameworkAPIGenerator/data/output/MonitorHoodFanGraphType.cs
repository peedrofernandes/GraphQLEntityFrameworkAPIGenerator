
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
    public partial class MonitorHoodFanGraphType : ObjectGraphType<MonitorHoodFan>
    {
        public MonitorHoodFanGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorHoodFanId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfSensingLevels, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UseSensing, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.TemperatureGi, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.SpeedLevel0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensingTemperatureLevel0, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SpeedLevel1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensingTemperatureLevel1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SpeedLevel2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensingTemperatureLevel2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SpeedLevel3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensingTemperatureLevel3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SpeedLevel4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensingTemperatureLevel4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SpeedLevel5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensingTemperatureLevel5, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SpeedLevel6, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensingTemperatureLevel6, type: typeof(FloatGraphType), nullable: False);
            
            Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                        "MonitorHoodFan-MachineConfiguration-loader",
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
            
        }
    }
}
            