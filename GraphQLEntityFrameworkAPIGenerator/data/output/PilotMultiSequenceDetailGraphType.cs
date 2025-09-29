
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
    public partial class PilotMultiSequenceDetailGraphType : ObjectGraphType<PilotMultiSequenceDetail>
    {
        public PilotMultiSequenceDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfSteps, type: typeof(ByteGraphType), nullable: False);
            
            Field<PilotMultiSequenceConfigGraphType, PilotMultiSequenceConfig>("PilotMultiSequenceConfigs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PilotMultiSequenceConfigGraphType>>(
                        "PilotMultiSequenceDetail-PilotMultiSequenceConfig-loader",
                        async ids => 
                        {
                            var data = await dbContext.PilotMultiSequenceConfigDetail
                                .Where(x => x.ConfigId != null && ids.Contains((Guid)x.ConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.ConfigId!,
                                    Value = x.Config,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PilotMultiSequenceConfigs);
                });
            
			
            Field<PilotMultiSequenceStepGraphType, PilotMultiSequenceStep>("PilotMultiSequenceSteps")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PilotMultiSequenceStepGraphType>>(
                        "PilotMultiSequenceDetail-PilotMultiSequenceStep-loader",
                        async ids => 
                        {
                            var data = await dbContext.PilotMultiSequenceDetailsStep
                                .Where(x => x.DetailsId != null && ids.Contains((Guid)x.DetailsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.DetailsId!,
                                    Value = x.IdNavigation,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PilotMultiSequenceSteps);
                });
            
        }
    }
}
            