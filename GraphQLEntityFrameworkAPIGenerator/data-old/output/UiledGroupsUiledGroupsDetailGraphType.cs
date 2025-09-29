
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
    public partial class UiledGroupsUiledGroupsDetailGraphType : ObjectGraphType<UiledGroupsUiledGroupsDetail>
    {
        public UiledGroupsUiledGroupsDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledGroupsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UiledGroupsDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiledGroupGraphType, UiledGroup>("UiledGroups")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiledGroupGraphType>(
                            "{ Name = EntityName "UiledGroupsUiledGroupsDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiledGroupsUiledGroupsDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiledGroupsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiledGroupsDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "UiledGroupsId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiledGroupsDetailsId"
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
      { Name = RelationName "UiledGroupsDetail"
        TargetTable =
         { Name = TableName "UiledGroupsDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledGroupsDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Led"
                                                            IsNullable = false };
             Navigation { Type = TableName "UiledGroupsUiledGroupsDetail"
                          Name = "UiledGroupsUiledGroupsDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiledGroupsDetail"
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
            
			
                Field<UiledGroupsDetailGraphType, UiledGroupsDetail>("UiledGroupsDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiledGroupsDetailGraphType>(
                            "{ Name = EntityName "UiledGroupsUiledGroupsDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiledGroupsUiledGroupsDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiledGroupsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiledGroupsDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "UiledGroupsId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiledGroupsDetailsId"
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
      { Name = RelationName "UiledGroupsDetail"
        TargetTable =
         { Name = TableName "UiledGroupsDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledGroupsDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Led"
                                                            IsNullable = false };
             Navigation { Type = TableName "UiledGroupsUiledGroupsDetail"
                          Name = "UiledGroupsUiledGroupsDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiledGroupsDetail"
        IsNullable = false
        KeyType = Guid }] }-UiledGroupsDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiledGroupsDetails
                                    .Where(x => x.UiledGroupsDetail != null && ids.Contains((Guid)x.UiledGroupsDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiledGroupsDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiledGroupsDetail);
                });
            
        }
    }
}
            