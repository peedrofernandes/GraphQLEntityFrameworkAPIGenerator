
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
    public partial class ProductTypesHighStatementsViewGraphType : ObjectGraphType<ProductTypesHighStatementsView>
    {
        public ProductTypesHighStatementsViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProductTypeDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Priority, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OpCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.F0, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.F1, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Statement, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            