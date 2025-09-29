
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
			Field(t => t.TemperatureDsp00ld, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadIndexFan01, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureDsp01ld, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadIndexFan02, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureDsp02ld, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadIndexFan03, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureDsp03ld, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadIndexFan04, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureDsp04ld, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadIndexFan05, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureDsp05ld, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadIndexFan06, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureDsp06ld, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadIndexFan07, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureDsp07ld, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadIndexFan08, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureDsp08ld, type: typeof(GuidGraphType), nullable: True);
            
                Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                            "{ Name = EntityName "MonitorHeatSinkFan"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorHeatSinkFan"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorHeatSinkFanId"
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "StructureVersion"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "NumberOfFans"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "LoadIndexFan00"
                                                       IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp00ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan01"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp01ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan02"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp02ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan03"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp03ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan04"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp04ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan05"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp05ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan06"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp06ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan07"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp07ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan08"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp08ld"
                     IsNullable = true };
         Navigation { Type = TableName "MachineConfiguration"
                      Name = "MachineConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp00ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp01ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp02ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp03ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp04ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp05ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp06ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp07ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp08ldNavigation"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "MonitorHeatSinkFanId"
      Type = Id Guid
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
    { Name = "StructureVersion"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NumberOfFans"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "LoadIndexFan00"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "TemperatureDsp00ld"
      Type = Primitive Guid
      IsNullable = true }; { Name = "LoadIndexFan01"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "TemperatureDsp01ld"
                                                     Type = Primitive Guid
                                                     IsNullable = true };
    { Name = "LoadIndexFan02"
      Type = Primitive Byte
      IsNullable = false }; { Name = "TemperatureDsp02ld"
                              Type = Primitive Guid
                              IsNullable = true }; { Name = "LoadIndexFan03"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "TemperatureDsp03ld"
      Type = Primitive Guid
      IsNullable = true }; { Name = "LoadIndexFan04"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "TemperatureDsp04ld"
                                                     Type = Primitive Guid
                                                     IsNullable = true };
    { Name = "LoadIndexFan05"
      Type = Primitive Byte
      IsNullable = false }; { Name = "TemperatureDsp05ld"
                              Type = Primitive Guid
                              IsNullable = true }; { Name = "LoadIndexFan06"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "TemperatureDsp06ld"
      Type = Primitive Guid
      IsNullable = true }; { Name = "LoadIndexFan07"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "TemperatureDsp07ld"
                                                     Type = Primitive Guid
                                                     IsNullable = true };
    { Name = "LoadIndexFan08"
      Type = Primitive Byte
      IsNullable = false }; { Name = "TemperatureDsp08ld"
                              Type = Primitive Guid
                              IsNullable = true }]
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
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "TemperatureDsp00ldNavigation";
          RelationName "TemperatureDsp01ldNavigation";
          RelationName "TemperatureDsp02ldNavigation";
          RelationName "TemperatureDsp03ldNavigation";
          RelationName "TemperatureDsp04ldNavigation";
          RelationName "TemperatureDsp05ldNavigation";
          RelationName "TemperatureDsp06ldNavigation";
          RelationName "TemperatureDsp07ldNavigation";
          RelationName "TemperatureDsp08ldNavigation"]
        TargetTable =
         { Name = TableName "MonitorHeatSinkFanTemperature"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorHeatSinkFanTemperatureId"
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
             Primitive { Type = Byte
                         Name = "StructureVersion"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "PostMinimum"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "PostTimeout"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Hysteresis"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "SoftThreshold0"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SoftThreshold1"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SoftThreshold2"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SoftThreshold3"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SoftThreshold4"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "HardThreshold0"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "HardThreshold1"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "HardThreshold2"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "HardThreshold3"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "HardThreshold4"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PostThreshold"
                         IsNullable = false };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp00ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp01ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp02ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp03ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp04ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp05ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp06ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp07ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp08ldNavigations"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorHeatSinkFanTemperature"
        IsNullable = true
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
            
			
                Field<MonitorHeatSinkFanTemperatureGraphType, MonitorHeatSinkFanTemperature>("MonitorHeatSinkFanTemperatures")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorHeatSinkFanTemperatureGraphType>(
                            "{ Name = EntityName "MonitorHeatSinkFan"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorHeatSinkFan"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorHeatSinkFanId"
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "StructureVersion"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "NumberOfFans"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "LoadIndexFan00"
                                                       IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp00ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan01"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp01ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan02"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp02ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan03"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp03ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan04"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp04ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan05"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp05ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan06"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp06ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan07"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp07ld"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadIndexFan08"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "TemperatureDsp08ld"
                     IsNullable = true };
         Navigation { Type = TableName "MachineConfiguration"
                      Name = "MachineConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp00ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp01ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp02ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp03ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp04ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp05ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp06ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp07ldNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                      Name = "TemperatureDsp08ldNavigation"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "MonitorHeatSinkFanId"
      Type = Id Guid
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
    { Name = "StructureVersion"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NumberOfFans"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "LoadIndexFan00"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "TemperatureDsp00ld"
      Type = Primitive Guid
      IsNullable = true }; { Name = "LoadIndexFan01"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "TemperatureDsp01ld"
                                                     Type = Primitive Guid
                                                     IsNullable = true };
    { Name = "LoadIndexFan02"
      Type = Primitive Byte
      IsNullable = false }; { Name = "TemperatureDsp02ld"
                              Type = Primitive Guid
                              IsNullable = true }; { Name = "LoadIndexFan03"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "TemperatureDsp03ld"
      Type = Primitive Guid
      IsNullable = true }; { Name = "LoadIndexFan04"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "TemperatureDsp04ld"
                                                     Type = Primitive Guid
                                                     IsNullable = true };
    { Name = "LoadIndexFan05"
      Type = Primitive Byte
      IsNullable = false }; { Name = "TemperatureDsp05ld"
                              Type = Primitive Guid
                              IsNullable = true }; { Name = "LoadIndexFan06"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "TemperatureDsp06ld"
      Type = Primitive Guid
      IsNullable = true }; { Name = "LoadIndexFan07"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "TemperatureDsp07ld"
                                                     Type = Primitive Guid
                                                     IsNullable = true };
    { Name = "LoadIndexFan08"
      Type = Primitive Byte
      IsNullable = false }; { Name = "TemperatureDsp08ld"
                              Type = Primitive Guid
                              IsNullable = true }]
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
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "TemperatureDsp00ldNavigation";
          RelationName "TemperatureDsp01ldNavigation";
          RelationName "TemperatureDsp02ldNavigation";
          RelationName "TemperatureDsp03ldNavigation";
          RelationName "TemperatureDsp04ldNavigation";
          RelationName "TemperatureDsp05ldNavigation";
          RelationName "TemperatureDsp06ldNavigation";
          RelationName "TemperatureDsp07ldNavigation";
          RelationName "TemperatureDsp08ldNavigation"]
        TargetTable =
         { Name = TableName "MonitorHeatSinkFanTemperature"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorHeatSinkFanTemperatureId"
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
             Primitive { Type = Byte
                         Name = "StructureVersion"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "PostMinimum"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "PostTimeout"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Hysteresis"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "SoftThreshold0"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SoftThreshold1"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SoftThreshold2"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SoftThreshold3"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SoftThreshold4"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "HardThreshold0"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "HardThreshold1"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "HardThreshold2"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "HardThreshold3"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "HardThreshold4"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PostThreshold"
                         IsNullable = false };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp00ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp01ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp02ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp03ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp04ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp05ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp06ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp07ldNavigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "MonitorHeatSinkFan"
                 Name = "MonitorHeatSinkFanTemperatureDsp08ldNavigations"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorHeatSinkFanTemperature"
        IsNullable = true
        KeyType = Guid }] }-MonitorHeatSinkFanTemperature-loader",
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
            