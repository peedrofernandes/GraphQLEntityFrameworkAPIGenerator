
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
    public partial class InductionZeroCrossConfigurationGraphType : ObjectGraphType<InductionZeroCrossConfiguration>
    {
        public InductionZeroCrossConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ZeroCrossConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<InductionIpcdetailGraphType, InductionIpcdetail>("InductionIpcdetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionIpcdetailGraphType>>(
                            "{ Name = EntityName "InductionZeroCrossConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionZeroCrossConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ZeroCrossConfigId"
                      IsNullable = false }; ForeignKey { Type = Byte
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
         Navigation { Type = TableName "InductionInverterChannelConfiguration"
                      Name = "InverterChannel0"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionInverterChannelConfiguration"
                      Name = "InverterChannel1"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "ZeroCrossConfigId"
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
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "InverterChannel0"; RelationName "InverterChannel1"]
        TargetTable =
         { Name = TableName "InductionInverterChannelConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InverterChannelId"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "CoilChannel0Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CoilChannel1Id"
                          IsNullable = true };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "CoilChannel0"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "CoilChannel1"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "InductionZeroCrossConfiguration"
                 Name = "InductionZeroCrossConfigurationInverterChannel0s"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "InductionZeroCrossConfiguration"
                 Name = "InductionZeroCrossConfigurationInverterChannel1s"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionInverterChannelConfiguration"
        IsNullable = true
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
            
			
                Field<InductionInverterChannelConfigurationGraphType, InductionInverterChannelConfiguration>("InductionInverterChannelConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionInverterChannelConfigurationGraphType>(
                            "{ Name = EntityName "InductionZeroCrossConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionZeroCrossConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ZeroCrossConfigId"
                      IsNullable = false }; ForeignKey { Type = Byte
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
         Navigation { Type = TableName "InductionInverterChannelConfiguration"
                      Name = "InverterChannel0"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionInverterChannelConfiguration"
                      Name = "InverterChannel1"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "ZeroCrossConfigId"
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
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "InverterChannel0"; RelationName "InverterChannel1"]
        TargetTable =
         { Name = TableName "InductionInverterChannelConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InverterChannelId"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "CoilChannel0Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CoilChannel1Id"
                          IsNullable = true };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "CoilChannel0"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "CoilChannel1"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "InductionZeroCrossConfiguration"
                 Name = "InductionZeroCrossConfigurationInverterChannel0s"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "InductionZeroCrossConfiguration"
                 Name = "InductionZeroCrossConfigurationInverterChannel1s"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionInverterChannelConfiguration"
        IsNullable = true
        KeyType = Guid }] }-InductionInverterChannelConfiguration-loader",
                            async ids => 
                            {
                                Expression<Func<InductionInverterChannelConfiguration, bool>> expr = x => !ids.Any()
                                    \|\| (x.InverterChannel0 != null && ids.Contains((Guid)x.InverterChannel0))
\|\| (x.InverterChannel1 != null && ids.Contains((Guid)x.InverterChannel1));

                                var data = await dbContext.InductionInverterChannelConfigurations
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.InverterChannel0,
x.InverterChannel1
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.InductionInverterChannelConfigurations);
                    });
            
        }
    }
}
            