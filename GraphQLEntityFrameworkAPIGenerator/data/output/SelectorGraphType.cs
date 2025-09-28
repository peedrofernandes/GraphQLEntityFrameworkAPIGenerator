
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
    public partial class SelectorGraphType : ObjectGraphType<Selector>
    {
        public SelectorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SelectorId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Code, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Target, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Comment, type: typeof(StringGraphType), nullable: True);
            
                Field<UimacroGraphType, Uimacro>("Uimacros")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UimacroGraphType>(
                            "{ Name = EntityName "Selector"
  CorrespondingTable =
   Regular
     { Name = TableName "Selector"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SelectorId"
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
         ForeignKey { Type = Guid
                      Name = "OffMacroId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UiuserFunctionConfigurationId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "GlobalUimacroId"
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
                      Name = "OffUimacroId"
                      IsNullable = true }; Primitive { Type = Guid
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
         Primitive { Type = String
                     Name = "Comment"
                     IsNullable = true };
         Navigation { Type = TableName "Uimacro"
                      Name = "DelayUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "EndUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "GlobalUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "OffMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "OffUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "PauseUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "ProgrammingUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "SelectorConfigurationsSelector"
                      Name = "SelectorConfigurationsSelectors"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "SelectorsCycle"
                      Name = "SelectorsCycles"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UifunctionConfiguration"
                      Name = "UiuserFunctionConfiguration"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "SelectorId"
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
      IsNullable = true }; { Name = "Target"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "Comment"
                                                     Type = Primitive String
                                                     IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "DelayUimacro"; RelationName "EndUimacro";
          RelationName "GlobalUimacro"; RelationName "OffUimacro";
          RelationName "PauseUimacro"; RelationName "ProgrammingUimacro"]
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
    SingleManyToOne
      { Name = RelationName "Macro"
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
        KeyType = Byte };
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
                                Expression<Func<Uimacro, bool>> expr = x => !ids.Any()
                                    \|\| (x.DelayUimacro != null && ids.Contains((Guid)x.DelayUimacro))
\|\| (x.EndUimacro != null && ids.Contains((Guid)x.EndUimacro))
\|\| (x.GlobalUimacro != null && ids.Contains((Guid)x.GlobalUimacro))
\|\| (x.OffUimacro != null && ids.Contains((Guid)x.OffUimacro))
\|\| (x.PauseUimacro != null && ids.Contains((Guid)x.PauseUimacro))
\|\| (x.ProgrammingUimacro != null && ids.Contains((Guid)x.ProgrammingUimacro));

                                var data = await dbContext.Uimacros
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.DelayUimacro,
x.EndUimacro,
x.GlobalUimacro,
x.OffUimacro,
x.PauseUimacro,
x.ProgrammingUimacro
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.Uimacros);
                    });
            
			
                Field<MacroGraphType, Macro>("Macros")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MacroGraphType>(
                            "{ Name = EntityName "Selector"
  CorrespondingTable =
   Regular
     { Name = TableName "Selector"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SelectorId"
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
         ForeignKey { Type = Guid
                      Name = "OffMacroId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UiuserFunctionConfigurationId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "GlobalUimacroId"
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
                      Name = "OffUimacroId"
                      IsNullable = true }; Primitive { Type = Guid
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
         Primitive { Type = String
                     Name = "Comment"
                     IsNullable = true };
         Navigation { Type = TableName "Uimacro"
                      Name = "DelayUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "EndUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "GlobalUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "OffMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "OffUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "PauseUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "ProgrammingUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "SelectorConfigurationsSelector"
                      Name = "SelectorConfigurationsSelectors"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "SelectorsCycle"
                      Name = "SelectorsCycles"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UifunctionConfiguration"
                      Name = "UiuserFunctionConfiguration"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "SelectorId"
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
      IsNullable = true }; { Name = "Target"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "Comment"
                                                     Type = Primitive String
                                                     IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "DelayUimacro"; RelationName "EndUimacro";
          RelationName "GlobalUimacro"; RelationName "OffUimacro";
          RelationName "PauseUimacro"; RelationName "ProgrammingUimacro"]
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
    SingleManyToOne
      { Name = RelationName "Macro"
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
        KeyType = Byte };
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
        KeyType = Guid }] }-Macro-loader",
                            async ids => 
                            {
                                var data = await dbContext.Macros
                                    .Where(x => x.Macro != null && ids.Contains((Guid)x.Macro))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Macro!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Macro);
                });
            
			
                Field<SelectorConfigurationsSelectorGraphType, SelectorConfigurationsSelector>("SelectorConfigurationsSelectors")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorConfigurationsSelectorGraphType>>(
                            "{ Name = EntityName "Selector"
  CorrespondingTable =
   Regular
     { Name = TableName "Selector"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SelectorId"
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
         ForeignKey { Type = Guid
                      Name = "OffMacroId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UiuserFunctionConfigurationId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "GlobalUimacroId"
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
                      Name = "OffUimacroId"
                      IsNullable = true }; Primitive { Type = Guid
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
         Primitive { Type = String
                     Name = "Comment"
                     IsNullable = true };
         Navigation { Type = TableName "Uimacro"
                      Name = "DelayUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "EndUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "GlobalUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "OffMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "OffUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "PauseUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "ProgrammingUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "SelectorConfigurationsSelector"
                      Name = "SelectorConfigurationsSelectors"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "SelectorsCycle"
                      Name = "SelectorsCycles"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UifunctionConfiguration"
                      Name = "UiuserFunctionConfiguration"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "SelectorId"
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
      IsNullable = true }; { Name = "Target"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "Comment"
                                                     Type = Primitive String
                                                     IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "DelayUimacro"; RelationName "EndUimacro";
          RelationName "GlobalUimacro"; RelationName "OffUimacro";
          RelationName "PauseUimacro"; RelationName "ProgrammingUimacro"]
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
    SingleManyToOne
      { Name = RelationName "Macro"
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
        KeyType = Byte };
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
            
			
                Field<SelectorsCycleGraphType, SelectorsCycle>("SelectorsCycles")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorsCycleGraphType>>(
                            "{ Name = EntityName "Selector"
  CorrespondingTable =
   Regular
     { Name = TableName "Selector"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SelectorId"
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
         ForeignKey { Type = Guid
                      Name = "OffMacroId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UiuserFunctionConfigurationId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "GlobalUimacroId"
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
                      Name = "OffUimacroId"
                      IsNullable = true }; Primitive { Type = Guid
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
         Primitive { Type = String
                     Name = "Comment"
                     IsNullable = true };
         Navigation { Type = TableName "Uimacro"
                      Name = "DelayUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "EndUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "GlobalUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "OffMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "OffUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "PauseUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "ProgrammingUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "SelectorConfigurationsSelector"
                      Name = "SelectorConfigurationsSelectors"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "SelectorsCycle"
                      Name = "SelectorsCycles"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UifunctionConfiguration"
                      Name = "UiuserFunctionConfiguration"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "SelectorId"
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
      IsNullable = true }; { Name = "Target"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "Comment"
                                                     Type = Primitive String
                                                     IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "DelayUimacro"; RelationName "EndUimacro";
          RelationName "GlobalUimacro"; RelationName "OffUimacro";
          RelationName "PauseUimacro"; RelationName "ProgrammingUimacro"]
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
    SingleManyToOne
      { Name = RelationName "Macro"
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
        KeyType = Byte };
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
        KeyType = Guid }] }-SelectorsCycle-loader",
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
                            "{ Name = EntityName "Selector"
  CorrespondingTable =
   Regular
     { Name = TableName "Selector"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SelectorId"
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
         ForeignKey { Type = Guid
                      Name = "OffMacroId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UiuserFunctionConfigurationId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "GlobalUimacroId"
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
                      Name = "OffUimacroId"
                      IsNullable = true }; Primitive { Type = Guid
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
         Primitive { Type = String
                     Name = "Comment"
                     IsNullable = true };
         Navigation { Type = TableName "Uimacro"
                      Name = "DelayUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "EndUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "GlobalUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "OffMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "OffUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "PauseUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "ProgrammingUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "SelectorConfigurationsSelector"
                      Name = "SelectorConfigurationsSelectors"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "SelectorsCycle"
                      Name = "SelectorsCycles"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UifunctionConfiguration"
                      Name = "UiuserFunctionConfiguration"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "SelectorId"
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
      IsNullable = true }; { Name = "Target"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "Comment"
                                                     Type = Primitive String
                                                     IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "DelayUimacro"; RelationName "EndUimacro";
          RelationName "GlobalUimacro"; RelationName "OffUimacro";
          RelationName "PauseUimacro"; RelationName "ProgrammingUimacro"]
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
    SingleManyToOne
      { Name = RelationName "Macro"
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
        KeyType = Byte };
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
        KeyType = Guid }] }-TableTarget-loader",
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
            
			
                Field<UifunctionConfigurationGraphType, UifunctionConfiguration>("UifunctionConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UifunctionConfigurationGraphType>(
                            "{ Name = EntityName "Selector"
  CorrespondingTable =
   Regular
     { Name = TableName "Selector"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SelectorId"
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
         ForeignKey { Type = Guid
                      Name = "OffMacroId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UiuserFunctionConfigurationId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "GlobalUimacroId"
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
                      Name = "OffUimacroId"
                      IsNullable = true }; Primitive { Type = Guid
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
         Primitive { Type = String
                     Name = "Comment"
                     IsNullable = true };
         Navigation { Type = TableName "Uimacro"
                      Name = "DelayUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "EndUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "GlobalUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Macro"
                      Name = "OffMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "OffUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "PauseUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "ProgrammingUimacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "SelectorConfigurationsSelector"
                      Name = "SelectorConfigurationsSelectors"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "SelectorsCycle"
                      Name = "SelectorsCycles"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UifunctionConfiguration"
                      Name = "UiuserFunctionConfiguration"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "SelectorId"
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
      IsNullable = true }; { Name = "Target"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "Comment"
                                                     Type = Primitive String
                                                     IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "DelayUimacro"; RelationName "EndUimacro";
          RelationName "GlobalUimacro"; RelationName "OffUimacro";
          RelationName "PauseUimacro"; RelationName "ProgrammingUimacro"]
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
    SingleManyToOne
      { Name = RelationName "Macro"
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
        KeyType = Byte };
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
            