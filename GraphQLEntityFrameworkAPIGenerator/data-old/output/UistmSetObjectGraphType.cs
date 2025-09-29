
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
    public partial class UistmSetObjectGraphType : ObjectGraphType<UistmSetObject>
    {
        public UistmSetObjectGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ProductTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Type, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Idx, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Data, type: typeof(IdGraphType), nullable: False);
			Field(t => t.VariableIndex, type: typeof(IdGraphType), nullable: False);
			Field(t => t.VariableOffset, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LedIndex, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.GroupIndex, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Intensity, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VariableGroups, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VisualValueFlag, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitfieldIndexFlag, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            