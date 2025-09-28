
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
    public partial class UitouchDeviceGraphType : ObjectGraphType<UitouchDevice>
    {
        public UitouchDeviceGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UitouchDevicesId, type: typeof(GuidGraphType), nullable: False);
            
                Field<DisplayGraphType, Display>("Displays")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DisplayGraphType>>(
                            "{ Name = EntityName "UitouchDevice"
  CorrespondingTable =
   Regular
     { Name = TableName "UitouchDevice"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UitouchDevicesId"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "UicypressTouchId"
                      IsNullable = true }; ForeignKey { Type = Guid
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
  Fields = [{ Name = "UitouchDevicesId"
              Type = Id Guid
              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "Display"
        TargetTable =
         { Name = TableName "Display"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DisplayId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Code"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
                                                           Name = "Timestamp"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "GenericInputConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "FunctionConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SequenceConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "VisualBoardTypeId"
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
             ForeignKey { Type = Guid
                          Name = "StatusVariablesId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiledGroupsConfigurationsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiaudioConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UianimationConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "HmiexpansionBoardConfigurationsId"
                          IsNullable = true }; ForeignKey { Type = Byte
                                                            Name = "BrandId"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UisreventConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiviewEngineControlStateConfigurationsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiviewEngineViewsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UidataModelTranslationConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UitouchDevicesId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UilowPowerTimeId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UidefaultPinConfigurationId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "ProductVariant"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NodeAddress"
                                                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "FaultF12timeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StandByTimeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "GoingToSleepTimeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StandByCommunicationTimeout"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "MainTimeToEnd"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "DebugPointerConfigurationsId"
                          IsNullable = true };
             Navigation { Type = TableName "Brand"
                          Name = "Brand"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebugPointerConfiguration"
                          Name = "DebugPointerConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "FunctionConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "GenericInputConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HmiexpansionBoardConfiguration"
                          Name = "HmiexpansionBoardConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "HmiexpansionBoardConfigurationsDisplay"
                 Name = "HmiexpansionBoardConfigurationsDisplays"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HmiAvailableNode"
                          Name = "NodeAddressNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingProductVariant"
                          Name = "ProductVariantNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "SequenceConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UianimationConfiguration"
                          Name = "UianimationConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiaudioConfiguration"
                          Name = "UiaudioConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UidataModelTranslationConfiguration"
                          Name = "UidataModelTranslationConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UidefaultPinConfiguration"
                          Name = "UidefaultPinConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiledGroupsConfiguration"
                          Name = "UiledGroupsConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UilowPowerTime"
                          Name = "UilowPowerTime"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UitouchDevice"
                          Name = "UitouchDevices"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "UiviewEngineControlStateConfiguration"
                 Name = "UiviewEngineControlStateConfigurations"
                 IsNullable = true
                 IsCollection = false };
             Navigation { Type = TableName "UiviewEngineViewsConfiguratio"
                          Name = "UiviewEngineViews"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Display"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UicypressTouchParameter"
        TargetTable =
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
                         Name = "NumDevices"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "CapsenseMethod"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DeviceI2cport0"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DeviceI2caddress0"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DeviceNumKeys0"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DeviceI2cport1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DeviceI2caddress1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DeviceNumKeys1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NumSensors"
                                                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "Lpmdevice"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StuckKeyTimeout"
                         IsNullable = false }; Primitive { Type = Byte
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
        Destination = EntityName "UicypressTouchParameter"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UitouchLean"
        TargetTable =
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
        Destination = EntityName "UitouchLean"
        IsNullable = true
        KeyType = Guid }] }-Display-loader",
                            async ids => 
                            {
                                var data = await dbContext.Displays
                                    .Where(x => x.Display != null && ids.Contains((Guid)x.Display))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Display!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.Displays);
                    });
            
			
                Field<UicypressTouchParameterGraphType, UicypressTouchParameter>("UicypressTouchParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UicypressTouchParameterGraphType>(
                            "{ Name = EntityName "UitouchDevice"
  CorrespondingTable =
   Regular
     { Name = TableName "UitouchDevice"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UitouchDevicesId"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "UicypressTouchId"
                      IsNullable = true }; ForeignKey { Type = Guid
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
  Fields = [{ Name = "UitouchDevicesId"
              Type = Id Guid
              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "Display"
        TargetTable =
         { Name = TableName "Display"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DisplayId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Code"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
                                                           Name = "Timestamp"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "GenericInputConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "FunctionConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SequenceConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "VisualBoardTypeId"
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
             ForeignKey { Type = Guid
                          Name = "StatusVariablesId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiledGroupsConfigurationsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiaudioConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UianimationConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "HmiexpansionBoardConfigurationsId"
                          IsNullable = true }; ForeignKey { Type = Byte
                                                            Name = "BrandId"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UisreventConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiviewEngineControlStateConfigurationsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiviewEngineViewsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UidataModelTranslationConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UitouchDevicesId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UilowPowerTimeId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UidefaultPinConfigurationId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "ProductVariant"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NodeAddress"
                                                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "FaultF12timeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StandByTimeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "GoingToSleepTimeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StandByCommunicationTimeout"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "MainTimeToEnd"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "DebugPointerConfigurationsId"
                          IsNullable = true };
             Navigation { Type = TableName "Brand"
                          Name = "Brand"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebugPointerConfiguration"
                          Name = "DebugPointerConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "FunctionConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "GenericInputConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HmiexpansionBoardConfiguration"
                          Name = "HmiexpansionBoardConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "HmiexpansionBoardConfigurationsDisplay"
                 Name = "HmiexpansionBoardConfigurationsDisplays"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HmiAvailableNode"
                          Name = "NodeAddressNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingProductVariant"
                          Name = "ProductVariantNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "SequenceConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UianimationConfiguration"
                          Name = "UianimationConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiaudioConfiguration"
                          Name = "UiaudioConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UidataModelTranslationConfiguration"
                          Name = "UidataModelTranslationConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UidefaultPinConfiguration"
                          Name = "UidefaultPinConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiledGroupsConfiguration"
                          Name = "UiledGroupsConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UilowPowerTime"
                          Name = "UilowPowerTime"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UitouchDevice"
                          Name = "UitouchDevices"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "UiviewEngineControlStateConfiguration"
                 Name = "UiviewEngineControlStateConfigurations"
                 IsNullable = true
                 IsCollection = false };
             Navigation { Type = TableName "UiviewEngineViewsConfiguratio"
                          Name = "UiviewEngineViews"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Display"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UicypressTouchParameter"
        TargetTable =
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
                         Name = "NumDevices"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "CapsenseMethod"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DeviceI2cport0"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DeviceI2caddress0"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DeviceNumKeys0"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DeviceI2cport1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DeviceI2caddress1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DeviceNumKeys1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NumSensors"
                                                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "Lpmdevice"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StuckKeyTimeout"
                         IsNullable = false }; Primitive { Type = Byte
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
        Destination = EntityName "UicypressTouchParameter"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UitouchLean"
        TargetTable =
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
        Destination = EntityName "UitouchLean"
        IsNullable = true
        KeyType = Guid }] }-UicypressTouchParameter-loader",
                            async ids => 
                            {
                                var data = await dbContext.UicypressTouchParameters
                                    .Where(x => x.UicypressTouchParameter != null && ids.Contains((Guid)x.UicypressTouchParameter))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UicypressTouchParameter!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UicypressTouchParameter);
                });
            
			
                Field<UitouchLeanGraphType, UitouchLean>("UitouchLeans")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UitouchLeanGraphType>(
                            "{ Name = EntityName "UitouchDevice"
  CorrespondingTable =
   Regular
     { Name = TableName "UitouchDevice"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UitouchDevicesId"
                      IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "UicypressTouchId"
                      IsNullable = true }; ForeignKey { Type = Guid
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
  Fields = [{ Name = "UitouchDevicesId"
              Type = Id Guid
              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "Display"
        TargetTable =
         { Name = TableName "Display"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DisplayId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Code"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
                                                           Name = "Timestamp"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "GenericInputConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "FunctionConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SequenceConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "VisualBoardTypeId"
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
             ForeignKey { Type = Guid
                          Name = "StatusVariablesId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiledGroupsConfigurationsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiaudioConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UianimationConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "HmiexpansionBoardConfigurationsId"
                          IsNullable = true }; ForeignKey { Type = Byte
                                                            Name = "BrandId"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UisreventConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiviewEngineControlStateConfigurationsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiviewEngineViewsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UidataModelTranslationConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UitouchDevicesId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UilowPowerTimeId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UidefaultPinConfigurationId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "ProductVariant"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NodeAddress"
                                                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "FaultF12timeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StandByTimeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "GoingToSleepTimeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StandByCommunicationTimeout"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "MainTimeToEnd"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "DebugPointerConfigurationsId"
                          IsNullable = true };
             Navigation { Type = TableName "Brand"
                          Name = "Brand"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebugPointerConfiguration"
                          Name = "DebugPointerConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "FunctionConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "GenericInputConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HmiexpansionBoardConfiguration"
                          Name = "HmiexpansionBoardConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "HmiexpansionBoardConfigurationsDisplay"
                 Name = "HmiexpansionBoardConfigurationsDisplays"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HmiAvailableNode"
                          Name = "NodeAddressNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingProductVariant"
                          Name = "ProductVariantNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "SequenceConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UianimationConfiguration"
                          Name = "UianimationConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiaudioConfiguration"
                          Name = "UiaudioConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UidataModelTranslationConfiguration"
                          Name = "UidataModelTranslationConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UidefaultPinConfiguration"
                          Name = "UidefaultPinConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiledGroupsConfiguration"
                          Name = "UiledGroupsConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UilowPowerTime"
                          Name = "UilowPowerTime"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UitouchDevice"
                          Name = "UitouchDevices"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "UiviewEngineControlStateConfiguration"
                 Name = "UiviewEngineControlStateConfigurations"
                 IsNullable = true
                 IsCollection = false };
             Navigation { Type = TableName "UiviewEngineViewsConfiguratio"
                          Name = "UiviewEngineViews"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Display"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UicypressTouchParameter"
        TargetTable =
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
                         Name = "NumDevices"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "CapsenseMethod"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DeviceI2cport0"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DeviceI2caddress0"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DeviceNumKeys0"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "DeviceI2cport1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DeviceI2caddress1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "DeviceNumKeys1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NumSensors"
                                                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "Lpmdevice"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StuckKeyTimeout"
                         IsNullable = false }; Primitive { Type = Byte
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
        Destination = EntityName "UicypressTouchParameter"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UitouchLean"
        TargetTable =
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
        Destination = EntityName "UitouchLean"
        IsNullable = true
        KeyType = Guid }] }-UitouchLean-loader",
                            async ids => 
                            {
                                var data = await dbContext.UitouchLeans
                                    .Where(x => x.UitouchLean != null && ids.Contains((Guid)x.UitouchLean))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UitouchLean!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UitouchLean);
                });
            
        }
    }
}
            