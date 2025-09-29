
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
    public partial class GenericInputDetailGraphType : ObjectGraphType<GenericInputDetail>
    {
        public GenericInputDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.GenericInputDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ReadTypePos, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ParametersId, type: typeof(GuidGraphType), nullable: True);
            
            Field<GenericInputConfigurationGraphType, GenericInputConfiguration>("GenericInputConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<GenericInputConfigurationGraphType>>(
                        "GenericInputDetail-GenericInputConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.GenericInputConfigurationsGenericInputDetail
                                .Where(x => x.GenericInputConfigurationId != null && ids.Contains((Guid)x.GenericInputConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.GenericInputConfigurationId!,
                                    Value = x.GenericInputConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.GenericInputConfigurations);
                });
            
			
            Field<InputGraphType, Input>("Inputs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, InputGraphType>(
                        "GenericInputDetail-Input-loader",
                        async ids => 
                        {
                            var data = await dbContext.Inputs
                                .Where(x => x.Input != null && ids.Contains((byte)x.Input))
                                .Select(x => new
                                {
                                    Key = (byte)x.Input!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Input);
                });
            
			
            Field<ReadTypeGraphType, ReadType>("ReadTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ReadTypeGraphType>(
                        "GenericInputDetail-ReadType-loader",
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
            
        }
    }
}
            