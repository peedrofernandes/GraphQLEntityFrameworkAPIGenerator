
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
    public partial class UistatementGraphType : ObjectGraphType<Uistatement>
    {
        public UistatementGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UistatementId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.OpCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.F0, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.F1, type: typeof(BoolGraphType), nullable: False);
            
                Field<UimacrosUistatementGraphType, UimacrosUistatement>("UimacrosUistatements")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UimacrosUistatementGraphType>>(
                            "{ Name = EntityName "Uistatement"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "UistatementId"
      Type = Id Guid
      IsNullable = false }; { Name = "OpCode"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "F0"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "F1"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UimacrosUistatement"
        TargetTable =
         { Name = TableName "UimacrosUistatement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UimacroId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
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
        Destination = EntityName "UimacrosUistatement"
        KeyType = Guid }] }-UimacrosUistatement-loader",
                            async ids => 
                            {
                                var data = await dbContext.UimacrosUistatements
                                    .Where(x => x.UimacrosUistatement != null && ids.Contains((Guid)x.UimacrosUistatement))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UimacrosUistatement!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UimacrosUistatements);
                    });
            
        }
    }
}
            