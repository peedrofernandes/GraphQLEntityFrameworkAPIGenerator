
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
    public partial class PrmPilotPwmGraphType : ObjectGraphType<PrmPilotPwm>
    {
        public PrmPilotPwmGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.F, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.A, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.BaseFrequency, type: typeof(IdGraphType), nullable: False);
			Field(t => t.SpeedMin, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.DeltaMax, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.DeltaMin, type: typeof(ShortGraphType), nullable: False);
            
        }
    }
}
            