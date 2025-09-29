
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
    public partial class EepromCyclesViewGraphType : ObjectGraphType<EepromCyclesView>
    {
        public EepromCyclesViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProjectId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SelectorId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Target, type: typeof(IdGraphType), nullable: True);
			Field(t => t.SelectorDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.CyclePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CycleDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.ProgrammingMacroId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.DelayMacroId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.PauseMacroId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.EndMacroId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ProgrammingUimacroId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.DelayUimacroId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.PauseUimacroId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.EndUimacroId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.RunUimacroId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.CyclesTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.CycleTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Priority, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConditionId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.CycleNameId, type: typeof(IdGraphType), nullable: False);
            
        }
    }
}
            