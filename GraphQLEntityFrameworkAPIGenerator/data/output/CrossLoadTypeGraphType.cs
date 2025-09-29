
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
    public partial class CrossLoadTypeGraphType : ObjectGraphType<CrossLoadType>
    {
        public CrossLoadTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CrossLoadTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CrossLoadTypeDsc, type: typeof(StringGraphType), nullable: False);
            
            Field<CrossLoadDetailGraphType, CrossLoadDetail>("CrossLoadDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CrossLoadDetailGraphType>>(
                        "CrossLoadType-CrossLoadDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.CrossLoadDetails
                                .Where(x => x.CrossLoadDetail != null && ids.Contains((Guid)x.CrossLoadDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CrossLoadDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.CrossLoadDetails);
                });
            
        }
    }
}
            