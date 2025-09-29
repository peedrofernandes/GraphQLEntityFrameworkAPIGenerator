
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
    public partial class CycleNameGraphType : ObjectGraphType<CycleName>
    {
        public CycleNameGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(IdGraphType), nullable: False);
			Field(t => t.CycleName1, type: typeof(StringGraphType), nullable: False);
			Field(t => t.CycleSubHeading, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IsForSubcycles, type: typeof(BoolGraphType), nullable: False);
            
            Field<CycleGroupGraphType, CycleGroup>("CycleGroups")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleGroupGraphType>(
                        "CycleName-CycleGroup-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleGroups
                                .Where(x => x.CycleGroup != null && ids.Contains((byte)x.CycleGroup))
                                .Select(x => new
                                {
                                    Key = (byte)x.CycleGroup!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleGroup);
                });
            
			
            Field<CycleHeadingGraphType, CycleHeading>("CycleHeadings")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleHeadingGraphType>(
                        "CycleName-CycleHeading-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleHeadings
                                .Where(x => x.CycleHeading != null && ids.Contains((byte)x.CycleHeading))
                                .Select(x => new
                                {
                                    Key = (byte)x.CycleHeading!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleHeading);
                });
            
			
            Field<CycleGraphType, Cycle>("Cycles")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleGraphType>>(
                        "CycleName-Cycle-loader",
                        async ids => 
                        {
                            var data = await dbContext.Cycles
                                .Where(x => x.Cycle != null && ids.Contains((Guid)x.Cycle))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Cycle!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Cycles);
                });
            
        }
    }
}
            