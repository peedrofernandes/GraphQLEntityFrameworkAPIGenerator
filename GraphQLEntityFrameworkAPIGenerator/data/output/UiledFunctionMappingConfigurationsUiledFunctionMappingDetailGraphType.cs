
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
    public partial class UiledFunctionMappingConfigurationsUiledFunctionMappingDetailGraphType : ObjectGraphType<UiledFunctionMappingConfigurationsUiledFunctionMappingDetail>
    {
        public UiledFunctionMappingConfigurationsUiledFunctionMappingDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledFunctionMappingConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UiledFunctionMappingDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiledFunctionMappingConfigurationGraphType, UiledFunctionMappingConfiguration>("UiledFunctionMappingConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiledFunctionMappingConfigurationGraphType>(
                            "{ Name =
   EntityName "UiledFunctionMappingConfigurationsUiledFunctionMappingDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName "UiledFunctionMappingConfigurationsUiledFunctionMappingDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiledFunctionMappingConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiledFunctionMappingDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "UiledFunctionMappingConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiledFunctionMappingDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiledFunctionMappingDetail"
        TargetTable =
         { Name = TableName "UiledFunctionMappingDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledFunctionMappingDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "LedName"
                                                            IsNullable = false };
             ForeignKey { Type = Int
                          Name = "LedFunctionId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Compartment"
                                                            IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "UiledFunctionMappingConfigurationsUiledFunctionMappingDetail"
                 Name =
                  "UiledFunctionMappingConfigurationsUiledFunctionMappingDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiledFunctionMappingDetail"
        IsNullable = false
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
            
			
                Field<UiledFunctionMappingDetailGraphType, UiledFunctionMappingDetail>("UiledFunctionMappingDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiledFunctionMappingDetailGraphType>(
                            "{ Name =
   EntityName "UiledFunctionMappingConfigurationsUiledFunctionMappingDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName "UiledFunctionMappingConfigurationsUiledFunctionMappingDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiledFunctionMappingConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiledFunctionMappingDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "UiledFunctionMappingConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiledFunctionMappingDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiledFunctionMappingDetail"
        TargetTable =
         { Name = TableName "UiledFunctionMappingDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledFunctionMappingDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "LedName"
                                                            IsNullable = false };
             ForeignKey { Type = Int
                          Name = "LedFunctionId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Compartment"
                                                            IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "UiledFunctionMappingConfigurationsUiledFunctionMappingDetail"
                 Name =
                  "UiledFunctionMappingConfigurationsUiledFunctionMappingDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiledFunctionMappingDetail"
        IsNullable = false
        KeyType = Guid }] }-UiledFunctionMappingDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiledFunctionMappingDetails
                                    .Where(x => x.UiledFunctionMappingDetail != null && ids.Contains((Guid)x.UiledFunctionMappingDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiledFunctionMappingDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiledFunctionMappingDetail);
                });
            
        }
    }
}
            