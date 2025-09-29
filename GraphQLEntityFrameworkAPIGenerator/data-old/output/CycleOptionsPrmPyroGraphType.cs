
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
    public partial class CycleOptionsPrmPyroGraphType : ObjectGraphType<CycleOptionsPrmPyro>
    {
        public CycleOptionsPrmPyroGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PyroOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PyroCompletePercent, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CleanBackToBackTime, type: typeof(IdGraphType), nullable: False);
            
        }
    }
}
            