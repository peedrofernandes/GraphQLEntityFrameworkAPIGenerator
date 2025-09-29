
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
    public partial class DefaultGpioPinTypeGraphType : ObjectGraphType<DefaultGpioPinType>
    {
        public DefaultGpioPinTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.IsOutput, type: typeof(BoolGraphType), nullable: False);
            
            Field<DefaultPinDetailGraphType, DefaultPinDetail>("DefaultPinDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DefaultPinDetailGraphType>>(
                        "DefaultGpioPinType-DefaultPinDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.DefaultPinDetails
                                .Where(x => x.DefaultPinDetail != null && ids.Contains((Guid)x.DefaultPinDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.DefaultPinDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.DefaultPinDetails);
                });
            
			
            Field<UidefaultPinDetailGraphType, UidefaultPinDetail>("UidefaultPinDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UidefaultPinDetailGraphType>>(
                        "DefaultGpioPinType-UidefaultPinDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UidefaultPinDetails
                                .Where(x => x.UidefaultPinDetail != null && ids.Contains((Guid)x.UidefaultPinDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UidefaultPinDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UidefaultPinDetails);
                });
            
        }
    }
}
            