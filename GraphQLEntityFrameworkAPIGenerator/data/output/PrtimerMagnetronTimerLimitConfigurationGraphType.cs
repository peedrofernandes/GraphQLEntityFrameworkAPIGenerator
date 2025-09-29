
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
    public partial class PrtimerMagnetronTimerLimitConfigurationGraphType : ObjectGraphType<PrtimerMagnetronTimerLimitConfiguration>
    {
        public PrtimerMagnetronTimerLimitConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerMagnetronTimerLimitConfigId, type: typeof(GuidGraphType), nullable: False);
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
            
            Field<PrtimerMagnetronConfigurationGraphType, PrtimerMagnetronConfiguration>("PrtimerMagnetronConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerMagnetronConfigurationGraphType>>(
                        "PrtimerMagnetronTimerLimitConfiguration-PrtimerMagnetronConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerMagnetronConfigurations
                                .Where(x => x.PrtimerMagnetronConfiguration != null && ids.Contains((Guid)x.PrtimerMagnetronConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerMagnetronConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.PrtimerMagnetronConfigurations);
                });
            
			
            Field<PrtimerMagnetronTimerLimitDetailGraphType, PrtimerMagnetronTimerLimitDetail>("PrtimerMagnetronTimerLimitDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerMagnetronTimerLimitDetailGraphType>>(
                        "PrtimerMagnetronTimerLimitConfiguration-PrtimerMagnetronTimerLimitDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail
                                .Where(x => x.PrtimerMagnetronTimerLimitConfigId != null && ids.Contains((Guid)x.PrtimerMagnetronTimerLimitConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerMagnetronTimerLimitConfigId!,
                                    Value = x.PrtimerMagnetronTimerLimitDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerMagnetronTimerLimitDetails);
                });
            
        }
    }
}
            