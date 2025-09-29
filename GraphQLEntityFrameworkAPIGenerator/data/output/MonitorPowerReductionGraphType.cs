
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
    public partial class MonitorPowerReductionGraphType : ObjectGraphType<MonitorPowerReduction>
    {
        public MonitorPowerReductionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorPowerReductionId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                        "MonitorPowerReduction-MachineConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MachineConfigurations
                                .Where(x => x.MachineConfiguration != null && ids.Contains((Guid)x.MachineConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MachineConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.MachineConfigurations);
                });
            
			
            Field<PowerReductionTimerConfigurationGraphType, PowerReductionTimerConfiguration>("PowerReductionTimerConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PowerReductionTimerConfigurationGraphType>(
                        "MonitorPowerReduction-PowerReductionTimerConfiguration-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PowerReductionTimerConfiguration);
                });
            
        }
    }
}
            