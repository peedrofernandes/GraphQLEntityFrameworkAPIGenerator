
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
    public partial class HeatInitializeGraphType : ObjectGraphType<HeatInitialize>
    {
        public HeatInitializeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.IsPyro, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PyroDutyPeriod, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ProbeBalance, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RtdSlope1, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.RtdSlope2, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.RtdOffset1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.RtdOffset2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TargetTemperatureOffset, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.PyroTargetTime, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.UseForcedIntegral, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ForcedIntegralValue, type: typeof(IdGraphType), nullable: False);
            
                Field<StmHeatInitializeSelectorGraphType, StmHeatInitializeSelector>("StmHeatInitializeSelectors")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmHeatInitializeSelectorGraphType>>(
                            "{ Name = EntityName "HeatInitialize"
  CorrespondingTable =
   Regular
     { Name = TableName "HeatInitialize"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = Bool
                                                        Name = "IsPyro"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "PyroDutyPeriod"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ProbeBalance"
                                                       IsNullable = false };
         Primitive { Type = Double
                     Name = "RtdSlope1"
                     IsNullable = false }; Primitive { Type = Double
                                                       Name = "RtdSlope2"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "RtdOffset1"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "RtdOffset2"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "TargetTemperatureOffset"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PyroTargetTime"
                                                       IsNullable = true };
         Primitive { Type = String
                     Name = "Description"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = DateTime
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
                     Name = "UseForcedIntegral"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "ForcedIntegralValue"
                     IsNullable = false }; ForeignKey { Type = Bool
                                                        Name = "ReusePid"
                                                        IsNullable = false };
         Navigation { Type = TableName "StmHeatInitializeSelector"
                      Name = "StmHeatInitializeSelectors"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "StmSetupTempSelector"
                      Name = "StmSetupTempSelectors"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "IsPyro"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "PyroDutyPeriod"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ProbeBalance"
      Type = Primitive Byte
      IsNullable = false }; { Name = "RtdSlope1"
                              Type = Primitive Double
                              IsNullable = false }; { Name = "RtdSlope2"
                                                      Type = Primitive Double
                                                      IsNullable = false };
    { Name = "RtdOffset1"
      Type = Primitive Short
      IsNullable = false }; { Name = "RtdOffset2"
                              Type = Primitive Short
                              IsNullable = false };
    { Name = "TargetTemperatureOffset"
      Type = Primitive Short
      IsNullable = false }; { Name = "PyroTargetTime"
                              Type = Primitive Byte
                              IsNullable = true }; { Name = "Description"
                                                     Type = Primitive String
                                                     IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "UseForcedIntegral"
                             Type = Primitive Bool
                             IsNullable = false };
    { Name = "ForcedIntegralValue"
      Type = Primitive Int
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "StmHeatInitializeSelector"
        TargetTable =
         { Name = TableName "StmHeatInitializeSelector"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "HeatInitializeId"
                          IsNullable = false };
             Navigation { Type = TableName "HeatInitialize"
                          Name = "HeatInitialize"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmHeatInitializeSelector"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmSetupTempSelector"
        TargetTable =
         { Name = TableName "StmSetupTempSelector"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "HeatInitializeId"
                          IsNullable = false };
             Navigation { Type = TableName "HeatInitialize"
                          Name = "HeatInitialize"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmSetupTempSelector"
        KeyType = Guid }] }-StmHeatInitializeSelector-loader",
                            async ids => 
                            {
                                var data = await dbContext.StmHeatInitializeSelectors
                                    .Where(x => x.StmHeatInitializeSelector != null && ids.Contains((Guid)x.StmHeatInitializeSelector))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.StmHeatInitializeSelector!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.StmHeatInitializeSelectors);
                    });
            
			
                Field<StmSetupTempSelectorGraphType, StmSetupTempSelector>("StmSetupTempSelectors")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmSetupTempSelectorGraphType>>(
                            "{ Name = EntityName "HeatInitialize"
  CorrespondingTable =
   Regular
     { Name = TableName "HeatInitialize"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = Bool
                                                        Name = "IsPyro"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "PyroDutyPeriod"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ProbeBalance"
                                                       IsNullable = false };
         Primitive { Type = Double
                     Name = "RtdSlope1"
                     IsNullable = false }; Primitive { Type = Double
                                                       Name = "RtdSlope2"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "RtdOffset1"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "RtdOffset2"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "TargetTemperatureOffset"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PyroTargetTime"
                                                       IsNullable = true };
         Primitive { Type = String
                     Name = "Description"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = DateTime
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
                     Name = "UseForcedIntegral"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "ForcedIntegralValue"
                     IsNullable = false }; ForeignKey { Type = Bool
                                                        Name = "ReusePid"
                                                        IsNullable = false };
         Navigation { Type = TableName "StmHeatInitializeSelector"
                      Name = "StmHeatInitializeSelectors"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "StmSetupTempSelector"
                      Name = "StmSetupTempSelectors"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "IsPyro"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "PyroDutyPeriod"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ProbeBalance"
      Type = Primitive Byte
      IsNullable = false }; { Name = "RtdSlope1"
                              Type = Primitive Double
                              IsNullable = false }; { Name = "RtdSlope2"
                                                      Type = Primitive Double
                                                      IsNullable = false };
    { Name = "RtdOffset1"
      Type = Primitive Short
      IsNullable = false }; { Name = "RtdOffset2"
                              Type = Primitive Short
                              IsNullable = false };
    { Name = "TargetTemperatureOffset"
      Type = Primitive Short
      IsNullable = false }; { Name = "PyroTargetTime"
                              Type = Primitive Byte
                              IsNullable = true }; { Name = "Description"
                                                     Type = Primitive String
                                                     IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "UseForcedIntegral"
                             Type = Primitive Bool
                             IsNullable = false };
    { Name = "ForcedIntegralValue"
      Type = Primitive Int
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "StmHeatInitializeSelector"
        TargetTable =
         { Name = TableName "StmHeatInitializeSelector"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "HeatInitializeId"
                          IsNullable = false };
             Navigation { Type = TableName "HeatInitialize"
                          Name = "HeatInitialize"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmHeatInitializeSelector"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmSetupTempSelector"
        TargetTable =
         { Name = TableName "StmSetupTempSelector"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "HeatInitializeId"
                          IsNullable = false };
             Navigation { Type = TableName "HeatInitialize"
                          Name = "HeatInitialize"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmSetupTempSelector"
        KeyType = Guid }] }-StmSetupTempSelector-loader",
                            async ids => 
                            {
                                var data = await dbContext.StmSetupTempSelectors
                                    .Where(x => x.StmSetupTempSelector != null && ids.Contains((Guid)x.StmSetupTempSelector))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.StmSetupTempSelector!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.StmSetupTempSelectors);
                    });
            
        }
    }
}
            