
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
    public partial class CycleOptionsPrmSizeGraphType : ObjectGraphType<CycleOptionsPrmSize>
    {
        public CycleOptionsPrmSizeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SizeOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SizeSelectionMin, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SizeSelectionDefault, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SizeSelectionMax, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.UnitsAreMetric, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.Step, type: typeof(FloatGraphType), nullable: False);
            
        }
    }
}
            