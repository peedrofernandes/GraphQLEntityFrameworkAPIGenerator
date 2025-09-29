
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
    public partial class CycleMappingCavityParamGraphType : ObjectGraphType<CycleMappingCavityParam>
    {
        public CycleMappingCavityParamGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleMappingCavityParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ProbeRemovalTimeout, type: typeof(IdGraphType), nullable: False);
            
            Field<CycleMappingAcuTargetGraphType, CycleMappingAcuTarget>("CycleMappingAcuTargets")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingAcuTargetGraphType>>(
                        "CycleMappingCavityParam-CycleMappingAcuTarget-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappingAcuTargets
                                .Where(x => x.CycleMappingAcuTarget != null && ids.Contains((Guid)x.CycleMappingAcuTarget))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleMappingAcuTarget!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.CycleMappingAcuTargets);
                });
            
        }
    }
}
            