
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
    public partial class ModifierOperatorGraphType : ObjectGraphType<ModifierOperator>
    {
        public ModifierOperatorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ModifierOperatorId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierOperatorDescription, type: typeof(StringGraphType), nullable: False);
            
            Field<ModifierGraphType, Modifier>("Modifiers")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ModifierGraphType>>(
                        "ModifierOperator-Modifier-loader",
                        async ids => 
                        {
                            var data = await dbContext.Modifiers
                                .Where(x => x.Modifier != null && ids.Contains((Guid)x.Modifier))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Modifier!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Modifiers);
                });
            
        }
    }
}
            