
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
    public partial class UiopCodeGraphType : ObjectGraphType<UiopCode>
    {
        public UiopCodeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.OpCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Statement, type: typeof(StringGraphType), nullable: False);
            
                Field<UihighStatementGraphType, UihighStatement>("UihighStatements")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<UihighStatementGraphType>>(
                            "{ Name = EntityName "UiopCode"
  CorrespondingTable =
   Regular
     { Name = TableName "UiopCode"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "OpCode"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Statement"
                                                        IsNullable = false };
         Navigation { Type = TableName "UihighStatement"
                      Name = "UihighStatements"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "OpCode"
              Type = Id Byte
              IsNullable = false }; { Name = "Statement"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UihighStatement"
        TargetTable =
         { Name = TableName "UihighStatement"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "OpCode"
                          IsNullable = false };
             PrimaryKey { Type = Bool
                          Name = "F0"
                          IsNullable = false };
             PrimaryKey { Type = Bool
                          Name = "F1"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Priority"
                         IsNullable = false };
             Navigation { Type = TableName "UiopCode"
                          Name = "OpCodeNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UihighStatement"
        KeyType = Byte }] }-UihighStatement-loader",
                            async ids => 
                            {
                                var data = await dbContext.UihighStatements
                                    .Where(x => x.UihighStatement != null && ids.Contains((byte)x.UihighStatement))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.UihighStatement!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UihighStatements);
                    });
            
        }
    }
}
            