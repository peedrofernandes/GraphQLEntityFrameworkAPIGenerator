
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
    public partial class EepromUisequenceConfigurationSupportViewGraphType : ObjectGraphType<EepromUisequenceConfigurationSupportView>
    {
        public EepromUisequenceConfigurationSupportViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SequenceIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SequenceDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.GireadTypePosition, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Givalue, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.UseNewBuffer, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            