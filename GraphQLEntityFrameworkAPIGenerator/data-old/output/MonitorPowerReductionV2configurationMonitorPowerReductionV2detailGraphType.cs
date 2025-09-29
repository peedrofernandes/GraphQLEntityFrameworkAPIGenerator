
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
    public partial class MonitorPowerReductionV2configurationMonitorPowerReductionV2detailGraphType : ObjectGraphType<MonitorPowerReductionV2configurationMonitorPowerReductionV2detail>
    {
        public MonitorPowerReductionV2configurationMonitorPowerReductionV2detailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorPowerReductionV2configurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MonitorPowerReductionV2detailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<MonitorPowerReductionV2configurationGraphType, MonitorPowerReductionV2configuration>("MonitorPowerReductionV2configurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorPowerReductionV2configurationGraphType>(
                            "{ Name =
   EntityName
     "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorPowerReductionV2configurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "MonitorPowerReductionV2detailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "MonitorPowerReductionV2configuration"
                      Name = "MonitorPowerReductionV2configuration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "MonitorPowerReductionV2detail"
                      Name = "MonitorPowerReductionV2details"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "MonitorPowerReductionV2configurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "MonitorPowerReductionV2detailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "MonitorPowerReductionV2configuration"
        TargetTable =
         { Name = TableName "MonitorPowerReductionV2configuration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionV2configurationId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfEstimatedNodes"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Load0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Load1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Load2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Load3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Load4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Load5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Compartment"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfMeasuredNodes"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfOutputLoads"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "OutputLoad0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "OutputLoad1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "OutputLoad2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "OutputLoad3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "OutputLoad4"
                                                           IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "CoolingFanId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "EnableEmptyCrispPanDetection"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseDifferentTempThreshold"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "CrispMaxTime"
                                                           IsNullable = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
                 Name =
                  "MonitorPowerReductionV2configurationMonitorPowerReductionV2details"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorPowerReductionV2configuration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MonitorPowerReductionV2detail"
        TargetTable =
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
                          Name = "TemperatureNodeNameId"
                          IsNullable = false };
             ForeignKey
               { Type = Guid
                 Name = "MonitorPowerReductionV2estimatedTempConfigurationId"
                 IsNullable = true };
             ForeignKey
               { Type = Guid
                 Name = "MonitorPowerReductionV2powerRedConfigurationId"
                 IsNullable = true };
             Primitive { Type = Byte
                         Name = "TemperatureCalculationParametersType"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Slope"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "Offset"
                         IsNullable = false };
             ForeignKey { Type = Float
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
        Destination = EntityName "MonitorPowerReductionV2detail"
        IsNullable = false
        KeyType = Guid }] }-MonitorPowerReductionV2configuration-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorPowerReductionV2configurations
                                    .Where(x => x.MonitorPowerReductionV2configuration != null && ids.Contains((Guid)x.MonitorPowerReductionV2configuration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorPowerReductionV2configuration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.MonitorPowerReductionV2configuration);
                });
            
			
                Field<MonitorPowerReductionV2detailGraphType, MonitorPowerReductionV2detail>("MonitorPowerReductionV2details")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorPowerReductionV2detailGraphType>(
                            "{ Name =
   EntityName
     "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorPowerReductionV2configurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "MonitorPowerReductionV2detailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "MonitorPowerReductionV2configuration"
                      Name = "MonitorPowerReductionV2configuration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "MonitorPowerReductionV2detail"
                      Name = "MonitorPowerReductionV2details"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "MonitorPowerReductionV2configurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "MonitorPowerReductionV2detailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "MonitorPowerReductionV2configuration"
        TargetTable =
         { Name = TableName "MonitorPowerReductionV2configuration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionV2configurationId"
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
                         Name = "NumberOfFanSpeeds"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfEstimatedNodes"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Load0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Load1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Load2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Load3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Load4"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Load5"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Compartment"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfMeasuredNodes"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfOutputLoads"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "OutputLoad0"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "OutputLoad1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "OutputLoad2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "OutputLoad3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "OutputLoad4"
                                                           IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "CoolingFanId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "EnableEmptyCrispPanDetection"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseDifferentTempThreshold"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "CrispMaxTime"
                                                           IsNullable = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "MonitorPowerReductionV2configurationMonitorPowerReductionV2detail"
                 Name =
                  "MonitorPowerReductionV2configurationMonitorPowerReductionV2details"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorPowerReductionV2configuration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MonitorPowerReductionV2detail"
        TargetTable =
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
                          Name = "TemperatureNodeNameId"
                          IsNullable = false };
             ForeignKey
               { Type = Guid
                 Name = "MonitorPowerReductionV2estimatedTempConfigurationId"
                 IsNullable = true };
             ForeignKey
               { Type = Guid
                 Name = "MonitorPowerReductionV2powerRedConfigurationId"
                 IsNullable = true };
             Primitive { Type = Byte
                         Name = "TemperatureCalculationParametersType"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Slope"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "Offset"
                         IsNullable = false };
             ForeignKey { Type = Float
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
        Destination = EntityName "MonitorPowerReductionV2detail"
        IsNullable = false
        KeyType = Guid }] }-MonitorPowerReductionV2detail-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorPowerReductionV2details
                                    .Where(x => x.MonitorPowerReductionV2detail != null && ids.Contains((Guid)x.MonitorPowerReductionV2detail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorPowerReductionV2detail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.MonitorPowerReductionV2detail);
                });
            
        }
    }
}
            