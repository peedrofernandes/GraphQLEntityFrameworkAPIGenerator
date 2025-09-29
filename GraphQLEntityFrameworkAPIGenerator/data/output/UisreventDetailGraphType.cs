
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
    public partial class UisreventDetailGraphType : ObjectGraphType<UisreventDetail>
    {
        public UisreventDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UisreventDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SrinputPos, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Srevent, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SreventPrmId, type: typeof(GuidGraphType), nullable: True);
            
            Field<UigenericInputReadTypeGraphType, UigenericInputReadType>("UigenericInputReadTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, UigenericInputReadTypeGraphType>(
                        "UisreventDetail-UigenericInputReadType-loader",
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
            
			
            Field<UisreventConfigurationGraphType, UisreventConfiguration>("UisreventConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UisreventConfigurationGraphType>>(
                        "UisreventDetail-UisreventConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UisreventConfigurationsUisreventDetail
                                .Where(x => x.UisreventConfigurationId != null && ids.Contains((Guid)x.UisreventConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UisreventConfigurationId!,
                                    Value = x.UisreventConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UisreventConfigurations);
                });
            
        }
    }
}
            