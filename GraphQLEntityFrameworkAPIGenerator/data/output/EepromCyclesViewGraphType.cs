
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
    public partial class EepromCyclesViewGraphType : ObjectGraphType<EepromCyclesView>
    {
        public EepromCyclesViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Target, type: typeof(IdGraphType), nullable: True);
			Field(t => t.SelectorDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.CyclePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.CyclesTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Priority, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            