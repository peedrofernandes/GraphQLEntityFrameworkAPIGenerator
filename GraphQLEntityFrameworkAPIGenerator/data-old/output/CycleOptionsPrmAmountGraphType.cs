
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
    public partial class CycleOptionsPrmAmountGraphType : ObjectGraphType<CycleOptionsPrmAmount>
    {
        public CycleOptionsPrmAmountGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.AmountOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.AmountMin, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.AmountDefault, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.AmountMax, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.AmountUnits, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Step, type: typeof(FloatGraphType), nullable: False);
            
        }
    }
}
            