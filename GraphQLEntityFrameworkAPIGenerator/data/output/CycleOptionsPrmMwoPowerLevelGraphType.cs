
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
    public partial class CycleOptionsPrmMwoPowerLevelGraphType : ObjectGraphType<CycleOptionsPrmMwoPowerLevel>
    {
        public CycleOptionsPrmMwoPowerLevelGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MwoPowerLevelsOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PowerLevelTypeSelection, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLevelDefault, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Min, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Max, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Step, type: typeof(IdGraphType), nullable: False);
			Field(t => t.NumberOfLevels, type: typeof(ShortGraphType), nullable: False);
            
        }
    }
}
            