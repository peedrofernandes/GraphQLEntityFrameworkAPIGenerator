
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
    public partial class InductionThermalNodeConfigurationGraphType : ObjectGraphType<InductionThermalNodeConfiguration>
    {
        public InductionThermalNodeConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionThermalNodeConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.TempThresholdNominalToWarmState, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempThresholdWarmToOverheatState, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempTresholdHotIndicator, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ThermalDeratingPiControllerTempSetPoint, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ThermalDeratingPiControllerKp, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.ThermalDeratingPiControllerKi, type: typeof(DoubleGraphType), nullable: False);
            
            Field<IpcControllerCoilConfigurationGraphType, IpcControllerCoilConfiguration>("IpcControllerCoilConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerCoilConfigurationGraphType>>(
                        "InductionThermalNodeConfiguration-IpcControllerCoilConfiguration-loader",
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
            
			
            Field<IpcControllerCoilDetailGraphType, IpcControllerCoilDetail>("IpcControllerCoilDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerCoilDetailGraphType>>(
                        "InductionThermalNodeConfiguration-IpcControllerCoilDetail-loader",
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
            