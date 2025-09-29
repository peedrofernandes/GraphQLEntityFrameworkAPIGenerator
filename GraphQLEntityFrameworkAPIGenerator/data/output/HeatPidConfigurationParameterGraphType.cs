
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
    public partial class HeatPidConfigurationParameterGraphType : ObjectGraphType<HeatPidConfigurationParameter>
    {
        public HeatPidConfigurationParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Proportional, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.Integral, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.Derivative, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.WindUpFactor, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.UseForcedIntegral, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ForcedIntegralValue, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ReusePid, type: typeof(BoolGraphType), nullable: False);
            
            Field<StmHeatRunGraphType, StmHeatRun>("StmHeatRuns")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmHeatRunGraphType>>(
                        "HeatPidConfigurationParameter-StmHeatRun-loader",
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
            
			
            Field<StmHeatGraphType, StmHeat>("StmHeats")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmHeatGraphType>>(
                        "HeatPidConfigurationParameter-StmHeat-loader",
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
            