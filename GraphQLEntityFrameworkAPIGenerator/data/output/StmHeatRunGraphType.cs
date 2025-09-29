
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
                        "StmHeatRun-HeatConvectionFanParameter-loader",
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
                        "StmHeatRun-HeatLoadBalancingParameter-loader",
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
                        "StmHeatRun-HeatPidConfigurationParameter-loader",
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
            