
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
    public partial class MonitorLightGraphType : ObjectGraphType<MonitorLight>
    {
        public MonitorLightGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LightConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NoFadingNeeded, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HmidriverPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DoorDriverPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CycleDriverPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.HmifadeOn, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.HmifadeOff, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.HmimaximumIntensity, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.HmiminimumIntensity, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DoorFadeOn, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.DoorFadeOff, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.DoorMaximumIntensity, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DoorMinimumIntensity, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.CycleFadeOn, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.CycleFadeOff, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.CycleMaximumIntensity, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.CycleMinimumIntensity, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.AutoOffTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.HmiToggleControl, type: typeof(BoolGraphType), nullable: False);
            
                Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                            "{ Name = EntityName "MonitorLight"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorLight"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "LightConfigurationId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Version"
                                                        IsNullable = false };
         Primitive { Type = Bool
                     Name = "NoFadingNeeded"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "HmidriverPresent"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "DoorDriverPresent"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "CycleDriverPresent"
                     IsNullable = false }; Primitive { Type = String
                                                       Name = "Description"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Status"
                     IsNullable = false }; Primitive { Type = String
                                                       Name = "Owner"
                                                       IsNullable = false };
         Primitive { Type = DateTime
                     Name = "Timestamp"
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "HmifadeOn"
                                                      IsNullable = true };
         Primitive { Type = Float
                     Name = "HmifadeOff"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "HmimaximumIntensity"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "HmiminimumIntensity"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "DoorFadeOn"
                                                      IsNullable = true };
         Primitive { Type = Float
                     Name = "DoorFadeOff"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "DoorMaximumIntensity"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "DoorMinimumIntensity"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "CycleFadeOn"
                                                      IsNullable = true };
         Primitive { Type = Float
                     Name = "CycleFadeOff"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "CycleMaximumIntensity"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "CycleMinimumIntensity"
                     IsNullable = true }; Primitive { Type = Int
                                                      Name = "AutoOffTime"
                                                      IsNullable = false };
         Primitive { Type = Bool
                     Name = "HmiToggleControl"
                     IsNullable = false };
         Navigation { Type = TableName "MachineConfiguration"
                      Name = "MachineConfigurations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "LightConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "NoFadingNeeded"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "HmidriverPresent"
      Type = Primitive Bool
      IsNullable = false }; { Name = "DoorDriverPresent"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "CycleDriverPresent"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true };
    { Name = "HmifadeOn"
      Type = Primitive Float
      IsNullable = true }; { Name = "HmifadeOff"
                             Type = Primitive Float
                             IsNullable = true }; { Name = "HmimaximumIntensity"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "HmiminimumIntensity"
      Type = Primitive Byte
      IsNullable = true }; { Name = "DoorFadeOn"
                             Type = Primitive Float
                             IsNullable = true }; { Name = "DoorFadeOff"
                                                    Type = Primitive Float
                                                    IsNullable = true };
    { Name = "DoorMaximumIntensity"
      Type = Primitive Byte
      IsNullable = true }; { Name = "DoorMinimumIntensity"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "CycleFadeOn"
                                                    Type = Primitive Float
                                                    IsNullable = true };
    { Name = "CycleFadeOff"
      Type = Primitive Float
      IsNullable = true }; { Name = "CycleMaximumIntensity"
                             Type = Primitive Byte
                             IsNullable = true };
    { Name = "CycleMinimumIntensity"
      Type = Primitive Byte
      IsNullable = true }; { Name = "AutoOffTime"
                             Type = Primitive Int
                             IsNullable = false }; { Name = "HmiToggleControl"
                                                     Type = Primitive Bool
                                                     IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "MachineConfiguration"
        TargetTable =
         { Name = TableName "MachineConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MachineConfigurationId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Code"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
                                                           Name = "Timestamp"
                                                           IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Notes"
                                                           IsNullable = true };
             Primitive { Type = Short
                         Name = "ScaleTemperature"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "FaultConfigurationsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DebugPointerConfigurationsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ApplianceConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LatchControlId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CooktopOrgConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "TimeEstimationConfigurationId"
                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "UnitsAreMetric"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "IsofrequencyTableId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LightConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SrsafetyParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MicrowavePowerTableId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorPowerReductionId"
                          IsNullable = true };
             Primitive { Type = String
                         Name = "AttributeTable"
                         IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CycleMappingId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "WarmingZoneParamsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "IrshutterMonitorId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "IrtemperatureMonitorId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "AutoResumeMonitorId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "OpenDoorHeatingCyclesConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorHoodFanId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MinimumDcSupplyId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DlbConfigMonitorId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PowerDetectMonitorId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "StatusLedSolidOn"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "MonitorCoilDeratingConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorCoilId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorHeatsinkFanId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorPowerReductionV2configurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorVentId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorMultiPointProbeId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorSteamId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorWaterLevelThresholdId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorGfciId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "IpcControllerConfigurationsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorGfciV2id"
                          IsNullable = true };
             Navigation { Type = TableName "ApplianceConfiguration"
                          Name = "ApplianceConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorAutoResume"
                          Name = "AutoResumeMonitor"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "InductionCooktopOrgConfiguration"
                          Name = "CooktopOrgConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CycleMapping"
                          Name = "CycleMapping"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "DebugPointerConfiguration"
                          Name = "DebugPointerConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorDlbConfiguration"
                          Name = "DlbConfigMonitor"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "FaultConfiguration"
                          Name = "FaultConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerConfiguration"
                          Name = "IpcControllerConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorIrshutter"
                          Name = "IrshutterMonitor"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorIrtemperature"
                          Name = "IrtemperatureMonitor"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "InductionIsofrequencyConfiguration"
                          Name = "IsofrequencyTable"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorLatchControl"
                          Name = "LatchControl"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorLight"
                          Name = "LightConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MicrowavePowerTableConfiguration"
                          Name = "MicrowavePowerTable"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MinimumDcSupply"
                          Name = "MinimumDcSupply"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorCoil"
                          Name = "MonitorCoil"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorCoilDeratingConfiguration"
                          Name = "MonitorCoilDeratingConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorGfci"
                          Name = "MonitorGfci"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorGfciV2"
                          Name = "MonitorGfciV2"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorHeatSinkFan"
                          Name = "MonitorHeatsinkFan"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorHoodFan"
                          Name = "MonitorHoodFan"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorMultiPointProbe"
                          Name = "MonitorMultiPointProbe"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorPowerReduction"
                          Name = "MonitorPowerReduction"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "MonitorPowerReductionV2configuration"
                 Name = "MonitorPowerReductionV2configuration"
                 IsNullable = true
                 IsCollection = false };
             Navigation { Type = TableName "MonitorSteam"
                          Name = "MonitorSteam"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorVent"
                          Name = "MonitorVent"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "DeprecatedMonitorWaterLevelThreshold"
                 Name = "MonitorWaterLevelThreshold"
                 IsNullable = true
                 IsCollection = false };
             Navigation { Type = TableName "OpenDoorHeatingCyclesConfiguration"
                          Name = "OpenDoorHeatingCyclesConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorPowerDetect"
                          Name = "PowerDetectMonitor"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SrsafetyRelevantParameter"
                          Name = "SrsafetyParameters"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "TimeEstimationConfiguration"
                          Name = "TimeEstimationConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorWarmingZone"
                          Name = "WarmingZoneParams"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "MachineConfiguration"
        KeyType = Guid }] }-MachineConfiguration-loader",
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
            