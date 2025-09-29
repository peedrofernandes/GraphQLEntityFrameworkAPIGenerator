
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
    public partial class StmSetupTempSelectorGraphType : ObjectGraphType<StmSetupTempSelector>
    {
        public StmSetupTempSelectorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
            
                Field<HeatInitializeGraphType, HeatInitialize>("HeatInitializes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, HeatInitializeGraphType>(
                            "{ Name = EntityName "StmSetupTempSelector"
  CorrespondingTable =
   Regular
     { Name = TableName "StmSetupTempSelector"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "HeatInitializeId"
                      IsNullable = false };
         Navigation { Type = TableName "HeatInitialize"
                      Name = "HeatInitialize"
                      IsNullable = false
                      IsCollection = false }] }
  Fields = [{ Name = "Id"
              Type = Id Guid
              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "HeatInitialize"
        TargetTable =
         { Name = TableName "HeatInitialize"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsPyro"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "PyroDutyPeriod"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ProbeBalance"
                                                           IsNullable = false };
             Primitive { Type = Double
                         Name = "RtdSlope1"
                         IsNullable = false }; Primitive { Type = Double
                                                           Name = "RtdSlope2"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "RtdOffset1"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "RtdOffset2"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "TargetTemperatureOffset"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PyroTargetTime"
                         IsNullable = true }; Primitive { Type = String
                                                          Name = "Description"
                                                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
                         Name = "Timestamp"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Notes"
                                                           IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseForcedIntegral"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "ForcedIntegralValue"
                         IsNullable = false }; ForeignKey { Type = Bool
                                                            Name = "ReusePid"
                                                            IsNullable = false };
             Navigation { Type = TableName "StmHeatInitializeSelector"
                          Name = "StmHeatInitializeSelectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetupTempSelector"
                          Name = "StmSetupTempSelectors"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "HeatInitialize"
        IsNullable = false
        KeyType = Guid }] }-HeatInitialize-loader",
                            async ids => 
                            {
                                var data = await dbContext.HeatInitializes
                                    .Where(x => x.HeatInitialize != null && ids.Contains((Guid)x.HeatInitialize))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.HeatInitialize!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.HeatInitialize);
                });
            
        }
    }
}
            