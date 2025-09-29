
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
    public partial class EepromCycleHeadingsExtendedViewGraphType : ObjectGraphType<EepromCycleHeadingsExtendedView>
    {
        public EepromCycleHeadingsExtendedViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProjectId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SelectorConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SelectorId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SelectorDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Target, type: typeof(IdGraphType), nullable: True);
			Field(t => t.CyclePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.EnteringCycle, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.SelectorConditionId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.CycleId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CycleDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.AfterFaultRestore, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.BackupRestore, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Pause, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CycleName, type: typeof(IdGraphType), nullable: False);
			Field(t => t.CycleHeading, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleSubHeading, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleGroup, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            