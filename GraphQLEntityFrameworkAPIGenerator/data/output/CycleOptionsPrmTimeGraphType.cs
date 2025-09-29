
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
    public partial class CycleOptionsPrmTimeGraphType : ObjectGraphType<CycleOptionsPrmTime>
    {
        public CycleOptionsPrmTimeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.TimeOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfSelections, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.UserCookTime1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.UserCookTime2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.UserCookTime3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.UserCookTime4, type: typeof(IdGraphType), nullable: True);
			Field(t => t.UserCookTime5, type: typeof(IdGraphType), nullable: True);
			Field(t => t.UserCookTime6, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Step, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Units, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UserCookTimeDefaultSelection, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Name1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Name2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Name3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Name4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Name5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Name6, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NameDefault, type: typeof(ByteGraphType), nullable: False);
            
            Field<CycleTimeOptionsDisplayBehaviorLabelGraphType, CycleTimeOptionsDisplayBehaviorLabel>("CycleTimeOptionsDisplayBehaviorLabels")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleTimeOptionsDisplayBehaviorLabelGraphType>(
                        "CycleOptionsPrmTime-CycleTimeOptionsDisplayBehaviorLabel-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleTimeOptionsDisplayBehaviorLabels
                                .Where(x => x.CycleTimeOptionsDisplayBehaviorLabel != null && ids.Contains((byte)x.CycleTimeOptionsDisplayBehaviorLabel))
                                .Select(x => new
                                {
                                    Key = (byte)x.CycleTimeOptionsDisplayBehaviorLabel!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleTimeOptionsDisplayBehaviorLabel);
                });
            
			
            Field<CycleTimeOptionsSelectionBehaviorLabelGraphType, CycleTimeOptionsSelectionBehaviorLabel>("CycleTimeOptionsSelectionBehaviorLabels")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleTimeOptionsSelectionBehaviorLabelGraphType>(
                        "CycleOptionsPrmTime-CycleTimeOptionsSelectionBehaviorLabel-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleTimeOptionsSelectionBehaviorLabels
                                .Where(x => x.CycleTimeOptionsSelectionBehaviorLabel != null && ids.Contains((byte)x.CycleTimeOptionsSelectionBehaviorLabel))
                                .Select(x => new
                                {
                                    Key = (byte)x.CycleTimeOptionsSelectionBehaviorLabel!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleTimeOptionsSelectionBehaviorLabel);
                });
            
        }
    }
}
            