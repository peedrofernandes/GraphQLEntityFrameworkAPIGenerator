
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
    public partial class CycleGraphType : ObjectGraphType<Cycle>
    {
        public CycleGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.AfterFaultRestore, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.BackupRestore, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Pause, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CycleHeading, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleSubHeading, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleGroup, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Target, type: typeof(ByteGraphType), nullable: False);
            
            Field<CycleNameGraphType, CycleName>("CycleNames")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, CycleNameGraphType>(
                        "Cycle-CycleName-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleNames
                                .Where(x => x.CycleName != null && ids.Contains((int)x.CycleName))
                                .Select(x => new
                                {
                                    Key = (int)x.CycleName!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleName);
                });
            
			
            Field<MacroGraphType, Macro>("Macros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MacroGraphType>>(
                        "Cycle-Macro-loader",
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
                        "Cycle-TimeEstimation-loader",
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
            
			
            Field<UimacroGraphType, Uimacro>("Uimacros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UimacroGraphType>>(
                        "Cycle-Uimacro-loader",
                        async ids => 
                        {
                            var data = await dbContext.CyclesMacro
                                .Where(x => x.CycleId != null && ids.Contains((Guid)x.CycleId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleId!,
                                    Value = x.Uimacro,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Uimacros);
                });
            
			
            Field<UserPhaseNameGraphType, UserPhaseName>("UserPhaseNames")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, IEnumerable<UserPhaseNameGraphType>>(
                        "Cycle-UserPhaseName-loader",
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
            
			
            Field<MacroGraphType, Macro>("Macros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MacroGraphType>(
                        "Cycle-Macro-loader",
                        async ids => 
                        {
                            Expression<Func<Macro, bool>> expr = x => !ids.Any()
                                \|\| (x.DelayMacro != null && ids.Contains((Guid)x.DelayMacro))
\|\| (x.EndMacro != null && ids.Contains((Guid)x.EndMacro))
\|\| (x.PauseMacro != null && ids.Contains((Guid)x.PauseMacro))
\|\| (x.ProgrammingMacro != null && ids.Contains((Guid)x.ProgrammingMacro));

                            var data = await dbContext.Macros
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.DelayMacro,
x.EndMacro,
x.PauseMacro,
x.ProgrammingMacro
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.Macros);
                });
            
			
            Field<UimacroGraphType, Uimacro>("Uimacros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UimacroGraphType>(
                        "Cycle-Uimacro-loader",
                        async ids => 
                        {
                            Expression<Func<Uimacro, bool>> expr = x => !ids.Any()
                                \|\| (x.DelayUimacro != null && ids.Contains((Guid)x.DelayUimacro))
\|\| (x.EndUimacro != null && ids.Contains((Guid)x.EndUimacro))
\|\| (x.PauseUimacro != null && ids.Contains((Guid)x.PauseUimacro))
\|\| (x.ProgrammingUimacro != null && ids.Contains((Guid)x.ProgrammingUimacro))
\|\| (x.RunUimacro != null && ids.Contains((Guid)x.RunUimacro));

                            var data = await dbContext.Uimacros
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.DelayUimacro,
x.EndUimacro,
x.PauseUimacro,
x.ProgrammingUimacro,
x.RunUimacro
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.Uimacros);
                });
            
			
            Field<ConditionGraphType, Condition>("Conditions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ConditionGraphType>>(
                        "Cycle-Condition-loader",
                        async ids => 
                        {
                            var data = await dbContext.SelectorsCycle
                                .Where(x => x.SelectorId != null && ids.Contains((Guid)x.SelectorId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SelectorId!,
                                    Value = x.Condition,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Conditions);
                });
            
			
            Field<SelectorGraphType, Selector>("Selectors")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorGraphType>>(
                        "Cycle-Selector-loader",
                        async ids => 
                        {
                            var data = await dbContext.SelectorsCycle
                                .Where(x => x.SelectorId != null && ids.Contains((Guid)x.SelectorId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SelectorId!,
                                    Value = x.Selector,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Selectors);
                });
            
			
            Field<UifunctionConditionGraphType, UifunctionCondition>("UifunctionConditions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UifunctionConditionGraphType>>(
                        "Cycle-UifunctionCondition-loader",
                        async ids => 
                        {
                            var data = await dbContext.SelectorsCycle
                                .Where(x => x.SelectorId != null && ids.Contains((Guid)x.SelectorId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SelectorId!,
                                    Value = x.SelectorCondition,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UifunctionConditions);
                });
            
			
            Field<TableTargetGraphType, TableTarget>("TableTargets")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                        "Cycle-TableTarget-loader",
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
            
        }
    }
}
            