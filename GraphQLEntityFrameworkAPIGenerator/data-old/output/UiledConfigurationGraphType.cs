
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
    public partial class UiledConfigurationGraphType : ObjectGraphType<UiledConfiguration>
    {
        public UiledConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<UiledConfigurationsUiledDriverParameterGraphType, UiledConfigurationsUiledDriverParameter>("UiledConfigurationsUiledDriverParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledConfigurationsUiledDriverParameterGraphType>>(
                            "{ Name = EntityName "UiledConfiguration"
  CorrespondingTable =
   Regular
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
         ForeignKey { Type = Guid
                      Name = "UiledFunctionMappingConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "UiledConfigurationsUiledDriverParameter"
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
  Fields =
   [{ Name = "UiledConfigurationsId"
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
      { Name = RelationName "UiledConfigurationsUiledDriverParameter"
        TargetTable =
         { Name = TableName "UiledConfigurationsUiledDriverParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiledDriverParametersId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiledConfiguration"
                          Name = "UiledConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiledDriverParameter"
                          Name = "UiledDriverParameters"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UiledConfigurationsUiledDriverParameter"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiledFunctionMappingConfiguration"
        TargetTable =
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
        Destination = EntityName "UiledFunctionMappingConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
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
        KeyType = Guid }] }-UiledConfigurationsUiledDriverParameter-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiledConfigurationsUiledDriverParameters
                                    .Where(x => x.UiledConfigurationsUiledDriverParameter != null && ids.Contains((Guid)x.UiledConfigurationsUiledDriverParameter))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiledConfigurationsUiledDriverParameter!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiledConfigurationsUiledDriverParameters);
                    });
            
			
                Field<UiledFunctionMappingConfigurationGraphType, UiledFunctionMappingConfiguration>("UiledFunctionMappingConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiledFunctionMappingConfigurationGraphType>(
                            "{ Name = EntityName "UiledConfiguration"
  CorrespondingTable =
   Regular
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
         ForeignKey { Type = Guid
                      Name = "UiledFunctionMappingConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "UiledConfigurationsUiledDriverParameter"
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
  Fields =
   [{ Name = "UiledConfigurationsId"
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
      { Name = RelationName "UiledConfigurationsUiledDriverParameter"
        TargetTable =
         { Name = TableName "UiledConfigurationsUiledDriverParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiledDriverParametersId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiledConfiguration"
                          Name = "UiledConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiledDriverParameter"
                          Name = "UiledDriverParameters"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UiledConfigurationsUiledDriverParameter"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiledFunctionMappingConfiguration"
        TargetTable =
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
        Destination = EntityName "UiledFunctionMappingConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
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
        KeyType = Guid }] }-UiledFunctionMappingConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiledFunctionMappingConfigurations
                                    .Where(x => x.UiledFunctionMappingConfiguration != null && ids.Contains((Guid)x.UiledFunctionMappingConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiledFunctionMappingConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiledFunctionMappingConfiguration);
                });
            
			
                Field<UiledGroupsConfigurationGraphType, UiledGroupsConfiguration>("UiledGroupsConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledGroupsConfigurationGraphType>>(
                            "{ Name = EntityName "UiledConfiguration"
  CorrespondingTable =
   Regular
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
         ForeignKey { Type = Guid
                      Name = "UiledFunctionMappingConfigId"
                      IsNullable = true };
         Navigation { Type = TableName "UiledConfigurationsUiledDriverParameter"
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
  Fields =
   [{ Name = "UiledConfigurationsId"
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
      { Name = RelationName "UiledConfigurationsUiledDriverParameter"
        TargetTable =
         { Name = TableName "UiledConfigurationsUiledDriverParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiledDriverParametersId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiledConfiguration"
                          Name = "UiledConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiledDriverParameter"
                          Name = "UiledDriverParameters"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UiledConfigurationsUiledDriverParameter"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiledFunctionMappingConfiguration"
        TargetTable =
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
        Destination = EntityName "UiledFunctionMappingConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
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
                            });

                        return loader.LoadAsync(context.Source.UiledGroupsConfigurations);
                    });
            
        }
    }
}
            