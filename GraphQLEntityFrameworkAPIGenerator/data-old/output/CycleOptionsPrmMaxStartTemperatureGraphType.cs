
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
    public partial class CycleOptionsPrmMaxStartTemperatureGraphType : ObjectGraphType<CycleOptionsPrmMaxStartTemperature>
    {
        public CycleOptionsPrmMaxStartTemperatureGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MaxTempOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MaximumStartTemperature, type: typeof(DoubleGraphType), nullable: False);
            
        }
    }
}
            