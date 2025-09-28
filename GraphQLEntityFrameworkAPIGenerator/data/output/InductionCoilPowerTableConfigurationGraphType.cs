
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
    public partial class InductionCoilPowerTableConfigurationGraphType : ObjectGraphType<InductionCoilPowerTableConfiguration>
    {
        public InductionCoilPowerTableConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionCoilPowerTableConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.BoosterLevel, type: typeof(ByteGraphType), nullable: False);
            
                Field<InductionCoilChannelGraphType, InductionCoilChannel>("InductionCoilChannels")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilChannelGraphType>>(
                            "{ Name = EntityName "InductionCoilPowerTableConfiguration"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "InductionCoilPowerTableConfigId"
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
    { Name = "BoosterLevel"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "InductionCoilChannel"
        TargetTable =
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
               { Type = TableName "InductionCoilPowerTableConfiguration"
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
        Destination = EntityName "InductionCoilChannel"
        KeyType = Guid };
    OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
        TargetTable =
         { Name =
            TableName
              "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "InductionCoilPowerTableConfiguration"
                 Name = "InductionCoilPowerTableConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "InductionCoilPowerTableDetail"
                          Name = "InductionCoilPowerTableDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
        KeyType = Guid }] }-InductionCoilChannel-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionCoilChannels
                                    .Where(x => x.InductionCoilChannel != null && ids.Contains((Guid)x.InductionCoilChannel))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionCoilChannel!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.InductionCoilChannels);
                    });
            
			
                Field<InductionCoilConfigGraphType, InductionCoilConfig>("InductionCoilConfigs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilConfigGraphType>>(
                            "{ Name = EntityName "InductionCoilPowerTableConfiguration"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "InductionCoilPowerTableConfigId"
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
    { Name = "BoosterLevel"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "InductionCoilChannel"
        TargetTable =
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
               { Type = TableName "InductionCoilPowerTableConfiguration"
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
        Destination = EntityName "InductionCoilChannel"
        KeyType = Guid };
    OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
        TargetTable =
         { Name =
            TableName
              "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "InductionCoilPowerTableConfiguration"
                 Name = "InductionCoilPowerTableConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "InductionCoilPowerTableDetail"
                          Name = "InductionCoilPowerTableDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
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
            
			
                Field<InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetailGraphType, InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail>("InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetailGraphType>>(
                            "{ Name = EntityName "InductionCoilPowerTableConfiguration"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "InductionCoilPowerTableConfigId"
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
    { Name = "BoosterLevel"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "InductionCoilChannel"
        TargetTable =
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
               { Type = TableName "InductionCoilPowerTableConfiguration"
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
        Destination = EntityName "InductionCoilChannel"
        KeyType = Guid };
    OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
        TargetTable =
         { Name =
            TableName
              "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "InductionCoilPowerTableConfiguration"
                 Name = "InductionCoilPowerTableConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "InductionCoilPowerTableDetail"
                          Name = "InductionCoilPowerTableDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
        KeyType = Guid }] }-InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails
                                    .Where(x => x.InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail != null && ids.Contains((Guid)x.InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails);
                    });
            
        }
    }
}
            