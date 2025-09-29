
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
                        "HeatLoadBalancingClosedLoop-HeatConvectionFanParameter-loader",
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
                        "HeatLoadBalancingClosedLoop-StmHeat-loader",
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
            