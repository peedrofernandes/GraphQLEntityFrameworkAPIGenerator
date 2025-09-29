
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
    public partial class StmSetVariableGraphType : ObjectGraphType<StmSetVariable>
    {
        public StmSetVariableGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Operation, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex, type: typeof(IdGraphType), nullable: False);
			Field(t => t.VariableOffset, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Operand, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex1, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand1, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet1, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex2, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand2, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet2, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex3, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand3, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet3, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex4, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand4, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet4, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex5, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand5, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet5, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation6, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex6, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset6, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand6, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet6, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition6, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation7, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex7, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset7, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand7, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet7, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition7, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation8, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex8, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset8, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand8, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet8, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition8, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operation9, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableIndex9, type: typeof(IdGraphType), nullable: True);
			Field(t => t.VariableOffset9, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Operand9, type: typeof(ShortGraphType), nullable: True);
			Field(t => t.IsSet9, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.BitPosition9, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VariableGroups1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups6, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups7, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups8, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.VariableGroups9, type: typeof(ByteGraphType), nullable: True);
            
            Field<ModifierGraphType, Modifier>("Modifiers")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ModifierGraphType>(
                        "StmSetVariable-Modifier-loader",
                        async ids => 
                        {
                            Expression<Func<Modifier, bool>> expr = x => !ids.Any()
                                \|\| (x.Modifier1Navigation != null && ids.Contains((Guid)x.Modifier1Navigation))
\|\| (x.Modifier2Navigation != null && ids.Contains((Guid)x.Modifier2Navigation))
\|\| (x.Modifier3Navigation != null && ids.Contains((Guid)x.Modifier3Navigation))
\|\| (x.Modifier4Navigation != null && ids.Contains((Guid)x.Modifier4Navigation))
\|\| (x.Modifier5Navigation != null && ids.Contains((Guid)x.Modifier5Navigation))
\|\| (x.Modifier6Navigation != null && ids.Contains((Guid)x.Modifier6Navigation))
\|\| (x.Modifier7Navigation != null && ids.Contains((Guid)x.Modifier7Navigation))
\|\| (x.Modifier8Navigation != null && ids.Contains((Guid)x.Modifier8Navigation))
\|\| (x.Modifier9Navigation != null && ids.Contains((Guid)x.Modifier9Navigation))
\|\| (x.ModifierNavigation != null && ids.Contains((Guid)x.ModifierNavigation));

                            var data = await dbContext.Modifiers
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.Modifier1Navigation,
x.Modifier2Navigation,
x.Modifier3Navigation,
x.Modifier4Navigation,
x.Modifier5Navigation,
x.Modifier6Navigation,
x.Modifier7Navigation,
x.Modifier8Navigation,
x.Modifier9Navigation,
x.ModifierNavigation
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.Modifiers);
                });
            
			
            Field<ProductTypeGraphType, ProductType>("ProductTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ProductTypeGraphType>(
                        "StmSetVariable-ProductType-loader",
                        async ids => 
                        {
                            var data = await dbContext.ProductTypes
                                .Where(x => x.ProductType != null && ids.Contains((byte)x.ProductType))
                                .Select(x => new
                                {
                                    Key = (byte)x.ProductType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.ProductType);
                });
            
        }
    }
}
            