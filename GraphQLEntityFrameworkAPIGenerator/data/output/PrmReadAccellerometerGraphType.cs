
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
    public partial class PrmReadAccellerometerGraphType : ObjectGraphType<PrmReadAccellerometer>
    {
        public PrmReadAccellerometerGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Device, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrmReadAccellerometerStlisxDhGraphType, PrmReadAccellerometerStlisxDh>("PrmReadAccellerometerStlisxDhs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrmReadAccellerometerStlisxDhGraphType>(
                            "{ Name = EntityName "PrmReadAccellerometer"
  CorrespondingTable =
   Regular
     { Name = TableName "PrmReadAccellerometer"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Device"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "AccellerometerParamsId"
                      IsNullable = true };
         Navigation { Type = TableName "PrmReadAccellerometerStlisxDh"
                      Name = "AccellerometerParams"
                      IsNullable = true
                      IsCollection = false }] }
  Fields = [{ Name = "Id"
              Type = Id Guid
              IsNullable = false }; { Name = "Device"
                                      Type = Primitive Byte
                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrmReadAccellerometerStlisxDh"
        TargetTable =
         { Name = TableName "PrmReadAccellerometerStlisxDh"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrmReadAccellerometerStlisxDhid"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Fifo"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Res"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "I2cport"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "I2cspd"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "I2caddress"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Xa"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Ya"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Za"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Bdu"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Be"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Tr"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Scale"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "DataRate"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "XaxisOptions"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "YaxisOptions"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "ZaxisOptions"
                         IsNullable = false };
             Navigation { Type = TableName "PrmReadAccellerometer"
                          Name = "PrmReadAccellerometers"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrmReadAccellerometerStlisxDh"
        IsNullable = true
        KeyType = Guid }] }-PrmReadAccellerometerStlisxDh-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrmReadAccellerometerStlisxDhs
                                    .Where(x => x.PrmReadAccellerometerStlisxDh != null && ids.Contains((Guid)x.PrmReadAccellerometerStlisxDh))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrmReadAccellerometerStlisxDh!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrmReadAccellerometerStlisxDh);
                });
            
        }
    }
}
            