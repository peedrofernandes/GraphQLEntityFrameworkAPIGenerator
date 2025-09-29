
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
    public partial class StmActivateTaskGraphType : ObjectGraphType<StmActivateTask>
    {
        public StmActivateTaskGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TaskCode, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TaskParamsPosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TaskParamsId, type: typeof(GuidGraphType), nullable: True);
            
        }
    }
}
            