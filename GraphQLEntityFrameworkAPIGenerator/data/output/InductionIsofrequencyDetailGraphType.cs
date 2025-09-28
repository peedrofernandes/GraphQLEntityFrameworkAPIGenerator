
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
    public partial class InductionIsofrequencyDetailGraphType : ObjectGraphType<InductionIsofrequencyDetail>
    {
        public InductionIsofrequencyDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionIsofreqDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfCoils, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AdjacentCoil0, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.AdjacentCoil1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.AdjacentCoil2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.AdjacentCoil3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.AdjacentCoil4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.AdjacentCoil5, type: typeof(ByteGraphType), nullable: True);
            
                Field<InductionIsofrequencyConfigurationsInductionIsofrequencyDetailGraphType, InductionIsofrequencyConfigurationsInductionIsofrequencyDetail>("InductionIsofrequencyConfigurationsInductionIsofrequencyDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionIsofrequencyConfigurationsInductionIsofrequencyDetailGraphType>>(
                            "{ Name = EntityName "InductionIsofrequencyDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionIsofrequencyDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionIsofreqDetailsId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumberOfCoils"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "AdjacentCoil0"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "AdjacentCoil1"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "AdjacentCoil2"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "AdjacentCoil3"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "AdjacentCoil4"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "AdjacentCoil5"
                                                      IsNullable = true };
         Navigation
           { Type =
              TableName
                "InductionIsofrequencyConfigurationsInductionIsofrequencyDetail"
             Name =
              "InductionIsofrequencyConfigurationsInductionIsofrequencyDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "InductionIsofreqDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumberOfCoils"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "AdjacentCoil0"
                                                      Type = Primitive Byte
                                                      IsNullable = true };
    { Name = "AdjacentCoil1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "AdjacentCoil2"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "AdjacentCoil3"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "AdjacentCoil4"
      Type = Primitive Byte
      IsNullable = true }; { Name = "AdjacentCoil5"
                             Type = Primitive Byte
                             IsNullable = true }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "InductionIsofrequencyConfigurationsInductionIsofrequencyDetail"
        TargetTable =
         { Name =
            TableName
              "InductionIsofrequencyConfigurationsInductionIsofrequencyDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIsofreqConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "InductionIsofreqDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "InductionIsofrequencyConfiguration"
                          Name = "InductionIsofreqConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InductionIsofrequencyDetail"
                          Name = "InductionIsofreqDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "InductionIsofrequencyConfigurationsInductionIsofrequencyDetail"
        KeyType = Guid }] }-InductionIsofrequencyConfigurationsInductionIsofrequencyDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionIsofrequencyConfigurationsInductionIsofrequencyDetails
                                    .Where(x => x.InductionIsofrequencyConfigurationsInductionIsofrequencyDetail != null && ids.Contains((Guid)x.InductionIsofrequencyConfigurationsInductionIsofrequencyDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionIsofrequencyConfigurationsInductionIsofrequencyDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.InductionIsofrequencyConfigurationsInductionIsofrequencyDetails);
                    });
            
        }
    }
}
            