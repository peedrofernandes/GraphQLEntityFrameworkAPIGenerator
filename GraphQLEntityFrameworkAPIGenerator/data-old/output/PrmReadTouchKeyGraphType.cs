
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
    public partial class PrmReadTouchKeyGraphType : ObjectGraphType<PrmReadTouchKey>
    {
        public PrmReadTouchKeyGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TouchControllerIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TouchKeyIndex, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            