
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
    public partial class ModifiersDetailGraphType : ObjectGraphType<ModifiersDetail>
    {
        public ModifiersDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ModifiersDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumItems, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VariableIndex, type: typeof(IdGraphType), nullable: False);
			Field(t => t.VariableOffset, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierValues, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.ModifiedValues, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.IsPercent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.VariableGroupId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ProductTypeId, type: typeof(ByteGraphType), nullable: False);
            
            Field<ModifierGraphType, Modifier>("Modifiers")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ModifierGraphType>>(
                        "ModifiersDetail-Modifier-loader",
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
            
			
            Field<ModifierSearchMethodGraphType, ModifierSearchMethod>("ModifierSearchMethods")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ModifierSearchMethodGraphType>(
                        "ModifiersDetail-ModifierSearchMethod-loader",
                        async ids => 
                        {
                            var data = await dbContext.ModifierSearchMethods
                                .Where(x => x.ModifierSearchMethod != null && ids.Contains((byte)x.ModifierSearchMethod))
                                .Select(x => new
                                {
                                    Key = (byte)x.ModifierSearchMethod!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.ModifierSearchMethod);
                });
            
        }
    }
}
            