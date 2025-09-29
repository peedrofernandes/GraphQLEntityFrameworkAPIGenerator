
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
    public partial class DebounceMethodPrescalarGraphType : ObjectGraphType<DebounceMethodPrescalar>
    {
        public DebounceMethodPrescalarGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DebounceMethodPrescalarId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DebounceMethodPrescalarDescription, type: typeof(StringGraphType), nullable: False);
            
            Field<DebounceMethodParameterGraphType, DebounceMethodParameter>("DebounceMethodParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DebounceMethodParameterGraphType>>(
                        "DebounceMethodPrescalar-DebounceMethodParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.DebounceMethodParameters
                                .Where(x => x.DebounceMethodParameter != null && ids.Contains((Guid)x.DebounceMethodParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.DebounceMethodParameter!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.DebounceMethodParameters);
                });
            
        }
    }
}
            