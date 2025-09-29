
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
                        "HeatConvectionFanParameter-HeatLoadBalancingClosedLoop-loader",
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
                        "HeatConvectionFanParameter-StmHeat-loader",
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
                        "HeatConvectionFanParameter-StmHeatRun-loader",
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
            