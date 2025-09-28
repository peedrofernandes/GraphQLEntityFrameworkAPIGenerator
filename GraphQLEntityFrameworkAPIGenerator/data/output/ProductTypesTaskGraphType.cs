
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
    public partial class ProductTypesTaskGraphType : ObjectGraphType<ProductTypesTask>
    {
        public ProductTypesTaskGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProductTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TaskId, type: typeof(IdGraphType), nullable: False);
            
                Field<ProductTypeGraphType, ProductType>("ProductTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ProductTypeGraphType>(
                            "{ Name = EntityName "ProductTypesTask"
  CorrespondingTable =
   Regular
     { Name = TableName "ProductTypesTask"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "ProductTypeId"
                      IsNullable = false }; PrimaryKey { Type = Int
                                                         Name = "TaskId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "ProductTypeTaskId"
                      IsNullable = false };
         Navigation { Type = TableName "ProductType"
                      Name = "ProductType"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "Task"
                      Name = "Task"
                      IsNullable = false
                      IsCollection = false }] }
  Fields = [{ Name = "ProductTypeId"
              Type = Id Byte
              IsNullable = false }; { Name = "TaskId"
                                      Type = Id Int
                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "Task"
        TargetTable =
         { Name = TableName "Task"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Task1"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "TaskParametersNeeded"
                         IsNullable = false };
             Navigation { Type = TableName "ProductTypesTask"
                          Name = "ProductTypesTasks"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Task"
        IsNullable = false
        KeyType = Int }] }-ProductType-loader",
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
            
			
                Field<TaskGraphType, Task>("Tasks")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, TaskGraphType>(
                            "{ Name = EntityName "ProductTypesTask"
  CorrespondingTable =
   Regular
     { Name = TableName "ProductTypesTask"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "ProductTypeId"
                      IsNullable = false }; PrimaryKey { Type = Int
                                                         Name = "TaskId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "ProductTypeTaskId"
                      IsNullable = false };
         Navigation { Type = TableName "ProductType"
                      Name = "ProductType"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "Task"
                      Name = "Task"
                      IsNullable = false
                      IsCollection = false }] }
  Fields = [{ Name = "ProductTypeId"
              Type = Id Byte
              IsNullable = false }; { Name = "TaskId"
                                      Type = Id Int
                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "Task"
        TargetTable =
         { Name = TableName "Task"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Task1"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "TaskParametersNeeded"
                         IsNullable = false };
             Navigation { Type = TableName "ProductTypesTask"
                          Name = "ProductTypesTasks"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Task"
        IsNullable = false
        KeyType = Int }] }-Task-loader",
                            async ids => 
                            {
                                var data = await dbContext.Tasks
                                    .Where(x => x.Task != null && ids.Contains((int)x.Task))
                                    .Select(x => new
                                    {
                                        Key = (int)x.Task!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Task);
                });
            
        }
    }
}
            