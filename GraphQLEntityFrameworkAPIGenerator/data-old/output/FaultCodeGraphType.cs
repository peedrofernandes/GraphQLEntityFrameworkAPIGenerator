
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
    public partial class FaultCodeGraphType : ObjectGraphType<FaultCode>
    {
        public FaultCodeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FaultCode1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FaultDescription, type: typeof(StringGraphType), nullable: False);
            
                Field<FaultSubCodeGraphType, FaultSubCode>("FaultSubCodes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<FaultSubCodeGraphType>>(
                            "{ Name = EntityName "FaultCode"
  CorrespondingTable =
   Regular
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
  Fields = [{ Name = "FaultCode1"
              Type = Id Byte
              IsNullable = false }; { Name = "FaultDescription"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "FaultSubCode"
        TargetTable =
         { Name = TableName "FaultSubCode"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "FaultCode"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "FaultSubCode1"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "FaultSubCodeDescription"
                         IsNullable = false };
             Navigation { Type = TableName "FaultCode"
                          Name = "FaultCodeNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "FaultSubCode"
        KeyType = Byte }] }-FaultSubCode-loader",
                            async ids => 
                            {
                                var data = await dbContext.FaultSubCodes
                                    .Where(x => x.FaultSubCode != null && ids.Contains((byte)x.FaultSubCode))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.FaultSubCode!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.FaultSubCodes);
                    });
            
        }
    }
}
            