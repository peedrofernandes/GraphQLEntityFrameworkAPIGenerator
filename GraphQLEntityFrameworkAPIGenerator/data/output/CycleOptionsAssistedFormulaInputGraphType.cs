
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
    public partial class CycleOptionsAssistedFormulaInputGraphType : ObjectGraphType<CycleOptionsAssistedFormulaInput>
    {
        public CycleOptionsAssistedFormulaInputGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
            
            Field<CycleOptionsAssistedFormulaGraphType, CycleOptionsAssistedFormula>("CycleOptionsAssistedFormulas")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsAssistedFormulaGraphType>>(
                        "CycleOptionsAssistedFormulaInput-CycleOptionsAssistedFormula-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleOptionsAssistedFormulas
                                .Where(x => x.CycleOptionsAssistedFormula != null && ids.Contains((Guid)x.CycleOptionsAssistedFormula))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleOptionsAssistedFormula!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.CycleOptionsAssistedFormulas);
                });
            
        }
    }
}
            