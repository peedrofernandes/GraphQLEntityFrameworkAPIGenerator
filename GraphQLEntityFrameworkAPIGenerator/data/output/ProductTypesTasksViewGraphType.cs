
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
    public partial class ProductTypesTasksViewGraphType : ObjectGraphType<ProductTypesTasksView>
    {
        public ProductTypesTasksViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProductTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ProductTypeDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.ProductTypeTaskId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Id, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Task, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            