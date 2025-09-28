
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
    public partial class OpCodeGraphType : ObjectGraphType<OpCode>
    {
        public OpCodeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.OpCode1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Statement, type: typeof(StringGraphType), nullable: False);
            
                Field<ProductTypesHighStatementGraphType, ProductTypesHighStatement>("ProductTypesHighStatements")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<ProductTypesHighStatementGraphType>>(
                            "{ Name = EntityName "OpCode"
  CorrespondingTable =
   Regular
     { Name = TableName "OpCode"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "OpCode1"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Statement"
                                                        IsNullable = false };
         Navigation { Type = TableName "ProductTypesHighStatement"
                      Name = "ProductTypesHighStatements"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "OpCode1"
              Type = Id Byte
              IsNullable = false }; { Name = "Statement"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "ProductTypesHighStatement"
        TargetTable =
         { Name = TableName "ProductTypesHighStatement"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "HighStatementId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "OpCode"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "F0"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "F1"
                                                           IsNullable = false };
             Navigation { Type = TableName "HighStatement"
                          Name = "HighStatement"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "OpCode"
                          Name = "OpCodeNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ProductType"
                          Name = "ProductType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "ProductTypesHighStatement"
        KeyType = Byte }] }-ProductTypesHighStatement-loader",
                            async ids => 
                            {
                                var data = await dbContext.ProductTypesHighStatements
                                    .Where(x => x.ProductTypesHighStatement != null && ids.Contains((byte)x.ProductTypesHighStatement))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.ProductTypesHighStatement!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.ProductTypesHighStatements);
                    });
            
        }
    }
}
            