
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
    public partial class CycleOptionsPrmWeightRangeGraphType : ObjectGraphType<CycleOptionsPrmWeightRange>
    {
        public CycleOptionsPrmWeightRangeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.WeightRangesOptionId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Step, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WeightDefault, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.NumberOfLevels, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Weight1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Weight2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Weight3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Weight4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Weight5, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Weight6, type: typeof(FloatGraphType), nullable: False);
            
        }
    }
}
            