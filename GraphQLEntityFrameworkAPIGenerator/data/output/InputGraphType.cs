
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
    public partial class InputGraphType : ObjectGraphType<Input>
    {
        public InputGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InputId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.IsSafetyRelevant, type: typeof(BoolGraphType), nullable: False);
            
            Field<GenericInputDetailGraphType, GenericInputDetail>("GenericInputDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<GenericInputDetailGraphType>>(
                        "Input-GenericInputDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.GenericInputDetails
                                .Where(x => x.GenericInputDetail != null && ids.Contains((Guid)x.GenericInputDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.GenericInputDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.GenericInputDetails);
                });
            
			
            Field<InputTypeGraphType, InputType>("InputTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, InputTypeGraphType>(
                        "Input-InputType-loader",
                        async ids => 
                        {
                            var data = await dbContext.InputTypes
                                .Where(x => x.InputType != null && ids.Contains((byte)x.InputType))
                                .Select(x => new
                                {
                                    Key = (byte)x.InputType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InputType);
                });
            
			
            Field<InputGroupGraphType, InputGroup>("InputGroups")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, InputGroupGraphType>(
                        "Input-InputGroup-loader",
                        async ids => 
                        {
                            var data = await dbContext.InputGroups
                                .Where(x => x.InputGroup.Any(c => ids.Contains(c.InputGroupId)))
                                .Select(x => new
                                {
                                    Key = x,
                                    Values = x.InputGroup,
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.Values.Select(v => new { Key = v.InputGroupId, Value = x.Key }))
                                .ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.InputGroups);
                });
            
        }
    }
}
            