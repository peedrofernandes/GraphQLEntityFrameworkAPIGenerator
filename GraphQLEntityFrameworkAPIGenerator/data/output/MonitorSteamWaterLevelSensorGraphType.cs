
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
    public partial class MonitorSteamWaterLevelSensorGraphType : ObjectGraphType<MonitorSteamWaterLevelSensor>
    {
        public MonitorSteamWaterLevelSensorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorSteamWaterLevelSensorId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ColdTankLevels, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.WarmTankLevels, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ColdTankMaxVolume, type: typeof(IdGraphType), nullable: False);
			Field(t => t.WarmTankMaxVolume, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ColdTankWlsVolume1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ColdTankWlsVolume2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ColdTankWlsVolume3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ColdTankWlsVolume4, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ColdTankWlsVolume5, type: typeof(IdGraphType), nullable: False);
			Field(t => t.WarmTankWlsVolume1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.WarmTankWlsVolume2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.WarmTankWlsVolume3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.WarmTankWlsVolume4, type: typeof(IdGraphType), nullable: False);
			Field(t => t.WarmTankWlsVolume5, type: typeof(IdGraphType), nullable: False);
			Field(t => t.VolumeSubtracted, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.MinimumWaterLevelThreshold, type: typeof(IdGraphType), nullable: False);
			Field(t => t.MedianWaterLevelThreshold, type: typeof(IdGraphType), nullable: False);
			Field(t => t.MaximumWaterLevelThreshold, type: typeof(IdGraphType), nullable: False);
            
            Field<MonitorSteamGraphType, MonitorSteam>("MonitorSteams")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorSteamGraphType>>(
                        "MonitorSteamWaterLevelSensor-MonitorSteam-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorSteams
                                .Where(x => x.MonitorSteam != null && ids.Contains((Guid)x.MonitorSteam))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorSteam!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.MonitorSteams);
                });
            
        }
    }
}
            