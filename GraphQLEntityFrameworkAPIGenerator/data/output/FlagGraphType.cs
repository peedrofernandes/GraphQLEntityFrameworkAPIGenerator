
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
    public partial class FlagGraphType : ObjectGraphType<Flag>
    {
        public FlagGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Position, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VariableId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Flag1, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Offset, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IsEnum, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.BitSize, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TableBinding, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DisplayMember, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ValueMember, type: typeof(StringGraphType), nullable: True);
            
                Field<VariableGraphType, Variable>("Variables")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, VariableGraphType>(
                            "{ Name = EntityName "Flag"
  CorrespondingTable =
   Regular
     { Name = TableName "Flag"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "Position"
                      IsNullable = false }; PrimaryKey { Type = Int
                                                         Name = "VariableId"
                                                         IsNullable = false };
         Primitive { Type = String
                     Name = "Flag1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Offset"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsEnum"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "BitSize"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "TableBinding"
                     IsNullable = true }; Primitive { Type = String
                                                      Name = "DisplayMember"
                                                      IsNullable = true };
         Primitive { Type = String
                     Name = "ValueMember"
                     IsNullable = true };
         Navigation { Type = TableName "Variable"
                      Name = "Variable"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "Position"
      Type = Id Byte
      IsNullable = false }; { Name = "VariableId"
                              Type = Id Int
                              IsNullable = false }; { Name = "Flag1"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Offset"
      Type = Primitive Byte
      IsNullable = false }; { Name = "IsEnum"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "BitSize"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "TableBinding"
      Type = Primitive String
      IsNullable = true }; { Name = "DisplayMember"
                             Type = Primitive String
                             IsNullable = true }; { Name = "ValueMember"
                                                    Type = Primitive String
                                                    IsNullable = true }]
  Relations =
   [SingleManyToOne
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
        IsNullable = false
        KeyType = Int }] }-Variable-loader",
                            async ids => 
                            {
                                var data = await dbContext.Variables
                                    .Where(x => x.Variable != null && ids.Contains((int)x.Variable))
                                    .Select(x => new
                                    {
                                        Key = (int)x.Variable!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Variable);
                });
            
        }
    }
}
            