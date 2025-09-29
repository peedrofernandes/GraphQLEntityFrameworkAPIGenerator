
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
    public partial class MonitorPowerReductionV2estimatedTempConfigurationGraphType : ObjectGraphType<MonitorPowerReductionV2estimatedTempConfiguration>
    {
        public MonitorPowerReductionV2estimatedTempConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorPowerReductionV2estimatedTempConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DeltaTempTerm, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OverTempEstimation, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CavityTempTermApplies, type: typeof(BoolGraphType), nullable: True);
            
                Field<MonitorPowerReductionV2detailGraphType, MonitorPowerReductionV2detail>("MonitorPowerReductionV2details")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorPowerReductionV2detailGraphType>>(
                            "{ Name = EntityName "MonitorPowerReductionV2estimatedTempConfiguration"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "MonitorPowerReductionV2estimatedTempConfigurationId"
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
    { Name = "DeltaTempTerm"
      Type = Primitive Bool
      IsNullable = false }; { Name = "OverTempEstimation"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "CavityTempTermApplies"
      Type = Primitive Bool
      IsNullable = true }]
  Relations =
   [OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail"
        TargetTable =
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
                          IsNullable = false };
             PrimaryKey { Type = Byte
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
        Destination =
         EntityName
           "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail"
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
                            });

                        return loader.LoadAsync(context.Source.MonitorPowerReductionV2details);
                    });
            
			
                Field<MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetailGraphType, MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail>("MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetailGraphType>>(
                            "{ Name = EntityName "MonitorPowerReductionV2estimatedTempConfiguration"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "MonitorPowerReductionV2estimatedTempConfigurationId"
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
    { Name = "DeltaTempTerm"
      Type = Primitive Bool
      IsNullable = false }; { Name = "OverTempEstimation"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "CavityTempTermApplies"
      Type = Primitive Bool
      IsNullable = true }]
  Relations =
   [OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail"
        TargetTable =
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
                          IsNullable = false };
             PrimaryKey { Type = Byte
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
        Destination =
         EntityName
           "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail"
        KeyType = Guid }] }-MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails
                                    .Where(x => x.MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail != null && ids.Contains((Guid)x.MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails);
                    });
            
        }
    }
}
            