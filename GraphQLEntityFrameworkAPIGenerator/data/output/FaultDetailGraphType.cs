
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
    public partial class FaultDetailGraphType : ObjectGraphType<FaultDetail>
    {
        public FaultDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FaultDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.FaultId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Code, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SubCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.EngineeringCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PauseCycle, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DirectToFault, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.FaultParametersId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.HasSubCycle, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.SubCycleNameId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Phase, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AllowClearWithoutRemovingFault, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ClearFaultAfterColdReset, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CancelCycleOnly, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.EngineeringCodeMethod, type: typeof(BoolGraphType), nullable: False);
            
            Field<DebounceMethodParameterGraphType, DebounceMethodParameter>("DebounceMethodParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DebounceMethodParameterGraphType>(
                        "FaultDetail-DebounceMethodParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.DebounceMethodParameters
                                .Where(x => x.DebounceMethodParameter != null && ids.Contains((Guid)x.DebounceMethodParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.DebounceMethodParameter!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.DebounceMethodParameter);
                });
            
			
            Field<FaultConfigurationGraphType, FaultConfiguration>("FaultConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<FaultConfigurationGraphType>>(
                        "FaultDetail-FaultConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.FaultConfigurationsFaultDetail
                                .Where(x => x.FaultConfigurationsId != null && ids.Contains((Guid)x.FaultConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.FaultConfigurationsId!,
                                    Value = x.FaultConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.FaultConfigurations);
                });
            
			
            Field<MacroGraphType, Macro>("Macros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MacroGraphType>(
                        "FaultDetail-Macro-loader",
                        async ids => 
                        {
                            var data = await dbContext.Macros
                                .Where(x => x.Macro != null && ids.Contains((Guid)x.Macro))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Macro!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Macro);
                });
            
			
            Field<TargetGraphType, Target>("Targets")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TargetGraphType>(
                        "FaultDetail-Target-loader",
                        async ids => 
                        {
                            var data = await dbContext.Targets
                                .Where(x => x.Target != null && ids.Contains((byte)x.Target))
                                .Select(x => new
                                {
                                    Key = (byte)x.Target!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Target);
                });
            
        }
    }
}
            