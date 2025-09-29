
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
    public partial class UianimationDetailGraphType : ObjectGraphType<UianimationDetail>
    {
        public UianimationDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UianimationDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.AnimationType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PatternExecutions, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Csf, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Iaf, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Tsf, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Cef, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Df, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Rf, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Period, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TimeBetweenRepeats, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.AnimationFunction, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AnimationIndex, type: typeof(ByteGraphType), nullable: False);
            
            Field<UianimationBlinkTypeGraphType, UianimationBlinkType>("UianimationBlinkTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UianimationBlinkTypeGraphType>(
                        "UianimationDetail-UianimationBlinkType-loader",
                        async ids => 
                        {
                            var data = await dbContext.UianimationBlinkTypes
                                .Where(x => x.UianimationBlinkType != null && ids.Contains((Guid)x.UianimationBlinkType))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UianimationBlinkType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UianimationBlinkType);
                });
            
			
            Field<UianimationConfigurationGraphType, UianimationConfiguration>("UianimationConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UianimationConfigurationGraphType>>(
                        "UianimationDetail-UianimationConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UianimationConfigurationsUianimationDetail
                                .Where(x => x.UianimationConfigurationId != null && ids.Contains((Guid)x.UianimationConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UianimationConfigurationId!,
                                    Value = x.UianimationConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UianimationConfigurations);
                });
            
			
            Field<UianimationFadingTypeGraphType, UianimationFadingType>("UianimationFadingTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UianimationFadingTypeGraphType>(
                        "UianimationDetail-UianimationFadingType-loader",
                        async ids => 
                        {
                            var data = await dbContext.UianimationFadingTypes
                                .Where(x => x.UianimationFadingType != null && ids.Contains((Guid)x.UianimationFadingType))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UianimationFadingType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UianimationFadingType);
                });
            
			
            Field<UianimationFrameConfigurationGraphType, UianimationFrameConfiguration>("UianimationFrameConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UianimationFrameConfigurationGraphType>(
                        "UianimationDetail-UianimationFrameConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UianimationFrameConfigurations
                                .Where(x => x.UianimationFrameConfiguration != null && ids.Contains((Guid)x.UianimationFrameConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UianimationFrameConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UianimationFrameConfiguration);
                });
            
			
            Field<UianimationSequenceTypeGraphType, UianimationSequenceType>("UianimationSequenceTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UianimationSequenceTypeGraphType>(
                        "UianimationDetail-UianimationSequenceType-loader",
                        async ids => 
                        {
                            var data = await dbContext.UianimationSequenceTypes
                                .Where(x => x.UianimationSequenceType != null && ids.Contains((Guid)x.UianimationSequenceType))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UianimationSequenceType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UianimationSequenceType);
                });
            
        }
    }
}
            