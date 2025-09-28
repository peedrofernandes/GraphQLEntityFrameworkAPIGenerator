
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
    public partial class PrmPilotPartializedGraphType : ObjectGraphType<PrmPilotPartialized>
    {
        public PrmPilotPartializedGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Start1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Stop1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Start2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Stop2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Start3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Stop3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Start4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Stop4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.NumSpeeds, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.PulseWidthPercentage, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MinDeactivationPercentage, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ActivationEdge, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MinPulseWidthPercentage, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            