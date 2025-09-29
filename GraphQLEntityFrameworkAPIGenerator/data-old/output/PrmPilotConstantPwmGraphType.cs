
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
    public partial class PrmPilotConstantPwmGraphType : ObjectGraphType<PrmPilotConstantPwm>
    {
        public PrmPilotConstantPwmGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.BaseFrequency, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ProfileNumber, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MaxDutyStep, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.MinDutyStep, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ValidMinDuty, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.StepIntervalTime, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.EnableDutyStep, type: typeof(BoolGraphType), nullable: True);
            
        }
    }
}
            