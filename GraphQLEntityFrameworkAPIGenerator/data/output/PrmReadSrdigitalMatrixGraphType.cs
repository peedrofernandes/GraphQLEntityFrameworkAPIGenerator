
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
    public partial class PrmReadSrdigitalMatrixGraphType : ObjectGraphType<PrmReadSrdigitalMatrix>
    {
        public PrmReadSrdigitalMatrixGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Inverted, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PullUp, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.StrobePin, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            