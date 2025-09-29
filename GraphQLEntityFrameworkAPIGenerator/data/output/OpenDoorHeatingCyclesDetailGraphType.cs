
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
    public partial class OpenDoorHeatingCyclesDetailGraphType : ObjectGraphType<OpenDoorHeatingCyclesDetail>
    {
        public OpenDoorHeatingCyclesDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.OpenDoorHeatingCyclesDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CycleName, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(StringGraphType), nullable: False);
			Field(t => t.ConvFanFlag, type: typeof(BoolGraphType), nullable: False);
            
            Field<OpenDoorHeatingCyclesConfigurationGraphType, OpenDoorHeatingCyclesConfiguration>("OpenDoorHeatingCyclesConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<OpenDoorHeatingCyclesConfigurationGraphType>>(
                        "OpenDoorHeatingCyclesDetail-OpenDoorHeatingCyclesConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail
                                .Where(x => x.OpenDoorHeatingCyclesConfigId != null && ids.Contains((Guid)x.OpenDoorHeatingCyclesConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.OpenDoorHeatingCyclesConfigId!,
                                    Value = x.OpenDoorHeatingCyclesConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.OpenDoorHeatingCyclesConfigurations);
                });
            
        }
    }
}
            