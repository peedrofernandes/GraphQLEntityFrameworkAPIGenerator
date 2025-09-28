
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
    public partial class CycleGraphType : ObjectGraphType<Cycle>
    {
        public CycleGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.AfterFaultRestore, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.BackupRestore, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Pause, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CycleName, type: typeof(IdGraphType), nullable: False);
			Field(t => t.CycleHeading, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleSubHeading, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleGroup, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Target, type: typeof(ByteGraphType), nullable: False);
            
                Field<CycleNameGraphType, CycleName>("CycleNames")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, CycleNameGraphType>(
                            "{ Name = EntityName "Cycle"
  CorrespondingTable =
   Regular
     { Name = TableName "Cycle"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleId"
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
         ForeignKey { Type = Guid
                      Name = "ProgrammingMacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "DelayMacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PauseMacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "EndMacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ProgrammingUimacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "DelayUimacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PauseUimacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "EndUimacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "RunUimacroId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "AfterFaultRestore"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "BackupRestore"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Pause"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "CycleName"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleHeading"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "CycleSubHeading"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleGroup"
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Target"
                                                      IsNullable = false };
         Navigation { Type = TableName "CycleName"
                      Name = "CycleNameNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CyclesMacro"
                      Name = "CyclesMacros"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Macro"
                      Name = "DelayMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "DelayUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "EndMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "EndUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "PauseMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "PauseUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "ProgrammingMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "ProgrammingUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "RunUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "SelectorsCycle"
                      Name = "SelectorsCycles"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "CycleId"
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
                              IsNullable = false }; { Name = "AfterFaultRestore"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "BackupRestore"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Pause"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "CycleName"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "CycleHeading"
      Type = Primitive Byte
      IsNullable = false }; { Name = "CycleSubHeading"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "CycleGroup"
                                                      Type = Primitive Byte
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
      IsNullable = true }; { Name = "Target"
                             Type = Primitive Byte
                             IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleName"
        TargetTable =
         { Name = TableName "CycleName"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "CycleName1"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleHeading"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleSubHeading"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleGroup"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsForSubcycles"
                         IsNullable = false };
             Navigation { Type = TableName "CycleGroup"
                          Name = "CycleGroupNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleHeading"
                          Name = "CycleHeadingNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleName"
        IsNullable = false
        KeyType = Int };
    OneToMany
      { Name = RelationName "CyclesMacro"
        TargetTable =
         { Name = TableName "CyclesMacro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "MacroId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "PhaseName"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = true };
             Primitive { Type = Int
                         Name = "UserPhaseName"
                         IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Macro"
                          Name = "Macro"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "TimeEstimation"
                          Name = "TimeEstimation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UserPhaseName"
                          Name = "UserPhaseNameNavigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "CyclesMacro"
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "DelayMacro"; RelationName "EndMacro";
          RelationName "PauseMacro"; RelationName "ProgrammingMacro"]
        TargetTable =
         { Name = TableName "Macro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MacroId"
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
             Primitive { Type = Byte
                         Name = "Target"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Comment"
                                                           IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleDelayMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleEndMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CyclePauseMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleProgrammingMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MacrosStatement"
                          Name = "MacrosStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Macro"
        IsNullable = true
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "DelayUimacro"; RelationName "EndUimacro";
          RelationName "PauseUimacro"; RelationName "ProgrammingUimacro";
          RelationName "RunUimacro"]
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
      { Name = RelationName "SelectorsCycle"
        TargetTable =
         { Name = TableName "SelectorsCycle"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "SelectorConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "EnteringCycle"
                         IsNullable = true }; ForeignKey { Type = Guid
                                                           Name = "ConditionId"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Priority"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CycleTypeId"
                                                            IsNullable = false };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "SelectorCondition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "SelectorsCycle"
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
        KeyType = Byte }] }-CycleName-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleNames
                                    .Where(x => x.CycleName != null && ids.Contains((int)x.CycleName))
                                    .Select(x => new
                                    {
                                        Key = (int)x.CycleName!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleName);
                });
            
			
                Field<CyclesMacroGraphType, CyclesMacro>("CyclesMacros")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CyclesMacroGraphType>>(
                            "{ Name = EntityName "Cycle"
  CorrespondingTable =
   Regular
     { Name = TableName "Cycle"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleId"
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
         ForeignKey { Type = Guid
                      Name = "ProgrammingMacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "DelayMacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PauseMacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "EndMacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ProgrammingUimacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "DelayUimacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PauseUimacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "EndUimacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "RunUimacroId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "AfterFaultRestore"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "BackupRestore"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Pause"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "CycleName"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleHeading"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "CycleSubHeading"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleGroup"
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Target"
                                                      IsNullable = false };
         Navigation { Type = TableName "CycleName"
                      Name = "CycleNameNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CyclesMacro"
                      Name = "CyclesMacros"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Macro"
                      Name = "DelayMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "DelayUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "EndMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "EndUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "PauseMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "PauseUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "ProgrammingMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "ProgrammingUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "RunUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "SelectorsCycle"
                      Name = "SelectorsCycles"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "CycleId"
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
                              IsNullable = false }; { Name = "AfterFaultRestore"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "BackupRestore"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Pause"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "CycleName"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "CycleHeading"
      Type = Primitive Byte
      IsNullable = false }; { Name = "CycleSubHeading"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "CycleGroup"
                                                      Type = Primitive Byte
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
      IsNullable = true }; { Name = "Target"
                             Type = Primitive Byte
                             IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleName"
        TargetTable =
         { Name = TableName "CycleName"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "CycleName1"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleHeading"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleSubHeading"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleGroup"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsForSubcycles"
                         IsNullable = false };
             Navigation { Type = TableName "CycleGroup"
                          Name = "CycleGroupNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleHeading"
                          Name = "CycleHeadingNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleName"
        IsNullable = false
        KeyType = Int };
    OneToMany
      { Name = RelationName "CyclesMacro"
        TargetTable =
         { Name = TableName "CyclesMacro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "MacroId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "PhaseName"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = true };
             Primitive { Type = Int
                         Name = "UserPhaseName"
                         IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Macro"
                          Name = "Macro"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "TimeEstimation"
                          Name = "TimeEstimation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UserPhaseName"
                          Name = "UserPhaseNameNavigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "CyclesMacro"
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "DelayMacro"; RelationName "EndMacro";
          RelationName "PauseMacro"; RelationName "ProgrammingMacro"]
        TargetTable =
         { Name = TableName "Macro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MacroId"
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
             Primitive { Type = Byte
                         Name = "Target"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Comment"
                                                           IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleDelayMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleEndMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CyclePauseMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleProgrammingMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MacrosStatement"
                          Name = "MacrosStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Macro"
        IsNullable = true
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "DelayUimacro"; RelationName "EndUimacro";
          RelationName "PauseUimacro"; RelationName "ProgrammingUimacro";
          RelationName "RunUimacro"]
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
      { Name = RelationName "SelectorsCycle"
        TargetTable =
         { Name = TableName "SelectorsCycle"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "SelectorConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "EnteringCycle"
                         IsNullable = true }; ForeignKey { Type = Guid
                                                           Name = "ConditionId"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Priority"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CycleTypeId"
                                                            IsNullable = false };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "SelectorCondition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "SelectorsCycle"
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
        KeyType = Byte }] }-CyclesMacro-loader",
                            async ids => 
                            {
                                var data = await dbContext.CyclesMacros
                                    .Where(x => x.CyclesMacro != null && ids.Contains((Guid)x.CyclesMacro))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CyclesMacro!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CyclesMacros);
                    });
            
			
                Field<MacroGraphType, Macro>("Macros")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MacroGraphType>(
                            "{ Name = EntityName "Cycle"
  CorrespondingTable =
   Regular
     { Name = TableName "Cycle"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleId"
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
         ForeignKey { Type = Guid
                      Name = "ProgrammingMacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "DelayMacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PauseMacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "EndMacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ProgrammingUimacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "DelayUimacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PauseUimacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "EndUimacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "RunUimacroId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "AfterFaultRestore"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "BackupRestore"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Pause"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "CycleName"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleHeading"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "CycleSubHeading"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleGroup"
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Target"
                                                      IsNullable = false };
         Navigation { Type = TableName "CycleName"
                      Name = "CycleNameNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CyclesMacro"
                      Name = "CyclesMacros"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Macro"
                      Name = "DelayMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "DelayUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "EndMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "EndUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "PauseMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "PauseUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "ProgrammingMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "ProgrammingUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "RunUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "SelectorsCycle"
                      Name = "SelectorsCycles"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "CycleId"
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
                              IsNullable = false }; { Name = "AfterFaultRestore"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "BackupRestore"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Pause"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "CycleName"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "CycleHeading"
      Type = Primitive Byte
      IsNullable = false }; { Name = "CycleSubHeading"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "CycleGroup"
                                                      Type = Primitive Byte
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
      IsNullable = true }; { Name = "Target"
                             Type = Primitive Byte
                             IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleName"
        TargetTable =
         { Name = TableName "CycleName"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "CycleName1"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleHeading"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleSubHeading"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleGroup"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsForSubcycles"
                         IsNullable = false };
             Navigation { Type = TableName "CycleGroup"
                          Name = "CycleGroupNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleHeading"
                          Name = "CycleHeadingNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleName"
        IsNullable = false
        KeyType = Int };
    OneToMany
      { Name = RelationName "CyclesMacro"
        TargetTable =
         { Name = TableName "CyclesMacro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "MacroId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "PhaseName"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = true };
             Primitive { Type = Int
                         Name = "UserPhaseName"
                         IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Macro"
                          Name = "Macro"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "TimeEstimation"
                          Name = "TimeEstimation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UserPhaseName"
                          Name = "UserPhaseNameNavigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "CyclesMacro"
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "DelayMacro"; RelationName "EndMacro";
          RelationName "PauseMacro"; RelationName "ProgrammingMacro"]
        TargetTable =
         { Name = TableName "Macro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MacroId"
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
             Primitive { Type = Byte
                         Name = "Target"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Comment"
                                                           IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleDelayMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleEndMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CyclePauseMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleProgrammingMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MacrosStatement"
                          Name = "MacrosStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Macro"
        IsNullable = true
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "DelayUimacro"; RelationName "EndUimacro";
          RelationName "PauseUimacro"; RelationName "ProgrammingUimacro";
          RelationName "RunUimacro"]
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
      { Name = RelationName "SelectorsCycle"
        TargetTable =
         { Name = TableName "SelectorsCycle"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "SelectorConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "EnteringCycle"
                         IsNullable = true }; ForeignKey { Type = Guid
                                                           Name = "ConditionId"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Priority"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CycleTypeId"
                                                            IsNullable = false };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "SelectorCondition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "SelectorsCycle"
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
        KeyType = Byte }] }-Macro-loader",
                            async ids => 
                            {
                                Expression<Func<Macro, bool>> expr = x => !ids.Any()
                                    \|\| (x.DelayMacro != null && ids.Contains((Guid)x.DelayMacro))
\|\| (x.EndMacro != null && ids.Contains((Guid)x.EndMacro))
\|\| (x.PauseMacro != null && ids.Contains((Guid)x.PauseMacro))
\|\| (x.ProgrammingMacro != null && ids.Contains((Guid)x.ProgrammingMacro));

                                var data = await dbContext.Macros
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.DelayMacro,
x.EndMacro,
x.PauseMacro,
x.ProgrammingMacro
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.Macros);
                    });
            
			
                Field<UimacroGraphType, Uimacro>("Uimacros")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UimacroGraphType>(
                            "{ Name = EntityName "Cycle"
  CorrespondingTable =
   Regular
     { Name = TableName "Cycle"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleId"
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
         ForeignKey { Type = Guid
                      Name = "ProgrammingMacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "DelayMacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PauseMacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "EndMacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ProgrammingUimacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "DelayUimacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PauseUimacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "EndUimacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "RunUimacroId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "AfterFaultRestore"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "BackupRestore"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Pause"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "CycleName"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleHeading"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "CycleSubHeading"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleGroup"
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Target"
                                                      IsNullable = false };
         Navigation { Type = TableName "CycleName"
                      Name = "CycleNameNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CyclesMacro"
                      Name = "CyclesMacros"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Macro"
                      Name = "DelayMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "DelayUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "EndMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "EndUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "PauseMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "PauseUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "ProgrammingMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "ProgrammingUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "RunUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "SelectorsCycle"
                      Name = "SelectorsCycles"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "CycleId"
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
                              IsNullable = false }; { Name = "AfterFaultRestore"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "BackupRestore"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Pause"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "CycleName"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "CycleHeading"
      Type = Primitive Byte
      IsNullable = false }; { Name = "CycleSubHeading"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "CycleGroup"
                                                      Type = Primitive Byte
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
      IsNullable = true }; { Name = "Target"
                             Type = Primitive Byte
                             IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleName"
        TargetTable =
         { Name = TableName "CycleName"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "CycleName1"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleHeading"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleSubHeading"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleGroup"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsForSubcycles"
                         IsNullable = false };
             Navigation { Type = TableName "CycleGroup"
                          Name = "CycleGroupNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleHeading"
                          Name = "CycleHeadingNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleName"
        IsNullable = false
        KeyType = Int };
    OneToMany
      { Name = RelationName "CyclesMacro"
        TargetTable =
         { Name = TableName "CyclesMacro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "MacroId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "PhaseName"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = true };
             Primitive { Type = Int
                         Name = "UserPhaseName"
                         IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Macro"
                          Name = "Macro"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "TimeEstimation"
                          Name = "TimeEstimation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UserPhaseName"
                          Name = "UserPhaseNameNavigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "CyclesMacro"
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "DelayMacro"; RelationName "EndMacro";
          RelationName "PauseMacro"; RelationName "ProgrammingMacro"]
        TargetTable =
         { Name = TableName "Macro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MacroId"
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
             Primitive { Type = Byte
                         Name = "Target"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Comment"
                                                           IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleDelayMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleEndMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CyclePauseMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleProgrammingMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MacrosStatement"
                          Name = "MacrosStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Macro"
        IsNullable = true
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "DelayUimacro"; RelationName "EndUimacro";
          RelationName "PauseUimacro"; RelationName "ProgrammingUimacro";
          RelationName "RunUimacro"]
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
      { Name = RelationName "SelectorsCycle"
        TargetTable =
         { Name = TableName "SelectorsCycle"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "SelectorConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "EnteringCycle"
                         IsNullable = true }; ForeignKey { Type = Guid
                                                           Name = "ConditionId"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Priority"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CycleTypeId"
                                                            IsNullable = false };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "SelectorCondition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "SelectorsCycle"
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
        KeyType = Byte }] }-Uimacro-loader",
                            async ids => 
                            {
                                Expression<Func<Uimacro, bool>> expr = x => !ids.Any()
                                    \|\| (x.DelayUimacro != null && ids.Contains((Guid)x.DelayUimacro))
\|\| (x.EndUimacro != null && ids.Contains((Guid)x.EndUimacro))
\|\| (x.PauseUimacro != null && ids.Contains((Guid)x.PauseUimacro))
\|\| (x.ProgrammingUimacro != null && ids.Contains((Guid)x.ProgrammingUimacro))
\|\| (x.RunUimacro != null && ids.Contains((Guid)x.RunUimacro));

                                var data = await dbContext.Uimacros
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.DelayUimacro,
x.EndUimacro,
x.PauseUimacro,
x.ProgrammingUimacro,
x.RunUimacro
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.Uimacros);
                    });
            
			
                Field<SelectorsCycleGraphType, SelectorsCycle>("SelectorsCycles")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorsCycleGraphType>>(
                            "{ Name = EntityName "Cycle"
  CorrespondingTable =
   Regular
     { Name = TableName "Cycle"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleId"
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
         ForeignKey { Type = Guid
                      Name = "ProgrammingMacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "DelayMacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PauseMacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "EndMacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ProgrammingUimacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "DelayUimacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PauseUimacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "EndUimacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "RunUimacroId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "AfterFaultRestore"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "BackupRestore"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Pause"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "CycleName"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleHeading"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "CycleSubHeading"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleGroup"
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Target"
                                                      IsNullable = false };
         Navigation { Type = TableName "CycleName"
                      Name = "CycleNameNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CyclesMacro"
                      Name = "CyclesMacros"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Macro"
                      Name = "DelayMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "DelayUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "EndMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "EndUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "PauseMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "PauseUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "ProgrammingMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "ProgrammingUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "RunUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "SelectorsCycle"
                      Name = "SelectorsCycles"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "CycleId"
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
                              IsNullable = false }; { Name = "AfterFaultRestore"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "BackupRestore"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Pause"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "CycleName"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "CycleHeading"
      Type = Primitive Byte
      IsNullable = false }; { Name = "CycleSubHeading"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "CycleGroup"
                                                      Type = Primitive Byte
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
      IsNullable = true }; { Name = "Target"
                             Type = Primitive Byte
                             IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleName"
        TargetTable =
         { Name = TableName "CycleName"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "CycleName1"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleHeading"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleSubHeading"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleGroup"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsForSubcycles"
                         IsNullable = false };
             Navigation { Type = TableName "CycleGroup"
                          Name = "CycleGroupNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleHeading"
                          Name = "CycleHeadingNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleName"
        IsNullable = false
        KeyType = Int };
    OneToMany
      { Name = RelationName "CyclesMacro"
        TargetTable =
         { Name = TableName "CyclesMacro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "MacroId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "PhaseName"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = true };
             Primitive { Type = Int
                         Name = "UserPhaseName"
                         IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Macro"
                          Name = "Macro"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "TimeEstimation"
                          Name = "TimeEstimation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UserPhaseName"
                          Name = "UserPhaseNameNavigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "CyclesMacro"
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "DelayMacro"; RelationName "EndMacro";
          RelationName "PauseMacro"; RelationName "ProgrammingMacro"]
        TargetTable =
         { Name = TableName "Macro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MacroId"
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
             Primitive { Type = Byte
                         Name = "Target"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Comment"
                                                           IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleDelayMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleEndMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CyclePauseMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleProgrammingMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MacrosStatement"
                          Name = "MacrosStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Macro"
        IsNullable = true
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "DelayUimacro"; RelationName "EndUimacro";
          RelationName "PauseUimacro"; RelationName "ProgrammingUimacro";
          RelationName "RunUimacro"]
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
      { Name = RelationName "SelectorsCycle"
        TargetTable =
         { Name = TableName "SelectorsCycle"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "SelectorConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "EnteringCycle"
                         IsNullable = true }; ForeignKey { Type = Guid
                                                           Name = "ConditionId"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Priority"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CycleTypeId"
                                                            IsNullable = false };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "SelectorCondition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "SelectorsCycle"
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
        KeyType = Byte }] }-SelectorsCycle-loader",
                            async ids => 
                            {
                                var data = await dbContext.SelectorsCycles
                                    .Where(x => x.SelectorsCycle != null && ids.Contains((Guid)x.SelectorsCycle))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.SelectorsCycle!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.SelectorsCycles);
                    });
            
			
                Field<TableTargetGraphType, TableTarget>("TableTargets")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                            "{ Name = EntityName "Cycle"
  CorrespondingTable =
   Regular
     { Name = TableName "Cycle"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleId"
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
         ForeignKey { Type = Guid
                      Name = "ProgrammingMacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "DelayMacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PauseMacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "EndMacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ProgrammingUimacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "DelayUimacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "PauseUimacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "EndUimacroId"
                                                        IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "RunUimacroId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "AfterFaultRestore"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "BackupRestore"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Pause"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "CycleName"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleHeading"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "CycleSubHeading"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleGroup"
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Target"
                                                      IsNullable = false };
         Navigation { Type = TableName "CycleName"
                      Name = "CycleNameNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CyclesMacro"
                      Name = "CyclesMacros"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Macro"
                      Name = "DelayMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "DelayUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "EndMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "EndUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "PauseMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "PauseUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "ProgrammingMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "ProgrammingUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "RunUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "SelectorsCycle"
                      Name = "SelectorsCycles"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "CycleId"
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
                              IsNullable = false }; { Name = "AfterFaultRestore"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "BackupRestore"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Pause"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "CycleName"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "CycleHeading"
      Type = Primitive Byte
      IsNullable = false }; { Name = "CycleSubHeading"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "CycleGroup"
                                                      Type = Primitive Byte
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
      IsNullable = true }; { Name = "Target"
                             Type = Primitive Byte
                             IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleName"
        TargetTable =
         { Name = TableName "CycleName"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "CycleName1"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleHeading"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleSubHeading"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleGroup"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsForSubcycles"
                         IsNullable = false };
             Navigation { Type = TableName "CycleGroup"
                          Name = "CycleGroupNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleHeading"
                          Name = "CycleHeadingNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleName"
        IsNullable = false
        KeyType = Int };
    OneToMany
      { Name = RelationName "CyclesMacro"
        TargetTable =
         { Name = TableName "CyclesMacro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "MacroId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "PhaseName"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = true };
             Primitive { Type = Int
                         Name = "UserPhaseName"
                         IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Macro"
                          Name = "Macro"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "TimeEstimation"
                          Name = "TimeEstimation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UserPhaseName"
                          Name = "UserPhaseNameNavigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "CyclesMacro"
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "DelayMacro"; RelationName "EndMacro";
          RelationName "PauseMacro"; RelationName "ProgrammingMacro"]
        TargetTable =
         { Name = TableName "Macro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MacroId"
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
             Primitive { Type = Byte
                         Name = "Target"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Comment"
                                                           IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleDelayMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleEndMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CyclePauseMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleProgrammingMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MacrosStatement"
                          Name = "MacrosStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Macro"
        IsNullable = true
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "DelayUimacro"; RelationName "EndUimacro";
          RelationName "PauseUimacro"; RelationName "ProgrammingUimacro";
          RelationName "RunUimacro"]
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
      { Name = RelationName "SelectorsCycle"
        TargetTable =
         { Name = TableName "SelectorsCycle"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "SelectorConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "EnteringCycle"
                         IsNullable = true }; ForeignKey { Type = Guid
                                                           Name = "ConditionId"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Priority"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CycleTypeId"
                                                            IsNullable = false };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "SelectorCondition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "SelectorsCycle"
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
            