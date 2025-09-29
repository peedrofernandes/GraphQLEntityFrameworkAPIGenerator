
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
    public partial class UimacrosUistatementGraphType : ObjectGraphType<UimacrosUistatement>
    {
        public UimacrosUistatementGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UimacroId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UistatementId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Step, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.T, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.N, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Comment, type: typeof(StringGraphType), nullable: True);
			Field(t => t.StepLabel, type: typeof(StringGraphType), nullable: True);
            
                Field<UimacroGraphType, Uimacro>("Uimacros")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UimacroGraphType>(
                            "{ Name = EntityName "UimacrosUistatement"
  CorrespondingTable =
   Regular
     { Name = TableName "UimacrosUistatement"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UimacroId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "UistatementId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Step"
                                                        IsNullable = false };
         Primitive { Type = Bool
                     Name = "T"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "N"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Comment"
                     IsNullable = true }; Primitive { Type = String
                                                      Name = "StepLabel"
                                                      IsNullable = true };
         Navigation { Type = TableName "Uimacro"
                      Name = "Uimacro"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "Uistatement"
                      Name = "Uistatement"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UimacroId"
      Type = Id Guid
      IsNullable = false }; { Name = "UistatementId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "Step"
      Type = Primitive Byte
      IsNullable = false }; { Name = "T"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "N"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Comment"
      Type = Primitive String
      IsNullable = true }; { Name = "StepLabel"
                             Type = Primitive String
                             IsNullable = true }]
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Uistatement"
        TargetTable =
         { Name = TableName "Uistatement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UistatementId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "OpCode"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "F0"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "F1"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "LowStatementId"
                          IsNullable = true };
             Navigation { Type = TableName "UimacrosUistatement"
                          Name = "UimacrosUistatements"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uistatement"
        IsNullable = false
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
            
			
                Field<UistatementGraphType, Uistatement>("Uistatements")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UistatementGraphType>(
                            "{ Name = EntityName "UimacrosUistatement"
  CorrespondingTable =
   Regular
     { Name = TableName "UimacrosUistatement"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UimacroId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "UistatementId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Step"
                                                        IsNullable = false };
         Primitive { Type = Bool
                     Name = "T"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "N"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Comment"
                     IsNullable = true }; Primitive { Type = String
                                                      Name = "StepLabel"
                                                      IsNullable = true };
         Navigation { Type = TableName "Uimacro"
                      Name = "Uimacro"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "Uistatement"
                      Name = "Uistatement"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UimacroId"
      Type = Id Guid
      IsNullable = false }; { Name = "UistatementId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "Step"
      Type = Primitive Byte
      IsNullable = false }; { Name = "T"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "N"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Comment"
      Type = Primitive String
      IsNullable = true }; { Name = "StepLabel"
                             Type = Primitive String
                             IsNullable = true }]
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
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Uistatement"
        TargetTable =
         { Name = TableName "Uistatement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UistatementId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "OpCode"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "F0"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "F1"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "LowStatementId"
                          IsNullable = true };
             Navigation { Type = TableName "UimacrosUistatement"
                          Name = "UimacrosUistatements"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uistatement"
        IsNullable = false
        KeyType = Guid }] }-Uistatement-loader",
                            async ids => 
                            {
                                var data = await dbContext.Uistatements
                                    .Where(x => x.Uistatement != null && ids.Contains((Guid)x.Uistatement))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Uistatement!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Uistatement);
                });
            
        }
    }
}
            