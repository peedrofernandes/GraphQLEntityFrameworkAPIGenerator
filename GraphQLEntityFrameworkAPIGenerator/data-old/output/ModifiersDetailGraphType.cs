
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
    public partial class ModifiersDetailGraphType : ObjectGraphType<ModifiersDetail>
    {
        public ModifiersDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ModifiersDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumItems, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VariableIndex, type: typeof(IdGraphType), nullable: False);
			Field(t => t.VariableOffset, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IsPercent, type: typeof(BoolGraphType), nullable: False);
            
                Field<ModifierGraphType, Modifier>("Modifiers")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ModifierGraphType>>(
                            "{ Name = EntityName "ModifiersDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "ModifiersDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ModifiersDetailsId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumItems"
                                                        IsNullable = false };
         Primitive { Type = Int
                     Name = "VariableIndex"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "VariableOffset"
                                                       IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "ModifierSearchMethodId"
                      IsNullable = false }; Primitive { Type = Bool
                                                        Name = "IsPercent"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "VariableGroupId"
                      IsNullable = false }; ForeignKey { Type = Byte
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
  Fields =
   [{ Name = "ModifiersDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumItems"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "VariableIndex"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "VariableOffset"
      Type = Primitive Byte
      IsNullable = false }; { Name = "IsPercent"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "Modifier"
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
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "ModifierSearchMethod"
        TargetTable =
         { Name = TableName "ModifierSearchMethod"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierSearchMethodId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierSearchMethodDescription"
                         IsNullable = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifiersDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierSearchMethod"
        IsNullable = false
        KeyType = Byte }] }-Modifier-loader",
                            async ids => 
                            {
                                var data = await dbContext.Modifiers
                                    .Where(x => x.Modifier != null && ids.Contains((Guid)x.Modifier))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Modifier!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.Modifiers);
                    });
            
			
                Field<ModifierSearchMethodGraphType, ModifierSearchMethod>("ModifierSearchMethods")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ModifierSearchMethodGraphType>(
                            "{ Name = EntityName "ModifiersDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "ModifiersDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ModifiersDetailsId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumItems"
                                                        IsNullable = false };
         Primitive { Type = Int
                     Name = "VariableIndex"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "VariableOffset"
                                                       IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "ModifierSearchMethodId"
                      IsNullable = false }; Primitive { Type = Bool
                                                        Name = "IsPercent"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "VariableGroupId"
                      IsNullable = false }; ForeignKey { Type = Byte
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
  Fields =
   [{ Name = "ModifiersDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumItems"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "VariableIndex"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "VariableOffset"
      Type = Primitive Byte
      IsNullable = false }; { Name = "IsPercent"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "Modifier"
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
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "ModifierSearchMethod"
        TargetTable =
         { Name = TableName "ModifierSearchMethod"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ModifierSearchMethodId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ModifierSearchMethodDescription"
                         IsNullable = false };
             Navigation { Type = TableName "ModifiersDetail"
                          Name = "ModifiersDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ModifierSearchMethod"
        IsNullable = false
        KeyType = Byte }] }-ModifierSearchMethod-loader",
                            async ids => 
                            {
                                var data = await dbContext.ModifierSearchMethods
                                    .Where(x => x.ModifierSearchMethod != null && ids.Contains((byte)x.ModifierSearchMethod))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.ModifierSearchMethod!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.ModifierSearchMethod);
                });
            
        }
    }
}
            