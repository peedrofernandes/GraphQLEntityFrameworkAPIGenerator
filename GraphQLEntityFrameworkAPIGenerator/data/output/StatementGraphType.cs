
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
    public partial class StatementGraphType : ObjectGraphType<Statement>
    {
        public StatementGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.StatementId, type: typeof(GuidGraphType), nullable: False);
            
                Field<MacrosStatementGraphType, MacrosStatement>("MacrosStatements")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MacrosStatementGraphType>>(
                            "{ Name = EntityName "Statement"
  CorrespondingTable =
   Regular
     { Name = TableName "Statement"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "StatementId"
                      IsNullable = false }; ForeignKey { Type = Guid
                                                         Name = "LowStatementId"
                                                         IsNullable = true };
         ForeignKey { Type = Int
                      Name = "HighStatementId"
                      IsNullable = false };
         Navigation { Type = TableName "MacrosStatement"
                      Name = "MacrosStatements"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "StatementId"
              Type = Id Guid
              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "MacrosStatement"
        TargetTable =
         { Name = TableName "MacrosStatement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MacroId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
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
        Destination = EntityName "MacrosStatement"
        KeyType = Guid }] }-MacrosStatement-loader",
                            async ids => 
                            {
                                var data = await dbContext.MacrosStatements
                                    .Where(x => x.MacrosStatement != null && ids.Contains((Guid)x.MacrosStatement))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MacrosStatement!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.MacrosStatements);
                    });
            
        }
    }
}
            