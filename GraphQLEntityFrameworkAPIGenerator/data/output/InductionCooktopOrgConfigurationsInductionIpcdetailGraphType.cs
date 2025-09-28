
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
    public partial class InductionCooktopOrgConfigurationsInductionIpcdetailGraphType : ObjectGraphType<InductionCooktopOrgConfigurationsInductionIpcdetail>
    {
        public InductionCooktopOrgConfigurationsInductionIpcdetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CooktopOrgConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.InductionIpcid, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<InductionCooktopOrgConfigurationGraphType, InductionCooktopOrgConfiguration>("InductionCooktopOrgConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCooktopOrgConfigurationGraphType>(
                            "{ Name = EntityName "InductionCooktopOrgConfigurationsInductionIpcdetail"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionCooktopOrgConfigurationsInductionIpcdetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CooktopOrgConfigurationId"
                      IsNullable = false }; PrimaryKey { Type = Guid
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
  Fields =
   [{ Name = "CooktopOrgConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "InductionIpcid"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "InductionCooktopOrgConfiguration"
        TargetTable =
         { Name = TableName "InductionCooktopOrgConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CooktopOrgConfigurationId"
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
             Navigation
               { Type =
                  TableName
                    "InductionCooktopOrgConfigurationsInductionIpcdetail"
                 Name = "InductionCooktopOrgConfigurationsInductionIpcdetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCooktopOrgConfiguration"
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
        KeyType = Guid }] }-InductionCooktopOrgConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionCooktopOrgConfigurations
                                    .Where(x => x.InductionCooktopOrgConfiguration != null && ids.Contains((Guid)x.InductionCooktopOrgConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionCooktopOrgConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InductionCooktopOrgConfiguration);
                });
            
			
                Field<InductionIpcdetailGraphType, InductionIpcdetail>("InductionIpcdetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionIpcdetailGraphType>(
                            "{ Name = EntityName "InductionCooktopOrgConfigurationsInductionIpcdetail"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionCooktopOrgConfigurationsInductionIpcdetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CooktopOrgConfigurationId"
                      IsNullable = false }; PrimaryKey { Type = Guid
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
  Fields =
   [{ Name = "CooktopOrgConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "InductionIpcid"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "InductionCooktopOrgConfiguration"
        TargetTable =
         { Name = TableName "InductionCooktopOrgConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CooktopOrgConfigurationId"
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
             Navigation
               { Type =
                  TableName
                    "InductionCooktopOrgConfigurationsInductionIpcdetail"
                 Name = "InductionCooktopOrgConfigurationsInductionIpcdetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCooktopOrgConfiguration"
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
            