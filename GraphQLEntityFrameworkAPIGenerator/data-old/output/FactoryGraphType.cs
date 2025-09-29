
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
    public partial class FactoryGraphType : ObjectGraphType<Factory>
    {
        public FactoryGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FactoryId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FactoryDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.FactoryCode, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            