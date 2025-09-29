
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
    public partial class MonitorSteamDrainGraphType : ObjectGraphType<MonitorSteamDrain>
    {
        public MonitorSteamDrainGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorSteamDrainId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DrainToQcTank, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DrainToRemoveableDrawer, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DrainToExternal, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DrainToPlumbedOutlet, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.AutoDrainPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.BoilerTempSensorPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.RecommendDrainTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.RequireDrainTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.MinTimeBeforeDrain, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.MaxDrainTemp, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DrainPumpExtraTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.BoilerTempDebounceTime, type: typeof(ShortGraphType), nullable: False);
            
                Field<MonitorSteamGraphType, MonitorSteam>("MonitorSteams")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorSteamGraphType>>(
                            "{ Name = EntityName "MonitorSteamDrain"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorSteamDrain"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorSteamDrainId"
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
                                                      Name = "DrainToQcTank"
                                                      IsNullable = false };
         Primitive { Type = Bool
                     Name = "DrainToRemoveableDrawer"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "DrainToExternal"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "DrainToPlumbedOutlet"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "AutoDrainPresent"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "BoilerTempSensorPresent"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "RecommendDrainTime"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "RequireDrainTime"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "MinTimeBeforeDrain"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "MaxDrainTemp"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "DrainPumpExtraTime"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "BoilerTempDebounceTime"
                     IsNullable = false };
         Navigation { Type = TableName "MonitorSteam"
                      Name = "MonitorSteams"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "MonitorSteamDrainId"
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
    { Name = "DrainToQcTank"
      Type = Primitive Bool
      IsNullable = false }; { Name = "DrainToRemoveableDrawer"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "DrainToExternal"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "DrainToPlumbedOutlet"
      Type = Primitive Bool
      IsNullable = false }; { Name = "AutoDrainPresent"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "BoilerTempSensorPresent"
      Type = Primitive Bool
      IsNullable = false }; { Name = "RecommendDrainTime"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "RequireDrainTime"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "MinTimeBeforeDrain"
      Type = Primitive Short
      IsNullable = false }; { Name = "MaxDrainTemp"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "DrainPumpExtraTime"
      Type = Primitive Short
      IsNullable = false }; { Name = "BoilerTempDebounceTime"
                              Type = Primitive Short
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
            