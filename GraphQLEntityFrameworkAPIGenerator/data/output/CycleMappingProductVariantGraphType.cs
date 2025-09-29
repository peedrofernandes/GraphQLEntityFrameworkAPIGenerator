
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
    public partial class CycleMappingProductVariantGraphType : ObjectGraphType<CycleMappingProductVariant>
    {
        public CycleMappingProductVariantGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: True);
            
            Field<CycleMappingFileInfoGraphType, CycleMappingFileInfo>("CycleMappingFileInfos")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingFileInfoGraphType>>(
                        "CycleMappingProductVariant-CycleMappingFileInfo-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappingFileInfos
                                .Where(x => x.CycleMappingFileInfo != null && ids.Contains((Guid)x.CycleMappingFileInfo))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleMappingFileInfo!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.CycleMappingFileInfos);
                });
            
			
            Field<DisplayGraphType, Display>("Displays")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DisplayGraphType>>(
                        "CycleMappingProductVariant-Display-loader",
                        async ids => 
                        {
                            var data = await dbContext.Displays
                                .Where(x => x.Display != null && ids.Contains((Guid)x.Display))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Display!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Displays);
                });
            
        }
    }
}
            