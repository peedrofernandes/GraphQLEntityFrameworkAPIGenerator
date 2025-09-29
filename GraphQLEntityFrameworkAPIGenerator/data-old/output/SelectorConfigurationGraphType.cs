
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
    public partial class SelectorConfigurationGraphType : ObjectGraphType<SelectorConfiguration>
    {
        public SelectorConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SelectorConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Code, type: typeof(StringGraphType), nullable: False);
            
                Field<UimacroGraphType, Uimacro>("Uimacros")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UimacroGraphType>(
                            "{ Name = EntityName "SelectorConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "SelectorConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SelectorConfigurationId"
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
                     IsNullable = true }; Primitive { Type = String
                                                      Name = "Code"
                                                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "UiuserFunctionConfigurationId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "GlobalUimacroId"
                                                        IsNullable = true };
         Navigation { Type = TableName "Uimacro"
                      Name = "GlobalUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Project"
                      Name = "Projects"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "SelectorConfigurationsSelector"
                      Name = "SelectorConfigurationsSelectors"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionConfiguration"
                      Name = "UiuserFunctionConfiguration"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "SelectorConfigurationId"
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
    { Name = "Code"
      Type = Primitive String
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Uimacro"
        TargetTable =
         { Name = TableName "Uimacro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UimacroId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
                         Name = "TimeStamp"
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
             Navigation { Type = TableName "Cycle"
                          Name = "CycleDelayUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleEndUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CyclePauseUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleProgrammingUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleRunUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorDelayUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorEndUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorGlobalUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorOffUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorPauseUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorProgrammingUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UimacrosUistatement"
                          Name = "UimacrosUistatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineControlStateDetail"
                          Name = "UiviewEngineControlStateDetailDoMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineControlStateDetail"
                          Name = "UiviewEngineControlStateDetailOnEntryMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineControlStateDetail"
                          Name = "UiviewEngineControlStateDetailOnExitMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineViewsDetail"
                          Name = "UiviewEngineViewsDetailDoMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineViewsDetail"
                          Name = "UiviewEngineViewsDetailOnEntryMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineViewsDetail"
                          Name = "UiviewEngineViewsDetailOnExitMacros"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uimacro"
        IsNullable = true
        KeyType = Guid };
    OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name = RelationName "SelectorConfigurationsSelector"
        TargetTable =
         { Name = TableName "SelectorConfigurationsSelector"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfiguration"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "SelectorConfigurationsSelector"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UifunctionConfiguration"
        TargetTable =
         { Name = TableName "UifunctionConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UifunctionConfigurationId"
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
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Level"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UifunctionConfiguration"
        IsNullable = true
        KeyType = Guid }] }-Uimacro-loader",
                            async ids => 
                            {
                                var data = await dbContext.Uimacros
                                    .Where(x => x.Uimacro != null && ids.Contains((Guid)x.Uimacro))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Uimacro!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Uimacro);
                });
            
			
                Field<ProjectGraphType, Project>("Projects")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ProjectGraphType>>(
                            "{ Name = EntityName "SelectorConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "SelectorConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SelectorConfigurationId"
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
                     IsNullable = true }; Primitive { Type = String
                                                      Name = "Code"
                                                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "UiuserFunctionConfigurationId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "GlobalUimacroId"
                                                        IsNullable = true };
         Navigation { Type = TableName "Uimacro"
                      Name = "GlobalUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Project"
                      Name = "Projects"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "SelectorConfigurationsSelector"
                      Name = "SelectorConfigurationsSelectors"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionConfiguration"
                      Name = "UiuserFunctionConfiguration"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "SelectorConfigurationId"
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
    { Name = "Code"
      Type = Primitive String
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Uimacro"
        TargetTable =
         { Name = TableName "Uimacro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UimacroId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
                         Name = "TimeStamp"
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
             Navigation { Type = TableName "Cycle"
                          Name = "CycleDelayUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleEndUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CyclePauseUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleProgrammingUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleRunUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorDelayUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorEndUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorGlobalUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorOffUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorPauseUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorProgrammingUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UimacrosUistatement"
                          Name = "UimacrosUistatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineControlStateDetail"
                          Name = "UiviewEngineControlStateDetailDoMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineControlStateDetail"
                          Name = "UiviewEngineControlStateDetailOnEntryMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineControlStateDetail"
                          Name = "UiviewEngineControlStateDetailOnExitMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineViewsDetail"
                          Name = "UiviewEngineViewsDetailDoMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineViewsDetail"
                          Name = "UiviewEngineViewsDetailOnEntryMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineViewsDetail"
                          Name = "UiviewEngineViewsDetailOnExitMacros"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uimacro"
        IsNullable = true
        KeyType = Guid };
    OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name = RelationName "SelectorConfigurationsSelector"
        TargetTable =
         { Name = TableName "SelectorConfigurationsSelector"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfiguration"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "SelectorConfigurationsSelector"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UifunctionConfiguration"
        TargetTable =
         { Name = TableName "UifunctionConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UifunctionConfigurationId"
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
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Level"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UifunctionConfiguration"
        IsNullable = true
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
            
			
                Field<SelectorConfigurationsSelectorGraphType, SelectorConfigurationsSelector>("SelectorConfigurationsSelectors")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorConfigurationsSelectorGraphType>>(
                            "{ Name = EntityName "SelectorConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "SelectorConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SelectorConfigurationId"
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
                     IsNullable = true }; Primitive { Type = String
                                                      Name = "Code"
                                                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "UiuserFunctionConfigurationId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "GlobalUimacroId"
                                                        IsNullable = true };
         Navigation { Type = TableName "Uimacro"
                      Name = "GlobalUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Project"
                      Name = "Projects"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "SelectorConfigurationsSelector"
                      Name = "SelectorConfigurationsSelectors"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionConfiguration"
                      Name = "UiuserFunctionConfiguration"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "SelectorConfigurationId"
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
    { Name = "Code"
      Type = Primitive String
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Uimacro"
        TargetTable =
         { Name = TableName "Uimacro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UimacroId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
                         Name = "TimeStamp"
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
             Navigation { Type = TableName "Cycle"
                          Name = "CycleDelayUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleEndUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CyclePauseUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleProgrammingUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleRunUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorDelayUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorEndUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorGlobalUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorOffUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorPauseUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorProgrammingUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UimacrosUistatement"
                          Name = "UimacrosUistatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineControlStateDetail"
                          Name = "UiviewEngineControlStateDetailDoMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineControlStateDetail"
                          Name = "UiviewEngineControlStateDetailOnEntryMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineControlStateDetail"
                          Name = "UiviewEngineControlStateDetailOnExitMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineViewsDetail"
                          Name = "UiviewEngineViewsDetailDoMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineViewsDetail"
                          Name = "UiviewEngineViewsDetailOnEntryMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineViewsDetail"
                          Name = "UiviewEngineViewsDetailOnExitMacros"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uimacro"
        IsNullable = true
        KeyType = Guid };
    OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name = RelationName "SelectorConfigurationsSelector"
        TargetTable =
         { Name = TableName "SelectorConfigurationsSelector"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfiguration"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "SelectorConfigurationsSelector"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UifunctionConfiguration"
        TargetTable =
         { Name = TableName "UifunctionConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UifunctionConfigurationId"
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
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Level"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UifunctionConfiguration"
        IsNullable = true
        KeyType = Guid }] }-SelectorConfigurationsSelector-loader",
                            async ids => 
                            {
                                var data = await dbContext.SelectorConfigurationsSelectors
                                    .Where(x => x.SelectorConfigurationsSelector != null && ids.Contains((Guid)x.SelectorConfigurationsSelector))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.SelectorConfigurationsSelector!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.SelectorConfigurationsSelectors);
                    });
            
			
                Field<UifunctionConfigurationGraphType, UifunctionConfiguration>("UifunctionConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UifunctionConfigurationGraphType>(
                            "{ Name = EntityName "SelectorConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "SelectorConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SelectorConfigurationId"
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
                     IsNullable = true }; Primitive { Type = String
                                                      Name = "Code"
                                                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "UiuserFunctionConfigurationId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "GlobalUimacroId"
                                                        IsNullable = true };
         Navigation { Type = TableName "Uimacro"
                      Name = "GlobalUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Project"
                      Name = "Projects"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "SelectorConfigurationsSelector"
                      Name = "SelectorConfigurationsSelectors"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionConfiguration"
                      Name = "UiuserFunctionConfiguration"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "SelectorConfigurationId"
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
    { Name = "Code"
      Type = Primitive String
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Uimacro"
        TargetTable =
         { Name = TableName "Uimacro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UimacroId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
                         Name = "TimeStamp"
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
             Navigation { Type = TableName "Cycle"
                          Name = "CycleDelayUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleEndUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CyclePauseUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleProgrammingUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleRunUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorDelayUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorEndUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorGlobalUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorOffUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorPauseUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "SelectorProgrammingUimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UimacrosUistatement"
                          Name = "UimacrosUistatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineControlStateDetail"
                          Name = "UiviewEngineControlStateDetailDoMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineControlStateDetail"
                          Name = "UiviewEngineControlStateDetailOnEntryMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineControlStateDetail"
                          Name = "UiviewEngineControlStateDetailOnExitMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineViewsDetail"
                          Name = "UiviewEngineViewsDetailDoMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineViewsDetail"
                          Name = "UiviewEngineViewsDetailOnEntryMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiviewEngineViewsDetail"
                          Name = "UiviewEngineViewsDetailOnExitMacros"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uimacro"
        IsNullable = true
        KeyType = Guid };
    OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name = RelationName "SelectorConfigurationsSelector"
        TargetTable =
         { Name = TableName "SelectorConfigurationsSelector"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfiguration"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "SelectorConfigurationsSelector"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UifunctionConfiguration"
        TargetTable =
         { Name = TableName "UifunctionConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UifunctionConfigurationId"
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
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Level"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UifunctionConfiguration"
        IsNullable = true
        KeyType = Guid }] }-UifunctionConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UifunctionConfigurations
                                    .Where(x => x.UifunctionConfiguration != null && ids.Contains((Guid)x.UifunctionConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UifunctionConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UifunctionConfiguration);
                });
            
        }
    }
}
            