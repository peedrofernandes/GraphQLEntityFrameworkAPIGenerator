
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
    public partial class CyclesToStatementGraphType : ObjectGraphType<CyclesToStatement>
    {
        public CyclesToStatementGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Time, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.TimeEstModDescription, type: typeof(StringGraphType), nullable: True);
			Field(t => t.UseDirectModifier, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.Uimacro, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.MacrosIndex, type: typeof(IdGraphType), nullable: True);
			Field(t => t.StatementsIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.T, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CycleDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.MacroDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.PhaseName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.N, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CycleRev, type: typeof(IdGraphType), nullable: False);
			Field(t => t.PhaseRev, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Pause, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.BackupRestore, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.HasTimeEstModifiers, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.ModifiersLabel, type: typeof(StringGraphType), nullable: True);
			Field(t => t.OpCode, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.F0, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.F1, type: typeof(BoolGraphType), nullable: True);
            
        }
    }
}
            