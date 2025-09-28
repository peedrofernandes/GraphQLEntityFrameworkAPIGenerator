
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
    public partial class CodeBuilderContainerGraphType : ObjectGraphType<CodeBuilderContainer>
    {
        public CodeBuilderContainerGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CodeBuilderContainerId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TabName, type: typeof(StringGraphType), nullable: True);
            
                Field<CodeBuilderContainersElementGraphType, CodeBuilderContainersElement>("CodeBuilderContainersElements")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CodeBuilderContainersElementGraphType>>(
                            "{ Name = EntityName "CodeBuilderContainer"
  CorrespondingTable =
   Regular
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
  Fields = [{ Name = "CodeBuilderContainerId"
              Type = Id Guid
              IsNullable = false }; { Name = "TabName"
                                      Type = Primitive String
                                      IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "CodeBuilderContainersElement"
        TargetTable =
         { Name = TableName "CodeBuilderContainersElement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CodeBuilderContainerId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "ElementId"
                          IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "Index"
                          IsNullable = false };
             Primitive { Type = Int
                         Name = "StartPosition"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "EndPosition"
                                                           IsNullable = false };
             Navigation { Type = TableName "CodeBuilderContainer"
                          Name = "CodeBuilderContainer"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CodeBuilderContainersElement"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "CodeBuildersCodeBuilderContainer"
        TargetTable =
         { Name = TableName "CodeBuildersCodeBuilderContainer"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CodeBuilderId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CodeBuilderContainerId"
                          IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "CodeBuilder"
                          Name = "CodeBuilder"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CodeBuilderContainer"
                          Name = "CodeBuilderContainer"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CodeBuildersCodeBuilderContainer"
        KeyType = Guid }] }-CodeBuilderContainersElement-loader",
                            async ids => 
                            {
                                var data = await dbContext.CodeBuilderContainersElements
                                    .Where(x => x.CodeBuilderContainersElement != null && ids.Contains((Guid)x.CodeBuilderContainersElement))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CodeBuilderContainersElement!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CodeBuilderContainersElements);
                    });
            
			
                Field<CodeBuildersCodeBuilderContainerGraphType, CodeBuildersCodeBuilderContainer>("CodeBuildersCodeBuilderContainers")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CodeBuildersCodeBuilderContainerGraphType>>(
                            "{ Name = EntityName "CodeBuilderContainer"
  CorrespondingTable =
   Regular
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
  Fields = [{ Name = "CodeBuilderContainerId"
              Type = Id Guid
              IsNullable = false }; { Name = "TabName"
                                      Type = Primitive String
                                      IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "CodeBuilderContainersElement"
        TargetTable =
         { Name = TableName "CodeBuilderContainersElement"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CodeBuilderContainerId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "ElementId"
                          IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "Index"
                          IsNullable = false };
             Primitive { Type = Int
                         Name = "StartPosition"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "EndPosition"
                                                           IsNullable = false };
             Navigation { Type = TableName "CodeBuilderContainer"
                          Name = "CodeBuilderContainer"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CodeBuilderContainersElement"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "CodeBuildersCodeBuilderContainer"
        TargetTable =
         { Name = TableName "CodeBuildersCodeBuilderContainer"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CodeBuilderId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CodeBuilderContainerId"
                          IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "CodeBuilder"
                          Name = "CodeBuilder"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CodeBuilderContainer"
                          Name = "CodeBuilderContainer"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CodeBuildersCodeBuilderContainer"
        KeyType = Guid }] }-CodeBuildersCodeBuilderContainer-loader",
                            async ids => 
                            {
                                var data = await dbContext.CodeBuildersCodeBuilderContainers
                                    .Where(x => x.CodeBuildersCodeBuilderContainer != null && ids.Contains((Guid)x.CodeBuildersCodeBuilderContainer))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CodeBuildersCodeBuilderContainer!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CodeBuildersCodeBuilderContainers);
                    });
            
        }
    }
}
            