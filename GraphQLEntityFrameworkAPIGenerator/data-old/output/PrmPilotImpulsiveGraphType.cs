
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
    public partial class PrmPilotImpulsiveGraphType : ObjectGraphType<PrmPilotImpulsive>
    {
        public PrmPilotImpulsiveGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MaxPulseNumber, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PulseTiming, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UnlockWaitTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.IsDoorSensing, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PulseWidth, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            