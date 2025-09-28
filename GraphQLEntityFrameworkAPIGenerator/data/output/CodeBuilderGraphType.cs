
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
    public partial class CodeBuilderGraphType : ObjectGraphType<CodeBuilder>
    {
        public CodeBuilderGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CodeBuilderId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CodeBuilderFileName, type: typeof(StringGraphType), nullable: False);
            
                Field<CodeBuildersCodeBuilderContainerGraphType, CodeBuildersCodeBuilderContainer>("CodeBuildersCodeBuilderContainers")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CodeBuildersCodeBuilderContainerGraphType>>(
                            "{ Name = EntityName "CodeBuilder"
  CorrespondingTable =
   Regular
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
  Fields = [{ Name = "CodeBuilderId"
              Type = Id Guid
              IsNullable = false }; { Name = "CodeBuilderFileName"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
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
            