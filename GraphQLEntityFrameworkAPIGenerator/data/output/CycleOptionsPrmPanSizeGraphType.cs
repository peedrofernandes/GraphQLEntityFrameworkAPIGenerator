
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
    public partial class CycleOptionsPrmPanSizeGraphType : ObjectGraphType<CycleOptionsPrmPanSize>
    {
        public CycleOptionsPrmPanSizeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PanSizeOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PanSizeDefault, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Option8Present, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Option9Present, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Option10Present, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Option8x8Present, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Option9x9Present, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Option9x13Present, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            