
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
    public partial class PrmReadInputCaptureGraphType : ObjectGraphType<PrmReadInputCapture>
    {
        public PrmReadInputCaptureGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.FaultTimeout, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.SamplingTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.MinimumFrequency, type: typeof(IdGraphType), nullable: False);
			Field(t => t.MaximumFrequency, type: typeof(IdGraphType), nullable: False);
			Field(t => t.MinimumDuty, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MaximumDuty, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FilterFrequency, type: typeof(IdGraphType), nullable: False);
			Field(t => t.FilterDuty, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.BasePeriod, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            