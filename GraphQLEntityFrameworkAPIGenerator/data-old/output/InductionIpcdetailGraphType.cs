
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
    public partial class InductionIpcdetailGraphType : ObjectGraphType<InductionIpcdetail>
    {
        public InductionIpcdetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionIpcid, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SyncSerial, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.MasterSlave, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HalfBridgeQuasiResonant, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.InfinitePotLoss, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HeatsinkFanLoadIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfCoins, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MainRelayLoadIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InverterTechnology, type: typeof(ByteGraphType), nullable: False);
            
                Field<InductionCooktopOrgConfigurationsInductionIpcdetailGraphType, InductionCooktopOrgConfigurationsInductionIpcdetail>("InductionCooktopOrgConfigurationsInductionIpcdetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCooktopOrgConfigurationsInductionIpcdetailGraphType>>(
                            "{ Name = EntityName "InductionIpcdetail"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionIpcdetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionIpcid"
                      IsNullable = false }; Primitive { Type = Bool
                                                        Name = "SyncSerial"
                                                        IsNullable = false };
         Primitive { Type = Bool
                     Name = "MasterSlave"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "HalfBridgeQuasiResonant"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel0Id"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel1Id"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel2Id"
                      IsNullable = true }; Primitive { Type = String
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
                     IsNullable = true }; Primitive { Type = Bool
                                                      Name = "InfinitePotLoss"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "HeatsinkFanLoadIndex"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "NumberOfCoins"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "MainRelayLoadIndex"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionIpcSpecificDataId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "InverterTechnology"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "IpcSpecificSafetyParamsId"
                      IsNullable = true };
         Navigation
           { Type =
              TableName "InductionCooktopOrgConfigurationsInductionIpcdetail"
             Name = "InductionCooktopOrgConfigurationsInductionIpcdetails"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "InductionIpcSpecificDatum"
                      Name = "InductionIpcSpecificData"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionIpcdetailsInductionCoilConfig"
                      Name = "InductionIpcdetailsInductionCoilConfigs"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "IpcSpecificSafetyParam"
                      Name = "IpcSpecificSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel0"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel1"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel2"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "InductionIpcid"
      Type = Id Guid
      IsNullable = false }; { Name = "SyncSerial"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "MasterSlave"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "HalfBridgeQuasiResonant"
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
    { Name = "InfinitePotLoss"
      Type = Primitive Bool
      IsNullable = false }; { Name = "HeatsinkFanLoadIndex"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "NumberOfCoins"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "MainRelayLoadIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InverterTechnology"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName "InductionCooktopOrgConfigurationsInductionIpcdetail"
        TargetTable =
         { Name =
            TableName "InductionCooktopOrgConfigurationsInductionIpcdetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CooktopOrgConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionIpcid"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "InductionCooktopOrgConfiguration"
                          Name = "CooktopOrgConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpc"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "InductionCooktopOrgConfigurationsInductionIpcdetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionIpcSpecificDatum"
        TargetTable =
         { Name = TableName "InductionIpcSpecificDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIpcSpecificDataId"
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
                         Name = "PanInactiveCounterTimeout"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyLimitSlackGain"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyIncreaseGainCritical"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyIncreaseGainOverload"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyDecreaseGainRelax"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IirSmoothingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IirValidationMinDebounceSteps"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MainsLineUnderVoltageFailureThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MainsLineOverVoltageFailureThreshold"
                         IsNullable = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionIpcSpecificDatum"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "InductionIpcdetailsInductionCoilConfig"
        TargetTable =
         { Name = TableName "InductionIpcdetailsInductionCoilConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIpcid"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionCoilConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpc"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "InductionIpcdetailsInductionCoilConfig"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "IpcSpecificSafetyParam"
        TargetTable =
         { Name = TableName "IpcSpecificSafetyParam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcSpecificSafetyParamsId"
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
                         Name = "DeltaTempStartRisingTimeEvaluation"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "DeltaTempEndRisingTimeEvaluation"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeMinFixedPowerDeration"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMonitoringAdditionalOffset"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMonitoringMaxTemperature"
                         IsNullable = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "IpcSpecificSafetyParam"
        IsNullable = true
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "ZeroCrossChannel0"; RelationName "ZeroCrossChannel1";
          RelationName "ZeroCrossChannel2"]
        TargetTable =
         { Name = TableName "InductionZeroCrossConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ZeroCrossConfigId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "HeatSink0Giid"
                          IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "HeatSink1Giid"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "InverterChannel0Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "InverterChannel1Id"
                          IsNullable = true }; Primitive { Type = String
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
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel0s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel2s"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InverterChannel0"
                 IsNullable = true
                 IsCollection = false };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InverterChannel1"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "InductionZeroCrossConfiguration"
        IsNullable = true
        KeyType = Guid }] }-InductionCooktopOrgConfigurationsInductionIpcdetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionCooktopOrgConfigurationsInductionIpcdetails
                                    .Where(x => x.InductionCooktopOrgConfigurationsInductionIpcdetail != null && ids.Contains((Guid)x.InductionCooktopOrgConfigurationsInductionIpcdetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionCooktopOrgConfigurationsInductionIpcdetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.InductionCooktopOrgConfigurationsInductionIpcdetails);
                    });
            
			
                Field<InductionIpcSpecificDatumGraphType, InductionIpcSpecificDatum>("InductionIpcSpecificDatums")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionIpcSpecificDatumGraphType>(
                            "{ Name = EntityName "InductionIpcdetail"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionIpcdetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionIpcid"
                      IsNullable = false }; Primitive { Type = Bool
                                                        Name = "SyncSerial"
                                                        IsNullable = false };
         Primitive { Type = Bool
                     Name = "MasterSlave"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "HalfBridgeQuasiResonant"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel0Id"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel1Id"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel2Id"
                      IsNullable = true }; Primitive { Type = String
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
                     IsNullable = true }; Primitive { Type = Bool
                                                      Name = "InfinitePotLoss"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "HeatsinkFanLoadIndex"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "NumberOfCoins"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "MainRelayLoadIndex"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionIpcSpecificDataId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "InverterTechnology"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "IpcSpecificSafetyParamsId"
                      IsNullable = true };
         Navigation
           { Type =
              TableName "InductionCooktopOrgConfigurationsInductionIpcdetail"
             Name = "InductionCooktopOrgConfigurationsInductionIpcdetails"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "InductionIpcSpecificDatum"
                      Name = "InductionIpcSpecificData"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionIpcdetailsInductionCoilConfig"
                      Name = "InductionIpcdetailsInductionCoilConfigs"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "IpcSpecificSafetyParam"
                      Name = "IpcSpecificSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel0"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel1"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel2"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "InductionIpcid"
      Type = Id Guid
      IsNullable = false }; { Name = "SyncSerial"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "MasterSlave"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "HalfBridgeQuasiResonant"
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
    { Name = "InfinitePotLoss"
      Type = Primitive Bool
      IsNullable = false }; { Name = "HeatsinkFanLoadIndex"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "NumberOfCoins"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "MainRelayLoadIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InverterTechnology"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName "InductionCooktopOrgConfigurationsInductionIpcdetail"
        TargetTable =
         { Name =
            TableName "InductionCooktopOrgConfigurationsInductionIpcdetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CooktopOrgConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionIpcid"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "InductionCooktopOrgConfiguration"
                          Name = "CooktopOrgConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpc"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "InductionCooktopOrgConfigurationsInductionIpcdetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionIpcSpecificDatum"
        TargetTable =
         { Name = TableName "InductionIpcSpecificDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIpcSpecificDataId"
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
                         Name = "PanInactiveCounterTimeout"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyLimitSlackGain"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyIncreaseGainCritical"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyIncreaseGainOverload"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyDecreaseGainRelax"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IirSmoothingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IirValidationMinDebounceSteps"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MainsLineUnderVoltageFailureThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MainsLineOverVoltageFailureThreshold"
                         IsNullable = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionIpcSpecificDatum"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "InductionIpcdetailsInductionCoilConfig"
        TargetTable =
         { Name = TableName "InductionIpcdetailsInductionCoilConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIpcid"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionCoilConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpc"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "InductionIpcdetailsInductionCoilConfig"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "IpcSpecificSafetyParam"
        TargetTable =
         { Name = TableName "IpcSpecificSafetyParam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcSpecificSafetyParamsId"
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
                         Name = "DeltaTempStartRisingTimeEvaluation"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "DeltaTempEndRisingTimeEvaluation"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeMinFixedPowerDeration"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMonitoringAdditionalOffset"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMonitoringMaxTemperature"
                         IsNullable = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "IpcSpecificSafetyParam"
        IsNullable = true
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "ZeroCrossChannel0"; RelationName "ZeroCrossChannel1";
          RelationName "ZeroCrossChannel2"]
        TargetTable =
         { Name = TableName "InductionZeroCrossConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ZeroCrossConfigId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "HeatSink0Giid"
                          IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "HeatSink1Giid"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "InverterChannel0Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "InverterChannel1Id"
                          IsNullable = true }; Primitive { Type = String
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
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel0s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel2s"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InverterChannel0"
                 IsNullable = true
                 IsCollection = false };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InverterChannel1"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "InductionZeroCrossConfiguration"
        IsNullable = true
        KeyType = Guid }] }-InductionIpcSpecificDatum-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionIpcSpecificDatums
                                    .Where(x => x.InductionIpcSpecificDatum != null && ids.Contains((Guid)x.InductionIpcSpecificDatum))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionIpcSpecificDatum!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InductionIpcSpecificDatum);
                });
            
			
                Field<InductionIpcdetailsInductionCoilConfigGraphType, InductionIpcdetailsInductionCoilConfig>("InductionIpcdetailsInductionCoilConfigs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionIpcdetailsInductionCoilConfigGraphType>>(
                            "{ Name = EntityName "InductionIpcdetail"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionIpcdetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionIpcid"
                      IsNullable = false }; Primitive { Type = Bool
                                                        Name = "SyncSerial"
                                                        IsNullable = false };
         Primitive { Type = Bool
                     Name = "MasterSlave"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "HalfBridgeQuasiResonant"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel0Id"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel1Id"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel2Id"
                      IsNullable = true }; Primitive { Type = String
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
                     IsNullable = true }; Primitive { Type = Bool
                                                      Name = "InfinitePotLoss"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "HeatsinkFanLoadIndex"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "NumberOfCoins"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "MainRelayLoadIndex"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionIpcSpecificDataId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "InverterTechnology"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "IpcSpecificSafetyParamsId"
                      IsNullable = true };
         Navigation
           { Type =
              TableName "InductionCooktopOrgConfigurationsInductionIpcdetail"
             Name = "InductionCooktopOrgConfigurationsInductionIpcdetails"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "InductionIpcSpecificDatum"
                      Name = "InductionIpcSpecificData"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionIpcdetailsInductionCoilConfig"
                      Name = "InductionIpcdetailsInductionCoilConfigs"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "IpcSpecificSafetyParam"
                      Name = "IpcSpecificSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel0"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel1"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel2"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "InductionIpcid"
      Type = Id Guid
      IsNullable = false }; { Name = "SyncSerial"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "MasterSlave"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "HalfBridgeQuasiResonant"
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
    { Name = "InfinitePotLoss"
      Type = Primitive Bool
      IsNullable = false }; { Name = "HeatsinkFanLoadIndex"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "NumberOfCoins"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "MainRelayLoadIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InverterTechnology"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName "InductionCooktopOrgConfigurationsInductionIpcdetail"
        TargetTable =
         { Name =
            TableName "InductionCooktopOrgConfigurationsInductionIpcdetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CooktopOrgConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionIpcid"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "InductionCooktopOrgConfiguration"
                          Name = "CooktopOrgConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpc"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "InductionCooktopOrgConfigurationsInductionIpcdetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionIpcSpecificDatum"
        TargetTable =
         { Name = TableName "InductionIpcSpecificDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIpcSpecificDataId"
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
                         Name = "PanInactiveCounterTimeout"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyLimitSlackGain"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyIncreaseGainCritical"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyIncreaseGainOverload"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyDecreaseGainRelax"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IirSmoothingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IirValidationMinDebounceSteps"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MainsLineUnderVoltageFailureThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MainsLineOverVoltageFailureThreshold"
                         IsNullable = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionIpcSpecificDatum"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "InductionIpcdetailsInductionCoilConfig"
        TargetTable =
         { Name = TableName "InductionIpcdetailsInductionCoilConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIpcid"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionCoilConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpc"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "InductionIpcdetailsInductionCoilConfig"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "IpcSpecificSafetyParam"
        TargetTable =
         { Name = TableName "IpcSpecificSafetyParam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcSpecificSafetyParamsId"
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
                         Name = "DeltaTempStartRisingTimeEvaluation"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "DeltaTempEndRisingTimeEvaluation"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeMinFixedPowerDeration"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMonitoringAdditionalOffset"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMonitoringMaxTemperature"
                         IsNullable = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "IpcSpecificSafetyParam"
        IsNullable = true
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "ZeroCrossChannel0"; RelationName "ZeroCrossChannel1";
          RelationName "ZeroCrossChannel2"]
        TargetTable =
         { Name = TableName "InductionZeroCrossConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ZeroCrossConfigId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "HeatSink0Giid"
                          IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "HeatSink1Giid"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "InverterChannel0Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "InverterChannel1Id"
                          IsNullable = true }; Primitive { Type = String
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
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel0s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel2s"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InverterChannel0"
                 IsNullable = true
                 IsCollection = false };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InverterChannel1"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "InductionZeroCrossConfiguration"
        IsNullable = true
        KeyType = Guid }] }-InductionIpcdetailsInductionCoilConfig-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionIpcdetailsInductionCoilConfigs
                                    .Where(x => x.InductionIpcdetailsInductionCoilConfig != null && ids.Contains((Guid)x.InductionIpcdetailsInductionCoilConfig))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionIpcdetailsInductionCoilConfig!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.InductionIpcdetailsInductionCoilConfigs);
                    });
            
			
                Field<IpcSpecificSafetyParamGraphType, IpcSpecificSafetyParam>("IpcSpecificSafetyParams")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IpcSpecificSafetyParamGraphType>(
                            "{ Name = EntityName "InductionIpcdetail"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionIpcdetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionIpcid"
                      IsNullable = false }; Primitive { Type = Bool
                                                        Name = "SyncSerial"
                                                        IsNullable = false };
         Primitive { Type = Bool
                     Name = "MasterSlave"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "HalfBridgeQuasiResonant"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel0Id"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel1Id"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel2Id"
                      IsNullable = true }; Primitive { Type = String
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
                     IsNullable = true }; Primitive { Type = Bool
                                                      Name = "InfinitePotLoss"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "HeatsinkFanLoadIndex"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "NumberOfCoins"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "MainRelayLoadIndex"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionIpcSpecificDataId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "InverterTechnology"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "IpcSpecificSafetyParamsId"
                      IsNullable = true };
         Navigation
           { Type =
              TableName "InductionCooktopOrgConfigurationsInductionIpcdetail"
             Name = "InductionCooktopOrgConfigurationsInductionIpcdetails"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "InductionIpcSpecificDatum"
                      Name = "InductionIpcSpecificData"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionIpcdetailsInductionCoilConfig"
                      Name = "InductionIpcdetailsInductionCoilConfigs"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "IpcSpecificSafetyParam"
                      Name = "IpcSpecificSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel0"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel1"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel2"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "InductionIpcid"
      Type = Id Guid
      IsNullable = false }; { Name = "SyncSerial"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "MasterSlave"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "HalfBridgeQuasiResonant"
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
    { Name = "InfinitePotLoss"
      Type = Primitive Bool
      IsNullable = false }; { Name = "HeatsinkFanLoadIndex"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "NumberOfCoins"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "MainRelayLoadIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InverterTechnology"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName "InductionCooktopOrgConfigurationsInductionIpcdetail"
        TargetTable =
         { Name =
            TableName "InductionCooktopOrgConfigurationsInductionIpcdetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CooktopOrgConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionIpcid"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "InductionCooktopOrgConfiguration"
                          Name = "CooktopOrgConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpc"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "InductionCooktopOrgConfigurationsInductionIpcdetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionIpcSpecificDatum"
        TargetTable =
         { Name = TableName "InductionIpcSpecificDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIpcSpecificDataId"
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
                         Name = "PanInactiveCounterTimeout"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyLimitSlackGain"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyIncreaseGainCritical"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyIncreaseGainOverload"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyDecreaseGainRelax"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IirSmoothingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IirValidationMinDebounceSteps"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MainsLineUnderVoltageFailureThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MainsLineOverVoltageFailureThreshold"
                         IsNullable = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionIpcSpecificDatum"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "InductionIpcdetailsInductionCoilConfig"
        TargetTable =
         { Name = TableName "InductionIpcdetailsInductionCoilConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIpcid"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionCoilConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpc"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "InductionIpcdetailsInductionCoilConfig"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "IpcSpecificSafetyParam"
        TargetTable =
         { Name = TableName "IpcSpecificSafetyParam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcSpecificSafetyParamsId"
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
                         Name = "DeltaTempStartRisingTimeEvaluation"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "DeltaTempEndRisingTimeEvaluation"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeMinFixedPowerDeration"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMonitoringAdditionalOffset"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMonitoringMaxTemperature"
                         IsNullable = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "IpcSpecificSafetyParam"
        IsNullable = true
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "ZeroCrossChannel0"; RelationName "ZeroCrossChannel1";
          RelationName "ZeroCrossChannel2"]
        TargetTable =
         { Name = TableName "InductionZeroCrossConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ZeroCrossConfigId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "HeatSink0Giid"
                          IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "HeatSink1Giid"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "InverterChannel0Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "InverterChannel1Id"
                          IsNullable = true }; Primitive { Type = String
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
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel0s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel2s"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InverterChannel0"
                 IsNullable = true
                 IsCollection = false };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InverterChannel1"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "InductionZeroCrossConfiguration"
        IsNullable = true
        KeyType = Guid }] }-IpcSpecificSafetyParam-loader",
                            async ids => 
                            {
                                var data = await dbContext.IpcSpecificSafetyParams
                                    .Where(x => x.IpcSpecificSafetyParam != null && ids.Contains((Guid)x.IpcSpecificSafetyParam))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.IpcSpecificSafetyParam!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.IpcSpecificSafetyParam);
                });
            
			
                Field<InductionZeroCrossConfigurationGraphType, InductionZeroCrossConfiguration>("InductionZeroCrossConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionZeroCrossConfigurationGraphType>(
                            "{ Name = EntityName "InductionIpcdetail"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionIpcdetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionIpcid"
                      IsNullable = false }; Primitive { Type = Bool
                                                        Name = "SyncSerial"
                                                        IsNullable = false };
         Primitive { Type = Bool
                     Name = "MasterSlave"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "HalfBridgeQuasiResonant"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel0Id"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel1Id"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ZeroCrossChannel2Id"
                      IsNullable = true }; Primitive { Type = String
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
                     IsNullable = true }; Primitive { Type = Bool
                                                      Name = "InfinitePotLoss"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "HeatsinkFanLoadIndex"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "NumberOfCoins"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "MainRelayLoadIndex"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionIpcSpecificDataId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "InverterTechnology"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "IpcSpecificSafetyParamsId"
                      IsNullable = true };
         Navigation
           { Type =
              TableName "InductionCooktopOrgConfigurationsInductionIpcdetail"
             Name = "InductionCooktopOrgConfigurationsInductionIpcdetails"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "InductionIpcSpecificDatum"
                      Name = "InductionIpcSpecificData"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionIpcdetailsInductionCoilConfig"
                      Name = "InductionIpcdetailsInductionCoilConfigs"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "IpcSpecificSafetyParam"
                      Name = "IpcSpecificSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel0"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel1"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "ZeroCrossChannel2"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "InductionIpcid"
      Type = Id Guid
      IsNullable = false }; { Name = "SyncSerial"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "MasterSlave"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "HalfBridgeQuasiResonant"
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
    { Name = "InfinitePotLoss"
      Type = Primitive Bool
      IsNullable = false }; { Name = "HeatsinkFanLoadIndex"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "NumberOfCoins"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "MainRelayLoadIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InverterTechnology"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName "InductionCooktopOrgConfigurationsInductionIpcdetail"
        TargetTable =
         { Name =
            TableName "InductionCooktopOrgConfigurationsInductionIpcdetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CooktopOrgConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionIpcid"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "InductionCooktopOrgConfiguration"
                          Name = "CooktopOrgConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpc"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "InductionCooktopOrgConfigurationsInductionIpcdetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionIpcSpecificDatum"
        TargetTable =
         { Name = TableName "InductionIpcSpecificDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIpcSpecificDataId"
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
                         Name = "PanInactiveCounterTimeout"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyLimitSlackGain"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyIncreaseGainCritical"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyIncreaseGainOverload"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FrequencyDecreaseGainRelax"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IirSmoothingFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "IirValidationMinDebounceSteps"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MainsLineUnderVoltageFailureThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MainsLineOverVoltageFailureThreshold"
                         IsNullable = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionIpcSpecificDatum"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "InductionIpcdetailsInductionCoilConfig"
        TargetTable =
         { Name = TableName "InductionIpcdetailsInductionCoilConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIpcid"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionCoilConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpc"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "InductionIpcdetailsInductionCoilConfig"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "IpcSpecificSafetyParam"
        TargetTable =
         { Name = TableName "IpcSpecificSafetyParam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcSpecificSafetyParamsId"
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
                         Name = "DeltaTempStartRisingTimeEvaluation"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "DeltaTempEndRisingTimeEvaluation"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeMinFixedPowerDeration"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMonitoringAdditionalOffset"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMonitoringMaxTemperature"
                         IsNullable = false };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "IpcSpecificSafetyParam"
        IsNullable = true
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "ZeroCrossChannel0"; RelationName "ZeroCrossChannel1";
          RelationName "ZeroCrossChannel2"]
        TargetTable =
         { Name = TableName "InductionZeroCrossConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ZeroCrossConfigId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "HeatSink0Giid"
                          IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "HeatSink1Giid"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "InverterChannel0Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "InverterChannel1Id"
                          IsNullable = true }; Primitive { Type = String
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
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel0s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel2s"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InverterChannel0"
                 IsNullable = true
                 IsCollection = false };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InverterChannel1"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "InductionZeroCrossConfiguration"
        IsNullable = true
        KeyType = Guid }] }-InductionZeroCrossConfiguration-loader",
                            async ids => 
                            {
                                Expression<Func<InductionZeroCrossConfiguration, bool>> expr = x => !ids.Any()
                                    \|\| (x.ZeroCrossChannel0 != null && ids.Contains((Guid)x.ZeroCrossChannel0))
\|\| (x.ZeroCrossChannel1 != null && ids.Contains((Guid)x.ZeroCrossChannel1))
\|\| (x.ZeroCrossChannel2 != null && ids.Contains((Guid)x.ZeroCrossChannel2));

                                var data = await dbContext.InductionZeroCrossConfigurations
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.ZeroCrossChannel0,
x.ZeroCrossChannel1,
x.ZeroCrossChannel2
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.InductionZeroCrossConfigurations);
                    });
            
        }
    }
}
            