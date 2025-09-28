
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
    public partial class CycleOptionsPrmAmountDiscreteGraphType : ObjectGraphType<CycleOptionsPrmAmountDiscrete>
    {
        public CycleOptionsPrmAmountDiscreteGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.AmountDiscreteOptionId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfDecimals, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Units, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfLevels, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DefaultAmount, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Amount1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Amount2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Amount3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Amount4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Amount5, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Amount6, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Amount7, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Amount8, type: typeof(FloatGraphType), nullable: False);
            
        }
    }
}
            