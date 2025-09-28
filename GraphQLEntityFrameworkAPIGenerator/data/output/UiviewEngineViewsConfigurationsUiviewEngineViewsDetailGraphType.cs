
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
    public partial class UiviewEngineViewsConfigurationsUiviewEngineViewsDetailGraphType : ObjectGraphType<UiviewEngineViewsConfigurationsUiviewEngineViewsDetail>
    {
        public UiviewEngineViewsConfigurationsUiviewEngineViewsDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiviewEngineViewsConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UiviewEngineViewsDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiviewEngineViewsConfiguratioGraphType, UiviewEngineViewsConfiguratio>("UiviewEngineViewsConfiguratios")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiviewEngineViewsConfiguratioGraphType>(
                            "{ Name = EntityName "UiviewEngineViewsConfigurationsUiviewEngineViewsDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiviewEngineViewsConfigurationsUiviewEngineViewsDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiviewEngineViewsConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiviewEngineViewsDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UiviewEngineViewsConfiguratio"
                      Name = "UiviewEngineViewsConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiviewEngineViewsDetail"
                      Name = "UiviewEngineViewsDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UiviewEngineViewsConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiviewEngineViewsDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiviewEngineViewsConfiguratio"
        TargetTable =
         { Name = TableName "UiviewEngineViewsConfiguratio"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiviewEngineViewsConfigurationsId"
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
                    "UiviewEngineViewsConfigurationsUiviewEngineViewsDetail"
                 Name =
                  "UiviewEngineViewsConfigurationsUiviewEngineViewsDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiviewEngineViewsConfiguratio"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiviewEngineViewsDetail"
        TargetTable =
         { Name = TableName "UiviewEngineViewsDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiviewEngineViewsDetailsId"
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
                    "UiviewEngineViewsConfigurationsUiviewEngineViewsDetail"
                 Name =
                  "UiviewEngineViewsConfigurationsUiviewEngineViewsDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiviewEngineViewsDetail"
        IsNullable = false
        KeyType = Guid }] }-UiviewEngineViewsConfiguratio-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiviewEngineViewsConfiguratios
                                    .Where(x => x.UiviewEngineViewsConfiguratio != null && ids.Contains((Guid)x.UiviewEngineViewsConfiguratio))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiviewEngineViewsConfiguratio!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiviewEngineViewsConfiguratio);
                });
            
			
                Field<UiviewEngineViewsDetailGraphType, UiviewEngineViewsDetail>("UiviewEngineViewsDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiviewEngineViewsDetailGraphType>(
                            "{ Name = EntityName "UiviewEngineViewsConfigurationsUiviewEngineViewsDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiviewEngineViewsConfigurationsUiviewEngineViewsDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiviewEngineViewsConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiviewEngineViewsDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UiviewEngineViewsConfiguratio"
                      Name = "UiviewEngineViewsConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiviewEngineViewsDetail"
                      Name = "UiviewEngineViewsDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UiviewEngineViewsConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiviewEngineViewsDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiviewEngineViewsConfiguratio"
        TargetTable =
         { Name = TableName "UiviewEngineViewsConfiguratio"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiviewEngineViewsConfigurationsId"
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
                    "UiviewEngineViewsConfigurationsUiviewEngineViewsDetail"
                 Name =
                  "UiviewEngineViewsConfigurationsUiviewEngineViewsDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiviewEngineViewsConfiguratio"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiviewEngineViewsDetail"
        TargetTable =
         { Name = TableName "UiviewEngineViewsDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiviewEngineViewsDetailsId"
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
                    "UiviewEngineViewsConfigurationsUiviewEngineViewsDetail"
                 Name =
                  "UiviewEngineViewsConfigurationsUiviewEngineViewsDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiviewEngineViewsDetail"
        IsNullable = false
        KeyType = Guid }] }-UiviewEngineViewsDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiviewEngineViewsDetails
                                    .Where(x => x.UiviewEngineViewsDetail != null && ids.Contains((Guid)x.UiviewEngineViewsDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiviewEngineViewsDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiviewEngineViewsDetail);
                });
            
        }
    }
}
            