
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
    public partial class MultiDriverPilotTypeGraphType : ObjectGraphType<MultiDriverPilotType>
    {
        public MultiDriverPilotTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PilotTypeId, type: typeof(ByteGraphType), nullable: False);
            
                Field<PilotTypeGraphType, PilotType>("PilotTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, PilotTypeGraphType>(
                            "{ Name = EntityName "MultiDriverPilotType"
  CorrespondingTable =
   Regular
     { Name = TableName "MultiDriverPilotType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "PilotTypeId"
                      IsNullable = false };
         Navigation { Type = TableName "PilotType"
                      Name = "PilotType"
                      IsNullable = false
                      IsCollection = false }] }
  Fields = [{ Name = "PilotTypeId"
              Type = Id Byte
              IsNullable = false }]
  Relations =
   [OneToOne
      { Name = RelationName "PilotType"
        TargetTable =
         { Name = TableName "PilotType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "PilotTypeDsc"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "NumPins"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "NeedParams"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "NeedFeedbacks"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MultiDriverPilotType"
                          Name = "MultiDriverPilotType"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MultiSequencePilotType"
                          Name = "MultiSequencePilotType"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrmPilotMultiDriver"
                          Name = "PrmPilotMultiDriverPilotTypeId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiDriver"
                          Name = "PrmPilotMultiDriverPilotTypeId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiDriver"
                          Name = "PrmPilotMultiDriverPilotTypeId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiDriver"
                          Name = "PrmPilotMultiDriverPilotTypeId3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadType"
                          Name = "LoadTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PilotType"
        IsNullable = false
        KeyType = Byte }] }-PilotType-loader",
                            async ids => 
                            {
                                var data = await dbContext.PilotTypes
                                    .Where(x => x.PilotType != null && ids.Contains((byte)x.PilotType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.PilotType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PilotTypes);
                    });
            
        }
    }
}
            