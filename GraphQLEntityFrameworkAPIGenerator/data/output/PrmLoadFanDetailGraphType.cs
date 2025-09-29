
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
    public partial class PrmLoadFanDetailGraphType : ObjectGraphType<PrmLoadFanDetail>
    {
        public PrmLoadFanDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrmLoadFanDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.K1value, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.K2value, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.K3value, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.K4value, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerPercentage, type: typeof(ByteGraphType), nullable: False);
            
            Field<PrmLoadFanConfigurationGraphType, PrmLoadFanConfiguration>("PrmLoadFanConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmLoadFanConfigurationGraphType>>(
                        "PrmLoadFanDetail-PrmLoadFanConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrmLoadFanConfigurationPrmLoadFanDetail
                                .Where(x => x.Id != null && ids.Contains((Guid)x.Id))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Id!,
                                    Value = x.IdNavigation,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrmLoadFanConfigurations);
                });
            
        }
    }
}
            