
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
    public partial class EepromUisequenceConfigurationViewGraphType : ObjectGraphType<EepromUisequenceConfigurationView>
    {
        public EepromUisequenceConfigurationViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SequenceIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SequenceDescription, type: typeof(StringGraphType), nullable: False);
			Field(t => t.GireadTypePosition, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Givalue, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.UseNewBuffer, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.StepIndex, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.StepDescription, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Timer, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Timeout, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DisableFunctionLayer, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.FeedbackCode, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ConditionIndex, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ConditionGireadTypePos, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ConditionGivalue, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Board, type: typeof(IdGraphType), nullable: False);
            
        }
    }
}
            