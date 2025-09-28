
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
    public partial class InductionCoilConfigGraphType : ObjectGraphType<InductionCoilConfig>
    {
        public InductionCoilConfigGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionCoilConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<InductionCoilNtcspecificGraphType, InductionCoilNtcspecific>("InductionCoilNtcspecifics")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilNtcspecificGraphType>(
                            "{ Name = EntityName "InductionCoilConfig"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionCoilConfig"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionCoilConfigId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "CoilLoadId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "HeatsinkNtcgiid"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionCoilHeatsinkNtcspecificId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "InductionCoilSpecificId"
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
                     IsNullable = true }; ForeignKey { Type = Byte
                                                       Name = "CoilNtcgiid"
                                                       IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "Acntcgiid"
                      IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "HeatsinkFanLoadId"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "CoilNtcspecificId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "AcntcspecificId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilSripcsafetyId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "InductionCoilPowerTableConfigId"
                      IsNullable = true };
         ForeignKey { Type = Byte
                      Name = "IgbtTemperatureGiid"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionInverterSpecificDataId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "IgbtSafetyParamsId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionCoilSafetyParamsId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "Acntcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "CoilNtcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilSripcsafety"
                      Name = "CoilSripcsafety"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionCoilSafetyParam"
                      Name = "EmptyPotDetectionCoilSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "IgbtSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "InductionCoilHeatsinkNtcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilPowerTableConfiguration"
                      Name = "InductionCoilPowerTableConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilSpecific"
                      Name = "InductionCoilSpecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionInverterSpecificDatum"
                      Name = "InductionInverterSpecificData"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionIpcdetailsInductionCoilConfig"
                      Name = "InductionIpcdetailsInductionCoilConfigs"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "InductionCoilConfigId"
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
         [RelationName "Acntcspecific"; RelationName "CoilNtcspecific";
          RelationName "IgbtSafetyParams";
          RelationName "InductionCoilHeatsinkNtcspecific"]
        TargetTable =
         { Name = TableName "InductionCoilNtcspecific"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilNtcspecificId"
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
                         Name = "StuckExecutionTime"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StuckValidationTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SafetyDebounceTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ShortDebounceTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "OpenDebounceTime"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "ShortThresholdMax"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "OpenThresholdMin"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckWindowMin"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckWindowMax"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckExitDelta"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "SafetyThreshold"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "SafetyHysteresis"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "StuckExitDeltaCelsius"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SafetyHysteresisCelsius"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigAcntcspecifics"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigCoilNtcspecifics"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigIgbtSafetyParams"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "InductionCoilConfig"
                 Name = "InductionCoilConfigInductionCoilHeatsinkNtcspecifics"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilNtcspecific"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilSripcsafety"
        TargetTable =
         { Name = TableName "InductionCoilSripcsafety"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilSripcsafetyId"
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
                         Name = "DualZoneRole"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CoilModelId"
                                                            IsNullable = false };
             Primitive { Type = Float
                         Name = "CoverageAcceptance"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoverageRejection"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "CoverageMove"
                                                           IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilSripcsafety"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionCoilSafetyParam"
        TargetTable =
         { Name = TableName "EmptyPotDetectionCoilSafetyParam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionCoilSafetyParamsId"
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
                         Name = "IsEmptyPotDetectionEnabled"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseGapTempSensorForEmptyPotDetection"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RisingTimeThreshold"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MinLoadPowerAvgDeliveredDuringRisingTime"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxLoadPowerAvgDeliveredDuringRisingTime"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxLoadPowerAvgWhenFixedDerating"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureControlSetpointSlope"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionCoilSafetyParam"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilPowerTableConfiguration"
        TargetTable =
         { Name = TableName "InductionCoilPowerTableConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableConfigId"
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
                         Name = "BoosterLevel"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "InductionCoilChannels"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
                 Name =
                  "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilPowerTableConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilSpecific"
        TargetTable =
         { Name = TableName "InductionCoilSpecific"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilSpecificId"
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
             Primitive { Type = Short
                         Name = "ResonanceCapacitance"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "MaxCurrentNormal"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "MaxCurrentBooster"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "BoosterPowerThreshold"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "PanettoneElectricThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PanDetectedThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PanNotDetectedThreshold"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxNominalLoadAveragePower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalIgbtPeakTurnOffCurrent"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxNominalLoadAveragePowerBooster"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalIgbtPeakTurnOffCurrentBooster"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalLoadRmsCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalLoadRmsCurrentBooster"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilSpecific"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionInverterSpecificDatum"
        TargetTable =
         { Name = TableName "InductionInverterSpecificDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionInverterSpecificDataId"
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
                         Name = "SnubberCapacitance"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ResonantCapacitance"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "GateDelayOffHighSideIgbt"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "GateDelayOffLowSideIgbt"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalInverterPowerFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalInverterPowerFactorBooster"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionInverterSpecificDatum"
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
        KeyType = Guid }] }-InductionCoilNtcspecific-loader",
                            async ids => 
                            {
                                Expression<Func<InductionCoilNtcspecific, bool>> expr = x => !ids.Any()
                                    \|\| (x.Acntcspecific != null && ids.Contains((Guid)x.Acntcspecific))
\|\| (x.CoilNtcspecific != null && ids.Contains((Guid)x.CoilNtcspecific))
\|\| (x.IgbtSafetyParams != null && ids.Contains((Guid)x.IgbtSafetyParams))
\|\| (x.InductionCoilHeatsinkNtcspecific != null && ids.Contains((Guid)x.InductionCoilHeatsinkNtcspecific));

                                var data = await dbContext.InductionCoilNtcspecifics
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.Acntcspecific,
x.CoilNtcspecific,
x.IgbtSafetyParams,
x.InductionCoilHeatsinkNtcspecific
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.InductionCoilNtcspecifics);
                    });
            
			
                Field<InductionCoilSripcsafetyGraphType, InductionCoilSripcsafety>("InductionCoilSripcsafetys")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilSripcsafetyGraphType>(
                            "{ Name = EntityName "InductionCoilConfig"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionCoilConfig"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionCoilConfigId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "CoilLoadId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "HeatsinkNtcgiid"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionCoilHeatsinkNtcspecificId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "InductionCoilSpecificId"
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
                     IsNullable = true }; ForeignKey { Type = Byte
                                                       Name = "CoilNtcgiid"
                                                       IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "Acntcgiid"
                      IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "HeatsinkFanLoadId"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "CoilNtcspecificId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "AcntcspecificId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilSripcsafetyId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "InductionCoilPowerTableConfigId"
                      IsNullable = true };
         ForeignKey { Type = Byte
                      Name = "IgbtTemperatureGiid"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionInverterSpecificDataId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "IgbtSafetyParamsId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionCoilSafetyParamsId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "Acntcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "CoilNtcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilSripcsafety"
                      Name = "CoilSripcsafety"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionCoilSafetyParam"
                      Name = "EmptyPotDetectionCoilSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "IgbtSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "InductionCoilHeatsinkNtcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilPowerTableConfiguration"
                      Name = "InductionCoilPowerTableConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilSpecific"
                      Name = "InductionCoilSpecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionInverterSpecificDatum"
                      Name = "InductionInverterSpecificData"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionIpcdetailsInductionCoilConfig"
                      Name = "InductionIpcdetailsInductionCoilConfigs"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "InductionCoilConfigId"
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
         [RelationName "Acntcspecific"; RelationName "CoilNtcspecific";
          RelationName "IgbtSafetyParams";
          RelationName "InductionCoilHeatsinkNtcspecific"]
        TargetTable =
         { Name = TableName "InductionCoilNtcspecific"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilNtcspecificId"
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
                         Name = "StuckExecutionTime"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StuckValidationTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SafetyDebounceTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ShortDebounceTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "OpenDebounceTime"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "ShortThresholdMax"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "OpenThresholdMin"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckWindowMin"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckWindowMax"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckExitDelta"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "SafetyThreshold"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "SafetyHysteresis"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "StuckExitDeltaCelsius"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SafetyHysteresisCelsius"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigAcntcspecifics"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigCoilNtcspecifics"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigIgbtSafetyParams"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "InductionCoilConfig"
                 Name = "InductionCoilConfigInductionCoilHeatsinkNtcspecifics"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilNtcspecific"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilSripcsafety"
        TargetTable =
         { Name = TableName "InductionCoilSripcsafety"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilSripcsafetyId"
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
                         Name = "DualZoneRole"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CoilModelId"
                                                            IsNullable = false };
             Primitive { Type = Float
                         Name = "CoverageAcceptance"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoverageRejection"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "CoverageMove"
                                                           IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilSripcsafety"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionCoilSafetyParam"
        TargetTable =
         { Name = TableName "EmptyPotDetectionCoilSafetyParam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionCoilSafetyParamsId"
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
                         Name = "IsEmptyPotDetectionEnabled"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseGapTempSensorForEmptyPotDetection"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RisingTimeThreshold"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MinLoadPowerAvgDeliveredDuringRisingTime"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxLoadPowerAvgDeliveredDuringRisingTime"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxLoadPowerAvgWhenFixedDerating"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureControlSetpointSlope"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionCoilSafetyParam"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilPowerTableConfiguration"
        TargetTable =
         { Name = TableName "InductionCoilPowerTableConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableConfigId"
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
                         Name = "BoosterLevel"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "InductionCoilChannels"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
                 Name =
                  "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilPowerTableConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilSpecific"
        TargetTable =
         { Name = TableName "InductionCoilSpecific"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilSpecificId"
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
             Primitive { Type = Short
                         Name = "ResonanceCapacitance"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "MaxCurrentNormal"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "MaxCurrentBooster"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "BoosterPowerThreshold"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "PanettoneElectricThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PanDetectedThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PanNotDetectedThreshold"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxNominalLoadAveragePower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalIgbtPeakTurnOffCurrent"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxNominalLoadAveragePowerBooster"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalIgbtPeakTurnOffCurrentBooster"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalLoadRmsCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalLoadRmsCurrentBooster"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilSpecific"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionInverterSpecificDatum"
        TargetTable =
         { Name = TableName "InductionInverterSpecificDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionInverterSpecificDataId"
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
                         Name = "SnubberCapacitance"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ResonantCapacitance"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "GateDelayOffHighSideIgbt"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "GateDelayOffLowSideIgbt"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalInverterPowerFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalInverterPowerFactorBooster"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionInverterSpecificDatum"
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
        KeyType = Guid }] }-InductionCoilSripcsafety-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionCoilSripcsafetys
                                    .Where(x => x.InductionCoilSripcsafety != null && ids.Contains((Guid)x.InductionCoilSripcsafety))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionCoilSripcsafety!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InductionCoilSripcsafety);
                });
            
			
                Field<EmptyPotDetectionCoilSafetyParamGraphType, EmptyPotDetectionCoilSafetyParam>("EmptyPotDetectionCoilSafetyParams")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, EmptyPotDetectionCoilSafetyParamGraphType>(
                            "{ Name = EntityName "InductionCoilConfig"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionCoilConfig"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionCoilConfigId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "CoilLoadId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "HeatsinkNtcgiid"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionCoilHeatsinkNtcspecificId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "InductionCoilSpecificId"
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
                     IsNullable = true }; ForeignKey { Type = Byte
                                                       Name = "CoilNtcgiid"
                                                       IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "Acntcgiid"
                      IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "HeatsinkFanLoadId"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "CoilNtcspecificId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "AcntcspecificId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilSripcsafetyId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "InductionCoilPowerTableConfigId"
                      IsNullable = true };
         ForeignKey { Type = Byte
                      Name = "IgbtTemperatureGiid"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionInverterSpecificDataId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "IgbtSafetyParamsId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionCoilSafetyParamsId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "Acntcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "CoilNtcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilSripcsafety"
                      Name = "CoilSripcsafety"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionCoilSafetyParam"
                      Name = "EmptyPotDetectionCoilSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "IgbtSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "InductionCoilHeatsinkNtcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilPowerTableConfiguration"
                      Name = "InductionCoilPowerTableConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilSpecific"
                      Name = "InductionCoilSpecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionInverterSpecificDatum"
                      Name = "InductionInverterSpecificData"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionIpcdetailsInductionCoilConfig"
                      Name = "InductionIpcdetailsInductionCoilConfigs"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "InductionCoilConfigId"
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
         [RelationName "Acntcspecific"; RelationName "CoilNtcspecific";
          RelationName "IgbtSafetyParams";
          RelationName "InductionCoilHeatsinkNtcspecific"]
        TargetTable =
         { Name = TableName "InductionCoilNtcspecific"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilNtcspecificId"
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
                         Name = "StuckExecutionTime"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StuckValidationTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SafetyDebounceTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ShortDebounceTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "OpenDebounceTime"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "ShortThresholdMax"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "OpenThresholdMin"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckWindowMin"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckWindowMax"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckExitDelta"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "SafetyThreshold"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "SafetyHysteresis"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "StuckExitDeltaCelsius"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SafetyHysteresisCelsius"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigAcntcspecifics"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigCoilNtcspecifics"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigIgbtSafetyParams"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "InductionCoilConfig"
                 Name = "InductionCoilConfigInductionCoilHeatsinkNtcspecifics"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilNtcspecific"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilSripcsafety"
        TargetTable =
         { Name = TableName "InductionCoilSripcsafety"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilSripcsafetyId"
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
                         Name = "DualZoneRole"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CoilModelId"
                                                            IsNullable = false };
             Primitive { Type = Float
                         Name = "CoverageAcceptance"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoverageRejection"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "CoverageMove"
                                                           IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilSripcsafety"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionCoilSafetyParam"
        TargetTable =
         { Name = TableName "EmptyPotDetectionCoilSafetyParam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionCoilSafetyParamsId"
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
                         Name = "IsEmptyPotDetectionEnabled"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseGapTempSensorForEmptyPotDetection"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RisingTimeThreshold"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MinLoadPowerAvgDeliveredDuringRisingTime"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxLoadPowerAvgDeliveredDuringRisingTime"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxLoadPowerAvgWhenFixedDerating"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureControlSetpointSlope"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionCoilSafetyParam"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilPowerTableConfiguration"
        TargetTable =
         { Name = TableName "InductionCoilPowerTableConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableConfigId"
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
                         Name = "BoosterLevel"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "InductionCoilChannels"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
                 Name =
                  "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilPowerTableConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilSpecific"
        TargetTable =
         { Name = TableName "InductionCoilSpecific"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilSpecificId"
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
             Primitive { Type = Short
                         Name = "ResonanceCapacitance"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "MaxCurrentNormal"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "MaxCurrentBooster"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "BoosterPowerThreshold"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "PanettoneElectricThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PanDetectedThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PanNotDetectedThreshold"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxNominalLoadAveragePower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalIgbtPeakTurnOffCurrent"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxNominalLoadAveragePowerBooster"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalIgbtPeakTurnOffCurrentBooster"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalLoadRmsCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalLoadRmsCurrentBooster"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilSpecific"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionInverterSpecificDatum"
        TargetTable =
         { Name = TableName "InductionInverterSpecificDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionInverterSpecificDataId"
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
                         Name = "SnubberCapacitance"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ResonantCapacitance"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "GateDelayOffHighSideIgbt"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "GateDelayOffLowSideIgbt"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalInverterPowerFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalInverterPowerFactorBooster"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionInverterSpecificDatum"
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
        KeyType = Guid }] }-EmptyPotDetectionCoilSafetyParam-loader",
                            async ids => 
                            {
                                var data = await dbContext.EmptyPotDetectionCoilSafetyParams
                                    .Where(x => x.EmptyPotDetectionCoilSafetyParam != null && ids.Contains((Guid)x.EmptyPotDetectionCoilSafetyParam))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.EmptyPotDetectionCoilSafetyParam!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.EmptyPotDetectionCoilSafetyParam);
                });
            
			
                Field<InductionCoilPowerTableConfigurationGraphType, InductionCoilPowerTableConfiguration>("InductionCoilPowerTableConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilPowerTableConfigurationGraphType>(
                            "{ Name = EntityName "InductionCoilConfig"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionCoilConfig"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionCoilConfigId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "CoilLoadId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "HeatsinkNtcgiid"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionCoilHeatsinkNtcspecificId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "InductionCoilSpecificId"
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
                     IsNullable = true }; ForeignKey { Type = Byte
                                                       Name = "CoilNtcgiid"
                                                       IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "Acntcgiid"
                      IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "HeatsinkFanLoadId"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "CoilNtcspecificId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "AcntcspecificId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilSripcsafetyId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "InductionCoilPowerTableConfigId"
                      IsNullable = true };
         ForeignKey { Type = Byte
                      Name = "IgbtTemperatureGiid"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionInverterSpecificDataId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "IgbtSafetyParamsId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionCoilSafetyParamsId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "Acntcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "CoilNtcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilSripcsafety"
                      Name = "CoilSripcsafety"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionCoilSafetyParam"
                      Name = "EmptyPotDetectionCoilSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "IgbtSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "InductionCoilHeatsinkNtcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilPowerTableConfiguration"
                      Name = "InductionCoilPowerTableConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilSpecific"
                      Name = "InductionCoilSpecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionInverterSpecificDatum"
                      Name = "InductionInverterSpecificData"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionIpcdetailsInductionCoilConfig"
                      Name = "InductionIpcdetailsInductionCoilConfigs"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "InductionCoilConfigId"
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
         [RelationName "Acntcspecific"; RelationName "CoilNtcspecific";
          RelationName "IgbtSafetyParams";
          RelationName "InductionCoilHeatsinkNtcspecific"]
        TargetTable =
         { Name = TableName "InductionCoilNtcspecific"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilNtcspecificId"
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
                         Name = "StuckExecutionTime"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StuckValidationTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SafetyDebounceTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ShortDebounceTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "OpenDebounceTime"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "ShortThresholdMax"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "OpenThresholdMin"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckWindowMin"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckWindowMax"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckExitDelta"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "SafetyThreshold"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "SafetyHysteresis"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "StuckExitDeltaCelsius"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SafetyHysteresisCelsius"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigAcntcspecifics"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigCoilNtcspecifics"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigIgbtSafetyParams"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "InductionCoilConfig"
                 Name = "InductionCoilConfigInductionCoilHeatsinkNtcspecifics"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilNtcspecific"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilSripcsafety"
        TargetTable =
         { Name = TableName "InductionCoilSripcsafety"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilSripcsafetyId"
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
                         Name = "DualZoneRole"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CoilModelId"
                                                            IsNullable = false };
             Primitive { Type = Float
                         Name = "CoverageAcceptance"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoverageRejection"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "CoverageMove"
                                                           IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilSripcsafety"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionCoilSafetyParam"
        TargetTable =
         { Name = TableName "EmptyPotDetectionCoilSafetyParam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionCoilSafetyParamsId"
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
                         Name = "IsEmptyPotDetectionEnabled"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseGapTempSensorForEmptyPotDetection"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RisingTimeThreshold"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MinLoadPowerAvgDeliveredDuringRisingTime"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxLoadPowerAvgDeliveredDuringRisingTime"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxLoadPowerAvgWhenFixedDerating"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureControlSetpointSlope"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionCoilSafetyParam"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilPowerTableConfiguration"
        TargetTable =
         { Name = TableName "InductionCoilPowerTableConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableConfigId"
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
                         Name = "BoosterLevel"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "InductionCoilChannels"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
                 Name =
                  "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilPowerTableConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilSpecific"
        TargetTable =
         { Name = TableName "InductionCoilSpecific"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilSpecificId"
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
             Primitive { Type = Short
                         Name = "ResonanceCapacitance"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "MaxCurrentNormal"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "MaxCurrentBooster"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "BoosterPowerThreshold"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "PanettoneElectricThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PanDetectedThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PanNotDetectedThreshold"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxNominalLoadAveragePower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalIgbtPeakTurnOffCurrent"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxNominalLoadAveragePowerBooster"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalIgbtPeakTurnOffCurrentBooster"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalLoadRmsCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalLoadRmsCurrentBooster"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilSpecific"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionInverterSpecificDatum"
        TargetTable =
         { Name = TableName "InductionInverterSpecificDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionInverterSpecificDataId"
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
                         Name = "SnubberCapacitance"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ResonantCapacitance"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "GateDelayOffHighSideIgbt"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "GateDelayOffLowSideIgbt"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalInverterPowerFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalInverterPowerFactorBooster"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionInverterSpecificDatum"
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
        KeyType = Guid }] }-InductionCoilPowerTableConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionCoilPowerTableConfigurations
                                    .Where(x => x.InductionCoilPowerTableConfiguration != null && ids.Contains((Guid)x.InductionCoilPowerTableConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionCoilPowerTableConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InductionCoilPowerTableConfiguration);
                });
            
			
                Field<InductionCoilSpecificGraphType, InductionCoilSpecific>("InductionCoilSpecifics")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilSpecificGraphType>(
                            "{ Name = EntityName "InductionCoilConfig"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionCoilConfig"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionCoilConfigId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "CoilLoadId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "HeatsinkNtcgiid"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionCoilHeatsinkNtcspecificId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "InductionCoilSpecificId"
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
                     IsNullable = true }; ForeignKey { Type = Byte
                                                       Name = "CoilNtcgiid"
                                                       IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "Acntcgiid"
                      IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "HeatsinkFanLoadId"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "CoilNtcspecificId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "AcntcspecificId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilSripcsafetyId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "InductionCoilPowerTableConfigId"
                      IsNullable = true };
         ForeignKey { Type = Byte
                      Name = "IgbtTemperatureGiid"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionInverterSpecificDataId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "IgbtSafetyParamsId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionCoilSafetyParamsId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "Acntcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "CoilNtcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilSripcsafety"
                      Name = "CoilSripcsafety"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionCoilSafetyParam"
                      Name = "EmptyPotDetectionCoilSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "IgbtSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "InductionCoilHeatsinkNtcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilPowerTableConfiguration"
                      Name = "InductionCoilPowerTableConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilSpecific"
                      Name = "InductionCoilSpecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionInverterSpecificDatum"
                      Name = "InductionInverterSpecificData"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionIpcdetailsInductionCoilConfig"
                      Name = "InductionIpcdetailsInductionCoilConfigs"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "InductionCoilConfigId"
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
         [RelationName "Acntcspecific"; RelationName "CoilNtcspecific";
          RelationName "IgbtSafetyParams";
          RelationName "InductionCoilHeatsinkNtcspecific"]
        TargetTable =
         { Name = TableName "InductionCoilNtcspecific"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilNtcspecificId"
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
                         Name = "StuckExecutionTime"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StuckValidationTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SafetyDebounceTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ShortDebounceTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "OpenDebounceTime"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "ShortThresholdMax"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "OpenThresholdMin"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckWindowMin"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckWindowMax"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckExitDelta"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "SafetyThreshold"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "SafetyHysteresis"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "StuckExitDeltaCelsius"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SafetyHysteresisCelsius"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigAcntcspecifics"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigCoilNtcspecifics"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigIgbtSafetyParams"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "InductionCoilConfig"
                 Name = "InductionCoilConfigInductionCoilHeatsinkNtcspecifics"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilNtcspecific"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilSripcsafety"
        TargetTable =
         { Name = TableName "InductionCoilSripcsafety"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilSripcsafetyId"
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
                         Name = "DualZoneRole"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CoilModelId"
                                                            IsNullable = false };
             Primitive { Type = Float
                         Name = "CoverageAcceptance"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoverageRejection"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "CoverageMove"
                                                           IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilSripcsafety"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionCoilSafetyParam"
        TargetTable =
         { Name = TableName "EmptyPotDetectionCoilSafetyParam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionCoilSafetyParamsId"
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
                         Name = "IsEmptyPotDetectionEnabled"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseGapTempSensorForEmptyPotDetection"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RisingTimeThreshold"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MinLoadPowerAvgDeliveredDuringRisingTime"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxLoadPowerAvgDeliveredDuringRisingTime"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxLoadPowerAvgWhenFixedDerating"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureControlSetpointSlope"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionCoilSafetyParam"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilPowerTableConfiguration"
        TargetTable =
         { Name = TableName "InductionCoilPowerTableConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableConfigId"
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
                         Name = "BoosterLevel"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "InductionCoilChannels"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
                 Name =
                  "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilPowerTableConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilSpecific"
        TargetTable =
         { Name = TableName "InductionCoilSpecific"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilSpecificId"
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
             Primitive { Type = Short
                         Name = "ResonanceCapacitance"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "MaxCurrentNormal"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "MaxCurrentBooster"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "BoosterPowerThreshold"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "PanettoneElectricThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PanDetectedThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PanNotDetectedThreshold"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxNominalLoadAveragePower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalIgbtPeakTurnOffCurrent"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxNominalLoadAveragePowerBooster"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalIgbtPeakTurnOffCurrentBooster"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalLoadRmsCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalLoadRmsCurrentBooster"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilSpecific"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionInverterSpecificDatum"
        TargetTable =
         { Name = TableName "InductionInverterSpecificDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionInverterSpecificDataId"
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
                         Name = "SnubberCapacitance"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ResonantCapacitance"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "GateDelayOffHighSideIgbt"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "GateDelayOffLowSideIgbt"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalInverterPowerFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalInverterPowerFactorBooster"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionInverterSpecificDatum"
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
        KeyType = Guid }] }-InductionCoilSpecific-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionCoilSpecifics
                                    .Where(x => x.InductionCoilSpecific != null && ids.Contains((Guid)x.InductionCoilSpecific))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionCoilSpecific!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InductionCoilSpecific);
                });
            
			
                Field<InductionInverterSpecificDatumGraphType, InductionInverterSpecificDatum>("InductionInverterSpecificDatums")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionInverterSpecificDatumGraphType>(
                            "{ Name = EntityName "InductionCoilConfig"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionCoilConfig"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionCoilConfigId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "CoilLoadId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "HeatsinkNtcgiid"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionCoilHeatsinkNtcspecificId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "InductionCoilSpecificId"
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
                     IsNullable = true }; ForeignKey { Type = Byte
                                                       Name = "CoilNtcgiid"
                                                       IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "Acntcgiid"
                      IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "HeatsinkFanLoadId"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "CoilNtcspecificId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "AcntcspecificId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilSripcsafetyId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "InductionCoilPowerTableConfigId"
                      IsNullable = true };
         ForeignKey { Type = Byte
                      Name = "IgbtTemperatureGiid"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionInverterSpecificDataId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "IgbtSafetyParamsId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionCoilSafetyParamsId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "Acntcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "CoilNtcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilSripcsafety"
                      Name = "CoilSripcsafety"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionCoilSafetyParam"
                      Name = "EmptyPotDetectionCoilSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "IgbtSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "InductionCoilHeatsinkNtcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilPowerTableConfiguration"
                      Name = "InductionCoilPowerTableConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilSpecific"
                      Name = "InductionCoilSpecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionInverterSpecificDatum"
                      Name = "InductionInverterSpecificData"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionIpcdetailsInductionCoilConfig"
                      Name = "InductionIpcdetailsInductionCoilConfigs"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "InductionCoilConfigId"
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
         [RelationName "Acntcspecific"; RelationName "CoilNtcspecific";
          RelationName "IgbtSafetyParams";
          RelationName "InductionCoilHeatsinkNtcspecific"]
        TargetTable =
         { Name = TableName "InductionCoilNtcspecific"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilNtcspecificId"
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
                         Name = "StuckExecutionTime"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StuckValidationTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SafetyDebounceTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ShortDebounceTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "OpenDebounceTime"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "ShortThresholdMax"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "OpenThresholdMin"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckWindowMin"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckWindowMax"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckExitDelta"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "SafetyThreshold"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "SafetyHysteresis"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "StuckExitDeltaCelsius"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SafetyHysteresisCelsius"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigAcntcspecifics"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigCoilNtcspecifics"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigIgbtSafetyParams"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "InductionCoilConfig"
                 Name = "InductionCoilConfigInductionCoilHeatsinkNtcspecifics"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilNtcspecific"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilSripcsafety"
        TargetTable =
         { Name = TableName "InductionCoilSripcsafety"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilSripcsafetyId"
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
                         Name = "DualZoneRole"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CoilModelId"
                                                            IsNullable = false };
             Primitive { Type = Float
                         Name = "CoverageAcceptance"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoverageRejection"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "CoverageMove"
                                                           IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilSripcsafety"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionCoilSafetyParam"
        TargetTable =
         { Name = TableName "EmptyPotDetectionCoilSafetyParam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionCoilSafetyParamsId"
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
                         Name = "IsEmptyPotDetectionEnabled"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseGapTempSensorForEmptyPotDetection"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RisingTimeThreshold"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MinLoadPowerAvgDeliveredDuringRisingTime"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxLoadPowerAvgDeliveredDuringRisingTime"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxLoadPowerAvgWhenFixedDerating"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureControlSetpointSlope"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionCoilSafetyParam"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilPowerTableConfiguration"
        TargetTable =
         { Name = TableName "InductionCoilPowerTableConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableConfigId"
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
                         Name = "BoosterLevel"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "InductionCoilChannels"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
                 Name =
                  "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilPowerTableConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilSpecific"
        TargetTable =
         { Name = TableName "InductionCoilSpecific"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilSpecificId"
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
             Primitive { Type = Short
                         Name = "ResonanceCapacitance"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "MaxCurrentNormal"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "MaxCurrentBooster"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "BoosterPowerThreshold"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "PanettoneElectricThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PanDetectedThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PanNotDetectedThreshold"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxNominalLoadAveragePower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalIgbtPeakTurnOffCurrent"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxNominalLoadAveragePowerBooster"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalIgbtPeakTurnOffCurrentBooster"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalLoadRmsCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalLoadRmsCurrentBooster"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilSpecific"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionInverterSpecificDatum"
        TargetTable =
         { Name = TableName "InductionInverterSpecificDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionInverterSpecificDataId"
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
                         Name = "SnubberCapacitance"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ResonantCapacitance"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "GateDelayOffHighSideIgbt"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "GateDelayOffLowSideIgbt"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalInverterPowerFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalInverterPowerFactorBooster"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionInverterSpecificDatum"
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
        KeyType = Guid }] }-InductionInverterSpecificDatum-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionInverterSpecificDatums
                                    .Where(x => x.InductionInverterSpecificDatum != null && ids.Contains((Guid)x.InductionInverterSpecificDatum))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionInverterSpecificDatum!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InductionInverterSpecificDatum);
                });
            
			
                Field<InductionIpcdetailsInductionCoilConfigGraphType, InductionIpcdetailsInductionCoilConfig>("InductionIpcdetailsInductionCoilConfigs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionIpcdetailsInductionCoilConfigGraphType>>(
                            "{ Name = EntityName "InductionCoilConfig"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionCoilConfig"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionCoilConfigId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "CoilLoadId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "HeatsinkNtcgiid"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionCoilHeatsinkNtcspecificId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "InductionCoilSpecificId"
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
                     IsNullable = true }; ForeignKey { Type = Byte
                                                       Name = "CoilNtcgiid"
                                                       IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "Acntcgiid"
                      IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "HeatsinkFanLoadId"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "CoilNtcspecificId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "AcntcspecificId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilSripcsafetyId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "InductionCoilPowerTableConfigId"
                      IsNullable = true };
         ForeignKey { Type = Byte
                      Name = "IgbtTemperatureGiid"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "InductionInverterSpecificDataId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "IgbtSafetyParamsId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "EmptyPotDetectionCoilSafetyParamsId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "Acntcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "CoilNtcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilSripcsafety"
                      Name = "CoilSripcsafety"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "EmptyPotDetectionCoilSafetyParam"
                      Name = "EmptyPotDetectionCoilSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "IgbtSafetyParams"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilNtcspecific"
                      Name = "InductionCoilHeatsinkNtcspecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilPowerTableConfiguration"
                      Name = "InductionCoilPowerTableConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilSpecific"
                      Name = "InductionCoilSpecific"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionInverterSpecificDatum"
                      Name = "InductionInverterSpecificData"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionIpcdetailsInductionCoilConfig"
                      Name = "InductionIpcdetailsInductionCoilConfigs"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "InductionCoilConfigId"
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
         [RelationName "Acntcspecific"; RelationName "CoilNtcspecific";
          RelationName "IgbtSafetyParams";
          RelationName "InductionCoilHeatsinkNtcspecific"]
        TargetTable =
         { Name = TableName "InductionCoilNtcspecific"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilNtcspecificId"
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
                         Name = "StuckExecutionTime"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StuckValidationTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SafetyDebounceTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ShortDebounceTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "OpenDebounceTime"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "ShortThresholdMax"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "OpenThresholdMin"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckWindowMin"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckWindowMax"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "StuckExitDelta"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "SafetyThreshold"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "SafetyHysteresis"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "StuckExitDeltaCelsius"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "SafetyHysteresisCelsius"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigAcntcspecifics"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigCoilNtcspecifics"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigIgbtSafetyParams"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "InductionCoilConfig"
                 Name = "InductionCoilConfigInductionCoilHeatsinkNtcspecifics"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilNtcspecific"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilSripcsafety"
        TargetTable =
         { Name = TableName "InductionCoilSripcsafety"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilSripcsafetyId"
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
                         Name = "DualZoneRole"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CoilModelId"
                                                            IsNullable = false };
             Primitive { Type = Float
                         Name = "CoverageAcceptance"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoverageRejection"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "CoverageMove"
                                                           IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilSripcsafety"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "EmptyPotDetectionCoilSafetyParam"
        TargetTable =
         { Name = TableName "EmptyPotDetectionCoilSafetyParam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "EmptyPotDetectionCoilSafetyParamsId"
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
                         Name = "IsEmptyPotDetectionEnabled"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseGapTempSensorForEmptyPotDetection"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "RisingTimeThreshold"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MinLoadPowerAvgDeliveredDuringRisingTime"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxLoadPowerAvgDeliveredDuringRisingTime"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxLoadPowerAvgWhenFixedDerating"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureControlSetpointSlope"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "EmptyPotDetectionCoilSafetyParam"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilPowerTableConfiguration"
        TargetTable =
         { Name = TableName "InductionCoilPowerTableConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableConfigId"
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
                         Name = "BoosterLevel"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "InductionCoilChannels"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
                 Name =
                  "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilPowerTableConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilSpecific"
        TargetTable =
         { Name = TableName "InductionCoilSpecific"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilSpecificId"
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
             Primitive { Type = Short
                         Name = "ResonanceCapacitance"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "MaxCurrentNormal"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "MaxCurrentBooster"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "BoosterPowerThreshold"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "PanettoneElectricThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PanDetectedThreshold"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "PanNotDetectedThreshold"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxNominalLoadAveragePower"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalIgbtPeakTurnOffCurrent"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "MaxNominalLoadAveragePowerBooster"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalIgbtPeakTurnOffCurrentBooster"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalLoadRmsCurrent"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalLoadRmsCurrentBooster"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilSpecific"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionInverterSpecificDatum"
        TargetTable =
         { Name = TableName "InductionInverterSpecificDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionInverterSpecificDataId"
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
                         Name = "SnubberCapacitance"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ResonantCapacitance"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "GateDelayOffHighSideIgbt"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "GateDelayOffLowSideIgbt"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalInverterPowerFactor"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxNominalInverterPowerFactorBooster"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionInverterSpecificDatum"
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
            
        }
    }
}
            