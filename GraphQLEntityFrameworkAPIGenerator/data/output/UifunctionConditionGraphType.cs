
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
    public partial class UifunctionConditionGraphType : ObjectGraphType<UifunctionCondition>
    {
        public UifunctionConditionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ConditionId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumConditions, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiconditionBlockGraphType, UiconditionBlock>("UiconditionBlocks")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiconditionBlockGraphType>(
                            "{ Name = EntityName "UifunctionCondition"
  CorrespondingTable =
   Regular
     { Name = TableName "UifunctionCondition"
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
         { Name = TableName "UiconditionBlock"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiconditionBlockId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UiboolOperatorId"
                          IsNullable = false };
             ForeignKey { Type = Int
                          Name = "FirstVariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UioperatorId"
                          IsNullable = false }; Primitive { Type = Double
                                                            Name = "Operand"
                                                            IsNullable = true };
             Primitive { Type = Byte
                         Name = "FirstOffset"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroups"
                         IsNullable = false };
             Primitive { Type = Bool
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
        Destination = EntityName "UiconditionBlock"
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
      { Name = RelationName "UistmSetIncompatibility"
        TargetTable =
         { Name = TableName "UistmSetIncompatibility"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "RegulationValue"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "MinIndex"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "DefaultIndex"
                         IsNullable = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmSetIncompatibility"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UistmSetVariable"
        TargetTable =
         { Name = TableName "UistmSetVariable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false }; Primitive { Type = Double
                                                           Name = "Value"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroup"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ProductType"
                                                           IsNullable = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmSetVariable"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UistmVisualJumpIf"
        TargetTable =
         { Name = TableName "UistmVisualJumpIf"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Step"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmVisualJumpIf"
        KeyType = Guid }] }-UiconditionBlock-loader",
                            async ids => 
                            {
                                Expression<Func<UiconditionBlock, bool>> expr = x => !ids.Any()
                                    \|\| (x.ConditionBlock1 != null && ids.Contains((Guid)x.ConditionBlock1))
\|\| (x.ConditionBlock2 != null && ids.Contains((Guid)x.ConditionBlock2))
\|\| (x.ConditionBlock3 != null && ids.Contains((Guid)x.ConditionBlock3))
\|\| (x.ConditionBlock4 != null && ids.Contains((Guid)x.ConditionBlock4))
\|\| (x.ConditionBlock5 != null && ids.Contains((Guid)x.ConditionBlock5))
\|\| (x.ConditionBlock6 != null && ids.Contains((Guid)x.ConditionBlock6))
\|\| (x.ConditionBlock7 != null && ids.Contains((Guid)x.ConditionBlock7))
\|\| (x.ConditionBlock8 != null && ids.Contains((Guid)x.ConditionBlock8));

                                var data = await dbContext.UiconditionBlocks
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

                        return loader.LoadAsync(context.Source.UiconditionBlocks);
                    });
            
			
                Field<SelectorsCycleGraphType, SelectorsCycle>("SelectorsCycles")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorsCycleGraphType>>(
                            "{ Name = EntityName "UifunctionCondition"
  CorrespondingTable =
   Regular
     { Name = TableName "UifunctionCondition"
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
         { Name = TableName "UiconditionBlock"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiconditionBlockId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UiboolOperatorId"
                          IsNullable = false };
             ForeignKey { Type = Int
                          Name = "FirstVariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UioperatorId"
                          IsNullable = false }; Primitive { Type = Double
                                                            Name = "Operand"
                                                            IsNullable = true };
             Primitive { Type = Byte
                         Name = "FirstOffset"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroups"
                         IsNullable = false };
             Primitive { Type = Bool
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
        Destination = EntityName "UiconditionBlock"
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
      { Name = RelationName "UistmSetIncompatibility"
        TargetTable =
         { Name = TableName "UistmSetIncompatibility"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "RegulationValue"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "MinIndex"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "DefaultIndex"
                         IsNullable = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmSetIncompatibility"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UistmSetVariable"
        TargetTable =
         { Name = TableName "UistmSetVariable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false }; Primitive { Type = Double
                                                           Name = "Value"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroup"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ProductType"
                                                           IsNullable = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmSetVariable"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UistmVisualJumpIf"
        TargetTable =
         { Name = TableName "UistmVisualJumpIf"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Step"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmVisualJumpIf"
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
            
			
                Field<UistmSetIncompatibilityGraphType, UistmSetIncompatibility>("UistmSetIncompatibilitys")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UistmSetIncompatibilityGraphType>>(
                            "{ Name = EntityName "UifunctionCondition"
  CorrespondingTable =
   Regular
     { Name = TableName "UifunctionCondition"
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
         { Name = TableName "UiconditionBlock"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiconditionBlockId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UiboolOperatorId"
                          IsNullable = false };
             ForeignKey { Type = Int
                          Name = "FirstVariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UioperatorId"
                          IsNullable = false }; Primitive { Type = Double
                                                            Name = "Operand"
                                                            IsNullable = true };
             Primitive { Type = Byte
                         Name = "FirstOffset"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroups"
                         IsNullable = false };
             Primitive { Type = Bool
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
        Destination = EntityName "UiconditionBlock"
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
      { Name = RelationName "UistmSetIncompatibility"
        TargetTable =
         { Name = TableName "UistmSetIncompatibility"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "RegulationValue"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "MinIndex"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "DefaultIndex"
                         IsNullable = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmSetIncompatibility"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UistmSetVariable"
        TargetTable =
         { Name = TableName "UistmSetVariable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false }; Primitive { Type = Double
                                                           Name = "Value"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroup"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ProductType"
                                                           IsNullable = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmSetVariable"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UistmVisualJumpIf"
        TargetTable =
         { Name = TableName "UistmVisualJumpIf"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Step"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmVisualJumpIf"
        KeyType = Guid }] }-UistmSetIncompatibility-loader",
                            async ids => 
                            {
                                var data = await dbContext.UistmSetIncompatibilitys
                                    .Where(x => x.UistmSetIncompatibility != null && ids.Contains((Guid)x.UistmSetIncompatibility))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UistmSetIncompatibility!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UistmSetIncompatibilitys);
                    });
            
			
                Field<UistmSetVariableGraphType, UistmSetVariable>("UistmSetVariables")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UistmSetVariableGraphType>>(
                            "{ Name = EntityName "UifunctionCondition"
  CorrespondingTable =
   Regular
     { Name = TableName "UifunctionCondition"
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
         { Name = TableName "UiconditionBlock"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiconditionBlockId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UiboolOperatorId"
                          IsNullable = false };
             ForeignKey { Type = Int
                          Name = "FirstVariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UioperatorId"
                          IsNullable = false }; Primitive { Type = Double
                                                            Name = "Operand"
                                                            IsNullable = true };
             Primitive { Type = Byte
                         Name = "FirstOffset"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroups"
                         IsNullable = false };
             Primitive { Type = Bool
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
        Destination = EntityName "UiconditionBlock"
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
      { Name = RelationName "UistmSetIncompatibility"
        TargetTable =
         { Name = TableName "UistmSetIncompatibility"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "RegulationValue"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "MinIndex"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "DefaultIndex"
                         IsNullable = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmSetIncompatibility"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UistmSetVariable"
        TargetTable =
         { Name = TableName "UistmSetVariable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false }; Primitive { Type = Double
                                                           Name = "Value"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroup"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ProductType"
                                                           IsNullable = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmSetVariable"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UistmVisualJumpIf"
        TargetTable =
         { Name = TableName "UistmVisualJumpIf"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Step"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmVisualJumpIf"
        KeyType = Guid }] }-UistmSetVariable-loader",
                            async ids => 
                            {
                                var data = await dbContext.UistmSetVariables
                                    .Where(x => x.UistmSetVariable != null && ids.Contains((Guid)x.UistmSetVariable))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UistmSetVariable!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UistmSetVariables);
                    });
            
			
                Field<UistmVisualJumpIfGraphType, UistmVisualJumpIf>("UistmVisualJumpIfs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UistmVisualJumpIfGraphType>>(
                            "{ Name = EntityName "UifunctionCondition"
  CorrespondingTable =
   Regular
     { Name = TableName "UifunctionCondition"
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
         { Name = TableName "UiconditionBlock"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiconditionBlockId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UiboolOperatorId"
                          IsNullable = false };
             ForeignKey { Type = Int
                          Name = "FirstVariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UioperatorId"
                          IsNullable = false }; Primitive { Type = Double
                                                            Name = "Operand"
                                                            IsNullable = true };
             Primitive { Type = Byte
                         Name = "FirstOffset"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroups"
                         IsNullable = false };
             Primitive { Type = Bool
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
        Destination = EntityName "UiconditionBlock"
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
      { Name = RelationName "UistmSetIncompatibility"
        TargetTable =
         { Name = TableName "UistmSetIncompatibility"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "RegulationValue"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "MinIndex"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "DefaultIndex"
                         IsNullable = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmSetIncompatibility"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UistmSetVariable"
        TargetTable =
         { Name = TableName "UistmSetVariable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false }; Primitive { Type = Double
                                                           Name = "Value"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableGroup"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ProductType"
                                                           IsNullable = false };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmSetVariable"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UistmVisualJumpIf"
        TargetTable =
         { Name = TableName "UistmVisualJumpIf"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Step"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ConditionId"
                          IsNullable = true };
             Navigation { Type = TableName "UifunctionCondition"
                          Name = "Condition"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UistmVisualJumpIf"
        KeyType = Guid }] }-UistmVisualJumpIf-loader",
                            async ids => 
                            {
                                var data = await dbContext.UistmVisualJumpIfs
                                    .Where(x => x.UistmVisualJumpIf != null && ids.Contains((Guid)x.UistmVisualJumpIf))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UistmVisualJumpIf!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UistmVisualJumpIfs);
                    });
            
        }
    }
}
            