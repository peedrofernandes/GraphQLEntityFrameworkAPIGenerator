
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
    public partial class MicrowavePowerTableDetailGraphType : ObjectGraphType<MicrowavePowerTableDetail>
    {
        public MicrowavePowerTableDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MicrowavePowerTableDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PowerLabel, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Smpsduty, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.OnTime, type: typeof(FloatGraphType), nullable: False);
            
            Field<MicrowavePowerTableConfigurationGraphType, MicrowavePowerTableConfiguration>("MicrowavePowerTableConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MicrowavePowerTableConfigurationGraphType>>(
                        "MicrowavePowerTableDetail-MicrowavePowerTableConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MicrowavePowerTableConfigurationsMicrowavePowerTableDetail
                                .Where(x => x.MicrowavePowerTableConfigId != null && ids.Contains((Guid)x.MicrowavePowerTableConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MicrowavePowerTableConfigId!,
                                    Value = x.MicrowavePowerTableConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MicrowavePowerTableConfigurations);
                });
            
        }
    }
}
            