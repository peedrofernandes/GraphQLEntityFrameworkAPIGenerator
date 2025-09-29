
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
    public partial class StmJumpIfGraphType : ObjectGraphType<StmJumpIf>
    {
        public StmJumpIfGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DestinationCycle, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DestinationCycleLabel, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DestinationPhase, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DestinationPhaseLabel, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DestinationStep, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.WithReturn, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DestinationStepLabel, type: typeof(StringGraphType), nullable: True);
            
            Field<ConditionGraphType, Condition>("Conditions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ConditionGraphType>(
                        "StmJumpIf-Condition-loader",
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
            
			
            Field<JumpIfPredictionBehaviorGraphType, JumpIfPredictionBehavior>("JumpIfPredictionBehaviors")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, JumpIfPredictionBehaviorGraphType>(
                        "StmJumpIf-JumpIfPredictionBehavior-loader",
                        async ids => 
                        {
                            var data = await dbContext.JumpIfPredictionBehaviors
                                .Where(x => x.JumpIfPredictionBehavior != null && ids.Contains((byte)x.JumpIfPredictionBehavior))
                                .Select(x => new
                                {
                                    Key = (byte)x.JumpIfPredictionBehavior!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.JumpIfPredictionBehavior);
                });
            
        }
    }
}
            