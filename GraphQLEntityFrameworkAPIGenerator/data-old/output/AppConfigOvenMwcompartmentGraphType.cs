
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
    public partial class AppConfigOvenMwcompartmentGraphType : ObjectGraphType<AppConfigOvenMwcompartment>
    {
        public AppConfigOvenMwcompartmentGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.RelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Dlb, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Bake, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Broil1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Broil2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvElement1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvElement2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvFan1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvFan2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LatchMotor, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Temperature1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Temperature2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MeatProbe, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DoorSwitch, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LatchSwitch, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Light, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Magnetron, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ForcedConvValve, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TurnTable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.HumiditySensor, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DlbfeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.BackupRestore, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadsFeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.BakeFeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.BakeRelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Broil1FeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Broil1RelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Broil2FeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Broil2RelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvElement1FeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvElement1RelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvElement2FeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvElement2RelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LatchFeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LatchRelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MagnetronFeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MagnetronRelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TurnTableFeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TurnTableRelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Light2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SecondaryDoorSwitch, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ToastSensor, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SecondaryDlb, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SecondaryDlbFeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SecondaryRelayEnable, type: typeof(ByteGraphType), nullable: False);
            
                Field<AppConfigCompartmentDetailGraphType, AppConfigCompartmentDetail>("AppConfigCompartmentDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<AppConfigCompartmentDetailGraphType>>(
                            "{ Name = EntityName "AppConfigOvenMwcompartment"
  CorrespondingTable =
   Regular
     { Name = TableName "AppConfigOvenMwcompartment"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "RelayEnable"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "Dlb"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Bake"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Broil1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Broil2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ConvElement1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ConvElement2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ConvFan1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ConvFan2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "LatchMotor"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Temperature1"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Temperature2"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "MeatProbe"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "DoorSwitch"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "LatchSwitch"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Light"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Magnetron"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ForcedConvValve"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TurnTable"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "HumiditySensor"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "DlbfeedbackIndex"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "BackupRestore"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "LoadsFeedbackIndex"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "BakeFeedbackIndex"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "BakeRelayEnable"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Broil1FeedbackIndex"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "Broil1RelayEnable"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "Broil2FeedbackIndex"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "Broil2RelayEnable"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "ConvElement1FeedbackIndex"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "ConvElement1RelayEnable"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "ConvElement2FeedbackIndex"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "ConvElement2RelayEnable"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "LatchFeedbackIndex"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "LatchRelayEnable"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "MagnetronFeedbackIndex"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "MagnetronRelayEnable"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "TurnTableFeedbackIndex"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "TurnTableRelayEnable"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Light2"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "SecondaryDoorSwitch"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ToastSensor"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "SecondaryDlb"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "SecondaryDlbFeedbackIndex"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "SecondaryRelayEnable"
                     IsNullable = false };
         Navigation { Type = TableName "AppConfigCompartmentDetail"
                      Name = "AppConfigCompartmentDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "RelayEnable"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Dlb"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Bake"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Broil1"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Broil2"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ConvElement1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ConvElement2"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ConvFan1"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ConvFan2"
      Type = Primitive Byte
      IsNullable = false }; { Name = "LatchMotor"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Temperature1"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Temperature2"
      Type = Primitive Byte
      IsNullable = false }; { Name = "MeatProbe"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "DoorSwitch"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "LatchSwitch"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Light"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Magnetron"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ForcedConvValve"
      Type = Primitive Byte
      IsNullable = false }; { Name = "TurnTable"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "HumiditySensor"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "DlbfeedbackIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "BackupRestore"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "LoadsFeedbackIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "BakeFeedbackIndex"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "BakeRelayEnable"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Broil1FeedbackIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Broil1RelayEnable"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "Broil2FeedbackIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Broil2RelayEnable"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "ConvElement1FeedbackIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ConvElement1RelayEnable"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "ConvElement2FeedbackIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ConvElement2RelayEnable"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "LatchFeedbackIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "LatchRelayEnable"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "MagnetronFeedbackIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "MagnetronRelayEnable"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "TurnTableFeedbackIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "TurnTableRelayEnable"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Light2"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "SecondaryDoorSwitch"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ToastSensor"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "SecondaryDlb"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "SecondaryDlbFeedbackIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "SecondaryRelayEnable"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "AppConfigCompartmentDetail"
        TargetTable =
         { Name = TableName "AppConfigCompartmentDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AppConfigCompartmentDetailsId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Name"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "CompartmentType"
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
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Notes"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Version"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "OvenMwcompartmentId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "OvenCoolingFanCompId"
                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "HallEffectSensorPresent"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "BackupRestore"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName "ApplianceConfigurationAppConfigCompartmentDetail"
                 Name = "ApplianceConfigurationAppConfigCompartmentDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "AppConfigCoolingFanCompartment"
                          Name = "OvenCoolingFanComp"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "AppConfigOvenMwcompartment"
                          Name = "OvenMwcompartment"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "AppConfigCompartmentDetail"
        KeyType = Guid }] }-AppConfigCompartmentDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.AppConfigCompartmentDetails
                                    .Where(x => x.AppConfigCompartmentDetail != null && ids.Contains((Guid)x.AppConfigCompartmentDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.AppConfigCompartmentDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.AppConfigCompartmentDetails);
                    });
            
        }
    }
}
            