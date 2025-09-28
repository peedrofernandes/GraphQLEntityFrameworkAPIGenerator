
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
    public partial class UiconditionBlockGraphType : ObjectGraphType<UiconditionBlock>
    {
        public UiconditionBlockGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiconditionBlockId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Operand, type: typeof(DoubleGraphType), nullable: True);
			Field(t => t.FirstOffset, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VariableGroups, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UseVisualValue, type: typeof(BoolGraphType), nullable: False);
            
                Field<UifunctionConditionGraphType, UifunctionCondition>("UifunctionConditions")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UifunctionConditionGraphType>>(
                            "{ Name = EntityName "UiconditionBlock"
  CorrespondingTable =
   Regular
     { Name = TableName "UiconditionBlock"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiconditionBlockId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "ProductTypeId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "UiboolOperatorId"
                      IsNullable = false };
         ForeignKey { Type = Int
                      Name = "FirstVariableId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "UioperatorId"
                                                         IsNullable = false };
         Primitive { Type = Double
                     Name = "Operand"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "FirstOffset"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "VariableGroups"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "UseVisualValue"
                                                       IsNullable = false };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock1s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock2s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock3s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock4s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock5s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock6s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock7s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock8s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Uioperator"
                      Name = "Uioperator"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UiconditionBlockId"
      Type = Id Guid
      IsNullable = false }; { Name = "Operand"
                              Type = Primitive Double
                              IsNullable = true }; { Name = "FirstOffset"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "VariableGroups"
      Type = Primitive Byte
      IsNullable = false }; { Name = "UseVisualValue"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UifunctionCondition"
        TargetTable =
         { Name = TableName "UifunctionCondition"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumConditions"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock1Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock2Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock3Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock4Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock5Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock6Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock7Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock8Id"
                          IsNullable = true };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock1"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock2"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock3"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock4"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock5"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock6"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock7"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock8"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "SelectorsCycle"
                          Name = "SelectorsCycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UistmSetIncompatibility"
                          Name = "UistmSetIncompatibilities"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UistmSetVariable"
                          Name = "UistmSetVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UistmVisualJumpIf"
                          Name = "UistmVisualJumpIfs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UifunctionCondition"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Uioperator"
        TargetTable =
         { Name = TableName "Uioperator"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UioperatorId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Uioperator1"
                                                            IsNullable = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "UiconditionBlocks"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uioperator"
        IsNullable = false
        KeyType = Byte }] }-UifunctionCondition-loader",
                            async ids => 
                            {
                                var data = await dbContext.UifunctionConditions
                                    .Where(x => x.UifunctionCondition != null && ids.Contains((Guid)x.UifunctionCondition))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UifunctionCondition!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UifunctionConditions);
                    });
            
			
                Field<UioperatorGraphType, Uioperator>("Uioperators")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, UioperatorGraphType>(
                            "{ Name = EntityName "UiconditionBlock"
  CorrespondingTable =
   Regular
     { Name = TableName "UiconditionBlock"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiconditionBlockId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "ProductTypeId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "UiboolOperatorId"
                      IsNullable = false };
         ForeignKey { Type = Int
                      Name = "FirstVariableId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "UioperatorId"
                                                         IsNullable = false };
         Primitive { Type = Double
                     Name = "Operand"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "FirstOffset"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "VariableGroups"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "UseVisualValue"
                                                       IsNullable = false };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock1s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock2s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock3s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock4s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock5s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock6s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock7s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "UifunctionConditionConditionBlock8s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Uioperator"
                      Name = "Uioperator"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UiconditionBlockId"
      Type = Id Guid
      IsNullable = false }; { Name = "Operand"
                              Type = Primitive Double
                              IsNullable = true }; { Name = "FirstOffset"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "VariableGroups"
      Type = Primitive Byte
      IsNullable = false }; { Name = "UseVisualValue"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UifunctionCondition"
        TargetTable =
         { Name = TableName "UifunctionCondition"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumConditions"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock1Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock2Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock3Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock4Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock5Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock6Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock7Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ConditionBlock8Id"
                          IsNullable = true };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock1"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock2"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock3"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock4"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock5"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock6"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock7"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "ConditionBlock8"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "SelectorsCycle"
                          Name = "SelectorsCycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UistmSetIncompatibility"
                          Name = "UistmSetIncompatibilities"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UistmSetVariable"
                          Name = "UistmSetVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UistmVisualJumpIf"
                          Name = "UistmVisualJumpIfs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UifunctionCondition"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Uioperator"
        TargetTable =
         { Name = TableName "Uioperator"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UioperatorId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Uioperator1"
                                                            IsNullable = false };
             Navigation { Type = TableName "UiconditionBlock"
                          Name = "UiconditionBlocks"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uioperator"
        IsNullable = false
        KeyType = Byte }] }-Uioperator-loader",
                            async ids => 
                            {
                                var data = await dbContext.Uioperators
                                    .Where(x => x.Uioperator != null && ids.Contains((byte)x.Uioperator))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.Uioperator!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Uioperator);
                });
            
        }
    }
}
            