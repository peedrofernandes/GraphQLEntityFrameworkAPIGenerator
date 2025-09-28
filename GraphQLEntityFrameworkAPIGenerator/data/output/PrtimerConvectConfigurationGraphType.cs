
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
    public partial class PrtimerConvectConfigurationGraphType : ObjectGraphType<PrtimerConvectConfiguration>
    {
        public PrtimerConvectConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerConvectConfigId, type: typeof(GuidGraphType), nullable: False);
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
                            "{ Name = EntityName "PrtimerConvectConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerConvectConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectConfigId"
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
                      Name = "PrtimerConvectTimerLimitConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "PowerReductionTimerConfiguration"
                      Name = "PowerReductionTimerConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
             Name =
              "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                      Name = "PrtimerConvectTimerLimitConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerConvectConfigId"
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
           "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
        TargetTable =
         { Name =
            TableName
              "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerConvectConfiguration"
                          Name = "PrtimerConvectConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "PrtimerConvectUserPhaseNameConfiguration"
                 Name = "PrtimerConvectUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectTimerLimitConfiguration"
        TargetTable =
         { Name = TableName "PrtimerConvectTimerLimitConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerLimitConfigId"
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
             Navigation { Type = TableName "PrtimerConvectConfiguration"
                          Name = "PrtimerConvectConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
                 Name =
                  "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerConvectTimerLimitConfiguration"
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
            
			
                Field<PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurationGraphType, PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration>("PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurationGraphType>>(
                            "{ Name = EntityName "PrtimerConvectConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerConvectConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectConfigId"
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
                      Name = "PrtimerConvectTimerLimitConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "PowerReductionTimerConfiguration"
                      Name = "PowerReductionTimerConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
             Name =
              "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                      Name = "PrtimerConvectTimerLimitConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerConvectConfigId"
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
           "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
        TargetTable =
         { Name =
            TableName
              "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerConvectConfiguration"
                          Name = "PrtimerConvectConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "PrtimerConvectUserPhaseNameConfiguration"
                 Name = "PrtimerConvectUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectTimerLimitConfiguration"
        TargetTable =
         { Name = TableName "PrtimerConvectTimerLimitConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerLimitConfigId"
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
             Navigation { Type = TableName "PrtimerConvectConfiguration"
                          Name = "PrtimerConvectConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
                 Name =
                  "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerConvectTimerLimitConfiguration"
        IsNullable = true
        KeyType = Guid }] }-PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations
                                    .Where(x => x.PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration != null && ids.Contains((Guid)x.PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations);
                    });
            
			
                Field<PrtimerConvectTimerLimitConfigurationGraphType, PrtimerConvectTimerLimitConfiguration>("PrtimerConvectTimerLimitConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerConvectTimerLimitConfigurationGraphType>(
                            "{ Name = EntityName "PrtimerConvectConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerConvectConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectConfigId"
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
                      Name = "PrtimerConvectTimerLimitConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "PowerReductionTimerConfiguration"
                      Name = "PowerReductionTimerConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
             Name =
              "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                      Name = "PrtimerConvectTimerLimitConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerConvectConfigId"
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
           "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
        TargetTable =
         { Name =
            TableName
              "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerConvectConfiguration"
                          Name = "PrtimerConvectConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "PrtimerConvectUserPhaseNameConfiguration"
                 Name = "PrtimerConvectUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectTimerLimitConfiguration"
        TargetTable =
         { Name = TableName "PrtimerConvectTimerLimitConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerLimitConfigId"
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
             Navigation { Type = TableName "PrtimerConvectConfiguration"
                          Name = "PrtimerConvectConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
                 Name =
                  "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerConvectTimerLimitConfiguration"
        IsNullable = true
        KeyType = Guid }] }-PrtimerConvectTimerLimitConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerConvectTimerLimitConfigurations
                                    .Where(x => x.PrtimerConvectTimerLimitConfiguration != null && ids.Contains((Guid)x.PrtimerConvectTimerLimitConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerConvectTimerLimitConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectTimerLimitConfiguration);
                });
            
        }
    }
}
            