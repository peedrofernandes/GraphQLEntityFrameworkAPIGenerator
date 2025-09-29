
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
    public partial class UiaudioBuzzerDetailGraphType : ObjectGraphType<UiaudioBuzzerDetail>
    {
        public UiaudioBuzzerDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrmUiaudioBuzzerDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Frequency, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TimeOn, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TimeOff, type: typeof(ShortGraphType), nullable: False);
            
            Field<PrmUiaudioBuzzerGraphType, PrmUiaudioBuzzer>("PrmUiaudioBuzzers")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmUiaudioBuzzerGraphType>>(
                        "UiaudioBuzzerDetail-PrmUiaudioBuzzer-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiaudioBuzzerUiaudioBuzzerDetail
                                .Where(x => x.Id != null && ids.Contains((Guid)x.Id))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Id!,
                                    Value = x.IdNavigation,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrmUiaudioBuzzers);
                });
            
        }
    }
}
            