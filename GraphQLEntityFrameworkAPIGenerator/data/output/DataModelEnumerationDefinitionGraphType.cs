
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
    public partial class DataModelEnumerationDefinitionGraphType : ObjectGraphType<DataModelEnumerationDefinition>
    {
        public DataModelEnumerationDefinitionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DataModelDefinitionDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.EnumId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.EnumDescription, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            