
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
    public partial class PrtimerConvectTimerDecrementGraphType : ObjectGraphType<PrtimerConvectTimerDecrement>
    {
        public PrtimerConvectTimerDecrementGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerConvectTimerDecrementId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfFanSpeeds, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeed0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeed1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeed2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeed3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeed4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeed5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FanSpeed6, type: typeof(ByteGraphType), nullable: False);
            
            Field<PowerReductionTimerConfigurationGraphType, PowerReductionTimerConfiguration>("PowerReductionTimerConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PowerReductionTimerConfigurationGraphType>>(
                        "PrtimerConvectTimerDecrement-PowerReductionTimerConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.PowerReductionTimerConfigurations
                                .Where(x => x.PowerReductionTimerConfiguration != null && ids.Contains((Guid)x.PowerReductionTimerConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PowerReductionTimerConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.PowerReductionTimerConfigurations);
                });
            
        }
    }
}
            