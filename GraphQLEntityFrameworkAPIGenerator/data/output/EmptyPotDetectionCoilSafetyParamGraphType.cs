
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
    public partial class EmptyPotDetectionCoilSafetyParamGraphType : ObjectGraphType<EmptyPotDetectionCoilSafetyParam>
    {
        public EmptyPotDetectionCoilSafetyParamGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.EmptyPotDetectionCoilSafetyParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.IsEmptyPotDetectionEnabled, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.UseGapTempSensorForEmptyPotDetection, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.RisingTimeThreshold, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MinLoadPowerAvgDeliveredDuringRisingTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.MaxLoadPowerAvgDeliveredDuringRisingTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.MaxLoadPowerAvgWhenFixedDerating, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TemperatureControlSetpointSlope, type: typeof(FloatGraphType), nullable: False);
            
                Field<InductionCoilConfigGraphType, InductionCoilConfig>("InductionCoilConfigs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilConfigGraphType>>(
                            "{ Name = EntityName "EmptyPotDetectionCoilSafetyParam"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "EmptyPotDetectionCoilSafetyParamsId"
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
    { Name = "IsEmptyPotDetectionEnabled"
      Type = Primitive Bool
      IsNullable = false }; { Name = "UseGapTempSensorForEmptyPotDetection"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "RisingTimeThreshold"
      Type = Primitive Float
      IsNullable = false }; { Name = "MinLoadPowerAvgDeliveredDuringRisingTime"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "MaxLoadPowerAvgDeliveredDuringRisingTime"
      Type = Primitive Int
      IsNullable = false }; { Name = "MaxLoadPowerAvgWhenFixedDerating"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "TemperatureControlSetpointSlope"
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
            