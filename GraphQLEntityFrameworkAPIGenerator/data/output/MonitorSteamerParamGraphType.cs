
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
    public partial class MonitorSteamerParamGraphType : ObjectGraphType<MonitorSteamerParam>
    {
        public MonitorSteamerParamGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorSteamerParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.FillPumpOnTime, type: typeof(DecimalGraphType), nullable: False);
			Field(t => t.FillPumpOffTime, type: typeof(DecimalGraphType), nullable: False);
			Field(t => t.FillPumpOnTemp, type: typeof(IdGraphType), nullable: False);
			Field(t => t.FillPumpDeltaTemp, type: typeof(IdGraphType), nullable: False);
			Field(t => t.DrainPumpOnTime, type: typeof(DecimalGraphType), nullable: False);
			Field(t => t.SteamerTempUpperThreshold, type: typeof(IdGraphType), nullable: False);
			Field(t => t.SteamerTempLowerThreshold, type: typeof(IdGraphType), nullable: False);
			Field(t => t.FillPumpOnTimeDescale, type: typeof(DecimalGraphType), nullable: False);
			Field(t => t.DescaleTempUpperThreshold, type: typeof(IdGraphType), nullable: False);
			Field(t => t.DescaleTempLowerThreshold, type: typeof(IdGraphType), nullable: False);
            
                Field<MonitorSteamGraphType, MonitorSteam>("MonitorSteams")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorSteamGraphType>>(
                            "{ Name = EntityName "MonitorSteamerParam"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorSteamerParam"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorSteamerParamsId"
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
                     IsNullable = true }; Primitive { Type = Decimal
                                                      Name = "FillPumpOnTime"
                                                      IsNullable = false };
         Primitive { Type = Decimal
                     Name = "FillPumpOffTime"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "FillPumpOnTemp"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "FillPumpDeltaTemp"
                     IsNullable = false }; Primitive { Type = Decimal
                                                       Name = "DrainPumpOnTime"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "SteamerTempUpperThreshold"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "SteamerTempLowerThreshold"
                     IsNullable = false };
         Primitive { Type = Decimal
                     Name = "FillPumpOnTimeDescale"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "DescaleTempUpperThreshold"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "DescaleTempLowerThreshold"
                     IsNullable = false };
         Navigation { Type = TableName "MonitorSteam"
                      Name = "MonitorSteams"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "MonitorSteamerParamsId"
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
    { Name = "FillPumpOnTime"
      Type = Primitive Decimal
      IsNullable = false }; { Name = "FillPumpOffTime"
                              Type = Primitive Decimal
                              IsNullable = false }; { Name = "FillPumpOnTemp"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "FillPumpDeltaTemp"
      Type = Primitive Int
      IsNullable = false }; { Name = "DrainPumpOnTime"
                              Type = Primitive Decimal
                              IsNullable = false };
    { Name = "SteamerTempUpperThreshold"
      Type = Primitive Int
      IsNullable = false }; { Name = "SteamerTempLowerThreshold"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "FillPumpOnTimeDescale"
      Type = Primitive Decimal
      IsNullable = false }; { Name = "DescaleTempUpperThreshold"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "DescaleTempLowerThreshold"
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
            