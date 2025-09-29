
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
    public partial class SrexpansionDetailGraphType : ObjectGraphType<SrexpansionDetail>
    {
        public SrexpansionDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SrexpansionDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DuplicateOverTempCheckParams, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DuplicatePlausibilityCheckParams, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DuplicatePcbCheckParams, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DuplicatePinShortCheckParams, type: typeof(BoolGraphType), nullable: False);
            
            Field<SrexpansionConfigurationGraphType, SrexpansionConfiguration>("SrexpansionConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SrexpansionConfigurationGraphType>>(
                        "SrexpansionDetail-SrexpansionConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.SrexpansionConfigurationsSrexpansionDetail
                                .Where(x => x.SrexpansionConfigurationsId != null && ids.Contains((Guid)x.SrexpansionConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SrexpansionConfigurationsId!,
                                    Value = x.SrexpansionConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.SrexpansionConfigurations);
                });
            
        }
    }
}
            