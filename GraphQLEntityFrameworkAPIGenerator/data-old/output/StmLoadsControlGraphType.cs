
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
    public partial class StmLoadsControlGraphType : ObjectGraphType<StmLoadsControl>
    {
        public StmLoadsControlGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TimeOn, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TimeOff, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.StartOff, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PartialControl, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ActivateOptions, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Resume, type: typeof(BoolGraphType), nullable: False);
            
                Field<ConditionGraphType, Condition>("Conditions")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ConditionGraphType>(
                            "{ Name = EntityName "StmLoadsControl"
  CorrespondingTable =
   Regular
     { Name = TableName "StmLoadsControl"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; ForeignKey { Type = Guid
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
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ActivateOptions"
                                                       IsNullable = false };
         Primitive { Type = Bool
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "TimeOn"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "TimeOff"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "StartOff"
      Type = Primitive Bool
      IsNullable = false }; { Name = "PartialControl"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ActivateOptions"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Resume"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names = [RelationName "Condition"; RelationName "DeactivationCondition"]
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
        IsNullable = true
        KeyType = Guid }] }-Condition-loader",
                            async ids => 
                            {
                                Expression<Func<Condition, bool>> expr = x => !ids.Any()
                                    \|\| (x.Condition != null && ids.Contains((Guid)x.Condition))
\|\| (x.DeactivationCondition != null && ids.Contains((Guid)x.DeactivationCondition));

                                var data = await dbContext.Conditions
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.Condition,
x.DeactivationCondition
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.Conditions);
                    });
            
			
                Field<LoadsControlPilotParameterGraphType, LoadsControlPilotParameter>("LoadsControlPilotParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, LoadsControlPilotParameterGraphType>(
                            "{ Name = EntityName "StmLoadsControl"
  CorrespondingTable =
   Regular
     { Name = TableName "StmLoadsControl"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; ForeignKey { Type = Guid
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
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ActivateOptions"
                                                       IsNullable = false };
         Primitive { Type = Bool
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "TimeOn"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "TimeOff"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "StartOff"
      Type = Primitive Bool
      IsNullable = false }; { Name = "PartialControl"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ActivateOptions"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Resume"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names = [RelationName "Condition"; RelationName "DeactivationCondition"]
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
        IsNullable = true
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

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.LoadsControlPilotParameter);
                });
            
        }
    }
}
            