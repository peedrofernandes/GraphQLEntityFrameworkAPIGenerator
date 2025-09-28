
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
    public partial class VwVisualFunctionConfigurationGraphType : ObjectGraphType<VwVisualFunctionConfiguration>
    {
        public VwVisualFunctionConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.GireadTypePosition, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.FunctionLabel, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Compulsory, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Monitored, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.ToMainBoard, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.FunctionFlags, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RegulationFlags, type: typeof(IdGraphType), nullable: False);
			Field(t => t.SlaveInputTypePosition, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.IgnoreVisualRegulationTable, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.FactoryRestoreIndex, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            