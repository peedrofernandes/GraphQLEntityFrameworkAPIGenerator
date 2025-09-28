
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
    public partial class PrmReadI2cinfraredGraphType : ObjectGraphType<PrmReadI2cinfrared>
    {
        public PrmReadI2cinfraredGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.StepPeriodMilliseconds, type: typeof(IdGraphType), nullable: False);
			Field(t => t.I2cchannel, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.BitResolution, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RefreshRate, type: typeof(ByteGraphType), nullable: False);
            
                Field<RefreshRateGraphType, RefreshRate>("RefreshRates")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, RefreshRateGraphType>(
                            "{ Name = EntityName "PrmReadI2cinfrared"
  CorrespondingTable =
   Regular
     { Name = TableName "PrmReadI2cinfrared"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false };
         Primitive { Type = Int
                     Name = "StepPeriodMilliseconds"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "I2cchannel"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "BitResolution"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "RefreshRate"
                                                       IsNullable = false };
         Navigation { Type = TableName "RefreshRate"
                      Name = "RefreshRateNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "StepPeriodMilliseconds"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "I2cchannel"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "BitResolution"
      Type = Primitive Byte
      IsNullable = false }; { Name = "RefreshRate"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "RefreshRate"
        TargetTable =
         { Name = TableName "RefreshRate"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Navigation { Type = TableName "PrmReadI2cinfrared"
                          Name = "PrmReadI2cinfrareds"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "RefreshRate"
        IsNullable = false
        KeyType = Byte }] }-RefreshRate-loader",
                            async ids => 
                            {
                                var data = await dbContext.RefreshRates
                                    .Where(x => x.RefreshRate != null && ids.Contains((byte)x.RefreshRate))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.RefreshRate!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.RefreshRate);
                });
            
        }
    }
}
            