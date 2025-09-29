
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
    public partial class AcuexpansionBoardConfigurationGraphType : ObjectGraphType<AcuexpansionBoardConfiguration>
    {
        public AcuexpansionBoardConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.AcuexpansionBoardConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<BoardGraphType, Board>("Boards")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<BoardGraphType>>(
                        "AcuexpansionBoardConfiguration-Board-loader",
                        async ids => 
                        {
                            var data = await dbContext.AcuexpansionBoardConfigurationsBoard
                                .Where(x => x.AcuexpansionBoardConfigId != null && ids.Contains((Guid)x.AcuexpansionBoardConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.AcuexpansionBoardConfigId!,
                                    Value = x.Board,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Boards);
                });
            
			
            Field<BoardGraphType, Board>("Boards")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<BoardGraphType>>(
                        "AcuexpansionBoardConfiguration-Board-loader",
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
            
        }
    }
}
            