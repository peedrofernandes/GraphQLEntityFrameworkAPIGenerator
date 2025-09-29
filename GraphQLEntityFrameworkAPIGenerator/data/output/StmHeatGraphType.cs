
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
                        "StmHeat-HeatConvectionFanParameter-loader",
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
                        "StmHeat-HeatLoadBalancingClosedLoop-loader",
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
                        "StmHeat-HeatLoadBalancingOpenLoop-loader",
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
                        "StmHeat-HeatPidConfigurationParameter-loader",
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
            