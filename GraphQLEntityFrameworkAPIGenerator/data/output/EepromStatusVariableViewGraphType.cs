
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
    public partial class EepromStatusVariableViewGraphType : ObjectGraphType<EepromStatusVariableView>
    {
        public EepromStatusVariableViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProjectId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DisplayId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.StatusVariableId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.StatusVariables, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.StatusVariableGroups, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.ProductTypeId, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            