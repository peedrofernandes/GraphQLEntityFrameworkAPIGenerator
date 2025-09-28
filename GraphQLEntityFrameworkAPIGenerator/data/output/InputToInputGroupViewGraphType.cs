
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
    public partial class InputToInputGroupViewGraphType : ObjectGraphType<InputToInputGroupView>
    {
        public InputToInputGroupViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InputDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.InputGroupDesc, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            