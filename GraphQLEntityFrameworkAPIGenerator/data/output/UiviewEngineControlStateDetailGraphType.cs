
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
    public partial class UiviewEngineControlStateDetailGraphType : ObjectGraphType<UiviewEngineControlStateDetail>
    {
        public UiviewEngineControlStateDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiviewEngineControlStateDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<UimacroGraphType, Uimacro>("Uimacros")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UimacroGraphType>(
                            "{ Name = EntityName "UiviewEngineControlStateDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiviewEngineControlStateDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiviewEngineControlStateDetailsId"
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
                     IsNullable = true }; ForeignKey { Type = Guid
                                                       Name = "OnEntryMacroId"
                                                       IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "DoMacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "OnExitMacroId"
                                                        IsNullable = true };
         Navigation { Type = TableName "Uimacro"
                      Name = "DoMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "OnEntryMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "OnExitMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName
                "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
             Name =
              "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "UiviewEngineControlStateDetailsId"
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
                                                      IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "DoMacro"; RelationName "OnEntryMacro";
          RelationName "OnExitMacro"]
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
      { Name =
         RelationName
           "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
        TargetTable =
         { Name =
            TableName
              "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiviewEngineControlStateConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiviewEngineControlStateDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "UiviewEngineControlStateConfiguration"
                 Name = "UiviewEngineControlStateConfigurations"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "UiviewEngineControlStateDetail"
                          Name = "UiviewEngineControlStateDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
        KeyType = Guid }] }-Uimacro-loader",
                            async ids => 
                            {
                                Expression<Func<Uimacro, bool>> expr = x => !ids.Any()
                                    \|\| (x.DoMacro != null && ids.Contains((Guid)x.DoMacro))
\|\| (x.OnEntryMacro != null && ids.Contains((Guid)x.OnEntryMacro))
\|\| (x.OnExitMacro != null && ids.Contains((Guid)x.OnExitMacro));

                                var data = await dbContext.Uimacros
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.DoMacro,
x.OnEntryMacro,
x.OnExitMacro
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.Uimacros);
                    });
            
			
                Field<UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetailGraphType, UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail>("UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetailGraphType>>(
                            "{ Name = EntityName "UiviewEngineControlStateDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiviewEngineControlStateDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiviewEngineControlStateDetailsId"
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
                     IsNullable = true }; ForeignKey { Type = Guid
                                                       Name = "OnEntryMacroId"
                                                       IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "DoMacroId"
                      IsNullable = true }; ForeignKey { Type = Guid
                                                        Name = "OnExitMacroId"
                                                        IsNullable = true };
         Navigation { Type = TableName "Uimacro"
                      Name = "DoMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "OnEntryMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uimacro"
                      Name = "OnExitMacro"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type =
              TableName
                "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
             Name =
              "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "UiviewEngineControlStateDetailsId"
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
                                                      IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "DoMacro"; RelationName "OnEntryMacro";
          RelationName "OnExitMacro"]
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
      { Name =
         RelationName
           "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
        TargetTable =
         { Name =
            TableName
              "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiviewEngineControlStateConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiviewEngineControlStateDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "UiviewEngineControlStateConfiguration"
                 Name = "UiviewEngineControlStateConfigurations"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "UiviewEngineControlStateDetail"
                          Name = "UiviewEngineControlStateDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail"
        KeyType = Guid }] }-UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails
                                    .Where(x => x.UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail != null && ids.Contains((Guid)x.UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails);
                    });
            
        }
    }
}
            