
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
    public partial class UistmSetFunctionGraphType : ObjectGraphType<UistmSetFunction>
    {
        public UistmSetFunctionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.FunctionLabel, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DefaultIdx, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DefaultFlag, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.MinIdx, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MinFlag, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.MaxIdx, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MaxFlag, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CurrentIdx, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CurrentFlag, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Disable, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DisableFlag, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Freeze, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.FreezeFlag, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.AfterStart, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.AfterStartFlag, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Confirm, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ConfirmFlag, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Inversion, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.InversionFlag, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            