
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
    public partial class CycleOptionsPrmTipGraphType : ObjectGraphType<CycleOptionsPrmTip>
    {
        public CycleOptionsPrmTipGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.TipsOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfTips, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Key1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Key2, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Value2, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Key3, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Value3, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Key4, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Value4, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Key5, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Value5, type: typeof(IdGraphType), nullable: True);
            
        }
    }
}
            