
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
			Field(t => t.ProductTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UiboolOperatorId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FirstVariableId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Operand, type: typeof(DoubleGraphType), nullable: True);
			Field(t => t.FirstOffset, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VariableGroups, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UseVisualValue, type: typeof(BoolGraphType), nullable: False);
            
            Field<UifunctionConditionGraphType, UifunctionCondition>("UifunctionConditions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UifunctionConditionGraphType>>(
                        "UiconditionBlock-UifunctionCondition-loader",
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
                        "UiconditionBlock-Uioperator-loader",
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
            