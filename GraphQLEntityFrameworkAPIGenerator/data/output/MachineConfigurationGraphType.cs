
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
    public partial class MachineConfigurationGraphType : ObjectGraphType<MachineConfiguration>
    {
        public MachineConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MachineConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Code, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ScaleTemperature, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.UnitsAreMetric, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.AttributeTable, type: typeof(StringGraphType), nullable: True);
			Field(t => t.StatusLedSolidOn, type: typeof(ByteGraphType), nullable: False);
            
            Field<ApplianceConfigurationGraphType, ApplianceConfiguration>("ApplianceConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ApplianceConfigurationGraphType>(
                        "MachineConfiguration-ApplianceConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.ApplianceConfigurations
                                .Where(x => x.ApplianceConfiguration != null && ids.Contains((Guid)x.ApplianceConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.ApplianceConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.ApplianceConfiguration);
                });
            
			
            Field<MonitorAutoResumeGraphType, MonitorAutoResume>("MonitorAutoResumes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorAutoResumeGraphType>(
                        "MachineConfiguration-MonitorAutoResume-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorAutoResumes
                                .Where(x => x.MonitorAutoResume != null && ids.Contains((Guid)x.MonitorAutoResume))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorAutoResume!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorAutoResume);
                });
            
			
            Field<InductionCooktopOrgConfigurationGraphType, InductionCooktopOrgConfiguration>("InductionCooktopOrgConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCooktopOrgConfigurationGraphType>(
                        "MachineConfiguration-InductionCooktopOrgConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionCooktopOrgConfigurations
                                .Where(x => x.InductionCooktopOrgConfiguration != null && ids.Contains((Guid)x.InductionCooktopOrgConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionCooktopOrgConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionCooktopOrgConfiguration);
                });
            
			
            Field<CycleMappingGraphType, CycleMapping>("CycleMappings")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleMappingGraphType>(
                        "MachineConfiguration-CycleMapping-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappings
                                .Where(x => x.CycleMapping != null && ids.Contains((Guid)x.CycleMapping))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleMapping!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleMapping);
                });
            
			
            Field<DebugPointerConfigurationGraphType, DebugPointerConfiguration>("DebugPointerConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DebugPointerConfigurationGraphType>(
                        "MachineConfiguration-DebugPointerConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.DebugPointerConfigurations
                                .Where(x => x.DebugPointerConfiguration != null && ids.Contains((Guid)x.DebugPointerConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.DebugPointerConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.DebugPointerConfiguration);
                });
            
			
            Field<MonitorDlbConfigurationGraphType, MonitorDlbConfiguration>("MonitorDlbConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorDlbConfigurationGraphType>(
                        "MachineConfiguration-MonitorDlbConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorDlbConfigurations
                                .Where(x => x.MonitorDlbConfiguration != null && ids.Contains((Guid)x.MonitorDlbConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorDlbConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorDlbConfiguration);
                });
            
			
            Field<FaultConfigurationGraphType, FaultConfiguration>("FaultConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, FaultConfigurationGraphType>(
                        "MachineConfiguration-FaultConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.FaultConfigurations
                                .Where(x => x.FaultConfiguration != null && ids.Contains((Guid)x.FaultConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.FaultConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.FaultConfiguration);
                });
            
			
            Field<IpcControllerConfigurationGraphType, IpcControllerConfiguration>("IpcControllerConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IpcControllerConfigurationGraphType>(
                        "MachineConfiguration-IpcControllerConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.IpcControllerConfigurations
                                .Where(x => x.IpcControllerConfiguration != null && ids.Contains((Guid)x.IpcControllerConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.IpcControllerConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.IpcControllerConfiguration);
                });
            
			
            Field<MonitorIrshutterGraphType, MonitorIrshutter>("MonitorIrshutters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorIrshutterGraphType>(
                        "MachineConfiguration-MonitorIrshutter-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorIrshutters
                                .Where(x => x.MonitorIrshutter != null && ids.Contains((Guid)x.MonitorIrshutter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorIrshutter!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorIrshutter);
                });
            
			
            Field<MonitorIrtemperatureGraphType, MonitorIrtemperature>("MonitorIrtemperatures")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorIrtemperatureGraphType>(
                        "MachineConfiguration-MonitorIrtemperature-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorIrtemperatures
                                .Where(x => x.MonitorIrtemperature != null && ids.Contains((Guid)x.MonitorIrtemperature))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorIrtemperature!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorIrtemperature);
                });
            
			
            Field<InductionIsofrequencyConfigurationGraphType, InductionIsofrequencyConfiguration>("InductionIsofrequencyConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionIsofrequencyConfigurationGraphType>(
                        "MachineConfiguration-InductionIsofrequencyConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionIsofrequencyConfigurations
                                .Where(x => x.InductionIsofrequencyConfiguration != null && ids.Contains((Guid)x.InductionIsofrequencyConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionIsofrequencyConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionIsofrequencyConfiguration);
                });
            
			
            Field<MonitorLatchControlGraphType, MonitorLatchControl>("MonitorLatchControls")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorLatchControlGraphType>(
                        "MachineConfiguration-MonitorLatchControl-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorLatchControls
                                .Where(x => x.MonitorLatchControl != null && ids.Contains((Guid)x.MonitorLatchControl))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorLatchControl!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorLatchControl);
                });
            
			
            Field<MonitorLightGraphType, MonitorLight>("MonitorLights")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorLightGraphType>(
                        "MachineConfiguration-MonitorLight-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorLights
                                .Where(x => x.MonitorLight != null && ids.Contains((Guid)x.MonitorLight))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorLight!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorLight);
                });
            
			
            Field<MicrowavePowerTableConfigurationGraphType, MicrowavePowerTableConfiguration>("MicrowavePowerTableConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MicrowavePowerTableConfigurationGraphType>(
                        "MachineConfiguration-MicrowavePowerTableConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MicrowavePowerTableConfigurations
                                .Where(x => x.MicrowavePowerTableConfiguration != null && ids.Contains((Guid)x.MicrowavePowerTableConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MicrowavePowerTableConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MicrowavePowerTableConfiguration);
                });
            
			
            Field<MinimumDcSupplyGraphType, MinimumDcSupply>("MinimumDcSupplys")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MinimumDcSupplyGraphType>(
                        "MachineConfiguration-MinimumDcSupply-loader",
                        async ids => 
                        {
                            var data = await dbContext.MinimumDcSupplys
                                .Where(x => x.MinimumDcSupply != null && ids.Contains((Guid)x.MinimumDcSupply))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MinimumDcSupply!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MinimumDcSupply);
                });
            
			
            Field<MonitorCoilGraphType, MonitorCoil>("MonitorCoils")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorCoilGraphType>(
                        "MachineConfiguration-MonitorCoil-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorCoils
                                .Where(x => x.MonitorCoil != null && ids.Contains((Guid)x.MonitorCoil))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorCoil!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorCoil);
                });
            
			
            Field<MonitorCoilDeratingConfigurationGraphType, MonitorCoilDeratingConfiguration>("MonitorCoilDeratingConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorCoilDeratingConfigurationGraphType>(
                        "MachineConfiguration-MonitorCoilDeratingConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorCoilDeratingConfigurations
                                .Where(x => x.MonitorCoilDeratingConfiguration != null && ids.Contains((Guid)x.MonitorCoilDeratingConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorCoilDeratingConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorCoilDeratingConfiguration);
                });
            
			
            Field<MonitorGfciGraphType, MonitorGfci>("MonitorGfcis")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorGfciGraphType>(
                        "MachineConfiguration-MonitorGfci-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorGfcis
                                .Where(x => x.MonitorGfci != null && ids.Contains((Guid)x.MonitorGfci))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorGfci!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorGfci);
                });
            
			
            Field<MonitorGfciV2GraphType, MonitorGfciV2>("MonitorGfciV2s")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorGfciV2GraphType>(
                        "MachineConfiguration-MonitorGfciV2-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorGfciV2s
                                .Where(x => x.MonitorGfciV2 != null && ids.Contains((Guid)x.MonitorGfciV2))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorGfciV2!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorGfciV2);
                });
            
			
            Field<MonitorHeatSinkFanGraphType, MonitorHeatSinkFan>("MonitorHeatSinkFans")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorHeatSinkFanGraphType>(
                        "MachineConfiguration-MonitorHeatSinkFan-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorHeatSinkFan);
                });
            
			
            Field<MonitorHoodFanGraphType, MonitorHoodFan>("MonitorHoodFans")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorHoodFanGraphType>(
                        "MachineConfiguration-MonitorHoodFan-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorHoodFans
                                .Where(x => x.MonitorHoodFan != null && ids.Contains((Guid)x.MonitorHoodFan))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorHoodFan!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorHoodFan);
                });
            
			
            Field<MonitorMultiPointProbeGraphType, MonitorMultiPointProbe>("MonitorMultiPointProbes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorMultiPointProbeGraphType>(
                        "MachineConfiguration-MonitorMultiPointProbe-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorMultiPointProbes
                                .Where(x => x.MonitorMultiPointProbe != null && ids.Contains((Guid)x.MonitorMultiPointProbe))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorMultiPointProbe!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorMultiPointProbe);
                });
            
			
            Field<MonitorPowerReductionGraphType, MonitorPowerReduction>("MonitorPowerReductions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorPowerReductionGraphType>(
                        "MachineConfiguration-MonitorPowerReduction-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorPowerReduction);
                });
            
			
            Field<MonitorPowerReductionV2configurationGraphType, MonitorPowerReductionV2configuration>("MonitorPowerReductionV2configurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorPowerReductionV2configurationGraphType>(
                        "MachineConfiguration-MonitorPowerReductionV2configuration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorPowerReductionV2configurations
                                .Where(x => x.MonitorPowerReductionV2configuration != null && ids.Contains((Guid)x.MonitorPowerReductionV2configuration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorPowerReductionV2configuration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorPowerReductionV2configuration);
                });
            
			
            Field<MonitorSteamGraphType, MonitorSteam>("MonitorSteams")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorSteamGraphType>(
                        "MachineConfiguration-MonitorSteam-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorSteam);
                });
            
			
            Field<MonitorVentGraphType, MonitorVent>("MonitorVents")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorVentGraphType>(
                        "MachineConfiguration-MonitorVent-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorVents
                                .Where(x => x.MonitorVent != null && ids.Contains((Guid)x.MonitorVent))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorVent!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorVent);
                });
            
			
            Field<DeprecatedMonitorWaterLevelThresholdGraphType, DeprecatedMonitorWaterLevelThreshold>("DeprecatedMonitorWaterLevelThresholds")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DeprecatedMonitorWaterLevelThresholdGraphType>(
                        "MachineConfiguration-DeprecatedMonitorWaterLevelThreshold-loader",
                        async ids => 
                        {
                            var data = await dbContext.DeprecatedMonitorWaterLevelThresholds
                                .Where(x => x.DeprecatedMonitorWaterLevelThreshold != null && ids.Contains((Guid)x.DeprecatedMonitorWaterLevelThreshold))
                                .Select(x => new
                                {
                                    Key = (Guid)x.DeprecatedMonitorWaterLevelThreshold!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.DeprecatedMonitorWaterLevelThreshold);
                });
            
			
            Field<OpenDoorHeatingCyclesConfigurationGraphType, OpenDoorHeatingCyclesConfiguration>("OpenDoorHeatingCyclesConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, OpenDoorHeatingCyclesConfigurationGraphType>(
                        "MachineConfiguration-OpenDoorHeatingCyclesConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.OpenDoorHeatingCyclesConfigurations
                                .Where(x => x.OpenDoorHeatingCyclesConfiguration != null && ids.Contains((Guid)x.OpenDoorHeatingCyclesConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.OpenDoorHeatingCyclesConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.OpenDoorHeatingCyclesConfiguration);
                });
            
			
            Field<MonitorPowerDetectGraphType, MonitorPowerDetect>("MonitorPowerDetects")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorPowerDetectGraphType>(
                        "MachineConfiguration-MonitorPowerDetect-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorPowerDetects
                                .Where(x => x.MonitorPowerDetect != null && ids.Contains((Guid)x.MonitorPowerDetect))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorPowerDetect!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorPowerDetect);
                });
            
			
            Field<ProjectGraphType, Project>("Projects")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ProjectGraphType>>(
                        "MachineConfiguration-Project-loader",
                        async ids => 
                        {
                            var data = await dbContext.Projects
                                .Where(x => x.Project != null && ids.Contains((Guid)x.Project))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Project!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Projects);
                });
            
			
            Field<SrsafetyRelevantParameterGraphType, SrsafetyRelevantParameter>("SrsafetyRelevantParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SrsafetyRelevantParameterGraphType>(
                        "MachineConfiguration-SrsafetyRelevantParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.SrsafetyRelevantParameters
                                .Where(x => x.SrsafetyRelevantParameter != null && ids.Contains((Guid)x.SrsafetyRelevantParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SrsafetyRelevantParameter!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.SrsafetyRelevantParameter);
                });
            
			
            Field<TimeEstimationConfigurationGraphType, TimeEstimationConfiguration>("TimeEstimationConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, TimeEstimationConfigurationGraphType>(
                        "MachineConfiguration-TimeEstimationConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.TimeEstimationConfigurations
                                .Where(x => x.TimeEstimationConfiguration != null && ids.Contains((Guid)x.TimeEstimationConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.TimeEstimationConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.TimeEstimationConfiguration);
                });
            
			
            Field<MonitorWarmingZoneGraphType, MonitorWarmingZone>("MonitorWarmingZones")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorWarmingZoneGraphType>(
                        "MachineConfiguration-MonitorWarmingZone-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorWarmingZones
                                .Where(x => x.MonitorWarmingZone != null && ids.Contains((Guid)x.MonitorWarmingZone))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorWarmingZone!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorWarmingZone);
                });
            
        }
    }
}
            