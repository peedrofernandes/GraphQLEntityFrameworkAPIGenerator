
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
    public partial class UicypressTouchParameterGraphType : ObjectGraphType<UicypressTouchParameter>
    {
        public UicypressTouchParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UicypressTouchId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumDevices, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CapsenseMethod, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DeviceI2cport0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DeviceI2caddress0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DeviceNumKeys0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DeviceI2cport1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DeviceI2caddress1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DeviceNumKeys1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.NumSensors, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Sensors, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.Llis, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.Positions, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.Lpmdevice, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LpmsensorBitmap, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.StuckKeyTimeout, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.I2cspeed, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DeviceNumSliders0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DeviceNumSliders1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PositionsTouchSliders1, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.PositionsTouchSliders2, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.SensorsTouchSliders1, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.SensorsTouchSliders2, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.SensorsDataTouchSliders1, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.SensorsDataTouchSliders2, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
            
            Field<UitouchDeviceGraphType, UitouchDevice>("UitouchDevices")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UitouchDeviceGraphType>>(
                        "UicypressTouchParameter-UitouchDevice-loader",
                        async ids => 
                        {
                            var data = await dbContext.UitouchDevices
                                .Where(x => x.UitouchDevice != null && ids.Contains((Guid)x.UitouchDevice))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UitouchDevice!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UitouchDevices);
                });
            
        }
    }
}
            