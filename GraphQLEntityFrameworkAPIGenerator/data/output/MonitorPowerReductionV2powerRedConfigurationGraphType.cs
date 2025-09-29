
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
    public partial class MonitorPowerReductionV2powerRedConfigurationGraphType : ObjectGraphType<MonitorPowerReductionV2powerRedConfiguration>
    {
        public MonitorPowerReductionV2powerRedConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorPowerReductionV2powerRedConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<MonitorPowerReductionV2detailGraphType, MonitorPowerReductionV2detail>("MonitorPowerReductionV2details")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorPowerReductionV2detailGraphType>>(
                        "MonitorPowerReductionV2powerRedConfiguration-MonitorPowerReductionV2detail-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorPowerReductionV2details
                                .Where(x => x.MonitorPowerReductionV2detail != null && ids.Contains((Guid)x.MonitorPowerReductionV2detail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorPowerReductionV2detail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.MonitorPowerReductionV2details);
                });
            
			
            Field<MonitorPowerReductionV2powerRedDetailGraphType, MonitorPowerReductionV2powerRedDetail>("MonitorPowerReductionV2powerRedDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MonitorPowerReductionV2powerRedDetailGraphType>>(
                        "MonitorPowerReductionV2powerRedConfiguration-MonitorPowerReductionV2powerRedDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail
                                .Where(x => x.MonitorPowerReductionV2powerRedConfigurationId != null && ids.Contains((Guid)x.MonitorPowerReductionV2powerRedConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MonitorPowerReductionV2powerRedConfigurationId!,
                                    Value = x.MonitorPowerReductionV2powerRedDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MonitorPowerReductionV2powerRedDetails);
                });
            
        }
    }
}
            