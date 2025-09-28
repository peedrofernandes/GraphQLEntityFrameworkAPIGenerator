
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
    public partial class MonitorCoilDeratingDetailGraphType : ObjectGraphType<MonitorCoilDeratingDetail>
    {
        public MonitorCoilDeratingDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorCoilDeratingDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.EnableHeatsink, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.EnableCoil, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.MonoGlobal, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.MonoLocal, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PhaseTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureMinCoil, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureRefCoil, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureMaxCoil, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ControlDpCoil, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ControlDiCoil, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MaxPercentSoft, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MaxPercentHard, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureMinHeatsinkSoft, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureRefHeatsinkSoft, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureMaxHeatsinkSoft, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureMinHeatsinkHard, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureRefHeatsinkHard, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureMaxHeatsinkHard, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ControlDpHeatsinkSoft, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ControlDiHeatsinkHard, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ControlDpHeatsinkHard, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ControlDiHeatsinkSoft, type: typeof(FloatGraphType), nullable: False);
            
                Field<MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetailGraphType, MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail>("MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetailGraphType>>(
                            "{ Name = EntityName "MonitorCoilDeratingDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "MonitorCoilDeratingDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MonitorCoilDeratingDetailsId"
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
                                                      Name = "EnableHeatsink"
                                                      IsNullable = true };
         Primitive { Type = Bool
                     Name = "EnableCoil"
                     IsNullable = true }; Primitive { Type = Bool
                                                      Name = "MonoGlobal"
                                                      IsNullable = false };
         Primitive { Type = Bool
                     Name = "MonoLocal"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Version"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "PhaseTime"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureMinCoil"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureRefCoil"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureMaxCoil"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "ControlDpCoil"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "ControlDiCoil"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "MaxPercentSoft"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "MaxPercentHard"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureMinHeatsinkSoft"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureRefHeatsinkSoft"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureMaxHeatsinkSoft"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureMinHeatsinkHard"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureRefHeatsinkHard"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureMaxHeatsinkHard"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "ControlDpHeatsinkSoft"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "ControlDiHeatsinkHard"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "ControlDpHeatsinkHard"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "ControlDiHeatsinkSoft"
                     IsNullable = false };
         Navigation
           { Type =
              TableName
                "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail"
             Name =
              "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "MonitorCoilDeratingDetailsId"
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
    { Name = "EnableHeatsink"
      Type = Primitive Bool
      IsNullable = true }; { Name = "EnableCoil"
                             Type = Primitive Bool
                             IsNullable = true }; { Name = "MonoGlobal"
                                                    Type = Primitive Bool
                                                    IsNullable = false };
    { Name = "MonoLocal"
      Type = Primitive Bool
      IsNullable = true }; { Name = "Version"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "PhaseTime"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "TemperatureMinCoil"
      Type = Primitive Float
      IsNullable = false }; { Name = "TemperatureRefCoil"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "TemperatureMaxCoil"
      Type = Primitive Float
      IsNullable = false }; { Name = "ControlDpCoil"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "ControlDiCoil"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "MaxPercentSoft"
      Type = Primitive Byte
      IsNullable = false }; { Name = "MaxPercentHard"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "TemperatureMinHeatsinkSoft"
      Type = Primitive Float
      IsNullable = false }; { Name = "TemperatureRefHeatsinkSoft"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "TemperatureMaxHeatsinkSoft"
      Type = Primitive Float
      IsNullable = false }; { Name = "TemperatureMinHeatsinkHard"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "TemperatureRefHeatsinkHard"
      Type = Primitive Float
      IsNullable = false }; { Name = "TemperatureMaxHeatsinkHard"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "ControlDpHeatsinkSoft"
      Type = Primitive Float
      IsNullable = false }; { Name = "ControlDiHeatsinkHard"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "ControlDpHeatsinkHard"
      Type = Primitive Float
      IsNullable = false }; { Name = "ControlDiHeatsinkSoft"
                              Type = Primitive Float
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail"
        TargetTable =
         { Name =
            TableName
              "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MonitorCoilDeratingConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "MonitorCoilDeratingDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "MonitorCoilDeratingConfiguration"
                          Name = "MonitorCoilDeratingConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "MonitorCoilDeratingDetail"
                          Name = "MonitorCoilDeratingDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail"
        KeyType = Guid }] }-MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetails
                                    .Where(x => x.MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail != null && ids.Contains((Guid)x.MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetails);
                    });
            
        }
    }
}
            