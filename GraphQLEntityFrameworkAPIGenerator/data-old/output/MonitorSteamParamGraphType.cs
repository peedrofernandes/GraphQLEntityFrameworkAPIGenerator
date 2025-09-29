
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
    public partial class MonitorSteamParamGraphType : ObjectGraphType<MonitorSteamParam>
    {
        public MonitorSteamParamGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorSteamParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ExtraTankPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ColdTankPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.RemovableDrawerPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.QuickCouplingTankPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.FillPumpMaxTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.DrainPumpMaxTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.FillPlumbingPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.FillExtraTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.LowLevelTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.RecommendNewFilterVolume, type: typeof(IdGraphType), nullable: False);
			Field(t => t.RequireNewFilterVolume, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ColdTankToWarmTankFlowRate, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.DrainPumpFlowRate, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.QuickCouplingFlowRate, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PlumbingPumpFlowRate, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SteamGeneratorFlowRate, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TipsPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.RefillTimeThreshold, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.AllowDynamicFlowCalibration, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SteamSystemType, type: typeof(BoolGraphType), nullable: False);
            
                Field<MonitorSteamGraphType, MonitorSteam>("MonitorSteams")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorSteamGraphType>>(
                            "{ Name = EntityName "MonitorSteamParam"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorSteamParam"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorSteamParamsId"
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
                                                      Name = "ExtraTankPresent"
                                                      IsNullable = false };
         Primitive { Type = Bool
                     Name = "ColdTankPresent"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "RemovableDrawerPresent"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "QuickCouplingTankPresent"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "FillPumpMaxTime"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "DrainPumpMaxTime"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "FillPlumbingPresent"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "FillExtraTime"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "LowLevelTime"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "RecommendNewFilterVolume"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "RequireNewFilterVolume"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "ColdTankToWarmTankFlowRate"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "DrainPumpFlowRate"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "QuickCouplingFlowRate"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "PlumbingPumpFlowRate"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "SteamGeneratorFlowRate"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "TipsPresent"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "RefillTimeThreshold"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "AllowDynamicFlowCalibration"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "SteamSystemType"
                                                       IsNullable = false };
         Navigation { Type = TableName "MonitorSteam"
                      Name = "MonitorSteams"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "MonitorSteamParamsId"
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
    { Name = "ExtraTankPresent"
      Type = Primitive Bool
      IsNullable = false }; { Name = "ColdTankPresent"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "RemovableDrawerPresent"
      Type = Primitive Bool
      IsNullable = false }; { Name = "QuickCouplingTankPresent"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "FillPumpMaxTime"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "DrainPumpMaxTime"
      Type = Primitive Short
      IsNullable = false }; { Name = "FillPlumbingPresent"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "FillExtraTime"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "LowLevelTime"
      Type = Primitive Short
      IsNullable = false }; { Name = "RecommendNewFilterVolume"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "RequireNewFilterVolume"
      Type = Primitive Int
      IsNullable = false }; { Name = "ColdTankToWarmTankFlowRate"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "DrainPumpFlowRate"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "QuickCouplingFlowRate"
      Type = Primitive Float
      IsNullable = false }; { Name = "PlumbingPumpFlowRate"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "SteamGeneratorFlowRate"
      Type = Primitive Float
      IsNullable = false }; { Name = "TipsPresent"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "RefillTimeThreshold"
      Type = Primitive Short
      IsNullable = false }; { Name = "AllowDynamicFlowCalibration"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "SteamSystemType"
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
            