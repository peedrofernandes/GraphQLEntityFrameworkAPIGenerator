
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
    public partial class PilotTypeGraphType : ObjectGraphType<PilotType>
    {
        public PilotTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PilotTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PilotTypeDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.NumPins, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NeedParams, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.NeedFeedbacks, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsSafetyRelevant, type: typeof(BoolGraphType), nullable: False);
            
                Field<LoadDetailGraphType, LoadDetail>("LoadDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LoadDetailGraphType>>(
                            "{ Name = EntityName "PilotType"
  CorrespondingTable =
   Regular
     { Name = TableName "PilotType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "PilotTypeId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "PilotTypeDsc"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "NumPins"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "NeedParams"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "NeedFeedbacks"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "PilotTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "PilotTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "NumPins"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NeedParams"
      Type = Primitive Bool
      IsNullable = false }; { Name = "NeedFeedbacks"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "IsSafetyRelevant"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "LoadDetail"
        TargetTable =
         { Name = TableName "LoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Pin1"
                                                            IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Pin3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin4"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "OnLevel1"
                                                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "OnLevel2"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "OnLevel3"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "OnLevel4"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PilotParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "FeedbackParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LoadParametersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "Uidriven"
                                                           IsNullable = false };
             Navigation { Type = TableName "FeedbackParameter"
                          Name = "FeedbackParameters"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadDetail"
        KeyType = Guid };
    OneToOne
      { Name = RelationName "MultiDriverPilotType"
        TargetTable =
         { Name = TableName "MultiDriverPilotType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "MultiDriverPilotType"
        IsNullable = true
        KeyType = Byte };
    OneToOne
      { Name = RelationName "MultiSequencePilotType"
        TargetTable =
         { Name = TableName "MultiSequencePilotType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId3Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MultiSequencePilotType"
        IsNullable = true
        KeyType = Byte };
    OneToMany
      { Name = RelationName "PrmPilotMultiDriver"
        TargetTable =
         { Name = TableName "PrmPilotMultiDriver"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
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
        Destination = EntityName "PrmPilotMultiDriver"
        KeyType = Guid };
    ManyToMany
      { Name = RelationName "LoadType"
        TargetTable =
         { Name = TableName "LoadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadTypeId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "LoadTypeDsc"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "NeedParams"
                         IsNullable = false };
             Navigation { Type = TableName "Load"
                          Name = "Loads"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadType"
        KeyType = Byte }] }-LoadDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.LoadDetails
                                    .Where(x => x.LoadDetail != null && ids.Contains((Guid)x.LoadDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.LoadDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.LoadDetails);
                    });
            
			
                Field<MultiDriverPilotTypeGraphType, MultiDriverPilotType>("MultiDriverPilotTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, MultiDriverPilotTypeGraphType>(
                            "{ Name = EntityName "PilotType"
  CorrespondingTable =
   Regular
     { Name = TableName "PilotType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "PilotTypeId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "PilotTypeDsc"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "NumPins"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "NeedParams"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "NeedFeedbacks"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "PilotTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "PilotTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "NumPins"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NeedParams"
      Type = Primitive Bool
      IsNullable = false }; { Name = "NeedFeedbacks"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "IsSafetyRelevant"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "LoadDetail"
        TargetTable =
         { Name = TableName "LoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Pin1"
                                                            IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Pin3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin4"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "OnLevel1"
                                                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "OnLevel2"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "OnLevel3"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "OnLevel4"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PilotParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "FeedbackParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LoadParametersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "Uidriven"
                                                           IsNullable = false };
             Navigation { Type = TableName "FeedbackParameter"
                          Name = "FeedbackParameters"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadDetail"
        KeyType = Guid };
    OneToOne
      { Name = RelationName "MultiDriverPilotType"
        TargetTable =
         { Name = TableName "MultiDriverPilotType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "MultiDriverPilotType"
        IsNullable = true
        KeyType = Byte };
    OneToOne
      { Name = RelationName "MultiSequencePilotType"
        TargetTable =
         { Name = TableName "MultiSequencePilotType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId3Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MultiSequencePilotType"
        IsNullable = true
        KeyType = Byte };
    OneToMany
      { Name = RelationName "PrmPilotMultiDriver"
        TargetTable =
         { Name = TableName "PrmPilotMultiDriver"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
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
        Destination = EntityName "PrmPilotMultiDriver"
        KeyType = Guid };
    ManyToMany
      { Name = RelationName "LoadType"
        TargetTable =
         { Name = TableName "LoadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadTypeId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "LoadTypeDsc"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "NeedParams"
                         IsNullable = false };
             Navigation { Type = TableName "Load"
                          Name = "Loads"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadType"
        KeyType = Byte }] }-MultiDriverPilotType-loader",
                            async ids => 
                            {
                                var data = await dbContext.MultiDriverPilotTypes
                                    .Where(x => x.MultiDriverPilotType != null && ids.Contains((byte)x.MultiDriverPilotType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.MultiDriverPilotType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.MultiDriverPilotTypes);
                    });
            
			
                Field<MultiSequencePilotTypeGraphType, MultiSequencePilotType>("MultiSequencePilotTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, MultiSequencePilotTypeGraphType>(
                            "{ Name = EntityName "PilotType"
  CorrespondingTable =
   Regular
     { Name = TableName "PilotType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "PilotTypeId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "PilotTypeDsc"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "NumPins"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "NeedParams"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "NeedFeedbacks"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "PilotTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "PilotTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "NumPins"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NeedParams"
      Type = Primitive Bool
      IsNullable = false }; { Name = "NeedFeedbacks"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "IsSafetyRelevant"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "LoadDetail"
        TargetTable =
         { Name = TableName "LoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Pin1"
                                                            IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Pin3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin4"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "OnLevel1"
                                                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "OnLevel2"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "OnLevel3"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "OnLevel4"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PilotParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "FeedbackParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LoadParametersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "Uidriven"
                                                           IsNullable = false };
             Navigation { Type = TableName "FeedbackParameter"
                          Name = "FeedbackParameters"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadDetail"
        KeyType = Guid };
    OneToOne
      { Name = RelationName "MultiDriverPilotType"
        TargetTable =
         { Name = TableName "MultiDriverPilotType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "MultiDriverPilotType"
        IsNullable = true
        KeyType = Byte };
    OneToOne
      { Name = RelationName "MultiSequencePilotType"
        TargetTable =
         { Name = TableName "MultiSequencePilotType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId3Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MultiSequencePilotType"
        IsNullable = true
        KeyType = Byte };
    OneToMany
      { Name = RelationName "PrmPilotMultiDriver"
        TargetTable =
         { Name = TableName "PrmPilotMultiDriver"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
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
        Destination = EntityName "PrmPilotMultiDriver"
        KeyType = Guid };
    ManyToMany
      { Name = RelationName "LoadType"
        TargetTable =
         { Name = TableName "LoadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadTypeId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "LoadTypeDsc"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "NeedParams"
                         IsNullable = false };
             Navigation { Type = TableName "Load"
                          Name = "Loads"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadType"
        KeyType = Byte }] }-MultiSequencePilotType-loader",
                            async ids => 
                            {
                                var data = await dbContext.MultiSequencePilotTypes
                                    .Where(x => x.MultiSequencePilotType != null && ids.Contains((byte)x.MultiSequencePilotType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.MultiSequencePilotType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.MultiSequencePilotTypes);
                    });
            
			
                Field<PrmPilotMultiDriverGraphType, PrmPilotMultiDriver>("PrmPilotMultiDrivers")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmPilotMultiDriverGraphType>>(
                            "{ Name = EntityName "PilotType"
  CorrespondingTable =
   Regular
     { Name = TableName "PilotType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "PilotTypeId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "PilotTypeDsc"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "NumPins"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "NeedParams"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "NeedFeedbacks"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "PilotTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "PilotTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "NumPins"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NeedParams"
      Type = Primitive Bool
      IsNullable = false }; { Name = "NeedFeedbacks"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "IsSafetyRelevant"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "LoadDetail"
        TargetTable =
         { Name = TableName "LoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Pin1"
                                                            IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Pin3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin4"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "OnLevel1"
                                                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "OnLevel2"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "OnLevel3"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "OnLevel4"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PilotParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "FeedbackParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LoadParametersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "Uidriven"
                                                           IsNullable = false };
             Navigation { Type = TableName "FeedbackParameter"
                          Name = "FeedbackParameters"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadDetail"
        KeyType = Guid };
    OneToOne
      { Name = RelationName "MultiDriverPilotType"
        TargetTable =
         { Name = TableName "MultiDriverPilotType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "MultiDriverPilotType"
        IsNullable = true
        KeyType = Byte };
    OneToOne
      { Name = RelationName "MultiSequencePilotType"
        TargetTable =
         { Name = TableName "MultiSequencePilotType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId3Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MultiSequencePilotType"
        IsNullable = true
        KeyType = Byte };
    OneToMany
      { Name = RelationName "PrmPilotMultiDriver"
        TargetTable =
         { Name = TableName "PrmPilotMultiDriver"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
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
        Destination = EntityName "PrmPilotMultiDriver"
        KeyType = Guid };
    ManyToMany
      { Name = RelationName "LoadType"
        TargetTable =
         { Name = TableName "LoadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadTypeId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "LoadTypeDsc"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "NeedParams"
                         IsNullable = false };
             Navigation { Type = TableName "Load"
                          Name = "Loads"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadType"
        KeyType = Byte }] }-PrmPilotMultiDriver-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrmPilotMultiDrivers
                                    .Where(x => x.PrmPilotMultiDriver != null && ids.Contains((Guid)x.PrmPilotMultiDriver))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrmPilotMultiDriver!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrmPilotMultiDrivers);
                    });
            
			
                Field<LoadTypeGraphType, LoadType>("LoadTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, LoadTypeGraphType>(
                            "{ Name = EntityName "PilotType"
  CorrespondingTable =
   Regular
     { Name = TableName "PilotType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "PilotTypeId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "PilotTypeDsc"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "NumPins"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "NeedParams"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "NeedFeedbacks"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "PilotTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "PilotTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "NumPins"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NeedParams"
      Type = Primitive Bool
      IsNullable = false }; { Name = "NeedFeedbacks"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "IsSafetyRelevant"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "LoadDetail"
        TargetTable =
         { Name = TableName "LoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Pin1"
                                                            IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Pin3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin4"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "OnLevel1"
                                                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "OnLevel2"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "OnLevel3"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "OnLevel4"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PilotParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "FeedbackParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LoadParametersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "Uidriven"
                                                           IsNullable = false };
             Navigation { Type = TableName "FeedbackParameter"
                          Name = "FeedbackParameters"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadDetail"
        KeyType = Guid };
    OneToOne
      { Name = RelationName "MultiDriverPilotType"
        TargetTable =
         { Name = TableName "MultiDriverPilotType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "MultiDriverPilotType"
        IsNullable = true
        KeyType = Byte };
    OneToOne
      { Name = RelationName "MultiSequencePilotType"
        TargetTable =
         { Name = TableName "MultiSequencePilotType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId3Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MultiSequencePilotType"
        IsNullable = true
        KeyType = Byte };
    OneToMany
      { Name = RelationName "PrmPilotMultiDriver"
        TargetTable =
         { Name = TableName "PrmPilotMultiDriver"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
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
        Destination = EntityName "PrmPilotMultiDriver"
        KeyType = Guid };
    ManyToMany
      { Name = RelationName "LoadType"
        TargetTable =
         { Name = TableName "LoadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadTypeId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "LoadTypeDsc"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "NeedParams"
                         IsNullable = false };
             Navigation { Type = TableName "Load"
                          Name = "Loads"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadType"
        KeyType = Byte }] }-LoadType-loader",
                            async ids => 
                            {
                                var data = await dbContext.LoadTypes
                                    .Where(x => x.LoadType.Any(c => ids.Contains(c.LoadTypeId)))
                                    .Select(x => new
                                    {
                                        Key = x,
                                        Values = x.LoadType,
                                    })
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => x.Values.Select(v => new { Key = v.LoadTypeId, Value = x.Key }))
                                    .ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.LoadTypes);
                    });
            
        }
    }
}
            