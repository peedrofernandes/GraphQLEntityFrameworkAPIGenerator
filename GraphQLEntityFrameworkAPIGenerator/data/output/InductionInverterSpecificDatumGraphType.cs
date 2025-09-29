
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
    public partial class InductionInverterSpecificDatumGraphType : ObjectGraphType<InductionInverterSpecificDatum>
    {
        public InductionInverterSpecificDatumGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionInverterSpecificDataId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.SnubberCapacitance, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ResonantCapacitance, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.GateDelayOffHighSideIgbt, type: typeof(IdGraphType), nullable: False);
			Field(t => t.GateDelayOffLowSideIgbt, type: typeof(IdGraphType), nullable: False);
			Field(t => t.MaxNominalInverterPowerFactor, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MaxNominalInverterPowerFactorBooster, type: typeof(FloatGraphType), nullable: False);
            
            Field<InductionCoilConfigGraphType, InductionCoilConfig>("InductionCoilConfigs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilConfigGraphType>>(
                        "InductionInverterSpecificDatum-InductionCoilConfig-loader",
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
            