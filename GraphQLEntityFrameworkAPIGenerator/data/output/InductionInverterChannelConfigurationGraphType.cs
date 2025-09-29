
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
    public partial class InductionInverterChannelConfigurationGraphType : ObjectGraphType<InductionInverterChannelConfiguration>
    {
        public InductionInverterChannelConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InverterChannelId, type: typeof(GuidGraphType), nullable: False);
            
            Field<InductionCoilChannelGraphType, InductionCoilChannel>("InductionCoilChannels")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilChannelGraphType>(
                        "InductionInverterChannelConfiguration-InductionCoilChannel-loader",
                        async ids => 
                        {
                            Expression<Func<InductionCoilChannel, bool>> expr = x => !ids.Any()
                                \|\| (x.CoilChannel0 != null && ids.Contains((Guid)x.CoilChannel0))
\|\| (x.CoilChannel1 != null && ids.Contains((Guid)x.CoilChannel1));

                            var data = await dbContext.InductionCoilChannels
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.CoilChannel0,
x.CoilChannel1
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.InductionCoilChannels);
                });
            
			
            Field<InductionZeroCrossConfigurationGraphType, InductionZeroCrossConfiguration>("InductionZeroCrossConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionZeroCrossConfigurationGraphType>>(
                        "InductionInverterChannelConfiguration-InductionZeroCrossConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionZeroCrossConfigurations
                                .Where(x => x.InductionZeroCrossConfiguration != null && ids.Contains((Guid)x.InductionZeroCrossConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionZeroCrossConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.InductionZeroCrossConfigurations);
                });
            
        }
    }
}
            