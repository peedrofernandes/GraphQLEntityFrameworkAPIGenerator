
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
    public partial class EepromFaultSelectorViewGraphType : ObjectGraphType<EepromFaultSelectorView>
    {
        public EepromFaultSelectorViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProjectId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Target, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MacroId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MacroDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.StatementPosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Step, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.T, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.N, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.StatementId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.LowStatementId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.TimeEstimationId, type: typeof(IdGraphType), nullable: True);
			Field(t => t.HighStatementId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.FaultId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StepLabel, type: typeof(StringGraphType), nullable: True);
            
        }
    }
}
            