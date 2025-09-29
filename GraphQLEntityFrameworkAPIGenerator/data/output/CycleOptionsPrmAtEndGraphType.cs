
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
    public partial class CycleOptionsPrmAtEndGraphType : ObjectGraphType<CycleOptionsPrmAtEnd>
    {
        public CycleOptionsPrmAtEndGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.AtEndOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.AtEndDefault, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TurnOffOptionPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HoldTempOptionPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.KeepWarmOptionPresent, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            