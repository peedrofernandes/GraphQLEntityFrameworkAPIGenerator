
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
            Field(t => t.LbopenLoopId, type: typeof(GuidGraphType), nullable: False);
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
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
            
            Field<StmHeatGraphType, StmHeat>("StmHeats")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmHeatGraphType>>(
                        "HeatLoadBalancingOpenLoop-StmHeat-loader",
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
            