
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
    public partial class MonitorHeatSinkFanTemperatureGraphType : ObjectGraphType<MonitorHeatSinkFanTemperature>
    {
        public MonitorHeatSinkFanTemperatureGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorHeatSinkFanTemperatureId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.StructureVersion, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PostMinimum, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PostTimeout, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Hysteresis, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SoftThreshold0, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SoftThreshold1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SoftThreshold2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SoftThreshold3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SoftThreshold4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.HardThreshold0, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.HardThreshold1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.HardThreshold2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.HardThreshold3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.HardThreshold4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PostThreshold, type: typeof(FloatGraphType), nullable: False);
            
                Field<MonitorHeatSinkFanGraphType, MonitorHeatSinkFan>("MonitorHeatSinkFans")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorHeatSinkFanGraphType>>(
                            "{ Name = EntityName "MonitorHeatSinkFanTemperature"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorHeatSinkFanTemperature"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorHeatSinkFanTemperatureId"
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
                                                      Name = "StructureVersion"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "PostMinimum"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "PostTimeout"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "Hysteresis"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "SoftThreshold0"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "SoftThreshold1"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "SoftThreshold2"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "SoftThreshold3"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "SoftThreshold4"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "HardThreshold0"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "HardThreshold1"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "HardThreshold2"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "HardThreshold3"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "HardThreshold4"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "PostThreshold"
                                                       IsNullable = false };
         Navigation { Type = TableName "MonitorHeatSinkFan"
                      Name = "MonitorHeatSinkFanTemperatureDsp00ldNavigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "MonitorHeatSinkFan"
                      Name = "MonitorHeatSinkFanTemperatureDsp01ldNavigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "MonitorHeatSinkFan"
                      Name = "MonitorHeatSinkFanTemperatureDsp02ldNavigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "MonitorHeatSinkFan"
                      Name = "MonitorHeatSinkFanTemperatureDsp03ldNavigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "MonitorHeatSinkFan"
                      Name = "MonitorHeatSinkFanTemperatureDsp04ldNavigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "MonitorHeatSinkFan"
                      Name = "MonitorHeatSinkFanTemperatureDsp05ldNavigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "MonitorHeatSinkFan"
                      Name = "MonitorHeatSinkFanTemperatureDsp06ldNavigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "MonitorHeatSinkFan"
                      Name = "MonitorHeatSinkFanTemperatureDsp07ldNavigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "MonitorHeatSinkFan"
                      Name = "MonitorHeatSinkFanTemperatureDsp08ldNavigations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "MonitorHeatSinkFanTemperatureId"
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
    { Name = "StructureVersion"
      Type = Primitive Byte
      IsNullable = false }; { Name = "PostMinimum"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "PostTimeout"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "Hysteresis"
      Type = Primitive Float
      IsNullable = false }; { Name = "SoftThreshold0"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "SoftThreshold1"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "SoftThreshold2"
      Type = Primitive Float
      IsNullable = false }; { Name = "SoftThreshold3"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "SoftThreshold4"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "HardThreshold0"
      Type = Primitive Float
      IsNullable = false }; { Name = "HardThreshold1"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "HardThreshold2"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "HardThreshold3"
      Type = Primitive Float
      IsNullable = false }; { Name = "HardThreshold4"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "PostThreshold"
                                                      Type = Primitive Float
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "MonitorHeatSinkFan"
        TargetTable =
         { Name = TableName "MonitorHeatSinkFan"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorHeatSinkFanId"
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
             Primitive { Type = Byte
                         Name = "StructureVersion"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "NumberOfFans"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "LoadIndexFan00"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "TemperatureDsp00ld"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadIndexFan01"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "TemperatureDsp01ld"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadIndexFan02"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "TemperatureDsp02ld"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadIndexFan03"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "TemperatureDsp03ld"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadIndexFan04"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "TemperatureDsp04ld"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadIndexFan05"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "TemperatureDsp05ld"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadIndexFan06"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "TemperatureDsp06ld"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadIndexFan07"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "TemperatureDsp07ld"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadIndexFan08"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "TemperatureDsp08ld"
                         IsNullable = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                          Name = "TemperatureDsp00ldNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                          Name = "TemperatureDsp01ldNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                          Name = "TemperatureDsp02ldNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                          Name = "TemperatureDsp03ldNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                          Name = "TemperatureDsp04ldNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                          Name = "TemperatureDsp05ldNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                          Name = "TemperatureDsp06ldNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                          Name = "TemperatureDsp07ldNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MonitorHeatSinkFanTemperature"
                          Name = "TemperatureDsp08ldNavigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "MonitorHeatSinkFan"
        KeyType = Guid }] }-MonitorHeatSinkFan-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorHeatSinkFans
                                    .Where(x => x.MonitorHeatSinkFan != null && ids.Contains((Guid)x.MonitorHeatSinkFan))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorHeatSinkFan!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.MonitorHeatSinkFans);
                    });
            
        }
    }
}
            