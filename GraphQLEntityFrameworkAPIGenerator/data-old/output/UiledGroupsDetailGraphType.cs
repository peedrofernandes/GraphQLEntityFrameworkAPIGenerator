
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
    public partial class UiledGroupsDetailGraphType : ObjectGraphType<UiledGroupsDetail>
    {
        public UiledGroupsDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledGroupsDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Led, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiledGroupsUiledGroupsDetailGraphType, UiledGroupsUiledGroupsDetail>("UiledGroupsUiledGroupsDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledGroupsUiledGroupsDetailGraphType>>(
                            "{ Name = EntityName "UiledGroupsDetail"
  CorrespondingTable =
   Regular
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
  Fields = [{ Name = "UiledGroupsDetailsId"
              Type = Id Guid
              IsNullable = false }; { Name = "Led"
                                      Type = Primitive Byte
                                      IsNullable = false }]
  Relations =
   [OneToMany
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
            