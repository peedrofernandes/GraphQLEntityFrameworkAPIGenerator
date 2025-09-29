
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
    public partial class UidataModelTranslationConfigurationsUidataModelTranslationDetailGraphType : ObjectGraphType<UidataModelTranslationConfigurationsUidataModelTranslationDetail>
    {
        public UidataModelTranslationConfigurationsUidataModelTranslationDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UidataModelTranslationConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UidataModelTranslationDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UidataModelTranslationConfigurationGraphType, UidataModelTranslationConfiguration>("UidataModelTranslationConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UidataModelTranslationConfigurationGraphType>(
                            "{ Name =
   EntityName "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UidataModelTranslationConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UidataModelTranslationDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UidataModelTranslationConfiguration"
                      Name = "UidataModelTranslationConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UidataModelTranslationDetail"
                      Name = "UidataModelTranslationDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UidataModelTranslationConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UidataModelTranslationDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UidataModelTranslationConfiguration"
        TargetTable =
         { Name = TableName "UidataModelTranslationConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidataModelTranslationConfigurationId"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
                 Name =
                  "UidataModelTranslationConfigurationsUidataModelTranslationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UidataModelTranslationConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UidataModelTranslationDetail"
        TargetTable =
         { Name = TableName "UidataModelTranslationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidataModelTranslationDetailId"
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
                         Name = "DataModelKeyValue"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DataModelType"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DataModelSubType"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UidataModelKeyMappingId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "DataModelNamespace"
                         IsNullable = true };
             Navigation { Type = TableName "UidataModelKeyMapping"
                          Name = "UidataModelKeyMapping"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName
                    "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
                 Name =
                  "UidataModelTranslationConfigurationsUidataModelTranslationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UidataModelTranslationDetail"
        IsNullable = false
        KeyType = Guid }] }-UidataModelTranslationConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UidataModelTranslationConfigurations
                                    .Where(x => x.UidataModelTranslationConfiguration != null && ids.Contains((Guid)x.UidataModelTranslationConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UidataModelTranslationConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UidataModelTranslationConfiguration);
                });
            
			
                Field<UidataModelTranslationDetailGraphType, UidataModelTranslationDetail>("UidataModelTranslationDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UidataModelTranslationDetailGraphType>(
                            "{ Name =
   EntityName "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UidataModelTranslationConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UidataModelTranslationDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UidataModelTranslationConfiguration"
                      Name = "UidataModelTranslationConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UidataModelTranslationDetail"
                      Name = "UidataModelTranslationDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UidataModelTranslationConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UidataModelTranslationDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UidataModelTranslationConfiguration"
        TargetTable =
         { Name = TableName "UidataModelTranslationConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidataModelTranslationConfigurationId"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
                 Name =
                  "UidataModelTranslationConfigurationsUidataModelTranslationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UidataModelTranslationConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UidataModelTranslationDetail"
        TargetTable =
         { Name = TableName "UidataModelTranslationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidataModelTranslationDetailId"
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
                         Name = "DataModelKeyValue"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DataModelType"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DataModelSubType"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UidataModelKeyMappingId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "DataModelNamespace"
                         IsNullable = true };
             Navigation { Type = TableName "UidataModelKeyMapping"
                          Name = "UidataModelKeyMapping"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName
                    "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
                 Name =
                  "UidataModelTranslationConfigurationsUidataModelTranslationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UidataModelTranslationDetail"
        IsNullable = false
        KeyType = Guid }] }-UidataModelTranslationDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UidataModelTranslationDetails
                                    .Where(x => x.UidataModelTranslationDetail != null && ids.Contains((Guid)x.UidataModelTranslationDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UidataModelTranslationDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UidataModelTranslationDetail);
                });
            
        }
    }
}
            