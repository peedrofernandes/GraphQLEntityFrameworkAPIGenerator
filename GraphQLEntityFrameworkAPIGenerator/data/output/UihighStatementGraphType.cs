
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
    public partial class UihighStatementGraphType : ObjectGraphType<UihighStatement>
    {
        public UihighStatementGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.OpCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.F0, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.F1, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Priority, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiopCodeGraphType, UiopCode>("UiopCodes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, UiopCodeGraphType>(
                            "{ Name = EntityName "UihighStatement"
  CorrespondingTable =
   Regular
     { Name = TableName "UihighStatement"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "OpCode"
                      IsNullable = false }; PrimaryKey { Type = Bool
                                                         Name = "F0"
                                                         IsNullable = false };
         PrimaryKey { Type = Bool
                      Name = "F1"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Description"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "Priority"
                     IsNullable = false };
         Navigation { Type = TableName "UiopCode"
                      Name = "OpCodeNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "OpCode"
      Type = Id Byte
      IsNullable = false }; { Name = "F0"
                              Type = Id Bool
                              IsNullable = false }; { Name = "F1"
                                                      Type = Id Bool
                                                      IsNullable = false };
    { Name = "Description"
      Type = Primitive String
      IsNullable = false }; { Name = "Priority"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiopCode"
        TargetTable =
         { Name = TableName "UiopCode"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "OpCode"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Statement"
                                                            IsNullable = false };
             Navigation { Type = TableName "UihighStatement"
                          Name = "UihighStatements"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiopCode"
        IsNullable = false
        KeyType = Byte }] }-UiopCode-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiopCodes
                                    .Where(x => x.UiopCode != null && ids.Contains((byte)x.UiopCode))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.UiopCode!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiopCode);
                });
            
        }
    }
}
            