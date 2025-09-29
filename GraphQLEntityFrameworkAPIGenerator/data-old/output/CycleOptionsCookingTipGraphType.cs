
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
    public partial class CycleOptionsCookingTipGraphType : ObjectGraphType<CycleOptionsCookingTip>
    {
        public CycleOptionsCookingTipGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.TipKeyId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TipValueId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TipKeyDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.TipValueDescription, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            