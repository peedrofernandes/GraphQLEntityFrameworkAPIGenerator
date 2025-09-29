
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
    public partial class MonitorPowerDetectGraphType : ObjectGraphType<MonitorPowerDetect>
    {
        public MonitorPowerDetectGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PowerDetectMonitorId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Volts120Maximum, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Degrees120Minimum, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Degrees120Maximum, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Degrees180Minimum, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Degrees180Maximum, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Degrees240Minimum, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Degrees240Maximum, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Degrees360Minimum, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Degrees0Maximum, type: typeof(ShortGraphType), nullable: False);
            
            Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                        "MonitorPowerDetect-MachineConfiguration-loader",
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
            