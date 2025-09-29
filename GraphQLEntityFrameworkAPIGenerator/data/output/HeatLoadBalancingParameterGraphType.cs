
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
            Field(t => t.LoadBalancingId, type: typeof(GuidGraphType), nullable: False);
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
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
            
            Field<StmHeatRunGraphType, StmHeatRun>("StmHeatRuns")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmHeatRunGraphType>>(
                        "HeatLoadBalancingParameter-StmHeatRun-loader",
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
            