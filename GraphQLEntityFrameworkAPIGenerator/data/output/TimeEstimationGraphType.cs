
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
    public partial class TimeEstimationGraphType : ObjectGraphType<TimeEstimation>
    {
        public TimeEstimationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.TimeEstimationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Time, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.HasModifiers, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.ModifiersLabel, type: typeof(StringGraphType), nullable: True);
			Field(t => t.UseDirectModifier, type: typeof(BoolGraphType), nullable: False);
            
            Field<CycleGraphType, Cycle>("Cycles")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleGraphType>>(
                        "TimeEstimation-Cycle-loader",
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
                        "TimeEstimation-Macro-loader",
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
            
			
            Field<UimacroGraphType, Uimacro>("Uimacros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UimacroGraphType>>(
                        "TimeEstimation-Uimacro-loader",
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
                        "TimeEstimation-UserPhaseName-loader",
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
            
			
            Field<ModifierGraphType, Modifier>("Modifiers")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ModifierGraphType>(
                        "TimeEstimation-Modifier-loader",
                        async ids => 
                        {
                            var data = await dbContext.Modifiers
                                .Where(x => x.Modifier != null && ids.Contains((Guid)x.Modifier))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Modifier!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Modifier);
                });
            
        }
    }
}
            