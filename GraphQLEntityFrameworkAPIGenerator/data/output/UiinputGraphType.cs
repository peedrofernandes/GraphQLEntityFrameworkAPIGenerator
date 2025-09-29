
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
    public partial class UiinputGraphType : ObjectGraphType<Uiinput>
    {
        public UiinputGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiinputId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UiinputDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.NeedParams, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsSafetyRelevant, type: typeof(BoolGraphType), nullable: False);
            
            Field<UigenericInputReadTypeGraphType, UigenericInputReadType>("UigenericInputReadTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, UigenericInputReadTypeGraphType>(
                        "Uiinput-UigenericInputReadType-loader",
                        async ids => 
                        {
                            var data = await dbContext.UigenericInputReadTypes
                                .Where(x => x.UigenericInputReadType != null && ids.Contains((byte)x.UigenericInputReadType))
                                .Select(x => new
                                {
                                    Key = (byte)x.UigenericInputReadType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UigenericInputReadType);
                });
            
			
            Field<ReadTypeGraphType, ReadType>("ReadTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ReadTypeGraphType>(
                        "Uiinput-ReadType-loader",
                        async ids => 
                        {
                            Expression<Func<ReadType, bool>> expr = x => !ids.Any()
                                \|\| (x.LlireadType != null && ids.Contains((byte)x.LlireadType))
\|\| (x.ReadTypes != null && ids.Contains((byte)x.ReadTypes));

                            var data = await dbContext.ReadTypes
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<byte?>()
                                {
                                    x.LlireadType,
x.ReadTypes
                                }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.ReadTypes);
                });
            
			
            Field<UigenericInputDetailGraphType, UigenericInputDetail>("UigenericInputDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UigenericInputDetailGraphType>>(
                        "Uiinput-UigenericInputDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UigenericInputDetails
                                .Where(x => x.UigenericInputDetail != null && ids.Contains((Guid)x.UigenericInputDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UigenericInputDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UigenericInputDetails);
                });
            
        }
    }
}
            