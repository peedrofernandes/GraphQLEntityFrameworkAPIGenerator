
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
    public partial class CycleMappingFileInfoGraphType : ObjectGraphType<CycleMappingFileInfo>
    {
        public CycleMappingFileInfoGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleMappingFileInfoId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.HexEncoding, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ProductVariant, type: typeof(ByteGraphType), nullable: True);
            
                Field<CycleMappingFileInfoCycleMappingModelNumberGraphType, CycleMappingFileInfoCycleMappingModelNumber>("CycleMappingFileInfoCycleMappingModelNumbers")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingFileInfoCycleMappingModelNumberGraphType>>(
                            "{ Name = EntityName "CycleMappingFileInfo"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; ForeignKey { Type = String
                                                       Name = "FileId"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "HexEncoding"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ProductVariant"
                                                       IsNullable = true };
         Navigation
           { Type = TableName "CycleMappingFileInfoCycleMappingModelNumber"
             Name = "CycleMappingFileInfoCycleMappingModelNumbers"
             IsNullable = false
             IsCollection = true }; Navigation { Type = TableName "CycleMapping"
                                                 Name = "CycleMappings"
                                                 IsNullable = false
                                                 IsCollection = true };
         Navigation { Type = TableName "CycleMappingProductVariant"
                      Name = "ProductVariantNavigation"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "CycleMappingFileInfoId"
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
    { Name = "HexEncoding"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ProductVariant"
                              Type = Primitive Byte
                              IsNullable = true }]
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
        KeyType = Guid };
    OneToMany
      { Name = RelationName "CycleMapping"
        TargetTable =
         { Name = TableName "CycleMapping"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingId"
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
             ForeignKey { Type = Byte
                          Name = "ExportOptionId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsConnected"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "DataModelVersion"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "Version"
                                                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "CycleMappingFileInfoId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CycleMappingAcuTargetId"
                          IsNullable = true };
             Navigation { Type = TableName "CycleMappingAcuTarget"
                          Name = "CycleMappingAcuTarget"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CycleMappingFileInfo"
                          Name = "CycleMappingFileInfo"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingExportOption"
                          Name = "ExportOption"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleMapping"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleMappingProductVariant"
        TargetTable =
         { Name = TableName "CycleMappingProductVariant"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = true };
             Navigation { Type = TableName "CycleMappingFileInfo"
                          Name = "CycleMappingFileInfos"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleMappingProductVariant"
        IsNullable = true
        KeyType = Byte }] }-CycleMappingFileInfoCycleMappingModelNumber-loader",
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
            
			
                Field<CycleMappingGraphType, CycleMapping>("CycleMappings")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingGraphType>>(
                            "{ Name = EntityName "CycleMappingFileInfo"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; ForeignKey { Type = String
                                                       Name = "FileId"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "HexEncoding"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ProductVariant"
                                                       IsNullable = true };
         Navigation
           { Type = TableName "CycleMappingFileInfoCycleMappingModelNumber"
             Name = "CycleMappingFileInfoCycleMappingModelNumbers"
             IsNullable = false
             IsCollection = true }; Navigation { Type = TableName "CycleMapping"
                                                 Name = "CycleMappings"
                                                 IsNullable = false
                                                 IsCollection = true };
         Navigation { Type = TableName "CycleMappingProductVariant"
                      Name = "ProductVariantNavigation"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "CycleMappingFileInfoId"
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
    { Name = "HexEncoding"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ProductVariant"
                              Type = Primitive Byte
                              IsNullable = true }]
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
        KeyType = Guid };
    OneToMany
      { Name = RelationName "CycleMapping"
        TargetTable =
         { Name = TableName "CycleMapping"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingId"
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
             ForeignKey { Type = Byte
                          Name = "ExportOptionId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsConnected"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "DataModelVersion"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "Version"
                                                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "CycleMappingFileInfoId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CycleMappingAcuTargetId"
                          IsNullable = true };
             Navigation { Type = TableName "CycleMappingAcuTarget"
                          Name = "CycleMappingAcuTarget"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CycleMappingFileInfo"
                          Name = "CycleMappingFileInfo"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingExportOption"
                          Name = "ExportOption"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleMapping"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleMappingProductVariant"
        TargetTable =
         { Name = TableName "CycleMappingProductVariant"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = true };
             Navigation { Type = TableName "CycleMappingFileInfo"
                          Name = "CycleMappingFileInfos"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleMappingProductVariant"
        IsNullable = true
        KeyType = Byte }] }-CycleMapping-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleMappings
                                    .Where(x => x.CycleMapping != null && ids.Contains((Guid)x.CycleMapping))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleMapping!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CycleMappings);
                    });
            
			
                Field<CycleMappingProductVariantGraphType, CycleMappingProductVariant>("CycleMappingProductVariants")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleMappingProductVariantGraphType>(
                            "{ Name = EntityName "CycleMappingFileInfo"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; ForeignKey { Type = String
                                                       Name = "FileId"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "HexEncoding"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ProductVariant"
                                                       IsNullable = true };
         Navigation
           { Type = TableName "CycleMappingFileInfoCycleMappingModelNumber"
             Name = "CycleMappingFileInfoCycleMappingModelNumbers"
             IsNullable = false
             IsCollection = true }; Navigation { Type = TableName "CycleMapping"
                                                 Name = "CycleMappings"
                                                 IsNullable = false
                                                 IsCollection = true };
         Navigation { Type = TableName "CycleMappingProductVariant"
                      Name = "ProductVariantNavigation"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "CycleMappingFileInfoId"
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
    { Name = "HexEncoding"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ProductVariant"
                              Type = Primitive Byte
                              IsNullable = true }]
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
        KeyType = Guid };
    OneToMany
      { Name = RelationName "CycleMapping"
        TargetTable =
         { Name = TableName "CycleMapping"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingId"
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
             ForeignKey { Type = Byte
                          Name = "ExportOptionId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsConnected"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "DataModelVersion"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "Version"
                                                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "CycleMappingFileInfoId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CycleMappingAcuTargetId"
                          IsNullable = true };
             Navigation { Type = TableName "CycleMappingAcuTarget"
                          Name = "CycleMappingAcuTarget"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CycleMappingFileInfo"
                          Name = "CycleMappingFileInfo"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingExportOption"
                          Name = "ExportOption"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleMapping"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleMappingProductVariant"
        TargetTable =
         { Name = TableName "CycleMappingProductVariant"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = true };
             Navigation { Type = TableName "CycleMappingFileInfo"
                          Name = "CycleMappingFileInfos"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleMappingProductVariant"
        IsNullable = true
        KeyType = Byte }] }-CycleMappingProductVariant-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleMappingProductVariants
                                    .Where(x => x.CycleMappingProductVariant != null && ids.Contains((byte)x.CycleMappingProductVariant))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.CycleMappingProductVariant!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleMappingProductVariant);
                });
            
        }
    }
}
            