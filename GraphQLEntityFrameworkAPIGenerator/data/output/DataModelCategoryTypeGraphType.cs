
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
    public partial class DataModelCategoryTypeGraphType : ObjectGraphType<DataModelCategoryType>
    {
        public DataModelCategoryTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DataModelCategoryTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DataModelCategoryTypeDescription, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            