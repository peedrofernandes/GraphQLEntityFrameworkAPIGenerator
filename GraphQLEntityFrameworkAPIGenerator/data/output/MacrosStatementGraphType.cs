
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
    public partial class MacrosStatementGraphType : ObjectGraphType<MacrosStatement>
    {
        public MacrosStatementGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MacroId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.StatementId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Step, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.T, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.N, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Comment, type: typeof(StringGraphType), nullable: True);
			Field(t => t.StepLabel, type: typeof(StringGraphType), nullable: True);
            
                Field<MacroGraphType, Macro>("Macros")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MacroGraphType>(
                            "{ Name = EntityName "MacrosStatement"
  CorrespondingTable =
   Regular
     { Name = TableName "MacrosStatement"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MacroId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "StatementId"
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
         Navigation { Type = TableName "Macro"
                      Name = "Macro"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "Statement"
                      Name = "Statement"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "MacroId"
      Type = Id Guid
      IsNullable = false }; { Name = "StatementId"
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
      { Name = RelationName "Statement"
        TargetTable =
         { Name = TableName "Statement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "StatementId"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "LowStatementId"
                          IsNullable = true };
             ForeignKey { Type = Int
                          Name = "HighStatementId"
                          IsNullable = false };
             Navigation { Type = TableName "MacrosStatement"
                          Name = "MacrosStatements"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Statement"
        IsNullable = false
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
            
			
                Field<StatementGraphType, Statement>("Statements")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, StatementGraphType>(
                            "{ Name = EntityName "MacrosStatement"
  CorrespondingTable =
   Regular
     { Name = TableName "MacrosStatement"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MacroId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "StatementId"
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
         Navigation { Type = TableName "Macro"
                      Name = "Macro"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "Statement"
                      Name = "Statement"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "MacroId"
      Type = Id Guid
      IsNullable = false }; { Name = "StatementId"
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
      { Name = RelationName "Statement"
        TargetTable =
         { Name = TableName "Statement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "StatementId"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "LowStatementId"
                          IsNullable = true };
             ForeignKey { Type = Int
                          Name = "HighStatementId"
                          IsNullable = false };
             Navigation { Type = TableName "MacrosStatement"
                          Name = "MacrosStatements"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Statement"
        IsNullable = false
        KeyType = Guid }] }-Statement-loader",
                            async ids => 
                            {
                                var data = await dbContext.Statements
                                    .Where(x => x.Statement != null && ids.Contains((Guid)x.Statement))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Statement!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Statement);
                });
            
        }
    }
}
            