
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
    public partial class VariableGraphType : ObjectGraphType<Variable>
    {
        public VariableGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.VariableId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Variable1, type: typeof(StringGraphType), nullable: False);
			Field(t => t.DataType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IsBitmap, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsWritable, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Offset, type: typeof(ByteGraphType), nullable: True);
            
            Field<ProductTypeGraphType, ProductType>("ProductTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<ProductTypeGraphType>>(
                        "Variable-ProductType-loader",
                        async ids => 
                        {
                            var data = await dbContext.ProductTypesVariable
                                .Where(x => x.ProductTypeId != null && ids.Contains((byte)x.ProductTypeId))
                                .Select(x => new
                                {
                                    Key = (byte)x.ProductTypeId!,
                                    Value = x.ProductType,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.ProductTypes);
                });
            
			
            Field<VariableGroupGraphType, VariableGroup>("VariableGroups")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, VariableGroupGraphType>(
                        "Variable-VariableGroup-loader",
                        async ids => 
                        {
                            var data = await dbContext.VariableGroups
                                .Where(x => x.VariableGroup.Any(c => ids.Contains(c.VariableGroupId)))
                                .Select(x => new
                                {
                                    Key = x,
                                    Values = x.VariableGroup,
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.Values.Select(v => new { Key = v.VariableGroupId, Value = x.Key }))
                                .ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.VariableGroups);
                });
            
        }
    }
}
            