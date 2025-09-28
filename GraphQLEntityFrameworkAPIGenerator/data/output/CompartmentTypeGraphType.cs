
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
    public partial class CompartmentTypeGraphType : ObjectGraphType<CompartmentType>
    {
        public CompartmentTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CompartmentTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CompartmentTypeDsc, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            