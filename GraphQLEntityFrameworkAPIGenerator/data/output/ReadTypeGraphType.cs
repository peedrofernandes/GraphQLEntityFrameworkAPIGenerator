
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
    public partial class ReadTypeGraphType : ObjectGraphType<ReadType>
    {
        public ReadTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ReadTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadTypeDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.ReadTypeMax, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumPins, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NeedParams, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Automatic, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.NumReadings, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Multiplexed, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Inverted, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Partialized, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Acline, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Vreference, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Compensated, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Delta, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Rotation, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PullUp, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Feedback, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.SecondFeedback, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ChannelDischarge, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsSafetyRelevant, type: typeof(BoolGraphType), nullable: False);
            
            Field<GenericInputDetailGraphType, GenericInputDetail>("GenericInputDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<GenericInputDetailGraphType>>(
                        "ReadType-GenericInputDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.GenericInputDetails
                                .Where(x => x.GenericInputDetail != null && ids.Contains((Guid)x.GenericInputDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.GenericInputDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.GenericInputDetails);
                });
            
			
            Field<InputTypeGraphType, InputType>("InputTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<InputTypeGraphType>>(
                        "ReadType-InputType-loader",
                        async ids => 
                        {
                            var data = await dbContext.InputTypesReadType
                                .Where(x => x.InputTypeId != null && ids.Contains((byte)x.InputTypeId))
                                .Select(x => new
                                {
                                    Key = (byte)x.InputTypeId!,
                                    Value = x.InputType,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InputTypes);
                });
            
			
            Field<LowLevelInputDetailGraphType, LowLevelInputDetail>("LowLevelInputDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LowLevelInputDetailGraphType>>(
                        "ReadType-LowLevelInputDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.LowLevelInputDetails
                                .Where(x => x.LowLevelInputDetail != null && ids.Contains((Guid)x.LowLevelInputDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.LowLevelInputDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.LowLevelInputDetails);
                });
            
			
            Field<MultiInputReadTypeGraphType, MultiInputReadType>("MultiInputReadTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, MultiInputReadTypeGraphType>(
                        "ReadType-MultiInputReadType-loader",
                        async ids => 
                        {
                            var data = await dbContext.MultiInputReadTypes
                                .Where(x => x.MultiInputReadType != null && ids.Contains((byte)x.MultiInputReadType))
                                .Select(x => new
                                {
                                    Key = (byte)x.MultiInputReadType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MultiInputReadTypes);
                });
            
			
            Field<PrmReadMultiInputGraphType, PrmReadMultiInput>("PrmReadMultiInputs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmReadMultiInputGraphType>>(
                        "ReadType-PrmReadMultiInput-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrmReadMultiInputs
                                .Where(x => x.PrmReadMultiInput != null && ids.Contains((Guid)x.PrmReadMultiInput))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrmReadMultiInput!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.PrmReadMultiInputs);
                });
            
			
            Field<UigenericInputDetailGraphType, UigenericInputDetail>("UigenericInputDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UigenericInputDetailGraphType>>(
                        "ReadType-UigenericInputDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UigenericInputDetails
                                .Where(x => x.UigenericInputDetail != null && ids.Contains((Guid)x.UigenericInputDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UigenericInputDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UigenericInputDetails);
                });
            
			
            Field<UiinputGraphType, Uiinput>("Uiinputs")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<UiinputGraphType>>(
                        "ReadType-Uiinput-loader",
                        async ids => 
                        {
                            var data = await dbContext.Uiinputs
                                .Where(x => x.Uiinput != null && ids.Contains((byte)x.Uiinput))
                                .Select(x => new
                                {
                                    Key = (byte)x.Uiinput!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Uiinputs);
                });
            
        }
    }
}
            