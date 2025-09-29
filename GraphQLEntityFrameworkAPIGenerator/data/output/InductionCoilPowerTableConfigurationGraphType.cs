
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
    public partial class InductionCoilPowerTableConfigurationGraphType : ObjectGraphType<InductionCoilPowerTableConfiguration>
    {
        public InductionCoilPowerTableConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionCoilPowerTableConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.BoosterLevel, type: typeof(ByteGraphType), nullable: False);
            
            Field<InductionCoilChannelGraphType, InductionCoilChannel>("InductionCoilChannels")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilChannelGraphType>>(
                        "InductionCoilPowerTableConfiguration-InductionCoilChannel-loader",
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
            
			
            Field<InductionCoilConfigGraphType, InductionCoilConfig>("InductionCoilConfigs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilConfigGraphType>>(
                        "InductionCoilPowerTableConfiguration-InductionCoilConfig-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionCoilConfigs
                                .Where(x => x.InductionCoilConfig != null && ids.Contains((Guid)x.InductionCoilConfig))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionCoilConfig!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.InductionCoilConfigs);
                });
            
			
            Field<InductionCoilPowerTableDetailGraphType, InductionCoilPowerTableDetail>("InductionCoilPowerTableDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilPowerTableDetailGraphType>>(
                        "InductionCoilPowerTableConfiguration-InductionCoilPowerTableDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail
                                .Where(x => x.InductionCoilPowerTableConfigId != null && ids.Contains((Guid)x.InductionCoilPowerTableConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionCoilPowerTableConfigId!,
                                    Value = x.InductionCoilPowerTableDetail,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionCoilPowerTableDetails);
                });
            
        }
    }
}
            