
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
    public partial class CycleOptionsDetailGraphType : ObjectGraphType<CycleOptionsDetail>
    {
        public CycleOptionsDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleOptionsDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Input1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputValue1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Input2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputValue2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OptionTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OptionId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.NumberOfModifiers, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Grouping1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Grouping2, type: typeof(ByteGraphType), nullable: False);
            
            Field<CycleOptionsConfigurationGraphType, CycleOptionsConfiguration>("CycleOptionsConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsConfigurationGraphType>>(
                        "CycleOptionsDetail-CycleOptionsConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleOptionsConfigurationsCycleOptionsDetail
                                .Where(x => x.CycleOptionsConfigurationsId != null && ids.Contains((Guid)x.CycleOptionsConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleOptionsConfigurationsId!,
                                    Value = x.CycleOptionsConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleOptionsConfigurations);
                });
            
        }
    }
}
            