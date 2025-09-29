
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
    public partial class PrtimerBroilUserPhaseNameDetailGraphType : ObjectGraphType<PrtimerBroilUserPhaseNameDetail>
    {
        public PrtimerBroilUserPhaseNameDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerBroilUserPhaseNameDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TimerIncrement, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimit, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetailGraphType, PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail>("PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetailGraphType>>(
                            "{ Name = EntityName "PrtimerBroilUserPhaseNameDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerBroilUserPhaseNameDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilUserPhaseNameDetailsId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "TimerIncrement"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "PowerLimit"
                     IsNullable = false };
         Navigation
           { Type =
              TableName
                "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
             Name =
              "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "PrtimerBroilUserPhaseNameDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "TimerIncrement"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "PowerLimit"
                                                      Type = Primitive Byte
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "PrtimerBroilUserPhaseNameConfiguration"
                 Name = "PrtimerBroilUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "PrtimerBroilUserPhaseNameDetail"
                          Name = "PrtimerBroilUserPhaseNameDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
        KeyType = Guid }] }-PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails
                                    .Where(x => x.PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail != null && ids.Contains((Guid)x.PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails);
                    });
            
        }
    }
}
            