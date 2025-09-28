
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
    public partial class PrmPilotAnalogGraphType : ObjectGraphType<PrmPilotAnalog>
    {
        public PrmPilotAnalogGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MinPercent, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MaxPercent, type: typeof(FloatGraphType), nullable: False);
            
        }
    }
}
            