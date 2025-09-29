
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
    public partial class VariableGraphType : ObjectGraphType<Variable>
    {
        public VariableGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.VariableId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Variable1, type: typeof(StringGraphType), nullable: False);
			Field(t => t.DataType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IsBitmap, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsWritable, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Offset, type: typeof(ByteGraphType), nullable: True);
            
                Field<FlagGraphType, Flag>("Flags")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<FlagGraphType>>(
                            "{ Name = EntityName "Variable"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "VariableId"
      Type = Id Int
      IsNullable = false }; { Name = "Variable1"
                              Type = Primitive String
                              IsNullable = false }; { Name = "DataType"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "IsBitmap"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsWritable"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Offset"
                                                      Type = Primitive Byte
                                                      IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "Flag"
        TargetTable =
         { Name = TableName "Flag"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Position"
                          IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "VariableId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Flag1"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Offset"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsEnum"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "BitSize"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "TableBinding"
                                                           IsNullable = true };
             Primitive { Type = String
                         Name = "DisplayMember"
                         IsNullable = true }; Primitive { Type = String
                                                          Name = "ValueMember"
                                                          IsNullable = true };
             Navigation { Type = TableName "Variable"
                          Name = "Variable"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Flag"
        KeyType = Byte };
    ManyToManyWithJoinTable
      { Name = RelationName "ProductTypesVariable"
        JoinTable =
         { Name = TableName "ProductTypesVariable"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "VariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeVariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeOffsetId"
                          IsNullable = false };
             Navigation { Type = TableName "ProductType"
                          Name = "ProductType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Variable"
                          Name = "Variable"
                          IsNullable = false
                          IsCollection = false }] }
        TargetTable =
         { Name = TableName "ProductType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ProductTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "ProductTypesHighStatement"
                          Name = "ProductTypesHighStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesTask"
                          Name = "ProductTypesTasks"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesVariable"
                          Name = "ProductTypesVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ProductType"
        KeyType = Byte };
    ManyToMany
      { Name = RelationName "VariableGroup"
        TargetTable =
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
        Destination = EntityName "VariableGroup"
        KeyType = Byte }] }-Flag-loader",
                            async ids => 
                            {
                                var data = await dbContext.Flags
                                    .Where(x => x.Flag != null && ids.Contains((byte)x.Flag))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.Flag!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.Flags);
                    });
            
			
                Field<ProductTypeGraphType, ProductType>("ProductTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<ProductTypeGraphType>>(
                            "{ Name = EntityName "Variable"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "VariableId"
      Type = Id Int
      IsNullable = false }; { Name = "Variable1"
                              Type = Primitive String
                              IsNullable = false }; { Name = "DataType"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "IsBitmap"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsWritable"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Offset"
                                                      Type = Primitive Byte
                                                      IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "Flag"
        TargetTable =
         { Name = TableName "Flag"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Position"
                          IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "VariableId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Flag1"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Offset"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsEnum"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "BitSize"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "TableBinding"
                                                           IsNullable = true };
             Primitive { Type = String
                         Name = "DisplayMember"
                         IsNullable = true }; Primitive { Type = String
                                                          Name = "ValueMember"
                                                          IsNullable = true };
             Navigation { Type = TableName "Variable"
                          Name = "Variable"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Flag"
        KeyType = Byte };
    ManyToManyWithJoinTable
      { Name = RelationName "ProductTypesVariable"
        JoinTable =
         { Name = TableName "ProductTypesVariable"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "VariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeVariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeOffsetId"
                          IsNullable = false };
             Navigation { Type = TableName "ProductType"
                          Name = "ProductType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Variable"
                          Name = "Variable"
                          IsNullable = false
                          IsCollection = false }] }
        TargetTable =
         { Name = TableName "ProductType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ProductTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "ProductTypesHighStatement"
                          Name = "ProductTypesHighStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesTask"
                          Name = "ProductTypesTasks"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesVariable"
                          Name = "ProductTypesVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ProductType"
        KeyType = Byte };
    ManyToMany
      { Name = RelationName "VariableGroup"
        TargetTable =
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
        Destination = EntityName "VariableGroup"
        KeyType = Byte }] }-ProductType-loader",
                            async ids => 
                            {
                                var data = await dbContext.ProductTypesVariable
                                    .Where(x => x.ProductTypeVariableId != null && ids.Contains((byte)x.ProductTypeVariableId))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.ProductTypeVariableId!,
                                        Value = x.ProductType,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.ProductTypes);
                    });
            
			
                Field<VariableGroupGraphType, VariableGroup>("VariableGroups")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, VariableGroupGraphType>(
                            "{ Name = EntityName "Variable"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "VariableId"
      Type = Id Int
      IsNullable = false }; { Name = "Variable1"
                              Type = Primitive String
                              IsNullable = false }; { Name = "DataType"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "IsBitmap"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsWritable"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Offset"
                                                      Type = Primitive Byte
                                                      IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "Flag"
        TargetTable =
         { Name = TableName "Flag"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Position"
                          IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "VariableId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Flag1"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Offset"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsEnum"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "BitSize"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "TableBinding"
                                                           IsNullable = true };
             Primitive { Type = String
                         Name = "DisplayMember"
                         IsNullable = true }; Primitive { Type = String
                                                          Name = "ValueMember"
                                                          IsNullable = true };
             Navigation { Type = TableName "Variable"
                          Name = "Variable"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Flag"
        KeyType = Byte };
    ManyToManyWithJoinTable
      { Name = RelationName "ProductTypesVariable"
        JoinTable =
         { Name = TableName "ProductTypesVariable"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             PrimaryKey { Type = Int
                          Name = "VariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeVariableId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeOffsetId"
                          IsNullable = false };
             Navigation { Type = TableName "ProductType"
                          Name = "ProductType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Variable"
                          Name = "Variable"
                          IsNullable = false
                          IsCollection = false }] }
        TargetTable =
         { Name = TableName "ProductType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ProductTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "ProductTypesHighStatement"
                          Name = "ProductTypesHighStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesTask"
                          Name = "ProductTypesTasks"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesVariable"
                          Name = "ProductTypesVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ProductType"
        KeyType = Byte };
    ManyToMany
      { Name = RelationName "VariableGroup"
        TargetTable =
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
        Destination = EntityName "VariableGroup"
        KeyType = Byte }] }-VariableGroup-loader",
                            async ids => 
                            {
                                var data = await dbContext.VariableGroups
                                    .Where(x => x.VariableGroup.Any(c => ids.Contains(c.VariableGroupId)))
                                    .Select(x => new
                                    {
                                        Key = x,
                                        Values = x.VariableGroup,
                                    })
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => x.Values.Select(v => new { Key = v.VariableGroupId, Value = x.Key }))
                                    .ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.VariableGroups);
                    });
            
        }
    }
}
            