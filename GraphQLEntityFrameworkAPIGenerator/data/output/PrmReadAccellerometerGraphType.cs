
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
    public partial class PrmReadAccellerometerGraphType : ObjectGraphType<PrmReadAccellerometer>
    {
        public PrmReadAccellerometerGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Device, type: typeof(ByteGraphType), nullable: False);
            
            Field<PrmReadAccellerometerStlisxDhGraphType, PrmReadAccellerometerStlisxDh>("PrmReadAccellerometerStlisxDhs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrmReadAccellerometerStlisxDhGraphType>(
                        "PrmReadAccellerometer-PrmReadAccellerometerStlisxDh-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrmReadAccellerometerStlisxDhs
                                .Where(x => x.PrmReadAccellerometerStlisxDh != null && ids.Contains((Guid)x.PrmReadAccellerometerStlisxDh))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrmReadAccellerometerStlisxDh!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrmReadAccellerometerStlisxDh);
                });
            
        }
    }
}
            