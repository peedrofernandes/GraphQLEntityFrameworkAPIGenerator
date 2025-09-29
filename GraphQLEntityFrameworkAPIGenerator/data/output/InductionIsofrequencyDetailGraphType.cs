
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
    public partial class InductionIsofrequencyDetailGraphType : ObjectGraphType<InductionIsofrequencyDetail>
    {
        public InductionIsofrequencyDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionIsofreqDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfCoils, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AdjacentCoil0, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.AdjacentCoil1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.AdjacentCoil2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.AdjacentCoil3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.AdjacentCoil4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.AdjacentCoil5, type: typeof(ByteGraphType), nullable: True);
            
            Field<InductionIsofrequencyConfigurationGraphType, InductionIsofrequencyConfiguration>("InductionIsofrequencyConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionIsofrequencyConfigurationGraphType>>(
                        "InductionIsofrequencyDetail-InductionIsofrequencyConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionIsofrequencyConfigurationsInductionIsofrequencyDetail
                                .Where(x => x.InductionIsofreqConfigId != null && ids.Contains((Guid)x.InductionIsofreqConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionIsofreqConfigId!,
                                    Value = x.InductionIsofreqConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionIsofrequencyConfigurations);
                });
            
        }
    }
}
            