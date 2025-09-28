
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
    public partial class PrmReadAnalogGraphType : ObjectGraphType<PrmReadAnalog>
    {
        public PrmReadAnalogGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MinimumAdValue, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.MaximumAdValue, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.NominalAdValueReference, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.Hysteresis, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.PreOffset, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.PostOffset, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.ZeroLevelReference, type: typeof(ShortGraphType), nullable: True);
            
        }
    }
}
            