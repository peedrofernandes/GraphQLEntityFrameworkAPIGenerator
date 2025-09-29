
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
    public partial class FunctionLabelGraphType : ObjectGraphType<FunctionLabel>
    {
        public FunctionLabelGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FunctionLabelId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FunctionLabel1, type: typeof(StringGraphType), nullable: False);
            
            Field<UifunctionConfigurationGraphType, UifunctionConfiguration>("UifunctionConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UifunctionConfigurationGraphType>>(
                        "FunctionLabel-UifunctionConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UifunctionConfigurationsUifunctionDetail
                                .Where(x => x.UifunctionConfigurationId != null && ids.Contains((Guid)x.UifunctionConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UifunctionConfigurationId!,
                                    Value = x.UifunctionConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UifunctionConfigurations);
                });
            
			
            Field<UifunctionDetailGraphType, UifunctionDetail>("UifunctionDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UifunctionDetailGraphType>>(
                        "FunctionLabel-UifunctionDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UifunctionConfigurationsUifunctionDetail
                                .Where(x => x.UifunctionConfigurationId != null && ids.Contains((Guid)x.UifunctionConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UifunctionConfigurationId!,
                                    Value = x.UifunctionDetail,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UifunctionDetails);
                });
            
			
            Field<UiregulationTableGraphType, UiregulationTable>("UiregulationTables")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiregulationTableGraphType>>(
                        "FunctionLabel-UiregulationTable-loader",
                        async ids => 
                        {
                            var data = await dbContext.UifunctionConfigurationsUifunctionDetail
                                .Where(x => x.UifunctionConfigurationId != null && ids.Contains((Guid)x.UifunctionConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UifunctionConfigurationId!,
                                    Value = x.UiregulationTable,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiregulationTables);
                });
            
        }
    }
}
            