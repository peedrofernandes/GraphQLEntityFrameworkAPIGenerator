
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
    public partial class UisequenceGraphType : ObjectGraphType<Uisequence>
    {
        public UisequenceGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UisequenceId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.GireadTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.GireadTypePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Givalue, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UseNewBuffer, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<TableTargetGraphType, TableTarget>("TableTargets")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                        "Uisequence-TableTarget-loader",
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
            
			
            Field<UiconditionGraphType, Uicondition>("Uiconditions")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiconditionGraphType>>(
                        "Uisequence-Uicondition-loader",
                        async ids => 
                        {
                            var data = await dbContext.UisequenceConfigurationsUisequence
                                .Where(x => x.UisequenceConfigurationId != null && ids.Contains((Guid)x.UisequenceConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UisequenceConfigurationId!,
                                    Value = x.Uicondition,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Uiconditions);
                });
            
			
            Field<UisequenceConfigurationGraphType, UisequenceConfiguration>("UisequenceConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UisequenceConfigurationGraphType>>(
                        "Uisequence-UisequenceConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UisequenceConfigurationsUisequence
                                .Where(x => x.UisequenceConfigurationId != null && ids.Contains((Guid)x.UisequenceConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UisequenceConfigurationId!,
                                    Value = x.UisequenceConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UisequenceConfigurations);
                });
            
			
            Field<UistepGraphType, Uistep>("Uisteps")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UistepGraphType>>(
                        "Uisequence-Uistep-loader",
                        async ids => 
                        {
                            var data = await dbContext.UisequencesUistep
                                .Where(x => x.UisequenceId != null && ids.Contains((Guid)x.UisequenceId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UisequenceId!,
                                    Value = x.Uistep,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Uisteps);
                });
            
        }
    }
}
            