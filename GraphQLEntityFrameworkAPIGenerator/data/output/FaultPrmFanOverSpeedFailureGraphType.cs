
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
    public partial class FaultPrmFanOverSpeedFailureGraphType : ObjectGraphType<FaultPrmFanOverSpeedFailure>
    {
        public FaultPrmFanOverSpeedFailureGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeedGi, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MaximumFanSpeed, type: typeof(ShortGraphType), nullable: False);
            
        }
    }
}
            