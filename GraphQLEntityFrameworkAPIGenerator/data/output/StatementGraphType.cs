
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
    public partial class StatementGraphType : ObjectGraphType<Statement>
    {
        public StatementGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.StatementId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.LowStatementId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.HighStatementId, type: typeof(IdGraphType), nullable: False);
            
            Field<MacroGraphType, Macro>("Macros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MacroGraphType>>(
                        "Statement-Macro-loader",
                        async ids => 
                        {
                            var data = await dbContext.MacrosStatement
                                .Where(x => x.MacroId != null && ids.Contains((Guid)x.MacroId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MacroId!,
                                    Value = x.Macro,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Macros);
                });
            
        }
    }
}
            