
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
    public partial class CrossLoadTypeGraphType : ObjectGraphType<CrossLoadType>
    {
        public CrossLoadTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CrossLoadTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CrossLoadTypeDsc, type: typeof(StringGraphType), nullable: False);
            
                Field<CrossLoadDetailGraphType, CrossLoadDetail>("CrossLoadDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CrossLoadDetailGraphType>>(
                            "{ Name = EntityName "CrossLoadType"
  CorrespondingTable =
   Regular
     { Name = TableName "CrossLoadType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "CrossLoadTypeId"
                      IsNullable = false };
         Primitive { Type = String
                     Name = "CrossLoadTypeDsc"
                     IsNullable = false };
         Navigation { Type = TableName "CrossLoadDetail"
                      Name = "CrossLoadDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "CrossLoadTypeId"
              Type = Id Byte
              IsNullable = false }; { Name = "CrossLoadTypeDsc"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CrossLoadDetail"
        TargetTable =
         { Name = TableName "CrossLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "CrossLoadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "OnDelayTime"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "OffDelayTime"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CouplesNum"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOnDisconnected"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOffDisconnected"
                         IsNullable = false };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CrossLoadType"
                          Name = "CrossLoadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadDetail"
        KeyType = Guid }] }-CrossLoadDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.CrossLoadDetails
                                    .Where(x => x.CrossLoadDetail != null && ids.Contains((Guid)x.CrossLoadDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CrossLoadDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CrossLoadDetails);
                    });
            
        }
    }
}
            