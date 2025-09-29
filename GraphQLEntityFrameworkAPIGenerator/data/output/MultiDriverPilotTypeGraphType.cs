
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
    public partial class MultiDriverPilotTypeGraphType : ObjectGraphType<MultiDriverPilotType>
    {
        public MultiDriverPilotTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PilotTypeId, type: typeof(ByteGraphType), nullable: False);
            
            Field<PilotTypeGraphType, PilotType>("PilotTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, PilotTypeGraphType>(
                        "MultiDriverPilotType-PilotType-loader",
                        async ids => 
                        {
                            var data = await dbContext.PilotTypes
                                .Where(x => x.PilotType != null && ids.Contains((byte)x.PilotType))
                                .Select(x => new
                                {
                                    Key = (byte)x.PilotType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PilotTypes);
                });
            
        }
    }
}
            