
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
    public partial class StmLoadsControlGraphType : ObjectGraphType<StmLoadsControl>
    {
        public StmLoadsControlGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.LoadsList, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.TimeOn, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TimeOff, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.StartOff, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PartialControl, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ActivateOptions, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Resume, type: typeof(BoolGraphType), nullable: False);
            
            Field<ConditionGraphType, Condition>("Conditions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ConditionGraphType>(
                        "StmLoadsControl-Condition-loader",
                        async ids => 
                        {
                            Expression<Func<Condition, bool>> expr = x => !ids.Any()
                                \|\| (x.Condition != null && ids.Contains((Guid)x.Condition))
\|\| (x.DeactivationCondition != null && ids.Contains((Guid)x.DeactivationCondition));

                            var data = await dbContext.Conditions
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.Condition,
x.DeactivationCondition
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.Conditions);
                });
            
			
            Field<LoadsControlPilotParameterGraphType, LoadsControlPilotParameter>("LoadsControlPilotParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, LoadsControlPilotParameterGraphType>(
                        "StmLoadsControl-LoadsControlPilotParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.LoadsControlPilotParameters
                                .Where(x => x.LoadsControlPilotParameter != null && ids.Contains((Guid)x.LoadsControlPilotParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.LoadsControlPilotParameter!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.LoadsControlPilotParameter);
                });
            
        }
    }
}
            