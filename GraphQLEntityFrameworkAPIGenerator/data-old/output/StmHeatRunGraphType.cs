
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
    public partial class StmHeatRunGraphType : ObjectGraphType<StmHeatRun>
    {
        public StmHeatRunGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.IsPyro, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CavityIndex, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DutyPeriod, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ProbeBalance, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.RtdSlope1, type: typeof(DoubleGraphType), nullable: True);
			Field(t => t.RtdSlope2, type: typeof(DoubleGraphType), nullable: True);
			Field(t => t.RtdOffset1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.RtdOffset2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.SetPointOffset, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.PyroTargetTime, type: typeof(ByteGraphType), nullable: True);
            
                Field<HeatConvectionFanParameterGraphType, HeatConvectionFanParameter>("HeatConvectionFanParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, HeatConvectionFanParameterGraphType>(
                            "{ Name = EntityName "StmHeatRun"
  CorrespondingTable =
   Regular
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
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "LoadBalancingId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ConvectionFan1Id"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ConvectionFan2Id"
                      IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "IsPyro"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Version"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "CavityIndex"
      Type = Primitive Byte
      IsNullable = true }; { Name = "DutyPeriod"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "ProbeBalance"
                                                     Type = Primitive Byte
                                                     IsNullable = true };
    { Name = "RtdSlope1"
      Type = Primitive Double
      IsNullable = true }; { Name = "RtdSlope2"
                             Type = Primitive Double
                             IsNullable = true }; { Name = "RtdOffset1"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "RtdOffset2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "SetPointOffset"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "PyroTargetTime"
                                                    Type = Primitive Byte
                                                    IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names = [RelationName "ConvectionFan1"; RelationName "ConvectionFan2"]
        TargetTable =
         { Name = TableName "HeatConvectionFanParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConvectionFanId"
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
                         Name = "StartTime"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "StopTime"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Speed"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLinkedRings"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ConvectionRingLoad1"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ConvectionRingLoad2"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ConvectionRingLoad3"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ConvectionRingLoad4"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Version"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseOpenLoopPeriod"
                         IsNullable = false };
             Navigation { Type = TableName "HeatLoadBalancingClosedLoop"
                          Name = "HeatLoadBalancingClosedLoopConvectionFan1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "HeatLoadBalancingClosedLoop"
                          Name = "HeatLoadBalancingClosedLoopConvectionFan2s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmHeat"
                          Name = "StmHeatConvectionFan1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmHeat"
                          Name = "StmHeatConvectionFan2s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmHeatRun"
                          Name = "StmHeatRunConvectionFan1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmHeatRun"
                          Name = "StmHeatRunConvectionFan2s"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatConvectionFanParameter"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "HeatLoadBalancingParameter"
        TargetTable =
         { Name = TableName "HeatLoadBalancingParameter"
           Properties =
            [Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "LoadId1"
                                                           IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId2"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId3"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId4"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId5"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad5"
                         IsNullable = true }; Primitive { Type = String
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
             PrimaryKey { Type = Guid
                          Name = "LoadBalancingId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Navigation { Type = TableName "StmHeatRun"
                          Name = "StmHeatRuns"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatLoadBalancingParameter"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "HeatPidConfigurationParameter"
        TargetTable =
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
             Primitive { Type = Double
                         Name = "Proportional"
                         IsNullable = false }; Primitive { Type = Double
                                                           Name = "Integral"
                                                           IsNullable = false };
             Primitive { Type = Double
                         Name = "Derivative"
                         IsNullable = false }; Primitive { Type = Double
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
        Destination = EntityName "HeatPidConfigurationParameter"
        IsNullable = true
        KeyType = Guid }] }-HeatConvectionFanParameter-loader",
                            async ids => 
                            {
                                Expression<Func<HeatConvectionFanParameter, bool>> expr = x => !ids.Any()
                                    \|\| (x.ConvectionFan1 != null && ids.Contains((Guid)x.ConvectionFan1))
\|\| (x.ConvectionFan2 != null && ids.Contains((Guid)x.ConvectionFan2));

                                var data = await dbContext.HeatConvectionFanParameters
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.ConvectionFan1,
x.ConvectionFan2
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.HeatConvectionFanParameters);
                    });
            
			
                Field<HeatLoadBalancingParameterGraphType, HeatLoadBalancingParameter>("HeatLoadBalancingParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, HeatLoadBalancingParameterGraphType>(
                            "{ Name = EntityName "StmHeatRun"
  CorrespondingTable =
   Regular
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
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "LoadBalancingId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ConvectionFan1Id"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ConvectionFan2Id"
                      IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "IsPyro"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Version"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "CavityIndex"
      Type = Primitive Byte
      IsNullable = true }; { Name = "DutyPeriod"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "ProbeBalance"
                                                     Type = Primitive Byte
                                                     IsNullable = true };
    { Name = "RtdSlope1"
      Type = Primitive Double
      IsNullable = true }; { Name = "RtdSlope2"
                             Type = Primitive Double
                             IsNullable = true }; { Name = "RtdOffset1"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "RtdOffset2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "SetPointOffset"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "PyroTargetTime"
                                                    Type = Primitive Byte
                                                    IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names = [RelationName "ConvectionFan1"; RelationName "ConvectionFan2"]
        TargetTable =
         { Name = TableName "HeatConvectionFanParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConvectionFanId"
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
                         Name = "StartTime"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "StopTime"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Speed"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLinkedRings"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ConvectionRingLoad1"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ConvectionRingLoad2"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ConvectionRingLoad3"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ConvectionRingLoad4"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Version"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseOpenLoopPeriod"
                         IsNullable = false };
             Navigation { Type = TableName "HeatLoadBalancingClosedLoop"
                          Name = "HeatLoadBalancingClosedLoopConvectionFan1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "HeatLoadBalancingClosedLoop"
                          Name = "HeatLoadBalancingClosedLoopConvectionFan2s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmHeat"
                          Name = "StmHeatConvectionFan1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmHeat"
                          Name = "StmHeatConvectionFan2s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmHeatRun"
                          Name = "StmHeatRunConvectionFan1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmHeatRun"
                          Name = "StmHeatRunConvectionFan2s"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatConvectionFanParameter"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "HeatLoadBalancingParameter"
        TargetTable =
         { Name = TableName "HeatLoadBalancingParameter"
           Properties =
            [Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "LoadId1"
                                                           IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId2"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId3"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId4"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId5"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad5"
                         IsNullable = true }; Primitive { Type = String
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
             PrimaryKey { Type = Guid
                          Name = "LoadBalancingId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Navigation { Type = TableName "StmHeatRun"
                          Name = "StmHeatRuns"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatLoadBalancingParameter"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "HeatPidConfigurationParameter"
        TargetTable =
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
             Primitive { Type = Double
                         Name = "Proportional"
                         IsNullable = false }; Primitive { Type = Double
                                                           Name = "Integral"
                                                           IsNullable = false };
             Primitive { Type = Double
                         Name = "Derivative"
                         IsNullable = false }; Primitive { Type = Double
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
        Destination = EntityName "HeatPidConfigurationParameter"
        IsNullable = true
        KeyType = Guid }] }-HeatLoadBalancingParameter-loader",
                            async ids => 
                            {
                                var data = await dbContext.HeatLoadBalancingParameters
                                    .Where(x => x.HeatLoadBalancingParameter != null && ids.Contains((Guid)x.HeatLoadBalancingParameter))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.HeatLoadBalancingParameter!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.HeatLoadBalancingParameter);
                });
            
			
                Field<HeatPidConfigurationParameterGraphType, HeatPidConfigurationParameter>("HeatPidConfigurationParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, HeatPidConfigurationParameterGraphType>(
                            "{ Name = EntityName "StmHeatRun"
  CorrespondingTable =
   Regular
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
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "LoadBalancingId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ConvectionFan1Id"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ConvectionFan2Id"
                      IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "IsPyro"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Version"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "CavityIndex"
      Type = Primitive Byte
      IsNullable = true }; { Name = "DutyPeriod"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "ProbeBalance"
                                                     Type = Primitive Byte
                                                     IsNullable = true };
    { Name = "RtdSlope1"
      Type = Primitive Double
      IsNullable = true }; { Name = "RtdSlope2"
                             Type = Primitive Double
                             IsNullable = true }; { Name = "RtdOffset1"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "RtdOffset2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "SetPointOffset"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "PyroTargetTime"
                                                    Type = Primitive Byte
                                                    IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names = [RelationName "ConvectionFan1"; RelationName "ConvectionFan2"]
        TargetTable =
         { Name = TableName "HeatConvectionFanParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConvectionFanId"
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
                         Name = "StartTime"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "StopTime"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Speed"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLinkedRings"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ConvectionRingLoad1"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ConvectionRingLoad2"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ConvectionRingLoad3"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ConvectionRingLoad4"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Version"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseOpenLoopPeriod"
                         IsNullable = false };
             Navigation { Type = TableName "HeatLoadBalancingClosedLoop"
                          Name = "HeatLoadBalancingClosedLoopConvectionFan1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "HeatLoadBalancingClosedLoop"
                          Name = "HeatLoadBalancingClosedLoopConvectionFan2s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmHeat"
                          Name = "StmHeatConvectionFan1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmHeat"
                          Name = "StmHeatConvectionFan2s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmHeatRun"
                          Name = "StmHeatRunConvectionFan1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmHeatRun"
                          Name = "StmHeatRunConvectionFan2s"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatConvectionFanParameter"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "HeatLoadBalancingParameter"
        TargetTable =
         { Name = TableName "HeatLoadBalancingParameter"
           Properties =
            [Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "LoadId1"
                                                           IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId2"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId3"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId4"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId5"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IndependentLoad5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PriorityLoad5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "BalanceLoad5"
                         IsNullable = true }; Primitive { Type = String
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
             PrimaryKey { Type = Guid
                          Name = "LoadBalancingId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Navigation { Type = TableName "StmHeatRun"
                          Name = "StmHeatRuns"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatLoadBalancingParameter"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "HeatPidConfigurationParameter"
        TargetTable =
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
             Primitive { Type = Double
                         Name = "Proportional"
                         IsNullable = false }; Primitive { Type = Double
                                                           Name = "Integral"
                                                           IsNullable = false };
             Primitive { Type = Double
                         Name = "Derivative"
                         IsNullable = false }; Primitive { Type = Double
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
        Destination = EntityName "HeatPidConfigurationParameter"
        IsNullable = true
        KeyType = Guid }] }-HeatPidConfigurationParameter-loader",
                            async ids => 
                            {
                                var data = await dbContext.HeatPidConfigurationParameters
                                    .Where(x => x.HeatPidConfigurationParameter != null && ids.Contains((Guid)x.HeatPidConfigurationParameter))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.HeatPidConfigurationParameter!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.HeatPidConfigurationParameter);
                });
            
        }
    }
}
            