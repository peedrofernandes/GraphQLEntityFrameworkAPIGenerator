
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
    public partial class SrsafetyRelevantParameterGraphType : ObjectGraphType<SrsafetyRelevantParameter>
    {
        public SrsafetyRelevantParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SrsafetyParametersId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MachineConfigurationGraphType>>(
                        "SrsafetyRelevantParameter-MachineConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.MachineConfigurations
                                .Where(x => x.MachineConfiguration != null && ids.Contains((Guid)x.MachineConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.MachineConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.MachineConfigurations);
                });
            
			
            Field<SrfanSpeedCheckParameterGraphType, SrfanSpeedCheckParameter>("SrfanSpeedCheckParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SrfanSpeedCheckParameterGraphType>(
                        "SrsafetyRelevantParameter-SrfanSpeedCheckParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.SrfanSpeedCheckParameters
                                .Where(x => x.SrfanSpeedCheckParameter != null && ids.Contains((Guid)x.SrfanSpeedCheckParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SrfanSpeedCheckParameter!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.SrfanSpeedCheckParameter);
                });
            
			
            Field<SrpinShortCheckParameterGraphType, SrpinShortCheckParameter>("SrpinShortCheckParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SrpinShortCheckParameterGraphType>(
                        "SrsafetyRelevantParameter-SrpinShortCheckParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.SrpinShortCheckParameters
                                .Where(x => x.SrpinShortCheckParameter != null && ids.Contains((Guid)x.SrpinShortCheckParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SrpinShortCheckParameter!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.SrpinShortCheckParameter);
                });
            
			
            Field<SrplausibilityCheckParameterGraphType, SrplausibilityCheckParameter>("SrplausibilityCheckParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SrplausibilityCheckParameterGraphType>(
                        "SrsafetyRelevantParameter-SrplausibilityCheckParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.SrplausibilityCheckParameters
                                .Where(x => x.SrplausibilityCheckParameter != null && ids.Contains((Guid)x.SrplausibilityCheckParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SrplausibilityCheckParameter!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.SrplausibilityCheckParameter);
                });
            
			
            Field<SrstuckProbeCheckParameterGraphType, SrstuckProbeCheckParameter>("SrstuckProbeCheckParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SrstuckProbeCheckParameterGraphType>(
                        "SrsafetyRelevantParameter-SrstuckProbeCheckParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.SrstuckProbeCheckParameters
                                .Where(x => x.SrstuckProbeCheckParameter != null && ids.Contains((Guid)x.SrstuckProbeCheckParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SrstuckProbeCheckParameter!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.SrstuckProbeCheckParameter);
                });
            
			
            Field<SrboilerOverTempCheckParameterGraphType, SrboilerOverTempCheckParameter>("SrboilerOverTempCheckParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SrboilerOverTempCheckParameterGraphType>(
                        "SrsafetyRelevantParameter-SrboilerOverTempCheckParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.SrboilerOverTempCheckParameters
                                .Where(x => x.SrboilerOverTempCheckParameter != null && ids.Contains((Guid)x.SrboilerOverTempCheckParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SrboilerOverTempCheckParameter!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.SrboilerOverTempCheckParameter);
                });
            
			
            Field<SrexpansionConfigurationGraphType, SrexpansionConfiguration>("SrexpansionConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SrexpansionConfigurationGraphType>(
                        "SrsafetyRelevantParameter-SrexpansionConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.SrexpansionConfigurations
                                .Where(x => x.SrexpansionConfiguration != null && ids.Contains((Guid)x.SrexpansionConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SrexpansionConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.SrexpansionConfiguration);
                });
            
			
            Field<SrhmieventCheckParameterGraphType, SrhmieventCheckParameter>("SrhmieventCheckParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SrhmieventCheckParameterGraphType>(
                        "SrsafetyRelevantParameter-SrhmieventCheckParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.SrhmieventCheckParameters
                                .Where(x => x.SrhmieventCheckParameter != null && ids.Contains((Guid)x.SrhmieventCheckParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SrhmieventCheckParameter!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.SrhmieventCheckParameter);
                });
            
			
            Field<SroverTempCheckParameterGraphType, SroverTempCheckParameter>("SroverTempCheckParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SroverTempCheckParameterGraphType>(
                        "SrsafetyRelevantParameter-SroverTempCheckParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.SroverTempCheckParameters
                                .Where(x => x.SroverTempCheckParameter != null && ids.Contains((Guid)x.SroverTempCheckParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SroverTempCheckParameter!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.SroverTempCheckParameter);
                });
            
			
            Field<SrpcbcheckParameterGraphType, SrpcbcheckParameter>("SrpcbcheckParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SrpcbcheckParameterGraphType>(
                        "SrsafetyRelevantParameter-SrpcbcheckParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.SrpcbcheckParameters
                                .Where(x => x.SrpcbcheckParameter != null && ids.Contains((Guid)x.SrpcbcheckParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SrpcbcheckParameter!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.SrpcbcheckParameter);
                });
            
        }
    }
}
            