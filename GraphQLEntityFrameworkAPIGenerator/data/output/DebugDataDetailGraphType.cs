
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
    public partial class DebugDataDetailGraphType : ObjectGraphType<DebugDataDetail>
    {
        public DebugDataDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DebugDataDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DataType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DataValue, type: typeof(IdGraphType), nullable: False);
            
            Field<DebugDisplacementConfigurationGraphType, DebugDisplacementConfiguration>("DebugDisplacementConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DebugDisplacementConfigurationGraphType>>(
                        "DebugDataDetail-DebugDisplacementConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.DebugDisplacementConfigurationsDebugDataDetail
                                .Where(x => x.DebugDisplacementConfigurationsId != null && ids.Contains((Guid)x.DebugDisplacementConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.DebugDisplacementConfigurationsId!,
                                    Value = x.DebugDisplacementConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.DebugDisplacementConfigurations);
                });
            
        }
    }
}
            