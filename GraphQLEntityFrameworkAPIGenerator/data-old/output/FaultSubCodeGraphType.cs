
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
    public partial class FaultSubCodeGraphType : ObjectGraphType<FaultSubCode>
    {
        public FaultSubCodeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FaultCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FaultSubCode1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FaultSubCodeDescription, type: typeof(StringGraphType), nullable: False);
            
                Field<FaultCodeGraphType, FaultCode>("FaultCodes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, FaultCodeGraphType>(
                            "{ Name = EntityName "FaultSubCode"
  CorrespondingTable =
   Regular
     { Name = TableName "FaultSubCode"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "FaultCode"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "FaultSubCode1"
                                                         IsNullable = false };
         Primitive { Type = String
                     Name = "FaultSubCodeDescription"
                     IsNullable = false };
         Navigation { Type = TableName "FaultCode"
                      Name = "FaultCodeNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "FaultCode"
      Type = Id Byte
      IsNullable = false }; { Name = "FaultSubCode1"
                              Type = Id Byte
                              IsNullable = false };
    { Name = "FaultSubCodeDescription"
      Type = Primitive String
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "FaultCode"
        TargetTable =
         { Name = TableName "FaultCode"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "FaultCode1"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "FaultDescription"
                         IsNullable = false };
             Navigation { Type = TableName "FaultSubCode"
                          Name = "FaultSubCodes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "FaultCode"
        IsNullable = false
        KeyType = Byte }] }-FaultCode-loader",
                            async ids => 
                            {
                                var data = await dbContext.FaultCodes
                                    .Where(x => x.FaultCode != null && ids.Contains((byte)x.FaultCode))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.FaultCode!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.FaultCode);
                });
            
        }
    }
}
            