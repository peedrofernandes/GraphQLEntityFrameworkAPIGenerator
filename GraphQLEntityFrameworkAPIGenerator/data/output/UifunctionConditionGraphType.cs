
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
    public partial class UifunctionConditionGraphType : ObjectGraphType<UifunctionCondition>
    {
        public UifunctionConditionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ConditionId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumConditions, type: typeof(ByteGraphType), nullable: False);
            
            Field<UiconditionBlockGraphType, UiconditionBlock>("UiconditionBlocks")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiconditionBlockGraphType>(
                        "UifunctionCondition-UiconditionBlock-loader",
                        async ids => 
                        {
                            Expression<Func<UiconditionBlock, bool>> expr = x => !ids.Any()
                                \|\| (x.ConditionBlock1 != null && ids.Contains((Guid)x.ConditionBlock1))
\|\| (x.ConditionBlock2 != null && ids.Contains((Guid)x.ConditionBlock2))
\|\| (x.ConditionBlock3 != null && ids.Contains((Guid)x.ConditionBlock3))
\|\| (x.ConditionBlock4 != null && ids.Contains((Guid)x.ConditionBlock4))
\|\| (x.ConditionBlock5 != null && ids.Contains((Guid)x.ConditionBlock5))
\|\| (x.ConditionBlock6 != null && ids.Contains((Guid)x.ConditionBlock6))
\|\| (x.ConditionBlock7 != null && ids.Contains((Guid)x.ConditionBlock7))
\|\| (x.ConditionBlock8 != null && ids.Contains((Guid)x.ConditionBlock8));

                            var data = await dbContext.UiconditionBlocks
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.ConditionBlock1,
x.ConditionBlock2,
x.ConditionBlock3,
x.ConditionBlock4,
x.ConditionBlock5,
x.ConditionBlock6,
x.ConditionBlock7,
x.ConditionBlock8
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.UiconditionBlocks);
                });
            
			
            Field<ConditionGraphType, Condition>("Conditions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ConditionGraphType>>(
                        "UifunctionCondition-Condition-loader",
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
                        "UifunctionCondition-Cycle-loader",
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
            
			
            Field<SelectorGraphType, Selector>("Selectors")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorGraphType>>(
                        "UifunctionCondition-Selector-loader",
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
            
			
            Field<UistmSetIncompatibilityGraphType, UistmSetIncompatibility>("UistmSetIncompatibilitys")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UistmSetIncompatibilityGraphType>>(
                        "UifunctionCondition-UistmSetIncompatibility-loader",
                        async ids => 
                        {
                            var data = await dbContext.UistmSetIncompatibilitys
                                .Where(x => x.UistmSetIncompatibility != null && ids.Contains((Guid)x.UistmSetIncompatibility))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UistmSetIncompatibility!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UistmSetIncompatibilitys);
                });
            
			
            Field<UistmSetVariableGraphType, UistmSetVariable>("UistmSetVariables")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UistmSetVariableGraphType>>(
                        "UifunctionCondition-UistmSetVariable-loader",
                        async ids => 
                        {
                            var data = await dbContext.UistmSetVariables
                                .Where(x => x.UistmSetVariable != null && ids.Contains((Guid)x.UistmSetVariable))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UistmSetVariable!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UistmSetVariables);
                });
            
			
            Field<UistmVisualJumpIfGraphType, UistmVisualJumpIf>("UistmVisualJumpIfs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UistmVisualJumpIfGraphType>>(
                        "UifunctionCondition-UistmVisualJumpIf-loader",
                        async ids => 
                        {
                            var data = await dbContext.UistmVisualJumpIfs
                                .Where(x => x.UistmVisualJumpIf != null && ids.Contains((Guid)x.UistmVisualJumpIf))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UistmVisualJumpIf!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UistmVisualJumpIfs);
                });
            
        }
    }
}
            