
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
    public partial class HeatInitializeGraphType : ObjectGraphType<HeatInitialize>
    {
        public HeatInitializeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.IsPyro, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PyroDutyPeriod, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ProbeBalance, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RtdSlope1, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.RtdSlope2, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.RtdOffset1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.RtdOffset2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TargetTemperatureOffset, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.PyroTargetTime, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.UseForcedIntegral, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ForcedIntegralValue, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ReusePid, type: typeof(BoolGraphType), nullable: False);
            
            Field<StmHeatInitializeSelectorGraphType, StmHeatInitializeSelector>("StmHeatInitializeSelectors")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmHeatInitializeSelectorGraphType>>(
                        "HeatInitialize-StmHeatInitializeSelector-loader",
                        async ids => 
                        {
                            var data = await dbContext.StmHeatInitializeSelectors
                                .Where(x => x.StmHeatInitializeSelector != null && ids.Contains((Guid)x.StmHeatInitializeSelector))
                                .Select(x => new
                                {
                                    Key = (Guid)x.StmHeatInitializeSelector!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.StmHeatInitializeSelectors);
                });
            
			
            Field<StmSetupTempSelectorGraphType, StmSetupTempSelector>("StmSetupTempSelectors")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmSetupTempSelectorGraphType>>(
                        "HeatInitialize-StmSetupTempSelector-loader",
                        async ids => 
                        {
                            var data = await dbContext.StmSetupTempSelectors
                                .Where(x => x.StmSetupTempSelector != null && ids.Contains((Guid)x.StmSetupTempSelector))
                                .Select(x => new
                                {
                                    Key = (Guid)x.StmSetupTempSelector!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.StmSetupTempSelectors);
                });
            
        }
    }
}
            