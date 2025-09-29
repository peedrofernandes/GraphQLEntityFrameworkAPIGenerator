
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
    public partial class PrmReadI2cpressureSensorGraphType : ObjectGraphType<PrmReadI2cpressureSensor>
    {
        public PrmReadI2cpressureSensorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DeviceModeType, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.InvertedAlpha, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InitialStabilizationTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CommunicationFaultDebounce, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CommunicationFaultRetries, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            