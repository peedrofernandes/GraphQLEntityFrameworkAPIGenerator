
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
    public partial class UiledGroupGraphType : ObjectGraphType<UiledGroup>
    {
        public UiledGroupGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledGroupsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiledGroupsConfigurationsUiledGroupGraphType, UiledGroupsConfigurationsUiledGroup>("UiledGroupsConfigurationsUiledGroups")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledGroupsConfigurationsUiledGroupGraphType>>(
                            "{ Name = EntityName "UiledGroup"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; ForeignKey { Type = Int
                                                       Name = "LedFunctionId"
                                                       IsNullable = false };
         Primitive { Type = Byte
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
  Fields =
   [{ Name = "UiledGroupsId"
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
    { Name = "Compartment"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UiledGroupsConfigurationsUiledGroup"
        TargetTable =
         { Name = TableName "UiledGroupsConfigurationsUiledGroup"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledGroupsConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
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
        Destination = EntityName "UiledGroupsConfigurationsUiledGroup"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UiledGroupsUiledGroupsDetail"
        TargetTable =
         { Name = TableName "UiledGroupsUiledGroupsDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledGroupsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiledGroupsDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiledGroup"
                          Name = "UiledGroups"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiledGroupsDetail"
                          Name = "UiledGroupsDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UiledGroupsUiledGroupsDetail"
        KeyType = Guid }] }-UiledGroupsConfigurationsUiledGroup-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiledGroupsConfigurationsUiledGroups
                                    .Where(x => x.UiledGroupsConfigurationsUiledGroup != null && ids.Contains((Guid)x.UiledGroupsConfigurationsUiledGroup))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiledGroupsConfigurationsUiledGroup!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiledGroupsConfigurationsUiledGroups);
                    });
            
			
                Field<UiledGroupsUiledGroupsDetailGraphType, UiledGroupsUiledGroupsDetail>("UiledGroupsUiledGroupsDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledGroupsUiledGroupsDetailGraphType>>(
                            "{ Name = EntityName "UiledGroup"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; ForeignKey { Type = Int
                                                       Name = "LedFunctionId"
                                                       IsNullable = false };
         Primitive { Type = Byte
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
  Fields =
   [{ Name = "UiledGroupsId"
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
    { Name = "Compartment"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UiledGroupsConfigurationsUiledGroup"
        TargetTable =
         { Name = TableName "UiledGroupsConfigurationsUiledGroup"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledGroupsConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
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
        Destination = EntityName "UiledGroupsConfigurationsUiledGroup"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UiledGroupsUiledGroupsDetail"
        TargetTable =
         { Name = TableName "UiledGroupsUiledGroupsDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledGroupsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiledGroupsDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiledGroup"
                          Name = "UiledGroups"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiledGroupsDetail"
                          Name = "UiledGroupsDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UiledGroupsUiledGroupsDetail"
        KeyType = Guid }] }-UiledGroupsUiledGroupsDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiledGroupsUiledGroupsDetails
                                    .Where(x => x.UiledGroupsUiledGroupsDetail != null && ids.Contains((Guid)x.UiledGroupsUiledGroupsDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiledGroupsUiledGroupsDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiledGroupsUiledGroupsDetails);
                    });
            
        }
    }
}
            