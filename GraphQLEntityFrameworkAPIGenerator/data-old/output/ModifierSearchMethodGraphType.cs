
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
    public partial class ModifierSearchMethodGraphType : ObjectGraphType<ModifierSearchMethod>
    {
        public ModifierSearchMethodGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ModifierSearchMethodId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ModifierSearchMethodDescription, type: typeof(StringGraphType), nullable: False);
            
                Field<ModifiersDetailGraphType, ModifiersDetail>("ModifiersDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ModifiersDetailGraphType>>(
                            "{ Name = EntityName "ModifierSearchMethod"
  CorrespondingTable =
   Regular
     { Name = TableName "ModifierSearchMethod"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "ModifierSearchMethodId"
                      IsNullable = false };
         Primitive { Type = String
                     Name = "ModifierSearchMethodDescription"
                     IsNullable = false };
         Navigation { Type = TableName "ModifiersDetail"
                      Name = "ModifiersDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "ModifierSearchMethodId"
              Type = Id Byte
              IsNullable = false }; { Name = "ModifierSearchMethodDescription"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "ModifiersDetail"
        TargetTable =
         { Name = TableName "ModifiersDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ModifiersDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "NumItems"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "VariableIndex"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "VariableOffset"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ModifierSearchMethodId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsPercent"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "VariableGroupId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Modifier"
                          Name = "ModifierModifierDetails8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ModifierSearchMethod"
                          Name = "ModifierSearchMethod"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "ModifiersDetail"
        KeyType = Guid }] }-ModifiersDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.ModifiersDetails
                                    .Where(x => x.ModifiersDetail != null && ids.Contains((Guid)x.ModifiersDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.ModifiersDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.ModifiersDetails);
                    });
            
        }
    }
}
            