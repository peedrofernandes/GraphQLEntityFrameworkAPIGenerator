
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
    public partial class UistmSetIncompatibilityGraphType : ObjectGraphType<UistmSetIncompatibility>
    {
        public UistmSetIncompatibilityGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.RegulationValue, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MinIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DefaultIndex, type: typeof(ByteGraphType), nullable: False);
            
                Field<UifunctionConditionGraphType, UifunctionCondition>("UifunctionConditions")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UifunctionConditionGraphType>(
                            "{ Name = EntityName "UistmSetIncompatibility"
  CorrespondingTable =
   Regular
     { Name = TableName "UistmSetIncompatibility"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; ForeignKey { Type = Guid
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "RegulationValue"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "MinIndex"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "DefaultIndex"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        IsNullable = true
        KeyType = Guid }] }-UifunctionCondition-loader",
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

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UifunctionCondition);
                });
            
        }
    }
}
            