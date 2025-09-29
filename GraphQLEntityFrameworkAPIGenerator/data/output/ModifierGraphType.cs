
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
    public partial class ModifierGraphType : ObjectGraphType<Modifier>
    {
        public ModifierGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ModifiersId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumModifiers, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OverallOperationId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierOperator5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierOperator6, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<LoadsControlPilotParameterGraphType, LoadsControlPilotParameter>("LoadsControlPilotParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LoadsControlPilotParameterGraphType>>(
                        "Modifier-LoadsControlPilotParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.LoadsControlPilotParameters
                                .Where(x => x.LoadsControlPilotParameter != null && ids.Contains((Guid)x.LoadsControlPilotParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.LoadsControlPilotParameter!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.LoadsControlPilotParameters);
                });
            
			
            Field<ModifiersDetailGraphType, ModifiersDetail>("ModifiersDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ModifiersDetailGraphType>(
                        "Modifier-ModifiersDetail-loader",
                        async ids => 
                        {
                            Expression<Func<ModifiersDetail, bool>> expr = x => !ids.Any()
                                \|\| (x.ModifierDetails1Navigation != null && ids.Contains((Guid)x.ModifierDetails1Navigation))
\|\| (x.ModifierDetails2Navigation != null && ids.Contains((Guid)x.ModifierDetails2Navigation))
\|\| (x.ModifierDetails3Navigation != null && ids.Contains((Guid)x.ModifierDetails3Navigation))
\|\| (x.ModifierDetails4Navigation != null && ids.Contains((Guid)x.ModifierDetails4Navigation))
\|\| (x.ModifierDetails5Navigation != null && ids.Contains((Guid)x.ModifierDetails5Navigation))
\|\| (x.ModifierDetails6Navigation != null && ids.Contains((Guid)x.ModifierDetails6Navigation))
\|\| (x.ModifierDetails7Navigation != null && ids.Contains((Guid)x.ModifierDetails7Navigation))
\|\| (x.ModifierDetails8Navigation != null && ids.Contains((Guid)x.ModifierDetails8Navigation));

                            var data = await dbContext.ModifiersDetails
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.ModifierDetails1Navigation,
x.ModifierDetails2Navigation,
x.ModifierDetails3Navigation,
x.ModifierDetails4Navigation,
x.ModifierDetails5Navigation,
x.ModifierDetails6Navigation,
x.ModifierDetails7Navigation,
x.ModifierDetails8Navigation
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.ModifiersDetails);
                });
            
			
            Field<ModifierOperatorGraphType, ModifierOperator>("ModifierOperators")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ModifierOperatorGraphType>(
                        "Modifier-ModifierOperator-loader",
                        async ids => 
                        {
                            Expression<Func<ModifierOperator, bool>> expr = x => !ids.Any()
                                \|\| (x.ModifierOperator1Navigation != null && ids.Contains((byte)x.ModifierOperator1Navigation))
\|\| (x.ModifierOperator2Navigation != null && ids.Contains((byte)x.ModifierOperator2Navigation))
\|\| (x.ModifierOperator3Navigation != null && ids.Contains((byte)x.ModifierOperator3Navigation))
\|\| (x.ModifierOperator4Navigation != null && ids.Contains((byte)x.ModifierOperator4Navigation))
\|\| (x.ModifierOperator7Navigation != null && ids.Contains((byte)x.ModifierOperator7Navigation))
\|\| (x.ModifierOperator8Navigation != null && ids.Contains((byte)x.ModifierOperator8Navigation))
\|\| (x.ModifierType5Navigation != null && ids.Contains((byte)x.ModifierType5Navigation))
\|\| (x.ModifierType6Navigation != null && ids.Contains((byte)x.ModifierType6Navigation));

                            var data = await dbContext.ModifierOperators
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<byte?>()
                                {
                                    x.ModifierOperator1Navigation,
x.ModifierOperator2Navigation,
x.ModifierOperator3Navigation,
x.ModifierOperator4Navigation,
x.ModifierOperator7Navigation,
x.ModifierOperator8Navigation,
x.ModifierType5Navigation,
x.ModifierType6Navigation
                                }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.ModifierOperators);
                });
            
			
            Field<ModifierTypeGraphType, ModifierType>("ModifierTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ModifierTypeGraphType>(
                        "Modifier-ModifierType-loader",
                        async ids => 
                        {
                            Expression<Func<ModifierType, bool>> expr = x => !ids.Any()
                                \|\| (x.ModifierType1Navigation != null && ids.Contains((byte)x.ModifierType1Navigation))
\|\| (x.ModifierType2Navigation != null && ids.Contains((byte)x.ModifierType2Navigation))
\|\| (x.ModifierType3Navigation != null && ids.Contains((byte)x.ModifierType3Navigation))
\|\| (x.ModifierType4Navigation != null && ids.Contains((byte)x.ModifierType4Navigation))
\|\| (x.ModifierType7Navigation != null && ids.Contains((byte)x.ModifierType7Navigation))
\|\| (x.ModifierType8Navigation != null && ids.Contains((byte)x.ModifierType8Navigation));

                            var data = await dbContext.ModifierTypes
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<byte?>()
                                {
                                    x.ModifierType1Navigation,
x.ModifierType2Navigation,
x.ModifierType3Navigation,
x.ModifierType4Navigation,
x.ModifierType7Navigation,
x.ModifierType8Navigation
                                }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.ModifierTypes);
                });
            
			
            Field<StmMaintainGraphType, StmMaintain>("StmMaintains")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmMaintainGraphType>>(
                        "Modifier-StmMaintain-loader",
                        async ids => 
                        {
                            var data = await dbContext.StmMaintains
                                .Where(x => x.StmMaintain != null && ids.Contains((Guid)x.StmMaintain))
                                .Select(x => new
                                {
                                    Key = (Guid)x.StmMaintain!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.StmMaintains);
                });
            
			
            Field<StmSetVariableGraphType, StmSetVariable>("StmSetVariables")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmSetVariableGraphType>>(
                        "Modifier-StmSetVariable-loader",
                        async ids => 
                        {
                            var data = await dbContext.StmSetVariables
                                .Where(x => x.StmSetVariable != null && ids.Contains((Guid)x.StmSetVariable))
                                .Select(x => new
                                {
                                    Key = (Guid)x.StmSetVariable!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.StmSetVariables);
                });
            
			
            Field<TimeEstimationDetailGraphType, TimeEstimationDetail>("TimeEstimationDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<TimeEstimationDetailGraphType>>(
                        "Modifier-TimeEstimationDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.TimeEstimationDetails
                                .Where(x => x.TimeEstimationDetail != null && ids.Contains((Guid)x.TimeEstimationDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.TimeEstimationDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.TimeEstimationDetails);
                });
            
			
            Field<TimeEstimationGraphType, TimeEstimation>("TimeEstimations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<TimeEstimationGraphType>>(
                        "Modifier-TimeEstimation-loader",
                        async ids => 
                        {
                            var data = await dbContext.TimeEstimations
                                .Where(x => x.TimeEstimation != null && ids.Contains((Guid)x.TimeEstimation))
                                .Select(x => new
                                {
                                    Key = (Guid)x.TimeEstimation!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.TimeEstimations);
                });
            
			
            Field<UidataModelKeyMappingGraphType, UidataModelKeyMapping>("UidataModelKeyMappings")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UidataModelKeyMappingGraphType>>(
                        "Modifier-UidataModelKeyMapping-loader",
                        async ids => 
                        {
                            var data = await dbContext.UidataModelKeyMappings
                                .Where(x => x.UidataModelKeyMapping != null && ids.Contains((Guid)x.UidataModelKeyMapping))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UidataModelKeyMapping!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UidataModelKeyMappings);
                });
            
        }
    }
}
            