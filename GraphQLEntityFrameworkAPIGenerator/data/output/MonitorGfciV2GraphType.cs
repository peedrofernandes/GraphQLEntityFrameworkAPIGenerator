
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
    public partial class MonitorGfciV2GraphType : ObjectGraphType<MonitorGfciV2>
    {
        public MonitorGfciV2GraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MonitorGfciV2id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Cav1NumberOfLoads, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Cav1DutyPeriod, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Cav1NumberOfCycles, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Cav1LoadId1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Cav1LoadStartTime1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Cav1LoadStopTime1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Cav1LoadId2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Cav1LoadStartTime2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Cav1LoadStopTime2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Cav1LoadId3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Cav1LoadStartTime3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Cav1LoadStopTime3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Cav1LoadId4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Cav1LoadStartTime4, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Cav1LoadStopTime4, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Cav1LoadId5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Cav1LoadStartTime5, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Cav1LoadStopTime5, type: typeof(IdGraphType), nullable: False);
			Field(t => t.NumberOfCavities, type: typeof(ByteGraphType), nullable: False);
            
            Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                        "MonitorGfciV2-MachineConfiguration-loader",
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
            