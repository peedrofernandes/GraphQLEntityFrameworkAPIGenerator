
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
    public partial class EepromExpansionUigenericInputConfigurationViewGraphType : ObjectGraphType<EepromExpansionUigenericInputConfigurationView>
    {
        public EepromExpansionUigenericInputConfigurationViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProjectId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DisplayId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Board, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UigenericInputConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UigenericInputDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UiinputId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.GireadTypePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LlireadTypePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ParametersId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.IsInputSafetyRelevant, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsReadTypeSafetyRelevant, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.LlireadTypeId, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            