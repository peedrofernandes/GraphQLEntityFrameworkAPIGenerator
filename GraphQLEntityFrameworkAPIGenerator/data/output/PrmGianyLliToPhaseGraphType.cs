
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
    public partial class PrmGianyLliToPhaseGraphType : ObjectGraphType<PrmGianyLliToPhase>
    {
        public PrmGianyLliToPhaseGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Trigger, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Iirweight, type: typeof(ShortGraphType), nullable: False);
            
        }
    }
}
            