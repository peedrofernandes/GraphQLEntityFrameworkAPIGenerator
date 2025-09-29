
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
    public partial class CycleOptionsPrmDelayGraphType : ObjectGraphType<CycleOptionsPrmDelay>
    {
        public CycleOptionsPrmDelayGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DelayOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DelayMin, type: typeof(IdGraphType), nullable: False);
			Field(t => t.DelayDefault, type: typeof(IdGraphType), nullable: False);
			Field(t => t.DelayMax, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Step, type: typeof(IdGraphType), nullable: False);
            
        }
    }
}
            