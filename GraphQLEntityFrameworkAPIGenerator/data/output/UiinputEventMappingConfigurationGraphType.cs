
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
    public partial class UiinputEventMappingConfigurationGraphType : ObjectGraphType<UiinputEventMappingConfiguration>
    {
        public UiinputEventMappingConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiinputEventMappingConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
            
            Field<UigenericInputConfigurationGraphType, UigenericInputConfiguration>("UigenericInputConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UigenericInputConfigurationGraphType>>(
                        "UiinputEventMappingConfiguration-UigenericInputConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UigenericInputConfigurations
                                .Where(x => x.UigenericInputConfiguration != null && ids.Contains((Guid)x.UigenericInputConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UigenericInputConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UigenericInputConfigurations);
                });
            
			
            Field<UiinputEventMappingDetailGraphType, UiinputEventMappingDetail>("UiinputEventMappingDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiinputEventMappingDetailGraphType>>(
                        "UiinputEventMappingConfiguration-UiinputEventMappingDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiinputEventMappingConfigurationsUiinputEventMappingDetail
                                .Where(x => x.UiinputEventMappingConfigurationId != null && ids.Contains((Guid)x.UiinputEventMappingConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiinputEventMappingConfigurationId!,
                                    Value = x.UiinputEventMappingDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiinputEventMappingDetails);
                });
            
        }
    }
}
            