
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
    public partial class FaultRelayLoadFailureFaultConditionGraphType : ObjectGraphType<FaultRelayLoadFailureFaultCondition>
    {
        public FaultRelayLoadFailureFaultConditionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FaultConditionId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Gi1MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Gi2MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load1MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load2MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load3MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load4MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load5MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load6MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load7MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load8MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load9MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load10MonitoredState, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Gi1Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Gi2Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load1Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load2Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load3Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load4Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load5Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load6Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load7Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load8Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load9Ignore, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Load10Ignore, type: typeof(BoolGraphType), nullable: False);
            
            Field<FaultPrmRelayLoadFailureGraphType, FaultPrmRelayLoadFailure>("FaultPrmRelayLoadFailures")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<FaultPrmRelayLoadFailureGraphType>>(
                        "FaultRelayLoadFailureFaultCondition-FaultPrmRelayLoadFailure-loader",
                        async ids => 
                        {
                            var data = await dbContext.FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition
                                .Where(x => x.FaultPrmRelayLoadFailureId != null && ids.Contains((Guid)x.FaultPrmRelayLoadFailureId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.FaultPrmRelayLoadFailureId!,
                                    Value = x.FaultPrmRelayLoadFailure,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.FaultPrmRelayLoadFailures);
                });
            
        }
    }
}
            