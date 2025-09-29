
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
    public partial class UigenericInputDetailGraphType : ObjectGraphType<UigenericInputDetail>
    {
        public UigenericInputDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UigenericInputDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.GireadTypePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LlireadTypePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ParametersId, type: typeof(GuidGraphType), nullable: True);
            
            Field<ReadTypeGraphType, ReadType>("ReadTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ReadTypeGraphType>(
                        "UigenericInputDetail-ReadType-loader",
                        async ids => 
                        {
                            var data = await dbContext.ReadTypes
                                .Where(x => x.ReadType != null && ids.Contains((byte)x.ReadType))
                                .Select(x => new
                                {
                                    Key = (byte)x.ReadType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.ReadType);
                });
            
			
            Field<UigenericInputConfigurationGraphType, UigenericInputConfiguration>("UigenericInputConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UigenericInputConfigurationGraphType>>(
                        "UigenericInputDetail-UigenericInputConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UigenericInputConfigurationsUigenericInputDetail
                                .Where(x => x.UigenericInputConfigurationId != null && ids.Contains((Guid)x.UigenericInputConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UigenericInputConfigurationId!,
                                    Value = x.UigenericInputConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UigenericInputConfigurations);
                });
            
			
            Field<UiinputGraphType, Uiinput>("Uiinputs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, UiinputGraphType>(
                        "UigenericInputDetail-Uiinput-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Uiinput);
                });
            
        }
    }
}
            