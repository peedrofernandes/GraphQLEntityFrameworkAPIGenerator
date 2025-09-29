
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
    public partial class SelectorConfigurationGraphType : ObjectGraphType<SelectorConfiguration>
    {
        public SelectorConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SelectorConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Code, type: typeof(StringGraphType), nullable: False);
            
            Field<UimacroGraphType, Uimacro>("Uimacros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UimacroGraphType>(
                        "SelectorConfiguration-Uimacro-loader",
                        async ids => 
                        {
                            var data = await dbContext.Uimacros
                                .Where(x => x.Uimacro != null && ids.Contains((Guid)x.Uimacro))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Uimacro!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Uimacro);
                });
            
			
            Field<ProjectGraphType, Project>("Projects")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ProjectGraphType>>(
                        "SelectorConfiguration-Project-loader",
                        async ids => 
                        {
                            var data = await dbContext.Projects
                                .Where(x => x.Project != null && ids.Contains((Guid)x.Project))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Project!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Projects);
                });
            
			
            Field<SelectorGraphType, Selector>("Selectors")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorGraphType>>(
                        "SelectorConfiguration-Selector-loader",
                        async ids => 
                        {
                            var data = await dbContext.SelectorConfigurationsSelector
                                .Where(x => x.SelectorConfigurationId != null && ids.Contains((Guid)x.SelectorConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SelectorConfigurationId!,
                                    Value = x.Selector,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Selectors);
                });
            
			
            Field<UifunctionConfigurationGraphType, UifunctionConfiguration>("UifunctionConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UifunctionConfigurationGraphType>(
                        "SelectorConfiguration-UifunctionConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UifunctionConfigurations
                                .Where(x => x.UifunctionConfiguration != null && ids.Contains((Guid)x.UifunctionConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UifunctionConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UifunctionConfiguration);
                });
            
        }
    }
}
            