
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
    public partial class PrmPilotWaxGraphType : ObjectGraphType<PrmPilotWax>
    {
        public PrmPilotWaxGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MaxFaultWaitTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.MaxFaultWaitTimeClose, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.DoorLockFilterTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DoorLockOnTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DoorLockOffTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IsDoorSensing, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            