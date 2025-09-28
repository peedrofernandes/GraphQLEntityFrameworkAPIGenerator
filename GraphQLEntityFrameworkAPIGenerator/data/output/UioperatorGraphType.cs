
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
    public partial class UioperatorGraphType : ObjectGraphType<Uioperator>
    {
        public UioperatorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UioperatorId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Uioperator1, type: typeof(StringGraphType), nullable: False);
            
                Field<UiconditionBlockGraphType, UiconditionBlock>("UiconditionBlocks")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiconditionBlockGraphType>>(
                            "{ Name = EntityName "Uioperator"
  CorrespondingTable =
   Regular
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
  Fields = [{ Name = "UioperatorId"
              Type = Id Byte
              IsNullable = false }; { Name = "Uioperator1"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UiconditionBlock"
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
        KeyType = Guid }] }-UiconditionBlock-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiconditionBlocks
                                    .Where(x => x.UiconditionBlock != null && ids.Contains((Guid)x.UiconditionBlock))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiconditionBlock!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiconditionBlocks);
                    });
            
        }
    }
}
            