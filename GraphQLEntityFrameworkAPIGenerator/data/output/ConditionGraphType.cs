
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
    public partial class ConditionGraphType : ObjectGraphType<Condition>
    {
        public ConditionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ConditionId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumConditions, type: typeof(ByteGraphType), nullable: False);
            
                Field<ConditionBlockGraphType, ConditionBlock>("ConditionBlocks")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ConditionBlockGraphType>(
                            "{ Name = EntityName "Condition"
  CorrespondingTable =
   Regular
     { Name = TableName "Condition"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ConditionId"
                      IsNullable = false }; Primitive { Type = Byte
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
  Fields = [{ Name = "ConditionId"
              Type = Id Guid
              IsNullable = false }; { Name = "NumConditions"
                                      Type = Primitive Byte
                                      IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "ConditionBlock1"; RelationName "ConditionBlock2";
          RelationName "ConditionBlock3"; RelationName "ConditionBlock4";
          RelationName "ConditionBlock5"; RelationName "ConditionBlock6";
          RelationName "ConditionBlock7"; RelationName "ConditionBlock8"]
        TargetTable =
         { Name = TableName "ConditionBlock"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConditionBlockId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "BoolOperator"
                         IsNullable = false };
             ForeignKey { Type = Int
                          Name = "FirstVariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
                          IsNullable = true };
             ForeignKey { Type = Byte
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
        Destination = EntityName "ConditionBlock"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "SelectorsCycle"
        TargetTable =
         { Name = TableName "SelectorsCycle"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "SelectorConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "EnteringCycle"
                         IsNullable = true }; ForeignKey { Type = Guid
                                                           Name = "ConditionId"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Priority"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CycleTypeId"
                                                            IsNullable = false };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "SelectorCondition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "SelectorsCycle"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmJumpIf"
        TargetTable =
         { Name = TableName "StmJumpIf"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "DestinationCycle"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "DestinationCycleLabel"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DestinationPhase"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "DestinationPhaseLabel"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DestinationStep"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ConditionId"
                                                            IsNullable = true };
             Primitive { Type = Bool
                         Name = "WithReturn"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "JumpIfPredictionBehaviorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "DestinationStepLabel"
                         IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "JumpIfPredictionBehavior"
                          Name = "JumpIfPredictionBehavior"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmJumpIf"
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
        KeyType = Guid };
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
        KeyType = Guid }] }-ConditionBlock-loader",
                            async ids => 
                            {
                                Expression<Func<ConditionBlock, bool>> expr = x => !ids.Any()
                                    \|\| (x.ConditionBlock1 != null && ids.Contains((Guid)x.ConditionBlock1))
\|\| (x.ConditionBlock2 != null && ids.Contains((Guid)x.ConditionBlock2))
\|\| (x.ConditionBlock3 != null && ids.Contains((Guid)x.ConditionBlock3))
\|\| (x.ConditionBlock4 != null && ids.Contains((Guid)x.ConditionBlock4))
\|\| (x.ConditionBlock5 != null && ids.Contains((Guid)x.ConditionBlock5))
\|\| (x.ConditionBlock6 != null && ids.Contains((Guid)x.ConditionBlock6))
\|\| (x.ConditionBlock7 != null && ids.Contains((Guid)x.ConditionBlock7))
\|\| (x.ConditionBlock8 != null && ids.Contains((Guid)x.ConditionBlock8));

                                var data = await dbContext.ConditionBlocks
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.ConditionBlock1,
x.ConditionBlock2,
x.ConditionBlock3,
x.ConditionBlock4,
x.ConditionBlock5,
x.ConditionBlock6,
x.ConditionBlock7,
x.ConditionBlock8
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.ConditionBlocks);
                    });
            
			
                Field<SelectorsCycleGraphType, SelectorsCycle>("SelectorsCycles")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorsCycleGraphType>>(
                            "{ Name = EntityName "Condition"
  CorrespondingTable =
   Regular
     { Name = TableName "Condition"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ConditionId"
                      IsNullable = false }; Primitive { Type = Byte
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
  Fields = [{ Name = "ConditionId"
              Type = Id Guid
              IsNullable = false }; { Name = "NumConditions"
                                      Type = Primitive Byte
                                      IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "ConditionBlock1"; RelationName "ConditionBlock2";
          RelationName "ConditionBlock3"; RelationName "ConditionBlock4";
          RelationName "ConditionBlock5"; RelationName "ConditionBlock6";
          RelationName "ConditionBlock7"; RelationName "ConditionBlock8"]
        TargetTable =
         { Name = TableName "ConditionBlock"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConditionBlockId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "BoolOperator"
                         IsNullable = false };
             ForeignKey { Type = Int
                          Name = "FirstVariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
                          IsNullable = true };
             ForeignKey { Type = Byte
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
        Destination = EntityName "ConditionBlock"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "SelectorsCycle"
        TargetTable =
         { Name = TableName "SelectorsCycle"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "SelectorConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "EnteringCycle"
                         IsNullable = true }; ForeignKey { Type = Guid
                                                           Name = "ConditionId"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Priority"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CycleTypeId"
                                                            IsNullable = false };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "SelectorCondition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "SelectorsCycle"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmJumpIf"
        TargetTable =
         { Name = TableName "StmJumpIf"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "DestinationCycle"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "DestinationCycleLabel"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DestinationPhase"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "DestinationPhaseLabel"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DestinationStep"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ConditionId"
                                                            IsNullable = true };
             Primitive { Type = Bool
                         Name = "WithReturn"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "JumpIfPredictionBehaviorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "DestinationStepLabel"
                         IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "JumpIfPredictionBehavior"
                          Name = "JumpIfPredictionBehavior"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmJumpIf"
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
        KeyType = Guid };
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
        KeyType = Guid }] }-SelectorsCycle-loader",
                            async ids => 
                            {
                                var data = await dbContext.SelectorsCycles
                                    .Where(x => x.SelectorsCycle != null && ids.Contains((Guid)x.SelectorsCycle))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.SelectorsCycle!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.SelectorsCycles);
                    });
            
			
                Field<StmJumpIfGraphType, StmJumpIf>("StmJumpIfs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmJumpIfGraphType>>(
                            "{ Name = EntityName "Condition"
  CorrespondingTable =
   Regular
     { Name = TableName "Condition"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ConditionId"
                      IsNullable = false }; Primitive { Type = Byte
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
  Fields = [{ Name = "ConditionId"
              Type = Id Guid
              IsNullable = false }; { Name = "NumConditions"
                                      Type = Primitive Byte
                                      IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "ConditionBlock1"; RelationName "ConditionBlock2";
          RelationName "ConditionBlock3"; RelationName "ConditionBlock4";
          RelationName "ConditionBlock5"; RelationName "ConditionBlock6";
          RelationName "ConditionBlock7"; RelationName "ConditionBlock8"]
        TargetTable =
         { Name = TableName "ConditionBlock"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConditionBlockId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "BoolOperator"
                         IsNullable = false };
             ForeignKey { Type = Int
                          Name = "FirstVariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
                          IsNullable = true };
             ForeignKey { Type = Byte
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
        Destination = EntityName "ConditionBlock"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "SelectorsCycle"
        TargetTable =
         { Name = TableName "SelectorsCycle"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "SelectorConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "EnteringCycle"
                         IsNullable = true }; ForeignKey { Type = Guid
                                                           Name = "ConditionId"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Priority"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CycleTypeId"
                                                            IsNullable = false };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "SelectorCondition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "SelectorsCycle"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmJumpIf"
        TargetTable =
         { Name = TableName "StmJumpIf"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "DestinationCycle"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "DestinationCycleLabel"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DestinationPhase"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "DestinationPhaseLabel"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DestinationStep"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ConditionId"
                                                            IsNullable = true };
             Primitive { Type = Bool
                         Name = "WithReturn"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "JumpIfPredictionBehaviorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "DestinationStepLabel"
                         IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "JumpIfPredictionBehavior"
                          Name = "JumpIfPredictionBehavior"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmJumpIf"
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
        KeyType = Guid };
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
        KeyType = Guid }] }-StmJumpIf-loader",
                            async ids => 
                            {
                                var data = await dbContext.StmJumpIfs
                                    .Where(x => x.StmJumpIf != null && ids.Contains((Guid)x.StmJumpIf))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.StmJumpIf!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.StmJumpIfs);
                    });
            
			
                Field<StmLoadsControlGraphType, StmLoadsControl>("StmLoadsControls")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmLoadsControlGraphType>>(
                            "{ Name = EntityName "Condition"
  CorrespondingTable =
   Regular
     { Name = TableName "Condition"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ConditionId"
                      IsNullable = false }; Primitive { Type = Byte
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
  Fields = [{ Name = "ConditionId"
              Type = Id Guid
              IsNullable = false }; { Name = "NumConditions"
                                      Type = Primitive Byte
                                      IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "ConditionBlock1"; RelationName "ConditionBlock2";
          RelationName "ConditionBlock3"; RelationName "ConditionBlock4";
          RelationName "ConditionBlock5"; RelationName "ConditionBlock6";
          RelationName "ConditionBlock7"; RelationName "ConditionBlock8"]
        TargetTable =
         { Name = TableName "ConditionBlock"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConditionBlockId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "BoolOperator"
                         IsNullable = false };
             ForeignKey { Type = Int
                          Name = "FirstVariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
                          IsNullable = true };
             ForeignKey { Type = Byte
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
        Destination = EntityName "ConditionBlock"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "SelectorsCycle"
        TargetTable =
         { Name = TableName "SelectorsCycle"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "SelectorConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "EnteringCycle"
                         IsNullable = true }; ForeignKey { Type = Guid
                                                           Name = "ConditionId"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Priority"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CycleTypeId"
                                                            IsNullable = false };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "SelectorCondition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "SelectorsCycle"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmJumpIf"
        TargetTable =
         { Name = TableName "StmJumpIf"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "DestinationCycle"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "DestinationCycleLabel"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DestinationPhase"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "DestinationPhaseLabel"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DestinationStep"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ConditionId"
                                                            IsNullable = true };
             Primitive { Type = Bool
                         Name = "WithReturn"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "JumpIfPredictionBehaviorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "DestinationStepLabel"
                         IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "JumpIfPredictionBehavior"
                          Name = "JumpIfPredictionBehavior"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmJumpIf"
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
        KeyType = Guid };
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
            
			
                Field<StmMaintainGraphType, StmMaintain>("StmMaintains")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmMaintainGraphType>>(
                            "{ Name = EntityName "Condition"
  CorrespondingTable =
   Regular
     { Name = TableName "Condition"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ConditionId"
                      IsNullable = false }; Primitive { Type = Byte
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
  Fields = [{ Name = "ConditionId"
              Type = Id Guid
              IsNullable = false }; { Name = "NumConditions"
                                      Type = Primitive Byte
                                      IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "ConditionBlock1"; RelationName "ConditionBlock2";
          RelationName "ConditionBlock3"; RelationName "ConditionBlock4";
          RelationName "ConditionBlock5"; RelationName "ConditionBlock6";
          RelationName "ConditionBlock7"; RelationName "ConditionBlock8"]
        TargetTable =
         { Name = TableName "ConditionBlock"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConditionBlockId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "BoolOperator"
                         IsNullable = false };
             ForeignKey { Type = Int
                          Name = "FirstVariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
                          IsNullable = true };
             ForeignKey { Type = Byte
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
        Destination = EntityName "ConditionBlock"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "SelectorsCycle"
        TargetTable =
         { Name = TableName "SelectorsCycle"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "SelectorConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "EnteringCycle"
                         IsNullable = true }; ForeignKey { Type = Guid
                                                           Name = "ConditionId"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Priority"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "CycleTypeId"
                                                            IsNullable = false };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycle"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Selector"
                          Name = "Selector"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "SelectorCondition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "SelectorsCycle"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "StmJumpIf"
        TargetTable =
         { Name = TableName "StmJumpIf"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "DestinationCycle"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "DestinationCycleLabel"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DestinationPhase"
                         IsNullable = true };
             Primitive { Type = String
                         Name = "DestinationPhaseLabel"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DestinationStep"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ConditionId"
                                                            IsNullable = true };
             Primitive { Type = Bool
                         Name = "WithReturn"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "JumpIfPredictionBehaviorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "DestinationStepLabel"
                         IsNullable = true };
             Navigation { Type = TableName "Condition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "JumpIfPredictionBehavior"
                          Name = "JumpIfPredictionBehavior"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "StmJumpIf"
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
        KeyType = Guid };
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
            
        }
    }
}
            