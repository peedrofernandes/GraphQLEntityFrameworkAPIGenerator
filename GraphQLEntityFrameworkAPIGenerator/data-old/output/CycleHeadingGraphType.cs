
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
    public partial class CycleHeadingGraphType : ObjectGraphType<CycleHeading>
    {
        public CycleHeadingGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleHeading1, type: typeof(StringGraphType), nullable: False);
            
                Field<CycleNameGraphType, CycleName>("CycleNames")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, IEnumerable<CycleNameGraphType>>(
                            "{ Name = EntityName "CycleHeading"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleHeading"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "CycleHeading1"
                                                        IsNullable = false };
         Navigation { Type = TableName "CycleName"
                      Name = "CycleNames"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "Id"
              Type = Id Byte
              IsNullable = false }; { Name = "CycleHeading1"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CycleName"
        TargetTable =
         { Name = TableName "CycleName"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "CycleName1"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleHeading"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "CycleSubHeading"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CycleGroup"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsForSubcycles"
                         IsNullable = false };
             Navigation { Type = TableName "CycleGroup"
                          Name = "CycleGroupNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleHeading"
                          Name = "CycleHeadingNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleName"
        KeyType = Int }] }-CycleName-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleNames
                                    .Where(x => x.CycleName != null && ids.Contains((int)x.CycleName))
                                    .Select(x => new
                                    {
                                        Key = (int)x.CycleName!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CycleNames);
                    });
            
        }
    }
}
            