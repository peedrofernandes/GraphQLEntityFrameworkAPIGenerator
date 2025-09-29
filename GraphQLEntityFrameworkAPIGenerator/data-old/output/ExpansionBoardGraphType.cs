
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
    public partial class ExpansionBoardGraphType : ObjectGraphType<ExpansionBoard>
    {
        public ExpansionBoardGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ExpansionBoardId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ExpansionBoard1, type: typeof(StringGraphType), nullable: False);
			Field(t => t.IsHmi, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            