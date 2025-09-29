
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
    public partial class MonitorSteamDescaleGraphType : ObjectGraphType<MonitorSteamDescale>
    {
        public MonitorSteamDescaleGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorSteamDescaleId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfWaterHardnessCoeff, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RecommendDescaleHours, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.RequireDescaleHours, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.RecommendDescaleEfficiency, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReqiureDescaleEfficiency, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff5, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff6, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff7, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff8, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff9, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.WaterHardnessCoeff10, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.DescaleDetectionMethod, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TimeBasedDescale, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.BoilerEfficiencyBasedDescale, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.WaterLevelSensorBasedDescale, type: typeof(BoolGraphType), nullable: False);
            
            Field<MonitorSteamGraphType, MonitorSteam>("MonitorSteams")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorSteamGraphType>>(
                        "MonitorSteamDescale-MonitorSteam-loader",
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
            