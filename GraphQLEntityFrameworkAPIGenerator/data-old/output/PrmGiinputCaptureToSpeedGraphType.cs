
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
    public partial class PrmGiinputCaptureToSpeedGraphType : ObjectGraphType<PrmGiinputCaptureToSpeed>
    {
        public PrmGiinputCaptureToSpeedGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InvertedAlphaExponent, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfPoles, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            