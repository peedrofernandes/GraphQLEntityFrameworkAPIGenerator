
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
    public partial class MonitorPowerReductionV2powerRedDetailGraphType : ObjectGraphType<MonitorPowerReductionV2powerRedDetail>
    {
        public MonitorPowerReductionV2powerRedDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorPowerReductionV2powerRedDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.TempLimit, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.DeltaTemp, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CavityTempLimit, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.PowerLimitLoad0Na, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PowerLimitLoad1Na, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PowerLimitLoad2Na, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PowerLimitLoad3Na, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PowerLimitLoad4Na, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CavityTempLimitNa, type: typeof(BoolGraphType), nullable: False);
            
                Field<MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetailGraphType, MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail>("MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetailGraphType>>(
                            "{ Name = EntityName "MonitorPowerReductionV2powerRedDetail"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; Primitive { Type = Short
                                                      Name = "TempLimit"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "DeltaTemp"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PowerLimitLoad0"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "PowerLimitLoad1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PowerLimitLoad2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "PowerLimitLoad3"
                     IsNullable = false }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "MonitorPowerReductionV2powerRedDetailsId"
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
    { Name = "TempLimit"
      Type = Primitive Short
      IsNullable = false }; { Name = "DeltaTemp"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "PowerLimitLoad0"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "PowerLimitLoad1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "PowerLimitLoad2"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "PowerLimitLoad3"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "PowerLimitLoad4"
      Type = Primitive Byte
      IsNullable = false }; { Name = "CavityTempLimit"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "PowerLimitLoad0Na"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "PowerLimitLoad1Na"
      Type = Primitive Bool
      IsNullable = false }; { Name = "PowerLimitLoad2Na"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "PowerLimitLoad3Na"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "PowerLimitLoad4Na"
      Type = Primitive Bool
      IsNullable = false }; { Name = "CavityTempLimitNa"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail"
        TargetTable =
         { Name =
            TableName
              "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail"
           Properties =
            [PrimaryKey
               { Type = Guid
                 Name = "MonitorPowerReductionV2powerRedConfigurationId"
                 IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "MonitorPowerReductionV2powerRedDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "MonitorPowerReductionV2powerRedConfiguration"
                 Name = "MonitorPowerReductionV2powerRedConfiguration"
                 IsNullable = false
                 IsCollection = false };
             Navigation
               { Type = TableName "MonitorPowerReductionV2powerRedDetail"
                 Name = "MonitorPowerReductionV2powerRedDetails"
                 IsNullable = false
                 IsCollection = false }] }
        Destination =
         EntityName
           "MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail"
        KeyType = Guid }] }-MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails
                                    .Where(x => x.MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail != null && ids.Contains((Guid)x.MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails);
                    });
            
        }
    }
}
            