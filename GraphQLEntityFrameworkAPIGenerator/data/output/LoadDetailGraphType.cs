
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
    public partial class LoadDetailGraphType : ObjectGraphType<LoadDetail>
    {
        public LoadDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LoadDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Pin1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.OnLevel1, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OnLevel2, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OnLevel3, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OnLevel4, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Uidriven, type: typeof(BoolGraphType), nullable: False);
            
                Field<FeedbackParameterGraphType, FeedbackParameter>("FeedbackParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, FeedbackParameterGraphType>(
                            "{ Name = EntityName "LoadDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "LoadDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "LoadDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
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
  Fields =
   [{ Name = "LoadDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "Pin1"
                              Type = Primitive Byte
                              IsNullable = true }; { Name = "Pin2"
                                                     Type = Primitive Byte
                                                     IsNullable = true };
    { Name = "Pin3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Pin4"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "OnLevel1"
                                                    Type = Primitive Bool
                                                    IsNullable = false };
    { Name = "OnLevel2"
      Type = Primitive Bool
      IsNullable = false }; { Name = "OnLevel3"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "OnLevel4"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Uidriven"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "FeedbackParameter"
        TargetTable =
         { Name = TableName "FeedbackParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FeedbackParametersId"
                          IsNullable = false }; Primitive { Type = String
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
             Primitive { Type = Byte
                         Name = "FeedbacksNumber"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "StatesNumber"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "ItemsNumber"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ReadTypeId1"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "ReadTypePos1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ReadTypeId2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "ReadTypePos2"
                         IsNullable = false };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "FeedbackParameter"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
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
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LoadConfigurationsLoadDetail"
        TargetTable =
         { Name = TableName "LoadConfigurationsLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "LoadDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfigurationsLoadDetail"
        KeyType = Guid };
    SingleManyToOne
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
        KeyType = Byte }] }-FeedbackParameter-loader",
                            async ids => 
                            {
                                var data = await dbContext.FeedbackParameters
                                    .Where(x => x.FeedbackParameter != null && ids.Contains((Guid)x.FeedbackParameter))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.FeedbackParameter!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.FeedbackParameter);
                });
            
			
                Field<LoadGraphType, Load>("Loads")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, LoadGraphType>(
                            "{ Name = EntityName "LoadDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "LoadDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "LoadDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
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
  Fields =
   [{ Name = "LoadDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "Pin1"
                              Type = Primitive Byte
                              IsNullable = true }; { Name = "Pin2"
                                                     Type = Primitive Byte
                                                     IsNullable = true };
    { Name = "Pin3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Pin4"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "OnLevel1"
                                                    Type = Primitive Bool
                                                    IsNullable = false };
    { Name = "OnLevel2"
      Type = Primitive Bool
      IsNullable = false }; { Name = "OnLevel3"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "OnLevel4"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Uidriven"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "FeedbackParameter"
        TargetTable =
         { Name = TableName "FeedbackParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FeedbackParametersId"
                          IsNullable = false }; Primitive { Type = String
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
             Primitive { Type = Byte
                         Name = "FeedbacksNumber"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "StatesNumber"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "ItemsNumber"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ReadTypeId1"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "ReadTypePos1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ReadTypeId2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "ReadTypePos2"
                         IsNullable = false };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "FeedbackParameter"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
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
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LoadConfigurationsLoadDetail"
        TargetTable =
         { Name = TableName "LoadConfigurationsLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "LoadDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfigurationsLoadDetail"
        KeyType = Guid };
    SingleManyToOne
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

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Load);
                });
            
			
                Field<LoadConfigurationsLoadDetailGraphType, LoadConfigurationsLoadDetail>("LoadConfigurationsLoadDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LoadConfigurationsLoadDetailGraphType>>(
                            "{ Name = EntityName "LoadDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "LoadDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "LoadDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
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
  Fields =
   [{ Name = "LoadDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "Pin1"
                              Type = Primitive Byte
                              IsNullable = true }; { Name = "Pin2"
                                                     Type = Primitive Byte
                                                     IsNullable = true };
    { Name = "Pin3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Pin4"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "OnLevel1"
                                                    Type = Primitive Bool
                                                    IsNullable = false };
    { Name = "OnLevel2"
      Type = Primitive Bool
      IsNullable = false }; { Name = "OnLevel3"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "OnLevel4"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Uidriven"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "FeedbackParameter"
        TargetTable =
         { Name = TableName "FeedbackParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FeedbackParametersId"
                          IsNullable = false }; Primitive { Type = String
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
             Primitive { Type = Byte
                         Name = "FeedbacksNumber"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "StatesNumber"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "ItemsNumber"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ReadTypeId1"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "ReadTypePos1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ReadTypeId2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "ReadTypePos2"
                         IsNullable = false };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "FeedbackParameter"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
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
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LoadConfigurationsLoadDetail"
        TargetTable =
         { Name = TableName "LoadConfigurationsLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "LoadDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfigurationsLoadDetail"
        KeyType = Guid };
    SingleManyToOne
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
        KeyType = Byte }] }-LoadConfigurationsLoadDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.LoadConfigurationsLoadDetails
                                    .Where(x => x.LoadConfigurationsLoadDetail != null && ids.Contains((Guid)x.LoadConfigurationsLoadDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.LoadConfigurationsLoadDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.LoadConfigurationsLoadDetails);
                    });
            
			
                Field<PilotTypeGraphType, PilotType>("PilotTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, PilotTypeGraphType>(
                            "{ Name = EntityName "LoadDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "LoadDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "LoadDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
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
  Fields =
   [{ Name = "LoadDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "Pin1"
                              Type = Primitive Byte
                              IsNullable = true }; { Name = "Pin2"
                                                     Type = Primitive Byte
                                                     IsNullable = true };
    { Name = "Pin3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Pin4"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "OnLevel1"
                                                    Type = Primitive Bool
                                                    IsNullable = false };
    { Name = "OnLevel2"
      Type = Primitive Bool
      IsNullable = false }; { Name = "OnLevel3"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "OnLevel4"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Uidriven"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "FeedbackParameter"
        TargetTable =
         { Name = TableName "FeedbackParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FeedbackParametersId"
                          IsNullable = false }; Primitive { Type = String
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
             Primitive { Type = Byte
                         Name = "FeedbacksNumber"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "StatesNumber"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "ItemsNumber"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ReadTypeId1"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "ReadTypePos1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ReadTypeId2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "ReadTypePos2"
                         IsNullable = false };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "FeedbackParameter"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
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
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LoadConfigurationsLoadDetail"
        TargetTable =
         { Name = TableName "LoadConfigurationsLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "LoadDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfigurationsLoadDetail"
        KeyType = Guid };
    SingleManyToOne
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

                        return loader.LoadAsync(context.Source.PilotType);
                });
            
        }
    }
}
            