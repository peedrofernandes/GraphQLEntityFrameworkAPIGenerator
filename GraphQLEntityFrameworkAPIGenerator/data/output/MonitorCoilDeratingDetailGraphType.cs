
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
    public partial class MonitorCoilDeratingDetailGraphType : ObjectGraphType<MonitorCoilDeratingDetail>
    {
        public MonitorCoilDeratingDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorCoilDeratingDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.EnableHeatsink, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.EnableCoil, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.MonoGlobal, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.MonoLocal, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PhaseTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureMinCoil, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureRefCoil, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureMaxCoil, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ControlDpCoil, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ControlDiCoil, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MaxPercentSoft, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MaxPercentHard, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureMinHeatsinkSoft, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureRefHeatsinkSoft, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureMaxHeatsinkSoft, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureMinHeatsinkHard, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureRefHeatsinkHard, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureMaxHeatsinkHard, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ControlDpHeatsinkSoft, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ControlDiHeatsinkHard, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ControlDpHeatsinkHard, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.ControlDiHeatsinkSoft, type: typeof(FloatGraphType), nullable: False);
            
            Field<MonitorCoilDeratingConfigurationGraphType, MonitorCoilDeratingConfiguration>("MonitorCoilDeratingConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorCoilDeratingConfigurationGraphType>>(
                        "MonitorCoilDeratingDetail-MonitorCoilDeratingConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail
                                .Where(x => x.MonitorCoilDeratingConfigurationId != null && ids.Contains((Guid)x.MonitorCoilDeratingConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorCoilDeratingConfigurationId!,
                                    Value = x.MonitorCoilDeratingConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorCoilDeratingConfigurations);
                });
            
        }
    }
}
            