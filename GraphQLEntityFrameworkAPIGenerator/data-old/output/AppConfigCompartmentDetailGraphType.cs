
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
    public partial class AppConfigCompartmentDetailGraphType : ObjectGraphType<AppConfigCompartmentDetail>
    {
        public AppConfigCompartmentDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.AppConfigCompartmentDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Name, type: typeof(StringGraphType), nullable: False);
			Field(t => t.CompartmentType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.HallEffectSensorPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.BackupRestore, type: typeof(ByteGraphType), nullable: False);
            
                Field<ApplianceConfigurationAppConfigCompartmentDetailGraphType, ApplianceConfigurationAppConfigCompartmentDetail>("ApplianceConfigurationAppConfigCompartmentDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ApplianceConfigurationAppConfigCompartmentDetailGraphType>>(
                            "{ Name = EntityName "AppConfigCompartmentDetail"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "BackupRestore"
                                                       IsNullable = false };
         Navigation
           { Type = TableName "ApplianceConfigurationAppConfigCompartmentDetail"
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
  Fields =
   [{ Name = "AppConfigCompartmentDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Name"
                              Type = Primitive String
                              IsNullable = false }; { Name = "CompartmentType"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Description"
      Type = Primitive String
      IsNullable = false }; { Name = "Status"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Owner"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Timestamp"
      Type = Primitive DateTime
      IsNullable = false }; { Name = "RevisionGroup"
                              Type = Primitive Guid
                              IsNullable = false }; { Name = "Revision"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "TableTarget"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Notes"
                              Type = Primitive String
                              IsNullable = true }; { Name = "Version"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "HallEffectSensorPresent"
      Type = Primitive Bool
      IsNullable = false }; { Name = "BackupRestore"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "ApplianceConfigurationAppConfigCompartmentDetail"
        TargetTable =
         { Name = TableName "ApplianceConfigurationAppConfigCompartmentDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ApplianceConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "AppConfigCompartmentDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "AppConfigCompartmentDetail"
                          Name = "AppConfigCompartmentDetails"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ApplianceConfiguration"
                          Name = "ApplianceConfiguration"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "ApplianceConfigurationAppConfigCompartmentDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "AppConfigCoolingFanCompartment"
        TargetTable =
         { Name = TableName "AppConfigCoolingFanCompartment"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfCoolingFans"
                         IsNullable = false }; ForeignKey { Type = Short
                                                            Name = "Fan1LoadId"
                                                            IsNullable = false };
             Primitive { Type = Short
                         Name = "Fan1SpeedGi"
                         IsNullable = false }; ForeignKey { Type = Short
                                                            Name = "Fan2LoadId"
                                                            IsNullable = false };
             Primitive { Type = Short
                         Name = "Fan2SpeedGi"
                         IsNullable = false };
             Navigation { Type = TableName "AppConfigCompartmentDetail"
                          Name = "AppConfigCompartmentDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "AppConfigCoolingFanCompartment"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "AppConfigOvenMwcompartment"
        TargetTable =
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
                         IsNullable = false };
             Primitive { Type = Byte
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
                         IsNullable = false };
             Primitive { Type = Byte
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
                         IsNullable = false };
             Primitive { Type = Byte
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
        Destination = EntityName "AppConfigOvenMwcompartment"
        IsNullable = true
        KeyType = Guid }] }-ApplianceConfigurationAppConfigCompartmentDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.ApplianceConfigurationAppConfigCompartmentDetails
                                    .Where(x => x.ApplianceConfigurationAppConfigCompartmentDetail != null && ids.Contains((Guid)x.ApplianceConfigurationAppConfigCompartmentDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.ApplianceConfigurationAppConfigCompartmentDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.ApplianceConfigurationAppConfigCompartmentDetails);
                    });
            
			
                Field<AppConfigCoolingFanCompartmentGraphType, AppConfigCoolingFanCompartment>("AppConfigCoolingFanCompartments")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, AppConfigCoolingFanCompartmentGraphType>(
                            "{ Name = EntityName "AppConfigCompartmentDetail"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "BackupRestore"
                                                       IsNullable = false };
         Navigation
           { Type = TableName "ApplianceConfigurationAppConfigCompartmentDetail"
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
  Fields =
   [{ Name = "AppConfigCompartmentDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Name"
                              Type = Primitive String
                              IsNullable = false }; { Name = "CompartmentType"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Description"
      Type = Primitive String
      IsNullable = false }; { Name = "Status"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Owner"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Timestamp"
      Type = Primitive DateTime
      IsNullable = false }; { Name = "RevisionGroup"
                              Type = Primitive Guid
                              IsNullable = false }; { Name = "Revision"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "TableTarget"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Notes"
                              Type = Primitive String
                              IsNullable = true }; { Name = "Version"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "HallEffectSensorPresent"
      Type = Primitive Bool
      IsNullable = false }; { Name = "BackupRestore"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "ApplianceConfigurationAppConfigCompartmentDetail"
        TargetTable =
         { Name = TableName "ApplianceConfigurationAppConfigCompartmentDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ApplianceConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "AppConfigCompartmentDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "AppConfigCompartmentDetail"
                          Name = "AppConfigCompartmentDetails"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ApplianceConfiguration"
                          Name = "ApplianceConfiguration"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "ApplianceConfigurationAppConfigCompartmentDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "AppConfigCoolingFanCompartment"
        TargetTable =
         { Name = TableName "AppConfigCoolingFanCompartment"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfCoolingFans"
                         IsNullable = false }; ForeignKey { Type = Short
                                                            Name = "Fan1LoadId"
                                                            IsNullable = false };
             Primitive { Type = Short
                         Name = "Fan1SpeedGi"
                         IsNullable = false }; ForeignKey { Type = Short
                                                            Name = "Fan2LoadId"
                                                            IsNullable = false };
             Primitive { Type = Short
                         Name = "Fan2SpeedGi"
                         IsNullable = false };
             Navigation { Type = TableName "AppConfigCompartmentDetail"
                          Name = "AppConfigCompartmentDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "AppConfigCoolingFanCompartment"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "AppConfigOvenMwcompartment"
        TargetTable =
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
                         IsNullable = false };
             Primitive { Type = Byte
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
                         IsNullable = false };
             Primitive { Type = Byte
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
                         IsNullable = false };
             Primitive { Type = Byte
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
        Destination = EntityName "AppConfigOvenMwcompartment"
        IsNullable = true
        KeyType = Guid }] }-AppConfigCoolingFanCompartment-loader",
                            async ids => 
                            {
                                var data = await dbContext.AppConfigCoolingFanCompartments
                                    .Where(x => x.AppConfigCoolingFanCompartment != null && ids.Contains((Guid)x.AppConfigCoolingFanCompartment))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.AppConfigCoolingFanCompartment!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.AppConfigCoolingFanCompartment);
                });
            
			
                Field<AppConfigOvenMwcompartmentGraphType, AppConfigOvenMwcompartment>("AppConfigOvenMwcompartments")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, AppConfigOvenMwcompartmentGraphType>(
                            "{ Name = EntityName "AppConfigCompartmentDetail"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "BackupRestore"
                                                       IsNullable = false };
         Navigation
           { Type = TableName "ApplianceConfigurationAppConfigCompartmentDetail"
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
  Fields =
   [{ Name = "AppConfigCompartmentDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Name"
                              Type = Primitive String
                              IsNullable = false }; { Name = "CompartmentType"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Description"
      Type = Primitive String
      IsNullable = false }; { Name = "Status"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Owner"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Timestamp"
      Type = Primitive DateTime
      IsNullable = false }; { Name = "RevisionGroup"
                              Type = Primitive Guid
                              IsNullable = false }; { Name = "Revision"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "TableTarget"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Notes"
                              Type = Primitive String
                              IsNullable = true }; { Name = "Version"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "HallEffectSensorPresent"
      Type = Primitive Bool
      IsNullable = false }; { Name = "BackupRestore"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "ApplianceConfigurationAppConfigCompartmentDetail"
        TargetTable =
         { Name = TableName "ApplianceConfigurationAppConfigCompartmentDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ApplianceConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "AppConfigCompartmentDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "AppConfigCompartmentDetail"
                          Name = "AppConfigCompartmentDetails"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ApplianceConfiguration"
                          Name = "ApplianceConfiguration"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "ApplianceConfigurationAppConfigCompartmentDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "AppConfigCoolingFanCompartment"
        TargetTable =
         { Name = TableName "AppConfigCoolingFanCompartment"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfCoolingFans"
                         IsNullable = false }; ForeignKey { Type = Short
                                                            Name = "Fan1LoadId"
                                                            IsNullable = false };
             Primitive { Type = Short
                         Name = "Fan1SpeedGi"
                         IsNullable = false }; ForeignKey { Type = Short
                                                            Name = "Fan2LoadId"
                                                            IsNullable = false };
             Primitive { Type = Short
                         Name = "Fan2SpeedGi"
                         IsNullable = false };
             Navigation { Type = TableName "AppConfigCompartmentDetail"
                          Name = "AppConfigCompartmentDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "AppConfigCoolingFanCompartment"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "AppConfigOvenMwcompartment"
        TargetTable =
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
                         IsNullable = false };
             Primitive { Type = Byte
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
                         IsNullable = false };
             Primitive { Type = Byte
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
                         IsNullable = false };
             Primitive { Type = Byte
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
        Destination = EntityName "AppConfigOvenMwcompartment"
        IsNullable = true
        KeyType = Guid }] }-AppConfigOvenMwcompartment-loader",
                            async ids => 
                            {
                                var data = await dbContext.AppConfigOvenMwcompartments
                                    .Where(x => x.AppConfigOvenMwcompartment != null && ids.Contains((Guid)x.AppConfigOvenMwcompartment))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.AppConfigOvenMwcompartment!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.AppConfigOvenMwcompartment);
                });
            
        }
    }
}
            