
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
    public partial class UiboolOperatorGraphType : ObjectGraphType<UiboolOperator>
    {
        public UiboolOperatorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UioperatorId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Uioperator, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            