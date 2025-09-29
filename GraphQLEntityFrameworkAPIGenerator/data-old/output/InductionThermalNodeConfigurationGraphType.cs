
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
    public partial class InductionThermalNodeConfigurationGraphType : ObjectGraphType<InductionThermalNodeConfiguration>
    {
        public InductionThermalNodeConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionThermalNodeConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.TempThresholdNominalToWarmState, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempThresholdWarmToOverheatState, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempTresholdHotIndicator, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ThermalDeratingPiControllerTempSetPoint, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ThermalDeratingPiControllerKp, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.ThermalDeratingPiControllerKi, type: typeof(DoubleGraphType), nullable: False);
            
                Field<IpcControllerCoilConfigurationGraphType, IpcControllerCoilConfiguration>("IpcControllerCoilConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerCoilConfigurationGraphType>>(
                            "{ Name = EntityName "InductionThermalNodeConfiguration"
  CorrespondingTable =
   Regular
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
             Name = "IpcControllerCoilConfigurationHeatsinkThermalNodeConfigs"
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
         Navigation { Type = TableName "IpcControllerCoilDetail"
                      Name = "IpcControllerCoilDetailCoilGapThermalNodeConfigs"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "IpcControllerCoilDetail"
                      Name = "IpcControllerCoilDetailIgbtThermalNodeConfigs"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "InductionThermalNodeConfigId"
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
    { Name = "Version"
      Type = Primitive Byte
      IsNullable = true }; { Name = "TempThresholdNominalToWarmState"
                             Type = Primitive Float
                             IsNullable = false };
    { Name = "TempThresholdWarmToOverheatState"
      Type = Primitive Float
      IsNullable = false }; { Name = "TempTresholdHotIndicator"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "ThermalDeratingPiControllerTempSetPoint"
      Type = Primitive Float
      IsNullable = false }; { Name = "ThermalDeratingPiControllerKp"
                              Type = Primitive Double
                              IsNullable = false };
    { Name = "ThermalDeratingPiControllerKi"
      Type = Primitive Double
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "IpcControllerCoilConfiguration"
        TargetTable =
         { Name = TableName "IpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
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
             ForeignKey { Type = Guid
                          Name = "IpcFanConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "HeatsinkThermalNodeConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MicroThermalNodeConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "InductionThermalNodeConfiguration"
                          Name = "HeatsinkThermalNodeConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName
                    "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
                 Name =
                  "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerIpcConfigurationsIpcControllerCoilConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "IpcFanConfigDatum"
                          Name = "IpcFanConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "InductionThermalNodeConfiguration"
                          Name = "MicroThermalNodeConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "IpcControllerCoilConfiguration"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "IpcControllerCoilDetail"
        TargetTable =
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
             ForeignKey { Type = Guid
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
                  TableName
                    "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
                 Name =
                  "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "IpcControllerCoilDetail"
        KeyType = Guid }] }-IpcControllerCoilConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.IpcControllerCoilConfigurations
                                    .Where(x => x.IpcControllerCoilConfiguration != null && ids.Contains((Guid)x.IpcControllerCoilConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.IpcControllerCoilConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.IpcControllerCoilConfigurations);
                    });
            
			
                Field<IpcControllerCoilDetailGraphType, IpcControllerCoilDetail>("IpcControllerCoilDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerCoilDetailGraphType>>(
                            "{ Name = EntityName "InductionThermalNodeConfiguration"
  CorrespondingTable =
   Regular
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
             Name = "IpcControllerCoilConfigurationHeatsinkThermalNodeConfigs"
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
         Navigation { Type = TableName "IpcControllerCoilDetail"
                      Name = "IpcControllerCoilDetailCoilGapThermalNodeConfigs"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "IpcControllerCoilDetail"
                      Name = "IpcControllerCoilDetailIgbtThermalNodeConfigs"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "InductionThermalNodeConfigId"
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
    { Name = "Version"
      Type = Primitive Byte
      IsNullable = true }; { Name = "TempThresholdNominalToWarmState"
                             Type = Primitive Float
                             IsNullable = false };
    { Name = "TempThresholdWarmToOverheatState"
      Type = Primitive Float
      IsNullable = false }; { Name = "TempTresholdHotIndicator"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "ThermalDeratingPiControllerTempSetPoint"
      Type = Primitive Float
      IsNullable = false }; { Name = "ThermalDeratingPiControllerKp"
                              Type = Primitive Double
                              IsNullable = false };
    { Name = "ThermalDeratingPiControllerKi"
      Type = Primitive Double
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "IpcControllerCoilConfiguration"
        TargetTable =
         { Name = TableName "IpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
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
             ForeignKey { Type = Guid
                          Name = "IpcFanConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "HeatsinkThermalNodeConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MicroThermalNodeConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "InductionThermalNodeConfiguration"
                          Name = "HeatsinkThermalNodeConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName
                    "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
                 Name =
                  "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerIpcConfigurationsIpcControllerCoilConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "IpcFanConfigDatum"
                          Name = "IpcFanConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "InductionThermalNodeConfiguration"
                          Name = "MicroThermalNodeConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "IpcControllerCoilConfiguration"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "IpcControllerCoilDetail"
        TargetTable =
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
             ForeignKey { Type = Guid
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
                  TableName
                    "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
                 Name =
                  "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "IpcControllerCoilDetail"
        KeyType = Guid }] }-IpcControllerCoilDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.IpcControllerCoilDetails
                                    .Where(x => x.IpcControllerCoilDetail != null && ids.Contains((Guid)x.IpcControllerCoilDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.IpcControllerCoilDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.IpcControllerCoilDetails);
                    });
            
        }
    }
}
            