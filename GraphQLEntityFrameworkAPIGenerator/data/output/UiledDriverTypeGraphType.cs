
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
    public partial class UiledDriverTypeGraphType : ObjectGraphType<UiledDriverType>
    {
        public UiledDriverTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LedTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LedTypeDescription, type: typeof(StringGraphType), nullable: False);
            
            Field<UiledDriverParameterGraphType, UiledDriverParameter>("UiledDriverParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledDriverParameterGraphType>>(
                        "UiledDriverType-UiledDriverParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiledDriverParameters
                                .Where(x => x.UiledDriverParameter != null && ids.Contains((Guid)x.UiledDriverParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiledDriverParameter!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UiledDriverParameters);
                });
            
        }
    }
}
            