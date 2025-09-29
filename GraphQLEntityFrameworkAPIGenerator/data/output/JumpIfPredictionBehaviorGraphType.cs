
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
    public partial class JumpIfPredictionBehaviorGraphType : ObjectGraphType<JumpIfPredictionBehavior>
    {
        public JumpIfPredictionBehaviorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.JumpIfPredictionBehaviorId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.JumpIfPredictionBehaviorDescription, type: typeof(StringGraphType), nullable: False);
            
            Field<StmJumpIfGraphType, StmJumpIf>("StmJumpIfs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmJumpIfGraphType>>(
                        "JumpIfPredictionBehavior-StmJumpIf-loader",
                        async ids => 
                        {
                            var data = await dbContext.StmJumpIfs
                                .Where(x => x.StmJumpIf != null && ids.Contains((Guid)x.StmJumpIf))
                                .Select(x => new
                                {
                                    Key = (Guid)x.StmJumpIf!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.StmJumpIfs);
                });
            
        }
    }
}
            