
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
    public partial class EepromGenericInputConfigurationViewGraphType : ObjectGraphType<EepromGenericInputConfigurationView>
    {
        public EepromGenericInputConfigurationViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadTypePos, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Board, type: typeof(IdGraphType), nullable: False);
			Field(t => t.IsReadTypeSafetyRelevant, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsInputSafetyRelevant, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            