
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
    public partial class UiinputEventMappingConfigurationGraphType : ObjectGraphType<UiinputEventMappingConfiguration>
    {
        public UiinputEventMappingConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiinputEventMappingConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
            
                Field<UigenericInputConfigurationGraphType, UigenericInputConfiguration>("UigenericInputConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UigenericInputConfigurationGraphType>>(
                            "{ Name = EntityName "UiinputEventMappingConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "UiinputEventMappingConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiinputEventMappingConfigurationId"
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Version"
                                                      IsNullable = false };
         Navigation { Type = TableName "UigenericInputConfiguration"
                      Name = "UigenericInputConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
             Name =
              "UiinputEventMappingConfigurationsUiinputEventMappingDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "UiinputEventMappingConfigurationId"
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
    { Name = "Version"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UigenericInputConfiguration"
        TargetTable =
         { Name = TableName "UigenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputConfigurationId"
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
                          Name = "UiinputEventMappingConfigurationId"
                          IsNullable = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UigenericInputConfigurationsUigenericInputDetail"
                 Name = "UigenericInputConfigurationsUigenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "UiinputEventMappingConfiguration"
                          Name = "UiinputEventMappingConfiguration"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UigenericInputConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
        TargetTable =
         { Name =
            TableName
              "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiinputEventMappingConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiinputEventMappingDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiinputEventMappingConfiguration"
                          Name = "UiinputEventMappingConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiinputEventMappingDetail"
                          Name = "UiinputEventMappingDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
        KeyType = Guid }] }-UigenericInputConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UigenericInputConfigurations
                                    .Where(x => x.UigenericInputConfiguration != null && ids.Contains((Guid)x.UigenericInputConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UigenericInputConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UigenericInputConfigurations);
                    });
            
			
                Field<UiinputEventMappingConfigurationsUiinputEventMappingDetailGraphType, UiinputEventMappingConfigurationsUiinputEventMappingDetail>("UiinputEventMappingConfigurationsUiinputEventMappingDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiinputEventMappingConfigurationsUiinputEventMappingDetailGraphType>>(
                            "{ Name = EntityName "UiinputEventMappingConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "UiinputEventMappingConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiinputEventMappingConfigurationId"
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Version"
                                                      IsNullable = false };
         Navigation { Type = TableName "UigenericInputConfiguration"
                      Name = "UigenericInputConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
             Name =
              "UiinputEventMappingConfigurationsUiinputEventMappingDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "UiinputEventMappingConfigurationId"
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
    { Name = "Version"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UigenericInputConfiguration"
        TargetTable =
         { Name = TableName "UigenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputConfigurationId"
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
                          Name = "UiinputEventMappingConfigurationId"
                          IsNullable = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UigenericInputConfigurationsUigenericInputDetail"
                 Name = "UigenericInputConfigurationsUigenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "UiinputEventMappingConfiguration"
                          Name = "UiinputEventMappingConfiguration"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UigenericInputConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
        TargetTable =
         { Name =
            TableName
              "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiinputEventMappingConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiinputEventMappingDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiinputEventMappingConfiguration"
                          Name = "UiinputEventMappingConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiinputEventMappingDetail"
                          Name = "UiinputEventMappingDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "UiinputEventMappingConfigurationsUiinputEventMappingDetail"
        KeyType = Guid }] }-UiinputEventMappingConfigurationsUiinputEventMappingDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiinputEventMappingConfigurationsUiinputEventMappingDetails
                                    .Where(x => x.UiinputEventMappingConfigurationsUiinputEventMappingDetail != null && ids.Contains((Guid)x.UiinputEventMappingConfigurationsUiinputEventMappingDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiinputEventMappingConfigurationsUiinputEventMappingDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiinputEventMappingConfigurationsUiinputEventMappingDetails);
                    });
            
        }
    }
}
            