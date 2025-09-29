
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
    public partial class BoardGraphType : ObjectGraphType<Board>
    {
        public BoardGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.BoardId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Code, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NodeAddress, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StartPosition, type: typeof(LongGraphType), nullable: False);
			Field(t => t.Size, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ReadableFlash, type: typeof(ByteGraphType), nullable: False);
            
            Field<AcuexpansionBoardConfigurationGraphType, AcuexpansionBoardConfiguration>("AcuexpansionBoardConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, AcuexpansionBoardConfigurationGraphType>(
                        "Board-AcuexpansionBoardConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.AcuexpansionBoardConfigurations
                                .Where(x => x.AcuexpansionBoardConfiguration != null && ids.Contains((Guid)x.AcuexpansionBoardConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.AcuexpansionBoardConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.AcuexpansionBoardConfiguration);
                });
            
			
            Field<AcuexpansionBoardConfigurationGraphType, AcuexpansionBoardConfiguration>("AcuexpansionBoardConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<AcuexpansionBoardConfigurationGraphType>>(
                        "Board-AcuexpansionBoardConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.AcuexpansionBoardConfigurationsBoard
                                .Where(x => x.AcuexpansionBoardConfigId != null && ids.Contains((Guid)x.AcuexpansionBoardConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.AcuexpansionBoardConfigId!,
                                    Value = x.AcuexpansionBoardConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.AcuexpansionBoardConfigurations);
                });
            
			
            Field<CrossLoadConfigurationGraphType, CrossLoadConfiguration>("CrossLoadConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CrossLoadConfigurationGraphType>(
                        "Board-CrossLoadConfiguration-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CrossLoadConfiguration);
                });
            
			
            Field<DefaultPinConfigurationGraphType, DefaultPinConfiguration>("DefaultPinConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DefaultPinConfigurationGraphType>(
                        "Board-DefaultPinConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.DefaultPinConfigurations
                                .Where(x => x.DefaultPinConfiguration != null && ids.Contains((Guid)x.DefaultPinConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.DefaultPinConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.DefaultPinConfiguration);
                });
            
			
            Field<GenericInputConfigurationGraphType, GenericInputConfiguration>("GenericInputConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, GenericInputConfigurationGraphType>(
                        "Board-GenericInputConfiguration-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.GenericInputConfiguration);
                });
            
			
            Field<LoadConfigurationGraphType, LoadConfiguration>("LoadConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, LoadConfigurationGraphType>(
                        "Board-LoadConfiguration-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.LoadConfiguration);
                });
            
			
            Field<LowLevelInputConfigurationGraphType, LowLevelInputConfiguration>("LowLevelInputConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, LowLevelInputConfigurationGraphType>(
                        "Board-LowLevelInputConfiguration-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.LowLevelInputConfiguration);
                });
            
			
            Field<ProjectGraphType, Project>("Projects")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ProjectGraphType>>(
                        "Board-Project-loader",
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
            
			
            Field<TableTargetGraphType, TableTarget>("TableTargets")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                        "Board-TableTarget-loader",
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
            