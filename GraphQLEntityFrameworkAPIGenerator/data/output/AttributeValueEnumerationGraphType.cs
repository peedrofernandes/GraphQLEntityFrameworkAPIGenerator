
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
    public partial class AttributeValueEnumerationGraphType : ObjectGraphType<AttributeValueEnumeration>
    {
        public AttributeValueEnumerationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.AttributeValueEnumerationId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.AttributeValueEnumeration1, type: typeof(StringGraphType), nullable: True);
            
            Field<AttributeGraphType, Attribute>("Attributes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, AttributeGraphType>(
                        "AttributeValueEnumeration-Attribute-loader",
                        async ids => 
                        {
                            var data = await dbContext.Attributes
                                .Where(x => x.Attribute.Any(c => ids.Contains(c.AttributeId)))
                                .Select(x => new
                                {
                                    Key = x,
                                    Values = x.Attribute,
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.Values.Select(v => new { Key = v.AttributeId, Value = x.Key }))
                                .ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Attributes);
                });
            
        }
    }
}
            