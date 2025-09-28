
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
                            "{ Name = EntityName "Input"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "InputId"
      Type = Id Byte
      IsNullable = false }; { Name = "InputDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "IsSafetyRelevant"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "GenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "InputId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypePos"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ParametersId"
                          IsNullable = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Input"
                                                     Name = "Input"
                                                     IsNullable = false
                                                     IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InputType"
        TargetTable =
         { Name = TableName "InputType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             Primitive { Type = String
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
        Destination = EntityName "InputType"
        IsNullable = false
        KeyType = Byte };
    ManyToMany
      { Name = RelationName "InputGroup"
        TargetTable =
         { Name = TableName "InputGroup"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputGroupId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "InputGroupDesc"
                         IsNullable = false };
             Navigation { Type = TableName "Input"
                          Name = "Inputs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InputGroup"
        KeyType = Byte }] }-GenericInputDetail-loader",
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
                            "{ Name = EntityName "Input"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "InputId"
      Type = Id Byte
      IsNullable = false }; { Name = "InputDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "IsSafetyRelevant"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "GenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "InputId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypePos"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ParametersId"
                          IsNullable = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Input"
                                                     Name = "Input"
                                                     IsNullable = false
                                                     IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InputType"
        TargetTable =
         { Name = TableName "InputType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             Primitive { Type = String
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
        Destination = EntityName "InputType"
        IsNullable = false
        KeyType = Byte };
    ManyToMany
      { Name = RelationName "InputGroup"
        TargetTable =
         { Name = TableName "InputGroup"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputGroupId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "InputGroupDesc"
                         IsNullable = false };
             Navigation { Type = TableName "Input"
                          Name = "Inputs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InputGroup"
        KeyType = Byte }] }-InputType-loader",
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
                            "{ Name = EntityName "Input"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "InputId"
      Type = Id Byte
      IsNullable = false }; { Name = "InputDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "IsSafetyRelevant"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "GenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "InputId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypePos"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ParametersId"
                          IsNullable = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Input"
                                                     Name = "Input"
                                                     IsNullable = false
                                                     IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InputType"
        TargetTable =
         { Name = TableName "InputType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             Primitive { Type = String
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
        Destination = EntityName "InputType"
        IsNullable = false
        KeyType = Byte };
    ManyToMany
      { Name = RelationName "InputGroup"
        TargetTable =
         { Name = TableName "InputGroup"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputGroupId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "InputGroupDesc"
                         IsNullable = false };
             Navigation { Type = TableName "Input"
                          Name = "Inputs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InputGroup"
        KeyType = Byte }] }-InputGroup-loader",
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
            