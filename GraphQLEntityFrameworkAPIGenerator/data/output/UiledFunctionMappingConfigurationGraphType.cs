
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
    public partial class UiledFunctionMappingConfigurationGraphType : ObjectGraphType<UiledFunctionMappingConfiguration>
    {
        public UiledFunctionMappingConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledFunctionMappingConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<UiledConfigurationGraphType, UiledConfiguration>("UiledConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledConfigurationGraphType>>(
                            "{ Name = EntityName "UiledFunctionMappingConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "UiledFunctionMappingConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiledFunctionMappingConfigId"
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
                     IsNullable = true };
         Navigation { Type = TableName "UiledConfiguration"
                      Name = "UiledConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "UiledFunctionMappingConfigurationsUiledFunctionMappingDetail"
             Name =
              "UiledFunctionMappingConfigurationsUiledFunctionMappingDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "UiledFunctionMappingConfigId"
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
                                                      IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "UiledConfiguration"
        TargetTable =
         { Name = TableName "UiledConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledConfigurationsId"
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
                          Name = "UiledFunctionMappingConfigId"
                          IsNullable = true };
             Navigation
               { Type = TableName "UiledConfigurationsUiledDriverParameter"
                 Name = "UiledConfigurationsUiledDriverParameters"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "UiledFunctionMappingConfiguration"
                          Name = "UiledFunctionMappingConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiledGroupsConfiguration"
                          Name = "UiledGroupsConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiledConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "UiledFunctionMappingConfigurationsUiledFunctionMappingDetail"
        TargetTable =
         { Name =
            TableName
              "UiledFunctionMappingConfigurationsUiledFunctionMappingDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledFunctionMappingConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiledFunctionMappingDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiledFunctionMappingConfiguration"
                          Name = "UiledFunctionMappingConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiledFunctionMappingDetail"
                          Name = "UiledFunctionMappingDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "UiledFunctionMappingConfigurationsUiledFunctionMappingDetail"
        KeyType = Guid }] }-UiledConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiledConfigurations
                                    .Where(x => x.UiledConfiguration != null && ids.Contains((Guid)x.UiledConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiledConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiledConfigurations);
                    });
            
			
                Field<UiledFunctionMappingConfigurationsUiledFunctionMappingDetailGraphType, UiledFunctionMappingConfigurationsUiledFunctionMappingDetail>("UiledFunctionMappingConfigurationsUiledFunctionMappingDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledFunctionMappingConfigurationsUiledFunctionMappingDetailGraphType>>(
                            "{ Name = EntityName "UiledFunctionMappingConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "UiledFunctionMappingConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiledFunctionMappingConfigId"
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
                     IsNullable = true };
         Navigation { Type = TableName "UiledConfiguration"
                      Name = "UiledConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "UiledFunctionMappingConfigurationsUiledFunctionMappingDetail"
             Name =
              "UiledFunctionMappingConfigurationsUiledFunctionMappingDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "UiledFunctionMappingConfigId"
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
                                                      IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "UiledConfiguration"
        TargetTable =
         { Name = TableName "UiledConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledConfigurationsId"
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
                          Name = "UiledFunctionMappingConfigId"
                          IsNullable = true };
             Navigation
               { Type = TableName "UiledConfigurationsUiledDriverParameter"
                 Name = "UiledConfigurationsUiledDriverParameters"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "UiledFunctionMappingConfiguration"
                          Name = "UiledFunctionMappingConfig"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiledGroupsConfiguration"
                          Name = "UiledGroupsConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiledConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "UiledFunctionMappingConfigurationsUiledFunctionMappingDetail"
        TargetTable =
         { Name =
            TableName
              "UiledFunctionMappingConfigurationsUiledFunctionMappingDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledFunctionMappingConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiledFunctionMappingDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiledFunctionMappingConfiguration"
                          Name = "UiledFunctionMappingConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiledFunctionMappingDetail"
                          Name = "UiledFunctionMappingDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "UiledFunctionMappingConfigurationsUiledFunctionMappingDetail"
        KeyType = Guid }] }-UiledFunctionMappingConfigurationsUiledFunctionMappingDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiledFunctionMappingConfigurationsUiledFunctionMappingDetails
                                    .Where(x => x.UiledFunctionMappingConfigurationsUiledFunctionMappingDetail != null && ids.Contains((Guid)x.UiledFunctionMappingConfigurationsUiledFunctionMappingDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiledFunctionMappingConfigurationsUiledFunctionMappingDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiledFunctionMappingConfigurationsUiledFunctionMappingDetails);
                    });
            
        }
    }
}
            