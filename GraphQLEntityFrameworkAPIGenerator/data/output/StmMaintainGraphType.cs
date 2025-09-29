
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
    public partial class StmMaintainGraphType : ObjectGraphType<StmMaintain>
    {
        public StmMaintainGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Time, type: typeof(IdGraphType), nullable: False);
			Field(t => t.IsAdd, type: typeof(BoolGraphType), nullable: False);
            
            Field<ConditionGraphType, Condition>("Conditions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ConditionGraphType>(
                        "StmMaintain-Condition-loader",
                        async ids => 
                        {
                            var data = await dbContext.Conditions
                                .Where(x => x.Condition != null && ids.Contains((Guid)x.Condition))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Condition!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Condition);
                });
            
			
            Field<ModifierGraphType, Modifier>("Modifiers")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ModifierGraphType>(
                        "StmMaintain-Modifier-loader",
                        async ids => 
                        {
                            var data = await dbContext.Modifiers
                                .Where(x => x.Modifier != null && ids.Contains((Guid)x.Modifier))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Modifier!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Modifier);
                });
            
        }
    }
}
            