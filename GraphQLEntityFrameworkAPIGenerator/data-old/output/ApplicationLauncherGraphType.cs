
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
    public partial class ApplicationLauncherGraphType : ObjectGraphType<ApplicationLauncher>
    {
        public ApplicationLauncherGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ApplicationName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Environment, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Enabled, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            