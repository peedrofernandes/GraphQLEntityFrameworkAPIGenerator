
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
    public partial class UiledConfigurationsUiledDriverParameterGraphType : ObjectGraphType<UiledConfigurationsUiledDriverParameter>
    {
        public UiledConfigurationsUiledDriverParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UiledDriverParametersId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiledConfigurationGraphType, UiledConfiguration>("UiledConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiledConfigurationGraphType>(
                            "{ Name = EntityName "UiledConfigurationsUiledDriverParameter"
  CorrespondingTable =
   Regular
     { Name = TableName "UiledConfigurationsUiledDriverParameter"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiledConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiledDriverParametersId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "UiledConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiledDriverParametersId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiledDriverParameter"
        TargetTable =
         { Name = TableName "UiledDriverParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledDriverParametersId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "LedName"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "LedTypeId"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Parameter1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Parameter2"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Parameter3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Status"
                                                          IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
             Navigation { Type = TableName "UiledDriverType"
                          Name = "LedType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UiledConfigurationsUiledDriverParameter"
                 Name = "UiledConfigurationsUiledDriverParameters"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiledDriverParameter"
        IsNullable = false
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

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiledConfiguration);
                });
            
			
                Field<UiledDriverParameterGraphType, UiledDriverParameter>("UiledDriverParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiledDriverParameterGraphType>(
                            "{ Name = EntityName "UiledConfigurationsUiledDriverParameter"
  CorrespondingTable =
   Regular
     { Name = TableName "UiledConfigurationsUiledDriverParameter"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiledConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiledDriverParametersId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "UiledConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiledDriverParametersId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiledDriverParameter"
        TargetTable =
         { Name = TableName "UiledDriverParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledDriverParametersId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "LedName"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "LedTypeId"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Parameter1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Parameter2"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Parameter3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Status"
                                                          IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
             Navigation { Type = TableName "UiledDriverType"
                          Name = "LedType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UiledConfigurationsUiledDriverParameter"
                 Name = "UiledConfigurationsUiledDriverParameters"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiledDriverParameter"
        IsNullable = false
        KeyType = Guid }] }-UiledDriverParameter-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiledDriverParameters
                                    .Where(x => x.UiledDriverParameter != null && ids.Contains((Guid)x.UiledDriverParameter))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiledDriverParameter!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiledDriverParameter);
                });
            
        }
    }
}
            