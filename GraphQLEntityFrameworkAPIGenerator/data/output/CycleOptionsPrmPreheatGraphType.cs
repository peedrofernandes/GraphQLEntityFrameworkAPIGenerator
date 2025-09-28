
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
    public partial class CycleOptionsPrmPreheatGraphType : ObjectGraphType<CycleOptionsPrmPreheat>
    {
        public CycleOptionsPrmPreheatGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PreheatOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UserEditable, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PreheatDefault, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NoPreheatOptionPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PreheatOptionPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.RapidPreheatOptionPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DisplayRampStepF, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DisplayRampStepC, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            