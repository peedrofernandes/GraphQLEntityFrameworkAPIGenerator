
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
    public partial class PrmGianyLliToFeedbackGraphType : ObjectGraphType<PrmGianyLliToFeedback>
    {
        public PrmGianyLliToFeedbackGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NValues, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SwitchInputValues, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.SwitchOutputValues, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.SearchMethod, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            