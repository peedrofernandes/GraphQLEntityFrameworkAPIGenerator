
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
    public partial class CycleMappingGraphType : ObjectGraphType<CycleMapping>
    {
        public CycleMappingGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleMappingId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.IsConnected, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DataModelVersion, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Version, type: typeof(FloatGraphType), nullable: False);
            
            Field<CycleMappingAcuTargetGraphType, CycleMappingAcuTarget>("CycleMappingAcuTargets")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleMappingAcuTargetGraphType>(
                        "CycleMapping-CycleMappingAcuTarget-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappingAcuTargets
                                .Where(x => x.CycleMappingAcuTarget != null && ids.Contains((Guid)x.CycleMappingAcuTarget))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleMappingAcuTarget!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleMappingAcuTarget);
                });
            
			
            Field<CycleOptionsConfigurationGraphType, CycleOptionsConfiguration>("CycleOptionsConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsConfigurationGraphType>>(
                        "CycleMapping-CycleOptionsConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappingCycleOptionsConfiguration
                                .Where(x => x.CycleMappingId != null && ids.Contains((Guid)x.CycleMappingId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleMappingId!,
                                    Value = x.CycleOptionsConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleOptionsConfigurations);
                });
            
			
            Field<CycleMappingUriGraphType, CycleMappingUri>("CycleMappingUris")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingUriGraphType>>(
                        "CycleMapping-CycleMappingUri-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappingCycleOptionsConfiguration
                                .Where(x => x.CycleMappingId != null && ids.Contains((Guid)x.CycleMappingId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleMappingId!,
                                    Value = x.UriTree,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleMappingUris);
                });
            
			
            Field<CycleMappingFileInfoGraphType, CycleMappingFileInfo>("CycleMappingFileInfos")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleMappingFileInfoGraphType>(
                        "CycleMapping-CycleMappingFileInfo-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappingFileInfos
                                .Where(x => x.CycleMappingFileInfo != null && ids.Contains((Guid)x.CycleMappingFileInfo))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleMappingFileInfo!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleMappingFileInfo);
                });
            
			
            Field<CycleMappingExportOptionGraphType, CycleMappingExportOption>("CycleMappingExportOptions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleMappingExportOptionGraphType>(
                        "CycleMapping-CycleMappingExportOption-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappingExportOptions
                                .Where(x => x.CycleMappingExportOption != null && ids.Contains((byte)x.CycleMappingExportOption))
                                .Select(x => new
                                {
                                    Key = (byte)x.CycleMappingExportOption!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleMappingExportOption);
                });
            
			
            Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                        "CycleMapping-MachineConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MachineConfigurations
                                .Where(x => x.MachineConfiguration != null && ids.Contains((Guid)x.MachineConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MachineConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.MachineConfigurations);
                });
            
        }
    }
}
            