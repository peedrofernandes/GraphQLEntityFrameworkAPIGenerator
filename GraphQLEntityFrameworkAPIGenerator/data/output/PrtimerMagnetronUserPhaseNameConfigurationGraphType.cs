
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
    public partial class PrtimerMagnetronUserPhaseNameConfigurationGraphType : ObjectGraphType<PrtimerMagnetronUserPhaseNameConfiguration>
    {
        public PrtimerMagnetronUserPhaseNameConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerMagnetronUserPhaseNameConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.UserPhaseName, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.NumberOfLevels, type: typeof(ByteGraphType), nullable: False);
            
            Field<PrtimerMagnetronConfigurationGraphType, PrtimerMagnetronConfiguration>("PrtimerMagnetronConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerMagnetronConfigurationGraphType>>(
                        "PrtimerMagnetronUserPhaseNameConfiguration-PrtimerMagnetronConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration
                                .Where(x => x.PrtimerMagnetronConfigId != null && ids.Contains((Guid)x.PrtimerMagnetronConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerMagnetronConfigId!,
                                    Value = x.PrtimerMagnetronConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerMagnetronConfigurations);
                });
            
			
            Field<PrtimerMagnetronUserPhaseNameDetailGraphType, PrtimerMagnetronUserPhaseNameDetail>("PrtimerMagnetronUserPhaseNameDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerMagnetronUserPhaseNameDetailGraphType>>(
                        "PrtimerMagnetronUserPhaseNameConfiguration-PrtimerMagnetronUserPhaseNameDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail
                                .Where(x => x.PrtimerMagnetronUserPhaseNameConfigId != null && ids.Contains((Guid)x.PrtimerMagnetronUserPhaseNameConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerMagnetronUserPhaseNameConfigId!,
                                    Value = x.PrtimerMagnetronUserPhaseNameDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerMagnetronUserPhaseNameDetails);
                });
            
        }
    }
}
            