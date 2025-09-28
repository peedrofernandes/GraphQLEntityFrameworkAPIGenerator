
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
    public partial class ProductTypesVariablesVariableGroupsViewGraphType : ObjectGraphType<ProductTypesVariablesVariableGroupsView>
    {
        public ProductTypesVariablesVariableGroupsViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProductTypeDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Variable, type: typeof(StringGraphType), nullable: False);
			Field(t => t.DataType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IsBitmap, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsWritable, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.VariableGroupDescription, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            