
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
    public partial class MultiSequencePilotTypeGraphType : ObjectGraphType<MultiSequencePilotType>
    {
        public MultiSequencePilotTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PilotTypeId, type: typeof(ByteGraphType), nullable: False);
            
            Field<PilotTypeGraphType, PilotType>("PilotTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, PilotTypeGraphType>(
                        "MultiSequencePilotType-PilotType-loader",
                        async ids => 
                        {
                            var data = await dbContext.PilotTypes
                                .Where(x => x.PilotType != null && ids.Contains((byte)x.PilotType))
                                .Select(x => new
                                {
                                    Key = (byte)x.PilotType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PilotTypes);
                });
            
			
            Field<PrmPilotMultiSequenceGraphType, PrmPilotMultiSequence>("PrmPilotMultiSequences")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmPilotMultiSequenceGraphType>>(
                        "MultiSequencePilotType-PrmPilotMultiSequence-loader",
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
            