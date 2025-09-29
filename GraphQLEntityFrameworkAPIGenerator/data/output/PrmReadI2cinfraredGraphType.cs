
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
    public partial class PrmReadI2cinfraredGraphType : ObjectGraphType<PrmReadI2cinfrared>
    {
        public PrmReadI2cinfraredGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.StepPeriodMilliseconds, type: typeof(IdGraphType), nullable: False);
			Field(t => t.I2cchannel, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.BitResolution, type: typeof(ByteGraphType), nullable: False);
            
            Field<RefreshRateGraphType, RefreshRate>("RefreshRates")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, RefreshRateGraphType>(
                        "PrmReadI2cinfrared-RefreshRate-loader",
                        async ids => 
                        {
                            var data = await dbContext.RefreshRates
                                .Where(x => x.RefreshRate != null && ids.Contains((byte)x.RefreshRate))
                                .Select(x => new
                                {
                                    Key = (byte)x.RefreshRate!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.RefreshRate);
                });
            
        }
    }
}
            