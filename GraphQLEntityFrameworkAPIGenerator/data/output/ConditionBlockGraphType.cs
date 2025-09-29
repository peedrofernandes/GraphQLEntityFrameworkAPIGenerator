
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
			Field(t => t.FirstVariableId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.OperatorId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SecondVariableId, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Operand, type: typeof(DoubleGraphType), nullable: True);
			Field(t => t.Mask, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.FirstOffset, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SecondOffset, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.IsNot, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.FirstVariableGroupId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SecondVariableGroupId, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ProductTypeId, type: typeof(ByteGraphType), nullable: False);
            
            Field<ConditionGraphType, Condition>("Conditions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ConditionGraphType>>(
                        "ConditionBlock-Condition-loader",
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
            