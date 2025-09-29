
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
    public partial class PrtimerMagnetronTimerLimitDetailGraphType : ObjectGraphType<PrtimerMagnetronTimerLimitDetail>
    {
        public PrtimerMagnetronTimerLimitDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerMagnetronTimerLimitDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TimerLimit, type: typeof(LongGraphType), nullable: False);
            
                Field<PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetailGraphType, PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail>("PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetailGraphType>>(
                            "{ Name = EntityName "PrtimerMagnetronTimerLimitDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerMagnetronTimerLimitDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronTimerLimitDetailsId"
                      IsNullable = false }; Primitive { Type = Long
                                                        Name = "TimerLimit"
                                                        IsNullable = false };
         Navigation
           { Type =
              TableName
                "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
             Name =
              "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields = [{ Name = "PrtimerMagnetronTimerLimitDetailsId"
              Type = Id Guid
              IsNullable = false }; { Name = "TimerLimit"
                                      Type = Primitive Long
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerLimitConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerLimitDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                 Name = "PrtimerMagnetronTimerLimitConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "PrtimerMagnetronTimerLimitDetail"
                          Name = "PrtimerMagnetronTimerLimitDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
        KeyType = Guid }] }-PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails
                                    .Where(x => x.PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail != null && ids.Contains((Guid)x.PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails);
                    });
            
        }
    }
}
            