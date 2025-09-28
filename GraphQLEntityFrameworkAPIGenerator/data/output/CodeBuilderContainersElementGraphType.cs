
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
    public partial class CodeBuilderContainersElementGraphType : ObjectGraphType<CodeBuilderContainersElement>
    {
        public CodeBuilderContainersElementGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CodeBuilderContainerId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ElementId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(IdGraphType), nullable: False);
			Field(t => t.StartPosition, type: typeof(IdGraphType), nullable: False);
			Field(t => t.EndPosition, type: typeof(IdGraphType), nullable: False);
            
                Field<CodeBuilderContainerGraphType, CodeBuilderContainer>("CodeBuilderContainers")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CodeBuilderContainerGraphType>(
                            "{ Name = EntityName "CodeBuilderContainersElement"
  CorrespondingTable =
   Regular
     { Name = TableName "CodeBuilderContainersElement"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CodeBuilderContainerId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "ElementId"
                                                         IsNullable = false };
         PrimaryKey { Type = Int
                      Name = "Index"
                      IsNullable = false }; Primitive { Type = Int
                                                        Name = "StartPosition"
                                                        IsNullable = false };
         Primitive { Type = Int
                     Name = "EndPosition"
                     IsNullable = false };
         Navigation { Type = TableName "CodeBuilderContainer"
                      Name = "CodeBuilderContainer"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "CodeBuilderContainerId"
      Type = Id Guid
      IsNullable = false }; { Name = "ElementId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Int
                                                      IsNullable = false };
    { Name = "StartPosition"
      Type = Primitive Int
      IsNullable = false }; { Name = "EndPosition"
                              Type = Primitive Int
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CodeBuilderContainer"
        TargetTable =
         { Name = TableName "CodeBuilderContainer"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CodeBuilderContainerId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "TabName"
                                                            IsNullable = true };
             Navigation { Type = TableName "CodeBuilderContainersElement"
                          Name = "CodeBuilderContainersElements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CodeBuildersCodeBuilderContainer"
                          Name = "CodeBuildersCodeBuilderContainers"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CodeBuilderContainer"
        IsNullable = false
        KeyType = Guid }] }-CodeBuilderContainer-loader",
                            async ids => 
                            {
                                var data = await dbContext.CodeBuilderContainers
                                    .Where(x => x.CodeBuilderContainer != null && ids.Contains((Guid)x.CodeBuilderContainer))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CodeBuilderContainer!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CodeBuilderContainer);
                });
            
        }
    }
}
            