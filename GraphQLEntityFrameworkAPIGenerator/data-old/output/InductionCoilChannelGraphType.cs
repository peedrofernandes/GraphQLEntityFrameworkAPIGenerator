
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
    public partial class InductionCoilChannelGraphType : ObjectGraphType<InductionCoilChannel>
    {
        public InductionCoilChannelGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CoilChannelId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CoilType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ResonanceCapacity, type: typeof(IdGraphType), nullable: True);
			Field(t => t.ResonantCapacitorPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<InductionCoilPowerTableConfigurationGraphType, InductionCoilPowerTableConfiguration>("InductionCoilPowerTableConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilPowerTableConfigurationGraphType>(
                            "{ Name = EntityName "InductionCoilChannel"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionCoilChannel"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CoilChannelId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "CoilType"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "CoilPowerTableId"
                      IsNullable = true }; ForeignKey { Type = Byte
                                                        Name = "CoilNtcGiid"
                                                        IsNullable = true };
         ForeignKey { Type = Byte
                      Name = "AssistedCookingNtcGiid"
                      IsNullable = true };
         Primitive { Type = Int
                     Name = "ResonanceCapacity"
                     IsNullable = true };
         Primitive { Type = Bool
                     Name = "ResonantCapacitorPresent"
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
         Navigation { Type = TableName "InductionCoilPowerTableConfiguration"
                      Name = "CoilPowerTable"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilType"
                      Name = "CoilTypeNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation
           { Type = TableName "InductionInverterChannelConfiguration"
             Name = "InductionInverterChannelConfigurationCoilChannel0s"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type = TableName "InductionInverterChannelConfiguration"
             Name = "InductionInverterChannelConfigurationCoilChannel1s"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "CoilChannelId"
      Type = Id Guid
      IsNullable = false }; { Name = "CoilType"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ResonanceCapacity"
                                                      Type = Primitive Int
                                                      IsNullable = true };
    { Name = "ResonantCapacitorPresent"
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
                                                      IsNullable = true }]
  Relations =
   [SingleManyToOne
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
      { Name = RelationName "InductionCoilType"
        TargetTable =
         { Name = TableName "InductionCoilType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "CoilTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "CoilTypeDesc"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "InductionCoilChannels"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "InductionInverterChannelConfiguration"
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
            
			
                Field<InductionCoilTypeGraphType, InductionCoilType>("InductionCoilTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, InductionCoilTypeGraphType>(
                            "{ Name = EntityName "InductionCoilChannel"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionCoilChannel"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CoilChannelId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "CoilType"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "CoilPowerTableId"
                      IsNullable = true }; ForeignKey { Type = Byte
                                                        Name = "CoilNtcGiid"
                                                        IsNullable = true };
         ForeignKey { Type = Byte
                      Name = "AssistedCookingNtcGiid"
                      IsNullable = true };
         Primitive { Type = Int
                     Name = "ResonanceCapacity"
                     IsNullable = true };
         Primitive { Type = Bool
                     Name = "ResonantCapacitorPresent"
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
         Navigation { Type = TableName "InductionCoilPowerTableConfiguration"
                      Name = "CoilPowerTable"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilType"
                      Name = "CoilTypeNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation
           { Type = TableName "InductionInverterChannelConfiguration"
             Name = "InductionInverterChannelConfigurationCoilChannel0s"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type = TableName "InductionInverterChannelConfiguration"
             Name = "InductionInverterChannelConfigurationCoilChannel1s"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "CoilChannelId"
      Type = Id Guid
      IsNullable = false }; { Name = "CoilType"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ResonanceCapacity"
                                                      Type = Primitive Int
                                                      IsNullable = true };
    { Name = "ResonantCapacitorPresent"
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
                                                      IsNullable = true }]
  Relations =
   [SingleManyToOne
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
      { Name = RelationName "InductionCoilType"
        TargetTable =
         { Name = TableName "InductionCoilType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "CoilTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "CoilTypeDesc"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "InductionCoilChannels"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "InductionInverterChannelConfiguration"
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
        KeyType = Guid }] }-InductionCoilType-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionCoilTypes
                                    .Where(x => x.InductionCoilType != null && ids.Contains((byte)x.InductionCoilType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.InductionCoilType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InductionCoilType);
                });
            
			
                Field<InductionInverterChannelConfigurationGraphType, InductionInverterChannelConfiguration>("InductionInverterChannelConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionInverterChannelConfigurationGraphType>>(
                            "{ Name = EntityName "InductionCoilChannel"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionCoilChannel"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CoilChannelId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "CoilType"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "CoilPowerTableId"
                      IsNullable = true }; ForeignKey { Type = Byte
                                                        Name = "CoilNtcGiid"
                                                        IsNullable = true };
         ForeignKey { Type = Byte
                      Name = "AssistedCookingNtcGiid"
                      IsNullable = true };
         Primitive { Type = Int
                     Name = "ResonanceCapacity"
                     IsNullable = true };
         Primitive { Type = Bool
                     Name = "ResonantCapacitorPresent"
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
         Navigation { Type = TableName "InductionCoilPowerTableConfiguration"
                      Name = "CoilPowerTable"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilType"
                      Name = "CoilTypeNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation
           { Type = TableName "InductionInverterChannelConfiguration"
             Name = "InductionInverterChannelConfigurationCoilChannel0s"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type = TableName "InductionInverterChannelConfiguration"
             Name = "InductionInverterChannelConfigurationCoilChannel1s"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "CoilChannelId"
      Type = Id Guid
      IsNullable = false }; { Name = "CoilType"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ResonanceCapacity"
                                                      Type = Primitive Int
                                                      IsNullable = true };
    { Name = "ResonantCapacitorPresent"
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
                                                      IsNullable = true }]
  Relations =
   [SingleManyToOne
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
      { Name = RelationName "InductionCoilType"
        TargetTable =
         { Name = TableName "InductionCoilType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "CoilTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "CoilTypeDesc"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "InductionCoilChannels"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionCoilType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "InductionInverterChannelConfiguration"
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
        KeyType = Guid }] }-InductionInverterChannelConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionInverterChannelConfigurations
                                    .Where(x => x.InductionInverterChannelConfiguration != null && ids.Contains((Guid)x.InductionInverterChannelConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionInverterChannelConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.InductionInverterChannelConfigurations);
                    });
            
        }
    }
}
            