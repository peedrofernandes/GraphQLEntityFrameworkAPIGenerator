
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
    public partial class EepromEndStateCycleViewGraphType : ObjectGraphType<EepromEndStateCycleView>
    {
        public EepromEndStateCycleViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.StateCyclePosition, type: typeof(IdGraphType), nullable: False);
			Field(t => t.StateCycleDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.PhasePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MacroDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.StatementPosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Step, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.T, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.N, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Target, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Priority, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StepLabel, type: typeof(StringGraphType), nullable: True);
            
        }
    }
}
            