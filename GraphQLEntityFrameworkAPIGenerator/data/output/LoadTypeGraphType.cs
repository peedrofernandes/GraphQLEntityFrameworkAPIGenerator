
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
    public partial class LoadTypeGraphType : ObjectGraphType<LoadType>
    {
        public LoadTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LoadTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadTypeDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.NeedParams, type: typeof(BoolGraphType), nullable: False);
            
            Field<LoadGraphType, Load>("Loads")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<LoadGraphType>>(
                        "LoadType-Load-loader",
                        async ids => 
                        {
                            var data = await dbContext.Loads
                                .Where(x => x.Load != null && ids.Contains((byte)x.Load))
                                .Select(x => new
                                {
                                    Key = (byte)x.Load!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Loads);
                });
            
			
            Field<PilotTypeGraphType, PilotType>("PilotTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, PilotTypeGraphType>(
                        "LoadType-PilotType-loader",
                        async ids => 
                        {
                            var data = await dbContext.PilotTypes
                                .Where(x => x.PilotType.Any(c => ids.Contains(c.PilotTypeId)))
                                .Select(x => new
                                {
                                    Key = x,
                                    Values = x.PilotType,
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.Values.Select(v => new { Key = v.PilotTypeId, Value = x.Key }))
                                .ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PilotTypes);
                });
            
        }
    }
}
            