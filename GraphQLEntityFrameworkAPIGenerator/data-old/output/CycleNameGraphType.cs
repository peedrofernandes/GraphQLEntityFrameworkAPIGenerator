
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
    public partial class CycleNameGraphType : ObjectGraphType<CycleName>
    {
        public CycleNameGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(IdGraphType), nullable: False);
			Field(t => t.CycleName1, type: typeof(StringGraphType), nullable: False);
			Field(t => t.CycleHeading, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleSubHeading, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleGroup, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IsForSubcycles, type: typeof(BoolGraphType), nullable: False);
            
                Field<CycleGroupGraphType, CycleGroup>("CycleGroups")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleGroupGraphType>(
                            "{ Name = EntityName "CycleName"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleName"
       Properties =
        [PrimaryKey { Type = Int
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "CycleName1"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleHeading"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "CycleSubHeading"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleGroup"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "Id"
      Type = Id Int
      IsNullable = false }; { Name = "CycleName1"
                              Type = Primitive String
                              IsNullable = false }; { Name = "CycleHeading"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "CycleSubHeading"
      Type = Primitive Byte
      IsNullable = false }; { Name = "CycleGroup"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "IsForSubcycles"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleGroup"
        TargetTable =
         { Name = TableName "CycleGroup"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "CycleGroup1"
                                                            IsNullable = false };
             Navigation { Type = TableName "CycleName"
                          Name = "CycleNames"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleGroup"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "CycleHeading"
        TargetTable =
         { Name = TableName "CycleHeading"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "CycleHeading1"
                         IsNullable = false };
             Navigation { Type = TableName "CycleName"
                          Name = "CycleNames"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleHeading"
        IsNullable = false
        KeyType = Byte };
    OneToMany
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
        KeyType = Guid }] }-CycleGroup-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleGroups
                                    .Where(x => x.CycleGroup != null && ids.Contains((byte)x.CycleGroup))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.CycleGroup!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleGroup);
                });
            
			
                Field<CycleHeadingGraphType, CycleHeading>("CycleHeadings")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleHeadingGraphType>(
                            "{ Name = EntityName "CycleName"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleName"
       Properties =
        [PrimaryKey { Type = Int
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "CycleName1"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleHeading"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "CycleSubHeading"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleGroup"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "Id"
      Type = Id Int
      IsNullable = false }; { Name = "CycleName1"
                              Type = Primitive String
                              IsNullable = false }; { Name = "CycleHeading"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "CycleSubHeading"
      Type = Primitive Byte
      IsNullable = false }; { Name = "CycleGroup"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "IsForSubcycles"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleGroup"
        TargetTable =
         { Name = TableName "CycleGroup"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "CycleGroup1"
                                                            IsNullable = false };
             Navigation { Type = TableName "CycleName"
                          Name = "CycleNames"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleGroup"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "CycleHeading"
        TargetTable =
         { Name = TableName "CycleHeading"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "CycleHeading1"
                         IsNullable = false };
             Navigation { Type = TableName "CycleName"
                          Name = "CycleNames"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleHeading"
        IsNullable = false
        KeyType = Byte };
    OneToMany
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
        KeyType = Guid }] }-CycleHeading-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleHeadings
                                    .Where(x => x.CycleHeading != null && ids.Contains((byte)x.CycleHeading))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.CycleHeading!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleHeading);
                });
            
			
                Field<CycleGraphType, Cycle>("Cycles")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleGraphType>>(
                            "{ Name = EntityName "CycleName"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleName"
       Properties =
        [PrimaryKey { Type = Int
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "CycleName1"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleHeading"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "CycleSubHeading"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "CycleGroup"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "Id"
      Type = Id Int
      IsNullable = false }; { Name = "CycleName1"
                              Type = Primitive String
                              IsNullable = false }; { Name = "CycleHeading"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "CycleSubHeading"
      Type = Primitive Byte
      IsNullable = false }; { Name = "CycleGroup"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "IsForSubcycles"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleGroup"
        TargetTable =
         { Name = TableName "CycleGroup"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "CycleGroup1"
                                                            IsNullable = false };
             Navigation { Type = TableName "CycleName"
                          Name = "CycleNames"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleGroup"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "CycleHeading"
        TargetTable =
         { Name = TableName "CycleHeading"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "CycleHeading1"
                         IsNullable = false };
             Navigation { Type = TableName "CycleName"
                          Name = "CycleNames"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleHeading"
        IsNullable = false
        KeyType = Byte };
    OneToMany
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
        KeyType = Guid }] }-Cycle-loader",
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
                            });

                        return loader.LoadAsync(context.Source.Cycles);
                    });
            
        }
    }
}
            