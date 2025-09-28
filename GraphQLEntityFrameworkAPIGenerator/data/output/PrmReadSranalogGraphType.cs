
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
    public partial class PrmReadSranalogGraphType : ObjectGraphType<PrmReadSranalog>
    {
        public PrmReadSranalogGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MinimumAdValue, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.MaximumAdValue, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.NominalAdValueReference, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Hysteresis, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PreOffset, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.PostOffset, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.ZeroLevelReference, type: typeof(ShortGraphType), nullable: False);
            
        }
    }
}
            