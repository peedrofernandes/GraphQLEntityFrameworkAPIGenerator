
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
    public partial class InductionIpcdetailGraphType : ObjectGraphType<InductionIpcdetail>
    {
        public InductionIpcdetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionIpcid, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SyncSerial, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.MasterSlave, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HalfBridgeQuasiResonant, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.InfinitePotLoss, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HeatsinkFanLoadIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfCoins, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MainRelayLoadIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InverterTechnology, type: typeof(ByteGraphType), nullable: False);
            
            Field<InductionCooktopOrgConfigurationGraphType, InductionCooktopOrgConfiguration>("InductionCooktopOrgConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCooktopOrgConfigurationGraphType>>(
                        "InductionIpcdetail-InductionCooktopOrgConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionCooktopOrgConfigurationsInductionIpcdetail
                                .Where(x => x.CooktopOrgConfigurationId != null && ids.Contains((Guid)x.CooktopOrgConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CooktopOrgConfigurationId!,
                                    Value = x.CooktopOrgConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionCooktopOrgConfigurations);
                });
            
			
            Field<InductionIpcSpecificDatumGraphType, InductionIpcSpecificDatum>("InductionIpcSpecificDatums")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionIpcSpecificDatumGraphType>(
                        "InductionIpcdetail-InductionIpcSpecificDatum-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionIpcSpecificDatums
                                .Where(x => x.InductionIpcSpecificDatum != null && ids.Contains((Guid)x.InductionIpcSpecificDatum))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionIpcSpecificDatum!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionIpcSpecificDatum);
                });
            
			
            Field<InductionCoilConfigGraphType, InductionCoilConfig>("InductionCoilConfigs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilConfigGraphType>>(
                        "InductionIpcdetail-InductionCoilConfig-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionIpcdetailsInductionCoilConfig
                                .Where(x => x.InductionIpcid != null && ids.Contains((Guid)x.InductionIpcid))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionIpcid!,
                                    Value = x.InductionCoilConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionCoilConfigs);
                });
            
			
            Field<IpcSpecificSafetyParamGraphType, IpcSpecificSafetyParam>("IpcSpecificSafetyParams")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IpcSpecificSafetyParamGraphType>(
                        "InductionIpcdetail-IpcSpecificSafetyParam-loader",
                        async ids => 
                        {
                            var data = await dbContext.IpcSpecificSafetyParams
                                .Where(x => x.IpcSpecificSafetyParam != null && ids.Contains((Guid)x.IpcSpecificSafetyParam))
                                .Select(x => new
                                {
                                    Key = (Guid)x.IpcSpecificSafetyParam!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.IpcSpecificSafetyParam);
                });
            
			
            Field<InductionZeroCrossConfigurationGraphType, InductionZeroCrossConfiguration>("InductionZeroCrossConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionZeroCrossConfigurationGraphType>(
                        "InductionIpcdetail-InductionZeroCrossConfiguration-loader",
                        async ids => 
                        {
                            Expression<Func<InductionZeroCrossConfiguration, bool>> expr = x => !ids.Any()
                                \|\| (x.ZeroCrossChannel0 != null && ids.Contains((Guid)x.ZeroCrossChannel0))
\|\| (x.ZeroCrossChannel1 != null && ids.Contains((Guid)x.ZeroCrossChannel1))
\|\| (x.ZeroCrossChannel2 != null && ids.Contains((Guid)x.ZeroCrossChannel2));

                            var data = await dbContext.InductionZeroCrossConfigurations
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.ZeroCrossChannel0,
x.ZeroCrossChannel1,
x.ZeroCrossChannel2
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.InductionZeroCrossConfigurations);
                });
            
        }
    }
}
            