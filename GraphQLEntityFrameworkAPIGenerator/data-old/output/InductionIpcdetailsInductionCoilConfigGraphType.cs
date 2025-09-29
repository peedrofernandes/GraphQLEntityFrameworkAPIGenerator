
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
    public partial class InductionIpcdetailsInductionCoilConfigGraphType : ObjectGraphType<InductionIpcdetailsInductionCoilConfig>
    {
        public InductionIpcdetailsInductionCoilConfigGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionIpcid, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.InductionCoilConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<InductionCoilConfigGraphType, InductionCoilConfig>("InductionCoilConfigs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilConfigGraphType>(
                            "{ Name = EntityName "InductionIpcdetailsInductionCoilConfig"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionIpcdetailsInductionCoilConfig"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionIpcid"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "InductionCoilConfigId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "InductionIpcid"
      Type = Id Guid
      IsNullable = false }; { Name = "InductionCoilConfigId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
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
        IsNullable = false
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

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InductionCoilConfig);
                });
            
			
                Field<InductionIpcdetailGraphType, InductionIpcdetail>("InductionIpcdetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionIpcdetailGraphType>(
                            "{ Name = EntityName "InductionIpcdetailsInductionCoilConfig"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionIpcdetailsInductionCoilConfig"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionIpcid"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "InductionCoilConfigId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "InductionIpcid"
      Type = Id Guid
      IsNullable = false }; { Name = "InductionCoilConfigId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
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
        IsNullable = false
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

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InductionIpcdetail);
                });
            
        }
    }
}
            