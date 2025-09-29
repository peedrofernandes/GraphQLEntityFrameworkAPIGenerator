
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
    public partial class InductionIpcSpecificDatumGraphType : ObjectGraphType<InductionIpcSpecificDatum>
    {
        public InductionIpcSpecificDatumGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionIpcSpecificDataId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.PanInactiveCounterTimeout, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.FrequencyLimitSlackGain, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.FrequencyIncreaseGainCritical, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.FrequencyIncreaseGainOverload, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.FrequencyDecreaseGainRelax, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.IirSmoothingFactor, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.IirValidationMinDebounceSteps, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MainsLineUnderVoltageFailureThreshold, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MainsLineOverVoltageFailureThreshold, type: typeof(FloatGraphType), nullable: False);
            
            Field<InductionIpcdetailGraphType, InductionIpcdetail>("InductionIpcdetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionIpcdetailGraphType>>(
                        "InductionIpcSpecificDatum-InductionIpcdetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionIpcdetails
                                .Where(x => x.InductionIpcdetail != null && ids.Contains((Guid)x.InductionIpcdetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionIpcdetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.InductionIpcdetails);
                });
            
        }
    }
}
            