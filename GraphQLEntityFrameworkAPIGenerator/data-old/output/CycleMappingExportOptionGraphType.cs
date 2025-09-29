
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
    public partial class CycleMappingExportOptionGraphType : ObjectGraphType<CycleMappingExportOption>
    {
        public CycleMappingExportOptionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
            
                Field<CycleMappingGraphType, CycleMapping>("CycleMappings")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingGraphType>>(
                            "{ Name = EntityName "CycleMappingExportOption"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleMappingExportOption"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Description"
                                                        IsNullable = false };
         Navigation { Type = TableName "CycleMapping"
                      Name = "CycleMappings"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "Id"
              Type = Id Byte
              IsNullable = false }; { Name = "Description"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
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
        KeyType = Guid }] }-CycleMapping-loader",
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
            
        }
    }
}
            