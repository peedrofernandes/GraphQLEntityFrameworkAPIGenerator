
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
    public partial class EepromPauseStateCycleViewGraphType : ObjectGraphType<EepromPauseStateCycleView>
    {
        public EepromPauseStateCycleViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProjectId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SelectorId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.StateCyclePosition, type: typeof(IdGraphType), nullable: False);
			Field(t => t.StateCycleDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.PhasePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MacroId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MacroDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.StatementPosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Step, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.T, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.N, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.StatementId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.LowStatementId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.Target, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Priority, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConditionId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.TimeEstimationId, type: typeof(IdGraphType), nullable: True);
			Field(t => t.CycleNameId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.HighStatementId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.StepLabel, type: typeof(StringGraphType), nullable: True);
            
        }
    }
}
            