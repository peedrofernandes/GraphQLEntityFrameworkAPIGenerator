
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
    public partial class EepromExpansionUisequenceConfigurationSupportViewGraphType : ObjectGraphType<EepromExpansionUisequenceConfigurationSupportView>
    {
        public EepromExpansionUisequenceConfigurationSupportViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProjectId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DisplayId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Board, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UisequenceConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UisequenceId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SequenceIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SequenceDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.GireadTypeId, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.GireadTypePosition, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Givalue, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.UseNewBuffer, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            