
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
    public partial class PrtimerConvectUserPhaseNameDetailGraphType : ObjectGraphType<PrtimerConvectUserPhaseNameDetail>
    {
        public PrtimerConvectUserPhaseNameDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerConvectUserPhaseNameDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TimerIncrement, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimit, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetailGraphType, PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail>("PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetailGraphType>>(
                            "{ Name = EntityName "PrtimerConvectUserPhaseNameDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerConvectUserPhaseNameDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectUserPhaseNameDetailsId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "TimerIncrement"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "PowerLimit"
                     IsNullable = false };
         Navigation
           { Type =
              TableName
                "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
             Name =
              "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "PrtimerConvectUserPhaseNameDetailsId"
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
           "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "PrtimerConvectUserPhaseNameConfiguration"
                 Name = "PrtimerConvectUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "PrtimerConvectUserPhaseNameDetail"
                          Name = "PrtimerConvectUserPhaseNameDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
        KeyType = Guid }] }-PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails
                                    .Where(x => x.PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail != null && ids.Contains((Guid)x.PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails);
                    });
            
        }
    }
}
            