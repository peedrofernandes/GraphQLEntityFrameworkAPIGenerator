
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
    public partial class ConditionBlockGraphType : ObjectGraphType<ConditionBlock>
    {
        public ConditionBlockGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ConditionBlockId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.BoolOperator, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Operand, type: typeof(DoubleGraphType), nullable: True);
			Field(t => t.Mask, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.FirstOffset, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SecondOffset, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.IsNot, type: typeof(BoolGraphType), nullable: False);
            
                Field<ConditionGraphType, Condition>("Conditions")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ConditionGraphType>>(
                            "{ Name = EntityName "ConditionBlock"
  CorrespondingTable =
   Regular
     { Name = TableName "ConditionBlock"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ConditionBlockId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "BoolOperator"
                                                        IsNullable = false };
         ForeignKey { Type = Int
                      Name = "FirstVariableId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "OperatorId"
                                                         IsNullable = false };
         ForeignKey { Type = Int
                      Name = "SecondVariableId"
                      IsNullable = true }; Primitive { Type = Double
                                                       Name = "Operand"
                                                       IsNullable = true };
         Primitive { Type = Short
                     Name = "Mask"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "FirstOffset"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "SecondOffset"
                     IsNullable = true }; Primitive { Type = Bool
                                                      Name = "IsNot"
                                                      IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "FirstVariableGroupId"
                      IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "SecondVariableGroupId"
                      IsNullable = true }; ForeignKey { Type = Byte
                                                        Name = "ProductTypeId"
                                                        IsNullable = false };
         Navigation { Type = TableName "Condition"
                      Name = "ConditionConditionBlock1s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Condition"
                      Name = "ConditionConditionBlock2s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Condition"
                      Name = "ConditionConditionBlock3s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Condition"
                      Name = "ConditionConditionBlock4s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Condition"
                      Name = "ConditionConditionBlock5s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Condition"
                      Name = "ConditionConditionBlock6s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Condition"
                      Name = "ConditionConditionBlock7s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Condition"
                      Name = "ConditionConditionBlock8s"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "ConditionBlockId"
      Type = Id Guid
      IsNullable = false }; { Name = "BoolOperator"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Operand"
                                                      Type = Primitive Double
                                                      IsNullable = true };
    { Name = "Mask"
      Type = Primitive Short
      IsNullable = false }; { Name = "FirstOffset"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "SecondOffset"
                                                      Type = Primitive Byte
                                                      IsNullable = true };
    { Name = "IsNot"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "Condition"
        TargetTable =
         { Name = TableName "Condition"
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
             Navigation { Type = TableName "ConditionBlock"
                          Name = "ConditionBlock1"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ConditionBlock"
                          Name = "ConditionBlock2"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ConditionBlock"
                          Name = "ConditionBlock3"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ConditionBlock"
                          Name = "ConditionBlock4"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ConditionBlock"
                          Name = "ConditionBlock5"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ConditionBlock"
                          Name = "ConditionBlock6"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ConditionBlock"
                          Name = "ConditionBlock7"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ConditionBlock"
                          Name = "ConditionBlock8"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "SelectorsCycle"
                          Name = "SelectorsCycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmJumpIf"
                          Name = "StmJumpIfs"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmLoadsControl"
                          Name = "StmLoadsControlConditions"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmLoadsControl"
                          Name = "StmLoadsControlDeactivationConditions"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmMaintain"
                          Name = "StmMaintains"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Condition"
        KeyType = Guid }] }-Condition-loader",
                            async ids => 
                            {
                                var data = await dbContext.Conditions
                                    .Where(x => x.Condition != null && ids.Contains((Guid)x.Condition))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Condition!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.Conditions);
                    });
            
        }
    }
}
            