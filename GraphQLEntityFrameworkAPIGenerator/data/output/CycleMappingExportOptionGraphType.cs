
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
    public partial class CycleMappingExportOptionGraphType : ObjectGraphType<CycleMappingExportOption>
    {
        public CycleMappingExportOptionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
            
            Field<CycleMappingGraphType, CycleMapping>("CycleMappings")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingGraphType>>(
                        "CycleMappingExportOption-CycleMapping-loader",
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
            