
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
    public partial class CycleOptionsPrmConvectConvertGraphType : ObjectGraphType<CycleOptionsPrmConvectConvert>
    {
        public CycleOptionsPrmConvectConvertGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ConvectConversionOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TimeAdjustValue, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureAdjustValue, type: typeof(FloatGraphType), nullable: False);
            
        }
    }
}
            