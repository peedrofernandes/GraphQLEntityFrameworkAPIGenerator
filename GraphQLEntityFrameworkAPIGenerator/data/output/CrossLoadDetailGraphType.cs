
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
    public partial class CrossLoadDetailGraphType : ObjectGraphType<CrossLoadDetail>
    {
        public CrossLoadDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CrossLoadDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.OnDelayTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OffDelayTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CouplesNum, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadOn, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.LoadOff, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.LoadOnDisconnected, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.LoadOffDisconnected, type: typeof(ShortGraphType), nullable: False);
            
            Field<CrossLoadConfigurationGraphType, CrossLoadConfiguration>("CrossLoadConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CrossLoadConfigurationGraphType>>(
                        "CrossLoadDetail-CrossLoadConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.CrossLoadConfigurationsCrossLoadDetail
                                .Where(x => x.CrossLoadConfigurationId != null && ids.Contains((Guid)x.CrossLoadConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CrossLoadConfigurationId!,
                                    Value = x.CrossLoadConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CrossLoadConfigurations);
                });
            
			
            Field<CrossLoadTypeGraphType, CrossLoadType>("CrossLoadTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CrossLoadTypeGraphType>(
                        "CrossLoadDetail-CrossLoadType-loader",
                        async ids => 
                        {
                            var data = await dbContext.CrossLoadTypes
                                .Where(x => x.CrossLoadType != null && ids.Contains((byte)x.CrossLoadType))
                                .Select(x => new
                                {
                                    Key = (byte)x.CrossLoadType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CrossLoadType);
                });
            
			
            Field<LoadGraphType, Load>("Loads")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, LoadGraphType>(
                        "CrossLoadDetail-Load-loader",
                        async ids => 
                        {
                            var data = await dbContext.Loads
                                .Where(x => x.Load != null && ids.Contains((byte)x.Load))
                                .Select(x => new
                                {
                                    Key = (byte)x.Load!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Load);
                });
            
        }
    }
}
            