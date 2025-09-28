
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
    public partial class PrmReadConductivitySensorGraphType : ObjectGraphType<PrmReadConductivitySensor>
    {
        public PrmReadConductivitySensorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.FaultTimeout, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SignalTmax, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.SignalTmin, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Period, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Filter, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OutputUnitMeasure, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            