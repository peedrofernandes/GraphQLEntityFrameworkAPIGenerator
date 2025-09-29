
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
    public partial class UiconditionGraphType : ObjectGraphType<Uicondition>
    {
        public UiconditionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiconditionId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.GireadTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.GireadTypePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Givalue, type: typeof(ByteGraphType), nullable: False);
            
            Field<UisequenceGraphType, Uisequence>("Uisequences")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UisequenceGraphType>>(
                        "Uicondition-Uisequence-loader",
                        async ids => 
                        {
                            var data = await dbContext.UisequenceConfigurationsUisequence
                                .Where(x => x.UisequenceConfigurationId != null && ids.Contains((Guid)x.UisequenceConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UisequenceConfigurationId!,
                                    Value = x.Uisequence,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Uisequences);
                });
            
			
            Field<UisequenceConfigurationGraphType, UisequenceConfiguration>("UisequenceConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UisequenceConfigurationGraphType>>(
                        "Uicondition-UisequenceConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UisequenceConfigurationsUisequence
                                .Where(x => x.UisequenceConfigurationId != null && ids.Contains((Guid)x.UisequenceConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UisequenceConfigurationId!,
                                    Value = x.UisequenceConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UisequenceConfigurations);
                });
            
			
            Field<UistepGraphType, Uistep>("Uisteps")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UistepGraphType>>(
                        "Uicondition-Uistep-loader",
                        async ids => 
                        {
                            var data = await dbContext.UistepsUicondition
                                .Where(x => x.UistepId != null && ids.Contains((Guid)x.UistepId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UistepId!,
                                    Value = x.Uistep,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Uisteps);
                });
            
        }
    }
}
            