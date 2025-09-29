
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
    public partial class PrmPilotVentGraphType : ObjectGraphType<PrmPilotVent>
    {
        public PrmPilotVentGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.StructureVersion, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OnPositionDetectionMethod, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OffPositionFeedbackGiindex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OnPositionFeedbackGiindex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OffToOnPositionTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.OffToOnPositionZcnumber, type: typeof(IdGraphType), nullable: False);
			Field(t => t.OffPositionDetectionTimeout, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.OnPositionDetectionTimeout, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.OffPositionDetectionMethod, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OnToOffPositionTimeOrZcNumber, type: typeof(IdGraphType), nullable: False);
            
        }
    }
}
            