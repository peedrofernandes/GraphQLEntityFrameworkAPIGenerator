
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
    public partial class InputGroupGraphType : ObjectGraphType<InputGroup>
    {
        public InputGroupGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InputGroupId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputGroupDesc, type: typeof(StringGraphType), nullable: False);
            
                Field<InputGraphType, Input>("Inputs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, InputGraphType>(
                            "{ Name = EntityName "InputGroup"
  CorrespondingTable =
   Regular
     { Name = TableName "InputGroup"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "InputGroupId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "InputGroupDesc"
                                                        IsNullable = false };
         Navigation { Type = TableName "Input"
                      Name = "Inputs"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "InputGroupId"
              Type = Id Byte
              IsNullable = false }; { Name = "InputGroupDesc"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [ManyToMany
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
                                    .Where(x => x.Input.Any(c => ids.Contains(c.InputId)))
                                    .Select(x => new
                                    {
                                        Key = x,
                                        Values = x.Input,
                                    })
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => x.Values.Select(v => new { Key = v.InputId, Value = x.Key }))
                                    .ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Inputs);
                    });
            
        }
    }
}
            