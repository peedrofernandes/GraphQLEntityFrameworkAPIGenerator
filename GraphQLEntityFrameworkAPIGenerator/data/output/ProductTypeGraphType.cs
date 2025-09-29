
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
    public partial class ProductTypeGraphType : ObjectGraphType<ProductType>
    {
        public ProductTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProductTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ProductTypeDsc, type: typeof(StringGraphType), nullable: False);
            
            Field<HighStatementGraphType, HighStatement>("HighStatements")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, IEnumerable<HighStatementGraphType>>(
                        "ProductType-HighStatement-loader",
                        async ids => 
                        {
                            var data = await dbContext.ProductTypesHighStatement
                                .Where(x => x.HighStatementId != null && ids.Contains((int)x.HighStatementId))
                                .Select(x => new
                                {
                                    Key = (int)x.HighStatementId!,
                                    Value = x.HighStatement,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.HighStatements);
                });
            
			
            Field<OpCodeGraphType, OpCode>("OpCodes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<OpCodeGraphType>>(
                        "ProductType-OpCode-loader",
                        async ids => 
                        {
                            var data = await dbContext.ProductTypesHighStatement
                                .Where(x => x.ProductTypeId != null && ids.Contains((byte)x.ProductTypeId))
                                .Select(x => new
                                {
                                    Key = (byte)x.ProductTypeId!,
                                    Value = x.OpCodeNavigation,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.OpCodes);
                });
            
			
            Field<TaskGraphType, Task>("Tasks")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, IEnumerable<TaskGraphType>>(
                        "ProductType-Task-loader",
                        async ids => 
                        {
                            var data = await dbContext.ProductTypesTask
                                .Where(x => x.TaskId != null && ids.Contains((int)x.TaskId))
                                .Select(x => new
                                {
                                    Key = (int)x.TaskId!,
                                    Value = x.Task,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Tasks);
                });
            
			
            Field<VariableGraphType, Variable>("Variables")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, IEnumerable<VariableGraphType>>(
                        "ProductType-Variable-loader",
                        async ids => 
                        {
                            var data = await dbContext.ProductTypesVariable
                                .Where(x => x.VariableId != null && ids.Contains((int)x.VariableId))
                                .Select(x => new
                                {
                                    Key = (int)x.VariableId!,
                                    Value = x.Variable,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Variables);
                });
            
			
            Field<ProjectGraphType, Project>("Projects")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ProjectGraphType>>(
                        "ProductType-Project-loader",
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
            
			
            Field<StatusVariableGraphType, StatusVariable>("StatusVariables")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StatusVariableGraphType>>(
                        "ProductType-StatusVariable-loader",
                        async ids => 
                        {
                            var data = await dbContext.StatusVariables
                                .Where(x => x.StatusVariable != null && ids.Contains((Guid)x.StatusVariable))
                                .Select(x => new
                                {
                                    Key = (Guid)x.StatusVariable!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.StatusVariables);
                });
            
			
            Field<StmSetVariableGraphType, StmSetVariable>("StmSetVariables")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<StmSetVariableGraphType>>(
                        "ProductType-StmSetVariable-loader",
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
            
			
            Field<VisualBoardTypeGraphType, VisualBoardType>("VisualBoardTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, VisualBoardTypeGraphType>(
                        "ProductType-VisualBoardType-loader",
                        async ids => 
                        {
                            var data = await dbContext.VisualBoardTypes
                                .Where(x => x.VisualBoardType.Any(c => ids.Contains(c.VisualBoardTypeId)))
                                .Select(x => new
                                {
                                    Key = x,
                                    Values = x.VisualBoardType,
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.Values.Select(v => new { Key = v.VisualBoardTypeId, Value = x.Key }))
                                .ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.VisualBoardTypes);
                });
            
        }
    }
}
            