
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
    public partial class PrmReadSrtouchKeyGraphType : ObjectGraphType<PrmReadSrtouchKey>
    {
        public PrmReadSrtouchKeyGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SrtouchControllerIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SrtouchKeyIndex, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            