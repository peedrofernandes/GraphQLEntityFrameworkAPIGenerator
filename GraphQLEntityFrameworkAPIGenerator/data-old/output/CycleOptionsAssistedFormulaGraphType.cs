
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
    public partial class CycleOptionsAssistedFormulaGraphType : ObjectGraphType<CycleOptionsAssistedFormula>
    {
        public CycleOptionsAssistedFormulaGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.AssistedFormulaParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfInputs, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Constant, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Temperature, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.InputId1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Coefficient1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.InputId2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Coefficient2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.InputId3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Coefficient3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.InputId4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Coefficient4, type: typeof(FloatGraphType), nullable: False);
            
                Field<CycleOptionsAssistedFormulaInputGraphType, CycleOptionsAssistedFormulaInput>("CycleOptionsAssistedFormulaInputs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleOptionsAssistedFormulaInputGraphType>(
                            "{ Name = EntityName "CycleOptionsAssistedFormula"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleOptionsAssistedFormula"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "AssistedFormulaParamsId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "NumberOfInputs"
                                                        IsNullable = false };
         Primitive { Type = Float
                     Name = "Constant"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "Temperature"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "InputId1"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "Coefficient1"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "InputId2"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "Coefficient2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "InputId3"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "Coefficient3"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "InputId4"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "Coefficient4"
                                                       IsNullable = false };
         Navigation { Type = TableName "CycleOptionsAssistedFormulaInput"
                      Name = "InputId1Navigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CycleOptionsAssistedFormulaInput"
                      Name = "InputId2Navigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CycleOptionsAssistedFormulaInput"
                      Name = "InputId3Navigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CycleOptionsAssistedFormulaInput"
                      Name = "InputId4Navigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "AssistedFormulaParamsId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumberOfInputs"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Constant"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "Temperature"
      Type = Primitive Float
      IsNullable = false }; { Name = "InputId1"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Coefficient1"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "InputId2"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Coefficient2"
                              Type = Primitive Float
                              IsNullable = false }; { Name = "InputId3"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Coefficient3"
      Type = Primitive Float
      IsNullable = false }; { Name = "InputId4"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Coefficient4"
                                                      Type = Primitive Float
                                                      IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "InputId1Navigation"; RelationName "InputId2Navigation";
          RelationName "InputId3Navigation"; RelationName "InputId4Navigation"]
        TargetTable =
         { Name = TableName "CycleOptionsAssistedFormulaInput"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Navigation
               { Type = TableName "CycleOptionsAssistedFormula"
                 Name = "CycleOptionsAssistedFormulaInputId1Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "CycleOptionsAssistedFormula"
                 Name = "CycleOptionsAssistedFormulaInputId2Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "CycleOptionsAssistedFormula"
                 Name = "CycleOptionsAssistedFormulaInputId3Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "CycleOptionsAssistedFormula"
                 Name = "CycleOptionsAssistedFormulaInputId4Navigations"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleOptionsAssistedFormulaInput"
        IsNullable = false
        KeyType = Byte }] }-CycleOptionsAssistedFormulaInput-loader",
                            async ids => 
                            {
                                Expression<Func<CycleOptionsAssistedFormulaInput, bool>> expr = x => !ids.Any()
                                    \|\| (x.InputId1Navigation != null && ids.Contains((byte)x.InputId1Navigation))
\|\| (x.InputId2Navigation != null && ids.Contains((byte)x.InputId2Navigation))
\|\| (x.InputId3Navigation != null && ids.Contains((byte)x.InputId3Navigation))
\|\| (x.InputId4Navigation != null && ids.Contains((byte)x.InputId4Navigation));

                                var data = await dbContext.CycleOptionsAssistedFormulaInputs
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<byte?>()
                                    {
                                        x.InputId1Navigation,
x.InputId2Navigation,
x.InputId3Navigation,
x.InputId4Navigation
                                    }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.CycleOptionsAssistedFormulaInputs);
                    });
            
        }
    }
}
            