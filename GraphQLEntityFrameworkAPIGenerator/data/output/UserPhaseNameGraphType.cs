
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
    public partial class UserPhaseNameGraphType : ObjectGraphType<UserPhaseName>
    {
        public UserPhaseNameGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(IdGraphType), nullable: False);
			Field(t => t.UserPhaseName1, type: typeof(StringGraphType), nullable: False);
            
                Field<CyclesMacroGraphType, CyclesMacro>("CyclesMacros")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CyclesMacroGraphType>>(
                            "{ Name = EntityName "UserPhaseName"
  CorrespondingTable =
   Regular
     { Name = TableName "UserPhaseName"
       Properties =
        [PrimaryKey { Type = Int
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "UserPhaseName1"
                                                        IsNullable = false };
         Navigation { Type = TableName "CyclesMacro"
                      Name = "CyclesMacros"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "Id"
              Type = Id Int
              IsNullable = false }; { Name = "UserPhaseName1"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CyclesMacro"
        TargetTable =
         { Name = TableName "CyclesMacro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "MacroId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "PhaseName"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = true };
             Primitive { Type = Int
                         Name = "UserPhaseName"
                         IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Macro"
                          Name = "Macro"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "TimeEstimation"
                          Name = "TimeEstimation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UserPhaseName"
                          Name = "UserPhaseNameNavigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "CyclesMacro"
        KeyType = Guid }] }-CyclesMacro-loader",
                            async ids => 
                            {
                                var data = await dbContext.CyclesMacros
                                    .Where(x => x.CyclesMacro != null && ids.Contains((Guid)x.CyclesMacro))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CyclesMacro!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CyclesMacros);
                    });
            
        }
    }
}
            