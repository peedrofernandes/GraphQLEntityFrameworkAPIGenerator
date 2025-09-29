
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
    public partial class PrtimerConvectTimerLimitConfigurationGraphType : ObjectGraphType<PrtimerConvectTimerLimitConfiguration>
    {
        public PrtimerConvectTimerLimitConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerConvectTimerLimitConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfLevels, type: typeof(ByteGraphType), nullable: False);
            
            Field<PrtimerConvectConfigurationGraphType, PrtimerConvectConfiguration>("PrtimerConvectConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerConvectConfigurationGraphType>>(
                        "PrtimerConvectTimerLimitConfiguration-PrtimerConvectConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerConvectConfigurations
                                .Where(x => x.PrtimerConvectConfiguration != null && ids.Contains((Guid)x.PrtimerConvectConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerConvectConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.PrtimerConvectConfigurations);
                });
            
			
            Field<PrtimerConvectTimerLimitDetailGraphType, PrtimerConvectTimerLimitDetail>("PrtimerConvectTimerLimitDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerConvectTimerLimitDetailGraphType>>(
                        "PrtimerConvectTimerLimitConfiguration-PrtimerConvectTimerLimitDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail
                                .Where(x => x.PrtimerConvectTimerLimitConfigId != null && ids.Contains((Guid)x.PrtimerConvectTimerLimitConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerConvectTimerLimitConfigId!,
                                    Value = x.PrtimerConvectTimerLimitDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerConvectTimerLimitDetails);
                });
            
        }
    }
}
            