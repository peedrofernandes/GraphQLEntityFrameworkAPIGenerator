
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
    public partial class MonitorPowerReductionV2estimatedTempDetailGraphType : ObjectGraphType<MonitorPowerReductionV2estimatedTempDetail>
    {
        public MonitorPowerReductionV2estimatedTempDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorPowerReductionV2estimatedTempDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.TempLimit, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TempLimitKload0, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempLimitKload1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempLimitKload2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempLimitKload3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempLimitKload4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TempLimitKload5, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.CoolDownTempFan0, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.CoolDownTempFan1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.CoolDownTempFan2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.CavityTempTerm, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLimitLoad0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimitLoad5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CoolDownTempFan3, type: typeof(FloatGraphType), nullable: False);
            
            Field<MonitorPowerReductionV2estimatedTempConfigurationGraphType, MonitorPowerReductionV2estimatedTempConfiguration>("MonitorPowerReductionV2estimatedTempConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorPowerReductionV2estimatedTempConfigurationGraphType>>(
                        "MonitorPowerReductionV2estimatedTempDetail-MonitorPowerReductionV2estimatedTempConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail
                                .Where(x => x.MonitorPowerReductionV2estimatedTempConfigurationId != null && ids.Contains((Guid)x.MonitorPowerReductionV2estimatedTempConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorPowerReductionV2estimatedTempConfigurationId!,
                                    Value = x.MonitorPowerReductionV2estimatedTempConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorPowerReductionV2estimatedTempConfigurations);
                });
            
        }
    }
}
            