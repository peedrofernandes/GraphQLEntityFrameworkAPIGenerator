
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
    public partial class UitouchLeanGraphType : ObjectGraphType<UitouchLean>
    {
        public UitouchLeanGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UitouchLeanId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfZones, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.EnableTouchLeanFeature, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.TimeToComeOutFromLeanModeZone0, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TimeDuringLeanModeZone0, type: typeof(IdGraphType), nullable: False);
			Field(t => t.LockKeysNumberZone0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensorSelectionBufferZone0, type: typeof(LongGraphType), nullable: False);
			Field(t => t.TimeToComeOutFromLeanModeZone1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TimeDuringLeanModeZone1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.LockKeysNumberZone1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensorSelectionBufferZone1, type: typeof(LongGraphType), nullable: False);
			Field(t => t.TimeToComeOutFromLeanModeZone2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TimeDuringLeanModeZone2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.LockKeysNumberZone2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensorSelectionBufferZone2, type: typeof(LongGraphType), nullable: False);
			Field(t => t.TimeToComeOutFromLeanModeZone3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TimeDuringLeanModeZone3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.LockKeysNumberZone3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensorSelectionBufferZone3, type: typeof(LongGraphType), nullable: False);
			Field(t => t.MaxZoneSensorBufferSize, type: typeof(ByteGraphType), nullable: False);
            
            Field<UitouchDeviceGraphType, UitouchDevice>("UitouchDevices")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UitouchDeviceGraphType>>(
                        "UitouchLean-UitouchDevice-loader",
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
            