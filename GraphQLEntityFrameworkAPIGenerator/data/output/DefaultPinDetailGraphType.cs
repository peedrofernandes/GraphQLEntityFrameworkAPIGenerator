
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
    public partial class DefaultPinDetailGraphType : ObjectGraphType<DefaultPinDetail>
    {
        public DefaultPinDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DefaultPinDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.VirtualPinNumber, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.High, type: typeof(BoolGraphType), nullable: False);
            
            Field<DefaultPinConfigurationGraphType, DefaultPinConfiguration>("DefaultPinConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DefaultPinConfigurationGraphType>>(
                        "DefaultPinDetail-DefaultPinConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.DefaultPinConfigurationsDefaultPinDetail
                                .Where(x => x.DefaultPinConfigurationId != null && ids.Contains((Guid)x.DefaultPinConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.DefaultPinConfigurationId!,
                                    Value = x.DefaultPinConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.DefaultPinConfigurations);
                });
            
			
            Field<DefaultGpioPinTypeGraphType, DefaultGpioPinType>("DefaultGpioPinTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<short, DefaultGpioPinTypeGraphType>(
                        "DefaultPinDetail-DefaultGpioPinType-loader",
                        async ids => 
                        {
                            var data = await dbContext.DefaultGpioPinTypes
                                .Where(x => x.DefaultGpioPinType != null && ids.Contains((short)x.DefaultGpioPinType))
                                .Select(x => new
                                {
                                    Key = (short)x.DefaultGpioPinType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.DefaultGpioPinType);
                });
            
        }
    }
}
            