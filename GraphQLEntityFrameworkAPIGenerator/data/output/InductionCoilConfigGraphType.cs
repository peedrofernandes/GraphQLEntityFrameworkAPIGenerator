
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
    public partial class InductionCoilConfigGraphType : ObjectGraphType<InductionCoilConfig>
    {
        public InductionCoilConfigGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionCoilConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CoilLoadId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.HeatsinkNtcgiid, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.CoilNtcgiid, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Acntcgiid, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.HeatsinkFanLoadId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IgbtTemperatureGiid, type: typeof(ByteGraphType), nullable: False);
            
            Field<InductionCoilNtcspecificGraphType, InductionCoilNtcspecific>("InductionCoilNtcspecifics")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilNtcspecificGraphType>(
                        "InductionCoilConfig-InductionCoilNtcspecific-loader",
                        async ids => 
                        {
                            Expression<Func<InductionCoilNtcspecific, bool>> expr = x => !ids.Any()
                                \|\| (x.Acntcspecific != null && ids.Contains((Guid)x.Acntcspecific))
\|\| (x.CoilNtcspecific != null && ids.Contains((Guid)x.CoilNtcspecific))
\|\| (x.IgbtSafetyParams != null && ids.Contains((Guid)x.IgbtSafetyParams))
\|\| (x.InductionCoilHeatsinkNtcspecific != null && ids.Contains((Guid)x.InductionCoilHeatsinkNtcspecific));

                            var data = await dbContext.InductionCoilNtcspecifics
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.Acntcspecific,
x.CoilNtcspecific,
x.IgbtSafetyParams,
x.InductionCoilHeatsinkNtcspecific
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.InductionCoilNtcspecifics);
                });
            
			
            Field<InductionCoilSripcsafetyGraphType, InductionCoilSripcsafety>("InductionCoilSripcsafetys")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilSripcsafetyGraphType>(
                        "InductionCoilConfig-InductionCoilSripcsafety-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionCoilSripcsafetys
                                .Where(x => x.InductionCoilSripcsafety != null && ids.Contains((Guid)x.InductionCoilSripcsafety))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionCoilSripcsafety!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionCoilSripcsafety);
                });
            
			
            Field<EmptyPotDetectionCoilSafetyParamGraphType, EmptyPotDetectionCoilSafetyParam>("EmptyPotDetectionCoilSafetyParams")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, EmptyPotDetectionCoilSafetyParamGraphType>(
                        "InductionCoilConfig-EmptyPotDetectionCoilSafetyParam-loader",
                        async ids => 
                        {
                            var data = await dbContext.EmptyPotDetectionCoilSafetyParams
                                .Where(x => x.EmptyPotDetectionCoilSafetyParam != null && ids.Contains((Guid)x.EmptyPotDetectionCoilSafetyParam))
                                .Select(x => new
                                {
                                    Key = (Guid)x.EmptyPotDetectionCoilSafetyParam!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.EmptyPotDetectionCoilSafetyParam);
                });
            
			
            Field<InductionCoilPowerTableConfigurationGraphType, InductionCoilPowerTableConfiguration>("InductionCoilPowerTableConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilPowerTableConfigurationGraphType>(
                        "InductionCoilConfig-InductionCoilPowerTableConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionCoilPowerTableConfigurations
                                .Where(x => x.InductionCoilPowerTableConfiguration != null && ids.Contains((Guid)x.InductionCoilPowerTableConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionCoilPowerTableConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionCoilPowerTableConfiguration);
                });
            
			
            Field<InductionCoilSpecificGraphType, InductionCoilSpecific>("InductionCoilSpecifics")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilSpecificGraphType>(
                        "InductionCoilConfig-InductionCoilSpecific-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionCoilSpecifics
                                .Where(x => x.InductionCoilSpecific != null && ids.Contains((Guid)x.InductionCoilSpecific))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionCoilSpecific!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionCoilSpecific);
                });
            
			
            Field<InductionInverterSpecificDatumGraphType, InductionInverterSpecificDatum>("InductionInverterSpecificDatums")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionInverterSpecificDatumGraphType>(
                        "InductionCoilConfig-InductionInverterSpecificDatum-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionInverterSpecificDatums
                                .Where(x => x.InductionInverterSpecificDatum != null && ids.Contains((Guid)x.InductionInverterSpecificDatum))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionInverterSpecificDatum!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionInverterSpecificDatum);
                });
            
			
            Field<InductionIpcdetailGraphType, InductionIpcdetail>("InductionIpcdetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionIpcdetailGraphType>>(
                        "InductionCoilConfig-InductionIpcdetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionIpcdetailsInductionCoilConfig
                                .Where(x => x.InductionIpcid != null && ids.Contains((Guid)x.InductionIpcid))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionIpcid!,
                                    Value = x.InductionIpc,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InductionIpcdetails);
                });
            
        }
    }
}
            