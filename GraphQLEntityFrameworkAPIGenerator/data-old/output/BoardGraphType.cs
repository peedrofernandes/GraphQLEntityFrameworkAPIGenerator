
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
    public partial class BoardGraphType : ObjectGraphType<Board>
    {
        public BoardGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.BoardId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Code, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NodeAddress, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StartPosition, type: typeof(LongGraphType), nullable: False);
			Field(t => t.Size, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ReadableFlash, type: typeof(ByteGraphType), nullable: False);
            
                Field<AcuexpansionBoardConfigurationGraphType, AcuexpansionBoardConfiguration>("AcuexpansionBoardConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, AcuexpansionBoardConfigurationGraphType>(
                            "{ Name = EntityName "Board"
  CorrespondingTable =
   Regular
     { Name = TableName "Board"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "BoardId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Code"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "Description"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = DateTime
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
         ForeignKey { Type = Guid
                      Name = "LoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "LowLevelInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "GenericInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CrossLoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AcuexpansionBoardConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "NodeAddress"
                                                       IsNullable = false };
         Primitive { Type = Long
                     Name = "StartPosition"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "Size"
                                                       IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "DefaultPinConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "ReadableFlash"
                                                       IsNullable = false };
         Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                      Name = "AcuexpansionBoardConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                      Name = "AcuexpansionBoardConfigurationsBoards"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CrossLoadConfiguration"
                      Name = "CrossLoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "DefaultPinConfiguration"
                      Name = "DefaultPinConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "GenericInputConfiguration"
                      Name = "GenericInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LoadConfiguration"
                      Name = "LoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LowLevelInputConfiguration"
                      Name = "LowLevelInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Project"
                      Name = "Projects"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "BoardId"
      Type = Id Guid
      IsNullable = false }; { Name = "Code"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NodeAddress"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "StartPosition"
                                                     Type = Primitive Long
                                                     IsNullable = false };
    { Name = "Size"
      Type = Primitive Int
      IsNullable = false }; { Name = "ReadableFlash"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "AcuexpansionBoardConfiguration"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
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
             Navigation
               { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                 Name = "AcuexpansionBoardConfigurationsBoards"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Board"
                                                     Name = "Boards"
                                                     IsNullable = false
                                                     IsCollection = true }] }
        Destination = EntityName "AcuexpansionBoardConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "AcuexpansionBoardConfigurationsBoard"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfigurationsBoard"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "BoardId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                          Name = "AcuexpansionBoardConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Board"
                          Name = "Board"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "AcuexpansionBoardConfigurationsBoard"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CrossLoadConfiguration"
        TargetTable =
         { Name = TableName "CrossLoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DefaultPinConfiguration"
        TargetTable =
         { Name = TableName "DefaultPinConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
                 Name = "DefaultPinConfigurationsDefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DefaultPinConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "GenericInputConfiguration"
        TargetTable =
         { Name = TableName "GenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LoadConfiguration"
        TargetTable =
         { Name = TableName "LoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LowLevelInputConfiguration"
        TargetTable =
         { Name = TableName "LowLevelInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
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
                                                           Name = "Board"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LowLevelInputConfiguration"
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
    SingleManyToOne
      { Name = RelationName "TableTarget"
        TargetTable =
         { Name = TableName "TableTarget"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCodeMandatory"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsTargetReleasable"
                         IsNullable = false };
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Macro"
                          Name = "Macros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotGeneralizedProfile"
                          Name = "PilotGeneralizedProfiles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmGianalogToTemperature"
                          Name = "PrmGianalogToTemperatures"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiclassBeventConfiguration"
                          Name = "UiclassBeventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UifunctionConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionDetail"
                          Name = "UifunctionDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogEncoder"
                          Name = "UiprmGianalogEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogPotentiometer"
                          Name = "UiprmGianalogPotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGidiscretePotentiometer"
                          Name = "UiprmGidiscretePotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGiincrementalEncoder"
                          Name = "UiprmGiincrementalEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGitouchSlider"
                          Name = "UiprmGitouchSliders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiregulationTable"
                          Name = "UiregulationTables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "UisequenceConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uisequence"
                          Name = "Uisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uistep"
                          Name = "Uisteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "TableTarget"
        IsNullable = false
        KeyType = Byte }] }-AcuexpansionBoardConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.AcuexpansionBoardConfigurations
                                    .Where(x => x.AcuexpansionBoardConfiguration != null && ids.Contains((Guid)x.AcuexpansionBoardConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.AcuexpansionBoardConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.AcuexpansionBoardConfiguration);
                });
            
			
                Field<AcuexpansionBoardConfigurationsBoardGraphType, AcuexpansionBoardConfigurationsBoard>("AcuexpansionBoardConfigurationsBoards")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<AcuexpansionBoardConfigurationsBoardGraphType>>(
                            "{ Name = EntityName "Board"
  CorrespondingTable =
   Regular
     { Name = TableName "Board"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "BoardId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Code"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "Description"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = DateTime
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
         ForeignKey { Type = Guid
                      Name = "LoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "LowLevelInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "GenericInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CrossLoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AcuexpansionBoardConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "NodeAddress"
                                                       IsNullable = false };
         Primitive { Type = Long
                     Name = "StartPosition"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "Size"
                                                       IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "DefaultPinConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "ReadableFlash"
                                                       IsNullable = false };
         Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                      Name = "AcuexpansionBoardConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                      Name = "AcuexpansionBoardConfigurationsBoards"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CrossLoadConfiguration"
                      Name = "CrossLoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "DefaultPinConfiguration"
                      Name = "DefaultPinConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "GenericInputConfiguration"
                      Name = "GenericInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LoadConfiguration"
                      Name = "LoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LowLevelInputConfiguration"
                      Name = "LowLevelInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Project"
                      Name = "Projects"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "BoardId"
      Type = Id Guid
      IsNullable = false }; { Name = "Code"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NodeAddress"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "StartPosition"
                                                     Type = Primitive Long
                                                     IsNullable = false };
    { Name = "Size"
      Type = Primitive Int
      IsNullable = false }; { Name = "ReadableFlash"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "AcuexpansionBoardConfiguration"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
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
             Navigation
               { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                 Name = "AcuexpansionBoardConfigurationsBoards"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Board"
                                                     Name = "Boards"
                                                     IsNullable = false
                                                     IsCollection = true }] }
        Destination = EntityName "AcuexpansionBoardConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "AcuexpansionBoardConfigurationsBoard"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfigurationsBoard"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "BoardId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                          Name = "AcuexpansionBoardConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Board"
                          Name = "Board"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "AcuexpansionBoardConfigurationsBoard"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CrossLoadConfiguration"
        TargetTable =
         { Name = TableName "CrossLoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DefaultPinConfiguration"
        TargetTable =
         { Name = TableName "DefaultPinConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
                 Name = "DefaultPinConfigurationsDefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DefaultPinConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "GenericInputConfiguration"
        TargetTable =
         { Name = TableName "GenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LoadConfiguration"
        TargetTable =
         { Name = TableName "LoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LowLevelInputConfiguration"
        TargetTable =
         { Name = TableName "LowLevelInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
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
                                                           Name = "Board"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LowLevelInputConfiguration"
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
    SingleManyToOne
      { Name = RelationName "TableTarget"
        TargetTable =
         { Name = TableName "TableTarget"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCodeMandatory"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsTargetReleasable"
                         IsNullable = false };
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Macro"
                          Name = "Macros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotGeneralizedProfile"
                          Name = "PilotGeneralizedProfiles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmGianalogToTemperature"
                          Name = "PrmGianalogToTemperatures"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiclassBeventConfiguration"
                          Name = "UiclassBeventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UifunctionConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionDetail"
                          Name = "UifunctionDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogEncoder"
                          Name = "UiprmGianalogEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogPotentiometer"
                          Name = "UiprmGianalogPotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGidiscretePotentiometer"
                          Name = "UiprmGidiscretePotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGiincrementalEncoder"
                          Name = "UiprmGiincrementalEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGitouchSlider"
                          Name = "UiprmGitouchSliders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiregulationTable"
                          Name = "UiregulationTables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "UisequenceConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uisequence"
                          Name = "Uisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uistep"
                          Name = "Uisteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "TableTarget"
        IsNullable = false
        KeyType = Byte }] }-AcuexpansionBoardConfigurationsBoard-loader",
                            async ids => 
                            {
                                var data = await dbContext.AcuexpansionBoardConfigurationsBoards
                                    .Where(x => x.AcuexpansionBoardConfigurationsBoard != null && ids.Contains((Guid)x.AcuexpansionBoardConfigurationsBoard))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.AcuexpansionBoardConfigurationsBoard!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.AcuexpansionBoardConfigurationsBoards);
                    });
            
			
                Field<CrossLoadConfigurationGraphType, CrossLoadConfiguration>("CrossLoadConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CrossLoadConfigurationGraphType>(
                            "{ Name = EntityName "Board"
  CorrespondingTable =
   Regular
     { Name = TableName "Board"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "BoardId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Code"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "Description"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = DateTime
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
         ForeignKey { Type = Guid
                      Name = "LoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "LowLevelInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "GenericInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CrossLoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AcuexpansionBoardConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "NodeAddress"
                                                       IsNullable = false };
         Primitive { Type = Long
                     Name = "StartPosition"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "Size"
                                                       IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "DefaultPinConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "ReadableFlash"
                                                       IsNullable = false };
         Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                      Name = "AcuexpansionBoardConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                      Name = "AcuexpansionBoardConfigurationsBoards"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CrossLoadConfiguration"
                      Name = "CrossLoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "DefaultPinConfiguration"
                      Name = "DefaultPinConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "GenericInputConfiguration"
                      Name = "GenericInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LoadConfiguration"
                      Name = "LoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LowLevelInputConfiguration"
                      Name = "LowLevelInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Project"
                      Name = "Projects"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "BoardId"
      Type = Id Guid
      IsNullable = false }; { Name = "Code"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NodeAddress"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "StartPosition"
                                                     Type = Primitive Long
                                                     IsNullable = false };
    { Name = "Size"
      Type = Primitive Int
      IsNullable = false }; { Name = "ReadableFlash"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "AcuexpansionBoardConfiguration"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
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
             Navigation
               { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                 Name = "AcuexpansionBoardConfigurationsBoards"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Board"
                                                     Name = "Boards"
                                                     IsNullable = false
                                                     IsCollection = true }] }
        Destination = EntityName "AcuexpansionBoardConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "AcuexpansionBoardConfigurationsBoard"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfigurationsBoard"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "BoardId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                          Name = "AcuexpansionBoardConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Board"
                          Name = "Board"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "AcuexpansionBoardConfigurationsBoard"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CrossLoadConfiguration"
        TargetTable =
         { Name = TableName "CrossLoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DefaultPinConfiguration"
        TargetTable =
         { Name = TableName "DefaultPinConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
                 Name = "DefaultPinConfigurationsDefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DefaultPinConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "GenericInputConfiguration"
        TargetTable =
         { Name = TableName "GenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LoadConfiguration"
        TargetTable =
         { Name = TableName "LoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LowLevelInputConfiguration"
        TargetTable =
         { Name = TableName "LowLevelInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
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
                                                           Name = "Board"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LowLevelInputConfiguration"
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
    SingleManyToOne
      { Name = RelationName "TableTarget"
        TargetTable =
         { Name = TableName "TableTarget"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCodeMandatory"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsTargetReleasable"
                         IsNullable = false };
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Macro"
                          Name = "Macros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotGeneralizedProfile"
                          Name = "PilotGeneralizedProfiles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmGianalogToTemperature"
                          Name = "PrmGianalogToTemperatures"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiclassBeventConfiguration"
                          Name = "UiclassBeventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UifunctionConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionDetail"
                          Name = "UifunctionDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogEncoder"
                          Name = "UiprmGianalogEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogPotentiometer"
                          Name = "UiprmGianalogPotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGidiscretePotentiometer"
                          Name = "UiprmGidiscretePotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGiincrementalEncoder"
                          Name = "UiprmGiincrementalEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGitouchSlider"
                          Name = "UiprmGitouchSliders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiregulationTable"
                          Name = "UiregulationTables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "UisequenceConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uisequence"
                          Name = "Uisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uistep"
                          Name = "Uisteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "TableTarget"
        IsNullable = false
        KeyType = Byte }] }-CrossLoadConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.CrossLoadConfigurations
                                    .Where(x => x.CrossLoadConfiguration != null && ids.Contains((Guid)x.CrossLoadConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CrossLoadConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CrossLoadConfiguration);
                });
            
			
                Field<DefaultPinConfigurationGraphType, DefaultPinConfiguration>("DefaultPinConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DefaultPinConfigurationGraphType>(
                            "{ Name = EntityName "Board"
  CorrespondingTable =
   Regular
     { Name = TableName "Board"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "BoardId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Code"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "Description"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = DateTime
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
         ForeignKey { Type = Guid
                      Name = "LoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "LowLevelInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "GenericInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CrossLoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AcuexpansionBoardConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "NodeAddress"
                                                       IsNullable = false };
         Primitive { Type = Long
                     Name = "StartPosition"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "Size"
                                                       IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "DefaultPinConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "ReadableFlash"
                                                       IsNullable = false };
         Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                      Name = "AcuexpansionBoardConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                      Name = "AcuexpansionBoardConfigurationsBoards"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CrossLoadConfiguration"
                      Name = "CrossLoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "DefaultPinConfiguration"
                      Name = "DefaultPinConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "GenericInputConfiguration"
                      Name = "GenericInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LoadConfiguration"
                      Name = "LoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LowLevelInputConfiguration"
                      Name = "LowLevelInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Project"
                      Name = "Projects"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "BoardId"
      Type = Id Guid
      IsNullable = false }; { Name = "Code"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NodeAddress"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "StartPosition"
                                                     Type = Primitive Long
                                                     IsNullable = false };
    { Name = "Size"
      Type = Primitive Int
      IsNullable = false }; { Name = "ReadableFlash"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "AcuexpansionBoardConfiguration"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
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
             Navigation
               { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                 Name = "AcuexpansionBoardConfigurationsBoards"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Board"
                                                     Name = "Boards"
                                                     IsNullable = false
                                                     IsCollection = true }] }
        Destination = EntityName "AcuexpansionBoardConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "AcuexpansionBoardConfigurationsBoard"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfigurationsBoard"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "BoardId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                          Name = "AcuexpansionBoardConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Board"
                          Name = "Board"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "AcuexpansionBoardConfigurationsBoard"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CrossLoadConfiguration"
        TargetTable =
         { Name = TableName "CrossLoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DefaultPinConfiguration"
        TargetTable =
         { Name = TableName "DefaultPinConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
                 Name = "DefaultPinConfigurationsDefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DefaultPinConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "GenericInputConfiguration"
        TargetTable =
         { Name = TableName "GenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LoadConfiguration"
        TargetTable =
         { Name = TableName "LoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LowLevelInputConfiguration"
        TargetTable =
         { Name = TableName "LowLevelInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
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
                                                           Name = "Board"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LowLevelInputConfiguration"
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
    SingleManyToOne
      { Name = RelationName "TableTarget"
        TargetTable =
         { Name = TableName "TableTarget"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCodeMandatory"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsTargetReleasable"
                         IsNullable = false };
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Macro"
                          Name = "Macros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotGeneralizedProfile"
                          Name = "PilotGeneralizedProfiles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmGianalogToTemperature"
                          Name = "PrmGianalogToTemperatures"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiclassBeventConfiguration"
                          Name = "UiclassBeventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UifunctionConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionDetail"
                          Name = "UifunctionDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogEncoder"
                          Name = "UiprmGianalogEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogPotentiometer"
                          Name = "UiprmGianalogPotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGidiscretePotentiometer"
                          Name = "UiprmGidiscretePotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGiincrementalEncoder"
                          Name = "UiprmGiincrementalEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGitouchSlider"
                          Name = "UiprmGitouchSliders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiregulationTable"
                          Name = "UiregulationTables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "UisequenceConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uisequence"
                          Name = "Uisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uistep"
                          Name = "Uisteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "TableTarget"
        IsNullable = false
        KeyType = Byte }] }-DefaultPinConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.DefaultPinConfigurations
                                    .Where(x => x.DefaultPinConfiguration != null && ids.Contains((Guid)x.DefaultPinConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DefaultPinConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.DefaultPinConfiguration);
                });
            
			
                Field<GenericInputConfigurationGraphType, GenericInputConfiguration>("GenericInputConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, GenericInputConfigurationGraphType>(
                            "{ Name = EntityName "Board"
  CorrespondingTable =
   Regular
     { Name = TableName "Board"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "BoardId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Code"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "Description"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = DateTime
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
         ForeignKey { Type = Guid
                      Name = "LoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "LowLevelInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "GenericInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CrossLoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AcuexpansionBoardConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "NodeAddress"
                                                       IsNullable = false };
         Primitive { Type = Long
                     Name = "StartPosition"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "Size"
                                                       IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "DefaultPinConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "ReadableFlash"
                                                       IsNullable = false };
         Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                      Name = "AcuexpansionBoardConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                      Name = "AcuexpansionBoardConfigurationsBoards"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CrossLoadConfiguration"
                      Name = "CrossLoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "DefaultPinConfiguration"
                      Name = "DefaultPinConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "GenericInputConfiguration"
                      Name = "GenericInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LoadConfiguration"
                      Name = "LoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LowLevelInputConfiguration"
                      Name = "LowLevelInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Project"
                      Name = "Projects"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "BoardId"
      Type = Id Guid
      IsNullable = false }; { Name = "Code"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NodeAddress"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "StartPosition"
                                                     Type = Primitive Long
                                                     IsNullable = false };
    { Name = "Size"
      Type = Primitive Int
      IsNullable = false }; { Name = "ReadableFlash"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "AcuexpansionBoardConfiguration"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
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
             Navigation
               { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                 Name = "AcuexpansionBoardConfigurationsBoards"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Board"
                                                     Name = "Boards"
                                                     IsNullable = false
                                                     IsCollection = true }] }
        Destination = EntityName "AcuexpansionBoardConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "AcuexpansionBoardConfigurationsBoard"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfigurationsBoard"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "BoardId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                          Name = "AcuexpansionBoardConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Board"
                          Name = "Board"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "AcuexpansionBoardConfigurationsBoard"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CrossLoadConfiguration"
        TargetTable =
         { Name = TableName "CrossLoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DefaultPinConfiguration"
        TargetTable =
         { Name = TableName "DefaultPinConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
                 Name = "DefaultPinConfigurationsDefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DefaultPinConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "GenericInputConfiguration"
        TargetTable =
         { Name = TableName "GenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LoadConfiguration"
        TargetTable =
         { Name = TableName "LoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LowLevelInputConfiguration"
        TargetTable =
         { Name = TableName "LowLevelInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
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
                                                           Name = "Board"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LowLevelInputConfiguration"
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
    SingleManyToOne
      { Name = RelationName "TableTarget"
        TargetTable =
         { Name = TableName "TableTarget"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCodeMandatory"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsTargetReleasable"
                         IsNullable = false };
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Macro"
                          Name = "Macros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotGeneralizedProfile"
                          Name = "PilotGeneralizedProfiles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmGianalogToTemperature"
                          Name = "PrmGianalogToTemperatures"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiclassBeventConfiguration"
                          Name = "UiclassBeventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UifunctionConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionDetail"
                          Name = "UifunctionDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogEncoder"
                          Name = "UiprmGianalogEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogPotentiometer"
                          Name = "UiprmGianalogPotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGidiscretePotentiometer"
                          Name = "UiprmGidiscretePotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGiincrementalEncoder"
                          Name = "UiprmGiincrementalEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGitouchSlider"
                          Name = "UiprmGitouchSliders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiregulationTable"
                          Name = "UiregulationTables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "UisequenceConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uisequence"
                          Name = "Uisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uistep"
                          Name = "Uisteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "TableTarget"
        IsNullable = false
        KeyType = Byte }] }-GenericInputConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.GenericInputConfigurations
                                    .Where(x => x.GenericInputConfiguration != null && ids.Contains((Guid)x.GenericInputConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.GenericInputConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.GenericInputConfiguration);
                });
            
			
                Field<LoadConfigurationGraphType, LoadConfiguration>("LoadConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, LoadConfigurationGraphType>(
                            "{ Name = EntityName "Board"
  CorrespondingTable =
   Regular
     { Name = TableName "Board"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "BoardId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Code"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "Description"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = DateTime
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
         ForeignKey { Type = Guid
                      Name = "LoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "LowLevelInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "GenericInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CrossLoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AcuexpansionBoardConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "NodeAddress"
                                                       IsNullable = false };
         Primitive { Type = Long
                     Name = "StartPosition"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "Size"
                                                       IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "DefaultPinConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "ReadableFlash"
                                                       IsNullable = false };
         Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                      Name = "AcuexpansionBoardConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                      Name = "AcuexpansionBoardConfigurationsBoards"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CrossLoadConfiguration"
                      Name = "CrossLoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "DefaultPinConfiguration"
                      Name = "DefaultPinConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "GenericInputConfiguration"
                      Name = "GenericInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LoadConfiguration"
                      Name = "LoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LowLevelInputConfiguration"
                      Name = "LowLevelInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Project"
                      Name = "Projects"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "BoardId"
      Type = Id Guid
      IsNullable = false }; { Name = "Code"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NodeAddress"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "StartPosition"
                                                     Type = Primitive Long
                                                     IsNullable = false };
    { Name = "Size"
      Type = Primitive Int
      IsNullable = false }; { Name = "ReadableFlash"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "AcuexpansionBoardConfiguration"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
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
             Navigation
               { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                 Name = "AcuexpansionBoardConfigurationsBoards"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Board"
                                                     Name = "Boards"
                                                     IsNullable = false
                                                     IsCollection = true }] }
        Destination = EntityName "AcuexpansionBoardConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "AcuexpansionBoardConfigurationsBoard"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfigurationsBoard"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "BoardId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                          Name = "AcuexpansionBoardConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Board"
                          Name = "Board"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "AcuexpansionBoardConfigurationsBoard"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CrossLoadConfiguration"
        TargetTable =
         { Name = TableName "CrossLoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DefaultPinConfiguration"
        TargetTable =
         { Name = TableName "DefaultPinConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
                 Name = "DefaultPinConfigurationsDefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DefaultPinConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "GenericInputConfiguration"
        TargetTable =
         { Name = TableName "GenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LoadConfiguration"
        TargetTable =
         { Name = TableName "LoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LowLevelInputConfiguration"
        TargetTable =
         { Name = TableName "LowLevelInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
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
                                                           Name = "Board"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LowLevelInputConfiguration"
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
    SingleManyToOne
      { Name = RelationName "TableTarget"
        TargetTable =
         { Name = TableName "TableTarget"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCodeMandatory"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsTargetReleasable"
                         IsNullable = false };
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Macro"
                          Name = "Macros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotGeneralizedProfile"
                          Name = "PilotGeneralizedProfiles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmGianalogToTemperature"
                          Name = "PrmGianalogToTemperatures"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiclassBeventConfiguration"
                          Name = "UiclassBeventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UifunctionConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionDetail"
                          Name = "UifunctionDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogEncoder"
                          Name = "UiprmGianalogEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogPotentiometer"
                          Name = "UiprmGianalogPotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGidiscretePotentiometer"
                          Name = "UiprmGidiscretePotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGiincrementalEncoder"
                          Name = "UiprmGiincrementalEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGitouchSlider"
                          Name = "UiprmGitouchSliders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiregulationTable"
                          Name = "UiregulationTables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "UisequenceConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uisequence"
                          Name = "Uisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uistep"
                          Name = "Uisteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "TableTarget"
        IsNullable = false
        KeyType = Byte }] }-LoadConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.LoadConfigurations
                                    .Where(x => x.LoadConfiguration != null && ids.Contains((Guid)x.LoadConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.LoadConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.LoadConfiguration);
                });
            
			
                Field<LowLevelInputConfigurationGraphType, LowLevelInputConfiguration>("LowLevelInputConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, LowLevelInputConfigurationGraphType>(
                            "{ Name = EntityName "Board"
  CorrespondingTable =
   Regular
     { Name = TableName "Board"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "BoardId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Code"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "Description"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = DateTime
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
         ForeignKey { Type = Guid
                      Name = "LoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "LowLevelInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "GenericInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CrossLoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AcuexpansionBoardConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "NodeAddress"
                                                       IsNullable = false };
         Primitive { Type = Long
                     Name = "StartPosition"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "Size"
                                                       IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "DefaultPinConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "ReadableFlash"
                                                       IsNullable = false };
         Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                      Name = "AcuexpansionBoardConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                      Name = "AcuexpansionBoardConfigurationsBoards"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CrossLoadConfiguration"
                      Name = "CrossLoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "DefaultPinConfiguration"
                      Name = "DefaultPinConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "GenericInputConfiguration"
                      Name = "GenericInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LoadConfiguration"
                      Name = "LoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LowLevelInputConfiguration"
                      Name = "LowLevelInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Project"
                      Name = "Projects"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "BoardId"
      Type = Id Guid
      IsNullable = false }; { Name = "Code"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NodeAddress"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "StartPosition"
                                                     Type = Primitive Long
                                                     IsNullable = false };
    { Name = "Size"
      Type = Primitive Int
      IsNullable = false }; { Name = "ReadableFlash"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "AcuexpansionBoardConfiguration"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
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
             Navigation
               { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                 Name = "AcuexpansionBoardConfigurationsBoards"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Board"
                                                     Name = "Boards"
                                                     IsNullable = false
                                                     IsCollection = true }] }
        Destination = EntityName "AcuexpansionBoardConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "AcuexpansionBoardConfigurationsBoard"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfigurationsBoard"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "BoardId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                          Name = "AcuexpansionBoardConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Board"
                          Name = "Board"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "AcuexpansionBoardConfigurationsBoard"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CrossLoadConfiguration"
        TargetTable =
         { Name = TableName "CrossLoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DefaultPinConfiguration"
        TargetTable =
         { Name = TableName "DefaultPinConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
                 Name = "DefaultPinConfigurationsDefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DefaultPinConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "GenericInputConfiguration"
        TargetTable =
         { Name = TableName "GenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LoadConfiguration"
        TargetTable =
         { Name = TableName "LoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LowLevelInputConfiguration"
        TargetTable =
         { Name = TableName "LowLevelInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
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
                                                           Name = "Board"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LowLevelInputConfiguration"
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
    SingleManyToOne
      { Name = RelationName "TableTarget"
        TargetTable =
         { Name = TableName "TableTarget"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCodeMandatory"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsTargetReleasable"
                         IsNullable = false };
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Macro"
                          Name = "Macros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotGeneralizedProfile"
                          Name = "PilotGeneralizedProfiles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmGianalogToTemperature"
                          Name = "PrmGianalogToTemperatures"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiclassBeventConfiguration"
                          Name = "UiclassBeventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UifunctionConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionDetail"
                          Name = "UifunctionDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogEncoder"
                          Name = "UiprmGianalogEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogPotentiometer"
                          Name = "UiprmGianalogPotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGidiscretePotentiometer"
                          Name = "UiprmGidiscretePotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGiincrementalEncoder"
                          Name = "UiprmGiincrementalEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGitouchSlider"
                          Name = "UiprmGitouchSliders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiregulationTable"
                          Name = "UiregulationTables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "UisequenceConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uisequence"
                          Name = "Uisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uistep"
                          Name = "Uisteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "TableTarget"
        IsNullable = false
        KeyType = Byte }] }-LowLevelInputConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.LowLevelInputConfigurations
                                    .Where(x => x.LowLevelInputConfiguration != null && ids.Contains((Guid)x.LowLevelInputConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.LowLevelInputConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.LowLevelInputConfiguration);
                });
            
			
                Field<ProjectGraphType, Project>("Projects")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ProjectGraphType>>(
                            "{ Name = EntityName "Board"
  CorrespondingTable =
   Regular
     { Name = TableName "Board"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "BoardId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Code"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "Description"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = DateTime
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
         ForeignKey { Type = Guid
                      Name = "LoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "LowLevelInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "GenericInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CrossLoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AcuexpansionBoardConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "NodeAddress"
                                                       IsNullable = false };
         Primitive { Type = Long
                     Name = "StartPosition"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "Size"
                                                       IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "DefaultPinConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "ReadableFlash"
                                                       IsNullable = false };
         Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                      Name = "AcuexpansionBoardConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                      Name = "AcuexpansionBoardConfigurationsBoards"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CrossLoadConfiguration"
                      Name = "CrossLoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "DefaultPinConfiguration"
                      Name = "DefaultPinConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "GenericInputConfiguration"
                      Name = "GenericInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LoadConfiguration"
                      Name = "LoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LowLevelInputConfiguration"
                      Name = "LowLevelInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Project"
                      Name = "Projects"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "BoardId"
      Type = Id Guid
      IsNullable = false }; { Name = "Code"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NodeAddress"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "StartPosition"
                                                     Type = Primitive Long
                                                     IsNullable = false };
    { Name = "Size"
      Type = Primitive Int
      IsNullable = false }; { Name = "ReadableFlash"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "AcuexpansionBoardConfiguration"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
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
             Navigation
               { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                 Name = "AcuexpansionBoardConfigurationsBoards"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Board"
                                                     Name = "Boards"
                                                     IsNullable = false
                                                     IsCollection = true }] }
        Destination = EntityName "AcuexpansionBoardConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "AcuexpansionBoardConfigurationsBoard"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfigurationsBoard"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "BoardId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                          Name = "AcuexpansionBoardConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Board"
                          Name = "Board"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "AcuexpansionBoardConfigurationsBoard"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CrossLoadConfiguration"
        TargetTable =
         { Name = TableName "CrossLoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DefaultPinConfiguration"
        TargetTable =
         { Name = TableName "DefaultPinConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
                 Name = "DefaultPinConfigurationsDefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DefaultPinConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "GenericInputConfiguration"
        TargetTable =
         { Name = TableName "GenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LoadConfiguration"
        TargetTable =
         { Name = TableName "LoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LowLevelInputConfiguration"
        TargetTable =
         { Name = TableName "LowLevelInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
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
                                                           Name = "Board"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LowLevelInputConfiguration"
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
    SingleManyToOne
      { Name = RelationName "TableTarget"
        TargetTable =
         { Name = TableName "TableTarget"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCodeMandatory"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsTargetReleasable"
                         IsNullable = false };
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Macro"
                          Name = "Macros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotGeneralizedProfile"
                          Name = "PilotGeneralizedProfiles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmGianalogToTemperature"
                          Name = "PrmGianalogToTemperatures"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiclassBeventConfiguration"
                          Name = "UiclassBeventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UifunctionConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionDetail"
                          Name = "UifunctionDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogEncoder"
                          Name = "UiprmGianalogEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogPotentiometer"
                          Name = "UiprmGianalogPotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGidiscretePotentiometer"
                          Name = "UiprmGidiscretePotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGiincrementalEncoder"
                          Name = "UiprmGiincrementalEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGitouchSlider"
                          Name = "UiprmGitouchSliders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiregulationTable"
                          Name = "UiregulationTables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "UisequenceConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uisequence"
                          Name = "Uisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uistep"
                          Name = "Uisteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "TableTarget"
        IsNullable = false
        KeyType = Byte }] }-Project-loader",
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
            
			
                Field<TableTargetGraphType, TableTarget>("TableTargets")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                            "{ Name = EntityName "Board"
  CorrespondingTable =
   Regular
     { Name = TableName "Board"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "BoardId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Code"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "Description"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = DateTime
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
         ForeignKey { Type = Guid
                      Name = "LoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "LowLevelInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "GenericInputConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CrossLoadConfigurationId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "AcuexpansionBoardConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "NodeAddress"
                                                       IsNullable = false };
         Primitive { Type = Long
                     Name = "StartPosition"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "Size"
                                                       IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "DefaultPinConfigurationId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "ReadableFlash"
                                                       IsNullable = false };
         Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                      Name = "AcuexpansionBoardConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                      Name = "AcuexpansionBoardConfigurationsBoards"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CrossLoadConfiguration"
                      Name = "CrossLoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "DefaultPinConfiguration"
                      Name = "DefaultPinConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "GenericInputConfiguration"
                      Name = "GenericInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LoadConfiguration"
                      Name = "LoadConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "LowLevelInputConfiguration"
                      Name = "LowLevelInputConfiguration"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Project"
                      Name = "Projects"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "BoardId"
      Type = Id Guid
      IsNullable = false }; { Name = "Code"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NodeAddress"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "StartPosition"
                                                     Type = Primitive Long
                                                     IsNullable = false };
    { Name = "Size"
      Type = Primitive Int
      IsNullable = false }; { Name = "ReadableFlash"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "AcuexpansionBoardConfiguration"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
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
             Navigation
               { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                 Name = "AcuexpansionBoardConfigurationsBoards"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Board"
                                                     Name = "Boards"
                                                     IsNullable = false
                                                     IsCollection = true }] }
        Destination = EntityName "AcuexpansionBoardConfiguration"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "AcuexpansionBoardConfigurationsBoard"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfigurationsBoard"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "BoardId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                          Name = "AcuexpansionBoardConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Board"
                          Name = "Board"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "AcuexpansionBoardConfigurationsBoard"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CrossLoadConfiguration"
        TargetTable =
         { Name = TableName "CrossLoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DefaultPinConfiguration"
        TargetTable =
         { Name = TableName "DefaultPinConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
                 Name = "DefaultPinConfigurationsDefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DefaultPinConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "GenericInputConfiguration"
        TargetTable =
         { Name = TableName "GenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LoadConfiguration"
        TargetTable =
         { Name = TableName "LoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LowLevelInputConfiguration"
        TargetTable =
         { Name = TableName "LowLevelInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
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
                                                           Name = "Board"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LowLevelInputConfiguration"
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
    SingleManyToOne
      { Name = RelationName "TableTarget"
        TargetTable =
         { Name = TableName "TableTarget"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCodeMandatory"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsTargetReleasable"
                         IsNullable = false };
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Macro"
                          Name = "Macros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotGeneralizedProfile"
                          Name = "PilotGeneralizedProfiles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmGianalogToTemperature"
                          Name = "PrmGianalogToTemperatures"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiclassBeventConfiguration"
                          Name = "UiclassBeventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UifunctionConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionDetail"
                          Name = "UifunctionDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogEncoder"
                          Name = "UiprmGianalogEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogPotentiometer"
                          Name = "UiprmGianalogPotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGidiscretePotentiometer"
                          Name = "UiprmGidiscretePotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGiincrementalEncoder"
                          Name = "UiprmGiincrementalEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGitouchSlider"
                          Name = "UiprmGitouchSliders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiregulationTable"
                          Name = "UiregulationTables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "UisequenceConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uisequence"
                          Name = "Uisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uistep"
                          Name = "Uisteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "TableTarget"
        IsNullable = false
        KeyType = Byte }] }-TableTarget-loader",
                            async ids => 
                            {
                                var data = await dbContext.TableTargets
                                    .Where(x => x.TableTarget != null && ids.Contains((byte)x.TableTarget))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.TableTarget!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.TableTarget);
                });
            
        }
    }
}
            