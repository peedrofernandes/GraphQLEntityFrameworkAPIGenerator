
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
    public partial class IpcControllerIpcConfigurationGraphType : ObjectGraphType<IpcControllerIpcConfiguration>
    {
        public IpcControllerIpcConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.IpcControllerIpcConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<AssistedCookingConfigDatumGraphType, AssistedCookingConfigDatum>("AssistedCookingConfigDatums")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, AssistedCookingConfigDatumGraphType>(
                        "IpcControllerIpcConfiguration-AssistedCookingConfigDatum-loader",
                        async ids => 
                        {
                            var data = await dbContext.AssistedCookingConfigDatums
                                .Where(x => x.AssistedCookingConfigDatum != null && ids.Contains((Guid)x.AssistedCookingConfigDatum))
                                .Select(x => new
                                {
                                    Key = (Guid)x.AssistedCookingConfigDatum!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.AssistedCookingConfigDatum);
                });
            
			
            Field<CoilOperationConfigDatumGraphType, CoilOperationConfigDatum>("CoilOperationConfigDatums")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CoilOperationConfigDatumGraphType>(
                        "IpcControllerIpcConfiguration-CoilOperationConfigDatum-loader",
                        async ids => 
                        {
                            var data = await dbContext.CoilOperationConfigDatums
                                .Where(x => x.CoilOperationConfigDatum != null && ids.Contains((Guid)x.CoilOperationConfigDatum))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CoilOperationConfigDatum!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CoilOperationConfigDatum);
                });
            
			
            Field<EmptyPotDetectionConfigGraphType, EmptyPotDetectionConfig>("EmptyPotDetectionConfigs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, EmptyPotDetectionConfigGraphType>(
                        "IpcControllerIpcConfiguration-EmptyPotDetectionConfig-loader",
                        async ids => 
                        {
                            var data = await dbContext.EmptyPotDetectionConfigs
                                .Where(x => x.EmptyPotDetectionConfig != null && ids.Contains((Guid)x.EmptyPotDetectionConfig))
                                .Select(x => new
                                {
                                    Key = (Guid)x.EmptyPotDetectionConfig!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.EmptyPotDetectionConfig);
                });
            
			
            Field<IpcControllerConfigurationGraphType, IpcControllerConfiguration>("IpcControllerConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerConfigurationGraphType>>(
                        "IpcControllerIpcConfiguration-IpcControllerConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.IpcControllerConfigurationsIpcControllerIpcConfiguration
                                .Where(x => x.IpcControllerConfigurationsId != null && ids.Contains((Guid)x.IpcControllerConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.IpcControllerConfigurationsId!,
                                    Value = x.IpcControllerConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.IpcControllerConfigurations);
                });
            
			
            Field<IpcControllerCoilConfigurationGraphType, IpcControllerCoilConfiguration>("IpcControllerCoilConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerCoilConfigurationGraphType>>(
                        "IpcControllerIpcConfiguration-IpcControllerCoilConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.IpcControllerIpcConfigurationsIpcControllerCoilConfiguration
                                .Where(x => x.IpcControllerIpcConfigurationsId != null && ids.Contains((Guid)x.IpcControllerIpcConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.IpcControllerIpcConfigurationsId!,
                                    Value = x.IpcControllerCoilConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.IpcControllerCoilConfigurations);
                });
            
			
            Field<MainsLineConfigDatumGraphType, MainsLineConfigDatum>("MainsLineConfigDatums")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MainsLineConfigDatumGraphType>(
                        "IpcControllerIpcConfiguration-MainsLineConfigDatum-loader",
                        async ids => 
                        {
                            var data = await dbContext.MainsLineConfigDatums
                                .Where(x => x.MainsLineConfigDatum != null && ids.Contains((Guid)x.MainsLineConfigDatum))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MainsLineConfigDatum!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MainsLineConfigDatum);
                });
            
			
            Field<PowerDeliveryConfigDatumGraphType, PowerDeliveryConfigDatum>("PowerDeliveryConfigDatums")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PowerDeliveryConfigDatumGraphType>(
                        "IpcControllerIpcConfiguration-PowerDeliveryConfigDatum-loader",
                        async ids => 
                        {
                            var data = await dbContext.PowerDeliveryConfigDatums
                                .Where(x => x.PowerDeliveryConfigDatum != null && ids.Contains((Guid)x.PowerDeliveryConfigDatum))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PowerDeliveryConfigDatum!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PowerDeliveryConfigDatum);
                });
            
			
            Field<ThermalConfigDatumGraphType, ThermalConfigDatum>("ThermalConfigDatums")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ThermalConfigDatumGraphType>(
                        "IpcControllerIpcConfiguration-ThermalConfigDatum-loader",
                        async ids => 
                        {
                            var data = await dbContext.ThermalConfigDatums
                                .Where(x => x.ThermalConfigDatum != null && ids.Contains((Guid)x.ThermalConfigDatum))
                                .Select(x => new
                                {
                                    Key = (Guid)x.ThermalConfigDatum!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.ThermalConfigDatum);
                });
            
        }
    }
}
            