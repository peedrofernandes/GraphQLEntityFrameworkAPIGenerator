
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
    public partial class PrtimerConvectTimerLimitDetailGraphType : ObjectGraphType<PrtimerConvectTimerLimitDetail>
    {
        public PrtimerConvectTimerLimitDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerConvectTimerLimitDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TimerLimit, type: typeof(LongGraphType), nullable: False);
            
                Field<PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetailGraphType, PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail>("PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetailGraphType>>(
                            "{ Name = EntityName "PrtimerConvectTimerLimitDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerConvectTimerLimitDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectTimerLimitDetailsId"
                      IsNullable = false }; Primitive { Type = Long
                                                        Name = "TimerLimit"
                                                        IsNullable = false };
         Navigation
           { Type =
              TableName
                "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
             Name =
              "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields = [{ Name = "PrtimerConvectTimerLimitDetailsId"
              Type = Id Guid
              IsNullable = false }; { Name = "TimerLimit"
                                      Type = Primitive Long
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerLimitConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerLimitDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                 Name = "PrtimerConvectTimerLimitConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "PrtimerConvectTimerLimitDetail"
                          Name = "PrtimerConvectTimerLimitDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
        KeyType = Guid }] }-PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails
                                    .Where(x => x.PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail != null && ids.Contains((Guid)x.PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails);
                    });
            
        }
    }
}
            