
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
    public partial class TargetGraphType : ObjectGraphType<Target>
    {
        public TargetGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.TargetId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TargetDsc, type: typeof(StringGraphType), nullable: False);
            
            Field<FaultDetailGraphType, FaultDetail>("FaultDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<FaultDetailGraphType>>(
                        "Target-FaultDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.FaultDetails
                                .Where(x => x.FaultDetail != null && ids.Contains((Guid)x.FaultDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.FaultDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.FaultDetails);
                });
            
        }
    }
}
            