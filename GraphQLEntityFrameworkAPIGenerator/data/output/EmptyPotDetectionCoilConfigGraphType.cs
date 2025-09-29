
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
    public partial class EmptyPotDetectionCoilConfigGraphType : ObjectGraphType<EmptyPotDetectionCoilConfig>
    {
        public EmptyPotDetectionCoilConfigGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.EmptyPotDetectionCoilConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.UseGapTempSensorForEmptyPotHandling, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.KiTemperatureControl, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.KpTemperatureControl, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.FixedDeratingFactor, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureControlSetpointSlope, type: typeof(FloatGraphType), nullable: False);
            
            Field<IpcControllerCoilDetailGraphType, IpcControllerCoilDetail>("IpcControllerCoilDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerCoilDetailGraphType>>(
                        "EmptyPotDetectionCoilConfig-IpcControllerCoilDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.IpcControllerCoilDetails
                                .Where(x => x.IpcControllerCoilDetail != null && ids.Contains((Guid)x.IpcControllerCoilDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.IpcControllerCoilDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.IpcControllerCoilDetails);
                });
            
        }
    }
}
            