
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
    public partial class PrmPilotMagnetronGraphType : ObjectGraphType<PrmPilotMagnetron>
    {
        public PrmPilotMagnetronGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.StructureVersion, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TurboEnable, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.AcMainsSamePhase, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.MwFbActiveHigh, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.TurboOnOffDelay, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MainsPinIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MicrowaveFeedbackPinIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MicrowaveDoorInput, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            