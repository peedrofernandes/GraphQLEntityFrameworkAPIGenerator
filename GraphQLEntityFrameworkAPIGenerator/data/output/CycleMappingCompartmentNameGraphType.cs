
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
    public partial class CycleMappingCompartmentNameGraphType : ObjectGraphType<CycleMappingCompartmentName>
    {
        public CycleMappingCompartmentNameGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CompartmentKeyName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.CompartmentDisplayName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            