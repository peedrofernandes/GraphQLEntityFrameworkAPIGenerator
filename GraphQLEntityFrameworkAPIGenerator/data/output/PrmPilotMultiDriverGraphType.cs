
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
    public partial class PrmPilotMultiDriverGraphType : ObjectGraphType<PrmPilotMultiDriver>
    {
        public PrmPilotMultiDriverGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PilotTypeId0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PilotParametersId0, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.PilotTypeId1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PilotParametersId1, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.PilotTypeId2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.PilotParametersId2, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.PilotTypeId3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.PilotParametersId3, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.NumOfPins, type: typeof(ByteGraphType), nullable: False);
            
                Field<PilotTypeGraphType, PilotType>("PilotTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, PilotTypeGraphType>(
                            "{ Name = EntityName "PrmPilotMultiDriver"
  CorrespondingTable =
   Regular
     { Name = TableName "PrmPilotMultiDriver"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "PilotTypeId0"
                                                        IsNullable = false };
         Primitive { Type = Guid
                     Name = "PilotParametersId0"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "PilotTypeId1"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "PilotParametersId1"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "PilotTypeId2"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "PilotParametersId2"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "PilotTypeId3"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "PilotParametersId3"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "NumOfPins"
                                                      IsNullable = false };
         Navigation { Type = TableName "PilotType"
                      Name = "PilotTypeId0Navigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PilotType"
                      Name = "PilotTypeId1Navigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PilotType"
                      Name = "PilotTypeId2Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "PilotType"
                      Name = "PilotTypeId3Navigation"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "PilotTypeId0"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "PilotParametersId0"
      Type = Primitive Guid
      IsNullable = true }; { Name = "PilotTypeId1"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "PilotParametersId1"
                                                     Type = Primitive Guid
                                                     IsNullable = true };
    { Name = "PilotTypeId2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "PilotParametersId2"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "PilotTypeId3"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "PilotParametersId3"
      Type = Primitive Guid
      IsNullable = true }; { Name = "NumOfPins"
                             Type = Primitive Byte
                             IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "PilotTypeId0Navigation";
          RelationName "PilotTypeId1Navigation";
          RelationName "PilotTypeId2Navigation";
          RelationName "PilotTypeId3Navigation"]
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
                                Expression<Func<PilotType, bool>> expr = x => !ids.Any()
                                    \|\| (x.PilotTypeId0Navigation != null && ids.Contains((byte)x.PilotTypeId0Navigation))
\|\| (x.PilotTypeId1Navigation != null && ids.Contains((byte)x.PilotTypeId1Navigation))
\|\| (x.PilotTypeId2Navigation != null && ids.Contains((byte)x.PilotTypeId2Navigation))
\|\| (x.PilotTypeId3Navigation != null && ids.Contains((byte)x.PilotTypeId3Navigation));

                                var data = await dbContext.PilotTypes
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<byte?>()
                                    {
                                        x.PilotTypeId0Navigation,
x.PilotTypeId1Navigation,
x.PilotTypeId2Navigation,
x.PilotTypeId3Navigation
                                    }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.PilotTypes);
                    });
            
        }
    }
}
            