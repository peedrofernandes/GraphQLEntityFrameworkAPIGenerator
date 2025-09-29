
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
    public partial class InputTypeGraphType : ObjectGraphType<InputType>
    {
        public InputTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InputTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputTypeDsc, type: typeof(StringGraphType), nullable: False);
            
            Field<ReadTypeGraphType, ReadType>("ReadTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<ReadTypeGraphType>>(
                        "InputType-ReadType-loader",
                        async ids => 
                        {
                            var data = await dbContext.InputTypesReadType
                                .Where(x => x.InputTypeId != null && ids.Contains((byte)x.InputTypeId))
                                .Select(x => new
                                {
                                    Key = (byte)x.InputTypeId!,
                                    Value = x.ReadType,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.ReadTypes);
                });
            
			
            Field<InputGraphType, Input>("Inputs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<InputGraphType>>(
                        "InputType-Input-loader",
                        async ids => 
                        {
                            var data = await dbContext.Inputs
                                .Where(x => x.Input != null && ids.Contains((byte)x.Input))
                                .Select(x => new
                                {
                                    Key = (byte)x.Input!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Inputs);
                });
            
        }
    }
}
            