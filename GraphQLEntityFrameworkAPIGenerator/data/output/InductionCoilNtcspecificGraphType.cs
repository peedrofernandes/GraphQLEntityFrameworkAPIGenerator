
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
    public partial class InductionCoilNtcspecificGraphType : ObjectGraphType<InductionCoilNtcspecific>
    {
        public InductionCoilNtcspecificGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionCoilNtcspecificId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.StuckExecutionTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StuckValidationTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SafetyDebounceTime, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ShortDebounceTime, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.OpenDebounceTime, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ShortThresholdMax, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.OpenThresholdMin, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.StuckWindowMin, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.StuckWindowMax, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.StuckExitDelta, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.SafetyThreshold, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.SafetyHysteresis, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.StuckExitDeltaCelsius, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SafetyHysteresisCelsius, type: typeof(FloatGraphType), nullable: False);
            
            Field<InductionCoilConfigGraphType, InductionCoilConfig>("InductionCoilConfigs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilConfigGraphType>>(
                        "InductionCoilNtcspecific-InductionCoilConfig-loader",
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
            