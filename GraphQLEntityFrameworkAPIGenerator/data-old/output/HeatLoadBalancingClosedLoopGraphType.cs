
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
    public partial class HeatLoadBalancingClosedLoopGraphType : ObjectGraphType<HeatLoadBalancingClosedLoop>
    {
        public HeatLoadBalancingClosedLoopGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LbclosedLoopId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfLoads, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DutyPeriod, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.LoadId1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.StartTimeLoad1, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.StopTimeLoad1, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.LoadId2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.StartTimeLoad2, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.StopTimeLoad2, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.LoadId3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.StartTimeLoad3, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.StopTimeLoad3, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.LoadId4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.StartTimeLoad4, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.StopTimeLoad4, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.LoadId5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.StartTimeLoad5, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.StopTimeLoad5, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
            
                Field<HeatConvectionFanParameterGraphType, HeatConvectionFanParameter>("HeatConvectionFanParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, HeatConvectionFanParameterGraphType>(
                            "{ Name = EntityName "HeatLoadBalancingClosedLoop"
  CorrespondingTable =
   Regular
     { Name = TableName "HeatLoadBalancingClosedLoop"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "LbclosedLoopId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumberOfLoads"
                                                        IsNullable = false };
         Primitive { Type = Float
                     Name = "DutyPeriod"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "LoadId1"
                                                       IsNullable = true };
         Primitive { Type = Float
                     Name = "StartTimeLoad1"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "StopTimeLoad1"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId2"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "StartTimeLoad2"
                                                      IsNullable = true };
         Primitive { Type = Float
                     Name = "StopTimeLoad2"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadId3"
                                                      IsNullable = true };
         Primitive { Type = Float
                     Name = "StartTimeLoad3"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "StopTimeLoad3"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId4"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "StartTimeLoad4"
                                                      IsNullable = true };
         Primitive { Type = Float
                     Name = "StopTimeLoad4"
                     IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "LbclosedLoopId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumberOfLoads"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "DutyPeriod"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "LoadId1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "StartTimeLoad1"
                             Type = Primitive Float
                             IsNullable = true }; { Name = "StopTimeLoad1"
                                                    Type = Primitive Float
                                                    IsNullable = true };
    { Name = "LoadId2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "StartTimeLoad2"
                             Type = Primitive Float
                             IsNullable = true }; { Name = "StopTimeLoad2"
                                                    Type = Primitive Float
                                                    IsNullable = true };
    { Name = "LoadId3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "StartTimeLoad3"
                             Type = Primitive Float
                             IsNullable = true }; { Name = "StopTimeLoad3"
                                                    Type = Primitive Float
                                                    IsNullable = true };
    { Name = "LoadId4"
      Type = Primitive Byte
      IsNullable = true }; { Name = "StartTimeLoad4"
                             Type = Primitive Float
                             IsNullable = true }; { Name = "StopTimeLoad4"
                                                    Type = Primitive Float
                                                    IsNullable = true };
    { Name = "LoadId5"
      Type = Primitive Byte
      IsNullable = true }; { Name = "StartTimeLoad5"
                             Type = Primitive Float
                             IsNullable = true }; { Name = "StopTimeLoad5"
                                                    Type = Primitive Float
                                                    IsNullable = true };
    { Name = "Description"
      Type = Primitive String
      IsNullable = false }; { Name = "Status"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Owner"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Timestamp"
      Type = Primitive DateTime
      IsNullable = false }; { Name = "RevisionGroup"
                              Type = Primitive Guid
                              IsNullable = false }; { Name = "Revision"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "TableTarget"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Notes"
                              Type = Primitive String
                              IsNullable = true }; { Name = "Version"
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
            
			
                Field<StmHeatGraphType, StmHeat>("StmHeats")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmHeatGraphType>>(
                            "{ Name = EntityName "HeatLoadBalancingClosedLoop"
  CorrespondingTable =
   Regular
     { Name = TableName "HeatLoadBalancingClosedLoop"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "LbclosedLoopId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumberOfLoads"
                                                        IsNullable = false };
         Primitive { Type = Float
                     Name = "DutyPeriod"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "LoadId1"
                                                       IsNullable = true };
         Primitive { Type = Float
                     Name = "StartTimeLoad1"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "StopTimeLoad1"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId2"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "StartTimeLoad2"
                                                      IsNullable = true };
         Primitive { Type = Float
                     Name = "StopTimeLoad2"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadId3"
                                                      IsNullable = true };
         Primitive { Type = Float
                     Name = "StartTimeLoad3"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "StopTimeLoad3"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId4"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "StartTimeLoad4"
                                                      IsNullable = true };
         Primitive { Type = Float
                     Name = "StopTimeLoad4"
                     IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "LbclosedLoopId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumberOfLoads"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "DutyPeriod"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "LoadId1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "StartTimeLoad1"
                             Type = Primitive Float
                             IsNullable = true }; { Name = "StopTimeLoad1"
                                                    Type = Primitive Float
                                                    IsNullable = true };
    { Name = "LoadId2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "StartTimeLoad2"
                             Type = Primitive Float
                             IsNullable = true }; { Name = "StopTimeLoad2"
                                                    Type = Primitive Float
                                                    IsNullable = true };
    { Name = "LoadId3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "StartTimeLoad3"
                             Type = Primitive Float
                             IsNullable = true }; { Name = "StopTimeLoad3"
                                                    Type = Primitive Float
                                                    IsNullable = true };
    { Name = "LoadId4"
      Type = Primitive Byte
      IsNullable = true }; { Name = "StartTimeLoad4"
                             Type = Primitive Float
                             IsNullable = true }; { Name = "StopTimeLoad4"
                                                    Type = Primitive Float
                                                    IsNullable = true };
    { Name = "LoadId5"
      Type = Primitive Byte
      IsNullable = true }; { Name = "StartTimeLoad5"
                             Type = Primitive Float
                             IsNullable = true }; { Name = "StopTimeLoad5"
                                                    Type = Primitive Float
                                                    IsNullable = true };
    { Name = "Description"
      Type = Primitive String
      IsNullable = false }; { Name = "Status"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Owner"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Timestamp"
      Type = Primitive DateTime
      IsNullable = false }; { Name = "RevisionGroup"
                              Type = Primitive Guid
                              IsNullable = false }; { Name = "Revision"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "TableTarget"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Notes"
                              Type = Primitive String
                              IsNullable = true }; { Name = "Version"
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
            