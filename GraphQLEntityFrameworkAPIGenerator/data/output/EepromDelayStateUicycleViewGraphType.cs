
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
    public partial class EepromDelayStateUicycleViewGraphType : ObjectGraphType<EepromDelayStateUicycleView>
    {
        public EepromDelayStateUicycleViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.StateCyclePosition, type: typeof(IdGraphType), nullable: False);
			Field(t => t.StateCycleDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.PhasePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MacroDescription, type: typeof(StringGraphType), nullable: True);
			Field(t => t.StatementPosition, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Step, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.T, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.N, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.OpCode, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.F0, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.F1, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.Target, type: typeof(IdGraphType), nullable: True);
            
        }
    }
}
            