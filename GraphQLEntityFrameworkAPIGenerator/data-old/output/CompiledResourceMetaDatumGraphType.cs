
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
    public partial class CompiledResourceMetaDatumGraphType : ObjectGraphType<CompiledResourceMetaDatum>
    {
        public CompiledResourceMetaDatumGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ProgramingOffset, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Length, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Crc, type: typeof(IdGraphType), nullable: True);
			Field(t => t.EncryptedFileStoragePath, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
            
                Field<ProjectGraphType, Project>("Projects")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ProjectGraphType>(
                            "{ Name = EntityName "CompiledResourceMetaDatum"
  CorrespondingTable =
   Regular
     { Name = TableName "CompiledResourceMetaDatum"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false };
         Primitive { Type = Int
                     Name = "ProgramingOffset"
                     IsNullable = true }; Primitive { Type = Int
                                                      Name = "Length"
                                                      IsNullable = true };
         Primitive { Type = Int
                     Name = "Crc"
                     IsNullable = true };
         Primitive { Type = String
                     Name = "EncryptedFileStoragePath"
                     IsNullable = false }; ForeignKey { Type = Guid
                                                        Name = "ProjectId"
                                                        IsNullable = false };
         Primitive { Type = DateTime
                     Name = "Timestamp"
                     IsNullable = false };
         Navigation { Type = TableName "Project"
                      Name = "Project"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "ProgramingOffset"
                              Type = Primitive Int
                              IsNullable = true }; { Name = "Length"
                                                     Type = Primitive Int
                                                     IsNullable = true };
    { Name = "Crc"
      Type = Primitive Int
      IsNullable = true }; { Name = "EncryptedFileStoragePath"
                             Type = Primitive String
                             IsNullable = false }; { Name = "Timestamp"
                                                     Type = Primitive DateTime
                                                     IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Project"
        TargetTable =
         { Name = TableName "Project"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ProjectId"
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
             Primitive { Type = String
                         Name = "IndustrialCode"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "ModelName"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "AcuConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "MachineConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SelectorConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "HmiConfigurationId"
                          IsNullable = true }; Primitive { Type = String
                                                           Name = "Comment"
                                                           IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "ProjectCode"
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
             Primitive { Type = String
                         Name = "GeneratorVersion"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "SoftwareCodeNumber"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "SoftwarePartNumber"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ChangeActivityNumber"
                         IsNullable = true };
             Primitive { Type = Short
                         Name = "WindchillDescriptionObjectVersion"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "WindchillStatusId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "AttributeTable"
                         IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SettingFileExtensionsId"
                          IsNullable = true };
             Navigation { Type = TableName "Board"
                          Name = "AcuConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CompiledResourceMetaDatum"
                          Name = "CompiledResourceMetaData"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "HmiConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ProductType"
                          Name = "ProductType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "SettingFileExtension"
                          Name = "SettingFileExtensions"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Project"
        IsNullable = false
        KeyType = Guid }] }-Project-loader",
                            async ids => 
                            {
                                var data = await dbContext.Projects
                                    .Where(x => x.Project != null && ids.Contains((Guid)x.Project))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Project!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Project);
                });
            
        }
    }
}
            