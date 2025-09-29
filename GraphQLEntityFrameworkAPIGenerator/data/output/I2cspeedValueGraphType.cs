
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
    public partial class I2cspeedValueGraphType : ObjectGraphType<I2cspeedValue>
    {
        public I2cspeedValueGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.I2cspeedId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.I2cdescription, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            