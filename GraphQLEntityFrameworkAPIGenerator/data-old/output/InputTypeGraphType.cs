
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
    public partial class InputTypeGraphType : ObjectGraphType<InputType>
    {
        public InputTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InputTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputTypeDsc, type: typeof(StringGraphType), nullable: False);
            
                Field<InputTypesReadTypeGraphType, InputTypesReadType>("InputTypesReadTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<InputTypesReadTypeGraphType>>(
                            "{ Name = EntityName "InputType"
  CorrespondingTable =
   Regular
     { Name = TableName "InputType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "InputTypeId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "InputTypeDsc"
                                                        IsNullable = false };
         Navigation { Type = TableName "InputTypesReadType"
                      Name = "InputTypesReadTypes"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Input"
                      Name = "Inputs"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "InputTypeId"
              Type = Id Byte
              IsNullable = false }; { Name = "InputTypeDsc"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "InputTypesReadType"
        TargetTable =
         { Name = TableName "InputTypesReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Navigation { Type = TableName "InputType"
                          Name = "InputType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "InputTypesReadType"
        KeyType = Byte };
    OneToMany
      { Name = RelationName "Input"
        TargetTable =
         { Name = TableName "Input"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "InputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "GenericInputDetail"
                          Name = "GenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InputType"
                          Name = "InputType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InputGroup"
                          Name = "InputGroups"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Input"
        KeyType = Byte }] }-InputTypesReadType-loader",
                            async ids => 
                            {
                                var data = await dbContext.InputTypesReadTypes
                                    .Where(x => x.InputTypesReadType != null && ids.Contains((byte)x.InputTypesReadType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.InputTypesReadType!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.InputTypesReadTypes);
                    });
            
			
                Field<InputGraphType, Input>("Inputs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<InputGraphType>>(
                            "{ Name = EntityName "InputType"
  CorrespondingTable =
   Regular
     { Name = TableName "InputType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "InputTypeId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "InputTypeDsc"
                                                        IsNullable = false };
         Navigation { Type = TableName "InputTypesReadType"
                      Name = "InputTypesReadTypes"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Input"
                      Name = "Inputs"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "InputTypeId"
              Type = Id Byte
              IsNullable = false }; { Name = "InputTypeDsc"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "InputTypesReadType"
        TargetTable =
         { Name = TableName "InputTypesReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Navigation { Type = TableName "InputType"
                          Name = "InputType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "InputTypesReadType"
        KeyType = Byte };
    OneToMany
      { Name = RelationName "Input"
        TargetTable =
         { Name = TableName "Input"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "InputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "GenericInputDetail"
                          Name = "GenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InputType"
                          Name = "InputType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InputGroup"
                          Name = "InputGroups"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Input"
        KeyType = Byte }] }-Input-loader",
                            async ids => 
                            {
                                var data = await dbContext.Inputs
                                    .Where(x => x.Input != null && ids.Contains((byte)x.Input))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.Input!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.Inputs);
                    });
            
        }
    }
}
            