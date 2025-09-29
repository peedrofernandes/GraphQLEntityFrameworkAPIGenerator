
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
    public partial class EepromTimeEstimationDetailsViewGraphType : ObjectGraphType<EepromTimeEstimationDetailsView>
    {
        public EepromTimeEstimationDetailsViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ModifiersLabel, type: typeof(StringGraphType), nullable: False);
			Field(t => t.ModifiersId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ProjectId, type: typeof(GuidGraphType), nullable: False);
            
        }
    }
}
            