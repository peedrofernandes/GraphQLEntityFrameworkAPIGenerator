
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
    public partial class IpcControllerCoilConfigurationGraphType : ObjectGraphType<IpcControllerCoilConfiguration>
    {
        public IpcControllerCoilConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.IpcControllerCoilConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<InductionThermalNodeConfigurationGraphType, InductionThermalNodeConfiguration>("InductionThermalNodeConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionThermalNodeConfigurationGraphType>(
                            "{ Name = EntityName "IpcControllerCoilConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerCoilConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilConfigurationsId"
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
                     IsNullable = true }; ForeignKey { Type = Guid
                                                       Name = "IpcFanConfigId"
                                                       IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "HeatsinkThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MicroThermalNodeConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "HeatsinkThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
             Name = "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type =
              TableName
                "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
             Name =
              "IpcControllerIpcConfigurationsIpcControllerCoilConfigurations"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "IpcFanConfigDatum"
                      Name = "IpcFanConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "MicroThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerCoilConfigurationsId"
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
   [MultipleManyToOne
      { Names =
         [RelationName "HeatsinkThermalNodeConfig";
          RelationName "MicroThermalNodeConfig"]
        TargetTable =
         { Name = TableName "InductionThermalNodeConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionThermalNodeConfigId"
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
                         Name = "Version"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "TempThresholdNominalToWarmState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempThresholdWarmToOverheatState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempTresholdHotIndicator"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ThermalDeratingPiControllerTempSetPoint"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKp"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKi"
                         IsNullable = false };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerCoilConfigurationHeatsinkThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name = "IpcControllerCoilConfigurationMicroThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilCenterThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilGapThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetailIgbtThermalNodeConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionThermalNodeConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        TargetTable =
         { Name =
            TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        TargetTable =
         { Name =
            TableName
              "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "IpcFanConfigDatum"
        TargetTable =
         { Name = TableName "IpcFanConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcFanConfigId"
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
                         Name = "Version"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "FanMaximumSpeed"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "FanMinimumSpeed"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FanActivationTempThresholdNotDelivering"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxTempForSpeedLinearInterpolation"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MinTempForSpeedLinearInterpolation"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "IpcFanConfigDatum"
        IsNullable = true
        KeyType = Guid }] }-InductionThermalNodeConfiguration-loader",
                            async ids => 
                            {
                                Expression<Func<InductionThermalNodeConfiguration, bool>> expr = x => !ids.Any()
                                    \|\| (x.HeatsinkThermalNodeConfig != null && ids.Contains((Guid)x.HeatsinkThermalNodeConfig))
\|\| (x.MicroThermalNodeConfig != null && ids.Contains((Guid)x.MicroThermalNodeConfig));

                                var data = await dbContext.InductionThermalNodeConfigurations
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.HeatsinkThermalNodeConfig,
x.MicroThermalNodeConfig
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.InductionThermalNodeConfigurations);
                    });
            
			
                Field<IpcControllerCoilConfigurationsIpcControllerCoilDetailGraphType, IpcControllerCoilConfigurationsIpcControllerCoilDetail>("IpcControllerCoilConfigurationsIpcControllerCoilDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerCoilConfigurationsIpcControllerCoilDetailGraphType>>(
                            "{ Name = EntityName "IpcControllerCoilConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerCoilConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilConfigurationsId"
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
                     IsNullable = true }; ForeignKey { Type = Guid
                                                       Name = "IpcFanConfigId"
                                                       IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "HeatsinkThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MicroThermalNodeConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "HeatsinkThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
             Name = "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type =
              TableName
                "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
             Name =
              "IpcControllerIpcConfigurationsIpcControllerCoilConfigurations"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "IpcFanConfigDatum"
                      Name = "IpcFanConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "MicroThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerCoilConfigurationsId"
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
   [MultipleManyToOne
      { Names =
         [RelationName "HeatsinkThermalNodeConfig";
          RelationName "MicroThermalNodeConfig"]
        TargetTable =
         { Name = TableName "InductionThermalNodeConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionThermalNodeConfigId"
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
                         Name = "Version"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "TempThresholdNominalToWarmState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempThresholdWarmToOverheatState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempTresholdHotIndicator"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ThermalDeratingPiControllerTempSetPoint"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKp"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKi"
                         IsNullable = false };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerCoilConfigurationHeatsinkThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name = "IpcControllerCoilConfigurationMicroThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilCenterThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilGapThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetailIgbtThermalNodeConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionThermalNodeConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        TargetTable =
         { Name =
            TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        TargetTable =
         { Name =
            TableName
              "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "IpcFanConfigDatum"
        TargetTable =
         { Name = TableName "IpcFanConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcFanConfigId"
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
                         Name = "Version"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "FanMaximumSpeed"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "FanMinimumSpeed"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FanActivationTempThresholdNotDelivering"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxTempForSpeedLinearInterpolation"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MinTempForSpeedLinearInterpolation"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "IpcFanConfigDatum"
        IsNullable = true
        KeyType = Guid }] }-IpcControllerCoilConfigurationsIpcControllerCoilDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.IpcControllerCoilConfigurationsIpcControllerCoilDetails
                                    .Where(x => x.IpcControllerCoilConfigurationsIpcControllerCoilDetail != null && ids.Contains((Guid)x.IpcControllerCoilConfigurationsIpcControllerCoilDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.IpcControllerCoilConfigurationsIpcControllerCoilDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.IpcControllerCoilConfigurationsIpcControllerCoilDetails);
                    });
            
			
                Field<IpcControllerIpcConfigurationsIpcControllerCoilConfigurationGraphType, IpcControllerIpcConfigurationsIpcControllerCoilConfiguration>("IpcControllerIpcConfigurationsIpcControllerCoilConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerIpcConfigurationsIpcControllerCoilConfigurationGraphType>>(
                            "{ Name = EntityName "IpcControllerCoilConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerCoilConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilConfigurationsId"
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
                     IsNullable = true }; ForeignKey { Type = Guid
                                                       Name = "IpcFanConfigId"
                                                       IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "HeatsinkThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MicroThermalNodeConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "HeatsinkThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
             Name = "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type =
              TableName
                "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
             Name =
              "IpcControllerIpcConfigurationsIpcControllerCoilConfigurations"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "IpcFanConfigDatum"
                      Name = "IpcFanConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "MicroThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerCoilConfigurationsId"
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
   [MultipleManyToOne
      { Names =
         [RelationName "HeatsinkThermalNodeConfig";
          RelationName "MicroThermalNodeConfig"]
        TargetTable =
         { Name = TableName "InductionThermalNodeConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionThermalNodeConfigId"
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
                         Name = "Version"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "TempThresholdNominalToWarmState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempThresholdWarmToOverheatState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempTresholdHotIndicator"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ThermalDeratingPiControllerTempSetPoint"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKp"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKi"
                         IsNullable = false };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerCoilConfigurationHeatsinkThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name = "IpcControllerCoilConfigurationMicroThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilCenterThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilGapThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetailIgbtThermalNodeConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionThermalNodeConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        TargetTable =
         { Name =
            TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        TargetTable =
         { Name =
            TableName
              "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "IpcFanConfigDatum"
        TargetTable =
         { Name = TableName "IpcFanConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcFanConfigId"
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
                         Name = "Version"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "FanMaximumSpeed"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "FanMinimumSpeed"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FanActivationTempThresholdNotDelivering"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxTempForSpeedLinearInterpolation"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MinTempForSpeedLinearInterpolation"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "IpcFanConfigDatum"
        IsNullable = true
        KeyType = Guid }] }-IpcControllerIpcConfigurationsIpcControllerCoilConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.IpcControllerIpcConfigurationsIpcControllerCoilConfigurations
                                    .Where(x => x.IpcControllerIpcConfigurationsIpcControllerCoilConfiguration != null && ids.Contains((Guid)x.IpcControllerIpcConfigurationsIpcControllerCoilConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.IpcControllerIpcConfigurationsIpcControllerCoilConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.IpcControllerIpcConfigurationsIpcControllerCoilConfigurations);
                    });
            
			
                Field<IpcFanConfigDatumGraphType, IpcFanConfigDatum>("IpcFanConfigDatums")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IpcFanConfigDatumGraphType>(
                            "{ Name = EntityName "IpcControllerCoilConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "IpcControllerCoilConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "IpcControllerCoilConfigurationsId"
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
                     IsNullable = true }; ForeignKey { Type = Guid
                                                       Name = "IpcFanConfigId"
                                                       IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "HeatsinkThermalNodeConfigId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MicroThermalNodeConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "HeatsinkThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
             Name = "IpcControllerCoilConfigurationsIpcControllerCoilDetails"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type =
              TableName
                "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
             Name =
              "IpcControllerIpcConfigurationsIpcControllerCoilConfigurations"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "IpcFanConfigDatum"
                      Name = "IpcFanConfig"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionThermalNodeConfiguration"
                      Name = "MicroThermalNodeConfig"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "IpcControllerCoilConfigurationsId"
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
   [MultipleManyToOne
      { Names =
         [RelationName "HeatsinkThermalNodeConfig";
          RelationName "MicroThermalNodeConfig"]
        TargetTable =
         { Name = TableName "InductionThermalNodeConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionThermalNodeConfigId"
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
                         Name = "Version"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "TempThresholdNominalToWarmState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempThresholdWarmToOverheatState"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempTresholdHotIndicator"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ThermalDeratingPiControllerTempSetPoint"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKp"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "ThermalDeratingPiControllerKi"
                         IsNullable = false };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name =
                  "IpcControllerCoilConfigurationHeatsinkThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilConfiguration"
                 Name = "IpcControllerCoilConfigurationMicroThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilCenterThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "IpcControllerCoilDetail"
                 Name = "IpcControllerCoilDetailCoilGapThermalNodeConfigs"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetailIgbtThermalNodeConfigs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionThermalNodeConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        TargetTable =
         { Name =
            TableName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerCoilDetail"
                          Name = "IpcControllerCoilDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "IpcControllerCoilConfigurationsIpcControllerCoilDetail"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        TargetTable =
         { Name =
            TableName
              "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcControllerIpcConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "IpcControllerCoilConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "IpcControllerIpcConfiguration"
                          Name = "IpcControllerIpcConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "IpcControllerIpcConfigurationsIpcControllerCoilConfiguration"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "IpcFanConfigDatum"
        TargetTable =
         { Name = TableName "IpcFanConfigDatum"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "IpcFanConfigId"
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
                         Name = "Version"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "FanMaximumSpeed"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "FanMinimumSpeed"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FanActivationTempThresholdNotDelivering"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MaxTempForSpeedLinearInterpolation"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "MinTempForSpeedLinearInterpolation"
                         IsNullable = false };
             Navigation { Type = TableName "IpcControllerCoilConfiguration"
                          Name = "IpcControllerCoilConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "IpcFanConfigDatum"
        IsNullable = true
        KeyType = Guid }] }-IpcFanConfigDatum-loader",
                            async ids => 
                            {
                                var data = await dbContext.IpcFanConfigDatums
                                    .Where(x => x.IpcFanConfigDatum != null && ids.Contains((Guid)x.IpcFanConfigDatum))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.IpcFanConfigDatum!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.IpcFanConfigDatum);
                });
            
        }
    }
}
            