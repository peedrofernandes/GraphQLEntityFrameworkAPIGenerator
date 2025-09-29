
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
    public partial class IpcFanConfigDatumGraphType : ObjectGraphType<IpcFanConfigDatum>
    {
        public IpcFanConfigDatumGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.IpcFanConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanMaximumSpeed, type: typeof(IdGraphType), nullable: False);
			Field(t => t.FanMinimumSpeed, type: typeof(IdGraphType), nullable: False);
			Field(t => t.FanActivationTempThresholdNotDelivering, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MaxTempForSpeedLinearInterpolation, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MinTempForSpeedLinearInterpolation, type: typeof(FloatGraphType), nullable: False);
            
            Field<IpcControllerCoilConfigurationGraphType, IpcControllerCoilConfiguration>("IpcControllerCoilConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerCoilConfigurationGraphType>>(
                        "IpcFanConfigDatum-IpcControllerCoilConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.IpcControllerCoilConfigurations
                                .Where(x => x.IpcControllerCoilConfiguration != null && ids.Contains((Guid)x.IpcControllerCoilConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.IpcControllerCoilConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.IpcControllerCoilConfigurations);
                });
            
        }
    }
}
            