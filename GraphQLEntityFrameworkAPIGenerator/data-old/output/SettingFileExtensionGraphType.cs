
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
    public partial class SettingFileExtensionGraphType : ObjectGraphType<SettingFileExtension>
    {
        public SettingFileExtensionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SettingFileExtensionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.HighStatementsExt, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.LowStatementsExt, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OpCodeLowStatementExt, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.IsMaintainModifiersExtended, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsTtemodifiersExtended, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsHmiiopointerExtended, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsHmiexpansion1IopointerExtended, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsHmiexpansion2IopointerExtended, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsHmiexpansion3IopointerExtended, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsHmiexpansion4IopointerExtended, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsHmiexpansion5IopointerExtended, type: typeof(BoolGraphType), nullable: False);
            
                Field<ProjectGraphType, Project>("Projects")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ProjectGraphType>>(
                            "{ Name = EntityName "SettingFileExtension"
  CorrespondingTable =
   Regular
     { Name = TableName "SettingFileExtension"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SettingFileExtensionsId"
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
                     IsNullable = true }; Primitive { Type = Bool
                                                      Name = "HighStatementsExt"
                                                      IsNullable = false };
         Primitive { Type = Bool
                     Name = "LowStatementsExt"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "OpCodeLowStatementExt"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsMaintainModifiersExtended"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsTtemodifiersExtended"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsHmiiopointerExtended"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsHmiexpansion1IopointerExtended"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsHmiexpansion2IopointerExtended"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsHmiexpansion3IopointerExtended"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsHmiexpansion4IopointerExtended"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsHmiexpansion5IopointerExtended"
                     IsNullable = false };
         Navigation { Type = TableName "Project"
                      Name = "Projects"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "SettingFileExtensionsId"
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
    { Name = "HighStatementsExt"
      Type = Primitive Bool
      IsNullable = false }; { Name = "LowStatementsExt"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "OpCodeLowStatementExt"
      Type = Primitive Short
      IsNullable = false }; { Name = "IsMaintainModifiersExtended"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "IsTtemodifiersExtended"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsHmiiopointerExtended"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "IsHmiexpansion1IopointerExtended"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsHmiexpansion2IopointerExtended"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "IsHmiexpansion3IopointerExtended"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsHmiexpansion4IopointerExtended"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "IsHmiexpansion5IopointerExtended"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [OneToMany
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
                            });

                        return loader.LoadAsync(context.Source.Projects);
                    });
            
        }
    }
}
            