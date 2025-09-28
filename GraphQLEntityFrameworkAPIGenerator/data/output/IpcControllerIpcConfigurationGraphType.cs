
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
    public partial class IpcControllerIpcConfigurationGraphType : ObjectGraphType<IpcControllerIpcConfiguration>
    {
        public IpcControllerIpcConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.IpcControllerIpcConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<AssistedCookingConfigDatumGraphType, AssistedCookingConfigDatum>("AssistedCookingConfigDatums")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, AssistedCookingConfigDatumGraphType>(
                            "{ Name = EntityName "IpcControllerIpcConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerIpcConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerIpcConfigurationsId"
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
                     IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MainsLineConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PowerDeliveryConfigId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "ThermalConfigId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilOperationConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AssistedCookingConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "AssistedCookingConfigDatum"
                      Name = "AssistedCookingConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CoilOperationConfigDatum"
                      Name = "CoilOperationConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionConfig"
                      Name = "EmptyPotDetectionConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName
                "IpcControllerConfigurationsIpcControllerIpcConfiguration"
             Name = "IpcControllerConfigurationsIpcControllerIpcConfigurations"
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
         Navigation { Type = TableName "MainsLineConfigDatum"
                      Name = "MainsLineConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "PowerDeliveryConfigDatum"
                      Name = "PowerDeliveryConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "ThermalConfigDatum"
                      Name = "ThermalConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerIpcConfigurationsId"
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
   [SingleManyToOne
      { Name = RelationName "AssistedCookingConfigDatum"
        TargetTable =
         { Name = TableName "AssistedCookingConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AssistedCookingConfigId"
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
             Primitive { Type = Int
                         Name = "InductanceMeasurementFrequency"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "AssistedCookingConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CoilOperationConfigDatum"
        TargetTable =
         { Name = TableName "CoilOperationConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilOperationConfigId"
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
                         Name = "PanDetectionTimeout"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CoilOperationConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionConfig"
        TargetTable =
         { Name = TableName "EmptyPotDetectionConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionConfigId"
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
                         Name = "EmptyPotDeratingDisengagementSlope"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeFixedPowerDerating"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionConfig"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        TargetTable =
         { Name =
            TableName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerConfiguration"
                          Name = "IpcControllerConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        TargetTable =
         { Name =
            TableName
              "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MainsLineConfigDatum"
        TargetTable =
         { Name = TableName "MainsLineConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MainsLineConfigId"
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
                         Name = "NominalPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "NominalCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IntegralGainCurrentAndPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CurrentFaultTreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PowerFaultThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartLineVoltageThresholdAfterSurgeFault"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartWaitingTimeAfterSurgeFault"
                         IsNullable = false };
             Primitive
               { Type = Float
                 Name = "ReclosingWaitingTimeAfter400VdetectionFaultIsCleared"
                 IsNullable = false };
             Primitive { Type = Float
                         Name = "OpeningWaitingTimeAfter400VdetectionFault"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MainsLineConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PowerDeliveryConfigDatum"
        TargetTable =
         { Name = TableName "PowerDeliveryConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PowerDeliveryConfigId"
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
                         Name = "MaxPowerGainFactorForPasoDobleOptimizer"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "LoadCharacterizationAttemptWaitingTime"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PowerDeliveryConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "ThermalConfigDatum"
        TargetTable =
         { Name = TableName "ThermalConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ThermalConfigId"
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
                         Name = "MaxDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MinDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "InitialValueDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ToleranceFromOverHeatingToWarm"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "HysteresysBandwidthHotIndicator"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ThermalConfigDatum"
        IsNullable = true
        KeyType = Guid }] }-AssistedCookingConfigDatum-loader",
                            async ids => 
                            {
                                var data = await dbContext.AssistedCookingConfigDatums
                                    .Where(x => x.AssistedCookingConfigDatum != null && ids.Contains((Guid)x.AssistedCookingConfigDatum))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.AssistedCookingConfigDatum!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.AssistedCookingConfigDatum);
                });
            
			
                Field<CoilOperationConfigDatumGraphType, CoilOperationConfigDatum>("CoilOperationConfigDatums")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CoilOperationConfigDatumGraphType>(
                            "{ Name = EntityName "IpcControllerIpcConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerIpcConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerIpcConfigurationsId"
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
                     IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MainsLineConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PowerDeliveryConfigId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "ThermalConfigId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilOperationConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AssistedCookingConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "AssistedCookingConfigDatum"
                      Name = "AssistedCookingConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CoilOperationConfigDatum"
                      Name = "CoilOperationConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionConfig"
                      Name = "EmptyPotDetectionConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName
                "IpcControllerConfigurationsIpcControllerIpcConfiguration"
             Name = "IpcControllerConfigurationsIpcControllerIpcConfigurations"
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
         Navigation { Type = TableName "MainsLineConfigDatum"
                      Name = "MainsLineConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "PowerDeliveryConfigDatum"
                      Name = "PowerDeliveryConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "ThermalConfigDatum"
                      Name = "ThermalConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerIpcConfigurationsId"
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
   [SingleManyToOne
      { Name = RelationName "AssistedCookingConfigDatum"
        TargetTable =
         { Name = TableName "AssistedCookingConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AssistedCookingConfigId"
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
             Primitive { Type = Int
                         Name = "InductanceMeasurementFrequency"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "AssistedCookingConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CoilOperationConfigDatum"
        TargetTable =
         { Name = TableName "CoilOperationConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilOperationConfigId"
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
                         Name = "PanDetectionTimeout"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CoilOperationConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionConfig"
        TargetTable =
         { Name = TableName "EmptyPotDetectionConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionConfigId"
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
                         Name = "EmptyPotDeratingDisengagementSlope"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeFixedPowerDerating"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionConfig"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        TargetTable =
         { Name =
            TableName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerConfiguration"
                          Name = "IpcControllerConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        TargetTable =
         { Name =
            TableName
              "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MainsLineConfigDatum"
        TargetTable =
         { Name = TableName "MainsLineConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MainsLineConfigId"
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
                         Name = "NominalPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "NominalCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IntegralGainCurrentAndPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CurrentFaultTreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PowerFaultThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartLineVoltageThresholdAfterSurgeFault"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartWaitingTimeAfterSurgeFault"
                         IsNullable = false };
             Primitive
               { Type = Float
                 Name = "ReclosingWaitingTimeAfter400VdetectionFaultIsCleared"
                 IsNullable = false };
             Primitive { Type = Float
                         Name = "OpeningWaitingTimeAfter400VdetectionFault"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MainsLineConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PowerDeliveryConfigDatum"
        TargetTable =
         { Name = TableName "PowerDeliveryConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PowerDeliveryConfigId"
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
                         Name = "MaxPowerGainFactorForPasoDobleOptimizer"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "LoadCharacterizationAttemptWaitingTime"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PowerDeliveryConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "ThermalConfigDatum"
        TargetTable =
         { Name = TableName "ThermalConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ThermalConfigId"
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
                         Name = "MaxDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MinDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "InitialValueDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ToleranceFromOverHeatingToWarm"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "HysteresysBandwidthHotIndicator"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ThermalConfigDatum"
        IsNullable = true
        KeyType = Guid }] }-CoilOperationConfigDatum-loader",
                            async ids => 
                            {
                                var data = await dbContext.CoilOperationConfigDatums
                                    .Where(x => x.CoilOperationConfigDatum != null && ids.Contains((Guid)x.CoilOperationConfigDatum))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CoilOperationConfigDatum!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CoilOperationConfigDatum);
                });
            
			
                Field<EmptyPotDetectionConfigGraphType, EmptyPotDetectionConfig>("EmptyPotDetectionConfigs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, EmptyPotDetectionConfigGraphType>(
                            "{ Name = EntityName "IpcControllerIpcConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerIpcConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerIpcConfigurationsId"
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
                     IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MainsLineConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PowerDeliveryConfigId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "ThermalConfigId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilOperationConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AssistedCookingConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "AssistedCookingConfigDatum"
                      Name = "AssistedCookingConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CoilOperationConfigDatum"
                      Name = "CoilOperationConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionConfig"
                      Name = "EmptyPotDetectionConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName
                "IpcControllerConfigurationsIpcControllerIpcConfiguration"
             Name = "IpcControllerConfigurationsIpcControllerIpcConfigurations"
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
         Navigation { Type = TableName "MainsLineConfigDatum"
                      Name = "MainsLineConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "PowerDeliveryConfigDatum"
                      Name = "PowerDeliveryConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "ThermalConfigDatum"
                      Name = "ThermalConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerIpcConfigurationsId"
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
   [SingleManyToOne
      { Name = RelationName "AssistedCookingConfigDatum"
        TargetTable =
         { Name = TableName "AssistedCookingConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AssistedCookingConfigId"
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
             Primitive { Type = Int
                         Name = "InductanceMeasurementFrequency"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "AssistedCookingConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CoilOperationConfigDatum"
        TargetTable =
         { Name = TableName "CoilOperationConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilOperationConfigId"
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
                         Name = "PanDetectionTimeout"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CoilOperationConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionConfig"
        TargetTable =
         { Name = TableName "EmptyPotDetectionConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionConfigId"
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
                         Name = "EmptyPotDeratingDisengagementSlope"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeFixedPowerDerating"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionConfig"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        TargetTable =
         { Name =
            TableName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerConfiguration"
                          Name = "IpcControllerConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        TargetTable =
         { Name =
            TableName
              "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MainsLineConfigDatum"
        TargetTable =
         { Name = TableName "MainsLineConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MainsLineConfigId"
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
                         Name = "NominalPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "NominalCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IntegralGainCurrentAndPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CurrentFaultTreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PowerFaultThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartLineVoltageThresholdAfterSurgeFault"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartWaitingTimeAfterSurgeFault"
                         IsNullable = false };
             Primitive
               { Type = Float
                 Name = "ReclosingWaitingTimeAfter400VdetectionFaultIsCleared"
                 IsNullable = false };
             Primitive { Type = Float
                         Name = "OpeningWaitingTimeAfter400VdetectionFault"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MainsLineConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PowerDeliveryConfigDatum"
        TargetTable =
         { Name = TableName "PowerDeliveryConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PowerDeliveryConfigId"
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
                         Name = "MaxPowerGainFactorForPasoDobleOptimizer"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "LoadCharacterizationAttemptWaitingTime"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PowerDeliveryConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "ThermalConfigDatum"
        TargetTable =
         { Name = TableName "ThermalConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ThermalConfigId"
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
                         Name = "MaxDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MinDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "InitialValueDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ToleranceFromOverHeatingToWarm"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "HysteresysBandwidthHotIndicator"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ThermalConfigDatum"
        IsNullable = true
        KeyType = Guid }] }-EmptyPotDetectionConfig-loader",
                            async ids => 
                            {
                                var data = await dbContext.EmptyPotDetectionConfigs
                                    .Where(x => x.EmptyPotDetectionConfig != null && ids.Contains((Guid)x.EmptyPotDetectionConfig))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.EmptyPotDetectionConfig!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.EmptyPotDetectionConfig);
                });
            
			
                Field<IpcControllerConfigurationsIpcControllerIpcConfigurationGraphType, IpcControllerConfigurationsIpcControllerIpcConfiguration>("IpcControllerConfigurationsIpcControllerIpcConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerConfigurationsIpcControllerIpcConfigurationGraphType>>(
                            "{ Name = EntityName "IpcControllerIpcConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerIpcConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerIpcConfigurationsId"
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
                     IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MainsLineConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PowerDeliveryConfigId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "ThermalConfigId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilOperationConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AssistedCookingConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "AssistedCookingConfigDatum"
                      Name = "AssistedCookingConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CoilOperationConfigDatum"
                      Name = "CoilOperationConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionConfig"
                      Name = "EmptyPotDetectionConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName
                "IpcControllerConfigurationsIpcControllerIpcConfiguration"
             Name = "IpcControllerConfigurationsIpcControllerIpcConfigurations"
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
         Navigation { Type = TableName "MainsLineConfigDatum"
                      Name = "MainsLineConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "PowerDeliveryConfigDatum"
                      Name = "PowerDeliveryConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "ThermalConfigDatum"
                      Name = "ThermalConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerIpcConfigurationsId"
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
   [SingleManyToOne
      { Name = RelationName "AssistedCookingConfigDatum"
        TargetTable =
         { Name = TableName "AssistedCookingConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AssistedCookingConfigId"
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
             Primitive { Type = Int
                         Name = "InductanceMeasurementFrequency"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "AssistedCookingConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CoilOperationConfigDatum"
        TargetTable =
         { Name = TableName "CoilOperationConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilOperationConfigId"
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
                         Name = "PanDetectionTimeout"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CoilOperationConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionConfig"
        TargetTable =
         { Name = TableName "EmptyPotDetectionConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionConfigId"
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
                         Name = "EmptyPotDeratingDisengagementSlope"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeFixedPowerDerating"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionConfig"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        TargetTable =
         { Name =
            TableName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerConfiguration"
                          Name = "IpcControllerConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        TargetTable =
         { Name =
            TableName
              "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MainsLineConfigDatum"
        TargetTable =
         { Name = TableName "MainsLineConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MainsLineConfigId"
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
                         Name = "NominalPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "NominalCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IntegralGainCurrentAndPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CurrentFaultTreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PowerFaultThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartLineVoltageThresholdAfterSurgeFault"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartWaitingTimeAfterSurgeFault"
                         IsNullable = false };
             Primitive
               { Type = Float
                 Name = "ReclosingWaitingTimeAfter400VdetectionFaultIsCleared"
                 IsNullable = false };
             Primitive { Type = Float
                         Name = "OpeningWaitingTimeAfter400VdetectionFault"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MainsLineConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PowerDeliveryConfigDatum"
        TargetTable =
         { Name = TableName "PowerDeliveryConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PowerDeliveryConfigId"
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
                         Name = "MaxPowerGainFactorForPasoDobleOptimizer"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "LoadCharacterizationAttemptWaitingTime"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PowerDeliveryConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "ThermalConfigDatum"
        TargetTable =
         { Name = TableName "ThermalConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ThermalConfigId"
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
                         Name = "MaxDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MinDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "InitialValueDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ToleranceFromOverHeatingToWarm"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "HysteresysBandwidthHotIndicator"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ThermalConfigDatum"
        IsNullable = true
        KeyType = Guid }] }-IpcControllerConfigurationsIpcControllerIpcConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.IpcControllerConfigurationsIpcControllerIpcConfigurations
                                    .Where(x => x.IpcControllerConfigurationsIpcControllerIpcConfiguration != null && ids.Contains((Guid)x.IpcControllerConfigurationsIpcControllerIpcConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.IpcControllerConfigurationsIpcControllerIpcConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.IpcControllerConfigurationsIpcControllerIpcConfigurations);
                    });
            
			
                Field<IpcControllerIpcConfigurationsIpcControllerCoilConfigurationGraphType, IpcControllerIpcConfigurationsIpcControllerCoilConfiguration>("IpcControllerIpcConfigurationsIpcControllerCoilConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerIpcConfigurationsIpcControllerCoilConfigurationGraphType>>(
                            "{ Name = EntityName "IpcControllerIpcConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerIpcConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerIpcConfigurationsId"
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
                     IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MainsLineConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PowerDeliveryConfigId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "ThermalConfigId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilOperationConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AssistedCookingConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "AssistedCookingConfigDatum"
                      Name = "AssistedCookingConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CoilOperationConfigDatum"
                      Name = "CoilOperationConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionConfig"
                      Name = "EmptyPotDetectionConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName
                "IpcControllerConfigurationsIpcControllerIpcConfiguration"
             Name = "IpcControllerConfigurationsIpcControllerIpcConfigurations"
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
         Navigation { Type = TableName "MainsLineConfigDatum"
                      Name = "MainsLineConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "PowerDeliveryConfigDatum"
                      Name = "PowerDeliveryConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "ThermalConfigDatum"
                      Name = "ThermalConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerIpcConfigurationsId"
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
   [SingleManyToOne
      { Name = RelationName "AssistedCookingConfigDatum"
        TargetTable =
         { Name = TableName "AssistedCookingConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AssistedCookingConfigId"
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
             Primitive { Type = Int
                         Name = "InductanceMeasurementFrequency"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "AssistedCookingConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CoilOperationConfigDatum"
        TargetTable =
         { Name = TableName "CoilOperationConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilOperationConfigId"
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
                         Name = "PanDetectionTimeout"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CoilOperationConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionConfig"
        TargetTable =
         { Name = TableName "EmptyPotDetectionConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionConfigId"
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
                         Name = "EmptyPotDeratingDisengagementSlope"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeFixedPowerDerating"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionConfig"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        TargetTable =
         { Name =
            TableName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerConfiguration"
                          Name = "IpcControllerConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        TargetTable =
         { Name =
            TableName
              "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MainsLineConfigDatum"
        TargetTable =
         { Name = TableName "MainsLineConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MainsLineConfigId"
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
                         Name = "NominalPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "NominalCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IntegralGainCurrentAndPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CurrentFaultTreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PowerFaultThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartLineVoltageThresholdAfterSurgeFault"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartWaitingTimeAfterSurgeFault"
                         IsNullable = false };
             Primitive
               { Type = Float
                 Name = "ReclosingWaitingTimeAfter400VdetectionFaultIsCleared"
                 IsNullable = false };
             Primitive { Type = Float
                         Name = "OpeningWaitingTimeAfter400VdetectionFault"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MainsLineConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PowerDeliveryConfigDatum"
        TargetTable =
         { Name = TableName "PowerDeliveryConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PowerDeliveryConfigId"
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
                         Name = "MaxPowerGainFactorForPasoDobleOptimizer"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "LoadCharacterizationAttemptWaitingTime"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PowerDeliveryConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "ThermalConfigDatum"
        TargetTable =
         { Name = TableName "ThermalConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ThermalConfigId"
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
                         Name = "MaxDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MinDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "InitialValueDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ToleranceFromOverHeatingToWarm"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "HysteresysBandwidthHotIndicator"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ThermalConfigDatum"
        IsNullable = true
        KeyType = Guid }] }-IpcControllerIpcConfigurationsIpcControllerCoilConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.IpcControllerIpcConfigurationsIpcControllerCoilConfigurations
                                    .Where(x => x.IpcControllerIpcConfigurationsIpcControllerCoilConfiguration != null && ids.Contains((Guid)x.IpcControllerIpcConfigurationsIpcControllerCoilConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.IpcControllerIpcConfigurationsIpcControllerCoilConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.IpcControllerIpcConfigurationsIpcControllerCoilConfigurations);
                    });
            
			
                Field<MainsLineConfigDatumGraphType, MainsLineConfigDatum>("MainsLineConfigDatums")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MainsLineConfigDatumGraphType>(
                            "{ Name = EntityName "IpcControllerIpcConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerIpcConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerIpcConfigurationsId"
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
                     IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MainsLineConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PowerDeliveryConfigId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "ThermalConfigId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilOperationConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AssistedCookingConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "AssistedCookingConfigDatum"
                      Name = "AssistedCookingConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CoilOperationConfigDatum"
                      Name = "CoilOperationConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionConfig"
                      Name = "EmptyPotDetectionConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName
                "IpcControllerConfigurationsIpcControllerIpcConfiguration"
             Name = "IpcControllerConfigurationsIpcControllerIpcConfigurations"
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
         Navigation { Type = TableName "MainsLineConfigDatum"
                      Name = "MainsLineConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "PowerDeliveryConfigDatum"
                      Name = "PowerDeliveryConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "ThermalConfigDatum"
                      Name = "ThermalConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerIpcConfigurationsId"
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
   [SingleManyToOne
      { Name = RelationName "AssistedCookingConfigDatum"
        TargetTable =
         { Name = TableName "AssistedCookingConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AssistedCookingConfigId"
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
             Primitive { Type = Int
                         Name = "InductanceMeasurementFrequency"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "AssistedCookingConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CoilOperationConfigDatum"
        TargetTable =
         { Name = TableName "CoilOperationConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilOperationConfigId"
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
                         Name = "PanDetectionTimeout"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CoilOperationConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionConfig"
        TargetTable =
         { Name = TableName "EmptyPotDetectionConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionConfigId"
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
                         Name = "EmptyPotDeratingDisengagementSlope"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeFixedPowerDerating"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionConfig"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        TargetTable =
         { Name =
            TableName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerConfiguration"
                          Name = "IpcControllerConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        TargetTable =
         { Name =
            TableName
              "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MainsLineConfigDatum"
        TargetTable =
         { Name = TableName "MainsLineConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MainsLineConfigId"
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
                         Name = "NominalPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "NominalCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IntegralGainCurrentAndPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CurrentFaultTreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PowerFaultThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartLineVoltageThresholdAfterSurgeFault"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartWaitingTimeAfterSurgeFault"
                         IsNullable = false };
             Primitive
               { Type = Float
                 Name = "ReclosingWaitingTimeAfter400VdetectionFaultIsCleared"
                 IsNullable = false };
             Primitive { Type = Float
                         Name = "OpeningWaitingTimeAfter400VdetectionFault"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MainsLineConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PowerDeliveryConfigDatum"
        TargetTable =
         { Name = TableName "PowerDeliveryConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PowerDeliveryConfigId"
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
                         Name = "MaxPowerGainFactorForPasoDobleOptimizer"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "LoadCharacterizationAttemptWaitingTime"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PowerDeliveryConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "ThermalConfigDatum"
        TargetTable =
         { Name = TableName "ThermalConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ThermalConfigId"
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
                         Name = "MaxDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MinDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "InitialValueDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ToleranceFromOverHeatingToWarm"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "HysteresysBandwidthHotIndicator"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ThermalConfigDatum"
        IsNullable = true
        KeyType = Guid }] }-MainsLineConfigDatum-loader",
                            async ids => 
                            {
                                var data = await dbContext.MainsLineConfigDatums
                                    .Where(x => x.MainsLineConfigDatum != null && ids.Contains((Guid)x.MainsLineConfigDatum))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MainsLineConfigDatum!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.MainsLineConfigDatum);
                });
            
			
                Field<PowerDeliveryConfigDatumGraphType, PowerDeliveryConfigDatum>("PowerDeliveryConfigDatums")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PowerDeliveryConfigDatumGraphType>(
                            "{ Name = EntityName "IpcControllerIpcConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerIpcConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerIpcConfigurationsId"
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
                     IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MainsLineConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PowerDeliveryConfigId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "ThermalConfigId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilOperationConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AssistedCookingConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "AssistedCookingConfigDatum"
                      Name = "AssistedCookingConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CoilOperationConfigDatum"
                      Name = "CoilOperationConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionConfig"
                      Name = "EmptyPotDetectionConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName
                "IpcControllerConfigurationsIpcControllerIpcConfiguration"
             Name = "IpcControllerConfigurationsIpcControllerIpcConfigurations"
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
         Navigation { Type = TableName "MainsLineConfigDatum"
                      Name = "MainsLineConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "PowerDeliveryConfigDatum"
                      Name = "PowerDeliveryConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "ThermalConfigDatum"
                      Name = "ThermalConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerIpcConfigurationsId"
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
   [SingleManyToOne
      { Name = RelationName "AssistedCookingConfigDatum"
        TargetTable =
         { Name = TableName "AssistedCookingConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AssistedCookingConfigId"
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
             Primitive { Type = Int
                         Name = "InductanceMeasurementFrequency"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "AssistedCookingConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CoilOperationConfigDatum"
        TargetTable =
         { Name = TableName "CoilOperationConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilOperationConfigId"
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
                         Name = "PanDetectionTimeout"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CoilOperationConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionConfig"
        TargetTable =
         { Name = TableName "EmptyPotDetectionConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionConfigId"
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
                         Name = "EmptyPotDeratingDisengagementSlope"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeFixedPowerDerating"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionConfig"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        TargetTable =
         { Name =
            TableName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerConfiguration"
                          Name = "IpcControllerConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        TargetTable =
         { Name =
            TableName
              "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MainsLineConfigDatum"
        TargetTable =
         { Name = TableName "MainsLineConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MainsLineConfigId"
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
                         Name = "NominalPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "NominalCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IntegralGainCurrentAndPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CurrentFaultTreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PowerFaultThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartLineVoltageThresholdAfterSurgeFault"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartWaitingTimeAfterSurgeFault"
                         IsNullable = false };
             Primitive
               { Type = Float
                 Name = "ReclosingWaitingTimeAfter400VdetectionFaultIsCleared"
                 IsNullable = false };
             Primitive { Type = Float
                         Name = "OpeningWaitingTimeAfter400VdetectionFault"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MainsLineConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PowerDeliveryConfigDatum"
        TargetTable =
         { Name = TableName "PowerDeliveryConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PowerDeliveryConfigId"
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
                         Name = "MaxPowerGainFactorForPasoDobleOptimizer"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "LoadCharacterizationAttemptWaitingTime"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PowerDeliveryConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "ThermalConfigDatum"
        TargetTable =
         { Name = TableName "ThermalConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ThermalConfigId"
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
                         Name = "MaxDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MinDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "InitialValueDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ToleranceFromOverHeatingToWarm"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "HysteresysBandwidthHotIndicator"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ThermalConfigDatum"
        IsNullable = true
        KeyType = Guid }] }-PowerDeliveryConfigDatum-loader",
                            async ids => 
                            {
                                var data = await dbContext.PowerDeliveryConfigDatums
                                    .Where(x => x.PowerDeliveryConfigDatum != null && ids.Contains((Guid)x.PowerDeliveryConfigDatum))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PowerDeliveryConfigDatum!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PowerDeliveryConfigDatum);
                });
            
			
                Field<ThermalConfigDatumGraphType, ThermalConfigDatum>("ThermalConfigDatums")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ThermalConfigDatumGraphType>(
                            "{ Name = EntityName "IpcControllerIpcConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerIpcConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerIpcConfigurationsId"
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
                     IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MainsLineConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PowerDeliveryConfigId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "ThermalConfigId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilOperationConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AssistedCookingConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "AssistedCookingConfigDatum"
                      Name = "AssistedCookingConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CoilOperationConfigDatum"
                      Name = "CoilOperationConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionConfig"
                      Name = "EmptyPotDetectionConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName
                "IpcControllerConfigurationsIpcControllerIpcConfiguration"
             Name = "IpcControllerConfigurationsIpcControllerIpcConfigurations"
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
         Navigation { Type = TableName "MainsLineConfigDatum"
                      Name = "MainsLineConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "PowerDeliveryConfigDatum"
                      Name = "PowerDeliveryConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "ThermalConfigDatum"
                      Name = "ThermalConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerIpcConfigurationsId"
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
   [SingleManyToOne
      { Name = RelationName "AssistedCookingConfigDatum"
        TargetTable =
         { Name = TableName "AssistedCookingConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AssistedCookingConfigId"
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
             Primitive { Type = Int
                         Name = "InductanceMeasurementFrequency"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "AssistedCookingConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CoilOperationConfigDatum"
        TargetTable =
         { Name = TableName "CoilOperationConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilOperationConfigId"
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
                         Name = "PanDetectionTimeout"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CoilOperationConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionConfig"
        TargetTable =
         { Name = TableName "EmptyPotDetectionConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionConfigId"
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
                         Name = "EmptyPotDeratingDisengagementSlope"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeFixedPowerDerating"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionConfig"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        TargetTable =
         { Name =
            TableName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerConfiguration"
                          Name = "IpcControllerConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerConfigurationsIpcControllerIpcConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        TargetTable =
         { Name =
            TableName
              "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MainsLineConfigDatum"
        TargetTable =
         { Name = TableName "MainsLineConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MainsLineConfigId"
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
                         Name = "NominalPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "NominalCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IntegralGainCurrentAndPower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CurrentFaultTreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PowerFaultThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartLineVoltageThresholdAfterSurgeFault"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RestartWaitingTimeAfterSurgeFault"
                         IsNullable = false };
             Primitive
               { Type = Float
                 Name = "ReclosingWaitingTimeAfter400VdetectionFaultIsCleared"
                 IsNullable = false };
             Primitive { Type = Float
                         Name = "OpeningWaitingTimeAfter400VdetectionFault"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MainsLineConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PowerDeliveryConfigDatum"
        TargetTable =
         { Name = TableName "PowerDeliveryConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PowerDeliveryConfigId"
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
                         Name = "MaxPowerGainFactorForPasoDobleOptimizer"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "LoadCharacterizationAttemptWaitingTime"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PowerDeliveryConfigDatum"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "ThermalConfigDatum"
        TargetTable =
         { Name = TableName "ThermalConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ThermalConfigId"
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
                         Name = "MaxDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MinDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "InitialValueDeratingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ToleranceFromOverHeatingToWarm"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "HysteresysBandwidthHotIndicator"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ThermalConfigDatum"
        IsNullable = true
        KeyType = Guid }] }-ThermalConfigDatum-loader",
                            async ids => 
                            {
                                var data = await dbContext.ThermalConfigDatums
                                    .Where(x => x.ThermalConfigDatum != null && ids.Contains((Guid)x.ThermalConfigDatum))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.ThermalConfigDatum!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.ThermalConfigDatum);
                });
            
        }
    }
}
            