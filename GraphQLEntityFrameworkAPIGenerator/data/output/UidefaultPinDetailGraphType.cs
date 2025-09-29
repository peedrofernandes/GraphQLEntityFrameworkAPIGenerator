
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
    public partial class UidefaultPinDetailGraphType : ObjectGraphType<UidefaultPinDetail>
    {
        public UidefaultPinDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UidefaultPinDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.VirtualPinNumber, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.High, type: typeof(BoolGraphType), nullable: False);
            
            Field<DefaultGpioPinTypeGraphType, DefaultGpioPinType>("DefaultGpioPinTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<short, DefaultGpioPinTypeGraphType>(
                        "UidefaultPinDetail-DefaultGpioPinType-loader",
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
            
			
            Field<UidefaultPinConfigurationGraphType, UidefaultPinConfiguration>("UidefaultPinConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UidefaultPinConfigurationGraphType>>(
                        "UidefaultPinDetail-UidefaultPinConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UidefaultPinConfigurationsUidefaultPinDetail
                                .Where(x => x.UidefaultPinConfigurationId != null && ids.Contains((Guid)x.UidefaultPinConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UidefaultPinConfigurationId!,
                                    Value = x.UidefaultPinConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UidefaultPinConfigurations);
                });
            
        }
    }
}
            