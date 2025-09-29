
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
                            "{ Name = EntityName "UidataModelTranslationDetail"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true }; Primitive { Type = Int
                                                      Name = "DataModelKeyValue"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "DataModelType"
                     IsNullable = false }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "UidataModelTranslationDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true };
    { Name = "DataModelKeyValue"
      Type = Primitive Int
      IsNullable = false }; { Name = "DataModelType"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "DataModelSubType"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "DataModelNamespace"
      Type = Primitive Byte
      IsNullable = true }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UidataModelKeyMapping"
        TargetTable =
         { Name = TableName "UidataModelKeyMapping"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidataModelKeyMappingId"
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
             Primitive { Type = Byte
                         Name = "NItems"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionLabelId0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId0"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId9"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId9"
                         IsNullable = true };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId0Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UidataModelTranslationDetail"
                          Name = "UidataModelTranslationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UidataModelKeyMapping"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
        TargetTable =
         { Name =
            TableName
              "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidataModelTranslationConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UidataModelTranslationDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
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
        Destination =
         EntityName
           "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
        KeyType = Guid }] }-UidataModelKeyMapping-loader",
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
            
			
                Field<UidataModelTranslationConfigurationsUidataModelTranslationDetailGraphType, UidataModelTranslationConfigurationsUidataModelTranslationDetail>("UidataModelTranslationConfigurationsUidataModelTranslationDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UidataModelTranslationConfigurationsUidataModelTranslationDetailGraphType>>(
                            "{ Name = EntityName "UidataModelTranslationDetail"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true }; Primitive { Type = Int
                                                      Name = "DataModelKeyValue"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "DataModelType"
                     IsNullable = false }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "UidataModelTranslationDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true };
    { Name = "DataModelKeyValue"
      Type = Primitive Int
      IsNullable = false }; { Name = "DataModelType"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "DataModelSubType"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "DataModelNamespace"
      Type = Primitive Byte
      IsNullable = true }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UidataModelKeyMapping"
        TargetTable =
         { Name = TableName "UidataModelKeyMapping"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidataModelKeyMappingId"
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
             Primitive { Type = Byte
                         Name = "NItems"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionLabelId0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId0"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId9"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId9"
                         IsNullable = true };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId0Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "KeyModifierId9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UidataModelTranslationDetail"
                          Name = "UidataModelTranslationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UidataModelKeyMapping"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
        TargetTable =
         { Name =
            TableName
              "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidataModelTranslationConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UidataModelTranslationDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
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
        Destination =
         EntityName
           "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
        KeyType = Guid }] }-UidataModelTranslationConfigurationsUidataModelTranslationDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UidataModelTranslationConfigurationsUidataModelTranslationDetails
                                    .Where(x => x.UidataModelTranslationConfigurationsUidataModelTranslationDetail != null && ids.Contains((Guid)x.UidataModelTranslationConfigurationsUidataModelTranslationDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UidataModelTranslationConfigurationsUidataModelTranslationDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UidataModelTranslationConfigurationsUidataModelTranslationDetails);
                    });
            
        }
    }
}
            