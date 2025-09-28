
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
    public partial class VariableGroupGraphType : ObjectGraphType<VariableGroup>
    {
        public VariableGroupGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.VariableGroupId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VariableGroupDescription, type: typeof(StringGraphType), nullable: False);
            
                Field<VariableGraphType, Variable>("Variables")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, VariableGraphType>(
                            "{ Name = EntityName "VariableGroup"
  CorrespondingTable =
   Regular
     { Name = TableName "VariableGroup"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "VariableGroupId"
                      IsNullable = false };
         Primitive { Type = String
                     Name = "VariableGroupDescription"
                     IsNullable = false };
         Navigation { Type = TableName "Variable"
                      Name = "Variables"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "VariableGroupId"
              Type = Id Byte
              IsNullable = false }; { Name = "VariableGroupDescription"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [ManyToMany
      { Name = RelationName "Variable"
        TargetTable =
         { Name = TableName "Variable"
           Properties =
            [PrimaryKey { Type = Int
                          Name = "VariableId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Variable1"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "DataType"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsBitmap"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsWritable"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Offset"
                                                           IsNullable = true };
             Navigation { Type = TableName "Flag"
                          Name = "Flags"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesVariable"
                          Name = "ProductTypesVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "VariableGroup"
                          Name = "VariableGroups"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Variable"
        KeyType = Int }] }-Variable-loader",
                            async ids => 
                            {
                                var data = await dbContext.Variables
                                    .Where(x => x.Variable.Any(c => ids.Contains(c.VariableId)))
                                    .Select(x => new
                                    {
                                        Key = x,
                                        Values = x.Variable,
                                    })
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => x.Values.Select(v => new { Key = v.VariableId, Value = x.Key }))
                                    .ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Variables);
                    });
            
        }
    }
}
            