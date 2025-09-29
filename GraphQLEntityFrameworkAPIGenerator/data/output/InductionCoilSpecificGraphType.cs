
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
    public partial class InductionCoilSpecificGraphType : ObjectGraphType<InductionCoilSpecific>
    {
        public InductionCoilSpecificGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionCoilSpecificId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ResonanceCapacitance, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.MaxCurrentNormal, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.MaxCurrentBooster, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.BoosterPowerThreshold, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.PanettoneElectricThreshold, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.PanDetectedThreshold, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PanNotDetectedThreshold, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MaxNominalLoadAveragePower, type: typeof(IdGraphType), nullable: False);
			Field(t => t.MaxNominalIgbtPeakTurnOffCurrent, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MaxNominalLoadAveragePowerBooster, type: typeof(IdGraphType), nullable: False);
			Field(t => t.MaxNominalIgbtPeakTurnOffCurrentBooster, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MaxNominalLoadRmsCurrent, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MaxNominalLoadRmsCurrentBooster, type: typeof(FloatGraphType), nullable: False);
            
            Field<InductionCoilConfigGraphType, InductionCoilConfig>("InductionCoilConfigs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilConfigGraphType>>(
                        "InductionCoilSpecific-InductionCoilConfig-loader",
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
            