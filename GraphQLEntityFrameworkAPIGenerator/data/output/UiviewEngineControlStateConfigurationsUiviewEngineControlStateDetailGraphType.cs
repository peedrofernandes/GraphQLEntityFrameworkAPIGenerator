
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
    public partial class UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetailGraphType : ObjectGraphType<UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail>
    {
        public UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiviewEngineControlStateConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UiviewEngineControlStateDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiviewEngineControlStateConfigurationGraphType, UiviewEngineControlStateConfiguration>("UiviewEngineControlStateConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiviewEngineControlStateConfigurationGraphType>(
                            "{ Name =
   EntityName
     "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiviewEngineControlStateConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiviewEngineControlStateDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UiviewEngineControlStateConfiguration"
                      Name = "UiviewEngineControlStateConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiviewEngineControlStateDetail"
                      Name = "UiviewEngineControlStateDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UiviewEngineControlStateConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiviewEngineControlStateDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiviewEngineControlStateConfiguration"
        TargetTable =
         { Name = TableName "UiviewEngineControlStateConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiviewEngineControlStateConfigurationsId"
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
                    "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
                 Name =
                  "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiviewEngineControlStateConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiviewEngineControlStateDetail"
        TargetTable =
         { Name = TableName "UiviewEngineControlStateDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiviewEngineControlStateDetailsId"
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
             ForeignKey { Type = Guid
                          Name = "OnEntryMacroId"
                          IsNullable = true }; ForeignKey { Type = Guid
                                                            Name = "DoMacroId"
                                                            IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "OnExitMacroId"
                          IsNullable = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "DoMacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "OnEntryMacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "OnExitMacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName
                    "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
                 Name =
                  "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiviewEngineControlStateDetail"
        IsNullable = false
        KeyType = Guid }] }-UiviewEngineControlStateConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiviewEngineControlStateConfigurations
                                    .Where(x => x.UiviewEngineControlStateConfiguration != null && ids.Contains((Guid)x.UiviewEngineControlStateConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiviewEngineControlStateConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiviewEngineControlStateConfiguration);
                });
            
			
                Field<UiviewEngineControlStateDetailGraphType, UiviewEngineControlStateDetail>("UiviewEngineControlStateDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiviewEngineControlStateDetailGraphType>(
                            "{ Name =
   EntityName
     "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiviewEngineControlStateConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiviewEngineControlStateDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UiviewEngineControlStateConfiguration"
                      Name = "UiviewEngineControlStateConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiviewEngineControlStateDetail"
                      Name = "UiviewEngineControlStateDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UiviewEngineControlStateConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiviewEngineControlStateDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiviewEngineControlStateConfiguration"
        TargetTable =
         { Name = TableName "UiviewEngineControlStateConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiviewEngineControlStateConfigurationsId"
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
                    "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
                 Name =
                  "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiviewEngineControlStateConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiviewEngineControlStateDetail"
        TargetTable =
         { Name = TableName "UiviewEngineControlStateDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiviewEngineControlStateDetailsId"
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
             ForeignKey { Type = Guid
                          Name = "OnEntryMacroId"
                          IsNullable = true }; ForeignKey { Type = Guid
                                                            Name = "DoMacroId"
                                                            IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "OnExitMacroId"
                          IsNullable = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "DoMacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "OnEntryMacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "OnExitMacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName
                    "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
                 Name =
                  "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiviewEngineControlStateDetail"
        IsNullable = false
        KeyType = Guid }] }-UiviewEngineControlStateDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiviewEngineControlStateDetails
                                    .Where(x => x.UiviewEngineControlStateDetail != null && ids.Contains((Guid)x.UiviewEngineControlStateDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiviewEngineControlStateDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiviewEngineControlStateDetail);
                });
            
        }
    }
}
            