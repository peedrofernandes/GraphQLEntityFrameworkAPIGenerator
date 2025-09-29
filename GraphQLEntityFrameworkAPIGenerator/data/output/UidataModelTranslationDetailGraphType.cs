
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
    public partial class UidataModelTranslationDetailGraphType : ObjectGraphType<UidataModelTranslationDetail>
    {
        public UidataModelTranslationDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UidataModelTranslationDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DataModelKeyValue, type: typeof(IdGraphType), nullable: False);
			Field(t => t.DataModelType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DataModelSubType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DataModelNamespace, type: typeof(ByteGraphType), nullable: True);
            
            Field<UidataModelKeyMappingGraphType, UidataModelKeyMapping>("UidataModelKeyMappings")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UidataModelKeyMappingGraphType>(
                        "UidataModelTranslationDetail-UidataModelKeyMapping-loader",
                        async ids => 
                        {
                            var data = await dbContext.UidataModelKeyMappings
                                .Where(x => x.UidataModelKeyMapping != null && ids.Contains((Guid)x.UidataModelKeyMapping))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UidataModelKeyMapping!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UidataModelKeyMapping);
                });
            
			
            Field<UidataModelTranslationConfigurationGraphType, UidataModelTranslationConfiguration>("UidataModelTranslationConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UidataModelTranslationConfigurationGraphType>>(
                        "UidataModelTranslationDetail-UidataModelTranslationConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UidataModelTranslationConfigurationsUidataModelTranslationDetail
                                .Where(x => x.UidataModelTranslationConfigurationId != null && ids.Contains((Guid)x.UidataModelTranslationConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UidataModelTranslationConfigurationId!,
                                    Value = x.UidataModelTranslationConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UidataModelTranslationConfigurations);
                });
            
        }
    }
}
            