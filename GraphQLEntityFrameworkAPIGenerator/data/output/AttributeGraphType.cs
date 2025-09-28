
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
                            "{ Name = EntityName "Attribute"
  CorrespondingTable =
   Regular
     { Name = TableName "Attribute"
       Properties =
        [PrimaryKey { Type = Int
                      Name = "AttributeId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "AttributeName"
                                                        IsNullable = true };
         ForeignKey { Type = Byte
                      Name = "AttributeTypeId"
                      IsNullable = false };
         Primitive { Type = Int
                     Name = "AttributeValueMin"
                     IsNullable = true }; Primitive { Type = Int
                                                      Name = "AttributeValueMax"
                                                      IsNullable = true };
         Primitive { Type = Float
                     Name = "AttributeValueResolution"
                     IsNullable = true }; Primitive { Type = Float
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
  Fields =
   [{ Name = "AttributeId"
      Type = Id Int
      IsNullable = false }; { Name = "AttributeName"
                              Type = Primitive String
                              IsNullable = true }; { Name = "AttributeValueMin"
                                                     Type = Primitive Int
                                                     IsNullable = true };
    { Name = "AttributeValueMax"
      Type = Primitive Int
      IsNullable = true }; { Name = "AttributeValueResolution"
                             Type = Primitive Float
                             IsNullable = true }; { Name = "AttributeDefault"
                                                    Type = Primitive Float
                                                    IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "AttributeType"
        TargetTable =
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
        Destination = EntityName "AttributeType"
        IsNullable = false
        KeyType = Byte };
    ManyToMany
      { Name = RelationName "AttributeValueEnumeration"
        TargetTable =
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
        Destination = EntityName "AttributeValueEnumeration"
        KeyType = Int }] }-AttributeType-loader",
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
                            "{ Name = EntityName "Attribute"
  CorrespondingTable =
   Regular
     { Name = TableName "Attribute"
       Properties =
        [PrimaryKey { Type = Int
                      Name = "AttributeId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "AttributeName"
                                                        IsNullable = true };
         ForeignKey { Type = Byte
                      Name = "AttributeTypeId"
                      IsNullable = false };
         Primitive { Type = Int
                     Name = "AttributeValueMin"
                     IsNullable = true }; Primitive { Type = Int
                                                      Name = "AttributeValueMax"
                                                      IsNullable = true };
         Primitive { Type = Float
                     Name = "AttributeValueResolution"
                     IsNullable = true }; Primitive { Type = Float
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
  Fields =
   [{ Name = "AttributeId"
      Type = Id Int
      IsNullable = false }; { Name = "AttributeName"
                              Type = Primitive String
                              IsNullable = true }; { Name = "AttributeValueMin"
                                                     Type = Primitive Int
                                                     IsNullable = true };
    { Name = "AttributeValueMax"
      Type = Primitive Int
      IsNullable = true }; { Name = "AttributeValueResolution"
                             Type = Primitive Float
                             IsNullable = true }; { Name = "AttributeDefault"
                                                    Type = Primitive Float
                                                    IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "AttributeType"
        TargetTable =
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
        Destination = EntityName "AttributeType"
        IsNullable = false
        KeyType = Byte };
    ManyToMany
      { Name = RelationName "AttributeValueEnumeration"
        TargetTable =
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
        Destination = EntityName "AttributeValueEnumeration"
        KeyType = Int }] }-AttributeValueEnumeration-loader",
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
            