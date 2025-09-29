
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
    public partial class PrtimerConvectUserPhaseNameConfigurationGraphType : ObjectGraphType<PrtimerConvectUserPhaseNameConfiguration>
    {
        public PrtimerConvectUserPhaseNameConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerConvectUserPhaseNameConfigId, type: typeof(GuidGraphType), nullable: False);
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
            
            Field<PrtimerConvectConfigurationGraphType, PrtimerConvectConfiguration>("PrtimerConvectConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerConvectConfigurationGraphType>>(
                        "PrtimerConvectUserPhaseNameConfiguration-PrtimerConvectConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration
                                .Where(x => x.PrtimerConvectConfigId != null && ids.Contains((Guid)x.PrtimerConvectConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerConvectConfigId!,
                                    Value = x.PrtimerConvectConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerConvectConfigurations);
                });
            
			
            Field<PrtimerConvectUserPhaseNameDetailGraphType, PrtimerConvectUserPhaseNameDetail>("PrtimerConvectUserPhaseNameDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerConvectUserPhaseNameDetailGraphType>>(
                        "PrtimerConvectUserPhaseNameConfiguration-PrtimerConvectUserPhaseNameDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail
                                .Where(x => x.PrtimerConvectUserPhaseNameConfigId != null && ids.Contains((Guid)x.PrtimerConvectUserPhaseNameConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerConvectUserPhaseNameConfigId!,
                                    Value = x.PrtimerConvectUserPhaseNameDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerConvectUserPhaseNameDetails);
                });
            
        }
    }
}
            