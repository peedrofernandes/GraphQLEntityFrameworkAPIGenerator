
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
    public partial class InductionCoilPowerTableDetailGraphType : ObjectGraphType<InductionCoilPowerTableDetail>
    {
        public InductionCoilPowerTableDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionCoilPowerTableDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Wattage, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Timeout, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ReturnLevel, type: typeof(ByteGraphType), nullable: False);
            
            Field<InductionCoilPowerTableConfigurationGraphType, InductionCoilPowerTableConfiguration>("InductionCoilPowerTableConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilPowerTableConfigurationGraphType>>(
                        "InductionCoilPowerTableDetail-InductionCoilPowerTableConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail
                                .Where(x => x.InductionCoilPowerTableConfigId != null && ids.Contains((Guid)x.InductionCoilPowerTableConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionCoilPowerTableConfigId!,
                                    Value = x.InductionCoilPowerTableConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionCoilPowerTableConfigurations);
                });
            
        }
    }
}
            