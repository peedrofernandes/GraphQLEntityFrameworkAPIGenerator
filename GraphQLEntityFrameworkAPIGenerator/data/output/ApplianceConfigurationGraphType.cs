
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
    public partial class ApplianceConfigurationGraphType : ObjectGraphType<ApplianceConfiguration>
    {
        public ApplianceConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ApplianceConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MinimumOnTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MinimumOffTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<AppConfigCompartmentDetailGraphType, AppConfigCompartmentDetail>("AppConfigCompartmentDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<AppConfigCompartmentDetailGraphType>>(
                        "ApplianceConfiguration-AppConfigCompartmentDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.ApplianceConfigurationAppConfigCompartmentDetail
                                .Where(x => x.ApplianceConfigurationId != null && ids.Contains((Guid)x.ApplianceConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.ApplianceConfigurationId!,
                                    Value = x.AppConfigCompartmentDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.AppConfigCompartmentDetails);
                });
            
			
            Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                        "ApplianceConfiguration-MachineConfiguration-loader",
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
            