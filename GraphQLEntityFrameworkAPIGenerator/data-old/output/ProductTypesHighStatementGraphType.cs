
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
    public partial class ProductTypesHighStatementGraphType : ObjectGraphType<ProductTypesHighStatement>
    {
        public ProductTypesHighStatementGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProductTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.HighStatementId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.OpCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.F0, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.F1, type: typeof(BoolGraphType), nullable: False);
            
                Field<HighStatementGraphType, HighStatement>("HighStatements")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, HighStatementGraphType>(
                            "{ Name = EntityName "ProductTypesHighStatement"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "ProductTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "HighStatementId"
                              Type = Id Int
                              IsNullable = false }; { Name = "OpCode"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "F0"
      Type = Primitive Bool
      IsNullable = false }; { Name = "F1"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "HighStatement"
        TargetTable =
         { Name = TableName "HighStatement"
           Properties =
            [Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Priority"
                                                           IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "HighStatementId"
                          IsNullable = false };
             Navigation { Type = TableName "ProductTypesHighStatement"
                          Name = "ProductTypesHighStatements"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HighStatement"
        IsNullable = false
        KeyType = Int };
    SingleManyToOne
      { Name = RelationName "OpCode"
        TargetTable =
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
        Destination = EntityName "OpCode"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "ProductType"
        TargetTable =
         { Name = TableName "ProductType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ProductTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "ProductTypesHighStatement"
                          Name = "ProductTypesHighStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesTask"
                          Name = "ProductTypesTasks"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesVariable"
                          Name = "ProductTypesVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ProductType"
        IsNullable = false
        KeyType = Byte }] }-HighStatement-loader",
                            async ids => 
                            {
                                var data = await dbContext.HighStatements
                                    .Where(x => x.HighStatement != null && ids.Contains((int)x.HighStatement))
                                    .Select(x => new
                                    {
                                        Key = (int)x.HighStatement!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.HighStatement);
                });
            
			
                Field<OpCodeGraphType, OpCode>("OpCodes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, OpCodeGraphType>(
                            "{ Name = EntityName "ProductTypesHighStatement"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "ProductTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "HighStatementId"
                              Type = Id Int
                              IsNullable = false }; { Name = "OpCode"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "F0"
      Type = Primitive Bool
      IsNullable = false }; { Name = "F1"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "HighStatement"
        TargetTable =
         { Name = TableName "HighStatement"
           Properties =
            [Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Priority"
                                                           IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "HighStatementId"
                          IsNullable = false };
             Navigation { Type = TableName "ProductTypesHighStatement"
                          Name = "ProductTypesHighStatements"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HighStatement"
        IsNullable = false
        KeyType = Int };
    SingleManyToOne
      { Name = RelationName "OpCode"
        TargetTable =
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
        Destination = EntityName "OpCode"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "ProductType"
        TargetTable =
         { Name = TableName "ProductType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ProductTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "ProductTypesHighStatement"
                          Name = "ProductTypesHighStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesTask"
                          Name = "ProductTypesTasks"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesVariable"
                          Name = "ProductTypesVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ProductType"
        IsNullable = false
        KeyType = Byte }] }-OpCode-loader",
                            async ids => 
                            {
                                var data = await dbContext.OpCodes
                                    .Where(x => x.OpCode != null && ids.Contains((byte)x.OpCode))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.OpCode!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.OpCode);
                });
            
			
                Field<ProductTypeGraphType, ProductType>("ProductTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ProductTypeGraphType>(
                            "{ Name = EntityName "ProductTypesHighStatement"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "ProductTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "HighStatementId"
                              Type = Id Int
                              IsNullable = false }; { Name = "OpCode"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "F0"
      Type = Primitive Bool
      IsNullable = false }; { Name = "F1"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "HighStatement"
        TargetTable =
         { Name = TableName "HighStatement"
           Properties =
            [Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Priority"
                                                           IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "HighStatementId"
                          IsNullable = false };
             Navigation { Type = TableName "ProductTypesHighStatement"
                          Name = "ProductTypesHighStatements"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HighStatement"
        IsNullable = false
        KeyType = Int };
    SingleManyToOne
      { Name = RelationName "OpCode"
        TargetTable =
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
        Destination = EntityName "OpCode"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "ProductType"
        TargetTable =
         { Name = TableName "ProductType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ProductTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "ProductTypesHighStatement"
                          Name = "ProductTypesHighStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesTask"
                          Name = "ProductTypesTasks"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesVariable"
                          Name = "ProductTypesVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ProductType"
        IsNullable = false
        KeyType = Byte }] }-ProductType-loader",
                            async ids => 
                            {
                                var data = await dbContext.ProductTypes
                                    .Where(x => x.ProductType != null && ids.Contains((byte)x.ProductType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.ProductType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.ProductType);
                });
            
        }
    }
}
            