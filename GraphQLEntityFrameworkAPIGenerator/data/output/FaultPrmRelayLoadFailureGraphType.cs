
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
    public partial class FaultPrmRelayLoadFailureGraphType : ObjectGraphType<FaultPrmRelayLoadFailure>
    {
        public FaultPrmRelayLoadFailureGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FaultPrmRelayLoadFailureId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfLoads, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberofGis, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Gi1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Gi2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load3, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load4, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load5, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load6, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load7, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load8, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load9, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Load10, type: typeof(ShortGraphType), nullable: False);
            
            Field<FaultRelayLoadFailureFaultConditionGraphType, FaultRelayLoadFailureFaultCondition>("FaultRelayLoadFailureFaultConditions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<FaultRelayLoadFailureFaultConditionGraphType>>(
                        "FaultPrmRelayLoadFailure-FaultRelayLoadFailureFaultCondition-loader",
                        async ids => 
                        {
                            var data = await dbContext.FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition
                                .Where(x => x.FaultPrmRelayLoadFailureId != null && ids.Contains((Guid)x.FaultPrmRelayLoadFailureId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.FaultPrmRelayLoadFailureId!,
                                    Value = x.FaultCondition,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.FaultRelayLoadFailureFaultConditions);
                });
            
        }
    }
}
            