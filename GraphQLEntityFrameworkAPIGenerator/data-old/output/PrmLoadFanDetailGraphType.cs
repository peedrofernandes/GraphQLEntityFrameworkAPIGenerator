
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
    public partial class PrmLoadFanDetailGraphType : ObjectGraphType<PrmLoadFanDetail>
    {
        public PrmLoadFanDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrmLoadFanDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.K1value, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.K2value, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.K3value, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.K4value, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PowerPercentage, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrmLoadFanConfigurationPrmLoadFanDetailGraphType, PrmLoadFanConfigurationPrmLoadFanDetail>("PrmLoadFanConfigurationPrmLoadFanDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmLoadFanConfigurationPrmLoadFanDetailGraphType>>(
                            "{ Name = EntityName "PrmLoadFanDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "PrmLoadFanDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrmLoadFanDetailsId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "K1value"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "K2value"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "K3value"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "K4value"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "PowerPercentage"
                                                       IsNullable = false };
         Navigation { Type = TableName "PrmLoadFanConfigurationPrmLoadFanDetail"
                      Name = "PrmLoadFanConfigurationPrmLoadFanDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "PrmLoadFanDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "K1value"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "K2value"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "K3value"
      Type = Primitive Byte
      IsNullable = false }; { Name = "K4value"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "PowerPercentage"
                                                      Type = Primitive Byte
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "PrmLoadFanConfigurationPrmLoadFanDetail"
        TargetTable =
         { Name = TableName "PrmLoadFanConfigurationPrmLoadFanDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrmLoadFanDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrmLoadFanConfiguration"
                          Name = "IdNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PrmLoadFanDetail"
                          Name = "PrmLoadFanDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "PrmLoadFanConfigurationPrmLoadFanDetail"
        KeyType = Guid }] }-PrmLoadFanConfigurationPrmLoadFanDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrmLoadFanConfigurationPrmLoadFanDetails
                                    .Where(x => x.PrmLoadFanConfigurationPrmLoadFanDetail != null && ids.Contains((Guid)x.PrmLoadFanConfigurationPrmLoadFanDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrmLoadFanConfigurationPrmLoadFanDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrmLoadFanConfigurationPrmLoadFanDetails);
                    });
            
        }
    }
}
            