
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
    public partial class SelectorGraphType : ObjectGraphType<Selector>
    {
        public SelectorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SelectorId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Code, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Target, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Comment, type: typeof(StringGraphType), nullable: True);
            
            Field<UimacroGraphType, Uimacro>("Uimacros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UimacroGraphType>(
                        "Selector-Uimacro-loader",
                        async ids => 
                        {
                            Expression<Func<Uimacro, bool>> expr = x => !ids.Any()
                                \|\| (x.DelayUimacro != null && ids.Contains((Guid)x.DelayUimacro))
\|\| (x.EndUimacro != null && ids.Contains((Guid)x.EndUimacro))
\|\| (x.GlobalUimacro != null && ids.Contains((Guid)x.GlobalUimacro))
\|\| (x.OffUimacro != null && ids.Contains((Guid)x.OffUimacro))
\|\| (x.PauseUimacro != null && ids.Contains((Guid)x.PauseUimacro))
\|\| (x.ProgrammingUimacro != null && ids.Contains((Guid)x.ProgrammingUimacro));

                            var data = await dbContext.Uimacros
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.DelayUimacro,
x.EndUimacro,
x.GlobalUimacro,
x.OffUimacro,
x.PauseUimacro,
x.ProgrammingUimacro
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.Uimacros);
                });
            
			
            Field<MacroGraphType, Macro>("Macros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MacroGraphType>(
                        "Selector-Macro-loader",
                        async ids => 
                        {
                            var data = await dbContext.Macros
                                .Where(x => x.Macro != null && ids.Contains((Guid)x.Macro))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Macro!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Macro);
                });
            
			
            Field<SelectorConfigurationGraphType, SelectorConfiguration>("SelectorConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorConfigurationGraphType>>(
                        "Selector-SelectorConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.SelectorConfigurationsSelector
                                .Where(x => x.SelectorConfigurationId != null && ids.Contains((Guid)x.SelectorConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SelectorConfigurationId!,
                                    Value = x.SelectorConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.SelectorConfigurations);
                });
            
			
            Field<ConditionGraphType, Condition>("Conditions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ConditionGraphType>>(
                        "Selector-Condition-loader",
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
            
			
            Field<CycleGraphType, Cycle>("Cycles")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleGraphType>>(
                        "Selector-Cycle-loader",
                        async ids => 
                        {
                            var data = await dbContext.SelectorsCycle
                                .Where(x => x.SelectorId != null && ids.Contains((Guid)x.SelectorId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SelectorId!,
                                    Value = x.Cycle,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Cycles);
                });
            
			
            Field<UifunctionConditionGraphType, UifunctionCondition>("UifunctionConditions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UifunctionConditionGraphType>>(
                        "Selector-UifunctionCondition-loader",
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
                        "Selector-TableTarget-loader",
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
            
			
            Field<UifunctionConfigurationGraphType, UifunctionConfiguration>("UifunctionConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UifunctionConfigurationGraphType>(
                        "Selector-UifunctionConfiguration-loader",
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
            
        }
    }
}
            