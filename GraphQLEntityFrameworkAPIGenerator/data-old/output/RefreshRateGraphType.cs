
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
    public partial class RefreshRateGraphType : ObjectGraphType<RefreshRate>
    {
        public RefreshRateGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
            
                Field<PrmReadI2cinfraredGraphType, PrmReadI2cinfrared>("PrmReadI2cinfrareds")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmReadI2cinfraredGraphType>>(
                            "{ Name = EntityName "RefreshRate"
  CorrespondingTable =
   Regular
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
  Fields = [{ Name = "Id"
              Type = Id Byte
              IsNullable = false }; { Name = "Description"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "PrmReadI2cinfrared"
        TargetTable =
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
        Destination = EntityName "PrmReadI2cinfrared"
        KeyType = Guid }] }-PrmReadI2cinfrared-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrmReadI2cinfrareds
                                    .Where(x => x.PrmReadI2cinfrared != null && ids.Contains((Guid)x.PrmReadI2cinfrared))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrmReadI2cinfrared!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrmReadI2cinfrareds);
                    });
            
        }
    }
}
            