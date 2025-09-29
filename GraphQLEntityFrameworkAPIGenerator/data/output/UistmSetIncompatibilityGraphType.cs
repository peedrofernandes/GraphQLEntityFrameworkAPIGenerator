
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
			Field(t => t.FunctionsList, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.RegulationValue, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.EnableFunctionsList, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.MinIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DefaultIndex, type: typeof(ByteGraphType), nullable: False);
            
            Field<UifunctionConditionGraphType, UifunctionCondition>("UifunctionConditions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UifunctionConditionGraphType>(
                        "UistmSetIncompatibility-UifunctionCondition-loader",
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
            