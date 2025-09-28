
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
    public partial class CycleOptionsDonenessGraphType : ObjectGraphType<CycleOptionsDoneness>
    {
        public CycleOptionsDonenessGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DonenessOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DefaultSelection, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Well, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.MediumWell, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Medium, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.MediumRare, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Rare, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            