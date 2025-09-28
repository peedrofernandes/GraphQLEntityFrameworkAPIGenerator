
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
    public partial class DataModelDefinitionConfigurationsDataModelDefinitionDetailGraphType : ObjectGraphType<DataModelDefinitionConfigurationsDataModelDefinitionDetail>
    {
        public DataModelDefinitionConfigurationsDataModelDefinitionDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DataModelDefinitionConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DataModelDefinitionDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(IdGraphType), nullable: False);
            
                Field<DataModelDefinitionConfigurationGraphType, DataModelDefinitionConfiguration>("DataModelDefinitionConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DataModelDefinitionConfigurationGraphType>(
                            "{ Name = EntityName "DataModelDefinitionConfigurationsDataModelDefinitionDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName "DataModelDefinitionConfigurationsDataModelDefinitionDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DataModelDefinitionConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "DataModelDefinitionDetailId"
                      IsNullable = false }; PrimaryKey { Type = Int
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "DataModelDefinitionConfiguration"
                      Name = "DataModelDefinitionConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "DataModelDefinitionDetail"
                      Name = "DataModelDefinitionDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "DataModelDefinitionConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "DataModelDefinitionDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Int
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "DataModelDefinitionConfiguration"
        TargetTable =
         { Name = TableName "DataModelDefinitionConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DataModelDefinitionConfigurationId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
                         Name = "Timestamp"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Notes"
                                                           IsNullable = true };
             Primitive { Type = Int
                         Name = "DataModelVersion"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "DataModelApi"
                                                           IsNullable = false };
             Primitive { Type = Int
                         Name = "DataModelCategory"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "DataModelDefinitionConfigurationsDataModelDefinitionDetail"
                 Name =
                  "DataModelDefinitionConfigurationsDataModelDefinitionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DataModelDefinitionConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DataModelDefinitionDetail"
        TargetTable =
         { Name = TableName "DataModelDefinitionDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DataModelDefinitionDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
                         Name = "Timestamp"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Notes"
                                                           IsNullable = true };
             Primitive { Type = Int
                         Name = "DataModelIndex"
                         IsNullable = true }; Primitive { Type = String
                                                          Name = "Sort"
                                                          IsNullable = true };
             Primitive { Type = String
                         Name = "DataModelNamespace"
                         IsNullable = true }; Primitive { Type = String
                                                          Name = "Entity"
                                                          IsNullable = true };
             Primitive { Type = String
                         Name = "Instance"
                         IsNullable = true }; Primitive { Type = String
                                                          Name = "AttributeName"
                                                          IsNullable = true };
             Primitive { Type = String
                         Name = "AttributeDisplayName"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "PayloadDataType"
                         IsNullable = true };
             Primitive { Type = Long
                         Name = "DataDefinition"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "IsGlobal"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsHardware"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "IsPersistence"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsTimeSeries"
                         IsNullable = true }; Primitive { Type = Long
                                                          Name = "DefaultValue"
                                                          IsNullable = true };
             Primitive { Type = Long
                         Name = "KeyValue"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "IsGet"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "PayloadFromCloud"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "OnRequest"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "OnChange"
                         IsNullable = true }; Primitive { Type = Long
                                                          Name = "OnFrequency"
                                                          IsNullable = true };
             Primitive { Type = String
                         Name = "PayloadFromAppliance"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "DataModelDescription"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "SetCmdEcho"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "ApplianceState"
                         IsNullable = true };
             Navigation
               { Type =
                  TableName
                    "DataModelDefinitionConfigurationsDataModelDefinitionDetail"
                 Name =
                  "DataModelDefinitionConfigurationsDataModelDefinitionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DataModelDefinitionDetail"
        IsNullable = false
        KeyType = Guid }] }-DataModelDefinitionConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.DataModelDefinitionConfigurations
                                    .Where(x => x.DataModelDefinitionConfiguration != null && ids.Contains((Guid)x.DataModelDefinitionConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DataModelDefinitionConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.DataModelDefinitionConfiguration);
                });
            
			
                Field<DataModelDefinitionDetailGraphType, DataModelDefinitionDetail>("DataModelDefinitionDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DataModelDefinitionDetailGraphType>(
                            "{ Name = EntityName "DataModelDefinitionConfigurationsDataModelDefinitionDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName "DataModelDefinitionConfigurationsDataModelDefinitionDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DataModelDefinitionConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "DataModelDefinitionDetailId"
                      IsNullable = false }; PrimaryKey { Type = Int
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "DataModelDefinitionConfiguration"
                      Name = "DataModelDefinitionConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "DataModelDefinitionDetail"
                      Name = "DataModelDefinitionDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "DataModelDefinitionConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "DataModelDefinitionDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Int
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "DataModelDefinitionConfiguration"
        TargetTable =
         { Name = TableName "DataModelDefinitionConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DataModelDefinitionConfigurationId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
                         Name = "Timestamp"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Notes"
                                                           IsNullable = true };
             Primitive { Type = Int
                         Name = "DataModelVersion"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "DataModelApi"
                                                           IsNullable = false };
             Primitive { Type = Int
                         Name = "DataModelCategory"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "DataModelDefinitionConfigurationsDataModelDefinitionDetail"
                 Name =
                  "DataModelDefinitionConfigurationsDataModelDefinitionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DataModelDefinitionConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DataModelDefinitionDetail"
        TargetTable =
         { Name = TableName "DataModelDefinitionDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DataModelDefinitionDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
                         Name = "Timestamp"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Notes"
                                                           IsNullable = true };
             Primitive { Type = Int
                         Name = "DataModelIndex"
                         IsNullable = true }; Primitive { Type = String
                                                          Name = "Sort"
                                                          IsNullable = true };
             Primitive { Type = String
                         Name = "DataModelNamespace"
                         IsNullable = true }; Primitive { Type = String
                                                          Name = "Entity"
                                                          IsNullable = true };
             Primitive { Type = String
                         Name = "Instance"
                         IsNullable = true }; Primitive { Type = String
                                                          Name = "AttributeName"
                                                          IsNullable = true };
             Primitive { Type = String
                         Name = "AttributeDisplayName"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "PayloadDataType"
                         IsNullable = true };
             Primitive { Type = Long
                         Name = "DataDefinition"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "IsGlobal"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsHardware"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "IsPersistence"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsTimeSeries"
                         IsNullable = true }; Primitive { Type = Long
                                                          Name = "DefaultValue"
                                                          IsNullable = true };
             Primitive { Type = Long
                         Name = "KeyValue"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "IsGet"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "PayloadFromCloud"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "OnRequest"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "OnChange"
                         IsNullable = true }; Primitive { Type = Long
                                                          Name = "OnFrequency"
                                                          IsNullable = true };
             Primitive { Type = String
                         Name = "PayloadFromAppliance"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "DataModelDescription"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "SetCmdEcho"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "ApplianceState"
                         IsNullable = true };
             Navigation
               { Type =
                  TableName
                    "DataModelDefinitionConfigurationsDataModelDefinitionDetail"
                 Name =
                  "DataModelDefinitionConfigurationsDataModelDefinitionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DataModelDefinitionDetail"
        IsNullable = false
        KeyType = Guid }] }-DataModelDefinitionDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.DataModelDefinitionDetails
                                    .Where(x => x.DataModelDefinitionDetail != null && ids.Contains((Guid)x.DataModelDefinitionDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DataModelDefinitionDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.DataModelDefinitionDetail);
                });
            
        }
    }
}
            