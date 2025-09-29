
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
    public partial class PilotMultiSequenceConfigGraphType : ObjectGraphType<PilotMultiSequenceConfig>
    {
        public PilotMultiSequenceConfigGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfSequence, type: typeof(ByteGraphType), nullable: False);
            
            Field<PilotMultiSequenceDetailGraphType, PilotMultiSequenceDetail>("PilotMultiSequenceDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PilotMultiSequenceDetailGraphType>>(
                        "PilotMultiSequenceConfig-PilotMultiSequenceDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.PilotMultiSequenceConfigDetail
                                .Where(x => x.ConfigId != null && ids.Contains((Guid)x.ConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.ConfigId!,
                                    Value = x.Details,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PilotMultiSequenceDetails);
                });
            
			
            Field<PrmPilotMultiSequenceGraphType, PrmPilotMultiSequence>("PrmPilotMultiSequences")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmPilotMultiSequenceGraphType>>(
                        "PilotMultiSequenceConfig-PrmPilotMultiSequence-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrmPilotMultiSequences
                                .Where(x => x.PrmPilotMultiSequence != null && ids.Contains((Guid)x.PrmPilotMultiSequence))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrmPilotMultiSequence!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.PrmPilotMultiSequences);
                });
            
        }
    }
}
            