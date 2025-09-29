
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
    public partial class ProjectGraphType : ObjectGraphType<Project>
    {
        public ProjectGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProjectId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.IndustrialCode, type: typeof(StringGraphType), nullable: False);
			Field(t => t.ModelName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Comment, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ProjectCode, type: typeof(StringGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.GeneratorVersion, type: typeof(StringGraphType), nullable: True);
			Field(t => t.SoftwareCodeNumber, type: typeof(StringGraphType), nullable: True);
			Field(t => t.SoftwarePartNumber, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ChangeActivityNumber, type: typeof(StringGraphType), nullable: True);
			Field(t => t.WindchillDescriptionObjectVersion, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.WindchillStatusId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AttributeTable, type: typeof(StringGraphType), nullable: True);
            
            Field<BoardGraphType, Board>("Boards")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, BoardGraphType>(
                        "Project-Board-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Board);
                });
            
			
            Field<CompiledResourceMetaDatumGraphType, CompiledResourceMetaDatum>("CompiledResourceMetaDatums")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CompiledResourceMetaDatumGraphType>>(
                        "Project-CompiledResourceMetaDatum-loader",
                        async ids => 
                        {
                            var data = await dbContext.CompiledResourceMetaDatums
                                .Where(x => x.CompiledResourceMetaDatum != null && ids.Contains((Guid)x.CompiledResourceMetaDatum))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CompiledResourceMetaDatum!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.CompiledResourceMetaDatums);
                });
            
			
            Field<DisplayGraphType, Display>("Displays")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DisplayGraphType>(
                        "Project-Display-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Display);
                });
            
			
            Field<MachineConfigurationGraphType, MachineConfiguration>("MachineConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MachineConfigurationGraphType>(
                        "Project-MachineConfiguration-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.MachineConfiguration);
                });
            
			
            Field<ProductTypeGraphType, ProductType>("ProductTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ProductTypeGraphType>(
                        "Project-ProductType-loader",
                        async ids => 
                        {
                            var data = await dbContext.ProductTypes
                                .Where(x => x.ProductType != null && ids.Contains((byte)x.ProductType))
                                .Select(x => new
                                {
                                    Key = (byte)x.ProductType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.ProductType);
                });
            
			
            Field<SelectorConfigurationGraphType, SelectorConfiguration>("SelectorConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SelectorConfigurationGraphType>(
                        "Project-SelectorConfiguration-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.SelectorConfiguration);
                });
            
			
            Field<SettingFileExtensionGraphType, SettingFileExtension>("SettingFileExtensions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SettingFileExtensionGraphType>(
                        "Project-SettingFileExtension-loader",
                        async ids => 
                        {
                            var data = await dbContext.SettingFileExtensions
                                .Where(x => x.SettingFileExtension != null && ids.Contains((Guid)x.SettingFileExtension))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SettingFileExtension!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.SettingFileExtension);
                });
            
			
            Field<TableTargetGraphType, TableTarget>("TableTargets")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                        "Project-TableTarget-loader",
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
            
        }
    }
}
            