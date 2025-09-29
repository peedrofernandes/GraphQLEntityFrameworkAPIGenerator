
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
    public partial class FaultCodeGraphType : ObjectGraphType<FaultCode>
    {
        public FaultCodeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FaultCode1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FaultDescription, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            