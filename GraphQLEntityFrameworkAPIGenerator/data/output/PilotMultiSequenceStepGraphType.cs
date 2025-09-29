
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
    public partial class PilotMultiSequenceStepGraphType : ObjectGraphType<PilotMultiSequenceStep>
    {
        public PilotMultiSequenceStepGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.StepDuration, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.PilotStatesId0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PilotStatesId1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.PilotStatesId2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.PilotStatesId3, type: typeof(ByteGraphType), nullable: True);
            
            Field<PilotMultiSequenceDetailGraphType, PilotMultiSequenceDetail>("PilotMultiSequenceDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PilotMultiSequenceDetailGraphType>>(
                        "PilotMultiSequenceStep-PilotMultiSequenceDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.PilotMultiSequenceDetailsStep
                                .Where(x => x.DetailsId != null && ids.Contains((Guid)x.DetailsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.DetailsId!,
                                    Value = x.Details,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PilotMultiSequenceDetails);
                });
            
        }
    }
}
            