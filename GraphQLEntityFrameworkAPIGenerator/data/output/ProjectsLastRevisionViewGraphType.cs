
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
    public partial class ProjectsLastRevisionViewGraphType : ObjectGraphType<ProjectsLastRevisionView>
    {
        public ProjectsLastRevisionViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.IndustrialCode, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ProductType, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ProductCode, type: typeof(StringGraphType), nullable: True);
			Field(t => t.LastProductRevision, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            