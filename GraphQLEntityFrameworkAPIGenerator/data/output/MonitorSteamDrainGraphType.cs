
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
    public partial class MonitorSteamDrainGraphType : ObjectGraphType<MonitorSteamDrain>
    {
        public MonitorSteamDrainGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorSteamDrainId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DrainToQcTank, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DrainToRemoveableDrawer, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DrainToExternal, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DrainToPlumbedOutlet, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.AutoDrainPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.BoilerTempSensorPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.RecommendDrainTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.RequireDrainTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.MinTimeBeforeDrain, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.MaxDrainTemp, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DrainPumpExtraTime, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.BoilerTempDebounceTime, type: typeof(ShortGraphType), nullable: False);
            
            Field<MonitorSteamGraphType, MonitorSteam>("MonitorSteams")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorSteamGraphType>>(
                        "MonitorSteamDrain-MonitorSteam-loader",
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
            