
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
    public partial class DataModelDefinitionDetailGraphType : ObjectGraphType<DataModelDefinitionDetail>
    {
        public DataModelDefinitionDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DataModelDefinitionDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DataModelIndex, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Sort, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DataModelNamespace, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Entity, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Instance, type: typeof(StringGraphType), nullable: True);
			Field(t => t.AttributeName, type: typeof(StringGraphType), nullable: True);
			Field(t => t.AttributeDisplayName, type: typeof(StringGraphType), nullable: True);
			Field(t => t.PayloadDataType, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DataDefinition, type: typeof(LongGraphType), nullable: True);
			Field(t => t.IsGlobal, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.IsHardware, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.IsPersistence, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.IsTimeSeries, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.DefaultValue, type: typeof(LongGraphType), nullable: True);
			Field(t => t.KeyValue, type: typeof(LongGraphType), nullable: True);
			Field(t => t.KeyValueHex, type: typeof(ListGraphType<ByteGraphType>), nullable: True);
			Field(t => t.IsGet, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.IsSet, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.PayloadFromCloud, type: typeof(StringGraphType), nullable: True);
			Field(t => t.OnRequest, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.OnChange, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.OnFrequency, type: typeof(LongGraphType), nullable: True);
			Field(t => t.PayloadFromAppliance, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DataModelDescription, type: typeof(StringGraphType), nullable: True);
			Field(t => t.SetCmdEcho, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.ApplianceState, type: typeof(BoolGraphType), nullable: True);
            
            Field<DataModelDefinitionConfigurationGraphType, DataModelDefinitionConfiguration>("DataModelDefinitionConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DataModelDefinitionConfigurationGraphType>>(
                        "DataModelDefinitionDetail-DataModelDefinitionConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.DataModelDefinitionConfigurationsDataModelDefinitionDetail
                                .Where(x => x.DataModelDefinitionConfigurationId != null && ids.Contains((Guid)x.DataModelDefinitionConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.DataModelDefinitionConfigurationId!,
                                    Value = x.DataModelDefinitionConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.DataModelDefinitionConfigurations);
                });
            
        }
    }
}
            