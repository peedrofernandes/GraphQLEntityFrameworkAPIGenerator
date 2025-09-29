
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
    public partial class DataModelVersionTypeGraphType : ObjectGraphType<DataModelVersionType>
    {
        public DataModelVersionTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DataModelVersionTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DataModelVersionTypeDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.DataModelApi, type: typeof(IdGraphType), nullable: False);
            
        }
    }
}
            