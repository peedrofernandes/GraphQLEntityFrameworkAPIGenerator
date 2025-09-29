
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
    public partial class DisplayGraphType : ObjectGraphType<Display>
    {
        public DisplayGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DisplayId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Code, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.FaultF12timeout, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StandByTimeout, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.GoingToSleepTimeout, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StandByCommunicationTimeout, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MainTimeToEnd, type: typeof(BoolGraphType), nullable: False);
            
            Field<BrandGraphType, Brand>("Brands")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, BrandGraphType>(
                        "Display-Brand-loader",
                        async ids => 
                        {
                            var data = await dbContext.Brands
                                .Where(x => x.Brand != null && ids.Contains((byte)x.Brand))
                                .Select(x => new
                                {
                                    Key = (byte)x.Brand!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Brand);
                });
            
			
            Field<DebugPointerConfigurationGraphType, DebugPointerConfiguration>("DebugPointerConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DebugPointerConfigurationGraphType>(
                        "Display-DebugPointerConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.DebugPointerConfigurations
                                .Where(x => x.DebugPointerConfiguration != null && ids.Contains((Guid)x.DebugPointerConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.DebugPointerConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.DebugPointerConfiguration);
                });
            
			
            Field<UifunctionConfigurationGraphType, UifunctionConfiguration>("UifunctionConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UifunctionConfigurationGraphType>(
                        "Display-UifunctionConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UifunctionConfigurations
                                .Where(x => x.UifunctionConfiguration != null && ids.Contains((Guid)x.UifunctionConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UifunctionConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UifunctionConfiguration);
                });
            
			
            Field<UigenericInputConfigurationGraphType, UigenericInputConfiguration>("UigenericInputConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UigenericInputConfigurationGraphType>(
                        "Display-UigenericInputConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UigenericInputConfigurations
                                .Where(x => x.UigenericInputConfiguration != null && ids.Contains((Guid)x.UigenericInputConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UigenericInputConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UigenericInputConfiguration);
                });
            
			
            Field<HmiexpansionBoardConfigurationGraphType, HmiexpansionBoardConfiguration>("HmiexpansionBoardConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, HmiexpansionBoardConfigurationGraphType>(
                        "Display-HmiexpansionBoardConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.HmiexpansionBoardConfigurations
                                .Where(x => x.HmiexpansionBoardConfiguration != null && ids.Contains((Guid)x.HmiexpansionBoardConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.HmiexpansionBoardConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.HmiexpansionBoardConfiguration);
                });
            
			
            Field<HmiexpansionBoardConfigurationGraphType, HmiexpansionBoardConfiguration>("HmiexpansionBoardConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<HmiexpansionBoardConfigurationGraphType>>(
                        "Display-HmiexpansionBoardConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.HmiexpansionBoardConfigurationsDisplay
                                .Where(x => x.HmiexpansionBoardConfigurationId != null && ids.Contains((Guid)x.HmiexpansionBoardConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.HmiexpansionBoardConfigurationId!,
                                    Value = x.HmiexpansionBoardConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.HmiexpansionBoardConfigurations);
                });
            
			
            Field<LowLevelInputConfigurationGraphType, LowLevelInputConfiguration>("LowLevelInputConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, LowLevelInputConfigurationGraphType>(
                        "Display-LowLevelInputConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.LowLevelInputConfigurations
                                .Where(x => x.LowLevelInputConfiguration != null && ids.Contains((Guid)x.LowLevelInputConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.LowLevelInputConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.LowLevelInputConfiguration);
                });
            
			
            Field<HmiAvailableNodeGraphType, HmiAvailableNode>("HmiAvailableNodes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, HmiAvailableNodeGraphType>(
                        "Display-HmiAvailableNode-loader",
                        async ids => 
                        {
                            var data = await dbContext.HmiAvailableNodes
                                .Where(x => x.HmiAvailableNode != null && ids.Contains((byte)x.HmiAvailableNode))
                                .Select(x => new
                                {
                                    Key = (byte)x.HmiAvailableNode!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.HmiAvailableNode);
                });
            
			
            Field<CycleMappingProductVariantGraphType, CycleMappingProductVariant>("CycleMappingProductVariants")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleMappingProductVariantGraphType>(
                        "Display-CycleMappingProductVariant-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappingProductVariants
                                .Where(x => x.CycleMappingProductVariant != null && ids.Contains((byte)x.CycleMappingProductVariant))
                                .Select(x => new
                                {
                                    Key = (byte)x.CycleMappingProductVariant!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleMappingProductVariant);
                });
            
			
            Field<ProjectGraphType, Project>("Projects")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ProjectGraphType>>(
                        "Display-Project-loader",
                        async ids => 
                        {
                            var data = await dbContext.Projects
                                .Where(x => x.Project != null && ids.Contains((Guid)x.Project))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Project!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Projects);
                });
            
			
            Field<UisequenceConfigurationGraphType, UisequenceConfiguration>("UisequenceConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UisequenceConfigurationGraphType>(
                        "Display-UisequenceConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UisequenceConfigurations
                                .Where(x => x.UisequenceConfiguration != null && ids.Contains((Guid)x.UisequenceConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UisequenceConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UisequenceConfiguration);
                });
            
			
            Field<StatusVariableGraphType, StatusVariable>("StatusVariables")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, StatusVariableGraphType>(
                        "Display-StatusVariable-loader",
                        async ids => 
                        {
                            var data = await dbContext.StatusVariables
                                .Where(x => x.StatusVariable != null && ids.Contains((Guid)x.StatusVariable))
                                .Select(x => new
                                {
                                    Key = (Guid)x.StatusVariable!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.StatusVariable);
                });
            
			
            Field<TableTargetGraphType, TableTarget>("TableTargets")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                        "Display-TableTarget-loader",
                        async ids => 
                        {
                            var data = await dbContext.TableTargets
                                .Where(x => x.TableTarget != null && ids.Contains((byte)x.TableTarget))
                                .Select(x => new
                                {
                                    Key = (byte)x.TableTarget!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.TableTarget);
                });
            
			
            Field<UianimationConfigurationGraphType, UianimationConfiguration>("UianimationConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UianimationConfigurationGraphType>(
                        "Display-UianimationConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UianimationConfigurations
                                .Where(x => x.UianimationConfiguration != null && ids.Contains((Guid)x.UianimationConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UianimationConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UianimationConfiguration);
                });
            
			
            Field<UiaudioConfigurationGraphType, UiaudioConfiguration>("UiaudioConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiaudioConfigurationGraphType>(
                        "Display-UiaudioConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiaudioConfigurations
                                .Where(x => x.UiaudioConfiguration != null && ids.Contains((Guid)x.UiaudioConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiaudioConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiaudioConfiguration);
                });
            
			
            Field<UidataModelTranslationConfigurationGraphType, UidataModelTranslationConfiguration>("UidataModelTranslationConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UidataModelTranslationConfigurationGraphType>(
                        "Display-UidataModelTranslationConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UidataModelTranslationConfigurations
                                .Where(x => x.UidataModelTranslationConfiguration != null && ids.Contains((Guid)x.UidataModelTranslationConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UidataModelTranslationConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UidataModelTranslationConfiguration);
                });
            
			
            Field<UidefaultPinConfigurationGraphType, UidefaultPinConfiguration>("UidefaultPinConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UidefaultPinConfigurationGraphType>(
                        "Display-UidefaultPinConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UidefaultPinConfigurations
                                .Where(x => x.UidefaultPinConfiguration != null && ids.Contains((Guid)x.UidefaultPinConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UidefaultPinConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UidefaultPinConfiguration);
                });
            
			
            Field<UiledGroupsConfigurationGraphType, UiledGroupsConfiguration>("UiledGroupsConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiledGroupsConfigurationGraphType>(
                        "Display-UiledGroupsConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiledGroupsConfigurations
                                .Where(x => x.UiledGroupsConfiguration != null && ids.Contains((Guid)x.UiledGroupsConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiledGroupsConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiledGroupsConfiguration);
                });
            
			
            Field<UilowPowerTimeGraphType, UilowPowerTime>("UilowPowerTimes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UilowPowerTimeGraphType>(
                        "Display-UilowPowerTime-loader",
                        async ids => 
                        {
                            var data = await dbContext.UilowPowerTimes
                                .Where(x => x.UilowPowerTime != null && ids.Contains((Guid)x.UilowPowerTime))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UilowPowerTime!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UilowPowerTime);
                });
            
			
            Field<UisreventConfigurationGraphType, UisreventConfiguration>("UisreventConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UisreventConfigurationGraphType>(
                        "Display-UisreventConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UisreventConfigurations
                                .Where(x => x.UisreventConfiguration != null && ids.Contains((Guid)x.UisreventConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UisreventConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UisreventConfiguration);
                });
            
			
            Field<UitouchDeviceGraphType, UitouchDevice>("UitouchDevices")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UitouchDeviceGraphType>(
                        "Display-UitouchDevice-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UitouchDevice);
                });
            
			
            Field<UiviewEngineControlStateConfigurationGraphType, UiviewEngineControlStateConfiguration>("UiviewEngineControlStateConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiviewEngineControlStateConfigurationGraphType>(
                        "Display-UiviewEngineControlStateConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiviewEngineControlStateConfigurations
                                .Where(x => x.UiviewEngineControlStateConfiguration != null && ids.Contains((Guid)x.UiviewEngineControlStateConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiviewEngineControlStateConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiviewEngineControlStateConfiguration);
                });
            
			
            Field<UiviewEngineViewsConfiguratioGraphType, UiviewEngineViewsConfiguratio>("UiviewEngineViewsConfiguratios")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiviewEngineViewsConfiguratioGraphType>(
                        "Display-UiviewEngineViewsConfiguratio-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiviewEngineViewsConfiguratios
                                .Where(x => x.UiviewEngineViewsConfiguratio != null && ids.Contains((Guid)x.UiviewEngineViewsConfiguratio))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiviewEngineViewsConfiguratio!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiviewEngineViewsConfiguratio);
                });
            
			
            Field<VisualBoardTypeGraphType, VisualBoardType>("VisualBoardTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, VisualBoardTypeGraphType>(
                        "Display-VisualBoardType-loader",
                        async ids => 
                        {
                            var data = await dbContext.VisualBoardTypes
                                .Where(x => x.VisualBoardType != null && ids.Contains((byte)x.VisualBoardType))
                                .Select(x => new
                                {
                                    Key = (byte)x.VisualBoardType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.VisualBoardType);
                });
            
        }
    }
}
            