
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
    public partial class MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetailGraphType : ObjectGraphType<MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail>
    {
        public MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorPowerReductionV2powerRedConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MonitorPowerReductionV2powerRedDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<MonitorPowerReductionV2powerRedConfigurationGraphType, MonitorPowerReductionV2powerRedConfiguration>("MonitorPowerReductionV2powerRedConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorPowerReductionV2powerRedConfigurationGraphType>(
                            "{ Name =
   EntityName
     "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorPowerReductionV2powerRedConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "MonitorPowerReductionV2powerRedDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation
           { Type = TableName "MonitorPowerReductionV2powerRedConfiguration"
             Name = "MonitorPowerReductionV2powerRedConfiguration"
             IsNullable = false
             IsCollection = false };
         Navigation { Type = TableName "MonitorPowerReductionV2powerRedDetail"
                      Name = "MonitorPowerReductionV2powerRedDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "MonitorPowerReductionV2powerRedConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "MonitorPowerReductionV2powerRedDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MonitorPowerReductionV2powerRedDetail"
        TargetTable =
         { Name = TableName "MonitorPowerReductionV2powerRedDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionV2powerRedDetailsId"
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
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "DeltaTemp"
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
             Primitive { Type = Short
                         Name = "CavityTempLimit"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "PowerLimitLoad0Na"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "PowerLimitLoad1Na"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "PowerLimitLoad2Na"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "PowerLimitLoad3Na"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "PowerLimitLoad4Na"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "CavityTempLimitNa"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail"
                 Name =
                  "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorPowerReductionV2powerRedDetail"
        IsNullable = false
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
            
			
                Field<MonitorPowerReductionV2powerRedDetailGraphType, MonitorPowerReductionV2powerRedDetail>("MonitorPowerReductionV2powerRedDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorPowerReductionV2powerRedDetailGraphType>(
                            "{ Name =
   EntityName
     "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorPowerReductionV2powerRedConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "MonitorPowerReductionV2powerRedDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation
           { Type = TableName "MonitorPowerReductionV2powerRedConfiguration"
             Name = "MonitorPowerReductionV2powerRedConfiguration"
             IsNullable = false
             IsCollection = false };
         Navigation { Type = TableName "MonitorPowerReductionV2powerRedDetail"
                      Name = "MonitorPowerReductionV2powerRedDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "MonitorPowerReductionV2powerRedConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "MonitorPowerReductionV2powerRedDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MonitorPowerReductionV2powerRedDetail"
        TargetTable =
         { Name = TableName "MonitorPowerReductionV2powerRedDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionV2powerRedDetailsId"
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
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "DeltaTemp"
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
             Primitive { Type = Short
                         Name = "CavityTempLimit"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "PowerLimitLoad0Na"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "PowerLimitLoad1Na"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "PowerLimitLoad2Na"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "PowerLimitLoad3Na"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "PowerLimitLoad4Na"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "CavityTempLimitNa"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail"
                 Name =
                  "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorPowerReductionV2powerRedDetail"
        IsNullable = false
        KeyType = Guid }] }-MonitorPowerReductionV2powerRedDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorPowerReductionV2powerRedDetails
                                    .Where(x => x.MonitorPowerReductionV2powerRedDetail != null && ids.Contains((Guid)x.MonitorPowerReductionV2powerRedDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorPowerReductionV2powerRedDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.MonitorPowerReductionV2powerRedDetail);
                });
            
        }
    }
}
            