
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
    public partial class PrmReadL2crhttempSensorGraphType : ObjectGraphType<PrmReadL2crhttempSensor>
    {
        public PrmReadL2crhttempSensorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.L2cchannel, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.L2cspeed, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RhtdeviceType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumReading, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.I2cslaveAddress, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            