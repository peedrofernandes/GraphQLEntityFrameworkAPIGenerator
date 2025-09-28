
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
    public partial class VwVisualGenericInputConfigurationGraphType : ObjectGraphType<VwVisualGenericInputConfiguration>
    {
        public VwVisualGenericInputConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.GireadTypePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LlireadTypePosition, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            