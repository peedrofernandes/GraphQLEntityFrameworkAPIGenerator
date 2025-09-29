
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
    public partial class MonitorSteamParamGraphType : ObjectGraphType<MonitorSteamParam>
    {
        public MonitorSteamParamGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorSteamParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ExtraTankPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ColdTankPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.RemovableDrawerPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.QuickCouplingTankPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.FillPumpMaxTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.DrainPumpMaxTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.FillPlumbingPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.FillExtraTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.LowLevelTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.RecommendNewFilterVolume, type: typeof(IdGraphType), nullable: False);
			Field(t => t.RequireNewFilterVolume, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ColdTankToWarmTankFlowRate, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.DrainPumpFlowRate, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.QuickCouplingFlowRate, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PlumbingPumpFlowRate, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.SteamGeneratorFlowRate, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TipsPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.RefillTimeThreshold, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.AllowDynamicFlowCalibration, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SteamSystemType, type: typeof(BoolGraphType), nullable: False);
            
            Field<MonitorSteamGraphType, MonitorSteam>("MonitorSteams")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorSteamGraphType>>(
                        "MonitorSteamParam-MonitorSteam-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorSteams
                                .Where(x => x.MonitorSteam != null && ids.Contains((Guid)x.MonitorSteam))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorSteam!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.MonitorSteams);
                });
            
        }
    }
}
            