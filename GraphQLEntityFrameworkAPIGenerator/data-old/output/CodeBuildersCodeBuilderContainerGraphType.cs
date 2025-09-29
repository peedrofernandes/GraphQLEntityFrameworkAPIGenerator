
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
    public partial class CodeBuildersCodeBuilderContainerGraphType : ObjectGraphType<CodeBuildersCodeBuilderContainer>
    {
        public CodeBuildersCodeBuilderContainerGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CodeBuilderId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CodeBuilderContainerId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(IdGraphType), nullable: False);
            
                Field<CodeBuilderGraphType, CodeBuilder>("CodeBuilders")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CodeBuilderGraphType>(
                            "{ Name = EntityName "CodeBuildersCodeBuilderContainer"
  CorrespondingTable =
   Regular
     { Name = TableName "CodeBuildersCodeBuilderContainer"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CodeBuilderId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "CodeBuilderContainerId"
                      IsNullable = false }; PrimaryKey { Type = Int
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
  Fields =
   [{ Name = "CodeBuilderId"
      Type = Id Guid
      IsNullable = false }; { Name = "CodeBuilderContainerId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Int
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CodeBuilder"
        TargetTable =
         { Name = TableName "CodeBuilder"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CodeBuilderId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "CodeBuilderFileName"
                         IsNullable = false };
             Navigation { Type = TableName "CodeBuildersCodeBuilderContainer"
                          Name = "CodeBuildersCodeBuilderContainers"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CodeBuilder"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
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
        KeyType = Guid }] }-CodeBuilder-loader",
                            async ids => 
                            {
                                var data = await dbContext.CodeBuilders
                                    .Where(x => x.CodeBuilder != null && ids.Contains((Guid)x.CodeBuilder))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CodeBuilder!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CodeBuilder);
                });
            
			
                Field<CodeBuilderContainerGraphType, CodeBuilderContainer>("CodeBuilderContainers")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CodeBuilderContainerGraphType>(
                            "{ Name = EntityName "CodeBuildersCodeBuilderContainer"
  CorrespondingTable =
   Regular
     { Name = TableName "CodeBuildersCodeBuilderContainer"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CodeBuilderId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "CodeBuilderContainerId"
                      IsNullable = false }; PrimaryKey { Type = Int
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
  Fields =
   [{ Name = "CodeBuilderId"
      Type = Id Guid
      IsNullable = false }; { Name = "CodeBuilderContainerId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Int
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CodeBuilder"
        TargetTable =
         { Name = TableName "CodeBuilder"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CodeBuilderId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "CodeBuilderFileName"
                         IsNullable = false };
             Navigation { Type = TableName "CodeBuildersCodeBuilderContainer"
                          Name = "CodeBuildersCodeBuilderContainers"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CodeBuilder"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
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
            