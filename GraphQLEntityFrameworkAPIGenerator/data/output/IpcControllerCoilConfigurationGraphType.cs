
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
    public partial class IpcControllerCoilConfigurationGraphType : ObjectGraphType<IpcControllerCoilConfiguration>
    {
        public IpcControllerCoilConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.IpcControllerCoilConfigurationsId, type: typeof(GuidGraphType), nullable: False);
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
                        "IpcControllerCoilConfiguration-InductionThermalNodeConfiguration-loader",
                        async ids => 
                        {
                            Expression<Func<InductionThermalNodeConfiguration, bool>> expr = x => !ids.Any()
                                \|\| (x.HeatsinkThermalNodeConfig != null && ids.Contains((Guid)x.HeatsinkThermalNodeConfig))
\|\| (x.MicroThermalNodeConfig != null && ids.Contains((Guid)x.MicroThermalNodeConfig));

                            var data = await dbContext.InductionThermalNodeConfigurations
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.HeatsinkThermalNodeConfig,
x.MicroThermalNodeConfig
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.InductionThermalNodeConfigurations);
                });
            
			
            Field<IpcControllerCoilDetailGraphType, IpcControllerCoilDetail>("IpcControllerCoilDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerCoilDetailGraphType>>(
                        "IpcControllerCoilConfiguration-IpcControllerCoilDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.IpcControllerCoilConfigurationsIpcControllerCoilDetail
                                .Where(x => x.IpcControllerCoilConfigurationsId != null && ids.Contains((Guid)x.IpcControllerCoilConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.IpcControllerCoilConfigurationsId!,
                                    Value = x.IpcControllerCoilDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.IpcControllerCoilDetails);
                });
            
			
            Field<IpcControllerIpcConfigurationGraphType, IpcControllerIpcConfiguration>("IpcControllerIpcConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerIpcConfigurationGraphType>>(
                        "IpcControllerCoilConfiguration-IpcControllerIpcConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.IpcControllerIpcConfigurationsIpcControllerCoilConfiguration
                                .Where(x => x.IpcControllerIpcConfigurationsId != null && ids.Contains((Guid)x.IpcControllerIpcConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.IpcControllerIpcConfigurationsId!,
                                    Value = x.IpcControllerIpcConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.IpcControllerIpcConfigurations);
                });
            
			
            Field<IpcFanConfigDatumGraphType, IpcFanConfigDatum>("IpcFanConfigDatums")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IpcFanConfigDatumGraphType>(
                        "IpcControllerCoilConfiguration-IpcFanConfigDatum-loader",
                        async ids => 
                        {
                            var data = await dbContext.IpcFanConfigDatums
                                .Where(x => x.IpcFanConfigDatum != null && ids.Contains((Guid)x.IpcFanConfigDatum))
                                .Select(x => new
                                {
                                    Key = (Guid)x.IpcFanConfigDatum!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.IpcFanConfigDatum);
                });
            
        }
    }
}
            