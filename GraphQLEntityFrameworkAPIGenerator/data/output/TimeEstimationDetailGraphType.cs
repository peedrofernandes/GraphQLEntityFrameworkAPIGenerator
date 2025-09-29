
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
    public partial class TimeEstimationDetailGraphType : ObjectGraphType<TimeEstimationDetail>
    {
        public TimeEstimationDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.TimeEstimationDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.ModifiersLabel, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<ModifierGraphType, Modifier>("Modifiers")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ModifierGraphType>(
                        "TimeEstimationDetail-Modifier-loader",
                        async ids => 
                        {
                            var data = await dbContext.Modifiers
                                .Where(x => x.Modifier != null && ids.Contains((Guid)x.Modifier))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Modifier!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Modifier);
                });
            
			
            Field<TimeEstimationConfigurationGraphType, TimeEstimationConfiguration>("TimeEstimationConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<TimeEstimationConfigurationGraphType>>(
                        "TimeEstimationDetail-TimeEstimationConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.TimeEstimationConfigurationsTimeEstimationDetail
                                .Where(x => x.TimeEstimationConfigurationId != null && ids.Contains((Guid)x.TimeEstimationConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.TimeEstimationConfigurationId!,
                                    Value = x.TimeEstimationConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.TimeEstimationConfigurations);
                });
            
        }
    }
}
            