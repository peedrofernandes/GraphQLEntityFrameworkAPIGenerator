
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
    public partial class MonitorSteamerParamGraphType : ObjectGraphType<MonitorSteamerParam>
    {
        public MonitorSteamerParamGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorSteamerParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.FillPumpOnTime, type: typeof(DecimalGraphType), nullable: False);
			Field(t => t.FillPumpOffTime, type: typeof(DecimalGraphType), nullable: False);
			Field(t => t.FillPumpOnTemp, type: typeof(IdGraphType), nullable: False);
			Field(t => t.FillPumpDeltaTemp, type: typeof(IdGraphType), nullable: False);
			Field(t => t.DrainPumpOnTime, type: typeof(DecimalGraphType), nullable: False);
			Field(t => t.SteamerTempUpperThreshold, type: typeof(IdGraphType), nullable: False);
			Field(t => t.SteamerTempLowerThreshold, type: typeof(IdGraphType), nullable: False);
			Field(t => t.FillPumpOnTimeDescale, type: typeof(DecimalGraphType), nullable: False);
			Field(t => t.DescaleTempUpperThreshold, type: typeof(IdGraphType), nullable: False);
			Field(t => t.DescaleTempLowerThreshold, type: typeof(IdGraphType), nullable: False);
            
            Field<MonitorSteamGraphType, MonitorSteam>("MonitorSteams")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorSteamGraphType>>(
                        "MonitorSteamerParam-MonitorSteam-loader",
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
            