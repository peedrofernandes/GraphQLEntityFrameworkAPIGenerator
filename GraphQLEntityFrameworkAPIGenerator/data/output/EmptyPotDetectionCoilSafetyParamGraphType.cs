
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
    public partial class EmptyPotDetectionCoilSafetyParamGraphType : ObjectGraphType<EmptyPotDetectionCoilSafetyParam>
    {
        public EmptyPotDetectionCoilSafetyParamGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.EmptyPotDetectionCoilSafetyParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.IsEmptyPotDetectionEnabled, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.UseGapTempSensorForEmptyPotDetection, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.RisingTimeThreshold, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MinLoadPowerAvgDeliveredDuringRisingTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.MaxLoadPowerAvgDeliveredDuringRisingTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.MaxLoadPowerAvgWhenFixedDerating, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TemperatureControlSetpointSlope, type: typeof(FloatGraphType), nullable: False);
            
            Field<InductionCoilConfigGraphType, InductionCoilConfig>("InductionCoilConfigs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilConfigGraphType>>(
                        "EmptyPotDetectionCoilSafetyParam-InductionCoilConfig-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionCoilConfigs
                                .Where(x => x.InductionCoilConfig != null && ids.Contains((Guid)x.InductionCoilConfig))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionCoilConfig!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.InductionCoilConfigs);
                });
            
        }
    }
}
            