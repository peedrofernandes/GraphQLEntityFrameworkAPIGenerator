
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
                            "{ Name = EntityName "AttributeType"
  CorrespondingTable =
   Regular
     { Name = TableName "AttributeType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "AttributeTypeId"
                      IsNullable = false };
         Primitive { Type = String
                     Name = "AttributeTypeName"
                     IsNullable = false };
         Navigation { Type = TableName "Attribute"
                      Name = "Attributes"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "AttributeTypeId"
              Type = Id Byte
              IsNullable = false }; { Name = "AttributeTypeName"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
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
            