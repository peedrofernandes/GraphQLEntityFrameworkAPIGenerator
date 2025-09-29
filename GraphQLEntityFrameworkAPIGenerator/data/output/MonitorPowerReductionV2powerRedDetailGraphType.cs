
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
    public partial class MonitorPowerReductionV2powerRedDetailGraphType : ObjectGraphType<MonitorPowerReductionV2powerRedDetail>
    {
        public MonitorPowerReductionV2powerRedDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorPowerReductionV2powerRedDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.TempLimit, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.DeltaTemp, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CavityTempLimit, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.PowerLimitLoad0Na, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PowerLimitLoad1Na, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PowerLimitLoad2Na, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PowerLimitLoad3Na, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PowerLimitLoad4Na, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CavityTempLimitNa, type: typeof(BoolGraphType), nullable: False);
            
            Field<MonitorPowerReductionV2powerRedConfigurationGraphType, MonitorPowerReductionV2powerRedConfiguration>("MonitorPowerReductionV2powerRedConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorPowerReductionV2powerRedConfigurationGraphType>>(
                        "MonitorPowerReductionV2powerRedDetail-MonitorPowerReductionV2powerRedConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail
                                .Where(x => x.MonitorPowerReductionV2powerRedConfigurationId != null && ids.Contains((Guid)x.MonitorPowerReductionV2powerRedConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorPowerReductionV2powerRedConfigurationId!,
                                    Value = x.MonitorPowerReductionV2powerRedConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorPowerReductionV2powerRedConfigurations);
                });
            
        }
    }
}
            