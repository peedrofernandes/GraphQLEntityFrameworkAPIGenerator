
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
    public partial class TaskGraphType : ObjectGraphType<Task>
    {
        public TaskGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Task1, type: typeof(StringGraphType), nullable: False);
			Field(t => t.TaskParametersNeeded, type: typeof(BoolGraphType), nullable: False);
            
                Field<ProductTypesTaskGraphType, ProductTypesTask>("ProductTypesTasks")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<ProductTypesTaskGraphType>>(
                            "{ Name = EntityName "Task"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "Id"
      Type = Id Int
      IsNullable = false }; { Name = "Task1"
                              Type = Primitive String
                              IsNullable = false };
    { Name = "TaskParametersNeeded"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "ProductTypesTask"
        TargetTable =
         { Name = TableName "ProductTypesTask"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             PrimaryKey { Type = Int
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
        Destination = EntityName "ProductTypesTask"
        KeyType = Byte }] }-ProductTypesTask-loader",
                            async ids => 
                            {
                                var data = await dbContext.ProductTypesTasks
                                    .Where(x => x.ProductTypesTask != null && ids.Contains((byte)x.ProductTypesTask))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.ProductTypesTask!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.ProductTypesTasks);
                    });
            
        }
    }
}
            