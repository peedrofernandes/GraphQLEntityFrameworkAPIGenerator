
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
    public partial class StmHeatGraphType : ObjectGraphType<StmHeat>
    {
        public StmHeatGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PyroTargetTime, type: typeof(ByteGraphType), nullable: False);
            
                Field<HeatConvectionFanParameterGraphType, HeatConvectionFanParameter>("HeatConvectionFanParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, HeatConvectionFanParameterGraphType>(
                            "{ Name = EntityName "StmHeat"
  CorrespondingTable =
   Regular
     { Name = TableName "StmHeat"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Version"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "PidConfigurationId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "LbopenLoopId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "LbclosedLoopId"
                      IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "PyroTargetTime"
                                                      Type = Primitive Byte
                                                      IsNullable = false }]
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
      { Name = RelationName "HeatLoadBalancingClosedLoop"
        TargetTable =
         { Name = TableName "HeatLoadBalancingClosedLoop"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LbclosedLoopId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "DutyPeriod"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "LoadId1"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad1"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId2"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad2"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId3"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad3"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId4"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad4"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId5"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad5"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad5"
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
             Primitive { Type = Byte
                         Name = "Version"
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
             Navigation { Type = TableName "StmHeat"
                          Name = "StmHeats"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatLoadBalancingClosedLoop"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "HeatLoadBalancingOpenLoop"
        TargetTable =
         { Name = TableName "HeatLoadBalancingOpenLoop"
           Properties =
            [Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "DutyPeriod"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "LoadId1"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad1"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad1"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad1"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId2"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad2"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad2"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad2"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId3"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad3"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad3"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad3"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId4"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad4"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad4"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad4"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId5"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad5"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad5"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad5"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad5"
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
                          Name = "LbopenLoopId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Navigation { Type = TableName "StmHeat"
                          Name = "StmHeats"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatLoadBalancingOpenLoop"
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
            
			
                Field<HeatLoadBalancingClosedLoopGraphType, HeatLoadBalancingClosedLoop>("HeatLoadBalancingClosedLoops")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, HeatLoadBalancingClosedLoopGraphType>(
                            "{ Name = EntityName "StmHeat"
  CorrespondingTable =
   Regular
     { Name = TableName "StmHeat"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Version"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "PidConfigurationId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "LbopenLoopId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "LbclosedLoopId"
                      IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "PyroTargetTime"
                                                      Type = Primitive Byte
                                                      IsNullable = false }]
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
      { Name = RelationName "HeatLoadBalancingClosedLoop"
        TargetTable =
         { Name = TableName "HeatLoadBalancingClosedLoop"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LbclosedLoopId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "DutyPeriod"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "LoadId1"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad1"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId2"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad2"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId3"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad3"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId4"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad4"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId5"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad5"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad5"
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
             Primitive { Type = Byte
                         Name = "Version"
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
             Navigation { Type = TableName "StmHeat"
                          Name = "StmHeats"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatLoadBalancingClosedLoop"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "HeatLoadBalancingOpenLoop"
        TargetTable =
         { Name = TableName "HeatLoadBalancingOpenLoop"
           Properties =
            [Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "DutyPeriod"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "LoadId1"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad1"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad1"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad1"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId2"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad2"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad2"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad2"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId3"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad3"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad3"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad3"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId4"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad4"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad4"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad4"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId5"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad5"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad5"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad5"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad5"
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
                          Name = "LbopenLoopId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Navigation { Type = TableName "StmHeat"
                          Name = "StmHeats"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatLoadBalancingOpenLoop"
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
        KeyType = Guid }] }-HeatLoadBalancingClosedLoop-loader",
                            async ids => 
                            {
                                var data = await dbContext.HeatLoadBalancingClosedLoops
                                    .Where(x => x.HeatLoadBalancingClosedLoop != null && ids.Contains((Guid)x.HeatLoadBalancingClosedLoop))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.HeatLoadBalancingClosedLoop!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.HeatLoadBalancingClosedLoop);
                });
            
			
                Field<HeatLoadBalancingOpenLoopGraphType, HeatLoadBalancingOpenLoop>("HeatLoadBalancingOpenLoops")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, HeatLoadBalancingOpenLoopGraphType>(
                            "{ Name = EntityName "StmHeat"
  CorrespondingTable =
   Regular
     { Name = TableName "StmHeat"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Version"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "PidConfigurationId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "LbopenLoopId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "LbclosedLoopId"
                      IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "PyroTargetTime"
                                                      Type = Primitive Byte
                                                      IsNullable = false }]
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
      { Name = RelationName "HeatLoadBalancingClosedLoop"
        TargetTable =
         { Name = TableName "HeatLoadBalancingClosedLoop"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LbclosedLoopId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "DutyPeriod"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "LoadId1"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad1"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId2"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad2"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId3"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad3"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId4"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad4"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId5"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad5"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad5"
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
             Primitive { Type = Byte
                         Name = "Version"
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
             Navigation { Type = TableName "StmHeat"
                          Name = "StmHeats"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatLoadBalancingClosedLoop"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "HeatLoadBalancingOpenLoop"
        TargetTable =
         { Name = TableName "HeatLoadBalancingOpenLoop"
           Properties =
            [Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "DutyPeriod"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "LoadId1"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad1"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad1"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad1"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId2"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad2"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad2"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad2"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId3"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad3"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad3"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad3"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId4"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad4"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad4"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad4"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId5"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad5"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad5"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad5"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad5"
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
                          Name = "LbopenLoopId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Navigation { Type = TableName "StmHeat"
                          Name = "StmHeats"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatLoadBalancingOpenLoop"
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
        KeyType = Guid }] }-HeatLoadBalancingOpenLoop-loader",
                            async ids => 
                            {
                                var data = await dbContext.HeatLoadBalancingOpenLoops
                                    .Where(x => x.HeatLoadBalancingOpenLoop != null && ids.Contains((Guid)x.HeatLoadBalancingOpenLoop))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.HeatLoadBalancingOpenLoop!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.HeatLoadBalancingOpenLoop);
                });
            
			
                Field<HeatPidConfigurationParameterGraphType, HeatPidConfigurationParameter>("HeatPidConfigurationParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, HeatPidConfigurationParameterGraphType>(
                            "{ Name = EntityName "StmHeat"
  CorrespondingTable =
   Regular
     { Name = TableName "StmHeat"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Version"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "PidConfigurationId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "LbopenLoopId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "LbclosedLoopId"
                      IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "PyroTargetTime"
                                                      Type = Primitive Byte
                                                      IsNullable = false }]
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
      { Name = RelationName "HeatLoadBalancingClosedLoop"
        TargetTable =
         { Name = TableName "HeatLoadBalancingClosedLoop"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LbclosedLoopId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "DutyPeriod"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "LoadId1"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad1"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId2"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad2"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId3"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad3"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId4"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad4"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadId5"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad5"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad5"
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
             Primitive { Type = Byte
                         Name = "Version"
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
             Navigation { Type = TableName "StmHeat"
                          Name = "StmHeats"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatLoadBalancingClosedLoop"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "HeatLoadBalancingOpenLoop"
        TargetTable =
         { Name = TableName "HeatLoadBalancingOpenLoop"
           Properties =
            [Primitive { Type = Byte
                         Name = "NumberOfLoads"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "DutyPeriod"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "LoadId1"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad1"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad1"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad1"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId2"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad2"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad2"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad2"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId3"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad3"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad3"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad3"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId4"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad4"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad4"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad4"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId5"
                                                          IsNullable = true };
             Primitive { Type = Float
                         Name = "StartTimeLoad5"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "StopTimeLoad5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "MagnetronTargetLoad5"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "BroilUserTargetLoad5"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ReduceFromRightLoad5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TurboOnTimeLoad5"
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
                          Name = "LbopenLoopId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Navigation { Type = TableName "StmHeat"
                          Name = "StmHeats"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatLoadBalancingOpenLoop"
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
            