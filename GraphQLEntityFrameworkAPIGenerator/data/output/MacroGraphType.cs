
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
    public partial class MacroGraphType : ObjectGraphType<Macro>
    {
        public MacroGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MacroId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Target, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Comment, type: typeof(StringGraphType), nullable: True);
            
            Field<CycleGraphType, Cycle>("Cycles")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleGraphType>>(
                        "Macro-Cycle-loader",
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
                        "Macro-Cycle-loader",
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
            
			
            Field<TimeEstimationGraphType, TimeEstimation>("TimeEstimations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<TimeEstimationGraphType>>(
                        "Macro-TimeEstimation-loader",
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
                        "Macro-Uimacro-loader",
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
                        "Macro-UserPhaseName-loader",
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
            
			
            Field<FaultDetailGraphType, FaultDetail>("FaultDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<FaultDetailGraphType>>(
                        "Macro-FaultDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.FaultDetails
                                .Where(x => x.FaultDetail != null && ids.Contains((Guid)x.FaultDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.FaultDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.FaultDetails);
                });
            
			
            Field<StatementGraphType, Statement>("Statements")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StatementGraphType>>(
                        "Macro-Statement-loader",
                        async ids => 
                        {
                            var data = await dbContext.MacrosStatement
                                .Where(x => x.MacroId != null && ids.Contains((Guid)x.MacroId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MacroId!,
                                    Value = x.Statement,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Statements);
                });
            
			
            Field<SelectorGraphType, Selector>("Selectors")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorGraphType>>(
                        "Macro-Selector-loader",
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
                        "Macro-TableTarget-loader",
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
            