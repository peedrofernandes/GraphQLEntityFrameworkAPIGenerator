
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
    public partial class CyclesMacroGraphType : ObjectGraphType<CyclesMacro>
    {
        public CyclesMacroGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MacroId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PhaseName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.UserPhaseName, type: typeof(IdGraphType), nullable: True);
            
                Field<CycleGraphType, Cycle>("Cycles")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleGraphType>(
                            "{ Name = EntityName "CyclesMacro"
  CorrespondingTable =
   Regular
     { Name = TableName "CyclesMacro"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleId"
                      IsNullable = false }; PrimaryKey { Type = Guid
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
                      IsNullable = true }; Primitive { Type = Int
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
  Fields =
   [{ Name = "CycleId"
      Type = Id Guid
      IsNullable = false }; { Name = "MacroId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "PhaseName"
      Type = Primitive String
      IsNullable = false }; { Name = "UserPhaseName"
                              Type = Primitive Int
                              IsNullable = true }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Cycle"
        TargetTable =
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
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DelayMacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PauseMacroId"
                          IsNullable = true }; ForeignKey { Type = Guid
                                                            Name = "EndMacroId"
                                                            IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ProgrammingUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DelayUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PauseUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "EndUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "RunUimacroId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "AfterFaultRestore"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "BackupRestore"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Pause"
                                                           IsNullable = false };
             Primitive { Type = Int
                         Name = "CycleName"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleHeading"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleSubHeading"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleGroup"
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
        Destination = EntityName "Cycle"
        IsNullable = false
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "TimeEstimation"
        TargetTable =
         { Name = TableName "TimeEstimation"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Time"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "HasModifiers"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseDirectModifier"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifierId"
                                                            IsNullable = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "TimeEstimation"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
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
    SingleManyToOne
      { Name = RelationName "UserPhaseName"
        TargetTable =
         { Name = TableName "UserPhaseName"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "UserPhaseName1"
                         IsNullable = false };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UserPhaseName"
        IsNullable = true
        KeyType = Int }] }-Cycle-loader",
                            async ids => 
                            {
                                var data = await dbContext.Cycles
                                    .Where(x => x.Cycle != null && ids.Contains((Guid)x.Cycle))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Cycle!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Cycle);
                });
            
			
                Field<MacroGraphType, Macro>("Macros")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MacroGraphType>(
                            "{ Name = EntityName "CyclesMacro"
  CorrespondingTable =
   Regular
     { Name = TableName "CyclesMacro"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleId"
                      IsNullable = false }; PrimaryKey { Type = Guid
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
                      IsNullable = true }; Primitive { Type = Int
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
  Fields =
   [{ Name = "CycleId"
      Type = Id Guid
      IsNullable = false }; { Name = "MacroId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "PhaseName"
      Type = Primitive String
      IsNullable = false }; { Name = "UserPhaseName"
                              Type = Primitive Int
                              IsNullable = true }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Cycle"
        TargetTable =
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
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DelayMacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PauseMacroId"
                          IsNullable = true }; ForeignKey { Type = Guid
                                                            Name = "EndMacroId"
                                                            IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ProgrammingUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DelayUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PauseUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "EndUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "RunUimacroId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "AfterFaultRestore"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "BackupRestore"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Pause"
                                                           IsNullable = false };
             Primitive { Type = Int
                         Name = "CycleName"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleHeading"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleSubHeading"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleGroup"
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
        Destination = EntityName "Cycle"
        IsNullable = false
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "TimeEstimation"
        TargetTable =
         { Name = TableName "TimeEstimation"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Time"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "HasModifiers"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseDirectModifier"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifierId"
                                                            IsNullable = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "TimeEstimation"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
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
    SingleManyToOne
      { Name = RelationName "UserPhaseName"
        TargetTable =
         { Name = TableName "UserPhaseName"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "UserPhaseName1"
                         IsNullable = false };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UserPhaseName"
        IsNullable = true
        KeyType = Int }] }-Macro-loader",
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
            
			
                Field<TimeEstimationGraphType, TimeEstimation>("TimeEstimations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, TimeEstimationGraphType>(
                            "{ Name = EntityName "CyclesMacro"
  CorrespondingTable =
   Regular
     { Name = TableName "CyclesMacro"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleId"
                      IsNullable = false }; PrimaryKey { Type = Guid
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
                      IsNullable = true }; Primitive { Type = Int
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
  Fields =
   [{ Name = "CycleId"
      Type = Id Guid
      IsNullable = false }; { Name = "MacroId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "PhaseName"
      Type = Primitive String
      IsNullable = false }; { Name = "UserPhaseName"
                              Type = Primitive Int
                              IsNullable = true }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Cycle"
        TargetTable =
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
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DelayMacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PauseMacroId"
                          IsNullable = true }; ForeignKey { Type = Guid
                                                            Name = "EndMacroId"
                                                            IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ProgrammingUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DelayUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PauseUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "EndUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "RunUimacroId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "AfterFaultRestore"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "BackupRestore"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Pause"
                                                           IsNullable = false };
             Primitive { Type = Int
                         Name = "CycleName"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleHeading"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleSubHeading"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleGroup"
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
        Destination = EntityName "Cycle"
        IsNullable = false
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "TimeEstimation"
        TargetTable =
         { Name = TableName "TimeEstimation"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Time"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "HasModifiers"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseDirectModifier"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifierId"
                                                            IsNullable = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "TimeEstimation"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
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
    SingleManyToOne
      { Name = RelationName "UserPhaseName"
        TargetTable =
         { Name = TableName "UserPhaseName"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "UserPhaseName1"
                         IsNullable = false };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UserPhaseName"
        IsNullable = true
        KeyType = Int }] }-TimeEstimation-loader",
                            async ids => 
                            {
                                var data = await dbContext.TimeEstimations
                                    .Where(x => x.TimeEstimation != null && ids.Contains((Guid)x.TimeEstimation))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.TimeEstimation!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.TimeEstimation);
                });
            
			
                Field<UimacroGraphType, Uimacro>("Uimacros")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UimacroGraphType>(
                            "{ Name = EntityName "CyclesMacro"
  CorrespondingTable =
   Regular
     { Name = TableName "CyclesMacro"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleId"
                      IsNullable = false }; PrimaryKey { Type = Guid
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
                      IsNullable = true }; Primitive { Type = Int
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
  Fields =
   [{ Name = "CycleId"
      Type = Id Guid
      IsNullable = false }; { Name = "MacroId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "PhaseName"
      Type = Primitive String
      IsNullable = false }; { Name = "UserPhaseName"
                              Type = Primitive Int
                              IsNullable = true }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Cycle"
        TargetTable =
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
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DelayMacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PauseMacroId"
                          IsNullable = true }; ForeignKey { Type = Guid
                                                            Name = "EndMacroId"
                                                            IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ProgrammingUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DelayUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PauseUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "EndUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "RunUimacroId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "AfterFaultRestore"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "BackupRestore"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Pause"
                                                           IsNullable = false };
             Primitive { Type = Int
                         Name = "CycleName"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleHeading"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleSubHeading"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleGroup"
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
        Destination = EntityName "Cycle"
        IsNullable = false
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "TimeEstimation"
        TargetTable =
         { Name = TableName "TimeEstimation"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Time"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "HasModifiers"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseDirectModifier"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifierId"
                                                            IsNullable = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "TimeEstimation"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
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
    SingleManyToOne
      { Name = RelationName "UserPhaseName"
        TargetTable =
         { Name = TableName "UserPhaseName"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "UserPhaseName1"
                         IsNullable = false };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UserPhaseName"
        IsNullable = true
        KeyType = Int }] }-Uimacro-loader",
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
            
			
                Field<UserPhaseNameGraphType, UserPhaseName>("UserPhaseNames")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, UserPhaseNameGraphType>(
                            "{ Name = EntityName "CyclesMacro"
  CorrespondingTable =
   Regular
     { Name = TableName "CyclesMacro"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleId"
                      IsNullable = false }; PrimaryKey { Type = Guid
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
                      IsNullable = true }; Primitive { Type = Int
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
  Fields =
   [{ Name = "CycleId"
      Type = Id Guid
      IsNullable = false }; { Name = "MacroId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "PhaseName"
      Type = Primitive String
      IsNullable = false }; { Name = "UserPhaseName"
                              Type = Primitive Int
                              IsNullable = true }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Cycle"
        TargetTable =
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
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DelayMacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PauseMacroId"
                          IsNullable = true }; ForeignKey { Type = Guid
                                                            Name = "EndMacroId"
                                                            IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ProgrammingUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DelayUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PauseUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "EndUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "RunUimacroId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "AfterFaultRestore"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "BackupRestore"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Pause"
                                                           IsNullable = false };
             Primitive { Type = Int
                         Name = "CycleName"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleHeading"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleSubHeading"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleGroup"
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
        Destination = EntityName "Cycle"
        IsNullable = false
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "TimeEstimation"
        TargetTable =
         { Name = TableName "TimeEstimation"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Time"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "HasModifiers"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseDirectModifier"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifierId"
                                                            IsNullable = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "TimeEstimation"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
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
    SingleManyToOne
      { Name = RelationName "UserPhaseName"
        TargetTable =
         { Name = TableName "UserPhaseName"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "UserPhaseName1"
                         IsNullable = false };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UserPhaseName"
        IsNullable = true
        KeyType = Int }] }-UserPhaseName-loader",
                            async ids => 
                            {
                                var data = await dbContext.UserPhaseNames
                                    .Where(x => x.UserPhaseName != null && ids.Contains((int)x.UserPhaseName))
                                    .Select(x => new
                                    {
                                        Key = (int)x.UserPhaseName!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UserPhaseName);
                });
            
        }
    }
}
            