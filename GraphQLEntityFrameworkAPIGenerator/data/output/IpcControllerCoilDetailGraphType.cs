
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
    public partial class IpcControllerCoilDetailGraphType : ObjectGraphType<IpcControllerCoilDetail>
    {
        public IpcControllerCoilDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.IpcControllerCoilDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<InductionThermalNodeConfigurationGraphType, InductionThermalNodeConfiguration>("InductionThermalNodeConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionThermalNodeConfigurationGraphType>(
                            "{ Name = EntityName "IpcControllerCoilDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerCoilDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilDetailsId"
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
                     IsNullable = true }; ForeignKey { Type = Guid
                                                       Name = "InverterConfigId"
                                                       IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilSpecificConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "IgbtThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilGapThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilCenterThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionCoilConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "CoilCenterThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "CoilGapThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CoilSpecificConfigDatum"
                      Name = "CoilSpecificConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionCoilConfig"
                      Name = "EmptyPotDetectionCoilConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "IgbtThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InverterConfigDatum"
                      Name = "InverterConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
             Name = "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "IpcControllerCoilDetailsId"
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
                                                      IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "CoilCenterThermalNodeConfig";
          RelationName "CoilGapThermalNodeConfig";
          RelationName "IgbtThermalNodeConfig"]
        TargetTable =
         { Name = TableName "InductionThermalNodeConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionThermalNodeConfigId"
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
                         Name = "Version"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "TempThresholdNominalToWarmState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempThresholdWarmToOverheatState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempTresholdHotIndicator"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ThermalDeratingPiControllerTempSetPoint"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKp"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKi"
                         IsNullable = false };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerCoilConfigurationHeatsinkThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name = "IpcControllerCoilConfigurationMicroThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilCenterThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilGapThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetailIgbtThermalNodeConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionThermalNodeConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CoilSpecificConfigDatum"
        TargetTable =
         { Name = TableName "CoilSpecificConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilSpecificConfigId"
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
             Primitive { Type = Float
                         Name = "MaxNominalDeliveryPower"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CoilSpecificConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionCoilConfig"
        TargetTable =
         { Name = TableName "EmptyPotDetectionCoilConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionCoilConfigId"
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
             Primitive { Type = Bool
                         Name = "UseGapTempSensorForEmptyPotHandling"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "KiTemperatureControl"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "KpTemperatureControl"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FixedDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureControlSetpointSlope"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionCoilConfig"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InverterConfigDatum"
        TargetTable =
         { Name = TableName "InverterConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InverterConfigId"
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
             Primitive { Type = Float
                         Name = "InverterResonanceCapacitance"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InverterConfigDatum"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        TargetTable =
         { Name =
            TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        KeyType = Guid }] }-InductionThermalNodeConfiguration-loader",
                            async ids => 
                            {
                                Expression<Func<InductionThermalNodeConfiguration, bool>> expr = x => !ids.Any()
                                    \|\| (x.CoilCenterThermalNodeConfig != null && ids.Contains((Guid)x.CoilCenterThermalNodeConfig))
\|\| (x.CoilGapThermalNodeConfig != null && ids.Contains((Guid)x.CoilGapThermalNodeConfig))
\|\| (x.IgbtThermalNodeConfig != null && ids.Contains((Guid)x.IgbtThermalNodeConfig));

                                var data = await dbContext.InductionThermalNodeConfigurations
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.CoilCenterThermalNodeConfig,
x.CoilGapThermalNodeConfig,
x.IgbtThermalNodeConfig
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.InductionThermalNodeConfigurations);
                    });
            
			
                Field<CoilSpecificConfigDatumGraphType, CoilSpecificConfigDatum>("CoilSpecificConfigDatums")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CoilSpecificConfigDatumGraphType>(
                            "{ Name = EntityName "IpcControllerCoilDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerCoilDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilDetailsId"
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
                     IsNullable = true }; ForeignKey { Type = Guid
                                                       Name = "InverterConfigId"
                                                       IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilSpecificConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "IgbtThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilGapThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilCenterThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionCoilConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "CoilCenterThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "CoilGapThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CoilSpecificConfigDatum"
                      Name = "CoilSpecificConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionCoilConfig"
                      Name = "EmptyPotDetectionCoilConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "IgbtThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InverterConfigDatum"
                      Name = "InverterConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
             Name = "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "IpcControllerCoilDetailsId"
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
                                                      IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "CoilCenterThermalNodeConfig";
          RelationName "CoilGapThermalNodeConfig";
          RelationName "IgbtThermalNodeConfig"]
        TargetTable =
         { Name = TableName "InductionThermalNodeConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionThermalNodeConfigId"
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
                         Name = "Version"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "TempThresholdNominalToWarmState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempThresholdWarmToOverheatState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempTresholdHotIndicator"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ThermalDeratingPiControllerTempSetPoint"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKp"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKi"
                         IsNullable = false };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerCoilConfigurationHeatsinkThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name = "IpcControllerCoilConfigurationMicroThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilCenterThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilGapThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetailIgbtThermalNodeConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionThermalNodeConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CoilSpecificConfigDatum"
        TargetTable =
         { Name = TableName "CoilSpecificConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilSpecificConfigId"
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
             Primitive { Type = Float
                         Name = "MaxNominalDeliveryPower"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CoilSpecificConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionCoilConfig"
        TargetTable =
         { Name = TableName "EmptyPotDetectionCoilConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionCoilConfigId"
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
             Primitive { Type = Bool
                         Name = "UseGapTempSensorForEmptyPotHandling"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "KiTemperatureControl"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "KpTemperatureControl"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FixedDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureControlSetpointSlope"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionCoilConfig"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InverterConfigDatum"
        TargetTable =
         { Name = TableName "InverterConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InverterConfigId"
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
             Primitive { Type = Float
                         Name = "InverterResonanceCapacitance"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InverterConfigDatum"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        TargetTable =
         { Name =
            TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        KeyType = Guid }] }-CoilSpecificConfigDatum-loader",
                            async ids => 
                            {
                                var data = await dbContext.CoilSpecificConfigDatums
                                    .Where(x => x.CoilSpecificConfigDatum != null && ids.Contains((Guid)x.CoilSpecificConfigDatum))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CoilSpecificConfigDatum!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CoilSpecificConfigDatum);
                });
            
			
                Field<EmptyPotDetectionCoilConfigGraphType, EmptyPotDetectionCoilConfig>("EmptyPotDetectionCoilConfigs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, EmptyPotDetectionCoilConfigGraphType>(
                            "{ Name = EntityName "IpcControllerCoilDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerCoilDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilDetailsId"
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
                     IsNullable = true }; ForeignKey { Type = Guid
                                                       Name = "InverterConfigId"
                                                       IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilSpecificConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "IgbtThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilGapThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilCenterThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionCoilConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "CoilCenterThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "CoilGapThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CoilSpecificConfigDatum"
                      Name = "CoilSpecificConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionCoilConfig"
                      Name = "EmptyPotDetectionCoilConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "IgbtThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InverterConfigDatum"
                      Name = "InverterConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
             Name = "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "IpcControllerCoilDetailsId"
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
                                                      IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "CoilCenterThermalNodeConfig";
          RelationName "CoilGapThermalNodeConfig";
          RelationName "IgbtThermalNodeConfig"]
        TargetTable =
         { Name = TableName "InductionThermalNodeConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionThermalNodeConfigId"
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
                         Name = "Version"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "TempThresholdNominalToWarmState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempThresholdWarmToOverheatState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempTresholdHotIndicator"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ThermalDeratingPiControllerTempSetPoint"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKp"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKi"
                         IsNullable = false };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerCoilConfigurationHeatsinkThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name = "IpcControllerCoilConfigurationMicroThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilCenterThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilGapThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetailIgbtThermalNodeConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionThermalNodeConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CoilSpecificConfigDatum"
        TargetTable =
         { Name = TableName "CoilSpecificConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilSpecificConfigId"
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
             Primitive { Type = Float
                         Name = "MaxNominalDeliveryPower"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CoilSpecificConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionCoilConfig"
        TargetTable =
         { Name = TableName "EmptyPotDetectionCoilConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionCoilConfigId"
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
             Primitive { Type = Bool
                         Name = "UseGapTempSensorForEmptyPotHandling"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "KiTemperatureControl"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "KpTemperatureControl"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FixedDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureControlSetpointSlope"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionCoilConfig"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InverterConfigDatum"
        TargetTable =
         { Name = TableName "InverterConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InverterConfigId"
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
             Primitive { Type = Float
                         Name = "InverterResonanceCapacitance"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InverterConfigDatum"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        TargetTable =
         { Name =
            TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        KeyType = Guid }] }-EmptyPotDetectionCoilConfig-loader",
                            async ids => 
                            {
                                var data = await dbContext.EmptyPotDetectionCoilConfigs
                                    .Where(x => x.EmptyPotDetectionCoilConfig != null && ids.Contains((Guid)x.EmptyPotDetectionCoilConfig))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.EmptyPotDetectionCoilConfig!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.EmptyPotDetectionCoilConfig);
                });
            
			
                Field<InverterConfigDatumGraphType, InverterConfigDatum>("InverterConfigDatums")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InverterConfigDatumGraphType>(
                            "{ Name = EntityName "IpcControllerCoilDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerCoilDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilDetailsId"
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
                     IsNullable = true }; ForeignKey { Type = Guid
                                                       Name = "InverterConfigId"
                                                       IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilSpecificConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "IgbtThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilGapThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilCenterThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionCoilConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "CoilCenterThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "CoilGapThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CoilSpecificConfigDatum"
                      Name = "CoilSpecificConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionCoilConfig"
                      Name = "EmptyPotDetectionCoilConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "IgbtThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InverterConfigDatum"
                      Name = "InverterConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
             Name = "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "IpcControllerCoilDetailsId"
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
                                                      IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "CoilCenterThermalNodeConfig";
          RelationName "CoilGapThermalNodeConfig";
          RelationName "IgbtThermalNodeConfig"]
        TargetTable =
         { Name = TableName "InductionThermalNodeConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionThermalNodeConfigId"
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
                         Name = "Version"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "TempThresholdNominalToWarmState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempThresholdWarmToOverheatState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempTresholdHotIndicator"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ThermalDeratingPiControllerTempSetPoint"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKp"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKi"
                         IsNullable = false };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerCoilConfigurationHeatsinkThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name = "IpcControllerCoilConfigurationMicroThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilCenterThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilGapThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetailIgbtThermalNodeConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionThermalNodeConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CoilSpecificConfigDatum"
        TargetTable =
         { Name = TableName "CoilSpecificConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilSpecificConfigId"
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
             Primitive { Type = Float
                         Name = "MaxNominalDeliveryPower"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CoilSpecificConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionCoilConfig"
        TargetTable =
         { Name = TableName "EmptyPotDetectionCoilConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionCoilConfigId"
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
             Primitive { Type = Bool
                         Name = "UseGapTempSensorForEmptyPotHandling"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "KiTemperatureControl"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "KpTemperatureControl"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FixedDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureControlSetpointSlope"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionCoilConfig"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InverterConfigDatum"
        TargetTable =
         { Name = TableName "InverterConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InverterConfigId"
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
             Primitive { Type = Float
                         Name = "InverterResonanceCapacitance"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InverterConfigDatum"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        TargetTable =
         { Name =
            TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        KeyType = Guid }] }-InverterConfigDatum-loader",
                            async ids => 
                            {
                                var data = await dbContext.InverterConfigDatums
                                    .Where(x => x.InverterConfigDatum != null && ids.Contains((Guid)x.InverterConfigDatum))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InverterConfigDatum!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InverterConfigDatum);
                });
            
			
                Field<IpcControllerCoilConfigurationsIpcControllerCoilDetailGraphType, IpcControllerCoilConfigurationsIpcControllerCoilDetail>("IpcControllerCoilConfigurationsIpcControllerCoilDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerCoilConfigurationsIpcControllerCoilDetailGraphType>>(
                            "{ Name = EntityName "IpcControllerCoilDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerCoilDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilDetailsId"
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
                     IsNullable = true }; ForeignKey { Type = Guid
                                                       Name = "InverterConfigId"
                                                       IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilSpecificConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "IgbtThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilGapThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilCenterThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionCoilConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "CoilCenterThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "CoilGapThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CoilSpecificConfigDatum"
                      Name = "CoilSpecificConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionCoilConfig"
                      Name = "EmptyPotDetectionCoilConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "IgbtThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InverterConfigDatum"
                      Name = "InverterConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
             Name = "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "IpcControllerCoilDetailsId"
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
                                                      IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "CoilCenterThermalNodeConfig";
          RelationName "CoilGapThermalNodeConfig";
          RelationName "IgbtThermalNodeConfig"]
        TargetTable =
         { Name = TableName "InductionThermalNodeConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionThermalNodeConfigId"
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
                         Name = "Version"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "TempThresholdNominalToWarmState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempThresholdWarmToOverheatState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempTresholdHotIndicator"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ThermalDeratingPiControllerTempSetPoint"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKp"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKi"
                         IsNullable = false };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerCoilConfigurationHeatsinkThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name = "IpcControllerCoilConfigurationMicroThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilCenterThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilGapThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetailIgbtThermalNodeConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionThermalNodeConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CoilSpecificConfigDatum"
        TargetTable =
         { Name = TableName "CoilSpecificConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilSpecificConfigId"
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
             Primitive { Type = Float
                         Name = "MaxNominalDeliveryPower"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CoilSpecificConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionCoilConfig"
        TargetTable =
         { Name = TableName "EmptyPotDetectionCoilConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionCoilConfigId"
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
             Primitive { Type = Bool
                         Name = "UseGapTempSensorForEmptyPotHandling"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "KiTemperatureControl"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "KpTemperatureControl"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FixedDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureControlSetpointSlope"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionCoilConfig"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InverterConfigDatum"
        TargetTable =
         { Name = TableName "InverterConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InverterConfigId"
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
             Primitive { Type = Float
                         Name = "InverterResonanceCapacitance"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InverterConfigDatum"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        TargetTable =
         { Name =
            TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        KeyType = Guid }] }-IpcControllerCoilConfigurationsIpcControllerCoilDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.IpcControllerCoilConfigurationsIpcControllerCoilDetails
                                    .Where(x => x.IpcControllerCoilConfigurationsIpcControllerCoilDetail != null && ids.Contains((Guid)x.IpcControllerCoilConfigurationsIpcControllerCoilDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.IpcControllerCoilConfigurationsIpcControllerCoilDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.IpcControllerCoilConfigurationsIpcControllerCoilDetails);
                    });
            
        }
    }
}
            