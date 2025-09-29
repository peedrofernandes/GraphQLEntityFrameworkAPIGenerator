
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
    public partial class UiledGroupsDetailGraphType : ObjectGraphType<UiledGroupsDetail>
    {
        public UiledGroupsDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledGroupsDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Led, type: typeof(ByteGraphType), nullable: False);
            
            Field<UiledGroupGraphType, UiledGroup>("UiledGroups")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledGroupGraphType>>(
                        "UiledGroupsDetail-UiledGroup-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiledGroupsUiledGroupsDetail
                                .Where(x => x.UiledGroupsId != null && ids.Contains((Guid)x.UiledGroupsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiledGroupsId!,
                                    Value = x.UiledGroups,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiledGroups);
                });
            
        }
    }
}
            