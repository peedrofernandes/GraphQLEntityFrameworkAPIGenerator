
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
    public partial class StmJumpIfGraphType : ObjectGraphType<StmJumpIf>
    {
        public StmJumpIfGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DestinationCycle, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DestinationCycleLabel, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DestinationPhase, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DestinationPhaseLabel, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DestinationStep, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.WithReturn, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DestinationStepLabel, type: typeof(StringGraphType), nullable: True);
            
                Field<ConditionGraphType, Condition>("Conditions")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ConditionGraphType>(
                            "{ Name = EntityName "StmJumpIf"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "DestinationPhase"
                                                      IsNullable = true };
         Primitive { Type = String
                     Name = "DestinationPhaseLabel"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "DestinationStep"
                                                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "ConditionId"
                      IsNullable = true }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "DestinationCycle"
                              Type = Primitive Byte
                              IsNullable = true };
    { Name = "DestinationCycleLabel"
      Type = Primitive String
      IsNullable = true }; { Name = "DestinationPhase"
                             Type = Primitive Byte
                             IsNullable = true };
    { Name = "DestinationPhaseLabel"
      Type = Primitive String
      IsNullable = true }; { Name = "DestinationStep"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "WithReturn"
                                                     Type = Primitive Bool
                                                     IsNullable = false };
    { Name = "DestinationStepLabel"
      Type = Primitive String
      IsNullable = true }]
  Relations =
   [SingleManyToOne
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
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "JumpIfPredictionBehavior"
        TargetTable =
         { Name = TableName "JumpIfPredictionBehavior"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "JumpIfPredictionBehaviorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "JumpIfPredictionBehaviorDescription"
                         IsNullable = false };
             Navigation { Type = TableName "StmJumpIf"
                          Name = "StmJumpIfs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "JumpIfPredictionBehavior"
        IsNullable = false
        KeyType = Byte }] }-Condition-loader",
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

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Condition);
                });
            
			
                Field<JumpIfPredictionBehaviorGraphType, JumpIfPredictionBehavior>("JumpIfPredictionBehaviors")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, JumpIfPredictionBehaviorGraphType>(
                            "{ Name = EntityName "StmJumpIf"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "DestinationPhase"
                                                      IsNullable = true };
         Primitive { Type = String
                     Name = "DestinationPhaseLabel"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "DestinationStep"
                                                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "ConditionId"
                      IsNullable = true }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "DestinationCycle"
                              Type = Primitive Byte
                              IsNullable = true };
    { Name = "DestinationCycleLabel"
      Type = Primitive String
      IsNullable = true }; { Name = "DestinationPhase"
                             Type = Primitive Byte
                             IsNullable = true };
    { Name = "DestinationPhaseLabel"
      Type = Primitive String
      IsNullable = true }; { Name = "DestinationStep"
                             Type = Primitive Byte
                             IsNullable = false }; { Name = "WithReturn"
                                                     Type = Primitive Bool
                                                     IsNullable = false };
    { Name = "DestinationStepLabel"
      Type = Primitive String
      IsNullable = true }]
  Relations =
   [SingleManyToOne
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
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "JumpIfPredictionBehavior"
        TargetTable =
         { Name = TableName "JumpIfPredictionBehavior"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "JumpIfPredictionBehaviorId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "JumpIfPredictionBehaviorDescription"
                         IsNullable = false };
             Navigation { Type = TableName "StmJumpIf"
                          Name = "StmJumpIfs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "JumpIfPredictionBehavior"
        IsNullable = false
        KeyType = Byte }] }-JumpIfPredictionBehavior-loader",
                            async ids => 
                            {
                                var data = await dbContext.JumpIfPredictionBehaviors
                                    .Where(x => x.JumpIfPredictionBehavior != null && ids.Contains((byte)x.JumpIfPredictionBehavior))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.JumpIfPredictionBehavior!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.JumpIfPredictionBehavior);
                });
            
        }
    }
}
            