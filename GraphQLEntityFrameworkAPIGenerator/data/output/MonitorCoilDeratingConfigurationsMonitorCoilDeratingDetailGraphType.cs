
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
    public partial class MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetailGraphType : ObjectGraphType<MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail>
    {
        public MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorCoilDeratingConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MonitorCoilDeratingDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<MonitorCoilDeratingConfigurationGraphType, MonitorCoilDeratingConfiguration>("MonitorCoilDeratingConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorCoilDeratingConfigurationGraphType>(
                            "{ Name = EntityName "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorCoilDeratingConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "MonitorCoilDeratingDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "AcuexpansionBoardId"
                      IsNullable = false };
         Navigation { Type = TableName "MonitorCoilDeratingConfiguration"
                      Name = "MonitorCoilDeratingConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "MonitorCoilDeratingDetail"
                      Name = "MonitorCoilDeratingDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "MonitorCoilDeratingConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "MonitorCoilDeratingDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "MonitorCoilDeratingConfiguration"
        TargetTable =
         { Name = TableName "MonitorCoilDeratingConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorCoilDeratingConfigurationId"
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
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail"
                 Name =
                  "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorCoilDeratingConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MonitorCoilDeratingDetail"
        TargetTable =
         { Name = TableName "MonitorCoilDeratingDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorCoilDeratingDetailsId"
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
                         Name = "EnableHeatsink"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "EnableCoil"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "MonoGlobal"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "MonoLocal"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Version"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "PhaseTime"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMinCoil"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureRefCoil"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMaxCoil"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ControlDpCoil"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ControlDiCoil"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "MaxPercentSoft"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "MaxPercentHard"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMinHeatsinkSoft"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureRefHeatsinkSoft"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMaxHeatsinkSoft"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMinHeatsinkHard"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureRefHeatsinkHard"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMaxHeatsinkHard"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ControlDpHeatsinkSoft"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ControlDiHeatsinkHard"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ControlDpHeatsinkHard"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ControlDiHeatsinkSoft"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail"
                 Name =
                  "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorCoilDeratingDetail"
        IsNullable = false
        KeyType = Guid }] }-MonitorCoilDeratingConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorCoilDeratingConfigurations
                                    .Where(x => x.MonitorCoilDeratingConfiguration != null && ids.Contains((Guid)x.MonitorCoilDeratingConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorCoilDeratingConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.MonitorCoilDeratingConfiguration);
                });
            
			
                Field<MonitorCoilDeratingDetailGraphType, MonitorCoilDeratingDetail>("MonitorCoilDeratingDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MonitorCoilDeratingDetailGraphType>(
                            "{ Name = EntityName "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorCoilDeratingConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "MonitorCoilDeratingDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "AcuexpansionBoardId"
                      IsNullable = false };
         Navigation { Type = TableName "MonitorCoilDeratingConfiguration"
                      Name = "MonitorCoilDeratingConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "MonitorCoilDeratingDetail"
                      Name = "MonitorCoilDeratingDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "MonitorCoilDeratingConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "MonitorCoilDeratingDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "MonitorCoilDeratingConfiguration"
        TargetTable =
         { Name = TableName "MonitorCoilDeratingConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorCoilDeratingConfigurationId"
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
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail"
                 Name =
                  "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorCoilDeratingConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MonitorCoilDeratingDetail"
        TargetTable =
         { Name = TableName "MonitorCoilDeratingDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorCoilDeratingDetailsId"
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
                         Name = "EnableHeatsink"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "EnableCoil"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "MonoGlobal"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "MonoLocal"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Version"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "PhaseTime"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMinCoil"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureRefCoil"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMaxCoil"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ControlDpCoil"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ControlDiCoil"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "MaxPercentSoft"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "MaxPercentHard"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMinHeatsinkSoft"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureRefHeatsinkSoft"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMaxHeatsinkSoft"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMinHeatsinkHard"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureRefHeatsinkHard"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "TemperatureMaxHeatsinkHard"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ControlDpHeatsinkSoft"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ControlDiHeatsinkHard"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ControlDpHeatsinkHard"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "ControlDiHeatsinkSoft"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail"
                 Name =
                  "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MonitorCoilDeratingDetail"
        IsNullable = false
        KeyType = Guid }] }-MonitorCoilDeratingDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorCoilDeratingDetails
                                    .Where(x => x.MonitorCoilDeratingDetail != null && ids.Contains((Guid)x.MonitorCoilDeratingDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorCoilDeratingDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.MonitorCoilDeratingDetail);
                });
            
        }
    }
}
            