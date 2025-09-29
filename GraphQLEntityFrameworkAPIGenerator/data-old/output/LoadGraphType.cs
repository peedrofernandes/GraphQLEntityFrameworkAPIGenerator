
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
    public partial class LoadGraphType : ObjectGraphType<Load>
    {
        public LoadGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LoadId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.LoadsControl, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsSafetyRelevant, type: typeof(BoolGraphType), nullable: False);
            
                Field<CrossLoadDetailGraphType, CrossLoadDetail>("CrossLoadDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CrossLoadDetailGraphType>>(
                            "{ Name = EntityName "Load"
  CorrespondingTable =
   Regular
     { Name = TableName "Load"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "LoadId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "LoadDsc"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "LoadTypeId"
                      IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "LoadId"
      Type = Id Byte
      IsNullable = false }; { Name = "LoadDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "LoadsControl"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "IsSafetyRelevant"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CrossLoadDetail"
        TargetTable =
         { Name = TableName "CrossLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "CrossLoadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "OnDelayTime"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "OffDelayTime"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CouplesNum"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOnDisconnected"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOffDisconnected"
                         IsNullable = false };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CrossLoadType"
                          Name = "CrossLoadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadDetail"
        KeyType = Guid };
    OneToMany
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
    SingleManyToOne
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
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LoadsControlPilotParameter"
        TargetTable =
         { Name = TableName "LoadsControlPilotParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "ComplexLoadsNumber"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "LoadId0"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId6"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId6"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId7"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId7"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId8"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId9"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue9"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId9"
                         IsNullable = true };
             Navigation { Type = TableName "Load"
                          Name = "LoadId0Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId0Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "StmLoadsControl"
                          Name = "StmLoadsControls"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadsControlPilotParameter"
        KeyType = Guid };
    ManyToMany
      { Name = RelationName "LoadGroup"
        TargetTable =
         { Name = TableName "LoadGroup"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadGroupId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "LoadGroupDsc"
                         IsNullable = false };
             Navigation { Type = TableName "Load"
                          Name = "Loads"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadGroup"
        KeyType = Byte }] }-CrossLoadDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.CrossLoadDetails
                                    .Where(x => x.CrossLoadDetail != null && ids.Contains((Guid)x.CrossLoadDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CrossLoadDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CrossLoadDetails);
                    });
            
			
                Field<LoadDetailGraphType, LoadDetail>("LoadDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LoadDetailGraphType>>(
                            "{ Name = EntityName "Load"
  CorrespondingTable =
   Regular
     { Name = TableName "Load"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "LoadId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "LoadDsc"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "LoadTypeId"
                      IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "LoadId"
      Type = Id Byte
      IsNullable = false }; { Name = "LoadDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "LoadsControl"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "IsSafetyRelevant"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CrossLoadDetail"
        TargetTable =
         { Name = TableName "CrossLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "CrossLoadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "OnDelayTime"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "OffDelayTime"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CouplesNum"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOnDisconnected"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOffDisconnected"
                         IsNullable = false };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CrossLoadType"
                          Name = "CrossLoadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadDetail"
        KeyType = Guid };
    OneToMany
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
    SingleManyToOne
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
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LoadsControlPilotParameter"
        TargetTable =
         { Name = TableName "LoadsControlPilotParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "ComplexLoadsNumber"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "LoadId0"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId6"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId6"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId7"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId7"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId8"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId9"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue9"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId9"
                         IsNullable = true };
             Navigation { Type = TableName "Load"
                          Name = "LoadId0Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId0Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "StmLoadsControl"
                          Name = "StmLoadsControls"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadsControlPilotParameter"
        KeyType = Guid };
    ManyToMany
      { Name = RelationName "LoadGroup"
        TargetTable =
         { Name = TableName "LoadGroup"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadGroupId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "LoadGroupDsc"
                         IsNullable = false };
             Navigation { Type = TableName "Load"
                          Name = "Loads"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadGroup"
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
            
			
                Field<LoadTypeGraphType, LoadType>("LoadTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, LoadTypeGraphType>(
                            "{ Name = EntityName "Load"
  CorrespondingTable =
   Regular
     { Name = TableName "Load"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "LoadId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "LoadDsc"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "LoadTypeId"
                      IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "LoadId"
      Type = Id Byte
      IsNullable = false }; { Name = "LoadDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "LoadsControl"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "IsSafetyRelevant"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CrossLoadDetail"
        TargetTable =
         { Name = TableName "CrossLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "CrossLoadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "OnDelayTime"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "OffDelayTime"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CouplesNum"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOnDisconnected"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOffDisconnected"
                         IsNullable = false };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CrossLoadType"
                          Name = "CrossLoadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadDetail"
        KeyType = Guid };
    OneToMany
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
    SingleManyToOne
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
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LoadsControlPilotParameter"
        TargetTable =
         { Name = TableName "LoadsControlPilotParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "ComplexLoadsNumber"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "LoadId0"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId6"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId6"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId7"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId7"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId8"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId9"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue9"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId9"
                         IsNullable = true };
             Navigation { Type = TableName "Load"
                          Name = "LoadId0Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId0Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "StmLoadsControl"
                          Name = "StmLoadsControls"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadsControlPilotParameter"
        KeyType = Guid };
    ManyToMany
      { Name = RelationName "LoadGroup"
        TargetTable =
         { Name = TableName "LoadGroup"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadGroupId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "LoadGroupDsc"
                         IsNullable = false };
             Navigation { Type = TableName "Load"
                          Name = "Loads"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadGroup"
        KeyType = Byte }] }-LoadType-loader",
                            async ids => 
                            {
                                var data = await dbContext.LoadTypes
                                    .Where(x => x.LoadType != null && ids.Contains((byte)x.LoadType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.LoadType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.LoadType);
                });
            
			
                Field<LoadsControlPilotParameterGraphType, LoadsControlPilotParameter>("LoadsControlPilotParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LoadsControlPilotParameterGraphType>>(
                            "{ Name = EntityName "Load"
  CorrespondingTable =
   Regular
     { Name = TableName "Load"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "LoadId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "LoadDsc"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "LoadTypeId"
                      IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "LoadId"
      Type = Id Byte
      IsNullable = false }; { Name = "LoadDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "LoadsControl"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "IsSafetyRelevant"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CrossLoadDetail"
        TargetTable =
         { Name = TableName "CrossLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "CrossLoadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "OnDelayTime"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "OffDelayTime"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CouplesNum"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOnDisconnected"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOffDisconnected"
                         IsNullable = false };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CrossLoadType"
                          Name = "CrossLoadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadDetail"
        KeyType = Guid };
    OneToMany
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
    SingleManyToOne
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
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LoadsControlPilotParameter"
        TargetTable =
         { Name = TableName "LoadsControlPilotParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "ComplexLoadsNumber"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "LoadId0"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId6"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId6"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId7"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId7"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId8"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId9"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue9"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId9"
                         IsNullable = true };
             Navigation { Type = TableName "Load"
                          Name = "LoadId0Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId0Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "StmLoadsControl"
                          Name = "StmLoadsControls"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadsControlPilotParameter"
        KeyType = Guid };
    ManyToMany
      { Name = RelationName "LoadGroup"
        TargetTable =
         { Name = TableName "LoadGroup"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadGroupId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "LoadGroupDsc"
                         IsNullable = false };
             Navigation { Type = TableName "Load"
                          Name = "Loads"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadGroup"
        KeyType = Byte }] }-LoadsControlPilotParameter-loader",
                            async ids => 
                            {
                                var data = await dbContext.LoadsControlPilotParameters
                                    .Where(x => x.LoadsControlPilotParameter != null && ids.Contains((Guid)x.LoadsControlPilotParameter))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.LoadsControlPilotParameter!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.LoadsControlPilotParameters);
                    });
            
			
                Field<LoadGroupGraphType, LoadGroup>("LoadGroups")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, LoadGroupGraphType>(
                            "{ Name = EntityName "Load"
  CorrespondingTable =
   Regular
     { Name = TableName "Load"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "LoadId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "LoadDsc"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "LoadTypeId"
                      IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "LoadId"
      Type = Id Byte
      IsNullable = false }; { Name = "LoadDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "LoadsControl"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "IsSafetyRelevant"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CrossLoadDetail"
        TargetTable =
         { Name = TableName "CrossLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "CrossLoadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "OnDelayTime"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "OffDelayTime"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CouplesNum"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOnDisconnected"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOffDisconnected"
                         IsNullable = false };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CrossLoadType"
                          Name = "CrossLoadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadDetail"
        KeyType = Guid };
    OneToMany
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
    SingleManyToOne
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
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LoadsControlPilotParameter"
        TargetTable =
         { Name = TableName "LoadsControlPilotParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "ComplexLoadsNumber"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "LoadId0"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId6"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId6"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId7"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId7"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId8"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "LoadId9"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "LoadValue9"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "LoadModifierId9"
                         IsNullable = true };
             Navigation { Type = TableName "Load"
                          Name = "LoadId0Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "LoadId9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId0Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "LoadModifierId9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "StmLoadsControl"
                          Name = "StmLoadsControls"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadsControlPilotParameter"
        KeyType = Guid };
    ManyToMany
      { Name = RelationName "LoadGroup"
        TargetTable =
         { Name = TableName "LoadGroup"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadGroupId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "LoadGroupDsc"
                         IsNullable = false };
             Navigation { Type = TableName "Load"
                          Name = "Loads"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "LoadGroup"
        KeyType = Byte }] }-LoadGroup-loader",
                            async ids => 
                            {
                                var data = await dbContext.LoadGroups
                                    .Where(x => x.LoadGroup.Any(c => ids.Contains(c.LoadGroupId)))
                                    .Select(x => new
                                    {
                                        Key = x,
                                        Values = x.LoadGroup,
                                    })
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => x.Values.Select(v => new { Key = v.LoadGroupId, Value = x.Key }))
                                    .ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.LoadGroups);
                    });
            
        }
    }
}
            