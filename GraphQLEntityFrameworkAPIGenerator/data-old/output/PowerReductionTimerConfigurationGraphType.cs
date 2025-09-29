
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
    public partial class PowerReductionTimerConfigurationGraphType : ObjectGraphType<PowerReductionTimerConfiguration>
    {
        public PowerReductionTimerConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PowerReductionTimerConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Compartment, type: typeof(StringGraphType), nullable: False);
            
                Field<MonitorPowerReductionGraphType, MonitorPowerReduction>("MonitorPowerReductions")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorPowerReductionGraphType>>(
                            "{ Name = EntityName "PowerReductionTimerConfiguration"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "PowerReductionTimerConfigId"
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
      IsNullable = true }; { Name = "Compartment"
                             Type = Primitive String
                             IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "MonitorPowerReduction"
        TargetTable =
         { Name = TableName "MonitorPowerReduction"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionId"
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
                          Name = "PowerReductionTimerConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "MonitorPowerReduction"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilConfiguration"
        TargetTable =
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
        Destination = EntityName "PrtimerBroilConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerBroilTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerBroilTimerDecrement"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectConfiguration"
        TargetTable =
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
             Navigation
               { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                 Name = "PrtimerConvectTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerConvectConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerConvectTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerConvectTimerDecrement"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
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
                          Name = "PrtimerMagnetronTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                 Name = "PrtimerMagnetronTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerMagnetronConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerMagnetronTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronTimerDecrement"
        IsNullable = true
        KeyType = Guid }] }-MonitorPowerReduction-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorPowerReductions
                                    .Where(x => x.MonitorPowerReduction != null && ids.Contains((Guid)x.MonitorPowerReduction))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorPowerReduction!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.MonitorPowerReductions);
                    });
            
			
                Field<PrtimerBroilConfigurationGraphType, PrtimerBroilConfiguration>("PrtimerBroilConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerBroilConfigurationGraphType>(
                            "{ Name = EntityName "PowerReductionTimerConfiguration"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "PowerReductionTimerConfigId"
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
      IsNullable = true }; { Name = "Compartment"
                             Type = Primitive String
                             IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "MonitorPowerReduction"
        TargetTable =
         { Name = TableName "MonitorPowerReduction"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionId"
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
                          Name = "PowerReductionTimerConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "MonitorPowerReduction"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilConfiguration"
        TargetTable =
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
        Destination = EntityName "PrtimerBroilConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerBroilTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerBroilTimerDecrement"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectConfiguration"
        TargetTable =
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
             Navigation
               { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                 Name = "PrtimerConvectTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerConvectConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerConvectTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerConvectTimerDecrement"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
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
                          Name = "PrtimerMagnetronTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                 Name = "PrtimerMagnetronTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerMagnetronConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerMagnetronTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronTimerDecrement"
        IsNullable = true
        KeyType = Guid }] }-PrtimerBroilConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilConfigurations
                                    .Where(x => x.PrtimerBroilConfiguration != null && ids.Contains((Guid)x.PrtimerBroilConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilConfiguration);
                });
            
			
                Field<PrtimerBroilTimerDecrementGraphType, PrtimerBroilTimerDecrement>("PrtimerBroilTimerDecrements")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerBroilTimerDecrementGraphType>(
                            "{ Name = EntityName "PowerReductionTimerConfiguration"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "PowerReductionTimerConfigId"
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
      IsNullable = true }; { Name = "Compartment"
                             Type = Primitive String
                             IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "MonitorPowerReduction"
        TargetTable =
         { Name = TableName "MonitorPowerReduction"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionId"
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
                          Name = "PowerReductionTimerConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "MonitorPowerReduction"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilConfiguration"
        TargetTable =
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
        Destination = EntityName "PrtimerBroilConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerBroilTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerBroilTimerDecrement"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectConfiguration"
        TargetTable =
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
             Navigation
               { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                 Name = "PrtimerConvectTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerConvectConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerConvectTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerConvectTimerDecrement"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
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
                          Name = "PrtimerMagnetronTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                 Name = "PrtimerMagnetronTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerMagnetronConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerMagnetronTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronTimerDecrement"
        IsNullable = true
        KeyType = Guid }] }-PrtimerBroilTimerDecrement-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilTimerDecrements
                                    .Where(x => x.PrtimerBroilTimerDecrement != null && ids.Contains((Guid)x.PrtimerBroilTimerDecrement))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilTimerDecrement!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilTimerDecrement);
                });
            
			
                Field<PrtimerConvectConfigurationGraphType, PrtimerConvectConfiguration>("PrtimerConvectConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerConvectConfigurationGraphType>(
                            "{ Name = EntityName "PowerReductionTimerConfiguration"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "PowerReductionTimerConfigId"
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
      IsNullable = true }; { Name = "Compartment"
                             Type = Primitive String
                             IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "MonitorPowerReduction"
        TargetTable =
         { Name = TableName "MonitorPowerReduction"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionId"
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
                          Name = "PowerReductionTimerConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "MonitorPowerReduction"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilConfiguration"
        TargetTable =
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
        Destination = EntityName "PrtimerBroilConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerBroilTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerBroilTimerDecrement"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectConfiguration"
        TargetTable =
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
             Navigation
               { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                 Name = "PrtimerConvectTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerConvectConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerConvectTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerConvectTimerDecrement"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
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
                          Name = "PrtimerMagnetronTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                 Name = "PrtimerMagnetronTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerMagnetronConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerMagnetronTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronTimerDecrement"
        IsNullable = true
        KeyType = Guid }] }-PrtimerConvectConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerConvectConfigurations
                                    .Where(x => x.PrtimerConvectConfiguration != null && ids.Contains((Guid)x.PrtimerConvectConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerConvectConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectConfiguration);
                });
            
			
                Field<PrtimerConvectTimerDecrementGraphType, PrtimerConvectTimerDecrement>("PrtimerConvectTimerDecrements")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerConvectTimerDecrementGraphType>(
                            "{ Name = EntityName "PowerReductionTimerConfiguration"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "PowerReductionTimerConfigId"
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
      IsNullable = true }; { Name = "Compartment"
                             Type = Primitive String
                             IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "MonitorPowerReduction"
        TargetTable =
         { Name = TableName "MonitorPowerReduction"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionId"
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
                          Name = "PowerReductionTimerConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "MonitorPowerReduction"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilConfiguration"
        TargetTable =
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
        Destination = EntityName "PrtimerBroilConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerBroilTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerBroilTimerDecrement"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectConfiguration"
        TargetTable =
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
             Navigation
               { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                 Name = "PrtimerConvectTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerConvectConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerConvectTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerConvectTimerDecrement"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
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
                          Name = "PrtimerMagnetronTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                 Name = "PrtimerMagnetronTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerMagnetronConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerMagnetronTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronTimerDecrement"
        IsNullable = true
        KeyType = Guid }] }-PrtimerConvectTimerDecrement-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerConvectTimerDecrements
                                    .Where(x => x.PrtimerConvectTimerDecrement != null && ids.Contains((Guid)x.PrtimerConvectTimerDecrement))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerConvectTimerDecrement!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectTimerDecrement);
                });
            
			
                Field<PrtimerMagnetronConfigurationGraphType, PrtimerMagnetronConfiguration>("PrtimerMagnetronConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerMagnetronConfigurationGraphType>(
                            "{ Name = EntityName "PowerReductionTimerConfiguration"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "PowerReductionTimerConfigId"
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
      IsNullable = true }; { Name = "Compartment"
                             Type = Primitive String
                             IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "MonitorPowerReduction"
        TargetTable =
         { Name = TableName "MonitorPowerReduction"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionId"
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
                          Name = "PowerReductionTimerConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "MonitorPowerReduction"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilConfiguration"
        TargetTable =
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
        Destination = EntityName "PrtimerBroilConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerBroilTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerBroilTimerDecrement"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectConfiguration"
        TargetTable =
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
             Navigation
               { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                 Name = "PrtimerConvectTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerConvectConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerConvectTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerConvectTimerDecrement"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
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
                          Name = "PrtimerMagnetronTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                 Name = "PrtimerMagnetronTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerMagnetronConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerMagnetronTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronTimerDecrement"
        IsNullable = true
        KeyType = Guid }] }-PrtimerMagnetronConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerMagnetronConfigurations
                                    .Where(x => x.PrtimerMagnetronConfiguration != null && ids.Contains((Guid)x.PrtimerMagnetronConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerMagnetronConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerMagnetronConfiguration);
                });
            
			
                Field<PrtimerMagnetronTimerDecrementGraphType, PrtimerMagnetronTimerDecrement>("PrtimerMagnetronTimerDecrements")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerMagnetronTimerDecrementGraphType>(
                            "{ Name = EntityName "PowerReductionTimerConfiguration"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "PowerReductionTimerConfigId"
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
      IsNullable = true }; { Name = "Compartment"
                             Type = Primitive String
                             IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "MonitorPowerReduction"
        TargetTable =
         { Name = TableName "MonitorPowerReduction"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionId"
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
                          Name = "PowerReductionTimerConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "MonitorPowerReduction"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilConfiguration"
        TargetTable =
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
        Destination = EntityName "PrtimerBroilConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerBroilTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerBroilTimerDecrement"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectConfiguration"
        TargetTable =
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
             Navigation
               { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                 Name = "PrtimerConvectTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerConvectConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerConvectTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerConvectTimerDecrement"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
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
                          Name = "PrtimerMagnetronTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                 Name = "PrtimerMagnetronTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerMagnetronConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronTimerDecrement"
        TargetTable =
         { Name = TableName "PrtimerMagnetronTimerDecrement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerDecrementId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "FanSpeed5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FanSpeed6"
                                                           IsNullable = false };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronTimerDecrement"
        IsNullable = true
        KeyType = Guid }] }-PrtimerMagnetronTimerDecrement-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerMagnetronTimerDecrements
                                    .Where(x => x.PrtimerMagnetronTimerDecrement != null && ids.Contains((Guid)x.PrtimerMagnetronTimerDecrement))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerMagnetronTimerDecrement!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerMagnetronTimerDecrement);
                });
            
        }
    }
}
            