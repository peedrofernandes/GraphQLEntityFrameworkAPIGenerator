
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
    public partial class UserPhaseNameGraphType : ObjectGraphType<UserPhaseName>
    {
        public UserPhaseNameGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(IdGraphType), nullable: False);
			Field(t => t.UserPhaseName1, type: typeof(StringGraphType), nullable: False);
            
            Field<CycleGraphType, Cycle>("Cycles")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleGraphType>>(
                        "UserPhaseName-Cycle-loader",
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
                        "UserPhaseName-Macro-loader",
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
                        "UserPhaseName-TimeEstimation-loader",
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
                        "UserPhaseName-Uimacro-loader",
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
            
        }
    }
}
            