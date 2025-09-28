
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
    public partial class EepromSortedFaulIdlistViewGraphType : ObjectGraphType<EepromSortedFaulIdlistView>
    {
        public EepromSortedFaulIdlistViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Priority, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            