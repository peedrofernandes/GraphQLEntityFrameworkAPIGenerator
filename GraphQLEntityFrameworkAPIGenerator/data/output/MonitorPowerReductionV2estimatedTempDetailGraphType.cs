
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
    public partial class MonitorPowerReductionV2estimatedTempDetailGraphType : ObjectGraphType<MonitorPowerReductionV2estimatedTempDetail>
    {
        public MonitorPowerReductionV2estimatedTempDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorPowerReductionV2estimatedTempDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.TempLimit, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TempLimitKload0, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempLimitKload1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempLimitKload2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempLimitKload3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempLimitKload4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempLimitKload5, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.CoolDownTempFan0, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.CoolDownTempFan1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.CoolDownTempFan2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.CavityTempTerm, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLimitLoad0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CoolDownTempFan3, type: typeof(FloatGraphType), nullable: False);
            
                Field<MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetailGraphType, MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail>("MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetailGraphType>>(
                            "{ Name = EntityName "MonitorPowerReductionV2estimatedTempDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorPowerReductionV2estimatedTempDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorPowerReductionV2estimatedTempDetailsId"
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
         Primitive { Type = Float
                     Name = "TempLimitKload0"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "TempLimitKload1"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "TempLimitKload2"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "TempLimitKload3"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "TempLimitKload4"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "TempLimitKload5"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "CoolDownTempFan0"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "CoolDownTempFan1"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "CoolDownTempFan2"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "CavityTempTerm"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "PowerLimitLoad0"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PowerLimitLoad1"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "PowerLimitLoad2"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PowerLimitLoad3"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "PowerLimitLoad4"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PowerLimitLoad5"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "CoolDownTempFan3"
                     IsNullable = false };
         Navigation
           { Type =
              TableName
                "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail"
             Name =
              "MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "MonitorPowerReductionV2estimatedTempDetailsId"
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
      IsNullable = false }; { Name = "TempLimitKload0"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "TempLimitKload1"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "TempLimitKload2"
      Type = Primitive Float
      IsNullable = false }; { Name = "TempLimitKload3"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "TempLimitKload4"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "TempLimitKload5"
      Type = Primitive Float
      IsNullable = false }; { Name = "CoolDownTempFan0"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "CoolDownTempFan1"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "CoolDownTempFan2"
      Type = Primitive Float
      IsNullable = false }; { Name = "CavityTempTerm"
                              Type = Primitive Float
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
      IsNullable = false }; { Name = "PowerLimitLoad5"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "CoolDownTempFan3"
                                                      Type = Primitive Float
                                                      IsNullable = false }]
  Relations =
   [OneToMany
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
            