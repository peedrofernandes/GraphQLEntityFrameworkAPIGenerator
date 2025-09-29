
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
    public partial class UigenericInputReadTypeGraphType : ObjectGraphType<UigenericInputReadType>
    {
        public UigenericInputReadTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UireadTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UireadTypeDsc, type: typeof(StringGraphType), nullable: False);
            
            Field<UiclassBeventDetailGraphType, UiclassBeventDetail>("UiclassBeventDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiclassBeventDetailGraphType>>(
                        "UigenericInputReadType-UiclassBeventDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiclassBeventDetails
                                .Where(x => x.UiclassBeventDetail != null && ids.Contains((Guid)x.UiclassBeventDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiclassBeventDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UiclassBeventDetails);
                });
            
			
            Field<UiinputGraphType, Uiinput>("Uiinputs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<UiinputGraphType>>(
                        "UigenericInputReadType-Uiinput-loader",
                        async ids => 
                        {
                            var data = await dbContext.Uiinputs
                                .Where(x => x.Uiinput != null && ids.Contains((byte)x.Uiinput))
                                .Select(x => new
                                {
                                    Key = (byte)x.Uiinput!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Uiinputs);
                });
            
			
            Field<UisreventDetailGraphType, UisreventDetail>("UisreventDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UisreventDetailGraphType>>(
                        "UigenericInputReadType-UisreventDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UisreventDetails
                                .Where(x => x.UisreventDetail != null && ids.Contains((Guid)x.UisreventDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UisreventDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UisreventDetails);
                });
            
        }
    }
}
            