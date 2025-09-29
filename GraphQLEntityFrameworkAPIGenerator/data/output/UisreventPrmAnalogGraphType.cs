
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
    public partial class UisreventPrmAnalogGraphType : ObjectGraphType<UisreventPrmAnalog>
    {
        public UisreventPrmAnalogGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SranalogInputMinimum, type: typeof(IdGraphType), nullable: False);
			Field(t => t.SranalogInputMaximum, type: typeof(IdGraphType), nullable: False);
            
        }
    }
}
            