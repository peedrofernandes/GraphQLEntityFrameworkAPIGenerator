
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
    public partial class PrtimerMagnetronUserPhaseNameDetailGraphType : ObjectGraphType<PrtimerMagnetronUserPhaseNameDetail>
    {
        public PrtimerMagnetronUserPhaseNameDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerMagnetronUserPhaseNameDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TimerIncrement, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerLimit, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetailGraphType, PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail>("PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetailGraphType>>(
                            "{ Name = EntityName "PrtimerMagnetronUserPhaseNameDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerMagnetronUserPhaseNameDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronUserPhaseNameDetailsId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "TimerIncrement"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "PowerLimit"
                     IsNullable = false };
         Navigation
           { Type =
              TableName
                "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
             Name =
              "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "PrtimerMagnetronUserPhaseNameDetailsId"
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
           "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronUserPhaseNameDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "PrtimerMagnetronUserPhaseNameConfiguration"
                 Name = "PrtimerMagnetronUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "PrtimerMagnetronUserPhaseNameDetail"
                          Name = "PrtimerMagnetronUserPhaseNameDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
        KeyType = Guid }] }-PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails
                                    .Where(x => x.PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail != null && ids.Contains((Guid)x.PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails);
                    });
            
        }
    }
}
            