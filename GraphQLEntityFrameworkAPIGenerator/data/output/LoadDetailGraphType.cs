
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
    public partial class LoadDetailGraphType : ObjectGraphType<LoadDetail>
    {
        public LoadDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LoadDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Pin1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.OnLevel1, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OnLevel2, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OnLevel3, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OnLevel4, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PilotParametersId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadParametersId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.Uidriven, type: typeof(BoolGraphType), nullable: False);
            
            Field<FeedbackParameterGraphType, FeedbackParameter>("FeedbackParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, FeedbackParameterGraphType>(
                        "LoadDetail-FeedbackParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.FeedbackParameters
                                .Where(x => x.FeedbackParameter != null && ids.Contains((Guid)x.FeedbackParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.FeedbackParameter!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.FeedbackParameter);
                });
            
			
            Field<LoadGraphType, Load>("Loads")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, LoadGraphType>(
                        "LoadDetail-Load-loader",
                        async ids => 
                        {
                            var data = await dbContext.Loads
                                .Where(x => x.Load != null && ids.Contains((byte)x.Load))
                                .Select(x => new
                                {
                                    Key = (byte)x.Load!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Load);
                });
            
			
            Field<LoadConfigurationGraphType, LoadConfiguration>("LoadConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LoadConfigurationGraphType>>(
                        "LoadDetail-LoadConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.LoadConfigurationsLoadDetail
                                .Where(x => x.LoadConfigurationId != null && ids.Contains((Guid)x.LoadConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.LoadConfigurationId!,
                                    Value = x.LoadConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.LoadConfigurations);
                });
            
			
            Field<PilotTypeGraphType, PilotType>("PilotTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, PilotTypeGraphType>(
                        "LoadDetail-PilotType-loader",
                        async ids => 
                        {
                            var data = await dbContext.PilotTypes
                                .Where(x => x.PilotType != null && ids.Contains((byte)x.PilotType))
                                .Select(x => new
                                {
                                    Key = (byte)x.PilotType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PilotType);
                });
            
        }
    }
}
            