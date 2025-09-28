
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
    public partial class CycleMappingCavityParamGraphType : ObjectGraphType<CycleMappingCavityParam>
    {
        public CycleMappingCavityParamGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleMappingCavityParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ProbeRemovalTimeout, type: typeof(IdGraphType), nullable: False);
            
                Field<CycleMappingAcuTargetGraphType, CycleMappingAcuTarget>("CycleMappingAcuTargets")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingAcuTargetGraphType>>(
                            "{ Name = EntityName "CycleMappingCavityParam"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleMappingCavityParam"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleMappingCavityParamsId"
                      IsNullable = false };
         Primitive { Type = Int
                     Name = "ProbeRemovalTimeout"
                     IsNullable = false };
         Navigation
           { Type = TableName "CycleMappingAcuTarget"
             Name =
              "CycleMappingAcuTargetCycleMappingCavityParamsId1Navigations"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type = TableName "CycleMappingAcuTarget"
             Name =
              "CycleMappingAcuTargetCycleMappingCavityParamsId2Navigations"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type = TableName "CycleMappingAcuTarget"
             Name =
              "CycleMappingAcuTargetCycleMappingCavityParamsId3Navigations"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type = TableName "CycleMappingAcuTarget"
             Name =
              "CycleMappingAcuTargetCycleMappingCavityParamsId4Navigations"
             IsNullable = false
             IsCollection = true }] }
  Fields = [{ Name = "CycleMappingCavityParamsId"
              Type = Id Guid
              IsNullable = false }; { Name = "ProbeRemovalTimeout"
                                      Type = Primitive Int
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CycleMappingAcuTarget"
        TargetTable =
         { Name = TableName "CycleMappingAcuTarget"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingAcuTargetId"
                          IsNullable = false };
             Primitive { Type = Int
                         Name = "NumberOfComparments"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "CycleMappingCavityParamsId1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "CycleMappingCavityParamsId2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "CycleMappingCavityParamsId3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "CycleMappingCavityParamsId4"
                         IsNullable = true };
             Navigation { Type = TableName "CycleMappingCavityParam"
                          Name = "CycleMappingCavityParamsId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingCavityParam"
                          Name = "CycleMappingCavityParamsId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingCavityParam"
                          Name = "CycleMappingCavityParamsId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingCavityParam"
                          Name = "CycleMappingCavityParamsId4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CycleMapping"
                          Name = "CycleMappings"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleMappingAcuTarget"
        KeyType = Guid }] }-CycleMappingAcuTarget-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleMappingAcuTargets
                                    .Where(x => x.CycleMappingAcuTarget != null && ids.Contains((Guid)x.CycleMappingAcuTarget))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleMappingAcuTarget!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CycleMappingAcuTargets);
                    });
            
        }
    }
}
            