
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
    public partial class PrmReadMultiInputGraphType : ObjectGraphType<PrmReadMultiInput>
    {
        public PrmReadMultiInputGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ReadParametersId0, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ReadParametersId1, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ReadParametersId2, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ReadParametersId3, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.NumOfPins, type: typeof(ByteGraphType), nullable: False);
            
            Field<ReadTypeGraphType, ReadType>("ReadTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ReadTypeGraphType>(
                        "PrmReadMultiInput-ReadType-loader",
                        async ids => 
                        {
                            Expression<Func<ReadType, bool>> expr = x => !ids.Any()
                                \|\| (x.ReadTypeId0Navigation != null && ids.Contains((byte)x.ReadTypeId0Navigation))
\|\| (x.ReadTypeId1Navigation != null && ids.Contains((byte)x.ReadTypeId1Navigation))
\|\| (x.ReadTypeId2Navigation != null && ids.Contains((byte)x.ReadTypeId2Navigation))
\|\| (x.ReadTypeId3Navigation != null && ids.Contains((byte)x.ReadTypeId3Navigation));

                            var data = await dbContext.ReadTypes
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<byte?>()
                                {
                                    x.ReadTypeId0Navigation,
x.ReadTypeId1Navigation,
x.ReadTypeId2Navigation,
x.ReadTypeId3Navigation
                                }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.ReadTypes);
                });
            
        }
    }
}
            