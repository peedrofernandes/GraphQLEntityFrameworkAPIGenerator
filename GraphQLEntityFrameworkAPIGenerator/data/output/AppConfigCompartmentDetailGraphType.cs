
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
    public partial class AppConfigCompartmentDetailGraphType : ObjectGraphType<AppConfigCompartmentDetail>
    {
        public AppConfigCompartmentDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.AppConfigCompartmentDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Name, type: typeof(StringGraphType), nullable: False);
			Field(t => t.CompartmentType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.HallEffectSensorPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.BackupRestore, type: typeof(ByteGraphType), nullable: False);
            
            Field<ApplianceConfigurationGraphType, ApplianceConfiguration>("ApplianceConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ApplianceConfigurationGraphType>>(
                        "AppConfigCompartmentDetail-ApplianceConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.ApplianceConfigurationAppConfigCompartmentDetail
                                .Where(x => x.ApplianceConfigurationId != null && ids.Contains((Guid)x.ApplianceConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.ApplianceConfigurationId!,
                                    Value = x.ApplianceConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.ApplianceConfigurations);
                });
            
			
            Field<AppConfigCoolingFanCompartmentGraphType, AppConfigCoolingFanCompartment>("AppConfigCoolingFanCompartments")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, AppConfigCoolingFanCompartmentGraphType>(
                        "AppConfigCompartmentDetail-AppConfigCoolingFanCompartment-loader",
                        async ids => 
                        {
                            var data = await dbContext.AppConfigCoolingFanCompartments
                                .Where(x => x.AppConfigCoolingFanCompartment != null && ids.Contains((Guid)x.AppConfigCoolingFanCompartment))
                                .Select(x => new
                                {
                                    Key = (Guid)x.AppConfigCoolingFanCompartment!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.AppConfigCoolingFanCompartment);
                });
            
			
            Field<AppConfigOvenMwcompartmentGraphType, AppConfigOvenMwcompartment>("AppConfigOvenMwcompartments")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, AppConfigOvenMwcompartmentGraphType>(
                        "AppConfigCompartmentDetail-AppConfigOvenMwcompartment-loader",
                        async ids => 
                        {
                            var data = await dbContext.AppConfigOvenMwcompartments
                                .Where(x => x.AppConfigOvenMwcompartment != null && ids.Contains((Guid)x.AppConfigOvenMwcompartment))
                                .Select(x => new
                                {
                                    Key = (Guid)x.AppConfigOvenMwcompartment!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.AppConfigOvenMwcompartment);
                });
            
        }
    }
}
            