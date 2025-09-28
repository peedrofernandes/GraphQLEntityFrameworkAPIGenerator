
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
    public partial class CycleOptionsPrmFormulaGraphType : ObjectGraphType<CycleOptionsPrmFormula>
    {
        public CycleOptionsPrmFormulaGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FormulaParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfInputs, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Constant, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.InputId1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Coefficient1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.InputId2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Coefficient2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.InputId3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Coefficient3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.InputId4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Coefficient4, type: typeof(FloatGraphType), nullable: False);
            
        }
    }
}
            