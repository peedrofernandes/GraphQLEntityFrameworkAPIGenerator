
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
    public partial class InductionCoilNtcspecificGraphType : ObjectGraphType<InductionCoilNtcspecific>
    {
        public InductionCoilNtcspecificGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionCoilNtcspecificId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.StuckExecutionTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StuckValidationTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SafetyDebounceTime, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ShortDebounceTime, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.OpenDebounceTime, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ShortThresholdMax, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.OpenThresholdMin, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.StuckWindowMin, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.StuckWindowMax, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.StuckExitDelta, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.SafetyThreshold, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.SafetyHysteresis, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.StuckExitDeltaCelsius, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SafetyHysteresisCelsius, type: typeof(FloatGraphType), nullable: False);
            
                Field<InductionCoilConfigGraphType, InductionCoilConfig>("InductionCoilConfigs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilConfigGraphType>>(
                            "{ Name = EntityName "InductionCoilNtcspecific"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "OpenDebounceTime"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "ShortThresholdMax"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "OpenThresholdMin"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "StuckWindowMin"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "StuckWindowMax"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "StuckExitDelta"
                     IsNullable = false }; Primitive { Type = Short
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
  Fields =
   [{ Name = "InductionCoilNtcspecificId"
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
    { Name = "StuckExecutionTime"
      Type = Primitive Byte
      IsNullable = false }; { Name = "StuckValidationTime"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "SafetyDebounceTime"
      Type = Primitive Float
      IsNullable = false }; { Name = "ShortDebounceTime"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "OpenDebounceTime"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "ShortThresholdMax"
      Type = Primitive Short
      IsNullable = false }; { Name = "OpenThresholdMin"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "StuckWindowMin"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "StuckWindowMax"
      Type = Primitive Short
      IsNullable = false }; { Name = "StuckExitDelta"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "SafetyThreshold"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "SafetyHysteresis"
      Type = Primitive Short
      IsNullable = false }; { Name = "StuckExitDeltaCelsius"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "SafetyHysteresisCelsius"
      Type = Primitive Float
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "InductionCoilConfig"
        TargetTable =
         { Name = TableName "InductionCoilConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilConfigId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
             ForeignKey { Type = Byte
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
                          IsNullable = true };
             ForeignKey { Type = Guid
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
             Navigation
               { Type = TableName "InductionCoilPowerTableConfiguration"
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
             Navigation
               { Type = TableName "InductionIpcdetailsInductionCoilConfig"
                 Name = "InductionIpcdetailsInductionCoilConfigs"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilConfig"
        KeyType = Guid }] }-InductionCoilConfig-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionCoilConfigs
                                    .Where(x => x.InductionCoilConfig != null && ids.Contains((Guid)x.InductionCoilConfig))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionCoilConfig!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.InductionCoilConfigs);
                    });
            
        }
    }
}
            