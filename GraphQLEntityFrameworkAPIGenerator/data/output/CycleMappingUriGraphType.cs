
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
    public partial class CycleMappingUriGraphType : ObjectGraphType<CycleMappingUri>
    {
        public CycleMappingUriGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UriTreeId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfTrees, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SetCycleTreeLevels1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.SetCycleTreeLevels2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.SetCycleTreeLevels3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.SetCycleTreeLevels4, type: typeof(ByteGraphType), nullable: True);
            
                Field<CycleMappingCycleOptionsConfigurationGraphType, CycleMappingCycleOptionsConfiguration>("CycleMappingCycleOptionsConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingCycleOptionsConfigurationGraphType>>(
                            "{ Name = EntityName "CycleMappingUri"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleMappingUri"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UriTreeId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumberOfTrees"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "SetCycleTreeLevels1"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "SetCycleTreeLevels2"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "SetCycleTreeLevels3"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "SetCycleTreeLevels4"
                     IsNullable = true };
         Navigation { Type = TableName "CycleMappingCycleOptionsConfiguration"
                      Name = "CycleMappingCycleOptionsConfigurations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "UriTreeId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumberOfTrees"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "SetCycleTreeLevels1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "SetCycleTreeLevels2"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "SetCycleTreeLevels3"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "SetCycleTreeLevels4"
      Type = Primitive Byte
      IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "CycleMappingCycleOptionsConfiguration"
        TargetTable =
         { Name = TableName "CycleMappingCycleOptionsConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleOptionsConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "CycleName"
                                                            IsNullable = true };
             Primitive { Type = String
                         Name = "HmiCycleName"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "ConnectivityCycleEnumeration0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Compartment0"
                                                          IsNullable = false };
             Primitive { Type = Long
                         Name = "ConnectivityCycleKey0"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels"
                         IsNullable = true }; ForeignKey { Type = Guid
                                                           Name = "UriTreeId"
                                                           IsNullable = true };
             Navigation { Type = TableName "CycleMapping"
                          Name = "CycleMapping"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleOptionsConfiguration"
                          Name = "CycleOptionsConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingUri"
                          Name = "UriTree"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "CycleMappingCycleOptionsConfiguration"
        KeyType = Guid }] }-CycleMappingCycleOptionsConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleMappingCycleOptionsConfigurations
                                    .Where(x => x.CycleMappingCycleOptionsConfiguration != null && ids.Contains((Guid)x.CycleMappingCycleOptionsConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleMappingCycleOptionsConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CycleMappingCycleOptionsConfigurations);
                    });
            
        }
    }
}
            