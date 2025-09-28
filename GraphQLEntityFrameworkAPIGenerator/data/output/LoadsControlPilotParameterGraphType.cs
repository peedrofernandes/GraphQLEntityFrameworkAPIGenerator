
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
    public partial class LoadsControlPilotParameterGraphType : ObjectGraphType<LoadsControlPilotParameter>
    {
        public LoadsControlPilotParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ComplexLoadsNumber, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadId0, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue0, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadModifierId0, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadId1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadModifierId1, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadId2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadModifierId2, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadId3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadModifierId3, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadId4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadModifierId4, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadId5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadModifierId5, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadId6, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue6, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadModifierId6, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadId7, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue7, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadModifierId7, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadId8, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue8, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadModifierId8, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadId9, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue9, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadModifierId9, type: typeof(GuidGraphType), nullable: True);
            
                Field<LoadGraphType, Load>("Loads")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, LoadGraphType>(
                            "{ Name = EntityName "LoadsControlPilotParameter"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId0"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId1"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadValue1"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "LoadModifierId1"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadId2"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadValue2"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId2"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId3"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadValue3"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "LoadModifierId3"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadId4"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadValue4"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId4"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId5"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadValue5"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "LoadModifierId5"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadId6"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadValue6"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId6"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId7"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadValue7"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "LoadModifierId7"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadId8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadValue8"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId9"
                     IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "ComplexLoadsNumber"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "LoadId0"
                                                      Type = Primitive Byte
                                                      IsNullable = true };
    { Name = "LoadValue0"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId0"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId1"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId1"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId2"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId2"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId3"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId3"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId4"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue4"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId4"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId5"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue5"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId5"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId6"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue6"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId6"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId7"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue7"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId7"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId8"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue8"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId8"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId9"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue9"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId9"
                             Type = Primitive Guid
                             IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "LoadId0Navigation"; RelationName "LoadId1Navigation";
          RelationName "LoadId2Navigation"; RelationName "LoadId3Navigation";
          RelationName "LoadId4Navigation"; RelationName "LoadId5Navigation";
          RelationName "LoadId6Navigation"; RelationName "LoadId7Navigation";
          RelationName "LoadId8Navigation"; RelationName "LoadId9Navigation"]
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
        IsNullable = true
        KeyType = Byte };
    MultipleManyToOne
      { Names =
         [RelationName "LoadModifierId0Navigation";
          RelationName "LoadModifierId1Navigation";
          RelationName "LoadModifierId2Navigation";
          RelationName "LoadModifierId3Navigation";
          RelationName "LoadModifierId4Navigation";
          RelationName "LoadModifierId5Navigation";
          RelationName "LoadModifierId6Navigation";
          RelationName "LoadModifierId7Navigation";
          RelationName "LoadModifierId8Navigation";
          RelationName "LoadModifierId9Navigation"]
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
      { Name = RelationName "StmLoadsControl"
        TargetTable =
         { Name = TableName "StmLoadsControl"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PilotParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DeactivationConditionId"
                          IsNullable = true }; Primitive { Type = Float
                                                           Name = "TimeOn"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeOff"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "StartOff"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "PartialControl"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ActivateOptions"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Resume"
                                                           IsNullable = false };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Condition"
                          Name = "DeactivationCondition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "PilotParameters"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmLoadsControl"
        KeyType = Guid }] }-Load-loader",
                            async ids => 
                            {
                                Expression<Func<Load, bool>> expr = x => !ids.Any()
                                    \|\| (x.LoadId0Navigation != null && ids.Contains((byte)x.LoadId0Navigation))
\|\| (x.LoadId1Navigation != null && ids.Contains((byte)x.LoadId1Navigation))
\|\| (x.LoadId2Navigation != null && ids.Contains((byte)x.LoadId2Navigation))
\|\| (x.LoadId3Navigation != null && ids.Contains((byte)x.LoadId3Navigation))
\|\| (x.LoadId4Navigation != null && ids.Contains((byte)x.LoadId4Navigation))
\|\| (x.LoadId5Navigation != null && ids.Contains((byte)x.LoadId5Navigation))
\|\| (x.LoadId6Navigation != null && ids.Contains((byte)x.LoadId6Navigation))
\|\| (x.LoadId7Navigation != null && ids.Contains((byte)x.LoadId7Navigation))
\|\| (x.LoadId8Navigation != null && ids.Contains((byte)x.LoadId8Navigation))
\|\| (x.LoadId9Navigation != null && ids.Contains((byte)x.LoadId9Navigation));

                                var data = await dbContext.Loads
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<byte?>()
                                    {
                                        x.LoadId0Navigation,
x.LoadId1Navigation,
x.LoadId2Navigation,
x.LoadId3Navigation,
x.LoadId4Navigation,
x.LoadId5Navigation,
x.LoadId6Navigation,
x.LoadId7Navigation,
x.LoadId8Navigation,
x.LoadId9Navigation
                                    }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.Loads);
                    });
            
			
                Field<ModifierGraphType, Modifier>("Modifiers")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ModifierGraphType>(
                            "{ Name = EntityName "LoadsControlPilotParameter"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId0"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId1"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadValue1"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "LoadModifierId1"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadId2"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadValue2"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId2"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId3"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadValue3"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "LoadModifierId3"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadId4"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadValue4"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId4"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId5"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadValue5"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "LoadModifierId5"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadId6"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadValue6"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId6"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId7"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadValue7"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "LoadModifierId7"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadId8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadValue8"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId9"
                     IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "ComplexLoadsNumber"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "LoadId0"
                                                      Type = Primitive Byte
                                                      IsNullable = true };
    { Name = "LoadValue0"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId0"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId1"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId1"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId2"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId2"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId3"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId3"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId4"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue4"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId4"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId5"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue5"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId5"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId6"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue6"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId6"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId7"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue7"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId7"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId8"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue8"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId8"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId9"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue9"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId9"
                             Type = Primitive Guid
                             IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "LoadId0Navigation"; RelationName "LoadId1Navigation";
          RelationName "LoadId2Navigation"; RelationName "LoadId3Navigation";
          RelationName "LoadId4Navigation"; RelationName "LoadId5Navigation";
          RelationName "LoadId6Navigation"; RelationName "LoadId7Navigation";
          RelationName "LoadId8Navigation"; RelationName "LoadId9Navigation"]
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
        IsNullable = true
        KeyType = Byte };
    MultipleManyToOne
      { Names =
         [RelationName "LoadModifierId0Navigation";
          RelationName "LoadModifierId1Navigation";
          RelationName "LoadModifierId2Navigation";
          RelationName "LoadModifierId3Navigation";
          RelationName "LoadModifierId4Navigation";
          RelationName "LoadModifierId5Navigation";
          RelationName "LoadModifierId6Navigation";
          RelationName "LoadModifierId7Navigation";
          RelationName "LoadModifierId8Navigation";
          RelationName "LoadModifierId9Navigation"]
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
      { Name = RelationName "StmLoadsControl"
        TargetTable =
         { Name = TableName "StmLoadsControl"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PilotParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DeactivationConditionId"
                          IsNullable = true }; Primitive { Type = Float
                                                           Name = "TimeOn"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeOff"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "StartOff"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "PartialControl"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ActivateOptions"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Resume"
                                                           IsNullable = false };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Condition"
                          Name = "DeactivationCondition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "PilotParameters"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmLoadsControl"
        KeyType = Guid }] }-Modifier-loader",
                            async ids => 
                            {
                                Expression<Func<Modifier, bool>> expr = x => !ids.Any()
                                    \|\| (x.LoadModifierId0Navigation != null && ids.Contains((Guid)x.LoadModifierId0Navigation))
\|\| (x.LoadModifierId1Navigation != null && ids.Contains((Guid)x.LoadModifierId1Navigation))
\|\| (x.LoadModifierId2Navigation != null && ids.Contains((Guid)x.LoadModifierId2Navigation))
\|\| (x.LoadModifierId3Navigation != null && ids.Contains((Guid)x.LoadModifierId3Navigation))
\|\| (x.LoadModifierId4Navigation != null && ids.Contains((Guid)x.LoadModifierId4Navigation))
\|\| (x.LoadModifierId5Navigation != null && ids.Contains((Guid)x.LoadModifierId5Navigation))
\|\| (x.LoadModifierId6Navigation != null && ids.Contains((Guid)x.LoadModifierId6Navigation))
\|\| (x.LoadModifierId7Navigation != null && ids.Contains((Guid)x.LoadModifierId7Navigation))
\|\| (x.LoadModifierId8Navigation != null && ids.Contains((Guid)x.LoadModifierId8Navigation))
\|\| (x.LoadModifierId9Navigation != null && ids.Contains((Guid)x.LoadModifierId9Navigation));

                                var data = await dbContext.Modifiers
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.LoadModifierId0Navigation,
x.LoadModifierId1Navigation,
x.LoadModifierId2Navigation,
x.LoadModifierId3Navigation,
x.LoadModifierId4Navigation,
x.LoadModifierId5Navigation,
x.LoadModifierId6Navigation,
x.LoadModifierId7Navigation,
x.LoadModifierId8Navigation,
x.LoadModifierId9Navigation
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.Modifiers);
                    });
            
			
                Field<StmLoadsControlGraphType, StmLoadsControl>("StmLoadsControls")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmLoadsControlGraphType>>(
                            "{ Name = EntityName "LoadsControlPilotParameter"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId0"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId1"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadValue1"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "LoadModifierId1"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadId2"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadValue2"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId2"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId3"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadValue3"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "LoadModifierId3"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadId4"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadValue4"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId4"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId5"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadValue5"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "LoadModifierId5"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadId6"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadValue6"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId6"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId7"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadValue7"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "LoadModifierId7"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "LoadId8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadValue8"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "LoadModifierId8"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "LoadId9"
                     IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "ComplexLoadsNumber"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "LoadId0"
                                                      Type = Primitive Byte
                                                      IsNullable = true };
    { Name = "LoadValue0"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId0"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId1"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId1"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId2"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId2"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId3"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId3"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId4"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue4"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId4"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId5"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue5"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId5"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId6"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue6"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId6"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId7"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue7"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId7"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId8"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue8"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId8"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "LoadId9"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "LoadValue9"
      Type = Primitive Byte
      IsNullable = true }; { Name = "LoadModifierId9"
                             Type = Primitive Guid
                             IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "LoadId0Navigation"; RelationName "LoadId1Navigation";
          RelationName "LoadId2Navigation"; RelationName "LoadId3Navigation";
          RelationName "LoadId4Navigation"; RelationName "LoadId5Navigation";
          RelationName "LoadId6Navigation"; RelationName "LoadId7Navigation";
          RelationName "LoadId8Navigation"; RelationName "LoadId9Navigation"]
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
        IsNullable = true
        KeyType = Byte };
    MultipleManyToOne
      { Names =
         [RelationName "LoadModifierId0Navigation";
          RelationName "LoadModifierId1Navigation";
          RelationName "LoadModifierId2Navigation";
          RelationName "LoadModifierId3Navigation";
          RelationName "LoadModifierId4Navigation";
          RelationName "LoadModifierId5Navigation";
          RelationName "LoadModifierId6Navigation";
          RelationName "LoadModifierId7Navigation";
          RelationName "LoadModifierId8Navigation";
          RelationName "LoadModifierId9Navigation"]
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
      { Name = RelationName "StmLoadsControl"
        TargetTable =
         { Name = TableName "StmLoadsControl"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PilotParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DeactivationConditionId"
                          IsNullable = true }; Primitive { Type = Float
                                                           Name = "TimeOn"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "TimeOff"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "StartOff"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "PartialControl"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "ActivateOptions"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Resume"
                                                           IsNullable = false };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Condition"
                          Name = "DeactivationCondition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "PilotParameters"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "StmLoadsControl"
        KeyType = Guid }] }-StmLoadsControl-loader",
                            async ids => 
                            {
                                var data = await dbContext.StmLoadsControls
                                    .Where(x => x.StmLoadsControl != null && ids.Contains((Guid)x.StmLoadsControl))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.StmLoadsControl!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.StmLoadsControls);
                    });
            
        }
    }
}
            