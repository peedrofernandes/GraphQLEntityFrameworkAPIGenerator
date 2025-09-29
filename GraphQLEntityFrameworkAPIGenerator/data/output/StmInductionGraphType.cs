
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
    public partial class StmInductionGraphType : ObjectGraphType<StmInduction>
    {
        public StmInductionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Level, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Mode, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Wattage, type: typeof(ShortGraphType), nullable: True);
            
        }
    }
}
            