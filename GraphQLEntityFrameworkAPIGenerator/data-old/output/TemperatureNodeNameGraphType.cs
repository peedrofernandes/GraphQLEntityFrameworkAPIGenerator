
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
    public partial class TemperatureNodeNameGraphType : ObjectGraphType<TemperatureNodeName>
    {
        public TemperatureNodeNameGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.TemperatureNodeNamesCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureNodeNamesDescription, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            