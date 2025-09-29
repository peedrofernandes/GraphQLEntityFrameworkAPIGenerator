
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
    public partial class HeatConvectionFanParameterGraphType : ObjectGraphType<HeatConvectionFanParameter>
    {
        public HeatConvectionFanParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ConvectionFanId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.StartTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StopTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Speed, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfLinkedRings, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvectionRingLoad1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvectionRingLoad2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvectionRingLoad3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvectionRingLoad4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UseOpenLoopPeriod, type: typeof(BoolGraphType), nullable: False);
            
                Field<HeatLoadBalancingClosedLoopGraphType, HeatLoadBalancingClosedLoop>("HeatLoadBalancingClosedLoops")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<HeatLoadBalancingClosedLoopGraphType>>(
                            "{ Name = EntityName "HeatConvectionFanParameter"
  CorrespondingTable =
   Regular
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
                                                      Name = "StartTime"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "StopTime"
                     IsNullable = false }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "ConvectionFanId"
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
    { Name = "StartTime"
      Type = Primitive Byte
      IsNullable = false }; { Name = "StopTime"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Speed"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NumberOfLinkedRings"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ConvectionRingLoad1"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "ConvectionRingLoad2"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ConvectionRingLoad3"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "ConvectionRingLoad4"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "UseOpenLoopPeriod"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
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
        KeyType = Guid };
    OneToMany
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
                            });

                        return loader.LoadAsync(context.Source.HeatLoadBalancingClosedLoops);
                    });
            
			
                Field<StmHeatGraphType, StmHeat>("StmHeats")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmHeatGraphType>>(
                            "{ Name = EntityName "HeatConvectionFanParameter"
  CorrespondingTable =
   Regular
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
                                                      Name = "StartTime"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "StopTime"
                     IsNullable = false }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "ConvectionFanId"
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
    { Name = "StartTime"
      Type = Primitive Byte
      IsNullable = false }; { Name = "StopTime"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Speed"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NumberOfLinkedRings"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ConvectionRingLoad1"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "ConvectionRingLoad2"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ConvectionRingLoad3"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "ConvectionRingLoad4"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "UseOpenLoopPeriod"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
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
        KeyType = Guid };
    OneToMany
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
            
			
                Field<StmHeatRunGraphType, StmHeatRun>("StmHeatRuns")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmHeatRunGraphType>>(
                            "{ Name = EntityName "HeatConvectionFanParameter"
  CorrespondingTable =
   Regular
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
                                                      Name = "StartTime"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "StopTime"
                     IsNullable = false }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "ConvectionFanId"
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
    { Name = "StartTime"
      Type = Primitive Byte
      IsNullable = false }; { Name = "StopTime"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Speed"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NumberOfLinkedRings"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ConvectionRingLoad1"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "ConvectionRingLoad2"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ConvectionRingLoad3"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "ConvectionRingLoad4"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "UseOpenLoopPeriod"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
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
        KeyType = Guid };
    OneToMany
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
            
        }
    }
}
            