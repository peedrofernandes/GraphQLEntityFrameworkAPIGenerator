
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
    public partial class UiledFunctionMappingDetailGraphType : ObjectGraphType<UiledFunctionMappingDetail>
    {
        public UiledFunctionMappingDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledFunctionMappingDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.LedName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiledFunctionMappingConfigurationsUiledFunctionMappingDetailGraphType, UiledFunctionMappingConfigurationsUiledFunctionMappingDetail>("UiledFunctionMappingConfigurationsUiledFunctionMappingDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledFunctionMappingConfigurationsUiledFunctionMappingDetailGraphType>>(
                            "{ Name = EntityName "UiledFunctionMappingDetail"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "UiledFunctionMappingDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "LedName"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Compartment"
                                                      Type = Primitive Byte
                                                      IsNullable = false }]
  Relations =
   [OneToMany
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
            