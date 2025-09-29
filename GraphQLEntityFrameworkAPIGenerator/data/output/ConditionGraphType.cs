
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
    public partial class ConditionGraphType : ObjectGraphType<Condition>
    {
        public ConditionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ConditionId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumConditions, type: typeof(ByteGraphType), nullable: False);
            
            Field<ConditionBlockGraphType, ConditionBlock>("ConditionBlocks")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ConditionBlockGraphType>(
                        "Condition-ConditionBlock-loader",
                        async ids => 
                        {
                            Expression<Func<ConditionBlock, bool>> expr = x => !ids.Any()
                                \|\| (x.ConditionBlock1 != null && ids.Contains((Guid)x.ConditionBlock1))
\|\| (x.ConditionBlock2 != null && ids.Contains((Guid)x.ConditionBlock2))
\|\| (x.ConditionBlock3 != null && ids.Contains((Guid)x.ConditionBlock3))
\|\| (x.ConditionBlock4 != null && ids.Contains((Guid)x.ConditionBlock4))
\|\| (x.ConditionBlock5 != null && ids.Contains((Guid)x.ConditionBlock5))
\|\| (x.ConditionBlock6 != null && ids.Contains((Guid)x.ConditionBlock6))
\|\| (x.ConditionBlock7 != null && ids.Contains((Guid)x.ConditionBlock7))
\|\| (x.ConditionBlock8 != null && ids.Contains((Guid)x.ConditionBlock8));

                            var data = await dbContext.ConditionBlocks
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

                    return loader.LoadAsync(context.Source.ConditionBlocks);
                });
            
			
            Field<CycleGraphType, Cycle>("Cycles")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleGraphType>>(
                        "Condition-Cycle-loader",
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
                        "Condition-Selector-loader",
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
                        "Condition-UifunctionCondition-loader",
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
            
			
            Field<StmJumpIfGraphType, StmJumpIf>("StmJumpIfs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmJumpIfGraphType>>(
                        "Condition-StmJumpIf-loader",
                        async ids => 
                        {
                            var data = await dbContext.StmJumpIfs
                                .Where(x => x.StmJumpIf != null && ids.Contains((Guid)x.StmJumpIf))
                                .Select(x => new
                                {
                                    Key = (Guid)x.StmJumpIf!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.StmJumpIfs);
                });
            
			
            Field<StmLoadsControlGraphType, StmLoadsControl>("StmLoadsControls")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmLoadsControlGraphType>>(
                        "Condition-StmLoadsControl-loader",
                        async ids => 
                        {
                            var data = await dbContext.StmLoadsControls
                                .Where(x => x.StmLoadsControl != null && ids.Contains((Guid)x.StmLoadsControl))
                                .Select(x => new
                                {
                                    Key = (Guid)x.StmLoadsControl!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.StmLoadsControls);
                });
            
			
            Field<StmMaintainGraphType, StmMaintain>("StmMaintains")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmMaintainGraphType>>(
                        "Condition-StmMaintain-loader",
                        async ids => 
                        {
                            var data = await dbContext.StmMaintains
                                .Where(x => x.StmMaintain != null && ids.Contains((Guid)x.StmMaintain))
                                .Select(x => new
                                {
                                    Key = (Guid)x.StmMaintain!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.StmMaintains);
                });
            
        }
    }
}
            