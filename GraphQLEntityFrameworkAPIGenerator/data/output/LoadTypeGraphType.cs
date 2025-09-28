
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
    public partial class LoadTypeGraphType : ObjectGraphType<LoadType>
    {
        public LoadTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LoadTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadTypeDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.NeedParams, type: typeof(BoolGraphType), nullable: False);
            
                Field<LoadGraphType, Load>("Loads")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<LoadGraphType>>(
                            "{ Name = EntityName "LoadType"
  CorrespondingTable =
   Regular
     { Name = TableName "LoadType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "LoadTypeId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "LoadTypeDsc"
                                                        IsNullable = false };
         Primitive { Type = Bool
                     Name = "NeedParams"
                     IsNullable = false }; Navigation { Type = TableName "Load"
                                                        Name = "Loads"
                                                        IsNullable = false
                                                        IsCollection = true };
         Navigation { Type = TableName "PilotType"
                      Name = "PilotTypes"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "LoadTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "LoadTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "NeedParams"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "Load"
        TargetTable =
         { Name = TableName "Load"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "LoadDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadTypeId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "LoadsControl"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "CrossLoadDetail"
                          Name = "CrossLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadType"
                          Name = "LoadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId9Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadGroup"
                          Name = "LoadGroups"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Load"
        KeyType = Byte };
    ManyToMany
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
        KeyType = Byte }] }-Load-loader",
                            async ids => 
                            {
                                var data = await dbContext.Loads
                                    .Where(x => x.Load != null && ids.Contains((byte)x.Load))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.Load!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.Loads);
                    });
            
			
                Field<PilotTypeGraphType, PilotType>("PilotTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, PilotTypeGraphType>(
                            "{ Name = EntityName "LoadType"
  CorrespondingTable =
   Regular
     { Name = TableName "LoadType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "LoadTypeId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "LoadTypeDsc"
                                                        IsNullable = false };
         Primitive { Type = Bool
                     Name = "NeedParams"
                     IsNullable = false }; Navigation { Type = TableName "Load"
                                                        Name = "Loads"
                                                        IsNullable = false
                                                        IsCollection = true };
         Navigation { Type = TableName "PilotType"
                      Name = "PilotTypes"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "LoadTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "LoadTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "NeedParams"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "Load"
        TargetTable =
         { Name = TableName "Load"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "LoadDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadTypeId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "LoadsControl"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "CrossLoadDetail"
                          Name = "CrossLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadType"
                          Name = "LoadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId9Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadGroup"
                          Name = "LoadGroups"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Load"
        KeyType = Byte };
    ManyToMany
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
        KeyType = Byte }] }-PilotType-loader",
                            async ids => 
                            {
                                var data = await dbContext.PilotTypes
                                    .Where(x => x.PilotType.Any(c => ids.Contains(c.PilotTypeId)))
                                    .Select(x => new
                                    {
                                        Key = x,
                                        Values = x.PilotType,
                                    })
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => x.Values.Select(v => new { Key = v.PilotTypeId, Value = x.Key }))
                                    .ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PilotTypes);
                    });
            
        }
    }
}
            