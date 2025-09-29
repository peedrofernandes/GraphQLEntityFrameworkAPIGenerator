
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
    public partial class LoadsControlPilotParameterGraphType : ObjectGraphType<LoadsControlPilotParameter>
    {
        public LoadsControlPilotParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ComplexLoadsNumber, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadValue0, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue6, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue7, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue8, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.LoadValue9, type: typeof(ByteGraphType), nullable: True);
            
            Field<LoadGraphType, Load>("Loads")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, LoadGraphType>(
                        "LoadsControlPilotParameter-Load-loader",
                        async ids => 
                        {
                            Expression<Func<Load, bool>> expr = x => !ids.Any()
                                \|\| (x.LoadId0Navigation != null && ids.Contains((byte)x.LoadId0Navigation))
\|\| (x.LoadId1Navigation != null && ids.Contains((byte)x.LoadId1Navigation))
\|\| (x.LoadId2Navigation != null && ids.Contains((byte)x.LoadId2Navigation))
\|\| (x.LoadId3Navigation != null && ids.Contains((byte)x.LoadId3Navigation))
\|\| (x.LoadId4Navigation != null && ids.Contains((byte)x.LoadId4Navigation))
\|\| (x.LoadId5Navigation != null && ids.Contains((byte)x.LoadId5Navigation))
\|\| (x.LoadId6Navigation != null && ids.Contains((byte)x.LoadId6Navigation))
\|\| (x.LoadId7Navigation != null && ids.Contains((byte)x.LoadId7Navigation))
\|\| (x.LoadId8Navigation != null && ids.Contains((byte)x.LoadId8Navigation))
\|\| (x.LoadId9Navigation != null && ids.Contains((byte)x.LoadId9Navigation));

                            var data = await dbContext.Loads
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<byte?>()
                                {
                                    x.LoadId0Navigation,
x.LoadId1Navigation,
x.LoadId2Navigation,
x.LoadId3Navigation,
x.LoadId4Navigation,
x.LoadId5Navigation,
x.LoadId6Navigation,
x.LoadId7Navigation,
x.LoadId8Navigation,
x.LoadId9Navigation
                                }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.Loads);
                });
            
			
            Field<ModifierGraphType, Modifier>("Modifiers")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ModifierGraphType>(
                        "LoadsControlPilotParameter-Modifier-loader",
                        async ids => 
                        {
                            Expression<Func<Modifier, bool>> expr = x => !ids.Any()
                                \|\| (x.LoadModifierId0Navigation != null && ids.Contains((Guid)x.LoadModifierId0Navigation))
\|\| (x.LoadModifierId1Navigation != null && ids.Contains((Guid)x.LoadModifierId1Navigation))
\|\| (x.LoadModifierId2Navigation != null && ids.Contains((Guid)x.LoadModifierId2Navigation))
\|\| (x.LoadModifierId3Navigation != null && ids.Contains((Guid)x.LoadModifierId3Navigation))
\|\| (x.LoadModifierId4Navigation != null && ids.Contains((Guid)x.LoadModifierId4Navigation))
\|\| (x.LoadModifierId5Navigation != null && ids.Contains((Guid)x.LoadModifierId5Navigation))
\|\| (x.LoadModifierId6Navigation != null && ids.Contains((Guid)x.LoadModifierId6Navigation))
\|\| (x.LoadModifierId7Navigation != null && ids.Contains((Guid)x.LoadModifierId7Navigation))
\|\| (x.LoadModifierId8Navigation != null && ids.Contains((Guid)x.LoadModifierId8Navigation))
\|\| (x.LoadModifierId9Navigation != null && ids.Contains((Guid)x.LoadModifierId9Navigation));

                            var data = await dbContext.Modifiers
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.LoadModifierId0Navigation,
x.LoadModifierId1Navigation,
x.LoadModifierId2Navigation,
x.LoadModifierId3Navigation,
x.LoadModifierId4Navigation,
x.LoadModifierId5Navigation,
x.LoadModifierId6Navigation,
x.LoadModifierId7Navigation,
x.LoadModifierId8Navigation,
x.LoadModifierId9Navigation
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.Modifiers);
                });
            
			
            Field<StmLoadsControlGraphType, StmLoadsControl>("StmLoadsControls")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmLoadsControlGraphType>>(
                        "LoadsControlPilotParameter-StmLoadsControl-loader",
                        async ids => 
                        {
                            var data = await dbContext.StmLoadsControls
                                .Where(x => x.StmLoadsControl != null && ids.Contains((Guid)x.StmLoadsControl))
                                .Select(x => new
                                {
                                    Key = (Guid)x.StmLoadsControl!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.StmLoadsControls);
                });
            
        }
    }
}
            