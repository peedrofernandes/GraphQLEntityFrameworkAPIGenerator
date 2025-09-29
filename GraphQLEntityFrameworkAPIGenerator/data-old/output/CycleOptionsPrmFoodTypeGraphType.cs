
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
    public partial class CycleOptionsPrmFoodTypeGraphType : ObjectGraphType<CycleOptionsPrmFoodType>
    {
        public CycleOptionsPrmFoodTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FoodTypeOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfOptions, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DefaultFoodType, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            