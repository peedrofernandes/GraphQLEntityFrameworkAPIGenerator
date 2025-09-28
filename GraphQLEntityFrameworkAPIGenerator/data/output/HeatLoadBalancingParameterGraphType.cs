
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
    public partial class HeatLoadBalancingParameterGraphType : ObjectGraphType<HeatLoadBalancingParameter>
    {
        public HeatLoadBalancingParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.NumberOfLoads, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadId1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.IndependentLoad1, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.PriorityLoad1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.BalanceLoad1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadId2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.IndependentLoad2, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.PriorityLoad2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.BalanceLoad2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadId3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.IndependentLoad3, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.PriorityLoad3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.BalanceLoad3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadId4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.IndependentLoad4, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.PriorityLoad4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.BalanceLoad4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadId5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.IndependentLoad5, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.PriorityLoad5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.BalanceLoad5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.LoadBalancingId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
            
                Field<StmHeatRunGraphType, StmHeatRun>("StmHeatRuns")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmHeatRunGraphType>>(
                            "{ Name = EntityName "HeatLoadBalancingParameter"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; PrimaryKey { Type = Guid
                                                       Name = "LoadBalancingId"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Version"
                     IsNullable = false };
         Navigation { Type = TableName "StmHeatRun"
                      Name = "StmHeatRuns"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "NumberOfLoads"
      Type = Primitive Byte
      IsNullable = false }; { Name = "LoadId1"
                              Type = Primitive Byte
                              IsNullable = true }; { Name = "IndependentLoad1"
                                                     Type = Primitive Bool
                                                     IsNullable = true };
    { Name = "PriorityLoad1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "BalanceLoad1"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "LoadId2"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "IndependentLoad2"
      Type = Primitive Bool
      IsNullable = true }; { Name = "PriorityLoad2"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "BalanceLoad2"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadId3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "IndependentLoad3"
                             Type = Primitive Bool
                             IsNullable = true }; { Name = "PriorityLoad3"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "BalanceLoad3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadId4"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "IndependentLoad4"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "PriorityLoad4"
      Type = Primitive Byte
      IsNullable = true }; { Name = "BalanceLoad4"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "LoadId5"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "IndependentLoad5"
      Type = Primitive Bool
      IsNullable = true }; { Name = "PriorityLoad5"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "BalanceLoad5"
                                                    Type = Primitive Byte
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
                              IsNullable = true }; { Name = "LoadBalancingId"
                                                     Type = Id Guid
                                                     IsNullable = false };
    { Name = "Version"
      Type = Primitive Byte
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
            