
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
    public partial class PrmReadVirtualDigitalGraphType : ObjectGraphType<PrmReadVirtualDigital>
    {
        public PrmReadVirtualDigitalGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.InputIndex0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputIndex1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputIndex2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputIndex3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadTypeId, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            