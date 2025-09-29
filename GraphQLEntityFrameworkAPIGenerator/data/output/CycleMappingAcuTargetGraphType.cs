
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
    public partial class CycleMappingAcuTargetGraphType : ObjectGraphType<CycleMappingAcuTarget>
    {
        public CycleMappingAcuTargetGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleMappingAcuTargetId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CycleMappingCompartmentArray, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.AcutargetArray, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.NumberOfComparments, type: typeof(IdGraphType), nullable: False);
            
            Field<CycleMappingCavityParamGraphType, CycleMappingCavityParam>("CycleMappingCavityParams")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleMappingCavityParamGraphType>(
                        "CycleMappingAcuTarget-CycleMappingCavityParam-loader",
                        async ids => 
                        {
                            Expression<Func<CycleMappingCavityParam, bool>> expr = x => !ids.Any()
                                \|\| (x.CycleMappingCavityParamsId1Navigation != null && ids.Contains((Guid)x.CycleMappingCavityParamsId1Navigation))
\|\| (x.CycleMappingCavityParamsId2Navigation != null && ids.Contains((Guid)x.CycleMappingCavityParamsId2Navigation))
\|\| (x.CycleMappingCavityParamsId3Navigation != null && ids.Contains((Guid)x.CycleMappingCavityParamsId3Navigation))
\|\| (x.CycleMappingCavityParamsId4Navigation != null && ids.Contains((Guid)x.CycleMappingCavityParamsId4Navigation));

                            var data = await dbContext.CycleMappingCavityParams
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.CycleMappingCavityParamsId1Navigation,
x.CycleMappingCavityParamsId2Navigation,
x.CycleMappingCavityParamsId3Navigation,
x.CycleMappingCavityParamsId4Navigation
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.CycleMappingCavityParams);
                });
            
			
            Field<CycleMappingGraphType, CycleMapping>("CycleMappings")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingGraphType>>(
                        "CycleMappingAcuTarget-CycleMapping-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappings
                                .Where(x => x.CycleMapping != null && ids.Contains((Guid)x.CycleMapping))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleMapping!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.CycleMappings);
                });
            
        }
    }
}
            