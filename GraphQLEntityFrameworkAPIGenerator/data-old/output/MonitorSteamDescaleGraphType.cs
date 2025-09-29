
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
    public partial class MonitorSteamDescaleGraphType : ObjectGraphType<MonitorSteamDescale>
    {
        public MonitorSteamDescaleGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorSteamDescaleId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfWaterHardnessCoeff, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RecommendDescaleHours, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.RequireDescaleHours, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.RecommendDescaleEfficiency, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReqiureDescaleEfficiency, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff5, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff6, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff7, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff8, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff9, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff10, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.DescaleDetectionMethod, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TimeBasedDescale, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.BoilerEfficiencyBasedDescale, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.WaterLevelSensorBasedDescale, type: typeof(BoolGraphType), nullable: False);
            
                Field<MonitorSteamGraphType, MonitorSteam>("MonitorSteams")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorSteamGraphType>>(
                            "{ Name = EntityName "MonitorSteamDescale"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorSteamDescale"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorSteamDescaleId"
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
         Primitive { Type = Byte
                     Name = "NumberOfWaterHardnessCoeff"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "RecommendDescaleHours"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "RequireDescaleHours"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "RecommendDescaleEfficiency"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "ReqiureDescaleEfficiency"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "WaterHardnessCoeff1"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "WaterHardnessCoeff2"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "WaterHardnessCoeff3"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "WaterHardnessCoeff4"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "WaterHardnessCoeff5"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "WaterHardnessCoeff6"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "WaterHardnessCoeff7"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "WaterHardnessCoeff8"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "WaterHardnessCoeff9"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "WaterHardnessCoeff10"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "DescaleDetectionMethod"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "TimeBasedDescale"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "BoilerEfficiencyBasedDescale"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "WaterLevelSensorBasedDescale"
                     IsNullable = false };
         Navigation { Type = TableName "MonitorSteam"
                      Name = "MonitorSteams"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "MonitorSteamDescaleId"
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
    { Name = "NumberOfWaterHardnessCoeff"
      Type = Primitive Byte
      IsNullable = false }; { Name = "RecommendDescaleHours"
                              Type = Primitive Short
                              IsNullable = false };
    { Name = "RequireDescaleHours"
      Type = Primitive Short
      IsNullable = false }; { Name = "RecommendDescaleEfficiency"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "ReqiureDescaleEfficiency"
      Type = Primitive Byte
      IsNullable = false }; { Name = "WaterHardnessCoeff1"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "WaterHardnessCoeff2"
      Type = Primitive Float
      IsNullable = false }; { Name = "WaterHardnessCoeff3"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "WaterHardnessCoeff4"
      Type = Primitive Float
      IsNullable = false }; { Name = "WaterHardnessCoeff5"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "WaterHardnessCoeff6"
      Type = Primitive Float
      IsNullable = false }; { Name = "WaterHardnessCoeff7"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "WaterHardnessCoeff8"
      Type = Primitive Float
      IsNullable = false }; { Name = "WaterHardnessCoeff9"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "WaterHardnessCoeff10"
      Type = Primitive Float
      IsNullable = false }; { Name = "DescaleDetectionMethod"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "TimeBasedDescale"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "BoilerEfficiencyBasedDescale"
      Type = Primitive Bool
      IsNullable = false }; { Name = "WaterLevelSensorBasedDescale"
                              Type = Primitive Bool
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
            