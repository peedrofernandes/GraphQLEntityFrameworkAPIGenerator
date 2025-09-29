
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
    public partial class AttributeTypeGraphType : ObjectGraphType<AttributeType>
    {
        public AttributeTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.AttributeTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AttributeTypeName, type: typeof(StringGraphType), nullable: False);
            
            Field<AttributeGraphType, Attribute>("Attributes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, IEnumerable<AttributeGraphType>>(
                        "AttributeType-Attribute-loader",
                        async ids => 
                        {
                            var data = await dbContext.Attributes
                                .Where(x => x.Attribute != null && ids.Contains((int)x.Attribute))
                                .Select(x => new
                                {
                                    Key = (int)x.Attribute!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Attributes);
                });
            
        }
    }
}
            