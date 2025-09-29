
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
    public partial class FkViewGraphType : ObjectGraphType<FkView>
    {
        public FkViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrimaryKeyTable, type: typeof(StringGraphType), nullable: True);
			Field(t => t.PrimaryKeyField, type: typeof(StringGraphType), nullable: True);
			Field(t => t.SecondaryKeyTable, type: typeof(StringGraphType), nullable: True);
			Field(t => t.SecondaryKeyField, type: typeof(StringGraphType), nullable: True);
            
        }
    }
}
            