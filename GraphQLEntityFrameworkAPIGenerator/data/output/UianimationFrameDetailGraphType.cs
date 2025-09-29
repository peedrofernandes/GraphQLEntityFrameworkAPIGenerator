
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
    public partial class UianimationFrameDetailGraphType : ObjectGraphType<UianimationFrameDetail>
    {
        public UianimationFrameDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UianimationFrameDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Pattern, type: typeof(LongGraphType), nullable: False);
			Field(t => t.TimeOn, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.FrameIntensity, type: typeof(ByteGraphType), nullable: False);
            
            Field<UianimationFrameConfigurationGraphType, UianimationFrameConfiguration>("UianimationFrameConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UianimationFrameConfigurationGraphType>>(
                        "UianimationFrameDetail-UianimationFrameConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UianimationFrameConfigurationsUianimationFrameDetail
                                .Where(x => x.UianimationFrameConfigurationsId != null && ids.Contains((Guid)x.UianimationFrameConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UianimationFrameConfigurationsId!,
                                    Value = x.UianimationFrameConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UianimationFrameConfigurations);
                });
            
        }
    }
}
            