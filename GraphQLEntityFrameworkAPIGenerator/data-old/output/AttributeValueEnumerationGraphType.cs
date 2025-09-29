
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
                            "{ Name = EntityName "AttributeValueEnumeration"
  CorrespondingTable =
   Regular
     { Name = TableName "AttributeValueEnumeration"
       Properties =
        [PrimaryKey { Type = Int
                      Name = "AttributeValueEnumerationId"
                      IsNullable = false };
         Primitive { Type = String
                     Name = "AttributeValueEnumeration1"
                     IsNullable = true };
         Navigation { Type = TableName "Attribute"
                      Name = "Attributes"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "AttributeValueEnumerationId"
              Type = Id Int
              IsNullable = false }; { Name = "AttributeValueEnumeration1"
                                      Type = Primitive String
                                      IsNullable = true }]
  Relations =
   [ManyToMany
      { Name = RelationName "Attribute"
        TargetTable =
         { Name = TableName "Attribute"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "AttributeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "AttributeName"
                         IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "AttributeTypeId"
                          IsNullable = false };
             Primitive { Type = Int
                         Name = "AttributeValueMin"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "AttributeValueMax"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "AttributeValueResolution"
                         IsNullable = true };
             Primitive { Type = Float
                         Name = "AttributeDefault"
                         IsNullable = false };
             Navigation { Type = TableName "AttributeType"
                          Name = "AttributeType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "AttributeValueEnumeration"
                          Name = "AttributeValueEnumerations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Attribute"
        KeyType = Int }] }-Attribute-loader",
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
            