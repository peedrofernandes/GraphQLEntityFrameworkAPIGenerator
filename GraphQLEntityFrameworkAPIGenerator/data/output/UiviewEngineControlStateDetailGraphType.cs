
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
    public partial class UiviewEngineControlStateDetailGraphType : ObjectGraphType<UiviewEngineControlStateDetail>
    {
        public UiviewEngineControlStateDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiviewEngineControlStateDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<UimacroGraphType, Uimacro>("Uimacros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UimacroGraphType>(
                        "UiviewEngineControlStateDetail-Uimacro-loader",
                        async ids => 
                        {
                            Expression<Func<Uimacro, bool>> expr = x => !ids.Any()
                                \|\| (x.DoMacro != null && ids.Contains((Guid)x.DoMacro))
\|\| (x.OnEntryMacro != null && ids.Contains((Guid)x.OnEntryMacro))
\|\| (x.OnExitMacro != null && ids.Contains((Guid)x.OnExitMacro));

                            var data = await dbContext.Uimacros
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.DoMacro,
x.OnEntryMacro,
x.OnExitMacro
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.Uimacros);
                });
            
			
            Field<UiviewEngineControlStateConfigurationGraphType, UiviewEngineControlStateConfiguration>("UiviewEngineControlStateConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiviewEngineControlStateConfigurationGraphType>>(
                        "UiviewEngineControlStateDetail-UiviewEngineControlStateConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail
                                .Where(x => x.UiviewEngineControlStateConfigurationsId != null && ids.Contains((Guid)x.UiviewEngineControlStateConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiviewEngineControlStateConfigurationsId!,
                                    Value = x.UiviewEngineControlStateConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiviewEngineControlStateConfigurations);
                });
            
        }
    }
}
            