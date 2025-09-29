
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
    public partial class MonitorLightGraphType : ObjectGraphType<MonitorLight>
    {
        public MonitorLightGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LightConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NoFadingNeeded, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HmidriverPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DoorDriverPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CycleDriverPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.HmifadeOn, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.HmifadeOff, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.HmimaximumIntensity, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.HmiminimumIntensity, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DoorFadeOn, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.DoorFadeOff, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.DoorMaximumIntensity, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DoorMinimumIntensity, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.CycleFadeOn, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.CycleFadeOff, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.CycleMaximumIntensity, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.CycleMinimumIntensity, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.AutoOffTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.HmiToggleControl, type: typeof(BoolGraphType), nullable: False);
            
            Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                        "MonitorLight-MachineConfiguration-loader",
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
            