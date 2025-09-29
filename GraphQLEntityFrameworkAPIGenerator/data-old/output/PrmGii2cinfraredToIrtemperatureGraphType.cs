
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
    public partial class PrmGii2cinfraredToIrtemperatureGraphType : ObjectGraphType<PrmGii2cinfraredToIrtemperature>
    {
        public PrmGii2cinfraredToIrtemperatureGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Emissivity, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.RemoveThresholdVdd, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.DebounceThresholdVdd, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.DissociateInputVdd, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.RemoveThresholdTa, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.DebounceThresholdTa, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.DissociateInputTa, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.RemoveThresholdTo, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.DebounceThresholdTo, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.DissociateInputTo, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.IrCompensationCoefficient0, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.IrCompensationCoefficient1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.IrCompensationCoefficient2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.IrCompensationCoefficient3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.IrCompensationCoefficient4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.IrCompensationCoefficient5, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.IrCompensationCoefficient6, type: typeof(FloatGraphType), nullable: False);
            
        }
    }
}
            