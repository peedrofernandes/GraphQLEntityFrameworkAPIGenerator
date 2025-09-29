
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
    public partial class CycleOptionsAssistedFormulaInputGraphType : ObjectGraphType<CycleOptionsAssistedFormulaInput>
    {
        public CycleOptionsAssistedFormulaInputGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
            
                Field<CycleOptionsAssistedFormulaGraphType, CycleOptionsAssistedFormula>("CycleOptionsAssistedFormulas")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsAssistedFormulaGraphType>>(
                            "{ Name = EntityName "CycleOptionsAssistedFormulaInput"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleOptionsAssistedFormulaInput"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Description"
                                                        IsNullable = false };
         Navigation { Type = TableName "CycleOptionsAssistedFormula"
                      Name = "CycleOptionsAssistedFormulaInputId1Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CycleOptionsAssistedFormula"
                      Name = "CycleOptionsAssistedFormulaInputId2Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CycleOptionsAssistedFormula"
                      Name = "CycleOptionsAssistedFormulaInputId3Navigations"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CycleOptionsAssistedFormula"
                      Name = "CycleOptionsAssistedFormulaInputId4Navigations"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "Id"
              Type = Id Byte
              IsNullable = false }; { Name = "Description"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CycleOptionsAssistedFormula"
        TargetTable =
         { Name = TableName "CycleOptionsAssistedFormula"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AssistedFormulaParamsId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfInputs"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "Constant"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "Temperature"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "InputId1"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "Coefficient1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "InputId2"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "Coefficient2"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "InputId3"
                                                           IsNullable = false };
             Primitive { Type = Float
                         Name = "Coefficient3"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "InputId4"
                                                           IsNullable = false };
             Primitive { Type = Float
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
        Destination = EntityName "CycleOptionsAssistedFormula"
        KeyType = Guid }] }-CycleOptionsAssistedFormula-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleOptionsAssistedFormulas
                                    .Where(x => x.CycleOptionsAssistedFormula != null && ids.Contains((Guid)x.CycleOptionsAssistedFormula))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleOptionsAssistedFormula!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CycleOptionsAssistedFormulas);
                    });
            
        }
    }
}
            