
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
    public partial class CycleOptionsBrowningGraphType : ObjectGraphType<CycleOptionsBrowning>
    {
        public CycleOptionsBrowningGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.BrowningOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DefaultSelection, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.High, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Medium, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Low, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            