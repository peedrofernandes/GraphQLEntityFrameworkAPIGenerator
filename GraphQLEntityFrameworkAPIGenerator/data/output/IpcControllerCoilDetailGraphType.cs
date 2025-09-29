
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
    public partial class IpcControllerCoilDetailGraphType : ObjectGraphType<IpcControllerCoilDetail>
    {
        public IpcControllerCoilDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.IpcControllerCoilDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<InductionThermalNodeConfigurationGraphType, InductionThermalNodeConfiguration>("InductionThermalNodeConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionThermalNodeConfigurationGraphType>(
                        "IpcControllerCoilDetail-InductionThermalNodeConfiguration-loader",
                        async ids => 
                        {
                            Expression<Func<InductionThermalNodeConfiguration, bool>> expr = x => !ids.Any()
                                \|\| (x.CoilCenterThermalNodeConfig != null && ids.Contains((Guid)x.CoilCenterThermalNodeConfig))
\|\| (x.CoilGapThermalNodeConfig != null && ids.Contains((Guid)x.CoilGapThermalNodeConfig))
\|\| (x.IgbtThermalNodeConfig != null && ids.Contains((Guid)x.IgbtThermalNodeConfig));

                            var data = await dbContext.InductionThermalNodeConfigurations
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.CoilCenterThermalNodeConfig,
x.CoilGapThermalNodeConfig,
x.IgbtThermalNodeConfig
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.InductionThermalNodeConfigurations);
                });
            
			
            Field<CoilSpecificConfigDatumGraphType, CoilSpecificConfigDatum>("CoilSpecificConfigDatums")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CoilSpecificConfigDatumGraphType>(
                        "IpcControllerCoilDetail-CoilSpecificConfigDatum-loader",
                        async ids => 
                        {
                            var data = await dbContext.CoilSpecificConfigDatums
                                .Where(x => x.CoilSpecificConfigDatum != null && ids.Contains((Guid)x.CoilSpecificConfigDatum))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CoilSpecificConfigDatum!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CoilSpecificConfigDatum);
                });
            
			
            Field<EmptyPotDetectionCoilConfigGraphType, EmptyPotDetectionCoilConfig>("EmptyPotDetectionCoilConfigs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, EmptyPotDetectionCoilConfigGraphType>(
                        "IpcControllerCoilDetail-EmptyPotDetectionCoilConfig-loader",
                        async ids => 
                        {
                            var data = await dbContext.EmptyPotDetectionCoilConfigs
                                .Where(x => x.EmptyPotDetectionCoilConfig != null && ids.Contains((Guid)x.EmptyPotDetectionCoilConfig))
                                .Select(x => new
                                {
                                    Key = (Guid)x.EmptyPotDetectionCoilConfig!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.EmptyPotDetectionCoilConfig);
                });
            
			
            Field<InverterConfigDatumGraphType, InverterConfigDatum>("InverterConfigDatums")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InverterConfigDatumGraphType>(
                        "IpcControllerCoilDetail-InverterConfigDatum-loader",
                        async ids => 
                        {
                            var data = await dbContext.InverterConfigDatums
                                .Where(x => x.InverterConfigDatum != null && ids.Contains((Guid)x.InverterConfigDatum))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InverterConfigDatum!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InverterConfigDatum);
                });
            
			
            Field<IpcControllerCoilConfigurationGraphType, IpcControllerCoilConfiguration>("IpcControllerCoilConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerCoilConfigurationGraphType>>(
                        "IpcControllerCoilDetail-IpcControllerCoilConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.IpcControllerCoilConfigurationsIpcControllerCoilDetail
                                .Where(x => x.IpcControllerCoilConfigurationsId != null && ids.Contains((Guid)x.IpcControllerCoilConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.IpcControllerCoilConfigurationsId!,
                                    Value = x.IpcControllerCoilConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.IpcControllerCoilConfigurations);
                });
            
        }
    }
}
            