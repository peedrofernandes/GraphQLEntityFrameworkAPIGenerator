
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
    public partial class UiclassBeventDetailGraphType : ObjectGraphType<UiclassBeventDetail>
    {
        public UiclassBeventDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiclassBeventDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SrinputPos, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Srevent, type: typeof(ByteGraphType), nullable: False);
            
            Field<UigenericInputReadTypeGraphType, UigenericInputReadType>("UigenericInputReadTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, UigenericInputReadTypeGraphType>(
                        "UiclassBeventDetail-UigenericInputReadType-loader",
                        async ids => 
                        {
                            var data = await dbContext.UigenericInputReadTypes
                                .Where(x => x.UigenericInputReadType != null && ids.Contains((byte)x.UigenericInputReadType))
                                .Select(x => new
                                {
                                    Key = (byte)x.UigenericInputReadType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UigenericInputReadType);
                });
            
			
            Field<UiclassBeventConfigurationGraphType, UiclassBeventConfiguration>("UiclassBeventConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiclassBeventConfigurationGraphType>>(
                        "UiclassBeventDetail-UiclassBeventConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiclassBeventConfigurationsUiclassBeventDetail
                                .Where(x => x.UiclassBeventConfigurationId != null && ids.Contains((Guid)x.UiclassBeventConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiclassBeventConfigurationId!,
                                    Value = x.UiclassBeventConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiclassBeventConfigurations);
                });
            
        }
    }
}
            