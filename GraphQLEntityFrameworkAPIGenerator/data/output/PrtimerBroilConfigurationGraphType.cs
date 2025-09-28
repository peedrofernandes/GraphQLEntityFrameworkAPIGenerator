
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
    public partial class PrtimerBroilConfigurationGraphType : ObjectGraphType<PrtimerBroilConfiguration>
    {
        public PrtimerBroilConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerBroilConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfLevels, type: typeof(ByteGraphType), nullable: False);
            
                Field<PowerReductionTimerConfigurationGraphType, PowerReductionTimerConfiguration>("PowerReductionTimerConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PowerReductionTimerConfigurationGraphType>>(
                            "{ Name = EntityName "PrtimerBroilConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerBroilConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilConfigId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Version"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "Description"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = DateTime
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
                     Name = "NumberOfLevels"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "PrtimerBroilTimerLimitConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "PowerReductionTimerConfiguration"
                      Name = "PowerReductionTimerConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
             Name =
              "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "PrtimerBroilTimerLimitConfiguration"
                      Name = "PrtimerBroilTimerLimitConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerBroilConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NumberOfLevels"
                             Type = Primitive Byte
                             IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "PowerReductionTimerConfiguration"
        TargetTable =
         { Name = TableName "PowerReductionTimerConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PowerReductionTimerConfigId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
             ForeignKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerBroilConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerMagnetronTimerDecrementId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerBroilTimerDecrementId"
                          IsNullable = true }; Primitive { Type = String
                                                           Name = "Compartment"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PrtimerConvectConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerConvectTimerDecrementId"
                          IsNullable = true };
             Navigation { Type = TableName "MonitorPowerReduction"
                          Name = "MonitorPowerReductions"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrtimerBroilConfiguration"
                          Name = "PrtimerBroilConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerBroilTimerDecrement"
                          Name = "PrtimerBroilTimerDecrement"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerConvectConfiguration"
                          Name = "PrtimerConvectConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerConvectTimerDecrement"
                          Name = "PrtimerConvectTimerDecrement"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerMagnetronConfiguration"
                          Name = "PrtimerMagnetronConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerMagnetronTimerDecrement"
                          Name = "PrtimerMagnetronTimerDecrement"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PowerReductionTimerConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
        TargetTable =
         { Name =
            TableName
              "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerBroilConfiguration"
                          Name = "PrtimerBroilConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "PrtimerBroilUserPhaseNameConfiguration"
                 Name = "PrtimerBroilUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilTimerLimitConfiguration"
        TargetTable =
         { Name = TableName "PrtimerBroilTimerLimitConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitConfigId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
                         Name = "NumberOfLevels"
                         IsNullable = false };
             Navigation { Type = TableName "PrtimerBroilConfiguration"
                          Name = "PrtimerBroilConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
                 Name =
                  "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerBroilTimerLimitConfiguration"
        IsNullable = true
        KeyType = Guid }] }-PowerReductionTimerConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PowerReductionTimerConfigurations
                                    .Where(x => x.PowerReductionTimerConfiguration != null && ids.Contains((Guid)x.PowerReductionTimerConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PowerReductionTimerConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PowerReductionTimerConfigurations);
                    });
            
			
                Field<PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurationGraphType, PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration>("PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurationGraphType>>(
                            "{ Name = EntityName "PrtimerBroilConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerBroilConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilConfigId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Version"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "Description"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = DateTime
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
                     Name = "NumberOfLevels"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "PrtimerBroilTimerLimitConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "PowerReductionTimerConfiguration"
                      Name = "PowerReductionTimerConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
             Name =
              "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "PrtimerBroilTimerLimitConfiguration"
                      Name = "PrtimerBroilTimerLimitConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerBroilConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NumberOfLevels"
                             Type = Primitive Byte
                             IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "PowerReductionTimerConfiguration"
        TargetTable =
         { Name = TableName "PowerReductionTimerConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PowerReductionTimerConfigId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
             ForeignKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerBroilConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerMagnetronTimerDecrementId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerBroilTimerDecrementId"
                          IsNullable = true }; Primitive { Type = String
                                                           Name = "Compartment"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PrtimerConvectConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerConvectTimerDecrementId"
                          IsNullable = true };
             Navigation { Type = TableName "MonitorPowerReduction"
                          Name = "MonitorPowerReductions"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrtimerBroilConfiguration"
                          Name = "PrtimerBroilConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerBroilTimerDecrement"
                          Name = "PrtimerBroilTimerDecrement"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerConvectConfiguration"
                          Name = "PrtimerConvectConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerConvectTimerDecrement"
                          Name = "PrtimerConvectTimerDecrement"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerMagnetronConfiguration"
                          Name = "PrtimerMagnetronConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerMagnetronTimerDecrement"
                          Name = "PrtimerMagnetronTimerDecrement"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PowerReductionTimerConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
        TargetTable =
         { Name =
            TableName
              "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerBroilConfiguration"
                          Name = "PrtimerBroilConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "PrtimerBroilUserPhaseNameConfiguration"
                 Name = "PrtimerBroilUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilTimerLimitConfiguration"
        TargetTable =
         { Name = TableName "PrtimerBroilTimerLimitConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitConfigId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
                         Name = "NumberOfLevels"
                         IsNullable = false };
             Navigation { Type = TableName "PrtimerBroilConfiguration"
                          Name = "PrtimerBroilConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
                 Name =
                  "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerBroilTimerLimitConfiguration"
        IsNullable = true
        KeyType = Guid }] }-PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations
                                    .Where(x => x.PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration != null && ids.Contains((Guid)x.PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations);
                    });
            
			
                Field<PrtimerBroilTimerLimitConfigurationGraphType, PrtimerBroilTimerLimitConfiguration>("PrtimerBroilTimerLimitConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerBroilTimerLimitConfigurationGraphType>(
                            "{ Name = EntityName "PrtimerBroilConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerBroilConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilConfigId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Version"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "Description"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = DateTime
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
                     Name = "NumberOfLevels"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "PrtimerBroilTimerLimitConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "PowerReductionTimerConfiguration"
                      Name = "PowerReductionTimerConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
             Name =
              "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "PrtimerBroilTimerLimitConfiguration"
                      Name = "PrtimerBroilTimerLimitConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerBroilConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NumberOfLevels"
                             Type = Primitive Byte
                             IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "PowerReductionTimerConfiguration"
        TargetTable =
         { Name = TableName "PowerReductionTimerConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PowerReductionTimerConfigId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
             ForeignKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerBroilConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerMagnetronTimerDecrementId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerBroilTimerDecrementId"
                          IsNullable = true }; Primitive { Type = String
                                                           Name = "Compartment"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PrtimerConvectConfigId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PrtimerConvectTimerDecrementId"
                          IsNullable = true };
             Navigation { Type = TableName "MonitorPowerReduction"
                          Name = "MonitorPowerReductions"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrtimerBroilConfiguration"
                          Name = "PrtimerBroilConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerBroilTimerDecrement"
                          Name = "PrtimerBroilTimerDecrement"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerConvectConfiguration"
                          Name = "PrtimerConvectConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerConvectTimerDecrement"
                          Name = "PrtimerConvectTimerDecrement"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerMagnetronConfiguration"
                          Name = "PrtimerMagnetronConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerMagnetronTimerDecrement"
                          Name = "PrtimerMagnetronTimerDecrement"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PowerReductionTimerConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
        TargetTable =
         { Name =
            TableName
              "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerBroilConfiguration"
                          Name = "PrtimerBroilConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "PrtimerBroilUserPhaseNameConfiguration"
                 Name = "PrtimerBroilUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilTimerLimitConfiguration"
        TargetTable =
         { Name = TableName "PrtimerBroilTimerLimitConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitConfigId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
                         Name = "NumberOfLevels"
                         IsNullable = false };
             Navigation { Type = TableName "PrtimerBroilConfiguration"
                          Name = "PrtimerBroilConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
                 Name =
                  "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerBroilTimerLimitConfiguration"
        IsNullable = true
        KeyType = Guid }] }-PrtimerBroilTimerLimitConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilTimerLimitConfigurations
                                    .Where(x => x.PrtimerBroilTimerLimitConfiguration != null && ids.Contains((Guid)x.PrtimerBroilTimerLimitConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilTimerLimitConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilTimerLimitConfiguration);
                });
            
        }
    }
}
            