
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
    public partial class InductionCoilInformationViewGraphType : ObjectGraphType<InductionCoilInformationView>
    {
        public InductionCoilInformationViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Ipc, type: typeof(IdGraphType), nullable: True);
			Field(t => t.ZeroCrossChannel, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Inverter, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Channel, type: typeof(IdGraphType), nullable: False);
			Field(t => t.CoilDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.CoilPowerTableDesc, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            