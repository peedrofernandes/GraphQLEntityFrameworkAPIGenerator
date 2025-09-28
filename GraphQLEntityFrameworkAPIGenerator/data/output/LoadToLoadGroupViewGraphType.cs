
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
    public partial class LoadToLoadGroupViewGraphType : ObjectGraphType<LoadToLoadGroupView>
    {
        public LoadToLoadGroupViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LoadDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.LoadGroupDsc, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            