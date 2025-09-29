
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
    public partial class PrmReadAccellerometerStlisxDhGraphType : ObjectGraphType<PrmReadAccellerometerStlisxDh>
    {
        public PrmReadAccellerometerStlisxDhGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrmReadAccellerometerStlisxDhid, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Fifo, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Res, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.I2cport, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.I2cspd, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.I2caddress, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Xa, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Ya, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Za, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Bdu, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Be, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Tr, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Scale, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DataRate, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.XaxisOptions, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.YaxisOptions, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ZaxisOptions, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrmReadAccellerometerGraphType, PrmReadAccellerometer>("PrmReadAccellerometers")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmReadAccellerometerGraphType>>(
                            "{ Name = EntityName "PrmReadAccellerometerStlisxDh"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "PrmReadAccellerometerStlisxDhid"
      Type = Id Guid
      IsNullable = false }; { Name = "Fifo"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Res"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "I2cport"
      Type = Primitive Byte
      IsNullable = false }; { Name = "I2cspd"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "I2caddress"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Xa"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Ya"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Za"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Bdu"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Be"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Tr"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Scale"
      Type = Primitive Byte
      IsNullable = false }; { Name = "DataRate"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "XaxisOptions"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "YaxisOptions"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ZaxisOptions"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "PrmReadAccellerometer"
        TargetTable =
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
        Destination = EntityName "PrmReadAccellerometer"
        KeyType = Guid }] }-PrmReadAccellerometer-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrmReadAccellerometers
                                    .Where(x => x.PrmReadAccellerometer != null && ids.Contains((Guid)x.PrmReadAccellerometer))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrmReadAccellerometer!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrmReadAccellerometers);
                    });
            
        }
    }
}
            