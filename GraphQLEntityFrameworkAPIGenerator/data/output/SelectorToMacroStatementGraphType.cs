
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
    public partial class SelectorToMacroStatementGraphType : ObjectGraphType<SelectorToMacroStatement>
    {
        public SelectorToMacroStatementGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.MacroPrefix, type: typeof(StringGraphType), nullable: False);
			Field(t => t.MacroIndex, type: typeof(IdGraphType), nullable: False);
			Field(t => t.StatementsIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.T, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.MacroDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.N, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PhaseRev, type: typeof(IdGraphType), nullable: False);
			Field(t => t.OpCode, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.F0, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.F1, type: typeof(BoolGraphType), nullable: True);
            
        }
    }
}
            