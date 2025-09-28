
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
    public partial class MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetailGraphType : ObjectGraphType<MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail>
    {
        public MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorPowerReductionV2estimatedTempConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MonitorPowerReductionV2estimatedTempDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<MonitorPowerReductionV2estimatedTempConfigurationGraphType, MonitorPowerReductionV2estimatedTempConfiguration>("MonitorPowerReductionV2estimatedTempConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorPowerReductionV2estimatedTempConfigurationGraphType>(
                            "{ Name =
   EntityName
     "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail"
       Properties =
        [PrimaryKey
           { Type = Guid
             Name = "MonitorPowerReductionV2estimatedTempConfigurationId"
             IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "MonitorPowerReductionV2estimatedTempDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation
           { Type =
              TableName "MonitorPowerReductionV2estimatedTempConfiguration"
             Name = "MonitorPowerReductionV2estimatedTempConfiguration"
             IsNullable = false
             IsCollection = false };
         Navigation
           { Type = TableName "MonitorPowerReductionV2estimatedTempDetail"
             Name = "MonitorPowerReductionV2estimatedTempDetails"
             IsNullable = false
             IsCollection = false }] }
  Fields =
   [{ Name = "MonitorPowerReductionV2estimatedTempConfigurationId"
      Type = Id Guid
      IsNullable = false };
    { Name = "MonitorPowerReductionV2estimatedTempDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Index"
                              Type = Id Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MonitorPowerReductionV2estimatedTempDetail"
        TargetTable =
         { Name = TableName "MonitorPowerReductionV2estimatedTempDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionV2estimatedTempDetailsId"
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
             Primitive { Type = Short
                         Name = "TempLimit"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempLimitKload0"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempLimitKload1"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempLimitKload2"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempLimitKload3"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempLimitKload4"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempLimitKload5"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoolDownTempFan0"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoolDownTempFan1"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoolDownTempFan2"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CavityTempTerm"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLimitLoad0"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLimitLoad1"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLimitLoad2"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLimitLoad3"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLimitLoad4"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLimitLoad5"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoolDownTempFan3"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail"
                 Name =
                  "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorPowerReductionV2estimatedTempDetail"
        IsNullable = false
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
            
			
                Field<MonitorPowerReductionV2estimatedTempDetailGraphType, MonitorPowerReductionV2estimatedTempDetail>("MonitorPowerReductionV2estimatedTempDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorPowerReductionV2estimatedTempDetailGraphType>(
                            "{ Name =
   EntityName
     "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail"
       Properties =
        [PrimaryKey
           { Type = Guid
             Name = "MonitorPowerReductionV2estimatedTempConfigurationId"
             IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "MonitorPowerReductionV2estimatedTempDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation
           { Type =
              TableName "MonitorPowerReductionV2estimatedTempConfiguration"
             Name = "MonitorPowerReductionV2estimatedTempConfiguration"
             IsNullable = false
             IsCollection = false };
         Navigation
           { Type = TableName "MonitorPowerReductionV2estimatedTempDetail"
             Name = "MonitorPowerReductionV2estimatedTempDetails"
             IsNullable = false
             IsCollection = false }] }
  Fields =
   [{ Name = "MonitorPowerReductionV2estimatedTempConfigurationId"
      Type = Id Guid
      IsNullable = false };
    { Name = "MonitorPowerReductionV2estimatedTempDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Index"
                              Type = Id Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MonitorPowerReductionV2estimatedTempDetail"
        TargetTable =
         { Name = TableName "MonitorPowerReductionV2estimatedTempDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionV2estimatedTempDetailsId"
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
             Primitive { Type = Short
                         Name = "TempLimit"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempLimitKload0"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempLimitKload1"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempLimitKload2"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempLimitKload3"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempLimitKload4"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TempLimitKload5"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoolDownTempFan0"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoolDownTempFan1"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoolDownTempFan2"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CavityTempTerm"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLimitLoad0"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLimitLoad1"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLimitLoad2"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLimitLoad3"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLimitLoad4"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerLimitLoad5"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "CoolDownTempFan3"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail"
                 Name =
                  "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorPowerReductionV2estimatedTempDetail"
        IsNullable = false
        KeyType = Guid }] }-MonitorPowerReductionV2estimatedTempDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorPowerReductionV2estimatedTempDetails
                                    .Where(x => x.MonitorPowerReductionV2estimatedTempDetail != null && ids.Contains((Guid)x.MonitorPowerReductionV2estimatedTempDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorPowerReductionV2estimatedTempDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.MonitorPowerReductionV2estimatedTempDetail);
                });
            
        }
    }
}
            