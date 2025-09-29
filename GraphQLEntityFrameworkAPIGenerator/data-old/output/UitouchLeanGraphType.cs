
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
    public partial class UitouchLeanGraphType : ObjectGraphType<UitouchLean>
    {
        public UitouchLeanGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UitouchLeanId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfZones, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.EnableTouchLeanFeature, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.TimeToComeOutFromLeanModeZone0, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TimeDuringLeanModeZone0, type: typeof(IdGraphType), nullable: False);
			Field(t => t.LockKeysNumberZone0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensorSelectionBufferZone0, type: typeof(LongGraphType), nullable: False);
			Field(t => t.TimeToComeOutFromLeanModeZone1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TimeDuringLeanModeZone1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.LockKeysNumberZone1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensorSelectionBufferZone1, type: typeof(LongGraphType), nullable: False);
			Field(t => t.TimeToComeOutFromLeanModeZone2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TimeDuringLeanModeZone2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.LockKeysNumberZone2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensorSelectionBufferZone2, type: typeof(LongGraphType), nullable: False);
			Field(t => t.TimeToComeOutFromLeanModeZone3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TimeDuringLeanModeZone3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.LockKeysNumberZone3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SensorSelectionBufferZone3, type: typeof(LongGraphType), nullable: False);
			Field(t => t.MaxZoneSensorBufferSize, type: typeof(ByteGraphType), nullable: False);
            
                Field<UitouchDeviceGraphType, UitouchDevice>("UitouchDevices")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UitouchDeviceGraphType>>(
                            "{ Name = EntityName "UitouchLean"
  CorrespondingTable =
   Regular
     { Name = TableName "UitouchLean"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UitouchLeanId"
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
                                                      Name = "NumberOfZones"
                                                      IsNullable = false };
         Primitive { Type = Bool
                     Name = "EnableTouchLeanFeature"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "TimeToComeOutFromLeanModeZone0"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "TimeDuringLeanModeZone0"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "LockKeysNumberZone0"
                     IsNullable = false };
         Primitive { Type = Long
                     Name = "SensorSelectionBufferZone0"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "TimeToComeOutFromLeanModeZone1"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "TimeDuringLeanModeZone1"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "LockKeysNumberZone1"
                     IsNullable = false };
         Primitive { Type = Long
                     Name = "SensorSelectionBufferZone1"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "TimeToComeOutFromLeanModeZone2"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "TimeDuringLeanModeZone2"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "LockKeysNumberZone2"
                     IsNullable = false };
         Primitive { Type = Long
                     Name = "SensorSelectionBufferZone2"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "TimeToComeOutFromLeanModeZone3"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "TimeDuringLeanModeZone3"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "LockKeysNumberZone3"
                     IsNullable = false };
         Primitive { Type = Long
                     Name = "SensorSelectionBufferZone3"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "MaxZoneSensorBufferSize"
                     IsNullable = false };
         Navigation { Type = TableName "UitouchDevice"
                      Name = "UitouchDevices"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "UitouchLeanId"
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
    { Name = "NumberOfZones"
      Type = Primitive Byte
      IsNullable = false }; { Name = "EnableTouchLeanFeature"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "TimeToComeOutFromLeanModeZone0"
      Type = Primitive Int
      IsNullable = false }; { Name = "TimeDuringLeanModeZone0"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "LockKeysNumberZone0"
      Type = Primitive Byte
      IsNullable = false }; { Name = "SensorSelectionBufferZone0"
                              Type = Primitive Long
                              IsNullable = false };
    { Name = "TimeToComeOutFromLeanModeZone1"
      Type = Primitive Int
      IsNullable = false }; { Name = "TimeDuringLeanModeZone1"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "LockKeysNumberZone1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "SensorSelectionBufferZone1"
                              Type = Primitive Long
                              IsNullable = false };
    { Name = "TimeToComeOutFromLeanModeZone2"
      Type = Primitive Int
      IsNullable = false }; { Name = "TimeDuringLeanModeZone2"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "LockKeysNumberZone2"
      Type = Primitive Byte
      IsNullable = false }; { Name = "SensorSelectionBufferZone2"
                              Type = Primitive Long
                              IsNullable = false };
    { Name = "TimeToComeOutFromLeanModeZone3"
      Type = Primitive Int
      IsNullable = false }; { Name = "TimeDuringLeanModeZone3"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "LockKeysNumberZone3"
      Type = Primitive Byte
      IsNullable = false }; { Name = "SensorSelectionBufferZone3"
                              Type = Primitive Long
                              IsNullable = false };
    { Name = "MaxZoneSensorBufferSize"
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
            