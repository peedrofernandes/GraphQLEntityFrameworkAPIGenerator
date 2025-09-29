
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
    public partial class HeatPidConfigurationParameterGraphType : ObjectGraphType<HeatPidConfigurationParameter>
    {
        public HeatPidConfigurationParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Proportional, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.Integral, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.Derivative, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.WindUpFactor, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.UseForcedIntegral, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ForcedIntegralValue, type: typeof(IdGraphType), nullable: False);
            
                Field<StmHeatRunGraphType, StmHeatRun>("StmHeatRuns")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmHeatRunGraphType>>(
                            "{ Name = EntityName "HeatPidConfigurationParameter"
  CorrespondingTable =
   Regular
     { Name = TableName "HeatPidConfigurationParameter"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
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
                     IsNullable = true }; Primitive { Type = Double
                                                      Name = "Proportional"
                                                      IsNullable = false };
         Primitive { Type = Double
                     Name = "Integral"
                     IsNullable = false }; Primitive { Type = Double
                                                       Name = "Derivative"
                                                       IsNullable = false };
         Primitive { Type = Double
                     Name = "WindUpFactor"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "UseForcedIntegral"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "ForcedIntegralValue"
                     IsNullable = false }; ForeignKey { Type = Bool
                                                        Name = "ReusePid"
                                                        IsNullable = false };
         Navigation { Type = TableName "StmHeatRun"
                      Name = "StmHeatRuns"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "StmHeat"
                      Name = "StmHeats"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "Id"
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
    { Name = "Proportional"
      Type = Primitive Double
      IsNullable = false }; { Name = "Integral"
                              Type = Primitive Double
                              IsNullable = false }; { Name = "Derivative"
                                                      Type = Primitive Double
                                                      IsNullable = false };
    { Name = "WindUpFactor"
      Type = Primitive Double
      IsNullable = false }; { Name = "UseForcedIntegral"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "ForcedIntegralValue"
      Type = Primitive Int
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "StmHeatRun"
        TargetTable =
         { Name = TableName "StmHeatRun"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsPyro"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Version"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CavityIndex"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "DutyPeriod"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ProbeBalance"
                                                           IsNullable = true };
             Primitive { Type = Double
                         Name = "RtdSlope1"
                         IsNullable = true }; Primitive { Type = Double
                                                          Name = "RtdSlope2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "RtdOffset1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "RtdOffset2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "SetPointOffset"
                         IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PidConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LoadBalancingId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConvectionFan1Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConvectionFan2Id"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "PyroTargetTime"
                         IsNullable = true };
             Navigation { Type = TableName "HeatConvectionFanParameter"
                          Name = "ConvectionFan1"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HeatConvectionFanParameter"
                          Name = "ConvectionFan2"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HeatLoadBalancingParameter"
                          Name = "LoadBalancing"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HeatPidConfigurationParameter"
                          Name = "PidConfiguration"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmHeatRun"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmHeat"
        TargetTable =
         { Name = TableName "StmHeat"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PidConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LbopenLoopId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LbclosedLoopId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "PyroTargetTime"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConvectionFan1Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConvectionFan2Id"
                          IsNullable = true };
             Navigation { Type = TableName "HeatConvectionFanParameter"
                          Name = "ConvectionFan1"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HeatConvectionFanParameter"
                          Name = "ConvectionFan2"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HeatLoadBalancingClosedLoop"
                          Name = "LbclosedLoop"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HeatLoadBalancingOpenLoop"
                          Name = "LbopenLoop"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HeatPidConfigurationParameter"
                          Name = "PidConfiguration"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmHeat"
        KeyType = Guid }] }-StmHeatRun-loader",
                            async ids => 
                            {
                                var data = await dbContext.StmHeatRuns
                                    .Where(x => x.StmHeatRun != null && ids.Contains((Guid)x.StmHeatRun))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.StmHeatRun!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.StmHeatRuns);
                    });
            
			
                Field<StmHeatGraphType, StmHeat>("StmHeats")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmHeatGraphType>>(
                            "{ Name = EntityName "HeatPidConfigurationParameter"
  CorrespondingTable =
   Regular
     { Name = TableName "HeatPidConfigurationParameter"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
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
                     IsNullable = true }; Primitive { Type = Double
                                                      Name = "Proportional"
                                                      IsNullable = false };
         Primitive { Type = Double
                     Name = "Integral"
                     IsNullable = false }; Primitive { Type = Double
                                                       Name = "Derivative"
                                                       IsNullable = false };
         Primitive { Type = Double
                     Name = "WindUpFactor"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "UseForcedIntegral"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "ForcedIntegralValue"
                     IsNullable = false }; ForeignKey { Type = Bool
                                                        Name = "ReusePid"
                                                        IsNullable = false };
         Navigation { Type = TableName "StmHeatRun"
                      Name = "StmHeatRuns"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "StmHeat"
                      Name = "StmHeats"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "Id"
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
    { Name = "Proportional"
      Type = Primitive Double
      IsNullable = false }; { Name = "Integral"
                              Type = Primitive Double
                              IsNullable = false }; { Name = "Derivative"
                                                      Type = Primitive Double
                                                      IsNullable = false };
    { Name = "WindUpFactor"
      Type = Primitive Double
      IsNullable = false }; { Name = "UseForcedIntegral"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "ForcedIntegralValue"
      Type = Primitive Int
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "StmHeatRun"
        TargetTable =
         { Name = TableName "StmHeatRun"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsPyro"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Version"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CavityIndex"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "DutyPeriod"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ProbeBalance"
                                                           IsNullable = true };
             Primitive { Type = Double
                         Name = "RtdSlope1"
                         IsNullable = true }; Primitive { Type = Double
                                                          Name = "RtdSlope2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "RtdOffset1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "RtdOffset2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "SetPointOffset"
                         IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PidConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LoadBalancingId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConvectionFan1Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConvectionFan2Id"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "PyroTargetTime"
                         IsNullable = true };
             Navigation { Type = TableName "HeatConvectionFanParameter"
                          Name = "ConvectionFan1"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HeatConvectionFanParameter"
                          Name = "ConvectionFan2"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HeatLoadBalancingParameter"
                          Name = "LoadBalancing"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HeatPidConfigurationParameter"
                          Name = "PidConfiguration"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmHeatRun"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmHeat"
        TargetTable =
         { Name = TableName "StmHeat"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PidConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LbopenLoopId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LbclosedLoopId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "PyroTargetTime"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConvectionFan1Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConvectionFan2Id"
                          IsNullable = true };
             Navigation { Type = TableName "HeatConvectionFanParameter"
                          Name = "ConvectionFan1"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HeatConvectionFanParameter"
                          Name = "ConvectionFan2"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HeatLoadBalancingClosedLoop"
                          Name = "LbclosedLoop"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HeatLoadBalancingOpenLoop"
                          Name = "LbopenLoop"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HeatPidConfigurationParameter"
                          Name = "PidConfiguration"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmHeat"
        KeyType = Guid }] }-StmHeat-loader",
                            async ids => 
                            {
                                var data = await dbContext.StmHeats
                                    .Where(x => x.StmHeat != null && ids.Contains((Guid)x.StmHeat))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.StmHeat!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.StmHeats);
                    });
            
        }
    }
}
            