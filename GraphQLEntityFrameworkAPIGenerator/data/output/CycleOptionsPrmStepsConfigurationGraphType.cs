
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
    public partial class CycleOptionsPrmStepsConfigurationGraphType : ObjectGraphType<CycleOptionsPrmStepsConfiguration>
    {
        public CycleOptionsPrmStepsConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleOptionsPrmStepsConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<CycleOptionsStepDetailGraphType, CycleOptionsStepDetail>("CycleOptionsStepDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsStepDetailGraphType>>(
                        "CycleOptionsPrmStepsConfiguration-CycleOptionsStepDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail
                                .Where(x => x.CycleOptionsPrmStepsConfigId != null && ids.Contains((Guid)x.CycleOptionsPrmStepsConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleOptionsPrmStepsConfigId!,
                                    Value = x.CycleOptionsStepDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleOptionsStepDetails);
                });
            
        }
    }
}
            