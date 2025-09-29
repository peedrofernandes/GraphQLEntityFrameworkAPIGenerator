
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
    public partial class UistatementGraphType : ObjectGraphType<Uistatement>
    {
        public UistatementGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UistatementId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.OpCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.F0, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.F1, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.LowStatementId, type: typeof(GuidGraphType), nullable: True);
            
            Field<UimacroGraphType, Uimacro>("Uimacros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UimacroGraphType>>(
                        "Uistatement-Uimacro-loader",
                        async ids => 
                        {
                            var data = await dbContext.UimacrosUistatement
                                .Where(x => x.UimacroId != null && ids.Contains((Guid)x.UimacroId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UimacroId!,
                                    Value = x.Uimacro,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Uimacros);
                });
            
        }
    }
}
            