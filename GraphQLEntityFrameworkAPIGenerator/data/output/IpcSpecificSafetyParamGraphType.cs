
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
    public partial class IpcSpecificSafetyParamGraphType : ObjectGraphType<IpcSpecificSafetyParam>
    {
        public IpcSpecificSafetyParamGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.IpcSpecificSafetyParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DeltaTempStartRisingTimeEvaluation, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.DeltaTempEndRisingTimeEvaluation, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TimeMinFixedPowerDeration, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureMonitoringAdditionalOffset, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureMonitoringMaxTemperature, type: typeof(FloatGraphType), nullable: False);
            
                Field<InductionIpcdetailGraphType, InductionIpcdetail>("InductionIpcdetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionIpcdetailGraphType>>(
                            "{ Name = EntityName "IpcSpecificSafetyParam"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "IpcSpecificSafetyParamsId"
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
    { Name = "DeltaTempStartRisingTimeEvaluation"
      Type = Primitive Float
      IsNullable = false }; { Name = "DeltaTempEndRisingTimeEvaluation"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "TimeMinFixedPowerDeration"
      Type = Primitive Float
      IsNullable = false }; { Name = "TemperatureMonitoringAdditionalOffset"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "TemperatureMonitoringMaxTemperature"
      Type = Primitive Float
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "InductionIpcdetail"
        TargetTable =
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
                         Name = "InfinitePotLoss"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "HeatsinkFanLoadIndex"
                         IsNullable = false };
             Primitive { Type = Byte
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
                  TableName
                    "InductionCooktopOrgConfigurationsInductionIpcdetail"
                 Name = "InductionCooktopOrgConfigurationsInductionIpcdetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "InductionIpcSpecificDatum"
                          Name = "InductionIpcSpecificData"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "InductionIpcdetailsInductionCoilConfig"
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
        Destination = EntityName "InductionIpcdetail"
        KeyType = Guid }] }-InductionIpcdetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionIpcdetails
                                    .Where(x => x.InductionIpcdetail != null && ids.Contains((Guid)x.InductionIpcdetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionIpcdetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.InductionIpcdetails);
                    });
            
        }
    }
}
            