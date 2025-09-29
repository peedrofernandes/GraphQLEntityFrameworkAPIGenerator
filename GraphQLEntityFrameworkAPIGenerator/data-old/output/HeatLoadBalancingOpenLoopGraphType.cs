
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
    public partial class HeatLoadBalancingOpenLoopGraphType : ObjectGraphType<HeatLoadBalancingOpenLoop>
    {
        public HeatLoadBalancingOpenLoopGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.NumberOfLoads, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DutyPeriod, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.LoadId1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.StartTimeLoad1, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.StopTimeLoad1, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.MagnetronTargetLoad1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.BroilUserTargetLoad1, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.ReduceFromRightLoad1, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.TurboOnTimeLoad1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadId2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.StartTimeLoad2, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.StopTimeLoad2, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.MagnetronTargetLoad2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.BroilUserTargetLoad2, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.ReduceFromRightLoad2, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.TurboOnTimeLoad2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadId3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.StartTimeLoad3, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.StopTimeLoad3, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.MagnetronTargetLoad3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.BroilUserTargetLoad3, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.ReduceFromRightLoad3, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.TurboOnTimeLoad3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadId4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.StartTimeLoad4, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.StopTimeLoad4, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.MagnetronTargetLoad4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.BroilUserTargetLoad4, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.ReduceFromRightLoad4, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.TurboOnTimeLoad4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadId5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.StartTimeLoad5, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.StopTimeLoad5, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.MagnetronTargetLoad5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.BroilUserTargetLoad5, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.ReduceFromRightLoad5, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.TurboOnTimeLoad5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.LbopenLoopId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
            
                Field<StmHeatGraphType, StmHeat>("StmHeats")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmHeatGraphType>>(
                            "{ Name = EntityName "HeatLoadBalancingOpenLoop"
  CorrespondingTable =
   Regular
     { Name = TableName "HeatLoadBalancingOpenLoop"
       Properties =
        [Primitive { Type = Byte
                     Name = "NumberOfLoads"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "DutyPeriod"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "LoadId1"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "StartTimeLoad1"
                                                      IsNullable = true };
         Primitive { Type = Float
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "TurboOnTimeLoad1"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId2"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "StartTimeLoad2"
                                                      IsNullable = true };
         Primitive { Type = Float
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "TurboOnTimeLoad2"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId3"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "StartTimeLoad3"
                                                      IsNullable = true };
         Primitive { Type = Float
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "TurboOnTimeLoad3"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId4"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "StartTimeLoad4"
                                                      IsNullable = true };
         Primitive { Type = Float
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "TurboOnTimeLoad4"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId5"
                     IsNullable = true }; Primitive { Type = Float
                                                      Name = "StartTimeLoad5"
                                                      IsNullable = true };
         Primitive { Type = Float
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "TurboOnTimeLoad5"
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
         PrimaryKey { Type = Guid
                      Name = "LbopenLoopId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Version"
                                                        IsNullable = false };
         Navigation { Type = TableName "StmHeat"
                      Name = "StmHeats"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "NumberOfLoads"
      Type = Primitive Byte
      IsNullable = false }; { Name = "DutyPeriod"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "LoadId1"
                                                      Type = Primitive Byte
                                                      IsNullable = true };
    { Name = "StartTimeLoad1"
      Type = Primitive Float
      IsNullable = true }; { Name = "StopTimeLoad1"
                             Type = Primitive Float
                             IsNullable = true };
    { Name = "MagnetronTargetLoad1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "BroilUserTargetLoad1"
                             Type = Primitive Bool
                             IsNullable = true };
    { Name = "ReduceFromRightLoad1"
      Type = Primitive Bool
      IsNullable = true }; { Name = "TurboOnTimeLoad1"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "LoadId2"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "StartTimeLoad2"
      Type = Primitive Float
      IsNullable = true }; { Name = "StopTimeLoad2"
                             Type = Primitive Float
                             IsNullable = true };
    { Name = "MagnetronTargetLoad2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "BroilUserTargetLoad2"
                             Type = Primitive Bool
                             IsNullable = true };
    { Name = "ReduceFromRightLoad2"
      Type = Primitive Bool
      IsNullable = true }; { Name = "TurboOnTimeLoad2"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "LoadId3"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "StartTimeLoad3"
      Type = Primitive Float
      IsNullable = true }; { Name = "StopTimeLoad3"
                             Type = Primitive Float
                             IsNullable = true };
    { Name = "MagnetronTargetLoad3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "BroilUserTargetLoad3"
                             Type = Primitive Bool
                             IsNullable = true };
    { Name = "ReduceFromRightLoad3"
      Type = Primitive Bool
      IsNullable = true }; { Name = "TurboOnTimeLoad3"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "LoadId4"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "StartTimeLoad4"
      Type = Primitive Float
      IsNullable = true }; { Name = "StopTimeLoad4"
                             Type = Primitive Float
                             IsNullable = true };
    { Name = "MagnetronTargetLoad4"
      Type = Primitive Byte
      IsNullable = true }; { Name = "BroilUserTargetLoad4"
                             Type = Primitive Bool
                             IsNullable = true };
    { Name = "ReduceFromRightLoad4"
      Type = Primitive Bool
      IsNullable = true }; { Name = "TurboOnTimeLoad4"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "LoadId5"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "StartTimeLoad5"
      Type = Primitive Float
      IsNullable = true }; { Name = "StopTimeLoad5"
                             Type = Primitive Float
                             IsNullable = true };
    { Name = "MagnetronTargetLoad5"
      Type = Primitive Byte
      IsNullable = true }; { Name = "BroilUserTargetLoad5"
                             Type = Primitive Bool
                             IsNullable = true };
    { Name = "ReduceFromRightLoad5"
      Type = Primitive Bool
      IsNullable = true }; { Name = "TurboOnTimeLoad5"
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
      IsNullable = true }; { Name = "LbopenLoopId"
                             Type = Id Guid
                             IsNullable = false }; { Name = "Version"
                                                     Type = Primitive Byte
                                                     IsNullable = false }]
  Relations =
   [OneToMany
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
            