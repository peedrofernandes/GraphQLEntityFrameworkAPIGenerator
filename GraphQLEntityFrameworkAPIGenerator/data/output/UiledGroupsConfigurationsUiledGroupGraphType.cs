
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
    public partial class UiledGroupsConfigurationsUiledGroupGraphType : ObjectGraphType<UiledGroupsConfigurationsUiledGroup>
    {
        public UiledGroupsConfigurationsUiledGroupGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledGroupsConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UiledGroupsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiledGroupGraphType, UiledGroup>("UiledGroups")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiledGroupGraphType>(
                            "{ Name = EntityName "UiledGroupsConfigurationsUiledGroup"
  CorrespondingTable =
   Regular
     { Name = TableName "UiledGroupsConfigurationsUiledGroup"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiledGroupsConfigurationsId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "UiledGroupsId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false };
         Navigation { Type = TableName "UiledGroup"
                      Name = "UiledGroups"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiledGroupsConfiguration"
                      Name = "UiledGroupsConfigurations"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UiledGroupsConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiledGroupsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiledGroup"
        TargetTable =
         { Name = TableName "UiledGroup"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledGroupsId"
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
             ForeignKey { Type = Int
                          Name = "LedFunctionId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Compartment"
                                                            IsNullable = false };
             Navigation { Type = TableName "UiledGroupsConfigurationsUiledGroup"
                          Name = "UiledGroupsConfigurationsUiledGroups"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiledGroupsUiledGroupsDetail"
                          Name = "UiledGroupsUiledGroupsDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiledGroup"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiledGroupsConfiguration"
        TargetTable =
         { Name = TableName "UiledGroupsConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledGroupsConfigurationsId"
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
                          Name = "UiledConfigurationsId"
                          IsNullable = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiledConfiguration"
                          Name = "UiledConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiledGroupsConfigurationsUiledGroup"
                          Name = "UiledGroupsConfigurationsUiledGroups"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiledGroupsConfiguration"
        IsNullable = false
        KeyType = Guid }] }-UiledGroup-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiledGroups
                                    .Where(x => x.UiledGroup != null && ids.Contains((Guid)x.UiledGroup))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiledGroup!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiledGroup);
                });
            
			
                Field<UiledGroupsConfigurationGraphType, UiledGroupsConfiguration>("UiledGroupsConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiledGroupsConfigurationGraphType>(
                            "{ Name = EntityName "UiledGroupsConfigurationsUiledGroup"
  CorrespondingTable =
   Regular
     { Name = TableName "UiledGroupsConfigurationsUiledGroup"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiledGroupsConfigurationsId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "UiledGroupsId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false };
         Navigation { Type = TableName "UiledGroup"
                      Name = "UiledGroups"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiledGroupsConfiguration"
                      Name = "UiledGroupsConfigurations"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UiledGroupsConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiledGroupsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiledGroup"
        TargetTable =
         { Name = TableName "UiledGroup"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledGroupsId"
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
             ForeignKey { Type = Int
                          Name = "LedFunctionId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Compartment"
                                                            IsNullable = false };
             Navigation { Type = TableName "UiledGroupsConfigurationsUiledGroup"
                          Name = "UiledGroupsConfigurationsUiledGroups"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiledGroupsUiledGroupsDetail"
                          Name = "UiledGroupsUiledGroupsDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiledGroup"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiledGroupsConfiguration"
        TargetTable =
         { Name = TableName "UiledGroupsConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledGroupsConfigurationsId"
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
                          Name = "UiledConfigurationsId"
                          IsNullable = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiledConfiguration"
                          Name = "UiledConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiledGroupsConfigurationsUiledGroup"
                          Name = "UiledGroupsConfigurationsUiledGroups"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiledGroupsConfiguration"
        IsNullable = false
        KeyType = Guid }] }-UiledGroupsConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiledGroupsConfigurations
                                    .Where(x => x.UiledGroupsConfiguration != null && ids.Contains((Guid)x.UiledGroupsConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiledGroupsConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiledGroupsConfiguration);
                });
            
        }
    }
}
            