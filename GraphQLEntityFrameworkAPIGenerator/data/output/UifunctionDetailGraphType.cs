
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
    public partial class UifunctionDetailGraphType : ObjectGraphType<UifunctionDetail>
    {
        public UifunctionDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UifunctionDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.FunctionId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TargetId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ToMainBoard, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.FunctionFlags, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RegulationFlags, type: typeof(IdGraphType), nullable: False);
			Field(t => t.SlaveInputTypeId, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.SlaveInputTypePosition, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.IgnoreVisualRegulationTable, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.FactoryRestoreIndex, type: typeof(ByteGraphType), nullable: False);
            
            Field<TableTargetGraphType, TableTarget>("TableTargets")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                        "UifunctionDetail-TableTarget-loader",
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
            
			
            Field<FunctionLabelGraphType, FunctionLabel>("FunctionLabels")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<FunctionLabelGraphType>>(
                        "UifunctionDetail-FunctionLabel-loader",
                        async ids => 
                        {
                            var data = await dbContext.UifunctionConfigurationsUifunctionDetail
                                .Where(x => x.FunctionLabel != null && ids.Contains((byte)x.FunctionLabel))
                                .Select(x => new
                                {
                                    Key = (byte)x.FunctionLabel!,
                                    Value = x.FunctionLabelNavigation,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.FunctionLabels);
                });
            
			
            Field<UifunctionConfigurationGraphType, UifunctionConfiguration>("UifunctionConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UifunctionConfigurationGraphType>>(
                        "UifunctionDetail-UifunctionConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UifunctionConfigurationsUifunctionDetail
                                .Where(x => x.UifunctionConfigurationId != null && ids.Contains((Guid)x.UifunctionConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UifunctionConfigurationId!,
                                    Value = x.UifunctionConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UifunctionConfigurations);
                });
            
			
            Field<UiregulationTableGraphType, UiregulationTable>("UiregulationTables")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiregulationTableGraphType>>(
                        "UifunctionDetail-UiregulationTable-loader",
                        async ids => 
                        {
                            var data = await dbContext.UifunctionConfigurationsUifunctionDetail
                                .Where(x => x.UifunctionConfigurationId != null && ids.Contains((Guid)x.UifunctionConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UifunctionConfigurationId!,
                                    Value = x.UiregulationTable,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiregulationTables);
                });
            
        }
    }
}
            