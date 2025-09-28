
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
    public partial class MonitorPowerReductionV2detailGraphType : ObjectGraphType<MonitorPowerReductionV2detail>
    {
        public MonitorPowerReductionV2detailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorPowerReductionV2detailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.TemperatureCalculationParametersType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Slope, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Offset, type: typeof(FloatGraphType), nullable: False);
            
                Field<MonitorPowerReductionV2configurationMonitorPowerReductionV2detailGraphType, MonitorPowerReductionV2configurationMonitorPowerReductionV2detail>("MonitorPowerReductionV2configurationMonitorPowerReductionV2details")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorPowerReductionV2configurationMonitorPowerReductionV2detailGraphType>>(
                            "{ Name = EntityName "MonitorPowerReductionV2detail"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorPowerReductionV2detail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorPowerReductionV2detailsId"
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
         ForeignKey { Type = Byte
                      Name = "TemperatureNodeNameId"
                      IsNullable = false };
         ForeignKey
           { Type = Guid
             Name = "MonitorPowerReductionV2estimatedTempConfigurationId"
             IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MonitorPowerReductionV2powerRedConfigurationId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "TemperatureCalculationParametersType"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "Slope"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "Offset"
                     IsNullable = false }; ForeignKey { Type = Float
                                                        Name = "TempSensorId"
                                                        IsNullable = false };
         Navigation
           { Type =
              TableName
                "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
             Name =
              "MonitorPowerReductionV2configurationMonitorPowerReductionV2details"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type =
              TableName "MonitorPowerReductionV2estimatedTempConfiguration"
             Name = "MonitorPowerReductionV2estimatedTempConfiguration"
             IsNullable = true
             IsCollection = false };
         Navigation
           { Type = TableName "MonitorPowerReductionV2powerRedConfiguration"
             Name = "MonitorPowerReductionV2powerRedConfiguration"
             IsNullable = true
             IsCollection = false }] }
  Fields =
   [{ Name = "MonitorPowerReductionV2detailsId"
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
    { Name = "TemperatureCalculationParametersType"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Slope"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "Offset"
                                                      Type = Primitive Float
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
        TargetTable =
         { Name =
            TableName
              "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionV2configurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionV2detailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "MonitorPowerReductionV2configuration"
                 Name = "MonitorPowerReductionV2configuration"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "MonitorPowerReductionV2detail"
                          Name = "MonitorPowerReductionV2details"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MonitorPowerReductionV2estimatedTempConfiguration"
        TargetTable =
         { Name = TableName "MonitorPowerReductionV2estimatedTempConfiguration"
           Properties =
            [PrimaryKey
               { Type = Guid
                 Name = "MonitorPowerReductionV2estimatedTempConfigurationId"
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
             Primitive { Type = Bool
                         Name = "DeltaTempTerm"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "OverTempEstimation"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "CavityTempTermApplies"
                         IsNullable = true };
             Navigation { Type = TableName "MonitorPowerReductionV2detail"
                          Name = "MonitorPowerReductionV2details"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail"
                 Name =
                  "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination =
         EntityName "MonitorPowerReductionV2estimatedTempConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MonitorPowerReductionV2powerRedConfiguration"
        TargetTable =
         { Name = TableName "MonitorPowerReductionV2powerRedConfiguration"
           Properties =
            [PrimaryKey
               { Type = Guid
                 Name = "MonitorPowerReductionV2powerRedConfigurationId"
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
             Navigation { Type = TableName "MonitorPowerReductionV2detail"
                          Name = "MonitorPowerReductionV2details"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail"
                 Name =
                  "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorPowerReductionV2powerRedConfiguration"
        IsNullable = true
        KeyType = Guid }] }-MonitorPowerReductionV2configurationMonitorPowerReductionV2detail-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorPowerReductionV2configurationMonitorPowerReductionV2details
                                    .Where(x => x.MonitorPowerReductionV2configurationMonitorPowerReductionV2detail != null && ids.Contains((Guid)x.MonitorPowerReductionV2configurationMonitorPowerReductionV2detail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorPowerReductionV2configurationMonitorPowerReductionV2detail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.MonitorPowerReductionV2configurationMonitorPowerReductionV2details);
                    });
            
			
                Field<MonitorPowerReductionV2estimatedTempConfigurationGraphType, MonitorPowerReductionV2estimatedTempConfiguration>("MonitorPowerReductionV2estimatedTempConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorPowerReductionV2estimatedTempConfigurationGraphType>(
                            "{ Name = EntityName "MonitorPowerReductionV2detail"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorPowerReductionV2detail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorPowerReductionV2detailsId"
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
         ForeignKey { Type = Byte
                      Name = "TemperatureNodeNameId"
                      IsNullable = false };
         ForeignKey
           { Type = Guid
             Name = "MonitorPowerReductionV2estimatedTempConfigurationId"
             IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MonitorPowerReductionV2powerRedConfigurationId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "TemperatureCalculationParametersType"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "Slope"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "Offset"
                     IsNullable = false }; ForeignKey { Type = Float
                                                        Name = "TempSensorId"
                                                        IsNullable = false };
         Navigation
           { Type =
              TableName
                "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
             Name =
              "MonitorPowerReductionV2configurationMonitorPowerReductionV2details"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type =
              TableName "MonitorPowerReductionV2estimatedTempConfiguration"
             Name = "MonitorPowerReductionV2estimatedTempConfiguration"
             IsNullable = true
             IsCollection = false };
         Navigation
           { Type = TableName "MonitorPowerReductionV2powerRedConfiguration"
             Name = "MonitorPowerReductionV2powerRedConfiguration"
             IsNullable = true
             IsCollection = false }] }
  Fields =
   [{ Name = "MonitorPowerReductionV2detailsId"
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
    { Name = "TemperatureCalculationParametersType"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Slope"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "Offset"
                                                      Type = Primitive Float
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
        TargetTable =
         { Name =
            TableName
              "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionV2configurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionV2detailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "MonitorPowerReductionV2configuration"
                 Name = "MonitorPowerReductionV2configuration"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "MonitorPowerReductionV2detail"
                          Name = "MonitorPowerReductionV2details"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MonitorPowerReductionV2estimatedTempConfiguration"
        TargetTable =
         { Name = TableName "MonitorPowerReductionV2estimatedTempConfiguration"
           Properties =
            [PrimaryKey
               { Type = Guid
                 Name = "MonitorPowerReductionV2estimatedTempConfigurationId"
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
             Primitive { Type = Bool
                         Name = "DeltaTempTerm"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "OverTempEstimation"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "CavityTempTermApplies"
                         IsNullable = true };
             Navigation { Type = TableName "MonitorPowerReductionV2detail"
                          Name = "MonitorPowerReductionV2details"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail"
                 Name =
                  "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination =
         EntityName "MonitorPowerReductionV2estimatedTempConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MonitorPowerReductionV2powerRedConfiguration"
        TargetTable =
         { Name = TableName "MonitorPowerReductionV2powerRedConfiguration"
           Properties =
            [PrimaryKey
               { Type = Guid
                 Name = "MonitorPowerReductionV2powerRedConfigurationId"
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
             Navigation { Type = TableName "MonitorPowerReductionV2detail"
                          Name = "MonitorPowerReductionV2details"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail"
                 Name =
                  "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorPowerReductionV2powerRedConfiguration"
        IsNullable = true
        KeyType = Guid }] }-MonitorPowerReductionV2estimatedTempConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorPowerReductionV2estimatedTempConfigurations
                                    .Where(x => x.MonitorPowerReductionV2estimatedTempConfiguration != null && ids.Contains((Guid)x.MonitorPowerReductionV2estimatedTempConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorPowerReductionV2estimatedTempConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.MonitorPowerReductionV2estimatedTempConfiguration);
                });
            
			
                Field<MonitorPowerReductionV2powerRedConfigurationGraphType, MonitorPowerReductionV2powerRedConfiguration>("MonitorPowerReductionV2powerRedConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorPowerReductionV2powerRedConfigurationGraphType>(
                            "{ Name = EntityName "MonitorPowerReductionV2detail"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorPowerReductionV2detail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorPowerReductionV2detailsId"
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
         ForeignKey { Type = Byte
                      Name = "TemperatureNodeNameId"
                      IsNullable = false };
         ForeignKey
           { Type = Guid
             Name = "MonitorPowerReductionV2estimatedTempConfigurationId"
             IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "MonitorPowerReductionV2powerRedConfigurationId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "TemperatureCalculationParametersType"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "Slope"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "Offset"
                     IsNullable = false }; ForeignKey { Type = Float
                                                        Name = "TempSensorId"
                                                        IsNullable = false };
         Navigation
           { Type =
              TableName
                "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
             Name =
              "MonitorPowerReductionV2configurationMonitorPowerReductionV2details"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type =
              TableName "MonitorPowerReductionV2estimatedTempConfiguration"
             Name = "MonitorPowerReductionV2estimatedTempConfiguration"
             IsNullable = true
             IsCollection = false };
         Navigation
           { Type = TableName "MonitorPowerReductionV2powerRedConfiguration"
             Name = "MonitorPowerReductionV2powerRedConfiguration"
             IsNullable = true
             IsCollection = false }] }
  Fields =
   [{ Name = "MonitorPowerReductionV2detailsId"
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
    { Name = "TemperatureCalculationParametersType"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Slope"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "Offset"
                                                      Type = Primitive Float
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
        TargetTable =
         { Name =
            TableName
              "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionV2configurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionV2detailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "MonitorPowerReductionV2configuration"
                 Name = "MonitorPowerReductionV2configuration"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "MonitorPowerReductionV2detail"
                          Name = "MonitorPowerReductionV2details"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MonitorPowerReductionV2estimatedTempConfiguration"
        TargetTable =
         { Name = TableName "MonitorPowerReductionV2estimatedTempConfiguration"
           Properties =
            [PrimaryKey
               { Type = Guid
                 Name = "MonitorPowerReductionV2estimatedTempConfigurationId"
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
             Primitive { Type = Bool
                         Name = "DeltaTempTerm"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "OverTempEstimation"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "CavityTempTermApplies"
                         IsNullable = true };
             Navigation { Type = TableName "MonitorPowerReductionV2detail"
                          Name = "MonitorPowerReductionV2details"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail"
                 Name =
                  "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination =
         EntityName "MonitorPowerReductionV2estimatedTempConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MonitorPowerReductionV2powerRedConfiguration"
        TargetTable =
         { Name = TableName "MonitorPowerReductionV2powerRedConfiguration"
           Properties =
            [PrimaryKey
               { Type = Guid
                 Name = "MonitorPowerReductionV2powerRedConfigurationId"
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
             Navigation { Type = TableName "MonitorPowerReductionV2detail"
                          Name = "MonitorPowerReductionV2details"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail"
                 Name =
                  "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorPowerReductionV2powerRedConfiguration"
        IsNullable = true
        KeyType = Guid }] }-MonitorPowerReductionV2powerRedConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorPowerReductionV2powerRedConfigurations
                                    .Where(x => x.MonitorPowerReductionV2powerRedConfiguration != null && ids.Contains((Guid)x.MonitorPowerReductionV2powerRedConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorPowerReductionV2powerRedConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.MonitorPowerReductionV2powerRedConfiguration);
                });
            
        }
    }
}
            