
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
    public partial class MonitorSteamHumidityTargetMappingGraphType : ObjectGraphType<MonitorSteamHumidityTargetMapping>
    {
        public MonitorSteamHumidityTargetMappingGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorSteamHumidityMapId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfLevels, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TargetTemperature1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TargetTemperature2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TargetTemperature3, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TargetHumidity1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TargetHumidity2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TargetHumidity3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TargetHumidity4, type: typeof(IdGraphType), nullable: False);
            
                Field<MonitorSteamGraphType, MonitorSteam>("MonitorSteams")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorSteamGraphType>>(
                            "{ Name = EntityName "MonitorSteamHumidityTargetMapping"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorSteamHumidityTargetMapping"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorSteamHumidityMapId"
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "NumberOfLevels"
                                                      IsNullable = false };
         Primitive { Type = Short
                     Name = "TargetTemperature1"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "TargetTemperature2"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "TargetTemperature3"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "TargetHumidity1"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "TargetHumidity2"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "TargetHumidity3"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "TargetHumidity4"
                     IsNullable = false };
         Navigation { Type = TableName "MonitorSteam"
                      Name = "MonitorSteams"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "MonitorSteamHumidityMapId"
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
    { Name = "NumberOfLevels"
      Type = Primitive Byte
      IsNullable = false }; { Name = "TargetTemperature1"
                              Type = Primitive Short
                              IsNullable = false };
    { Name = "TargetTemperature2"
      Type = Primitive Short
      IsNullable = false }; { Name = "TargetTemperature3"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "TargetHumidity1"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "TargetHumidity2"
      Type = Primitive Int
      IsNullable = false }; { Name = "TargetHumidity3"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TargetHumidity4"
                                                      Type = Primitive Int
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "MonitorSteam"
        TargetTable =
         { Name = TableName "MonitorSteam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorSteamId"
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
             ForeignKey { Type = Guid
                          Name = "MonitorSteamParamsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorSteamDrainId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorSteamWaterLevelSensorId"
                          IsNullable = true }; Primitive { Type = Byte
                                                           Name = "Version"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "MonitorSteamDescaleId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorSteamHumidityMapId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MonitorSteamerParamsId"
                          IsNullable = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MonitorSteamDescale"
                          Name = "MonitorSteamDescale"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorSteamDrain"
                          Name = "MonitorSteamDrain"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorSteamHumidityTargetMapping"
                          Name = "MonitorSteamHumidityMap"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorSteamParam"
                          Name = "MonitorSteamParams"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorSteamWaterLevelSensor"
                          Name = "MonitorSteamWaterLevelSensor"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorSteamerParam"
                          Name = "MonitorSteamerParams"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "MonitorSteam"
        KeyType = Guid }] }-MonitorSteam-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorSteams
                                    .Where(x => x.MonitorSteam != null && ids.Contains((Guid)x.MonitorSteam))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorSteam!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.MonitorSteams);
                    });
            
        }
    }
}
            