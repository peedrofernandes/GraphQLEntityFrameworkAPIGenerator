
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
    public partial class TableTargetGraphType : ObjectGraphType<TableTarget>
    {
        public TableTargetGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.IsCodeMandatory, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsTargetReleasable, type: typeof(BoolGraphType), nullable: False);
            
            Field<BoardGraphType, Board>("Boards")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<BoardGraphType>>(
                        "TableTarget-Board-loader",
                        async ids => 
                        {
                            var data = await dbContext.Boards
                                .Where(x => x.Board != null && ids.Contains((Guid)x.Board))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Board!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Boards);
                });
            
			
            Field<CrossLoadConfigurationGraphType, CrossLoadConfiguration>("CrossLoadConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CrossLoadConfigurationGraphType>>(
                        "TableTarget-CrossLoadConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.CrossLoadConfigurations
                                .Where(x => x.CrossLoadConfiguration != null && ids.Contains((Guid)x.CrossLoadConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CrossLoadConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.CrossLoadConfigurations);
                });
            
			
            Field<CycleGraphType, Cycle>("Cycles")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleGraphType>>(
                        "TableTarget-Cycle-loader",
                        async ids => 
                        {
                            var data = await dbContext.Cycles
                                .Where(x => x.Cycle != null && ids.Contains((Guid)x.Cycle))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Cycle!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Cycles);
                });
            
			
            Field<DisplayGraphType, Display>("Displays")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DisplayGraphType>>(
                        "TableTarget-Display-loader",
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
            
			
            Field<GenericInputConfigurationGraphType, GenericInputConfiguration>("GenericInputConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<GenericInputConfigurationGraphType>>(
                        "TableTarget-GenericInputConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.GenericInputConfigurations
                                .Where(x => x.GenericInputConfiguration != null && ids.Contains((Guid)x.GenericInputConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.GenericInputConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.GenericInputConfigurations);
                });
            
			
            Field<LoadConfigurationGraphType, LoadConfiguration>("LoadConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LoadConfigurationGraphType>>(
                        "TableTarget-LoadConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.LoadConfigurations
                                .Where(x => x.LoadConfiguration != null && ids.Contains((Guid)x.LoadConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.LoadConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.LoadConfigurations);
                });
            
			
            Field<LowLevelInputConfigurationGraphType, LowLevelInputConfiguration>("LowLevelInputConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LowLevelInputConfigurationGraphType>>(
                        "TableTarget-LowLevelInputConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.LowLevelInputConfigurations
                                .Where(x => x.LowLevelInputConfiguration != null && ids.Contains((Guid)x.LowLevelInputConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.LowLevelInputConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.LowLevelInputConfigurations);
                });
            
			
            Field<MacroGraphType, Macro>("Macros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MacroGraphType>>(
                        "TableTarget-Macro-loader",
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
                        });

                    return loader.LoadAsync(context.Source.Macros);
                });
            
			
            Field<PilotGeneralizedProfileGraphType, PilotGeneralizedProfile>("PilotGeneralizedProfiles")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PilotGeneralizedProfileGraphType>>(
                        "TableTarget-PilotGeneralizedProfile-loader",
                        async ids => 
                        {
                            var data = await dbContext.PilotGeneralizedProfiles
                                .Where(x => x.PilotGeneralizedProfile != null && ids.Contains((Guid)x.PilotGeneralizedProfile))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PilotGeneralizedProfile!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.PilotGeneralizedProfiles);
                });
            
			
            Field<PrmGianalogToTemperatureGraphType, PrmGianalogToTemperature>("PrmGianalogToTemperatures")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmGianalogToTemperatureGraphType>>(
                        "TableTarget-PrmGianalogToTemperature-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrmGianalogToTemperatures
                                .Where(x => x.PrmGianalogToTemperature != null && ids.Contains((Guid)x.PrmGianalogToTemperature))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrmGianalogToTemperature!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.PrmGianalogToTemperatures);
                });
            
			
            Field<ProjectGraphType, Project>("Projects")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ProjectGraphType>>(
                        "TableTarget-Project-loader",
                        async ids => 
                        {
                            var data = await dbContext.Projects
                                .Where(x => x.Project != null && ids.Contains((Guid)x.Project))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Project!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Projects);
                });
            
			
            Field<SelectorGraphType, Selector>("Selectors")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SelectorGraphType>>(
                        "TableTarget-Selector-loader",
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
            
			
            Field<UiclassBeventConfigurationGraphType, UiclassBeventConfiguration>("UiclassBeventConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiclassBeventConfigurationGraphType>>(
                        "TableTarget-UiclassBeventConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiclassBeventConfigurations
                                .Where(x => x.UiclassBeventConfiguration != null && ids.Contains((Guid)x.UiclassBeventConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiclassBeventConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UiclassBeventConfigurations);
                });
            
			
            Field<UifunctionConfigurationGraphType, UifunctionConfiguration>("UifunctionConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UifunctionConfigurationGraphType>>(
                        "TableTarget-UifunctionConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UifunctionConfigurations
                                .Where(x => x.UifunctionConfiguration != null && ids.Contains((Guid)x.UifunctionConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UifunctionConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UifunctionConfigurations);
                });
            
			
            Field<UifunctionDetailGraphType, UifunctionDetail>("UifunctionDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UifunctionDetailGraphType>>(
                        "TableTarget-UifunctionDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UifunctionDetails
                                .Where(x => x.UifunctionDetail != null && ids.Contains((Guid)x.UifunctionDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UifunctionDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UifunctionDetails);
                });
            
			
            Field<UigenericInputConfigurationGraphType, UigenericInputConfiguration>("UigenericInputConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UigenericInputConfigurationGraphType>>(
                        "TableTarget-UigenericInputConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UigenericInputConfigurations
                                .Where(x => x.UigenericInputConfiguration != null && ids.Contains((Guid)x.UigenericInputConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UigenericInputConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UigenericInputConfigurations);
                });
            
			
            Field<UimacroGraphType, Uimacro>("Uimacros")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UimacroGraphType>>(
                        "TableTarget-Uimacro-loader",
                        async ids => 
                        {
                            var data = await dbContext.Uimacros
                                .Where(x => x.Uimacro != null && ids.Contains((Guid)x.Uimacro))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Uimacro!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Uimacros);
                });
            
			
            Field<UiprmGianalogEncoderGraphType, UiprmGianalogEncoder>("UiprmGianalogEncoders")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiprmGianalogEncoderGraphType>>(
                        "TableTarget-UiprmGianalogEncoder-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiprmGianalogEncoders
                                .Where(x => x.UiprmGianalogEncoder != null && ids.Contains((Guid)x.UiprmGianalogEncoder))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiprmGianalogEncoder!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UiprmGianalogEncoders);
                });
            
			
            Field<UiprmGianalogPotentiometerGraphType, UiprmGianalogPotentiometer>("UiprmGianalogPotentiometers")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiprmGianalogPotentiometerGraphType>>(
                        "TableTarget-UiprmGianalogPotentiometer-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiprmGianalogPotentiometers
                                .Where(x => x.UiprmGianalogPotentiometer != null && ids.Contains((Guid)x.UiprmGianalogPotentiometer))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiprmGianalogPotentiometer!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UiprmGianalogPotentiometers);
                });
            
			
            Field<UiprmGidiscretePotentiometerGraphType, UiprmGidiscretePotentiometer>("UiprmGidiscretePotentiometers")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiprmGidiscretePotentiometerGraphType>>(
                        "TableTarget-UiprmGidiscretePotentiometer-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiprmGidiscretePotentiometers
                                .Where(x => x.UiprmGidiscretePotentiometer != null && ids.Contains((Guid)x.UiprmGidiscretePotentiometer))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiprmGidiscretePotentiometer!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UiprmGidiscretePotentiometers);
                });
            
			
            Field<UiprmGiincrementalEncoderGraphType, UiprmGiincrementalEncoder>("UiprmGiincrementalEncoders")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiprmGiincrementalEncoderGraphType>>(
                        "TableTarget-UiprmGiincrementalEncoder-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiprmGiincrementalEncoders
                                .Where(x => x.UiprmGiincrementalEncoder != null && ids.Contains((Guid)x.UiprmGiincrementalEncoder))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiprmGiincrementalEncoder!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UiprmGiincrementalEncoders);
                });
            
			
            Field<UiprmGitouchSliderGraphType, UiprmGitouchSlider>("UiprmGitouchSliders")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiprmGitouchSliderGraphType>>(
                        "TableTarget-UiprmGitouchSlider-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiprmGitouchSliders
                                .Where(x => x.UiprmGitouchSlider != null && ids.Contains((Guid)x.UiprmGitouchSlider))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiprmGitouchSlider!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UiprmGitouchSliders);
                });
            
			
            Field<UiregulationTableGraphType, UiregulationTable>("UiregulationTables")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiregulationTableGraphType>>(
                        "TableTarget-UiregulationTable-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiregulationTables
                                .Where(x => x.UiregulationTable != null && ids.Contains((Guid)x.UiregulationTable))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiregulationTable!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UiregulationTables);
                });
            
			
            Field<UisequenceConfigurationGraphType, UisequenceConfiguration>("UisequenceConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UisequenceConfigurationGraphType>>(
                        "TableTarget-UisequenceConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UisequenceConfigurations
                                .Where(x => x.UisequenceConfiguration != null && ids.Contains((Guid)x.UisequenceConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UisequenceConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UisequenceConfigurations);
                });
            
			
            Field<UisequenceGraphType, Uisequence>("Uisequences")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UisequenceGraphType>>(
                        "TableTarget-Uisequence-loader",
                        async ids => 
                        {
                            var data = await dbContext.Uisequences
                                .Where(x => x.Uisequence != null && ids.Contains((Guid)x.Uisequence))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Uisequence!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Uisequences);
                });
            
			
            Field<UisreventConfigurationGraphType, UisreventConfiguration>("UisreventConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UisreventConfigurationGraphType>>(
                        "TableTarget-UisreventConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UisreventConfigurations
                                .Where(x => x.UisreventConfiguration != null && ids.Contains((Guid)x.UisreventConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UisreventConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UisreventConfigurations);
                });
            
			
            Field<UistepGraphType, Uistep>("Uisteps")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UistepGraphType>>(
                        "TableTarget-Uistep-loader",
                        async ids => 
                        {
                            var data = await dbContext.Uisteps
                                .Where(x => x.Uistep != null && ids.Contains((Guid)x.Uistep))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Uistep!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Uisteps);
                });
            
        }
    }
}
            