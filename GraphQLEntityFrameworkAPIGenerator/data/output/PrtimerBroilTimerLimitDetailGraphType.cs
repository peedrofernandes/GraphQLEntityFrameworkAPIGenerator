
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
    public partial class PrtimerBroilTimerLimitDetailGraphType : ObjectGraphType<PrtimerBroilTimerLimitDetail>
    {
        public PrtimerBroilTimerLimitDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerBroilTimerLimitDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TimerLimit, type: typeof(LongGraphType), nullable: False);
            
                Field<PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetailGraphType, PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail>("PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetailGraphType>>(
                            "{ Name = EntityName "PrtimerBroilTimerLimitDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerBroilTimerLimitDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilTimerLimitDetailsId"
                      IsNullable = false }; Primitive { Type = Long
                                                        Name = "TimerLimit"
                                                        IsNullable = false };
         Navigation
           { Type =
              TableName
                "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
             Name =
              "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields = [{ Name = "PrtimerBroilTimerLimitDetailsId"
              Type = Id Guid
              IsNullable = false }; { Name = "TimerLimit"
                                      Type = Primitive Long
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerBroilTimerLimitConfiguration"
                          Name = "PrtimerBroilTimerLimitConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerBroilTimerLimitDetail"
                          Name = "PrtimerBroilTimerLimitDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
        KeyType = Guid }] }-PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails
                                    .Where(x => x.PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail != null && ids.Contains((Guid)x.PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails);
                    });
            
        }
    }
}
            