
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
    public partial class MonitorSteamGraphType : ObjectGraphType<MonitorSteam>
    {
        public MonitorSteamGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorSteamId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
            
            Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                        "MonitorSteam-MachineConfiguration-loader",
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
            
			
            Field<MonitorSteamDescaleGraphType, MonitorSteamDescale>("MonitorSteamDescales")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorSteamDescaleGraphType>(
                        "MonitorSteam-MonitorSteamDescale-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorSteamDescales
                                .Where(x => x.MonitorSteamDescale != null && ids.Contains((Guid)x.MonitorSteamDescale))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorSteamDescale!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorSteamDescale);
                });
            
			
            Field<MonitorSteamDrainGraphType, MonitorSteamDrain>("MonitorSteamDrains")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorSteamDrainGraphType>(
                        "MonitorSteam-MonitorSteamDrain-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorSteamDrains
                                .Where(x => x.MonitorSteamDrain != null && ids.Contains((Guid)x.MonitorSteamDrain))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorSteamDrain!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorSteamDrain);
                });
            
			
            Field<MonitorSteamHumidityTargetMappingGraphType, MonitorSteamHumidityTargetMapping>("MonitorSteamHumidityTargetMappings")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorSteamHumidityTargetMappingGraphType>(
                        "MonitorSteam-MonitorSteamHumidityTargetMapping-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorSteamHumidityTargetMappings
                                .Where(x => x.MonitorSteamHumidityTargetMapping != null && ids.Contains((Guid)x.MonitorSteamHumidityTargetMapping))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorSteamHumidityTargetMapping!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorSteamHumidityTargetMapping);
                });
            
			
            Field<MonitorSteamParamGraphType, MonitorSteamParam>("MonitorSteamParams")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorSteamParamGraphType>(
                        "MonitorSteam-MonitorSteamParam-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorSteamParams
                                .Where(x => x.MonitorSteamParam != null && ids.Contains((Guid)x.MonitorSteamParam))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorSteamParam!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorSteamParam);
                });
            
			
            Field<MonitorSteamWaterLevelSensorGraphType, MonitorSteamWaterLevelSensor>("MonitorSteamWaterLevelSensors")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorSteamWaterLevelSensorGraphType>(
                        "MonitorSteam-MonitorSteamWaterLevelSensor-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorSteamWaterLevelSensors
                                .Where(x => x.MonitorSteamWaterLevelSensor != null && ids.Contains((Guid)x.MonitorSteamWaterLevelSensor))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorSteamWaterLevelSensor!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorSteamWaterLevelSensor);
                });
            
			
            Field<MonitorSteamerParamGraphType, MonitorSteamerParam>("MonitorSteamerParams")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorSteamerParamGraphType>(
                        "MonitorSteam-MonitorSteamerParam-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorSteamerParams
                                .Where(x => x.MonitorSteamerParam != null && ids.Contains((Guid)x.MonitorSteamerParam))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorSteamerParam!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorSteamerParam);
                });
            
        }
    }
}
            