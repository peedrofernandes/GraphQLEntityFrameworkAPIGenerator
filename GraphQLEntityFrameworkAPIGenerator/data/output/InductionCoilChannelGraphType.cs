
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
    public partial class InductionCoilChannelGraphType : ObjectGraphType<InductionCoilChannel>
    {
        public InductionCoilChannelGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CoilChannelId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CoilNtcGiid, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.AssistedCookingNtcGiid, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ResonanceCapacity, type: typeof(IdGraphType), nullable: True);
			Field(t => t.ResonantCapacitorPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<InductionCoilPowerTableConfigurationGraphType, InductionCoilPowerTableConfiguration>("InductionCoilPowerTableConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilPowerTableConfigurationGraphType>(
                        "InductionCoilChannel-InductionCoilPowerTableConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionCoilPowerTableConfigurations
                                .Where(x => x.InductionCoilPowerTableConfiguration != null && ids.Contains((Guid)x.InductionCoilPowerTableConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionCoilPowerTableConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionCoilPowerTableConfiguration);
                });
            
			
            Field<InductionCoilTypeGraphType, InductionCoilType>("InductionCoilTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, InductionCoilTypeGraphType>(
                        "InductionCoilChannel-InductionCoilType-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionCoilTypes
                                .Where(x => x.InductionCoilType != null && ids.Contains((byte)x.InductionCoilType))
                                .Select(x => new
                                {
                                    Key = (byte)x.InductionCoilType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionCoilType);
                });
            
			
            Field<InductionInverterChannelConfigurationGraphType, InductionInverterChannelConfiguration>("InductionInverterChannelConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionInverterChannelConfigurationGraphType>>(
                        "InductionCoilChannel-InductionInverterChannelConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionInverterChannelConfigurations
                                .Where(x => x.InductionInverterChannelConfiguration != null && ids.Contains((Guid)x.InductionInverterChannelConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionInverterChannelConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.InductionInverterChannelConfigurations);
                });
            
        }
    }
}
            