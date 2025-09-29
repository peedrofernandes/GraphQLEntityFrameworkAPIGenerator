
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
    public partial class PrtimerBroilUserPhaseNameConfigurationGraphType : ObjectGraphType<PrtimerBroilUserPhaseNameConfiguration>
    {
        public PrtimerBroilUserPhaseNameConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerBroilUserPhaseNameConfigId, type: typeof(GuidGraphType), nullable: False);
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
            
            Field<PrtimerBroilConfigurationGraphType, PrtimerBroilConfiguration>("PrtimerBroilConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerBroilConfigurationGraphType>>(
                        "PrtimerBroilUserPhaseNameConfiguration-PrtimerBroilConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration
                                .Where(x => x.PrtimerBroilConfigId != null && ids.Contains((Guid)x.PrtimerBroilConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerBroilConfigId!,
                                    Value = x.PrtimerBroilConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerBroilConfigurations);
                });
            
			
            Field<PrtimerBroilUserPhaseNameDetailGraphType, PrtimerBroilUserPhaseNameDetail>("PrtimerBroilUserPhaseNameDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerBroilUserPhaseNameDetailGraphType>>(
                        "PrtimerBroilUserPhaseNameConfiguration-PrtimerBroilUserPhaseNameDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail
                                .Where(x => x.PrtimerBroilUserPhaseNameConfigId != null && ids.Contains((Guid)x.PrtimerBroilUserPhaseNameConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrtimerBroilUserPhaseNameConfigId!,
                                    Value = x.PrtimerBroilUserPhaseNameDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrtimerBroilUserPhaseNameDetails);
                });
            
        }
    }
}
            