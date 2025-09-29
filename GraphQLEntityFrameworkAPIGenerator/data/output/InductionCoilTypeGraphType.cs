
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
    public partial class InductionCoilTypeGraphType : ObjectGraphType<InductionCoilType>
    {
        public InductionCoilTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CoilTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CoilTypeDesc, type: typeof(StringGraphType), nullable: False);
            
            Field<InductionCoilChannelGraphType, InductionCoilChannel>("InductionCoilChannels")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilChannelGraphType>>(
                        "InductionCoilType-InductionCoilChannel-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionCoilChannels
                                .Where(x => x.InductionCoilChannel != null && ids.Contains((Guid)x.InductionCoilChannel))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionCoilChannel!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.InductionCoilChannels);
                });
            
        }
    }
}
            