
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
    public partial class CycleOptionsPrmMeatProbeTemperatureGraphType : ObjectGraphType<CycleOptionsPrmMeatProbeTemperature>
    {
        public CycleOptionsPrmMeatProbeTemperatureGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MeatProbeOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TempSelectionCelsiusMin, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempSelectionCelsiusDefault, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempSelectionCelsiusMax, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.StepCelsius, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StepFahrenheit, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            