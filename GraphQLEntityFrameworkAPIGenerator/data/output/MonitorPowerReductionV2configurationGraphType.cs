
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
    public partial class MonitorPowerReductionV2configurationGraphType : ObjectGraphType<MonitorPowerReductionV2configuration>
    {
        public MonitorPowerReductionV2configurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorPowerReductionV2configurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfFanSpeeds, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfEstimatedNodes, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Load0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Load1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Load2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Load3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Load4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Load5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfMeasuredNodes, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfLoads, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfOutputLoads, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OutputLoad0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OutputLoad1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OutputLoad2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OutputLoad3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OutputLoad4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CoolingFanId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.EnableEmptyCrispPanDetection, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.UseDifferentTempThreshold, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CrispMaxTime, type: typeof(IdGraphType), nullable: False);
            
            Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                        "MonitorPowerReductionV2configuration-MachineConfiguration-loader",
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
            
			
            Field<MonitorPowerReductionV2detailGraphType, MonitorPowerReductionV2detail>("MonitorPowerReductionV2details")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorPowerReductionV2detailGraphType>>(
                        "MonitorPowerReductionV2configuration-MonitorPowerReductionV2detail-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorPowerReductionV2configurationMonitorPowerReductionV2detail
                                .Where(x => x.MonitorPowerReductionV2configurationId != null && ids.Contains((Guid)x.MonitorPowerReductionV2configurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorPowerReductionV2configurationId!,
                                    Value = x.MonitorPowerReductionV2details,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorPowerReductionV2details);
                });
            
        }
    }
}
            