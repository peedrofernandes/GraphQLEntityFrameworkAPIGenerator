
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
    public partial class CycleMappingModelNumberGraphType : ObjectGraphType<CycleMappingModelNumber>
    {
        public CycleMappingModelNumberGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleMappingModelNumberId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ModelNumber, type: typeof(StringGraphType), nullable: False);
            
            Field<CycleMappingFileInfoGraphType, CycleMappingFileInfo>("CycleMappingFileInfos")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingFileInfoGraphType>>(
                        "CycleMappingModelNumber-CycleMappingFileInfo-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappingFileInfoCycleMappingModelNumber
                                .Where(x => x.CycleMappingFileInfoId != null && ids.Contains((Guid)x.CycleMappingFileInfoId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleMappingFileInfoId!,
                                    Value = x.CycleMappingFileInfo,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleMappingFileInfos);
                });
            
        }
    }
}
            