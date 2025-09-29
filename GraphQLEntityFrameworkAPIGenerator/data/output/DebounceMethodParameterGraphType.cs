
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
    public partial class DebounceMethodParameterGraphType : ObjectGraphType<DebounceMethodParameter>
    {
        public DebounceMethodParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DebounceMethodParametersId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PrefaultDelay, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FaultDelay, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RemovedPrefaultDelay, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RemovedFaultDelay, type: typeof(ByteGraphType), nullable: False);
            
            Field<DebounceMethodGraphType, DebounceMethod>("DebounceMethods")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, DebounceMethodGraphType>(
                        "DebounceMethodParameter-DebounceMethod-loader",
                        async ids => 
                        {
                            Expression<Func<DebounceMethod, bool>> expr = x => !ids.Any()
                                \|\| (x.FaultDebounceMethod != null && ids.Contains((byte)x.FaultDebounceMethod))
\|\| (x.PrefaultDebounceMethod != null && ids.Contains((byte)x.PrefaultDebounceMethod));

                            var data = await dbContext.DebounceMethods
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<byte?>()
                                {
                                    x.FaultDebounceMethod,
x.PrefaultDebounceMethod
                                }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.DebounceMethods);
                });
            
			
            Field<FaultDetailGraphType, FaultDetail>("FaultDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<FaultDetailGraphType>>(
                        "DebounceMethodParameter-FaultDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.FaultDetails
                                .Where(x => x.FaultDetail != null && ids.Contains((Guid)x.FaultDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.FaultDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.FaultDetails);
                });
            
			
            Field<DebounceMethodPrescalarGraphType, DebounceMethodPrescalar>("DebounceMethodPrescalars")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, DebounceMethodPrescalarGraphType>(
                        "DebounceMethodParameter-DebounceMethodPrescalar-loader",
                        async ids => 
                        {
                            Expression<Func<DebounceMethodPrescalar, bool>> expr = x => !ids.Any()
                                \|\| (x.FaultPrescalar != null && ids.Contains((byte)x.FaultPrescalar))
\|\| (x.PrefaultPrescalar != null && ids.Contains((byte)x.PrefaultPrescalar))
\|\| (x.RemovedFaultPrescalar != null && ids.Contains((byte)x.RemovedFaultPrescalar))
\|\| (x.RemovedPrefaultPrescalar != null && ids.Contains((byte)x.RemovedPrefaultPrescalar));

                            var data = await dbContext.DebounceMethodPrescalars
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<byte?>()
                                {
                                    x.FaultPrescalar,
x.PrefaultPrescalar,
x.RemovedFaultPrescalar,
x.RemovedPrefaultPrescalar
                                }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.DebounceMethodPrescalars);
                });
            
        }
    }
}
            