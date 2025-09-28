
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
    public partial class AppConfigMicrowaveCompartmentGraphType : ObjectGraphType<AppConfigMicrowaveCompartment>
    {
        public AppConfigMicrowaveCompartmentGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.RelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Dlb, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TurnTable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Light, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Grill1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Bake, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ForcedConvElement1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ForcedConvFan1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ForcedConvValve, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Magnetron, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CoolingFan1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Temperature1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.HumiditySensor, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Irsensor, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            