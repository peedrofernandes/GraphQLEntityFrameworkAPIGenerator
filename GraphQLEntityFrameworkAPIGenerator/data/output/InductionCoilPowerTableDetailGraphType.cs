
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
    public partial class InductionCoilPowerTableDetailGraphType : ObjectGraphType<InductionCoilPowerTableDetail>
    {
        public InductionCoilPowerTableDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionCoilPowerTableDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Wattage, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Timeout, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ReturnLevel, type: typeof(ByteGraphType), nullable: False);
            
                Field<InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetailGraphType, InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail>("InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetailGraphType>>(
                            "{ Name = EntityName "InductionCoilPowerTableDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionCoilPowerTableDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionCoilPowerTableDetailId"
                      IsNullable = false }; Primitive { Type = Int
                                                        Name = "Wattage"
                                                        IsNullable = false };
         Primitive { Type = Int
                     Name = "Timeout"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ReturnLevel"
                                                       IsNullable = false };
         Navigation
           { Type =
              TableName
                "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
             Name =
              "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "InductionCoilPowerTableDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "Wattage"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "Timeout"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "ReturnLevel"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
        TargetTable =
         { Name =
            TableName
              "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "InductionCoilPowerTableConfiguration"
                 Name = "InductionCoilPowerTableConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "InductionCoilPowerTableDetail"
                          Name = "InductionCoilPowerTableDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
        KeyType = Guid }] }-InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails
                                    .Where(x => x.InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail != null && ids.Contains((Guid)x.InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails);
                    });
            
        }
    }
}
            