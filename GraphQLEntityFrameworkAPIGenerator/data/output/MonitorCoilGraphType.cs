
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
    public partial class MonitorCoilGraphType : ObjectGraphType<MonitorCoil>
    {
        public MonitorCoilGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorCoilId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.GlobalMainRelay, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.StructureVersion, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CoilPanPresentDebounceTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CoilHotSurfaceDebounceTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MainRelayOpenDelayTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CoilPanDetectionTimeout, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CoilHotSurfaceRaise, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.CoilHotSurfaceClear, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.CoilOvertemperatureRaise, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.CoilOvertemperatureClear, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.HeatsinkOvertemperatureRaise, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.HeatsinkOvertemperatureClear, type: typeof(FloatGraphType), nullable: False);
            
            Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                        "MonitorCoil-MachineConfiguration-loader",
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
            
        }
    }
}
            