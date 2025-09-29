
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
    public partial class UidataModelKeyMappingGraphType : ObjectGraphType<UidataModelKeyMapping>
    {
        public UidataModelKeyMappingGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UidataModelKeyMappingId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NItems, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FunctionLabelId0, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.KeyModifierId0, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.FunctionLabelId1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.KeyModifierId1, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.FunctionLabelId2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.KeyModifierId2, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.FunctionLabelId3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.KeyModifierId3, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.FunctionLabelId4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.KeyModifierId4, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.FunctionLabelId5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.KeyModifierId5, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.FunctionLabelId6, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.KeyModifierId6, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.FunctionLabelId7, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.KeyModifierId7, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.FunctionLabelId8, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.KeyModifierId8, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.FunctionLabelId9, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.KeyModifierId9, type: typeof(GuidGraphType), nullable: True);
            
                Field<ModifierGraphType, Modifier>("Modifiers")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ModifierGraphType>(
                            "{ Name = EntityName "UidataModelKeyMapping"
  CorrespondingTable =
   Regular
     { Name = TableName "UidataModelKeyMapping"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UidataModelKeyMappingId"
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
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "NItems"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "FunctionLabelId0"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId0"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId1"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId1"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId2"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId2"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId3"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId3"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId4"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId4"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId5"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId5"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId6"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId6"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId7"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId7"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId8"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId9"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId9"
                                                      IsNullable = true };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId0Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId1Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId2Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId3Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId4Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId5Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId6Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId7Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId8Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId9Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UidataModelTranslationDetail"
                      Name = "UidataModelTranslationDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "UidataModelKeyMappingId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true };
    { Name = "NItems"
      Type = Primitive Byte
      IsNullable = false }; { Name = "FunctionLabelId0"
                              Type = Primitive Byte
                              IsNullable = true }; { Name = "KeyModifierId0"
                                                     Type = Primitive Guid
                                                     IsNullable = true };
    { Name = "FunctionLabelId1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "KeyModifierId1"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "FunctionLabelId2"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "KeyModifierId2"
      Type = Primitive Guid
      IsNullable = true }; { Name = "FunctionLabelId3"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "KeyModifierId3"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "FunctionLabelId4"
      Type = Primitive Byte
      IsNullable = true }; { Name = "KeyModifierId4"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "FunctionLabelId5"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "KeyModifierId5"
      Type = Primitive Guid
      IsNullable = true }; { Name = "FunctionLabelId6"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "KeyModifierId6"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "FunctionLabelId7"
      Type = Primitive Byte
      IsNullable = true }; { Name = "KeyModifierId7"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "FunctionLabelId8"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "KeyModifierId8"
      Type = Primitive Guid
      IsNullable = true }; { Name = "FunctionLabelId9"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "KeyModifierId9"
                                                    Type = Primitive Guid
                                                    IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "KeyModifierId0Navigation";
          RelationName "KeyModifierId1Navigation";
          RelationName "KeyModifierId2Navigation";
          RelationName "KeyModifierId3Navigation";
          RelationName "KeyModifierId4Navigation";
          RelationName "KeyModifierId5Navigation";
          RelationName "KeyModifierId6Navigation";
          RelationName "KeyModifierId7Navigation";
          RelationName "KeyModifierId8Navigation";
          RelationName "KeyModifierId9Navigation"]
        TargetTable =
         { Name = TableName "Modifier"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ModifiersId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumModifiers"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "OverallOperationId"
                          IsNullable = false };
             Primitive { Type = Guid
                         Name = "ModifierDetails1"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "ModifierDetails2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "ModifierDetails3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "ModifierDetails4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "ModifierDetails5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "ModifierDetails6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "ModifierDetails7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "ModifierDetails8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ModifierType1"
                                                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierType2"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierType3"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierType4"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierType5"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierType6"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierType7"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierType8"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator1"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator2"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator3"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator4"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator5"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator6"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator7"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator8"
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
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId0Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId1Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId2Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId3Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId4Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId5Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId6Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId7Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId8Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId9Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails1Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierOperator1Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierOperator2Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierOperator3Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierOperator4Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierOperator7Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierOperator8Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType1Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType2Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType3Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType4Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType51"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierType5Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType61"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierType6Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType7Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType8Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "StmMaintain"
                          Name = "StmMaintains"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier9Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifierNavigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TimeEstimationDetail"
                          Name = "TimeEstimationDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TimeEstimation"
                          Name = "TimeEstimations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId0Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId1Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId2Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId3Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId4Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId5Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId6Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId7Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId8Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId9Navigations"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "Modifier"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UidataModelTranslationDetail"
        TargetTable =
         { Name = TableName "UidataModelTranslationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidataModelTranslationDetailId"
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
             Primitive { Type = Int
                         Name = "DataModelKeyValue"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DataModelType"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DataModelSubType"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UidataModelKeyMappingId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "DataModelNamespace"
                         IsNullable = true };
             Navigation { Type = TableName "UidataModelKeyMapping"
                          Name = "UidataModelKeyMapping"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName
                    "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
                 Name =
                  "UidataModelTranslationConfigurationsUidataModelTranslationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UidataModelTranslationDetail"
        KeyType = Guid }] }-Modifier-loader",
                            async ids => 
                            {
                                Expression<Func<Modifier, bool>> expr = x => !ids.Any()
                                    \|\| (x.KeyModifierId0Navigation != null && ids.Contains((Guid)x.KeyModifierId0Navigation))
\|\| (x.KeyModifierId1Navigation != null && ids.Contains((Guid)x.KeyModifierId1Navigation))
\|\| (x.KeyModifierId2Navigation != null && ids.Contains((Guid)x.KeyModifierId2Navigation))
\|\| (x.KeyModifierId3Navigation != null && ids.Contains((Guid)x.KeyModifierId3Navigation))
\|\| (x.KeyModifierId4Navigation != null && ids.Contains((Guid)x.KeyModifierId4Navigation))
\|\| (x.KeyModifierId5Navigation != null && ids.Contains((Guid)x.KeyModifierId5Navigation))
\|\| (x.KeyModifierId6Navigation != null && ids.Contains((Guid)x.KeyModifierId6Navigation))
\|\| (x.KeyModifierId7Navigation != null && ids.Contains((Guid)x.KeyModifierId7Navigation))
\|\| (x.KeyModifierId8Navigation != null && ids.Contains((Guid)x.KeyModifierId8Navigation))
\|\| (x.KeyModifierId9Navigation != null && ids.Contains((Guid)x.KeyModifierId9Navigation));

                                var data = await dbContext.Modifiers
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.KeyModifierId0Navigation,
x.KeyModifierId1Navigation,
x.KeyModifierId2Navigation,
x.KeyModifierId3Navigation,
x.KeyModifierId4Navigation,
x.KeyModifierId5Navigation,
x.KeyModifierId6Navigation,
x.KeyModifierId7Navigation,
x.KeyModifierId8Navigation,
x.KeyModifierId9Navigation
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.Modifiers);
                    });
            
			
                Field<UidataModelTranslationDetailGraphType, UidataModelTranslationDetail>("UidataModelTranslationDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UidataModelTranslationDetailGraphType>>(
                            "{ Name = EntityName "UidataModelKeyMapping"
  CorrespondingTable =
   Regular
     { Name = TableName "UidataModelKeyMapping"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UidataModelKeyMappingId"
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
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "NItems"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "FunctionLabelId0"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId0"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId1"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId1"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId2"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId2"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId3"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId3"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId4"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId4"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId5"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId5"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId6"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId6"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId7"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId7"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId8"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "FunctionLabelId9"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "KeyModifierId9"
                                                      IsNullable = true };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId0Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId1Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId2Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId3Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId4Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId5Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId6Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId7Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId8Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Modifier"
                      Name = "KeyModifierId9Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UidataModelTranslationDetail"
                      Name = "UidataModelTranslationDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "UidataModelKeyMappingId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true };
    { Name = "NItems"
      Type = Primitive Byte
      IsNullable = false }; { Name = "FunctionLabelId0"
                              Type = Primitive Byte
                              IsNullable = true }; { Name = "KeyModifierId0"
                                                     Type = Primitive Guid
                                                     IsNullable = true };
    { Name = "FunctionLabelId1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "KeyModifierId1"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "FunctionLabelId2"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "KeyModifierId2"
      Type = Primitive Guid
      IsNullable = true }; { Name = "FunctionLabelId3"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "KeyModifierId3"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "FunctionLabelId4"
      Type = Primitive Byte
      IsNullable = true }; { Name = "KeyModifierId4"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "FunctionLabelId5"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "KeyModifierId5"
      Type = Primitive Guid
      IsNullable = true }; { Name = "FunctionLabelId6"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "KeyModifierId6"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "FunctionLabelId7"
      Type = Primitive Byte
      IsNullable = true }; { Name = "KeyModifierId7"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "FunctionLabelId8"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "KeyModifierId8"
      Type = Primitive Guid
      IsNullable = true }; { Name = "FunctionLabelId9"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "KeyModifierId9"
                                                    Type = Primitive Guid
                                                    IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "KeyModifierId0Navigation";
          RelationName "KeyModifierId1Navigation";
          RelationName "KeyModifierId2Navigation";
          RelationName "KeyModifierId3Navigation";
          RelationName "KeyModifierId4Navigation";
          RelationName "KeyModifierId5Navigation";
          RelationName "KeyModifierId6Navigation";
          RelationName "KeyModifierId7Navigation";
          RelationName "KeyModifierId8Navigation";
          RelationName "KeyModifierId9Navigation"]
        TargetTable =
         { Name = TableName "Modifier"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ModifiersId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumModifiers"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "OverallOperationId"
                          IsNullable = false };
             Primitive { Type = Guid
                         Name = "ModifierDetails1"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "ModifierDetails2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "ModifierDetails3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "ModifierDetails4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "ModifierDetails5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "ModifierDetails6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "ModifierDetails7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "ModifierDetails8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ModifierType1"
                                                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierType2"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierType3"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierType4"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierType5"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierType6"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierType7"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierType8"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator1"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator2"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator3"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator4"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator5"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator6"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator7"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ModifierOperator8"
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
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId0Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId1Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId2Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId3Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId4Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId5Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId6Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId7Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId8Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "LoadsControlPilotParameter"
                 Name = "LoadsControlPilotParameterLoadModifierId9Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails1Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifierDetails8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierOperator1Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierOperator2Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierOperator3Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierOperator4Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierOperator7Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierOperator8Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType1Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType2Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType3Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType4Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType51"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierType5Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType61"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierOperator"
                          Name = "ModifierType6Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType7Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ModifierType"
                          Name = "ModifierType8Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "StmMaintain"
                          Name = "StmMaintains"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifier9Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariableModifierNavigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TimeEstimationDetail"
                          Name = "TimeEstimationDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TimeEstimation"
                          Name = "TimeEstimations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId0Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId1Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId2Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId3Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId4Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId5Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId6Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId7Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId8Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "UidataModelKeyMapping"
                 Name = "UidataModelKeyMappingKeyModifierId9Navigations"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "Modifier"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UidataModelTranslationDetail"
        TargetTable =
         { Name = TableName "UidataModelTranslationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidataModelTranslationDetailId"
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
             Primitive { Type = Int
                         Name = "DataModelKeyValue"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DataModelType"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DataModelSubType"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UidataModelKeyMappingId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "DataModelNamespace"
                         IsNullable = true };
             Navigation { Type = TableName "UidataModelKeyMapping"
                          Name = "UidataModelKeyMapping"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName
                    "UidataModelTranslationConfigurationsUidataModelTranslationDetail"
                 Name =
                  "UidataModelTranslationConfigurationsUidataModelTranslationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UidataModelTranslationDetail"
        KeyType = Guid }] }-UidataModelTranslationDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UidataModelTranslationDetails
                                    .Where(x => x.UidataModelTranslationDetail != null && ids.Contains((Guid)x.UidataModelTranslationDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UidataModelTranslationDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UidataModelTranslationDetails);
                    });
            
        }
    }
}
            