
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
    public partial class FaultGraphType : ObjectGraphType<Fault>
    {
        public FaultGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FaultId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FaultName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.NeedSpecificParams, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            