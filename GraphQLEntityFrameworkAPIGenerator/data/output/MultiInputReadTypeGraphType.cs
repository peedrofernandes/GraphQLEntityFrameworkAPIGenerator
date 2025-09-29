
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
    public partial class MultiInputReadTypeGraphType : ObjectGraphType<MultiInputReadType>
    {
        public MultiInputReadTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ReadTypeId, type: typeof(ByteGraphType), nullable: False);
            
            Field<ReadTypeGraphType, ReadType>("ReadTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ReadTypeGraphType>(
                        "MultiInputReadType-ReadType-loader",
                        async ids => 
                        {
                            var data = await dbContext.ReadTypes
                                .Where(x => x.ReadType != null && ids.Contains((byte)x.ReadType))
                                .Select(x => new
                                {
                                    Key = (byte)x.ReadType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.ReadTypes);
                });
            
        }
    }
}
            