
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
    public partial class ModifierGraphType : ObjectGraphType<Modifier>
    {
        public ModifierGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ModifiersId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumModifiers, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierDetails1, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ModifierDetails2, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ModifierDetails3, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ModifierDetails4, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ModifierDetails5, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ModifierDetails6, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ModifierDetails7, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ModifierDetails8, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ModifierType1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierType2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierType3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierType4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierType5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierType6, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierType7, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierType8, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierOperator1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierOperator2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierOperator3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierOperator4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierOperator5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierOperator6, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierOperator7, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierOperator8, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<LoadsControlPilotParameterGraphType, LoadsControlPilotParameter>("LoadsControlPilotParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LoadsControlPilotParameterGraphType>>(
                            "{ Name = EntityName "Modifier"
  CorrespondingTable =
   Regular
     { Name = TableName "Modifier"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ModifiersId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumModifiers"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "OverallOperationId"
                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "ModifierDetails1"
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "ModifierDetails2"
                                                       IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails3"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails4"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails5"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails6"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails7"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "ModifierType1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType3"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType4"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType5"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType6"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType7"
                     IsNullable = false }; Primitive { Type = Byte
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
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId0Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId1Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId2Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId3Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId4Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId5Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId6Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId7Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId8Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId9Navigations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "ModifiersId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumModifiers"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierDetails1"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "ModifierDetails2"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails3"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails4"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails5"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails6"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails7"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails8"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierType1"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "ModifierType2"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "ModifierType3"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType4"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType5"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierType6"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType7"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType8"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator2"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator3"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator4"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator5"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator6"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator7"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator8"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }]
  Relations =
   [OneToMany
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
    MultipleManyToOne
      { Names =
         [RelationName "ModifierDetails1Navigation";
          RelationName "ModifierDetails2Navigation";
          RelationName "ModifierDetails3Navigation";
          RelationName "ModifierDetails4Navigation";
          RelationName "ModifierDetails5Navigation";
          RelationName "ModifierDetails6Navigation";
          RelationName "ModifierDetails7Navigation";
          RelationName "ModifierDetails8Navigation"]
        TargetTable =
         { Name = TableName "ModifiersDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ModifiersDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "NumItems"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ModifierSearchMethodId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsPercent"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "VariableGroupId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ModifierSearchMethod"
                          Name = "ModifierSearchMethod"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "ModifiersDetail"
        IsNullable = false
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierOperator1Navigation";
          RelationName "ModifierOperator2Navigation";
          RelationName "ModifierOperator3Navigation";
          RelationName "ModifierOperator4Navigation";
          RelationName "ModifierOperator7Navigation";
          RelationName "ModifierOperator8Navigation";
          RelationName "ModifierType5Navigation";
          RelationName "ModifierType6Navigation"]
        TargetTable =
         { Name = TableName "ModifierOperator"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierOperatorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierOperatorDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType6Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierOperator"
        IsNullable = false
        KeyType = Byte };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierType1Navigation";
          RelationName "ModifierType2Navigation";
          RelationName "ModifierType3Navigation";
          RelationName "ModifierType4Navigation"; RelationName "ModifierType51";
          RelationName "ModifierType61"; RelationName "ModifierType7Navigation";
          RelationName "ModifierType8Navigation"]
        TargetTable =
         { Name = TableName "ModifierType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierTypeDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType51s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType61s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType8Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "StmMaintain"
        TargetTable =
         { Name = TableName "StmMaintain"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "Time"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ModifiersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "IsAdd"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmMaintain"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmSetVariable"
        TargetTable =
         { Name = TableName "StmSetVariable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Operation"
                                                            IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Operand"
                                                           IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation1"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset1"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand1"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation2"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset2"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand2"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation3"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset3"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand3"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation4"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset4"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand4"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation5"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset5"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand5"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation6"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset6"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand6"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet6"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition6"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation7"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset7"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand7"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet7"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition7"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation8"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset8"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand8"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition8"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation9"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex9"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset9"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand9"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet9"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition9"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroups1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups9"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier1"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier3"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier4"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier5"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier6"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier7"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier8"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier9"
                         IsNullable = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ProductType"
                          Name = "ProductType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmSetVariable"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimationDetail"
        TargetTable =
         { Name = TableName "TimeEstimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifiersId"
                                                            IsNullable = true };
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
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "TimeEstimationConfigurationsTimeEstimationDetail"
                 Name = "TimeEstimationConfigurationsTimeEstimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "TimeEstimationDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimation"
        TargetTable =
         { Name = TableName "TimeEstimation"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Time"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "HasModifiers"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseDirectModifier"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifierId"
                                                            IsNullable = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "TimeEstimation"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UidataModelKeyMapping"
        TargetTable =
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
                         Name = "NItems"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionLabelId0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId0"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId9"
                         IsNullable = true };
             Primitive { Type = Guid
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
        Destination = EntityName "UidataModelKeyMapping"
        KeyType = Guid }] }-LoadsControlPilotParameter-loader",
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
            
			
                Field<ModifiersDetailGraphType, ModifiersDetail>("ModifiersDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ModifiersDetailGraphType>(
                            "{ Name = EntityName "Modifier"
  CorrespondingTable =
   Regular
     { Name = TableName "Modifier"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ModifiersId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumModifiers"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "OverallOperationId"
                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "ModifierDetails1"
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "ModifierDetails2"
                                                       IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails3"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails4"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails5"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails6"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails7"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "ModifierType1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType3"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType4"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType5"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType6"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType7"
                     IsNullable = false }; Primitive { Type = Byte
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
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId0Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId1Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId2Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId3Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId4Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId5Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId6Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId7Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId8Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId9Navigations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "ModifiersId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumModifiers"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierDetails1"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "ModifierDetails2"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails3"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails4"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails5"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails6"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails7"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails8"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierType1"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "ModifierType2"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "ModifierType3"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType4"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType5"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierType6"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType7"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType8"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator2"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator3"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator4"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator5"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator6"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator7"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator8"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }]
  Relations =
   [OneToMany
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
    MultipleManyToOne
      { Names =
         [RelationName "ModifierDetails1Navigation";
          RelationName "ModifierDetails2Navigation";
          RelationName "ModifierDetails3Navigation";
          RelationName "ModifierDetails4Navigation";
          RelationName "ModifierDetails5Navigation";
          RelationName "ModifierDetails6Navigation";
          RelationName "ModifierDetails7Navigation";
          RelationName "ModifierDetails8Navigation"]
        TargetTable =
         { Name = TableName "ModifiersDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ModifiersDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "NumItems"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ModifierSearchMethodId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsPercent"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "VariableGroupId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ModifierSearchMethod"
                          Name = "ModifierSearchMethod"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "ModifiersDetail"
        IsNullable = false
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierOperator1Navigation";
          RelationName "ModifierOperator2Navigation";
          RelationName "ModifierOperator3Navigation";
          RelationName "ModifierOperator4Navigation";
          RelationName "ModifierOperator7Navigation";
          RelationName "ModifierOperator8Navigation";
          RelationName "ModifierType5Navigation";
          RelationName "ModifierType6Navigation"]
        TargetTable =
         { Name = TableName "ModifierOperator"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierOperatorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierOperatorDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType6Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierOperator"
        IsNullable = false
        KeyType = Byte };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierType1Navigation";
          RelationName "ModifierType2Navigation";
          RelationName "ModifierType3Navigation";
          RelationName "ModifierType4Navigation"; RelationName "ModifierType51";
          RelationName "ModifierType61"; RelationName "ModifierType7Navigation";
          RelationName "ModifierType8Navigation"]
        TargetTable =
         { Name = TableName "ModifierType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierTypeDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType51s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType61s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType8Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "StmMaintain"
        TargetTable =
         { Name = TableName "StmMaintain"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "Time"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ModifiersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "IsAdd"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmMaintain"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmSetVariable"
        TargetTable =
         { Name = TableName "StmSetVariable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Operation"
                                                            IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Operand"
                                                           IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation1"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset1"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand1"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation2"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset2"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand2"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation3"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset3"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand3"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation4"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset4"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand4"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation5"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset5"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand5"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation6"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset6"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand6"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet6"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition6"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation7"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset7"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand7"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet7"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition7"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation8"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset8"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand8"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition8"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation9"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex9"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset9"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand9"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet9"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition9"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroups1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups9"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier1"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier3"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier4"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier5"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier6"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier7"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier8"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier9"
                         IsNullable = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ProductType"
                          Name = "ProductType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmSetVariable"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimationDetail"
        TargetTable =
         { Name = TableName "TimeEstimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifiersId"
                                                            IsNullable = true };
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
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "TimeEstimationConfigurationsTimeEstimationDetail"
                 Name = "TimeEstimationConfigurationsTimeEstimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "TimeEstimationDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimation"
        TargetTable =
         { Name = TableName "TimeEstimation"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Time"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "HasModifiers"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseDirectModifier"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifierId"
                                                            IsNullable = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "TimeEstimation"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UidataModelKeyMapping"
        TargetTable =
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
                         Name = "NItems"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionLabelId0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId0"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId9"
                         IsNullable = true };
             Primitive { Type = Guid
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
        Destination = EntityName "UidataModelKeyMapping"
        KeyType = Guid }] }-ModifiersDetail-loader",
                            async ids => 
                            {
                                Expression<Func<ModifiersDetail, bool>> expr = x => !ids.Any()
                                    \|\| (x.ModifierDetails1Navigation != null && ids.Contains((Guid)x.ModifierDetails1Navigation))
\|\| (x.ModifierDetails2Navigation != null && ids.Contains((Guid)x.ModifierDetails2Navigation))
\|\| (x.ModifierDetails3Navigation != null && ids.Contains((Guid)x.ModifierDetails3Navigation))
\|\| (x.ModifierDetails4Navigation != null && ids.Contains((Guid)x.ModifierDetails4Navigation))
\|\| (x.ModifierDetails5Navigation != null && ids.Contains((Guid)x.ModifierDetails5Navigation))
\|\| (x.ModifierDetails6Navigation != null && ids.Contains((Guid)x.ModifierDetails6Navigation))
\|\| (x.ModifierDetails7Navigation != null && ids.Contains((Guid)x.ModifierDetails7Navigation))
\|\| (x.ModifierDetails8Navigation != null && ids.Contains((Guid)x.ModifierDetails8Navigation));

                                var data = await dbContext.ModifiersDetails
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.ModifierDetails1Navigation,
x.ModifierDetails2Navigation,
x.ModifierDetails3Navigation,
x.ModifierDetails4Navigation,
x.ModifierDetails5Navigation,
x.ModifierDetails6Navigation,
x.ModifierDetails7Navigation,
x.ModifierDetails8Navigation
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.ModifiersDetails);
                    });
            
			
                Field<ModifierOperatorGraphType, ModifierOperator>("ModifierOperators")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ModifierOperatorGraphType>(
                            "{ Name = EntityName "Modifier"
  CorrespondingTable =
   Regular
     { Name = TableName "Modifier"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ModifiersId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumModifiers"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "OverallOperationId"
                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "ModifierDetails1"
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "ModifierDetails2"
                                                       IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails3"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails4"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails5"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails6"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails7"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "ModifierType1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType3"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType4"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType5"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType6"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType7"
                     IsNullable = false }; Primitive { Type = Byte
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
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId0Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId1Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId2Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId3Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId4Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId5Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId6Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId7Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId8Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId9Navigations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "ModifiersId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumModifiers"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierDetails1"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "ModifierDetails2"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails3"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails4"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails5"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails6"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails7"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails8"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierType1"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "ModifierType2"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "ModifierType3"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType4"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType5"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierType6"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType7"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType8"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator2"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator3"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator4"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator5"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator6"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator7"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator8"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }]
  Relations =
   [OneToMany
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
    MultipleManyToOne
      { Names =
         [RelationName "ModifierDetails1Navigation";
          RelationName "ModifierDetails2Navigation";
          RelationName "ModifierDetails3Navigation";
          RelationName "ModifierDetails4Navigation";
          RelationName "ModifierDetails5Navigation";
          RelationName "ModifierDetails6Navigation";
          RelationName "ModifierDetails7Navigation";
          RelationName "ModifierDetails8Navigation"]
        TargetTable =
         { Name = TableName "ModifiersDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ModifiersDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "NumItems"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ModifierSearchMethodId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsPercent"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "VariableGroupId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ModifierSearchMethod"
                          Name = "ModifierSearchMethod"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "ModifiersDetail"
        IsNullable = false
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierOperator1Navigation";
          RelationName "ModifierOperator2Navigation";
          RelationName "ModifierOperator3Navigation";
          RelationName "ModifierOperator4Navigation";
          RelationName "ModifierOperator7Navigation";
          RelationName "ModifierOperator8Navigation";
          RelationName "ModifierType5Navigation";
          RelationName "ModifierType6Navigation"]
        TargetTable =
         { Name = TableName "ModifierOperator"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierOperatorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierOperatorDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType6Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierOperator"
        IsNullable = false
        KeyType = Byte };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierType1Navigation";
          RelationName "ModifierType2Navigation";
          RelationName "ModifierType3Navigation";
          RelationName "ModifierType4Navigation"; RelationName "ModifierType51";
          RelationName "ModifierType61"; RelationName "ModifierType7Navigation";
          RelationName "ModifierType8Navigation"]
        TargetTable =
         { Name = TableName "ModifierType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierTypeDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType51s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType61s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType8Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "StmMaintain"
        TargetTable =
         { Name = TableName "StmMaintain"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "Time"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ModifiersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "IsAdd"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmMaintain"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmSetVariable"
        TargetTable =
         { Name = TableName "StmSetVariable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Operation"
                                                            IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Operand"
                                                           IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation1"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset1"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand1"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation2"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset2"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand2"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation3"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset3"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand3"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation4"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset4"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand4"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation5"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset5"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand5"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation6"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset6"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand6"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet6"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition6"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation7"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset7"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand7"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet7"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition7"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation8"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset8"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand8"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition8"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation9"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex9"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset9"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand9"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet9"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition9"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroups1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups9"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier1"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier3"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier4"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier5"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier6"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier7"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier8"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier9"
                         IsNullable = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ProductType"
                          Name = "ProductType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmSetVariable"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimationDetail"
        TargetTable =
         { Name = TableName "TimeEstimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifiersId"
                                                            IsNullable = true };
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
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "TimeEstimationConfigurationsTimeEstimationDetail"
                 Name = "TimeEstimationConfigurationsTimeEstimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "TimeEstimationDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimation"
        TargetTable =
         { Name = TableName "TimeEstimation"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Time"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "HasModifiers"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseDirectModifier"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifierId"
                                                            IsNullable = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "TimeEstimation"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UidataModelKeyMapping"
        TargetTable =
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
                         Name = "NItems"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionLabelId0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId0"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId9"
                         IsNullable = true };
             Primitive { Type = Guid
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
        Destination = EntityName "UidataModelKeyMapping"
        KeyType = Guid }] }-ModifierOperator-loader",
                            async ids => 
                            {
                                Expression<Func<ModifierOperator, bool>> expr = x => !ids.Any()
                                    \|\| (x.ModifierOperator1Navigation != null && ids.Contains((byte)x.ModifierOperator1Navigation))
\|\| (x.ModifierOperator2Navigation != null && ids.Contains((byte)x.ModifierOperator2Navigation))
\|\| (x.ModifierOperator3Navigation != null && ids.Contains((byte)x.ModifierOperator3Navigation))
\|\| (x.ModifierOperator4Navigation != null && ids.Contains((byte)x.ModifierOperator4Navigation))
\|\| (x.ModifierOperator7Navigation != null && ids.Contains((byte)x.ModifierOperator7Navigation))
\|\| (x.ModifierOperator8Navigation != null && ids.Contains((byte)x.ModifierOperator8Navigation))
\|\| (x.ModifierType5Navigation != null && ids.Contains((byte)x.ModifierType5Navigation))
\|\| (x.ModifierType6Navigation != null && ids.Contains((byte)x.ModifierType6Navigation));

                                var data = await dbContext.ModifierOperators
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<byte?>()
                                    {
                                        x.ModifierOperator1Navigation,
x.ModifierOperator2Navigation,
x.ModifierOperator3Navigation,
x.ModifierOperator4Navigation,
x.ModifierOperator7Navigation,
x.ModifierOperator8Navigation,
x.ModifierType5Navigation,
x.ModifierType6Navigation
                                    }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.ModifierOperators);
                    });
            
			
                Field<ModifierTypeGraphType, ModifierType>("ModifierTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ModifierTypeGraphType>(
                            "{ Name = EntityName "Modifier"
  CorrespondingTable =
   Regular
     { Name = TableName "Modifier"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ModifiersId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumModifiers"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "OverallOperationId"
                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "ModifierDetails1"
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "ModifierDetails2"
                                                       IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails3"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails4"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails5"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails6"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails7"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "ModifierType1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType3"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType4"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType5"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType6"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType7"
                     IsNullable = false }; Primitive { Type = Byte
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
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId0Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId1Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId2Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId3Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId4Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId5Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId6Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId7Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId8Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId9Navigations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "ModifiersId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumModifiers"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierDetails1"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "ModifierDetails2"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails3"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails4"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails5"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails6"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails7"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails8"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierType1"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "ModifierType2"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "ModifierType3"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType4"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType5"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierType6"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType7"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType8"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator2"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator3"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator4"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator5"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator6"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator7"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator8"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }]
  Relations =
   [OneToMany
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
    MultipleManyToOne
      { Names =
         [RelationName "ModifierDetails1Navigation";
          RelationName "ModifierDetails2Navigation";
          RelationName "ModifierDetails3Navigation";
          RelationName "ModifierDetails4Navigation";
          RelationName "ModifierDetails5Navigation";
          RelationName "ModifierDetails6Navigation";
          RelationName "ModifierDetails7Navigation";
          RelationName "ModifierDetails8Navigation"]
        TargetTable =
         { Name = TableName "ModifiersDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ModifiersDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "NumItems"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ModifierSearchMethodId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsPercent"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "VariableGroupId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ModifierSearchMethod"
                          Name = "ModifierSearchMethod"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "ModifiersDetail"
        IsNullable = false
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierOperator1Navigation";
          RelationName "ModifierOperator2Navigation";
          RelationName "ModifierOperator3Navigation";
          RelationName "ModifierOperator4Navigation";
          RelationName "ModifierOperator7Navigation";
          RelationName "ModifierOperator8Navigation";
          RelationName "ModifierType5Navigation";
          RelationName "ModifierType6Navigation"]
        TargetTable =
         { Name = TableName "ModifierOperator"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierOperatorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierOperatorDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType6Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierOperator"
        IsNullable = false
        KeyType = Byte };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierType1Navigation";
          RelationName "ModifierType2Navigation";
          RelationName "ModifierType3Navigation";
          RelationName "ModifierType4Navigation"; RelationName "ModifierType51";
          RelationName "ModifierType61"; RelationName "ModifierType7Navigation";
          RelationName "ModifierType8Navigation"]
        TargetTable =
         { Name = TableName "ModifierType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierTypeDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType51s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType61s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType8Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "StmMaintain"
        TargetTable =
         { Name = TableName "StmMaintain"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "Time"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ModifiersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "IsAdd"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmMaintain"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmSetVariable"
        TargetTable =
         { Name = TableName "StmSetVariable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Operation"
                                                            IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Operand"
                                                           IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation1"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset1"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand1"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation2"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset2"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand2"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation3"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset3"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand3"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation4"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset4"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand4"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation5"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset5"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand5"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation6"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset6"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand6"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet6"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition6"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation7"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset7"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand7"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet7"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition7"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation8"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset8"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand8"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition8"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation9"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex9"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset9"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand9"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet9"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition9"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroups1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups9"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier1"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier3"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier4"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier5"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier6"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier7"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier8"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier9"
                         IsNullable = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ProductType"
                          Name = "ProductType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmSetVariable"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimationDetail"
        TargetTable =
         { Name = TableName "TimeEstimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifiersId"
                                                            IsNullable = true };
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
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "TimeEstimationConfigurationsTimeEstimationDetail"
                 Name = "TimeEstimationConfigurationsTimeEstimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "TimeEstimationDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimation"
        TargetTable =
         { Name = TableName "TimeEstimation"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Time"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "HasModifiers"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseDirectModifier"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifierId"
                                                            IsNullable = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "TimeEstimation"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UidataModelKeyMapping"
        TargetTable =
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
                         Name = "NItems"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionLabelId0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId0"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId9"
                         IsNullable = true };
             Primitive { Type = Guid
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
        Destination = EntityName "UidataModelKeyMapping"
        KeyType = Guid }] }-ModifierType-loader",
                            async ids => 
                            {
                                Expression<Func<ModifierType, bool>> expr = x => !ids.Any()
                                    \|\| (x.ModifierType1Navigation != null && ids.Contains((byte)x.ModifierType1Navigation))
\|\| (x.ModifierType2Navigation != null && ids.Contains((byte)x.ModifierType2Navigation))
\|\| (x.ModifierType3Navigation != null && ids.Contains((byte)x.ModifierType3Navigation))
\|\| (x.ModifierType4Navigation != null && ids.Contains((byte)x.ModifierType4Navigation))
\|\| (x.ModifierType51 != null && ids.Contains((byte)x.ModifierType51))
\|\| (x.ModifierType61 != null && ids.Contains((byte)x.ModifierType61))
\|\| (x.ModifierType7Navigation != null && ids.Contains((byte)x.ModifierType7Navigation))
\|\| (x.ModifierType8Navigation != null && ids.Contains((byte)x.ModifierType8Navigation));

                                var data = await dbContext.ModifierTypes
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<byte?>()
                                    {
                                        x.ModifierType1Navigation,
x.ModifierType2Navigation,
x.ModifierType3Navigation,
x.ModifierType4Navigation,
x.ModifierType51,
x.ModifierType61,
x.ModifierType7Navigation,
x.ModifierType8Navigation
                                    }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.ModifierTypes);
                    });
            
			
                Field<StmMaintainGraphType, StmMaintain>("StmMaintains")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmMaintainGraphType>>(
                            "{ Name = EntityName "Modifier"
  CorrespondingTable =
   Regular
     { Name = TableName "Modifier"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ModifiersId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumModifiers"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "OverallOperationId"
                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "ModifierDetails1"
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "ModifierDetails2"
                                                       IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails3"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails4"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails5"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails6"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails7"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "ModifierType1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType3"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType4"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType5"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType6"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType7"
                     IsNullable = false }; Primitive { Type = Byte
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
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId0Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId1Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId2Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId3Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId4Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId5Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId6Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId7Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId8Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId9Navigations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "ModifiersId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumModifiers"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierDetails1"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "ModifierDetails2"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails3"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails4"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails5"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails6"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails7"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails8"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierType1"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "ModifierType2"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "ModifierType3"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType4"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType5"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierType6"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType7"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType8"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator2"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator3"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator4"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator5"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator6"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator7"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator8"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }]
  Relations =
   [OneToMany
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
    MultipleManyToOne
      { Names =
         [RelationName "ModifierDetails1Navigation";
          RelationName "ModifierDetails2Navigation";
          RelationName "ModifierDetails3Navigation";
          RelationName "ModifierDetails4Navigation";
          RelationName "ModifierDetails5Navigation";
          RelationName "ModifierDetails6Navigation";
          RelationName "ModifierDetails7Navigation";
          RelationName "ModifierDetails8Navigation"]
        TargetTable =
         { Name = TableName "ModifiersDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ModifiersDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "NumItems"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ModifierSearchMethodId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsPercent"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "VariableGroupId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ModifierSearchMethod"
                          Name = "ModifierSearchMethod"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "ModifiersDetail"
        IsNullable = false
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierOperator1Navigation";
          RelationName "ModifierOperator2Navigation";
          RelationName "ModifierOperator3Navigation";
          RelationName "ModifierOperator4Navigation";
          RelationName "ModifierOperator7Navigation";
          RelationName "ModifierOperator8Navigation";
          RelationName "ModifierType5Navigation";
          RelationName "ModifierType6Navigation"]
        TargetTable =
         { Name = TableName "ModifierOperator"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierOperatorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierOperatorDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType6Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierOperator"
        IsNullable = false
        KeyType = Byte };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierType1Navigation";
          RelationName "ModifierType2Navigation";
          RelationName "ModifierType3Navigation";
          RelationName "ModifierType4Navigation"; RelationName "ModifierType51";
          RelationName "ModifierType61"; RelationName "ModifierType7Navigation";
          RelationName "ModifierType8Navigation"]
        TargetTable =
         { Name = TableName "ModifierType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierTypeDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType51s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType61s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType8Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "StmMaintain"
        TargetTable =
         { Name = TableName "StmMaintain"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "Time"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ModifiersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "IsAdd"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmMaintain"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmSetVariable"
        TargetTable =
         { Name = TableName "StmSetVariable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Operation"
                                                            IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Operand"
                                                           IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation1"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset1"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand1"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation2"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset2"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand2"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation3"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset3"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand3"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation4"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset4"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand4"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation5"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset5"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand5"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation6"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset6"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand6"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet6"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition6"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation7"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset7"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand7"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet7"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition7"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation8"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset8"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand8"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition8"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation9"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex9"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset9"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand9"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet9"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition9"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroups1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups9"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier1"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier3"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier4"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier5"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier6"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier7"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier8"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier9"
                         IsNullable = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ProductType"
                          Name = "ProductType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmSetVariable"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimationDetail"
        TargetTable =
         { Name = TableName "TimeEstimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifiersId"
                                                            IsNullable = true };
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
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "TimeEstimationConfigurationsTimeEstimationDetail"
                 Name = "TimeEstimationConfigurationsTimeEstimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "TimeEstimationDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimation"
        TargetTable =
         { Name = TableName "TimeEstimation"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Time"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "HasModifiers"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseDirectModifier"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifierId"
                                                            IsNullable = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "TimeEstimation"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UidataModelKeyMapping"
        TargetTable =
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
                         Name = "NItems"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionLabelId0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId0"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId9"
                         IsNullable = true };
             Primitive { Type = Guid
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
        Destination = EntityName "UidataModelKeyMapping"
        KeyType = Guid }] }-StmMaintain-loader",
                            async ids => 
                            {
                                var data = await dbContext.StmMaintains
                                    .Where(x => x.StmMaintain != null && ids.Contains((Guid)x.StmMaintain))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.StmMaintain!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.StmMaintains);
                    });
            
			
                Field<StmSetVariableGraphType, StmSetVariable>("StmSetVariables")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmSetVariableGraphType>>(
                            "{ Name = EntityName "Modifier"
  CorrespondingTable =
   Regular
     { Name = TableName "Modifier"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ModifiersId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumModifiers"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "OverallOperationId"
                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "ModifierDetails1"
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "ModifierDetails2"
                                                       IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails3"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails4"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails5"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails6"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails7"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "ModifierType1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType3"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType4"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType5"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType6"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType7"
                     IsNullable = false }; Primitive { Type = Byte
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
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId0Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId1Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId2Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId3Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId4Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId5Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId6Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId7Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId8Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId9Navigations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "ModifiersId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumModifiers"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierDetails1"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "ModifierDetails2"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails3"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails4"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails5"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails6"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails7"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails8"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierType1"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "ModifierType2"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "ModifierType3"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType4"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType5"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierType6"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType7"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType8"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator2"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator3"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator4"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator5"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator6"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator7"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator8"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }]
  Relations =
   [OneToMany
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
    MultipleManyToOne
      { Names =
         [RelationName "ModifierDetails1Navigation";
          RelationName "ModifierDetails2Navigation";
          RelationName "ModifierDetails3Navigation";
          RelationName "ModifierDetails4Navigation";
          RelationName "ModifierDetails5Navigation";
          RelationName "ModifierDetails6Navigation";
          RelationName "ModifierDetails7Navigation";
          RelationName "ModifierDetails8Navigation"]
        TargetTable =
         { Name = TableName "ModifiersDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ModifiersDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "NumItems"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ModifierSearchMethodId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsPercent"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "VariableGroupId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ModifierSearchMethod"
                          Name = "ModifierSearchMethod"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "ModifiersDetail"
        IsNullable = false
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierOperator1Navigation";
          RelationName "ModifierOperator2Navigation";
          RelationName "ModifierOperator3Navigation";
          RelationName "ModifierOperator4Navigation";
          RelationName "ModifierOperator7Navigation";
          RelationName "ModifierOperator8Navigation";
          RelationName "ModifierType5Navigation";
          RelationName "ModifierType6Navigation"]
        TargetTable =
         { Name = TableName "ModifierOperator"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierOperatorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierOperatorDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType6Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierOperator"
        IsNullable = false
        KeyType = Byte };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierType1Navigation";
          RelationName "ModifierType2Navigation";
          RelationName "ModifierType3Navigation";
          RelationName "ModifierType4Navigation"; RelationName "ModifierType51";
          RelationName "ModifierType61"; RelationName "ModifierType7Navigation";
          RelationName "ModifierType8Navigation"]
        TargetTable =
         { Name = TableName "ModifierType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierTypeDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType51s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType61s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType8Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "StmMaintain"
        TargetTable =
         { Name = TableName "StmMaintain"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "Time"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ModifiersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "IsAdd"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmMaintain"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmSetVariable"
        TargetTable =
         { Name = TableName "StmSetVariable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Operation"
                                                            IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Operand"
                                                           IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation1"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset1"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand1"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation2"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset2"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand2"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation3"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset3"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand3"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation4"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset4"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand4"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation5"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset5"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand5"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation6"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset6"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand6"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet6"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition6"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation7"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset7"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand7"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet7"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition7"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation8"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset8"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand8"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition8"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation9"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex9"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset9"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand9"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet9"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition9"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroups1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups9"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier1"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier3"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier4"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier5"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier6"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier7"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier8"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier9"
                         IsNullable = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ProductType"
                          Name = "ProductType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmSetVariable"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimationDetail"
        TargetTable =
         { Name = TableName "TimeEstimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifiersId"
                                                            IsNullable = true };
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
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "TimeEstimationConfigurationsTimeEstimationDetail"
                 Name = "TimeEstimationConfigurationsTimeEstimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "TimeEstimationDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimation"
        TargetTable =
         { Name = TableName "TimeEstimation"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Time"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "HasModifiers"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseDirectModifier"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifierId"
                                                            IsNullable = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "TimeEstimation"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UidataModelKeyMapping"
        TargetTable =
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
                         Name = "NItems"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionLabelId0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId0"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId9"
                         IsNullable = true };
             Primitive { Type = Guid
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
        Destination = EntityName "UidataModelKeyMapping"
        KeyType = Guid }] }-StmSetVariable-loader",
                            async ids => 
                            {
                                var data = await dbContext.StmSetVariables
                                    .Where(x => x.StmSetVariable != null && ids.Contains((Guid)x.StmSetVariable))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.StmSetVariable!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.StmSetVariables);
                    });
            
			
                Field<TimeEstimationDetailGraphType, TimeEstimationDetail>("TimeEstimationDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<TimeEstimationDetailGraphType>>(
                            "{ Name = EntityName "Modifier"
  CorrespondingTable =
   Regular
     { Name = TableName "Modifier"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ModifiersId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumModifiers"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "OverallOperationId"
                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "ModifierDetails1"
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "ModifierDetails2"
                                                       IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails3"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails4"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails5"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails6"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails7"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "ModifierType1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType3"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType4"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType5"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType6"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType7"
                     IsNullable = false }; Primitive { Type = Byte
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
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId0Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId1Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId2Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId3Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId4Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId5Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId6Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId7Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId8Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId9Navigations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "ModifiersId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumModifiers"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierDetails1"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "ModifierDetails2"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails3"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails4"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails5"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails6"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails7"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails8"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierType1"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "ModifierType2"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "ModifierType3"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType4"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType5"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierType6"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType7"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType8"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator2"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator3"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator4"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator5"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator6"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator7"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator8"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }]
  Relations =
   [OneToMany
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
    MultipleManyToOne
      { Names =
         [RelationName "ModifierDetails1Navigation";
          RelationName "ModifierDetails2Navigation";
          RelationName "ModifierDetails3Navigation";
          RelationName "ModifierDetails4Navigation";
          RelationName "ModifierDetails5Navigation";
          RelationName "ModifierDetails6Navigation";
          RelationName "ModifierDetails7Navigation";
          RelationName "ModifierDetails8Navigation"]
        TargetTable =
         { Name = TableName "ModifiersDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ModifiersDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "NumItems"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ModifierSearchMethodId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsPercent"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "VariableGroupId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ModifierSearchMethod"
                          Name = "ModifierSearchMethod"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "ModifiersDetail"
        IsNullable = false
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierOperator1Navigation";
          RelationName "ModifierOperator2Navigation";
          RelationName "ModifierOperator3Navigation";
          RelationName "ModifierOperator4Navigation";
          RelationName "ModifierOperator7Navigation";
          RelationName "ModifierOperator8Navigation";
          RelationName "ModifierType5Navigation";
          RelationName "ModifierType6Navigation"]
        TargetTable =
         { Name = TableName "ModifierOperator"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierOperatorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierOperatorDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType6Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierOperator"
        IsNullable = false
        KeyType = Byte };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierType1Navigation";
          RelationName "ModifierType2Navigation";
          RelationName "ModifierType3Navigation";
          RelationName "ModifierType4Navigation"; RelationName "ModifierType51";
          RelationName "ModifierType61"; RelationName "ModifierType7Navigation";
          RelationName "ModifierType8Navigation"]
        TargetTable =
         { Name = TableName "ModifierType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierTypeDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType51s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType61s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType8Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "StmMaintain"
        TargetTable =
         { Name = TableName "StmMaintain"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "Time"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ModifiersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "IsAdd"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmMaintain"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmSetVariable"
        TargetTable =
         { Name = TableName "StmSetVariable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Operation"
                                                            IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Operand"
                                                           IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation1"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset1"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand1"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation2"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset2"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand2"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation3"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset3"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand3"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation4"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset4"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand4"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation5"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset5"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand5"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation6"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset6"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand6"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet6"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition6"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation7"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset7"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand7"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet7"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition7"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation8"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset8"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand8"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition8"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation9"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex9"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset9"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand9"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet9"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition9"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroups1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups9"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier1"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier3"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier4"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier5"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier6"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier7"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier8"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier9"
                         IsNullable = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ProductType"
                          Name = "ProductType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmSetVariable"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimationDetail"
        TargetTable =
         { Name = TableName "TimeEstimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifiersId"
                                                            IsNullable = true };
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
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "TimeEstimationConfigurationsTimeEstimationDetail"
                 Name = "TimeEstimationConfigurationsTimeEstimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "TimeEstimationDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimation"
        TargetTable =
         { Name = TableName "TimeEstimation"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Time"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "HasModifiers"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseDirectModifier"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifierId"
                                                            IsNullable = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "TimeEstimation"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UidataModelKeyMapping"
        TargetTable =
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
                         Name = "NItems"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionLabelId0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId0"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId9"
                         IsNullable = true };
             Primitive { Type = Guid
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
        Destination = EntityName "UidataModelKeyMapping"
        KeyType = Guid }] }-TimeEstimationDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.TimeEstimationDetails
                                    .Where(x => x.TimeEstimationDetail != null && ids.Contains((Guid)x.TimeEstimationDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.TimeEstimationDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.TimeEstimationDetails);
                    });
            
			
                Field<TimeEstimationGraphType, TimeEstimation>("TimeEstimations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<TimeEstimationGraphType>>(
                            "{ Name = EntityName "Modifier"
  CorrespondingTable =
   Regular
     { Name = TableName "Modifier"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ModifiersId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumModifiers"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "OverallOperationId"
                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "ModifierDetails1"
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "ModifierDetails2"
                                                       IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails3"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails4"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails5"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails6"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails7"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "ModifierType1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType3"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType4"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType5"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType6"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType7"
                     IsNullable = false }; Primitive { Type = Byte
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
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId0Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId1Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId2Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId3Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId4Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId5Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId6Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId7Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId8Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId9Navigations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "ModifiersId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumModifiers"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierDetails1"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "ModifierDetails2"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails3"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails4"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails5"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails6"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails7"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails8"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierType1"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "ModifierType2"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "ModifierType3"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType4"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType5"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierType6"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType7"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType8"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator2"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator3"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator4"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator5"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator6"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator7"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator8"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }]
  Relations =
   [OneToMany
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
    MultipleManyToOne
      { Names =
         [RelationName "ModifierDetails1Navigation";
          RelationName "ModifierDetails2Navigation";
          RelationName "ModifierDetails3Navigation";
          RelationName "ModifierDetails4Navigation";
          RelationName "ModifierDetails5Navigation";
          RelationName "ModifierDetails6Navigation";
          RelationName "ModifierDetails7Navigation";
          RelationName "ModifierDetails8Navigation"]
        TargetTable =
         { Name = TableName "ModifiersDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ModifiersDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "NumItems"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ModifierSearchMethodId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsPercent"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "VariableGroupId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ModifierSearchMethod"
                          Name = "ModifierSearchMethod"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "ModifiersDetail"
        IsNullable = false
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierOperator1Navigation";
          RelationName "ModifierOperator2Navigation";
          RelationName "ModifierOperator3Navigation";
          RelationName "ModifierOperator4Navigation";
          RelationName "ModifierOperator7Navigation";
          RelationName "ModifierOperator8Navigation";
          RelationName "ModifierType5Navigation";
          RelationName "ModifierType6Navigation"]
        TargetTable =
         { Name = TableName "ModifierOperator"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierOperatorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierOperatorDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType6Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierOperator"
        IsNullable = false
        KeyType = Byte };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierType1Navigation";
          RelationName "ModifierType2Navigation";
          RelationName "ModifierType3Navigation";
          RelationName "ModifierType4Navigation"; RelationName "ModifierType51";
          RelationName "ModifierType61"; RelationName "ModifierType7Navigation";
          RelationName "ModifierType8Navigation"]
        TargetTable =
         { Name = TableName "ModifierType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierTypeDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType51s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType61s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType8Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "StmMaintain"
        TargetTable =
         { Name = TableName "StmMaintain"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "Time"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ModifiersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "IsAdd"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmMaintain"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmSetVariable"
        TargetTable =
         { Name = TableName "StmSetVariable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Operation"
                                                            IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Operand"
                                                           IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation1"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset1"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand1"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation2"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset2"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand2"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation3"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset3"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand3"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation4"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset4"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand4"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation5"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset5"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand5"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation6"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset6"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand6"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet6"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition6"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation7"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset7"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand7"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet7"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition7"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation8"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset8"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand8"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition8"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation9"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex9"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset9"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand9"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet9"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition9"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroups1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups9"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier1"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier3"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier4"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier5"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier6"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier7"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier8"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier9"
                         IsNullable = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ProductType"
                          Name = "ProductType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmSetVariable"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimationDetail"
        TargetTable =
         { Name = TableName "TimeEstimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifiersId"
                                                            IsNullable = true };
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
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "TimeEstimationConfigurationsTimeEstimationDetail"
                 Name = "TimeEstimationConfigurationsTimeEstimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "TimeEstimationDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimation"
        TargetTable =
         { Name = TableName "TimeEstimation"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Time"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "HasModifiers"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseDirectModifier"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifierId"
                                                            IsNullable = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "TimeEstimation"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UidataModelKeyMapping"
        TargetTable =
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
                         Name = "NItems"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionLabelId0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId0"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId9"
                         IsNullable = true };
             Primitive { Type = Guid
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
        Destination = EntityName "UidataModelKeyMapping"
        KeyType = Guid }] }-TimeEstimation-loader",
                            async ids => 
                            {
                                var data = await dbContext.TimeEstimations
                                    .Where(x => x.TimeEstimation != null && ids.Contains((Guid)x.TimeEstimation))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.TimeEstimation!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.TimeEstimations);
                    });
            
			
                Field<UidataModelKeyMappingGraphType, UidataModelKeyMapping>("UidataModelKeyMappings")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UidataModelKeyMappingGraphType>>(
                            "{ Name = EntityName "Modifier"
  CorrespondingTable =
   Regular
     { Name = TableName "Modifier"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ModifiersId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumModifiers"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "OverallOperationId"
                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "ModifierDetails1"
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "ModifierDetails2"
                                                       IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails3"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails4"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails5"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails6"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ModifierDetails7"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "ModifierDetails8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "ModifierType1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType3"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType4"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType5"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ModifierType6"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ModifierType7"
                     IsNullable = false }; Primitive { Type = Byte
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
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId0Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId1Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId2Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId3Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId4Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId5Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId6Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId7Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId8Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidataModelKeyMapping"
                      Name = "UidataModelKeyMappingKeyModifierId9Navigations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "ModifiersId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumModifiers"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierDetails1"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "ModifierDetails2"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails3"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails4"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails5"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierDetails6"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "ModifierDetails7"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "ModifierDetails8"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ModifierType1"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "ModifierType2"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "ModifierType3"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType4"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType5"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierType6"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierType7"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierType8"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator2"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator3"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator4"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator5"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ModifierOperator6"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ModifierOperator7"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ModifierOperator8"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }]
  Relations =
   [OneToMany
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
    MultipleManyToOne
      { Names =
         [RelationName "ModifierDetails1Navigation";
          RelationName "ModifierDetails2Navigation";
          RelationName "ModifierDetails3Navigation";
          RelationName "ModifierDetails4Navigation";
          RelationName "ModifierDetails5Navigation";
          RelationName "ModifierDetails6Navigation";
          RelationName "ModifierDetails7Navigation";
          RelationName "ModifierDetails8Navigation"]
        TargetTable =
         { Name = TableName "ModifiersDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ModifiersDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "NumItems"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ModifierSearchMethodId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsPercent"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "VariableGroupId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ModifierSearchMethod"
                          Name = "ModifierSearchMethod"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "ModifiersDetail"
        IsNullable = false
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierOperator1Navigation";
          RelationName "ModifierOperator2Navigation";
          RelationName "ModifierOperator3Navigation";
          RelationName "ModifierOperator4Navigation";
          RelationName "ModifierOperator7Navigation";
          RelationName "ModifierOperator8Navigation";
          RelationName "ModifierType5Navigation";
          RelationName "ModifierType6Navigation"]
        TargetTable =
         { Name = TableName "ModifierOperator"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierOperatorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierOperatorDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierOperator8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType6Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierOperator"
        IsNullable = false
        KeyType = Byte };
    MultipleManyToOne
      { Names =
         [RelationName "ModifierType1Navigation";
          RelationName "ModifierType2Navigation";
          RelationName "ModifierType3Navigation";
          RelationName "ModifierType4Navigation"; RelationName "ModifierType51";
          RelationName "ModifierType61"; RelationName "ModifierType7Navigation";
          RelationName "ModifierType8Navigation"]
        TargetTable =
         { Name = TableName "ModifierType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierTypeDescription"
                         IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType51s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType61s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierType8Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "StmMaintain"
        TargetTable =
         { Name = TableName "StmMaintain"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "Time"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ModifiersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "IsAdd"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmMaintain"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmSetVariable"
        TargetTable =
         { Name = TableName "StmSetVariable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Operation"
                                                            IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "Operand"
                                                           IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation1"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset1"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand1"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation2"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset2"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand2"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition2"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation3"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset3"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand3"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation4"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset4"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand4"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition4"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation5"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset5"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand5"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet5"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition5"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation6"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset6"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand6"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet6"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition6"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation7"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset7"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand7"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet7"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition7"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation8"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset8"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand8"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet8"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition8"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Operation9"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "VariableIndex9"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset9"
                         IsNullable = true }; Primitive { Type = Short
                                                          Name = "Operand9"
                                                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "IsSet9"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "BitPosition9"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroups1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableGroups9"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier1"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier3"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier4"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier5"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier6"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier7"
                         IsNullable = true }; Primitive { Type = Guid
                                                          Name = "Modifier8"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "Modifier9"
                         IsNullable = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier4Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier5Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier6Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier7Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier8Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier9Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ProductType"
                          Name = "ProductType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmSetVariable"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimationDetail"
        TargetTable =
         { Name = TableName "TimeEstimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifiersId"
                                                            IsNullable = true };
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
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "TimeEstimationConfigurationsTimeEstimationDetail"
                 Name = "TimeEstimationConfigurationsTimeEstimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "TimeEstimationDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "TimeEstimation"
        TargetTable =
         { Name = TableName "TimeEstimation"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Time"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "HasModifiers"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "UseDirectModifier"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifierId"
                                                            IsNullable = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "Modifier"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "TimeEstimation"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UidataModelKeyMapping"
        TargetTable =
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
                         Name = "NItems"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionLabelId0"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId0"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId1"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId2"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId4"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId4"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId5"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId5"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId6"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId6"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId7"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId7"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId8"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "KeyModifierId8"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabelId9"
                         IsNullable = true };
             Primitive { Type = Guid
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
        Destination = EntityName "UidataModelKeyMapping"
        KeyType = Guid }] }-UidataModelKeyMapping-loader",
                            async ids => 
                            {
                                var data = await dbContext.UidataModelKeyMappings
                                    .Where(x => x.UidataModelKeyMapping != null && ids.Contains((Guid)x.UidataModelKeyMapping))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UidataModelKeyMapping!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UidataModelKeyMappings);
                    });
            
        }
    }
}
            