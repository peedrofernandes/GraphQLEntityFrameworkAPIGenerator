
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
    public partial class CycleOptionsAssistedFormulaGraphType : ObjectGraphType<CycleOptionsAssistedFormula>
    {
        public CycleOptionsAssistedFormulaGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.AssistedFormulaParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfInputs, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Constant, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Temperature, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Coefficient1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Coefficient2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Coefficient3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Coefficient4, type: typeof(FloatGraphType), nullable: False);
            
            Field<CycleOptionsAssistedFormulaInputGraphType, CycleOptionsAssistedFormulaInput>("CycleOptionsAssistedFormulaInputs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleOptionsAssistedFormulaInputGraphType>(
                        "CycleOptionsAssistedFormula-CycleOptionsAssistedFormulaInput-loader",
                        async ids => 
                        {
                            Expression<Func<CycleOptionsAssistedFormulaInput, bool>> expr = x => !ids.Any()
                                \|\| (x.InputId1Navigation != null && ids.Contains((byte)x.InputId1Navigation))
\|\| (x.InputId2Navigation != null && ids.Contains((byte)x.InputId2Navigation))
\|\| (x.InputId3Navigation != null && ids.Contains((byte)x.InputId3Navigation))
\|\| (x.InputId4Navigation != null && ids.Contains((byte)x.InputId4Navigation));

                            var data = await dbContext.CycleOptionsAssistedFormulaInputs
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<byte?>()
                                {
                                    x.InputId1Navigation,
x.InputId2Navigation,
x.InputId3Navigation,
x.InputId4Navigation
                                }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.CycleOptionsAssistedFormulaInputs);
                });
            
        }
    }
}
            