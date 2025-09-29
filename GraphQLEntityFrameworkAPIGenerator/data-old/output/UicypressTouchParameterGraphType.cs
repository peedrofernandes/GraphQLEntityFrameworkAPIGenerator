
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
    public partial class UicypressTouchParameterGraphType : ObjectGraphType<UicypressTouchParameter>
    {
        public UicypressTouchParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UicypressTouchId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumDevices, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CapsenseMethod, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DeviceI2cport0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DeviceI2caddress0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DeviceNumKeys0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DeviceI2cport1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DeviceI2caddress1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.DeviceNumKeys1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.NumSensors, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Lpmdevice, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StuckKeyTimeout, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.I2cspeed, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DeviceNumSliders0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DeviceNumSliders1, type: typeof(ByteGraphType), nullable: False);
            
                Field<UitouchDeviceGraphType, UitouchDevice>("UitouchDevices")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UitouchDeviceGraphType>>(
                            "{ Name = EntityName "UicypressTouchParameter"
  CorrespondingTable =
   Regular
     { Name = TableName "UicypressTouchParameter"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UicypressTouchId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Description"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "Status"
                     IsNullable = false }; Primitive { Type = String
                                                       Name = "Owner"
                                                       IsNullable = false };
         Primitive { Type = DateTime
                     Name = "Timestamp"
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "NumDevices"
                                                      IsNullable = false };
         Primitive { Type = Bool
                     Name = "CapsenseMethod"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "DeviceI2cport0"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "DeviceI2caddress0"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "DeviceNumKeys0"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "DeviceI2cport1"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "DeviceI2caddress1"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "DeviceNumKeys1"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "NumSensors"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "Lpmdevice"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "StuckKeyTimeout"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "I2cspeed"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "DeviceNumSliders0"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "DeviceNumSliders1"
                     IsNullable = false };
         Navigation { Type = TableName "UitouchDevice"
                      Name = "UitouchDevices"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "UicypressTouchId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true };
    { Name = "NumDevices"
      Type = Primitive Byte
      IsNullable = false }; { Name = "CapsenseMethod"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "DeviceI2cport0"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "DeviceI2caddress0"
      Type = Primitive Byte
      IsNullable = false }; { Name = "DeviceNumKeys0"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "DeviceI2cport1"
                                                      Type = Primitive Byte
                                                      IsNullable = true };
    { Name = "DeviceI2caddress1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "DeviceNumKeys1"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "NumSensors"
                                                    Type = Primitive Byte
                                                    IsNullable = false };
    { Name = "Lpmdevice"
      Type = Primitive Byte
      IsNullable = false }; { Name = "StuckKeyTimeout"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "I2cspeed"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "DeviceNumSliders0"
      Type = Primitive Byte
      IsNullable = false }; { Name = "DeviceNumSliders1"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UitouchDevice"
        TargetTable =
         { Name = TableName "UitouchDevice"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UitouchDevicesId"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UicypressTouchId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UitouchLeanId"
                          IsNullable = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UicypressTouchParameter"
                          Name = "UicypressTouch"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UitouchLean"
                          Name = "UitouchLean"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UitouchDevice"
        KeyType = Guid }] }-UitouchDevice-loader",
                            async ids => 
                            {
                                var data = await dbContext.UitouchDevices
                                    .Where(x => x.UitouchDevice != null && ids.Contains((Guid)x.UitouchDevice))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UitouchDevice!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UitouchDevices);
                    });
            
        }
    }
}
            