
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
    public partial class UifunctionConfigurationGraphType : ObjectGraphType<UifunctionConfiguration>
    {
        public UifunctionConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UifunctionConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.Level, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<DisplayGraphType, Display>("Displays")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DisplayGraphType>>(
                        "UifunctionConfiguration-Display-loader",
                        async ids => 
                        {
                            var data = await dbContext.Displays
                                .Where(x => x.Display != null && ids.Contains((Guid)x.Display))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Display!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Displays);
                });
            
			
            Field<SelectorConfigurationGraphType, SelectorConfiguration>("SelectorConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorConfigurationGraphType>>(
                        "UifunctionConfiguration-SelectorConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.SelectorConfigurations
                                .Where(x => x.SelectorConfiguration != null && ids.Contains((Guid)x.SelectorConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SelectorConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.SelectorConfigurations);
                });
            
			
            Field<SelectorGraphType, Selector>("Selectors")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorGraphType>>(
                        "UifunctionConfiguration-Selector-loader",
                        async ids => 
                        {
                            var data = await dbContext.Selectors
                                .Where(x => x.Selector != null && ids.Contains((Guid)x.Selector))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Selector!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Selectors);
                });
            
			
            Field<TableTargetGraphType, TableTarget>("TableTargets")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                        "UifunctionConfiguration-TableTarget-loader",
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
                        "UifunctionConfiguration-FunctionLabel-loader",
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
            
			
            Field<UifunctionDetailGraphType, UifunctionDetail>("UifunctionDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UifunctionDetailGraphType>>(
                        "UifunctionConfiguration-UifunctionDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UifunctionConfigurationsUifunctionDetail
                                .Where(x => x.UifunctionConfigurationId != null && ids.Contains((Guid)x.UifunctionConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UifunctionConfigurationId!,
                                    Value = x.UifunctionDetail,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UifunctionDetails);
                });
            
			
            Field<UiregulationTableGraphType, UiregulationTable>("UiregulationTables")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiregulationTableGraphType>>(
                        "UifunctionConfiguration-UiregulationTable-loader",
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
            