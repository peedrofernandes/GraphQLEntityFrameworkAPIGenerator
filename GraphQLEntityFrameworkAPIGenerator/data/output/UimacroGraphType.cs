
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
    public partial class UimacroGraphType : ObjectGraphType<Uimacro>
    {
        public UimacroGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UimacroId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.TimeStamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<CycleGraphType, Cycle>("Cycles")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleGraphType>>(
                        "Uimacro-Cycle-loader",
                        async ids => 
                        {
                            var data = await dbContext.Cycles
                                .Where(x => x.Cycle != null && ids.Contains((Guid)x.Cycle))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Cycle!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Cycles);
                });
            
			
            Field<CycleGraphType, Cycle>("Cycles")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleGraphType>>(
                        "Uimacro-Cycle-loader",
                        async ids => 
                        {
                            var data = await dbContext.CyclesMacro
                                .Where(x => x.CycleId != null && ids.Contains((Guid)x.CycleId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleId!,
                                    Value = x.Cycle,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Cycles);
                });
            
			
            Field<MacroGraphType, Macro>("Macros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MacroGraphType>>(
                        "Uimacro-Macro-loader",
                        async ids => 
                        {
                            var data = await dbContext.CyclesMacro
                                .Where(x => x.CycleId != null && ids.Contains((Guid)x.CycleId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleId!,
                                    Value = x.Macro,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Macros);
                });
            
			
            Field<TimeEstimationGraphType, TimeEstimation>("TimeEstimations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<TimeEstimationGraphType>>(
                        "Uimacro-TimeEstimation-loader",
                        async ids => 
                        {
                            var data = await dbContext.CyclesMacro
                                .Where(x => x.CycleId != null && ids.Contains((Guid)x.CycleId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleId!,
                                    Value = x.TimeEstimation,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.TimeEstimations);
                });
            
			
            Field<UserPhaseNameGraphType, UserPhaseName>("UserPhaseNames")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, IEnumerable<UserPhaseNameGraphType>>(
                        "Uimacro-UserPhaseName-loader",
                        async ids => 
                        {
                            var data = await dbContext.CyclesMacro
                                .Where(x => x.UserPhaseName != null && ids.Contains((int)x.UserPhaseName))
                                .Select(x => new
                                {
                                    Key = (int)x.UserPhaseName!,
                                    Value = x.UserPhaseNameNavigation,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UserPhaseNames);
                });
            
			
            Field<SelectorConfigurationGraphType, SelectorConfiguration>("SelectorConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorConfigurationGraphType>>(
                        "Uimacro-SelectorConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.SelectorConfigurations
                                .Where(x => x.SelectorConfiguration != null && ids.Contains((Guid)x.SelectorConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SelectorConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.SelectorConfigurations);
                });
            
			
            Field<SelectorGraphType, Selector>("Selectors")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorGraphType>>(
                        "Uimacro-Selector-loader",
                        async ids => 
                        {
                            var data = await dbContext.Selectors
                                .Where(x => x.Selector != null && ids.Contains((Guid)x.Selector))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Selector!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Selectors);
                });
            
			
            Field<TableTargetGraphType, TableTarget>("TableTargets")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                        "Uimacro-TableTarget-loader",
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
            
			
            Field<UistatementGraphType, Uistatement>("Uistatements")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UistatementGraphType>>(
                        "Uimacro-Uistatement-loader",
                        async ids => 
                        {
                            var data = await dbContext.UimacrosUistatement
                                .Where(x => x.UimacroId != null && ids.Contains((Guid)x.UimacroId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UimacroId!,
                                    Value = x.Uistatement,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Uistatements);
                });
            
			
            Field<UiviewEngineControlStateDetailGraphType, UiviewEngineControlStateDetail>("UiviewEngineControlStateDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiviewEngineControlStateDetailGraphType>>(
                        "Uimacro-UiviewEngineControlStateDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiviewEngineControlStateDetails
                                .Where(x => x.UiviewEngineControlStateDetail != null && ids.Contains((Guid)x.UiviewEngineControlStateDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiviewEngineControlStateDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UiviewEngineControlStateDetails);
                });
            
			
            Field<UiviewEngineViewsDetailGraphType, UiviewEngineViewsDetail>("UiviewEngineViewsDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiviewEngineViewsDetailGraphType>>(
                        "Uimacro-UiviewEngineViewsDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiviewEngineViewsDetails
                                .Where(x => x.UiviewEngineViewsDetail != null && ids.Contains((Guid)x.UiviewEngineViewsDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiviewEngineViewsDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UiviewEngineViewsDetails);
                });
            
        }
    }
}
            