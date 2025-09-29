
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
    public partial class MachineConfigTableAttributeGraphType : ObjectGraphType<MachineConfigTableAttribute>
    {
        public MachineConfigTableAttributeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(IdGraphType), nullable: False);
			Field(t => t.IsMandatory, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.AllowRepeat, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            