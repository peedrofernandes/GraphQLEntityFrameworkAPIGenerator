
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
    public partial class LowLevelInputConfigurationGraphType : ObjectGraphType<LowLevelInputConfiguration>
    {
        public LowLevelInputConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LowLevelInputConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.Board, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<BoardGraphType, Board>("Boards")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<BoardGraphType>>(
                        "LowLevelInputConfiguration-Board-loader",
                        async ids => 
                        {
                            var data = await dbContext.Boards
                                .Where(x => x.Board != null && ids.Contains((Guid)x.Board))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Board!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Boards);
                });
            
			
            Field<DisplayGraphType, Display>("Displays")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DisplayGraphType>>(
                        "LowLevelInputConfiguration-Display-loader",
                        async ids => 
                        {
                            var data = await dbContext.Displays
                                .Where(x => x.Display != null && ids.Contains((Guid)x.Display))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Display!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Displays);
                });
            
			
            Field<LowLevelInputDetailGraphType, LowLevelInputDetail>("LowLevelInputDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LowLevelInputDetailGraphType>>(
                        "LowLevelInputConfiguration-LowLevelInputDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.LowLevelInputConfigurationsLowLevelInputDetail
                                .Where(x => x.LowLevelInputConfigurationId != null && ids.Contains((Guid)x.LowLevelInputConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.LowLevelInputConfigurationId!,
                                    Value = x.LowLevelInputDetail,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.LowLevelInputDetails);
                });
            
			
            Field<TableTargetGraphType, TableTarget>("TableTargets")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                        "LowLevelInputConfiguration-TableTarget-loader",
                        async ids => 
                        {
                            var data = await dbContext.TableTargets
                                .Where(x => x.TableTarget != null && ids.Contains((byte)x.TableTarget))
                                .Select(x => new
                                {
                                    Key = (byte)x.TableTarget!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.TableTarget);
                });
            
        }
    }
}
            