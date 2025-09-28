
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
    public partial class VisualBoardTypeGraphType : ObjectGraphType<VisualBoardType>
    {
        public VisualBoardTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.VisualBoardTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VisualBoardTypeDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Uimicro, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.UiselectorCompressionAllowed, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DynamicTimeToEnd, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.EcoPowerSave, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.WeightSensor, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.LongFill, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CompressionMethod1, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CompressionMethod2, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CompressionMethod3, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.UieepromSize, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HasVisualBoardTypeDisplacement, type: typeof(BoolGraphType), nullable: False);
			Field(t => t._128cyclesEnabled, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.AutoStart, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.TimeToEndTo512, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.SupportsBeforeFaultCycle, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OffStandByEnabled, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Supports7Fabrics, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OscillatingGroup, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SupportsWordCapacitiveTouchParamsFingerThresholds, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HasConnectivityPointers, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PerformCheckOnWaterLevels, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HasExtendedCycleSubHeading, type: typeof(BoolGraphType), nullable: False);
            
                Field<DisplayGraphType, Display>("Displays")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DisplayGraphType>>(
                            "{ Name = EntityName "VisualBoardType"
  CorrespondingTable =
   Regular
     { Name = TableName "VisualBoardType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "VisualBoardTypeId"
                      IsNullable = false };
         Primitive { Type = String
                     Name = "VisualBoardTypeDsc"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Uimicro"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "UiselectorCompressionAllowed"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "DynamicTimeToEnd"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "EcoPowerSave"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "WeightSensor"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "LongFill"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "CompressionMethod1"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "CompressionMethod2"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "CompressionMethod3"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "UieepromSize"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "HasVisualBoardTypeDisplacement"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "_128cyclesEnabled"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "AutoStart"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "TimeToEndTo512"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "SupportsBeforeFaultCycle"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "OffStandByEnabled"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Supports7Fabrics"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "OscillatingGroup"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "SupportsWordCapacitiveTouchParamsFingerThresholds"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "HasConnectivityPointers"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "PerformCheckOnWaterLevels"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "HasExtendedCycleSubHeading"
                     IsNullable = false };
         Navigation { Type = TableName "Display"
                      Name = "Displays"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "ProductType"
                      Name = "ProductTypes"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "VisualBoardTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "VisualBoardTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Uimicro"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "UiselectorCompressionAllowed"
      Type = Primitive Bool
      IsNullable = false }; { Name = "DynamicTimeToEnd"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "EcoPowerSave"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "WeightSensor"
      Type = Primitive Bool
      IsNullable = false }; { Name = "LongFill"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "CompressionMethod1"
      Type = Primitive Bool
      IsNullable = false }; { Name = "CompressionMethod2"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "CompressionMethod3"
      Type = Primitive Bool
      IsNullable = false }; { Name = "UieepromSize"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "HasVisualBoardTypeDisplacement"
      Type = Primitive Bool
      IsNullable = false }; { Name = "_128cyclesEnabled"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "AutoStart"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "TimeToEndTo512"
      Type = Primitive Bool
      IsNullable = false }; { Name = "SupportsBeforeFaultCycle"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "OffStandByEnabled"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Supports7Fabrics"
      Type = Primitive Bool
      IsNullable = false }; { Name = "OscillatingGroup"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "SupportsWordCapacitiveTouchParamsFingerThresholds"
      Type = Primitive Bool
      IsNullable = false }; { Name = "HasConnectivityPointers"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "PerformCheckOnWaterLevels"
      Type = Primitive Bool
      IsNullable = false }; { Name = "HasExtendedCycleSubHeading"
                              Type = Primitive Bool
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
    ManyToMany
      { Name = RelationName "ProductType"
        TargetTable =
         { Name = TableName "ProductType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ProductTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "ProductTypesHighStatement"
                          Name = "ProductTypesHighStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesTask"
                          Name = "ProductTypesTasks"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesVariable"
                          Name = "ProductTypesVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ProductType"
        KeyType = Byte }] }-Display-loader",
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
            
			
                Field<ProductTypeGraphType, ProductType>("ProductTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ProductTypeGraphType>(
                            "{ Name = EntityName "VisualBoardType"
  CorrespondingTable =
   Regular
     { Name = TableName "VisualBoardType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "VisualBoardTypeId"
                      IsNullable = false };
         Primitive { Type = String
                     Name = "VisualBoardTypeDsc"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Uimicro"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "UiselectorCompressionAllowed"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "DynamicTimeToEnd"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "EcoPowerSave"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "WeightSensor"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "LongFill"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "CompressionMethod1"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "CompressionMethod2"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "CompressionMethod3"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "UieepromSize"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "HasVisualBoardTypeDisplacement"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "_128cyclesEnabled"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "AutoStart"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "TimeToEndTo512"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "SupportsBeforeFaultCycle"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "OffStandByEnabled"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Supports7Fabrics"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "OscillatingGroup"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "SupportsWordCapacitiveTouchParamsFingerThresholds"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "HasConnectivityPointers"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "PerformCheckOnWaterLevels"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "HasExtendedCycleSubHeading"
                     IsNullable = false };
         Navigation { Type = TableName "Display"
                      Name = "Displays"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "ProductType"
                      Name = "ProductTypes"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "VisualBoardTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "VisualBoardTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Uimicro"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "UiselectorCompressionAllowed"
      Type = Primitive Bool
      IsNullable = false }; { Name = "DynamicTimeToEnd"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "EcoPowerSave"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "WeightSensor"
      Type = Primitive Bool
      IsNullable = false }; { Name = "LongFill"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "CompressionMethod1"
      Type = Primitive Bool
      IsNullable = false }; { Name = "CompressionMethod2"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "CompressionMethod3"
      Type = Primitive Bool
      IsNullable = false }; { Name = "UieepromSize"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "HasVisualBoardTypeDisplacement"
      Type = Primitive Bool
      IsNullable = false }; { Name = "_128cyclesEnabled"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "AutoStart"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "TimeToEndTo512"
      Type = Primitive Bool
      IsNullable = false }; { Name = "SupportsBeforeFaultCycle"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "OffStandByEnabled"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Supports7Fabrics"
      Type = Primitive Bool
      IsNullable = false }; { Name = "OscillatingGroup"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "SupportsWordCapacitiveTouchParamsFingerThresholds"
      Type = Primitive Bool
      IsNullable = false }; { Name = "HasConnectivityPointers"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "PerformCheckOnWaterLevels"
      Type = Primitive Bool
      IsNullable = false }; { Name = "HasExtendedCycleSubHeading"
                              Type = Primitive Bool
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
    ManyToMany
      { Name = RelationName "ProductType"
        TargetTable =
         { Name = TableName "ProductType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ProductTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "ProductTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "ProductTypesHighStatement"
                          Name = "ProductTypesHighStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesTask"
                          Name = "ProductTypesTasks"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ProductTypesVariable"
                          Name = "ProductTypesVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "StmSetVariable"
                          Name = "StmSetVariables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ProductType"
        KeyType = Byte }] }-ProductType-loader",
                            async ids => 
                            {
                                var data = await dbContext.ProductTypes
                                    .Where(x => x.ProductType.Any(c => ids.Contains(c.ProductTypeId)))
                                    .Select(x => new
                                    {
                                        Key = x,
                                        Values = x.ProductType,
                                    })
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => x.Values.Select(v => new { Key = v.ProductTypeId, Value = x.Key }))
                                    .ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.ProductTypes);
                    });
            
        }
    }
}
            