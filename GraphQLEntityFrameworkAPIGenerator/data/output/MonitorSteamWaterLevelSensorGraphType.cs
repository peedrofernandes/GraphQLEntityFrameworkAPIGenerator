
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
    public partial class MonitorSteamWaterLevelSensorGraphType : ObjectGraphType<MonitorSteamWaterLevelSensor>
    {
        public MonitorSteamWaterLevelSensorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorSteamWaterLevelSensorId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ColdTankLevels, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.WarmTankLevels, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ColdTankMaxVolume, type: typeof(IdGraphType), nullable: False);
			Field(t => t.WarmTankMaxVolume, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ColdTankWlsVolume1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ColdTankWlsVolume2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ColdTankWlsVolume3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ColdTankWlsVolume4, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ColdTankWlsVolume5, type: typeof(IdGraphType), nullable: False);
			Field(t => t.WarmTankWlsVolume1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.WarmTankWlsVolume2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.WarmTankWlsVolume3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.WarmTankWlsVolume4, type: typeof(IdGraphType), nullable: False);
			Field(t => t.WarmTankWlsVolume5, type: typeof(IdGraphType), nullable: False);
			Field(t => t.VolumeSubtracted, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.MinimumWaterLevelThreshold, type: typeof(IdGraphType), nullable: False);
			Field(t => t.MedianWaterLevelThreshold, type: typeof(IdGraphType), nullable: False);
			Field(t => t.MaximumWaterLevelThreshold, type: typeof(IdGraphType), nullable: False);
            
                Field<MonitorSteamGraphType, MonitorSteam>("MonitorSteams")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorSteamGraphType>>(
                            "{ Name = EntityName "MonitorSteamWaterLevelSensor"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorSteamWaterLevelSensor"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorSteamWaterLevelSensorId"
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
                                                      Name = "ColdTankLevels"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "WarmTankLevels"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "ColdTankMaxVolume"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "WarmTankMaxVolume"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "ColdTankWlsVolume1"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "ColdTankWlsVolume2"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "ColdTankWlsVolume3"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "ColdTankWlsVolume4"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "ColdTankWlsVolume5"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "WarmTankWlsVolume1"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "WarmTankWlsVolume2"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "WarmTankWlsVolume3"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "WarmTankWlsVolume4"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "WarmTankWlsVolume5"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "VolumeSubtracted"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "MinimumWaterLevelThreshold"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "MedianWaterLevelThreshold"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "MaximumWaterLevelThreshold"
                     IsNullable = false };
         Navigation { Type = TableName "MonitorSteam"
                      Name = "MonitorSteams"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "MonitorSteamWaterLevelSensorId"
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
    { Name = "ColdTankLevels"
      Type = Primitive Byte
      IsNullable = false }; { Name = "WarmTankLevels"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ColdTankMaxVolume"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "WarmTankMaxVolume"
      Type = Primitive Int
      IsNullable = false }; { Name = "ColdTankWlsVolume1"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "ColdTankWlsVolume2"
      Type = Primitive Int
      IsNullable = false }; { Name = "ColdTankWlsVolume3"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "ColdTankWlsVolume4"
      Type = Primitive Int
      IsNullable = false }; { Name = "ColdTankWlsVolume5"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "WarmTankWlsVolume1"
      Type = Primitive Int
      IsNullable = false }; { Name = "WarmTankWlsVolume2"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "WarmTankWlsVolume3"
      Type = Primitive Int
      IsNullable = false }; { Name = "WarmTankWlsVolume4"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "WarmTankWlsVolume5"
      Type = Primitive Int
      IsNullable = false }; { Name = "VolumeSubtracted"
                              Type = Primitive Short
                              IsNullable = false };
    { Name = "MinimumWaterLevelThreshold"
      Type = Primitive Int
      IsNullable = false }; { Name = "MedianWaterLevelThreshold"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "MaximumWaterLevelThreshold"
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
            