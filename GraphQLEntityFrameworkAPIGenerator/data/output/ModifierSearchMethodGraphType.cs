
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
    public partial class ModifierSearchMethodGraphType : ObjectGraphType<ModifierSearchMethod>
    {
        public ModifierSearchMethodGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ModifierSearchMethodId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierSearchMethodDescription, type: typeof(StringGraphType), nullable: False);
            
            Field<ModifiersDetailGraphType, ModifiersDetail>("ModifiersDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ModifiersDetailGraphType>>(
                        "ModifierSearchMethod-ModifiersDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.ModifiersDetails
                                .Where(x => x.ModifiersDetail != null && ids.Contains((Guid)x.ModifiersDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.ModifiersDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.ModifiersDetails);
                });
            
        }
    }
}
            