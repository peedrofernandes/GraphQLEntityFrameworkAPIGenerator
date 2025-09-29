
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
    public partial class UistepGraphType : ObjectGraphType<Uistep>
    {
        public UistepGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UistepId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.Timer, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Timeout, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DisableFunctionLayer, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.FeedbackCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<TableTargetGraphType, TableTarget>("TableTargets")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                        "Uistep-TableTarget-loader",
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
            
			
            Field<UisequenceGraphType, Uisequence>("Uisequences")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UisequenceGraphType>>(
                        "Uistep-Uisequence-loader",
                        async ids => 
                        {
                            var data = await dbContext.UisequencesUistep
                                .Where(x => x.UisequenceId != null && ids.Contains((Guid)x.UisequenceId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UisequenceId!,
                                    Value = x.Uisequence,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Uisequences);
                });
            
			
            Field<UiconditionGraphType, Uicondition>("Uiconditions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiconditionGraphType>>(
                        "Uistep-Uicondition-loader",
                        async ids => 
                        {
                            var data = await dbContext.UistepsUicondition
                                .Where(x => x.UistepId != null && ids.Contains((Guid)x.UistepId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UistepId!,
                                    Value = x.Uicondition,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Uiconditions);
                });
            
        }
    }
}
            