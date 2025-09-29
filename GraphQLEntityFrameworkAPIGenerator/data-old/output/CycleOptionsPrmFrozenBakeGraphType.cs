
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
    public partial class CycleOptionsPrmFrozenBakeGraphType : ObjectGraphType<CycleOptionsPrmFrozenBake>
    {
        public CycleOptionsPrmFrozenBakeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FrozenBakeParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfTimeBands, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AddTime1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AddTime2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AddTime3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AddTime4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AddTime5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AddTime6, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time6, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AddTime7, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time7, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AddTime8, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time8, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AddTime9, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time9, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AddTime10, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            