
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
    public partial class StmSetVariableGraphType : ObjectGraphType<StmSetVariable>
    {
        public StmSetVariableGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Operation, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex, type: typeof(IdGraphType), nullable: False);
			Field(t => t.VariableOffset, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Operand, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex1, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand1, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet1, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex2, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand2, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet2, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex3, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand3, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet3, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex4, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand4, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet4, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex5, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand5, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet5, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation6, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex6, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset6, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand6, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet6, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition6, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation7, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex7, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset7, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand7, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet7, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition7, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation8, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex8, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset8, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand8, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet8, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition8, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation9, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex9, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset9, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand9, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet9, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition9, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VariableGroups1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups6, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups7, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups8, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups9, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Modifier, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.Modifier1, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.Modifier2, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.Modifier3, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.Modifier4, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.Modifier5, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.Modifier6, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.Modifier7, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.Modifier8, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.Modifier9, type: typeof(GuidGraphType), nullable: True);
            
                Field<ModifierGraphType, Modifier>("Modifiers")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ModifierGraphType>(
                            "{ Name = EntityName "StmSetVariable"
  CorrespondingTable =
   Regular
     { Name = TableName "StmSetVariable"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "ProductTypeId"
                                                         IsNullable = false };
         Primitive { Type = Byte
                     Name = "Operation"
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "VariableGroups1"
                                                       IsNullable = true };
         Primitive { Type = Byte
                     Name = "VariableGroups2"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "VariableGroups3"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "VariableGroups4"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "VariableGroups5"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "VariableGroups6"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "VariableGroups7"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "VariableGroups8"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "VariableGroups9"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "Modifier"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "Modifier1"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "Modifier2"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "Modifier3"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "Modifier4"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "Modifier5"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "Modifier6"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "Modifier7"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "Modifier8"
                     IsNullable = true }; Primitive { Type = Guid
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "Operation"
                              Type = Primitive Byte
                              IsNullable = true }; { Name = "VariableIndex"
                                                     Type = Primitive Int
                                                     IsNullable = false };
    { Name = "VariableOffset"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Operand"
                              Type = Primitive Short
                              IsNullable = true }; { Name = "IsSet"
                                                     Type = Primitive Bool
                                                     IsNullable = true };
    { Name = "BitPosition"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation1"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex1"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand1"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet1"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation2"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex2"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand2"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet2"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation3"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex3"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand3"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet3"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation4"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex4"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset4"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand4"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet4"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition4"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation5"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex5"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset5"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand5"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet5"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition5"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation6"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex6"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset6"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand6"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet6"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition6"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation7"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex7"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset7"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand7"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet7"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition7"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation8"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex8"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset8"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand8"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet8"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition8"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation9"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex9"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset9"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand9"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet9"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition9"
      Type = Primitive Byte
      IsNullable = true }; { Name = "VariableGroups"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "VariableGroups1"
                                                     Type = Primitive Byte
                                                     IsNullable = true };
    { Name = "VariableGroups2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "VariableGroups3"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableGroups4"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "VariableGroups5"
      Type = Primitive Byte
      IsNullable = true }; { Name = "VariableGroups6"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableGroups7"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "VariableGroups8"
      Type = Primitive Byte
      IsNullable = true }; { Name = "VariableGroups9"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "Modifier"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "Modifier1"
      Type = Primitive Guid
      IsNullable = true }; { Name = "Modifier2"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "Modifier3"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "Modifier4"
      Type = Primitive Guid
      IsNullable = true }; { Name = "Modifier5"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "Modifier6"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "Modifier7"
      Type = Primitive Guid
      IsNullable = true }; { Name = "Modifier8"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "Modifier9"
                                                    Type = Primitive Guid
                                                    IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "Modifier1Navigation"; RelationName "Modifier2Navigation";
          RelationName "Modifier3Navigation"; RelationName "Modifier4Navigation";
          RelationName "Modifier5Navigation"; RelationName "Modifier6Navigation";
          RelationName "Modifier7Navigation"; RelationName "Modifier8Navigation";
          RelationName "Modifier9Navigation"; RelationName "ModifierNavigation"]
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
    SingleManyToOne
      { Name = RelationName "ProductType"
        TargetTable =
         { Name = TableName "ProductType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ProductTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "ProductTypesHighStatement"
                          Name = "ProductTypesHighStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesTask"
                          Name = "ProductTypesTasks"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesVariable"
                          Name = "ProductTypesVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ProductType"
        IsNullable = false
        KeyType = Byte }] }-Modifier-loader",
                            async ids => 
                            {
                                Expression<Func<Modifier, bool>> expr = x => !ids.Any()
                                    \|\| (x.Modifier1Navigation != null && ids.Contains((Guid)x.Modifier1Navigation))
\|\| (x.Modifier2Navigation != null && ids.Contains((Guid)x.Modifier2Navigation))
\|\| (x.Modifier3Navigation != null && ids.Contains((Guid)x.Modifier3Navigation))
\|\| (x.Modifier4Navigation != null && ids.Contains((Guid)x.Modifier4Navigation))
\|\| (x.Modifier5Navigation != null && ids.Contains((Guid)x.Modifier5Navigation))
\|\| (x.Modifier6Navigation != null && ids.Contains((Guid)x.Modifier6Navigation))
\|\| (x.Modifier7Navigation != null && ids.Contains((Guid)x.Modifier7Navigation))
\|\| (x.Modifier8Navigation != null && ids.Contains((Guid)x.Modifier8Navigation))
\|\| (x.Modifier9Navigation != null && ids.Contains((Guid)x.Modifier9Navigation))
\|\| (x.ModifierNavigation != null && ids.Contains((Guid)x.ModifierNavigation));

                                var data = await dbContext.Modifiers
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.Modifier1Navigation,
x.Modifier2Navigation,
x.Modifier3Navigation,
x.Modifier4Navigation,
x.Modifier5Navigation,
x.Modifier6Navigation,
x.Modifier7Navigation,
x.Modifier8Navigation,
x.Modifier9Navigation,
x.ModifierNavigation
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.Modifiers);
                    });
            
			
                Field<ProductTypeGraphType, ProductType>("ProductTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ProductTypeGraphType>(
                            "{ Name = EntityName "StmSetVariable"
  CorrespondingTable =
   Regular
     { Name = TableName "StmSetVariable"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "ProductTypeId"
                                                         IsNullable = false };
         Primitive { Type = Byte
                     Name = "Operation"
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = true }; Primitive { Type = Int
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
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "VariableGroups1"
                                                       IsNullable = true };
         Primitive { Type = Byte
                     Name = "VariableGroups2"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "VariableGroups3"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "VariableGroups4"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "VariableGroups5"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "VariableGroups6"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "VariableGroups7"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "VariableGroups8"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "VariableGroups9"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "Modifier"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "Modifier1"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "Modifier2"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "Modifier3"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "Modifier4"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "Modifier5"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "Modifier6"
                     IsNullable = true }; Primitive { Type = Guid
                                                      Name = "Modifier7"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "Modifier8"
                     IsNullable = true }; Primitive { Type = Guid
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "Operation"
                              Type = Primitive Byte
                              IsNullable = true }; { Name = "VariableIndex"
                                                     Type = Primitive Int
                                                     IsNullable = false };
    { Name = "VariableOffset"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Operand"
                              Type = Primitive Short
                              IsNullable = true }; { Name = "IsSet"
                                                     Type = Primitive Bool
                                                     IsNullable = true };
    { Name = "BitPosition"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation1"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex1"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand1"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet1"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation2"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex2"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand2"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet2"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation3"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex3"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand3"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet3"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition3"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation4"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex4"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset4"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand4"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet4"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition4"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation5"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex5"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset5"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand5"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet5"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition5"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation6"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex6"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset6"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand6"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet6"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition6"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation7"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex7"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset7"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand7"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet7"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition7"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation8"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex8"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset8"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand8"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet8"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition8"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operation9"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableIndex9"
                                                    Type = Primitive Int
                                                    IsNullable = true };
    { Name = "VariableOffset9"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Operand9"
                             Type = Primitive Short
                             IsNullable = true }; { Name = "IsSet9"
                                                    Type = Primitive Bool
                                                    IsNullable = true };
    { Name = "BitPosition9"
      Type = Primitive Byte
      IsNullable = true }; { Name = "VariableGroups"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "VariableGroups1"
                                                     Type = Primitive Byte
                                                     IsNullable = true };
    { Name = "VariableGroups2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "VariableGroups3"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableGroups4"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "VariableGroups5"
      Type = Primitive Byte
      IsNullable = true }; { Name = "VariableGroups6"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "VariableGroups7"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "VariableGroups8"
      Type = Primitive Byte
      IsNullable = true }; { Name = "VariableGroups9"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "Modifier"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "Modifier1"
      Type = Primitive Guid
      IsNullable = true }; { Name = "Modifier2"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "Modifier3"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "Modifier4"
      Type = Primitive Guid
      IsNullable = true }; { Name = "Modifier5"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "Modifier6"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "Modifier7"
      Type = Primitive Guid
      IsNullable = true }; { Name = "Modifier8"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "Modifier9"
                                                    Type = Primitive Guid
                                                    IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "Modifier1Navigation"; RelationName "Modifier2Navigation";
          RelationName "Modifier3Navigation"; RelationName "Modifier4Navigation";
          RelationName "Modifier5Navigation"; RelationName "Modifier6Navigation";
          RelationName "Modifier7Navigation"; RelationName "Modifier8Navigation";
          RelationName "Modifier9Navigation"; RelationName "ModifierNavigation"]
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
    SingleManyToOne
      { Name = RelationName "ProductType"
        TargetTable =
         { Name = TableName "ProductType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ProductTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "ProductTypesHighStatement"
                          Name = "ProductTypesHighStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesTask"
                          Name = "ProductTypesTasks"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesVariable"
                          Name = "ProductTypesVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ProductType"
        IsNullable = false
        KeyType = Byte }] }-ProductType-loader",
                            async ids => 
                            {
                                var data = await dbContext.ProductTypes
                                    .Where(x => x.ProductType != null && ids.Contains((byte)x.ProductType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.ProductType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.ProductType);
                });
            
        }
    }
}
            