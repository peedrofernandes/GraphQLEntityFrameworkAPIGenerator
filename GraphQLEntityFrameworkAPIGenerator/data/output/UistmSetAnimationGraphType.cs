
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
    public partial class UistmSetAnimationGraphType : ObjectGraphType<UistmSetAnimation>
    {
        public UistmSetAnimationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Ledpattern, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Ledgroup, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.AnimationParameterIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfRepeats, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PauseTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.FlagInfiniteRepeats, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.FlagOneShotAnimation, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.FlagInfinitePauseTime, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            