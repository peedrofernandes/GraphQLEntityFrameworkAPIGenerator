
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
    public partial class UistmSetVariableGraphType : ObjectGraphType<UistmSetVariable>
    {
        public UistmSetVariableGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.VariableIndex, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.VariableOffset, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VariableGroup, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ProductType, type: typeof(ByteGraphType), nullable: False);
            
                Field<UifunctionConditionGraphType, UifunctionCondition>("UifunctionConditions")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UifunctionConditionGraphType>(
                            "{ Name = EntityName "UistmSetVariable"
  CorrespondingTable =
   Regular
     { Name = TableName "UistmSetVariable"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = Int
                                                        Name = "VariableIndex"
                                                        IsNullable = false };
         Primitive { Type = Double
                     Name = "Value"
                     IsNullable = false }; ForeignKey { Type = Guid
                                                        Name = "ConditionId"
                                                        IsNullable = true };
         Primitive { Type = Byte
                     Name = "VariableOffset"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "VariableGroup"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ProductType"
                     IsNullable = false };
         Navigation { Type = TableName "UifunctionCondition"
                      Name = "Condition"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "VariableIndex"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "Value"
                                                      Type = Primitive Double
                                                      IsNullable = false };
    { Name = "VariableOffset"
      Type = Primitive Byte
      IsNullable = false }; { Name = "VariableGroup"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ProductType"
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
            