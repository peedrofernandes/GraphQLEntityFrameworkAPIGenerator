
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
    public partial class PrmPilotUniversalMotorGraphType : ObjectGraphType<PrmPilotUniversalMotor>
    {
        public PrmPilotUniversalMotorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TachoIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FbkDebounceTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TapfieldSuspendTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TachoTimeout, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.AngleFbkThreshold, type: typeof(ShortGraphType), nullable: False);
            
        }
    }
}
            