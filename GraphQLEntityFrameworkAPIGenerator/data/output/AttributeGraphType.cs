
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
    public partial class AttributeGraphType : ObjectGraphType<Attribute>
    {
        public AttributeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.AttributeId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.AttributeName, type: typeof(StringGraphType), nullable: True);
			Field(t => t.AttributeValueMin, type: typeof(IdGraphType), nullable: True);
			Field(t => t.AttributeValueMax, type: typeof(IdGraphType), nullable: True);
			Field(t => t.AttributeValueResolution, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.AttributeDefault, type: typeof(FloatGraphType), nullable: False);
            
            Field<AttributeTypeGraphType, AttributeType>("AttributeTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, AttributeTypeGraphType>(
                        "Attribute-AttributeType-loader",
                        async ids => 
                        {
                            var data = await dbContext.AttributeTypes
                                .Where(x => x.AttributeType != null && ids.Contains((byte)x.AttributeType))
                                .Select(x => new
                                {
                                    Key = (byte)x.AttributeType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.AttributeType);
                });
            
			
            Field<AttributeValueEnumerationGraphType, AttributeValueEnumeration>("AttributeValueEnumerations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, AttributeValueEnumerationGraphType>(
                        "Attribute-AttributeValueEnumeration-loader",
                        async ids => 
                        {
                            var data = await dbContext.AttributeValueEnumerations
                                .Where(x => x.AttributeValueEnumeration.Any(c => ids.Contains(c.AttributeValueEnumerationId)))
                                .Select(x => new
                                {
                                    Key = x,
                                    Values = x.AttributeValueEnumeration,
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.Values.Select(v => new { Key = v.AttributeValueEnumerationId, Value = x.Key }))
                                .ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.AttributeValueEnumerations);
                });
            
        }
    }
}
            