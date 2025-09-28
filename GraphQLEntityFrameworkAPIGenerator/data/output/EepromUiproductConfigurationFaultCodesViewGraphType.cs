
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
    public partial class EepromUiproductConfigurationFaultCodesViewGraphType : ObjectGraphType<EepromUiproductConfigurationFaultCodesView>
    {
        public EepromUiproductConfigurationFaultCodesViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Code, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SubCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.EngineeringCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Priority, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            