
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
    public partial class OpenDoorHeatingCyclesConfigurationGraphType : ObjectGraphType<OpenDoorHeatingCyclesConfiguration>
    {
        public OpenDoorHeatingCyclesConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.OpenDoorHeatingCyclesConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Code, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
            
            Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                        "OpenDoorHeatingCyclesConfiguration-MachineConfiguration-loader",
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
            
			
            Field<OpenDoorHeatingCyclesDetailGraphType, OpenDoorHeatingCyclesDetail>("OpenDoorHeatingCyclesDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<OpenDoorHeatingCyclesDetailGraphType>>(
                        "OpenDoorHeatingCyclesConfiguration-OpenDoorHeatingCyclesDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail
                                .Where(x => x.OpenDoorHeatingCyclesConfigId != null && ids.Contains((Guid)x.OpenDoorHeatingCyclesConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.OpenDoorHeatingCyclesConfigId!,
                                    Value = x.OpenDoorHeatingCyclesDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.OpenDoorHeatingCyclesDetails);
                });
            
        }
    }
}
            