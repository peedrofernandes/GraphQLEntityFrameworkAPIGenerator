
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
    public partial class CycleMappingModelNumberGraphType : ObjectGraphType<CycleMappingModelNumber>
    {
        public CycleMappingModelNumberGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleMappingModelNumberId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ModelNumber, type: typeof(StringGraphType), nullable: False);
            
                Field<CycleMappingFileInfoCycleMappingModelNumberGraphType, CycleMappingFileInfoCycleMappingModelNumber>("CycleMappingFileInfoCycleMappingModelNumbers")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingFileInfoCycleMappingModelNumberGraphType>>(
                            "{ Name = EntityName "CycleMappingModelNumber"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleMappingModelNumber"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleMappingModelNumberId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "ModelNumber"
                                                        IsNullable = false };
         Navigation
           { Type = TableName "CycleMappingFileInfoCycleMappingModelNumber"
             Name = "CycleMappingFileInfoCycleMappingModelNumbers"
             IsNullable = false
             IsCollection = true }] }
  Fields = [{ Name = "CycleMappingModelNumberId"
              Type = Id Guid
              IsNullable = false }; { Name = "ModelNumber"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CycleMappingFileInfoCycleMappingModelNumber"
        TargetTable =
         { Name = TableName "CycleMappingFileInfoCycleMappingModelNumber"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingFileInfoId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleMappingModelNumberId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "CycleMappingFileInfo"
                          Name = "CycleMappingFileInfo"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingModelNumber"
                          Name = "CycleMappingModelNumber"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CycleMappingFileInfoCycleMappingModelNumber"
        KeyType = Guid }] }-CycleMappingFileInfoCycleMappingModelNumber-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleMappingFileInfoCycleMappingModelNumbers
                                    .Where(x => x.CycleMappingFileInfoCycleMappingModelNumber != null && ids.Contains((Guid)x.CycleMappingFileInfoCycleMappingModelNumber))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleMappingFileInfoCycleMappingModelNumber!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CycleMappingFileInfoCycleMappingModelNumbers);
                    });
            
        }
    }
}
            