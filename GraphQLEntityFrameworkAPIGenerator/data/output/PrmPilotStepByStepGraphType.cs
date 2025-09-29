
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
    public partial class PrmPilotStepByStepGraphType : ObjectGraphType<PrmPilotStepByStep>
    {
        public PrmPilotStepByStepGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumSteps, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.NumSpeeds, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.AdjSteps, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.P, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.I, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.NumSeq, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Steps, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.Seqs, type: typeof(IdGraphType), nullable: False);
			Field(t => t.NumPositions, type: typeof(ShortGraphType), nullable: False);
            
        }
    }
}
            