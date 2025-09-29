
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
    public partial class DebugDataDetailGraphType : ObjectGraphType<DebugDataDetail>
    {
        public DebugDataDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DebugDataDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DataType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DataValue, type: typeof(IdGraphType), nullable: False);
            
                Field<DebugDisplacementConfigurationsDebugDataDetailGraphType, DebugDisplacementConfigurationsDebugDataDetail>("DebugDisplacementConfigurationsDebugDataDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DebugDisplacementConfigurationsDebugDataDetailGraphType>>(
                            "{ Name = EntityName "DebugDataDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "DebugDataDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DebugDataDetailsId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "DataType"
                                                        IsNullable = false };
         Primitive { Type = Int
                     Name = "DataValue"
                     IsNullable = false };
         Navigation
           { Type = TableName "DebugDisplacementConfigurationsDebugDataDetail"
             Name = "DebugDisplacementConfigurationsDebugDataDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "DebugDataDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "DataType"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "DataValue"
                                                      Type = Primitive Int
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "DebugDisplacementConfigurationsDebugDataDetail"
        TargetTable =
         { Name = TableName "DebugDisplacementConfigurationsDebugDataDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebugDisplacementConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "DebugDataDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "DebugDataDetail"
                          Name = "DebugDataDetails"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebugDisplacementConfiguration"
                          Name = "DebugDisplacementConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "DebugDisplacementConfigurationsDebugDataDetail"
        KeyType = Guid }] }-DebugDisplacementConfigurationsDebugDataDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.DebugDisplacementConfigurationsDebugDataDetails
                                    .Where(x => x.DebugDisplacementConfigurationsDebugDataDetail != null && ids.Contains((Guid)x.DebugDisplacementConfigurationsDebugDataDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DebugDisplacementConfigurationsDebugDataDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.DebugDisplacementConfigurationsDebugDataDetails);
                    });
            
        }
    }
}
            