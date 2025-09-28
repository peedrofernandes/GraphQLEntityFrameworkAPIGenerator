
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
    public partial class UianimationFrameDetailGraphType : ObjectGraphType<UianimationFrameDetail>
    {
        public UianimationFrameDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UianimationFrameDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Pattern, type: typeof(LongGraphType), nullable: False);
			Field(t => t.TimeOn, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.FrameIntensity, type: typeof(ByteGraphType), nullable: False);
            
                Field<UianimationFrameConfigurationsUianimationFrameDetailGraphType, UianimationFrameConfigurationsUianimationFrameDetail>("UianimationFrameConfigurationsUianimationFrameDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UianimationFrameConfigurationsUianimationFrameDetailGraphType>>(
                            "{ Name = EntityName "UianimationFrameDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UianimationFrameDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UianimationFrameDetailsId"
                      IsNullable = false }; Primitive { Type = Long
                                                        Name = "Pattern"
                                                        IsNullable = false };
         Primitive { Type = Short
                     Name = "TimeOn"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "FrameIntensity"
                                                       IsNullable = false };
         Navigation
           { Type =
              TableName "UianimationFrameConfigurationsUianimationFrameDetail"
             Name = "UianimationFrameConfigurationsUianimationFrameDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "UianimationFrameDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Pattern"
                              Type = Primitive Long
                              IsNullable = false }; { Name = "TimeOn"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "FrameIntensity"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName "UianimationFrameConfigurationsUianimationFrameDetail"
        TargetTable =
         { Name =
            TableName "UianimationFrameConfigurationsUianimationFrameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationFrameConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UianimationFrameDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UianimationFrameConfiguration"
                          Name = "UianimationFrameConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UianimationFrameDetail"
                          Name = "UianimationFrameDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "UianimationFrameConfigurationsUianimationFrameDetail"
        KeyType = Guid }] }-UianimationFrameConfigurationsUianimationFrameDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UianimationFrameConfigurationsUianimationFrameDetails
                                    .Where(x => x.UianimationFrameConfigurationsUianimationFrameDetail != null && ids.Contains((Guid)x.UianimationFrameConfigurationsUianimationFrameDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UianimationFrameConfigurationsUianimationFrameDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UianimationFrameConfigurationsUianimationFrameDetails);
                    });
            
        }
    }
}
            