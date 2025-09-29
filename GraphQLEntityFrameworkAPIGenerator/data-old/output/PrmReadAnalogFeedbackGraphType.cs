
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
    public partial class PrmReadAnalogFeedbackGraphType : ObjectGraphType<PrmReadAnalogFeedback>
    {
        public PrmReadAnalogFeedbackGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.WaitTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SamplingDelay, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            