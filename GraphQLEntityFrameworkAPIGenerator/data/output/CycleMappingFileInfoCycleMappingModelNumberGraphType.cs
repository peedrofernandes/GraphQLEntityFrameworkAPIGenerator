
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
    public partial class CycleMappingFileInfoCycleMappingModelNumberGraphType : ObjectGraphType<CycleMappingFileInfoCycleMappingModelNumber>
    {
        public CycleMappingFileInfoCycleMappingModelNumberGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleMappingFileInfoId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CycleMappingModelNumberId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<CycleMappingFileInfoGraphType, CycleMappingFileInfo>("CycleMappingFileInfos")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleMappingFileInfoGraphType>(
                            "{ Name = EntityName "CycleMappingFileInfoCycleMappingModelNumber"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleMappingFileInfoCycleMappingModelNumber"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleMappingFileInfoId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "CycleMappingModelNumberId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "CycleMappingFileInfoId"
      Type = Id Guid
      IsNullable = false }; { Name = "CycleMappingModelNumberId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleMappingFileInfo"
        TargetTable =
         { Name = TableName "CycleMappingFileInfo"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingFileInfoId"
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
             ForeignKey { Type = String
                          Name = "FileId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "HexEncoding"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "ProductVariant"
                         IsNullable = true };
             Navigation
               { Type = TableName "CycleMappingFileInfoCycleMappingModelNumber"
                 Name = "CycleMappingFileInfoCycleMappingModelNumbers"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CycleMapping"
                          Name = "CycleMappings"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CycleMappingProductVariant"
                          Name = "ProductVariantNavigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "CycleMappingFileInfo"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleMappingModelNumber"
        TargetTable =
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
        Destination = EntityName "CycleMappingModelNumber"
        IsNullable = false
        KeyType = Guid }] }-CycleMappingFileInfo-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleMappingFileInfos
                                    .Where(x => x.CycleMappingFileInfo != null && ids.Contains((Guid)x.CycleMappingFileInfo))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleMappingFileInfo!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleMappingFileInfo);
                });
            
			
                Field<CycleMappingModelNumberGraphType, CycleMappingModelNumber>("CycleMappingModelNumbers")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleMappingModelNumberGraphType>(
                            "{ Name = EntityName "CycleMappingFileInfoCycleMappingModelNumber"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleMappingFileInfoCycleMappingModelNumber"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleMappingFileInfoId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "CycleMappingModelNumberId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "CycleMappingFileInfoId"
      Type = Id Guid
      IsNullable = false }; { Name = "CycleMappingModelNumberId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleMappingFileInfo"
        TargetTable =
         { Name = TableName "CycleMappingFileInfo"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingFileInfoId"
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
             ForeignKey { Type = String
                          Name = "FileId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "HexEncoding"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "ProductVariant"
                         IsNullable = true };
             Navigation
               { Type = TableName "CycleMappingFileInfoCycleMappingModelNumber"
                 Name = "CycleMappingFileInfoCycleMappingModelNumbers"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CycleMapping"
                          Name = "CycleMappings"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CycleMappingProductVariant"
                          Name = "ProductVariantNavigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "CycleMappingFileInfo"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleMappingModelNumber"
        TargetTable =
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
        Destination = EntityName "CycleMappingModelNumber"
        IsNullable = false
        KeyType = Guid }] }-CycleMappingModelNumber-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleMappingModelNumbers
                                    .Where(x => x.CycleMappingModelNumber != null && ids.Contains((Guid)x.CycleMappingModelNumber))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleMappingModelNumber!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleMappingModelNumber);
                });
            
        }
    }
}
            