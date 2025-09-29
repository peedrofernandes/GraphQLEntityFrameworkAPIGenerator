using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class GeseCookingContext : DbContext
{
    public GeseCookingContext()
    {
    }

    public GeseCookingContext(DbContextOptions<GeseCookingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AcuexpansionBoardConfiguration> AcuexpansionBoardConfigurations { get; set; }

    public virtual DbSet<AcuexpansionBoardConfigurationsBoard> AcuexpansionBoardConfigurationsBoards { get; set; }

    public virtual DbSet<AppConfigCompartmentDetail> AppConfigCompartmentDetails { get; set; }

    public virtual DbSet<AppConfigCoolingFanCompartment> AppConfigCoolingFanCompartments { get; set; }

    public virtual DbSet<AppConfigMicrowaveCompartment> AppConfigMicrowaveCompartments { get; set; }

    public virtual DbSet<AppConfigOvenMwcompartment> AppConfigOvenMwcompartments { get; set; }

    public virtual DbSet<ApplianceConfiguration> ApplianceConfigurations { get; set; }

    public virtual DbSet<ApplianceConfigurationAppConfigCompartmentDetail> ApplianceConfigurationAppConfigCompartmentDetails { get; set; }

    public virtual DbSet<ApplicationLauncher> ApplicationLaunchers { get; set; }

    public virtual DbSet<AssistedCookingConfigDatum> AssistedCookingConfigData { get; set; }

    public virtual DbSet<Attribute> Attributes { get; set; }

    public virtual DbSet<AttributeType> AttributeTypes { get; set; }

    public virtual DbSet<AttributeValueEnumeration> AttributeValueEnumerations { get; set; }

    public virtual DbSet<Board> Boards { get; set; }

    public virtual DbSet<BoolOperator> BoolOperators { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<CodeBuilder> CodeBuilders { get; set; }

    public virtual DbSet<CodeBuilderContainer> CodeBuilderContainers { get; set; }

    public virtual DbSet<CodeBuilderContainersElement> CodeBuilderContainersElements { get; set; }

    public virtual DbSet<CodeBuildersCodeBuilderContainer> CodeBuildersCodeBuilderContainers { get; set; }

    public virtual DbSet<CoilModelId> CoilModelIds { get; set; }

    public virtual DbSet<CoilOperationConfigDatum> CoilOperationConfigData { get; set; }

    public virtual DbSet<CoilSpecificConfigDatum> CoilSpecificConfigData { get; set; }

    public virtual DbSet<CompartmentNamesAndLoadsView> CompartmentNamesAndLoadsViews { get; set; }

    public virtual DbSet<CompartmentType> CompartmentTypes { get; set; }

    public virtual DbSet<CompiledResourceMetaDatum> CompiledResourceMetaData { get; set; }

    public virtual DbSet<Condition> Conditions { get; set; }

    public virtual DbSet<ConditionBlock> ConditionBlocks { get; set; }

    public virtual DbSet<CrossLoadConfiguration> CrossLoadConfigurations { get; set; }

    public virtual DbSet<CrossLoadConfigurationsCrossLoadDetail> CrossLoadConfigurationsCrossLoadDetails { get; set; }

    public virtual DbSet<CrossLoadDetail> CrossLoadDetails { get; set; }

    public virtual DbSet<CrossLoadType> CrossLoadTypes { get; set; }

    public virtual DbSet<Cycle> Cycles { get; set; }

    public virtual DbSet<CycleBrowningDonenessGrouping> CycleBrowningDonenessGroupings { get; set; }

    public virtual DbSet<CycleBrowningDonenessTempType> CycleBrowningDonenessTempTypes { get; set; }

    public virtual DbSet<CycleBrowningDonenessTimeType> CycleBrowningDonenessTimeTypes { get; set; }

    public virtual DbSet<CycleGroup> CycleGroups { get; set; }

    public virtual DbSet<CycleHeading> CycleHeadings { get; set; }

    public virtual DbSet<CycleMapping> CycleMappings { get; set; }

    public virtual DbSet<CycleMappingAcuTarget> CycleMappingAcuTargets { get; set; }

    public virtual DbSet<CycleMappingCavityParam> CycleMappingCavityParams { get; set; }

    public virtual DbSet<CycleMappingCompartmentName> CycleMappingCompartmentNames { get; set; }

    public virtual DbSet<CycleMappingCycleOptionsConfiguration> CycleMappingCycleOptionsConfigurations { get; set; }

    public virtual DbSet<CycleMappingExportOption> CycleMappingExportOptions { get; set; }

    public virtual DbSet<CycleMappingFileInfo> CycleMappingFileInfos { get; set; }

    public virtual DbSet<CycleMappingFileInfoCycleMappingModelNumber> CycleMappingFileInfoCycleMappingModelNumbers { get; set; }

    public virtual DbSet<CycleMappingModelNumber> CycleMappingModelNumbers { get; set; }

    public virtual DbSet<CycleMappingProductVariant> CycleMappingProductVariants { get; set; }

    public virtual DbSet<CycleMappingSelector> CycleMappingSelectors { get; set; }

    public virtual DbSet<CycleMappingUri> CycleMappingUris { get; set; }

    public virtual DbSet<CycleMappingUriSelection> CycleMappingUriSelections { get; set; }

    public virtual DbSet<CycleName> CycleNames { get; set; }

    public virtual DbSet<CycleOptionsAmountUnit> CycleOptionsAmountUnits { get; set; }

    public virtual DbSet<CycleOptionsAssistedFormula> CycleOptionsAssistedFormulas { get; set; }

    public virtual DbSet<CycleOptionsAssistedFormulaInput> CycleOptionsAssistedFormulaInputs { get; set; }

    public virtual DbSet<CycleOptionsAssistedFormulaResultingAttribute> CycleOptionsAssistedFormulaResultingAttributes { get; set; }

    public virtual DbSet<CycleOptionsAtEndSelection> CycleOptionsAtEndSelections { get; set; }

    public virtual DbSet<CycleOptionsBrowning> CycleOptionsBrownings { get; set; }

    public virtual DbSet<CycleOptionsConfiguration> CycleOptionsConfigurations { get; set; }

    public virtual DbSet<CycleOptionsConfigurationsCycleOptionsDetail> CycleOptionsConfigurationsCycleOptionsDetails { get; set; }

    public virtual DbSet<CycleOptionsCookingTip> CycleOptionsCookingTips { get; set; }

    public virtual DbSet<CycleOptionsDetail> CycleOptionsDetails { get; set; }

    public virtual DbSet<CycleOptionsDetailsInput> CycleOptionsDetailsInputs { get; set; }

    public virtual DbSet<CycleOptionsDoneness> CycleOptionsDonenesses { get; set; }

    public virtual DbSet<CycleOptionsDonenessLevel> CycleOptionsDonenessLevels { get; set; }

    public virtual DbSet<CycleOptionsFoodTypeSelection> CycleOptionsFoodTypeSelections { get; set; }

    public virtual DbSet<CycleOptionsFullView> CycleOptionsFullViews { get; set; }

    public virtual DbSet<CycleOptionsMwoPowerLvlType> CycleOptionsMwoPowerLvlTypes { get; set; }

    public virtual DbSet<CycleOptionsPanSizeSelection> CycleOptionsPanSizeSelections { get; set; }

    public virtual DbSet<CycleOptionsPreheatSelection> CycleOptionsPreheatSelections { get; set; }

    public virtual DbSet<CycleOptionsPrmAmount> CycleOptionsPrmAmounts { get; set; }

    public virtual DbSet<CycleOptionsPrmAmountDiscrete> CycleOptionsPrmAmountDiscretes { get; set; }

    public virtual DbSet<CycleOptionsPrmAtEnd> CycleOptionsPrmAtEnds { get; set; }

    public virtual DbSet<CycleOptionsPrmBrowningDoneness> CycleOptionsPrmBrowningDonenesses { get; set; }

    public virtual DbSet<CycleOptionsPrmConvectConvert> CycleOptionsPrmConvectConverts { get; set; }

    public virtual DbSet<CycleOptionsPrmDelay> CycleOptionsPrmDelays { get; set; }

    public virtual DbSet<CycleOptionsPrmFoodType> CycleOptionsPrmFoodTypes { get; set; }

    public virtual DbSet<CycleOptionsPrmFormula> CycleOptionsPrmFormulas { get; set; }

    public virtual DbSet<CycleOptionsPrmFrozenBake> CycleOptionsPrmFrozenBakes { get; set; }

    public virtual DbSet<CycleOptionsPrmMaxStartTemperature> CycleOptionsPrmMaxStartTemperatures { get; set; }

    public virtual DbSet<CycleOptionsPrmMeatProbeTemperature> CycleOptionsPrmMeatProbeTemperatures { get; set; }

    public virtual DbSet<CycleOptionsPrmMwoPowerLevel> CycleOptionsPrmMwoPowerLevels { get; set; }

    public virtual DbSet<CycleOptionsPrmPanSize> CycleOptionsPrmPanSizes { get; set; }

    public virtual DbSet<CycleOptionsPrmPreheat> CycleOptionsPrmPreheats { get; set; }

    public virtual DbSet<CycleOptionsPrmPyro> CycleOptionsPrmPyros { get; set; }

    public virtual DbSet<CycleOptionsPrmSize> CycleOptionsPrmSizes { get; set; }

    public virtual DbSet<CycleOptionsPrmStepsConfiguration> CycleOptionsPrmStepsConfigurations { get; set; }

    public virtual DbSet<CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail> CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails { get; set; }

    public virtual DbSet<CycleOptionsPrmTemperature> CycleOptionsPrmTemperatures { get; set; }

    public virtual DbSet<CycleOptionsPrmTime> CycleOptionsPrmTimes { get; set; }

    public virtual DbSet<CycleOptionsPrmTip> CycleOptionsPrmTips { get; set; }

    public virtual DbSet<CycleOptionsPrmWeight> CycleOptionsPrmWeights { get; set; }

    public virtual DbSet<CycleOptionsPrmWeightRange> CycleOptionsPrmWeightRanges { get; set; }

    public virtual DbSet<CycleOptionsStepDetail> CycleOptionsStepDetails { get; set; }

    public virtual DbSet<CycleOptionsStepTableType> CycleOptionsStepTableTypes { get; set; }

    public virtual DbSet<CycleOptionsStepUserInstruction> CycleOptionsStepUserInstructions { get; set; }

    public virtual DbSet<CycleOptionsTemperatureUnit> CycleOptionsTemperatureUnits { get; set; }

    public virtual DbSet<CycleOptionsTimeUnit> CycleOptionsTimeUnits { get; set; }

    public virtual DbSet<CycleOptionsType> CycleOptionsTypes { get; set; }

    public virtual DbSet<CycleSubHeading> CycleSubHeadings { get; set; }

    public virtual DbSet<CycleTemperatureOptionsBehaviorLabel> CycleTemperatureOptionsBehaviorLabels { get; set; }

    public virtual DbSet<CycleTimeOptionsDisplayBehaviorLabel> CycleTimeOptionsDisplayBehaviorLabels { get; set; }

    public virtual DbSet<CycleTimeOptionsSelectionBehaviorLabel> CycleTimeOptionsSelectionBehaviorLabels { get; set; }

    public virtual DbSet<CycleType> CycleTypes { get; set; }

    public virtual DbSet<CyclesMacro> CyclesMacros { get; set; }

    public virtual DbSet<CyclesToStatement> CyclesToStatements { get; set; }

    public virtual DbSet<CypressTouchCapsenseMethod> CypressTouchCapsenseMethods { get; set; }

    public virtual DbSet<DataModelCategoryType> DataModelCategoryTypes { get; set; }

    public virtual DbSet<DataModelDefinitionConfiguration> DataModelDefinitionConfigurations { get; set; }

    public virtual DbSet<DataModelDefinitionConfigurationsDataModelDefinitionDetail> DataModelDefinitionConfigurationsDataModelDefinitionDetails { get; set; }

    public virtual DbSet<DataModelDefinitionDetail> DataModelDefinitionDetails { get; set; }

    public virtual DbSet<DataModelDefinitionView> DataModelDefinitionViews { get; set; }

    public virtual DbSet<DataModelEnumerationDefinition> DataModelEnumerationDefinitions { get; set; }

    public virtual DbSet<DataModelNamespaceType> DataModelNamespaceTypes { get; set; }

    public virtual DbSet<DataModelSubType> DataModelSubTypes { get; set; }

    public virtual DbSet<DataModelType> DataModelTypes { get; set; }

    public virtual DbSet<DataModelVersionType> DataModelVersionTypes { get; set; }

    public virtual DbSet<DebounceMethod> DebounceMethods { get; set; }

    public virtual DbSet<DebounceMethodParameter> DebounceMethodParameters { get; set; }

    public virtual DbSet<DebounceMethodPrescalar> DebounceMethodPrescalars { get; set; }

    public virtual DbSet<DebugDataDetail> DebugDataDetails { get; set; }

    public virtual DbSet<DebugDisplacementConfiguration> DebugDisplacementConfigurations { get; set; }

    public virtual DbSet<DebugDisplacementConfigurationsDebugDataDetail> DebugDisplacementConfigurationsDebugDataDetails { get; set; }

    public virtual DbSet<DebugPointerConfiguration> DebugPointerConfigurations { get; set; }

    public virtual DbSet<DebugPointerConfigurationsDebugDisplacementConfiguration> DebugPointerConfigurationsDebugDisplacementConfigurations { get; set; }

    public virtual DbSet<DebugPointerDataType> DebugPointerDataTypes { get; set; }

    public virtual DbSet<DefaultGpioPinType> DefaultGpioPinTypes { get; set; }

    public virtual DbSet<DefaultPinConfiguration> DefaultPinConfigurations { get; set; }

    public virtual DbSet<DefaultPinConfigurationsDefaultPinDetail> DefaultPinConfigurationsDefaultPinDetails { get; set; }

    public virtual DbSet<DefaultPinDetail> DefaultPinDetails { get; set; }

    public virtual DbSet<DeprecatedMonitorWaterLevelThreshold> DeprecatedMonitorWaterLevelThresholds { get; set; }

    public virtual DbSet<DescaleDetectionMethod> DescaleDetectionMethods { get; set; }

    public virtual DbSet<Display> Displays { get; set; }

    public virtual DbSet<DualZoneRole> DualZoneRoles { get; set; }

    public virtual DbSet<EepromCycleHeadingsExtendedView> EepromCycleHeadingsExtendedViews { get; set; }

    public virtual DbSet<EepromCycleHeadingsView> EepromCycleHeadingsViews { get; set; }

    public virtual DbSet<EepromCycleMappingView> EepromCycleMappingViews { get; set; }

    public virtual DbSet<EepromCycleMappingViewV2> EepromCycleMappingViewV2s { get; set; }

    public virtual DbSet<EepromCyclesView> EepromCyclesViews { get; set; }

    public virtual DbSet<EepromDelayStateCycleView> EepromDelayStateCycleViews { get; set; }

    public virtual DbSet<EepromDelayStateUicycleView> EepromDelayStateUicycleViews { get; set; }

    public virtual DbSet<EepromDelayUiselectorView> EepromDelayUiselectorViews { get; set; }

    public virtual DbSet<EepromEndStateCycleView> EepromEndStateCycleViews { get; set; }

    public virtual DbSet<EepromEndStateUicycleView> EepromEndStateUicycleViews { get; set; }

    public virtual DbSet<EepromEndUiselectorView> EepromEndUiselectorViews { get; set; }

    public virtual DbSet<EepromExpansionGenericInputConfigurationView> EepromExpansionGenericInputConfigurationViews { get; set; }

    public virtual DbSet<EepromExpansionLoadConfigurationView> EepromExpansionLoadConfigurationViews { get; set; }

    public virtual DbSet<EepromExpansionLowLevelInputConfigurationView> EepromExpansionLowLevelInputConfigurationViews { get; set; }

    public virtual DbSet<EepromExpansionUigenericInputConfigurationView> EepromExpansionUigenericInputConfigurationViews { get; set; }

    public virtual DbSet<EepromExpansionUilowLevelInputConfigurationView> EepromExpansionUilowLevelInputConfigurationViews { get; set; }

    public virtual DbSet<EepromExpansionUisequenceConfigurationSupportView> EepromExpansionUisequenceConfigurationSupportViews { get; set; }

    public virtual DbSet<EepromExpansionUisequenceConfigurationView> EepromExpansionUisequenceConfigurationViews { get; set; }

    public virtual DbSet<EepromFaultSelectorView> EepromFaultSelectorViews { get; set; }

    public virtual DbSet<EepromGenericInputConfigurationView> EepromGenericInputConfigurationViews { get; set; }

    public virtual DbSet<EepromLoadConfigurationView> EepromLoadConfigurationViews { get; set; }

    public virtual DbSet<EepromLowLevelInputConfigurationView> EepromLowLevelInputConfigurationViews { get; set; }

    public virtual DbSet<EepromMainSelectorView> EepromMainSelectorViews { get; set; }

    public virtual DbSet<EepromOffselectorView> EepromOffselectorViews { get; set; }

    public virtual DbSet<EepromOffuiselectorView> EepromOffuiselectorViews { get; set; }

    public virtual DbSet<EepromPauseStateCycleView> EepromPauseStateCycleViews { get; set; }

    public virtual DbSet<EepromPauseStateUicycleView> EepromPauseStateUicycleViews { get; set; }

    public virtual DbSet<EepromPauseUiselectorView> EepromPauseUiselectorViews { get; set; }

    public virtual DbSet<EepromProgrammingStateCycleView> EepromProgrammingStateCycleViews { get; set; }

    public virtual DbSet<EepromProgrammingStateUicycleView> EepromProgrammingStateUicycleViews { get; set; }

    public virtual DbSet<EepromProgrammingUiselectorView> EepromProgrammingUiselectorViews { get; set; }

    public virtual DbSet<EepromSortedFaulIdlistView> EepromSortedFaulIdlistViews { get; set; }

    public virtual DbSet<EepromStateSelectorView> EepromStateSelectorViews { get; set; }

    public virtual DbSet<EepromStateUiselectorView> EepromStateUiselectorViews { get; set; }

    public virtual DbSet<EepromStatusVariableView> EepromStatusVariableViews { get; set; }

    public virtual DbSet<EepromTimeEstimationDetailsView> EepromTimeEstimationDetailsViews { get; set; }

    public virtual DbSet<EepromUicycleSelectorView> EepromUicycleSelectorViews { get; set; }

    public virtual DbSet<EepromUifunctionConfigurationView> EepromUifunctionConfigurationViews { get; set; }

    public virtual DbSet<EepromUigenericInputConfigurationView> EepromUigenericInputConfigurationViews { get; set; }

    public virtual DbSet<EepromUiglobalSelectorView> EepromUiglobalSelectorViews { get; set; }

    public virtual DbSet<EepromUilowLevelInputConfigurationView> EepromUilowLevelInputConfigurationViews { get; set; }

    public virtual DbSet<EepromUiproductConfigurationFaultCodesView> EepromUiproductConfigurationFaultCodesViews { get; set; }

    public virtual DbSet<EepromUiselectorView> EepromUiselectorViews { get; set; }

    public virtual DbSet<EepromUisequenceConfigurationSupportView> EepromUisequenceConfigurationSupportViews { get; set; }

    public virtual DbSet<EepromUisequenceConfigurationView> EepromUisequenceConfigurationViews { get; set; }

    public virtual DbSet<EepromUiuserFunctionConfigurationView> EepromUiuserFunctionConfigurationViews { get; set; }

    public virtual DbSet<EmptyPotDetectionCoilConfig> EmptyPotDetectionCoilConfigs { get; set; }

    public virtual DbSet<EmptyPotDetectionCoilSafetyParam> EmptyPotDetectionCoilSafetyParams { get; set; }

    public virtual DbSet<EmptyPotDetectionConfig> EmptyPotDetectionConfigs { get; set; }

    public virtual DbSet<ExpansionBoard> ExpansionBoards { get; set; }

    public virtual DbSet<Factory> Factories { get; set; }

    public virtual DbSet<FanType> FanTypes { get; set; }

    public virtual DbSet<Fault> Faults { get; set; }

    public virtual DbSet<FaultCode> FaultCodes { get; set; }

    public virtual DbSet<FaultConfiguration> FaultConfigurations { get; set; }

    public virtual DbSet<FaultConfigurationsFaultDetail> FaultConfigurationsFaultDetails { get; set; }

    public virtual DbSet<FaultDetail> FaultDetails { get; set; }

    public virtual DbSet<FaultPrmFanOverSpeedFailure> FaultPrmFanOverSpeedFailures { get; set; }

    public virtual DbSet<FaultPrmFanStalledFailure> FaultPrmFanStalledFailures { get; set; }

    public virtual DbSet<FaultPrmMeatProbeFailure> FaultPrmMeatProbeFailures { get; set; }

    public virtual DbSet<FaultPrmOverTemperatureFailure> FaultPrmOverTemperatureFailures { get; set; }

    public virtual DbSet<FaultPrmRelayLoadFailure> FaultPrmRelayLoadFailures { get; set; }

    public virtual DbSet<FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition> FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditions { get; set; }

    public virtual DbSet<FaultPrmTemperatureOpenShortFailure> FaultPrmTemperatureOpenShortFailures { get; set; }

    public virtual DbSet<FaultPrmTemperatureSensorOpenedFailure> FaultPrmTemperatureSensorOpenedFailures { get; set; }

    public virtual DbSet<FaultRelayLoadFailureFaultCondition> FaultRelayLoadFailureFaultConditions { get; set; }

    public virtual DbSet<FaultSubCode> FaultSubCodes { get; set; }

    public virtual DbSet<FeedbackParameter> FeedbackParameters { get; set; }

    public virtual DbSet<FkView> FkViews { get; set; }

    public virtual DbSet<Flag> Flags { get; set; }

    public virtual DbSet<Function> Functions { get; set; }

    public virtual DbSet<FunctionLabel> FunctionLabels { get; set; }

    public virtual DbSet<GenericInputConfiguration> GenericInputConfigurations { get; set; }

    public virtual DbSet<GenericInputConfigurationsGenericInputDetail> GenericInputConfigurationsGenericInputDetails { get; set; }

    public virtual DbSet<GenericInputDetail> GenericInputDetails { get; set; }

    public virtual DbSet<GiphaseTrigger> GiphaseTriggers { get; set; }

    public virtual DbSet<GisearchMethodType> GisearchMethodTypes { get; set; }

    public virtual DbSet<HeatConvectionFanParameter> HeatConvectionFanParameters { get; set; }

    public virtual DbSet<HeatInitialize> HeatInitializes { get; set; }

    public virtual DbSet<HeatLoadBalancingClosedLoop> HeatLoadBalancingClosedLoops { get; set; }

    public virtual DbSet<HeatLoadBalancingOpenLoop> HeatLoadBalancingOpenLoops { get; set; }

    public virtual DbSet<HeatLoadBalancingParameter> HeatLoadBalancingParameters { get; set; }

    public virtual DbSet<HeatPidConfigurationParameter> HeatPidConfigurationParameters { get; set; }

    public virtual DbSet<HighStatement> HighStatements { get; set; }

    public virtual DbSet<HmiAvailableNode> HmiAvailableNodes { get; set; }

    public virtual DbSet<HmiexpansionBoardConfiguration> HmiexpansionBoardConfigurations { get; set; }

    public virtual DbSet<HmiexpansionBoardConfigurationsDisplay> HmiexpansionBoardConfigurationsDisplays { get; set; }

    public virtual DbSet<I2cspeedValue> I2cspeedValues { get; set; }

    public virtual DbSet<InductionCoilChannel> InductionCoilChannels { get; set; }

    public virtual DbSet<InductionCoilConfig> InductionCoilConfigs { get; set; }

    public virtual DbSet<InductionCoilInformationView> InductionCoilInformationViews { get; set; }

    public virtual DbSet<InductionCoilNtcspecific> InductionCoilNtcspecifics { get; set; }

    public virtual DbSet<InductionCoilPowerTableConfiguration> InductionCoilPowerTableConfigurations { get; set; }

    public virtual DbSet<InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail> InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails { get; set; }

    public virtual DbSet<InductionCoilPowerTableDetail> InductionCoilPowerTableDetails { get; set; }

    public virtual DbSet<InductionCoilSpecific> InductionCoilSpecifics { get; set; }

    public virtual DbSet<InductionCoilSripcsafety> InductionCoilSripcsafeties { get; set; }

    public virtual DbSet<InductionCoilType> InductionCoilTypes { get; set; }

    public virtual DbSet<InductionCooktopOrgConfiguration> InductionCooktopOrgConfigurations { get; set; }

    public virtual DbSet<InductionCooktopOrgConfigurationsInductionIpcdetail> InductionCooktopOrgConfigurationsInductionIpcdetails { get; set; }

    public virtual DbSet<InductionInverterChannelConfiguration> InductionInverterChannelConfigurations { get; set; }

    public virtual DbSet<InductionInverterSpecificDatum> InductionInverterSpecificData { get; set; }

    public virtual DbSet<InductionIpcSpecificDatum> InductionIpcSpecificData { get; set; }

    public virtual DbSet<InductionIpcdetail> InductionIpcdetails { get; set; }

    public virtual DbSet<InductionIpcdetailsInductionCoilConfig> InductionIpcdetailsInductionCoilConfigs { get; set; }

    public virtual DbSet<InductionIsofrequencyConfiguration> InductionIsofrequencyConfigurations { get; set; }

    public virtual DbSet<InductionIsofrequencyConfigurationsInductionIsofrequencyDetail> InductionIsofrequencyConfigurationsInductionIsofrequencyDetails { get; set; }

    public virtual DbSet<InductionIsofrequencyDetail> InductionIsofrequencyDetails { get; set; }

    public virtual DbSet<InductionThermalNodeConfiguration> InductionThermalNodeConfigurations { get; set; }

    public virtual DbSet<InductionZeroCrossConfiguration> InductionZeroCrossConfigurations { get; set; }

    public virtual DbSet<Input> Inputs { get; set; }

    public virtual DbSet<InputGroup> InputGroups { get; set; }

    public virtual DbSet<InputToInputGroupView> InputToInputGroupViews { get; set; }

    public virtual DbSet<InputType> InputTypes { get; set; }

    public virtual DbSet<InputTypesReadType> InputTypesReadTypes { get; set; }

    public virtual DbSet<InverterConfigDatum> InverterConfigData { get; set; }

    public virtual DbSet<InverterTechnology> InverterTechnologies { get; set; }

    public virtual DbSet<IpcControllerCoilConfiguration> IpcControllerCoilConfigurations { get; set; }

    public virtual DbSet<IpcControllerCoilConfigurationsIpcControllerCoilDetail> IpcControllerCoilConfigurationsIpcControllerCoilDetails { get; set; }

    public virtual DbSet<IpcControllerCoilDetail> IpcControllerCoilDetails { get; set; }

    public virtual DbSet<IpcControllerConfiguration> IpcControllerConfigurations { get; set; }

    public virtual DbSet<IpcControllerConfigurationsIpcControllerIpcConfiguration> IpcControllerConfigurationsIpcControllerIpcConfigurations { get; set; }

    public virtual DbSet<IpcControllerIpcConfiguration> IpcControllerIpcConfigurations { get; set; }

    public virtual DbSet<IpcControllerIpcConfigurationsIpcControllerCoilConfiguration> IpcControllerIpcConfigurationsIpcControllerCoilConfigurations { get; set; }

    public virtual DbSet<IpcFanConfigDatum> IpcFanConfigData { get; set; }

    public virtual DbSet<IpcSpecificSafetyParam> IpcSpecificSafetyParams { get; set; }

    public virtual DbSet<JumpIfPredictionBehavior> JumpIfPredictionBehaviors { get; set; }

    public virtual DbSet<LatchLslType> LatchLslTypes { get; set; }

    public virtual DbSet<LightDriverType> LightDriverTypes { get; set; }

    public virtual DbSet<Load> Loads { get; set; }

    public virtual DbSet<LoadAlias> LoadAliases { get; set; }

    public virtual DbSet<LoadConfiguration> LoadConfigurations { get; set; }

    public virtual DbSet<LoadConfigurationsLoadDetail> LoadConfigurationsLoadDetails { get; set; }

    public virtual DbSet<LoadDetail> LoadDetails { get; set; }

    public virtual DbSet<LoadGroup> LoadGroups { get; set; }

    public virtual DbSet<LoadToLoadGroupView> LoadToLoadGroupViews { get; set; }

    public virtual DbSet<LoadType> LoadTypes { get; set; }

    public virtual DbSet<LoadsControlActivateOption> LoadsControlActivateOptions { get; set; }

    public virtual DbSet<LoadsControlPilotParameter> LoadsControlPilotParameters { get; set; }

    public virtual DbSet<LowLevelInputConfiguration> LowLevelInputConfigurations { get; set; }

    public virtual DbSet<LowLevelInputConfigurationsLowLevelInputDetail> LowLevelInputConfigurationsLowLevelInputDetails { get; set; }

    public virtual DbSet<LowLevelInputDetail> LowLevelInputDetails { get; set; }

    public virtual DbSet<LowMediumHigh> LowMediumHighs { get; set; }

    public virtual DbSet<MachineConfigTableAttribute> MachineConfigTableAttributes { get; set; }

    public virtual DbSet<MachineConfiguration> MachineConfigurations { get; set; }

    public virtual DbSet<Macro> Macros { get; set; }

    public virtual DbSet<MacrosStatement> MacrosStatements { get; set; }

    public virtual DbSet<MainsLineConfigDatum> MainsLineConfigData { get; set; }

    public virtual DbSet<MicrowaveCookingMode> MicrowaveCookingModes { get; set; }

    public virtual DbSet<MicrowavePowerTableConfiguration> MicrowavePowerTableConfigurations { get; set; }

    public virtual DbSet<MicrowavePowerTableConfigurationsMicrowavePowerTableDetail> MicrowavePowerTableConfigurationsMicrowavePowerTableDetails { get; set; }

    public virtual DbSet<MicrowavePowerTableDetail> MicrowavePowerTableDetails { get; set; }

    public virtual DbSet<MicrowavePowerTableView> MicrowavePowerTableViews { get; set; }

    public virtual DbSet<MicrowavePowerType> MicrowavePowerTypes { get; set; }

    public virtual DbSet<MinimumDcSupply> MinimumDcSupplies { get; set; }

    public virtual DbSet<Modifier> Modifiers { get; set; }

    public virtual DbSet<ModifierOperator> ModifierOperators { get; set; }

    public virtual DbSet<ModifierOverallOperation> ModifierOverallOperations { get; set; }

    public virtual DbSet<ModifierSearchMethod> ModifierSearchMethods { get; set; }

    public virtual DbSet<ModifierType> ModifierTypes { get; set; }

    public virtual DbSet<ModifiersDetail> ModifiersDetails { get; set; }

    public virtual DbSet<MonitorAutoResume> MonitorAutoResumes { get; set; }

    public virtual DbSet<MonitorCoil> MonitorCoils { get; set; }

    public virtual DbSet<MonitorCoilDeratingConfiguration> MonitorCoilDeratingConfigurations { get; set; }

    public virtual DbSet<MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail> MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetails { get; set; }

    public virtual DbSet<MonitorCoilDeratingDetail> MonitorCoilDeratingDetails { get; set; }

    public virtual DbSet<MonitorDlbConfiguration> MonitorDlbConfigurations { get; set; }

    public virtual DbSet<MonitorGfci> MonitorGfcis { get; set; }

    public virtual DbSet<MonitorGfciV2> MonitorGfciV2s { get; set; }

    public virtual DbSet<MonitorHeatSinkFan> MonitorHeatSinkFans { get; set; }

    public virtual DbSet<MonitorHeatSinkFanTemperature> MonitorHeatSinkFanTemperatures { get; set; }

    public virtual DbSet<MonitorHoodFan> MonitorHoodFans { get; set; }

    public virtual DbSet<MonitorIrshutter> MonitorIrshutters { get; set; }

    public virtual DbSet<MonitorIrshutterTempSource> MonitorIrshutterTempSources { get; set; }

    public virtual DbSet<MonitorIrtemperature> MonitorIrtemperatures { get; set; }

    public virtual DbSet<MonitorLatchControl> MonitorLatchControls { get; set; }

    public virtual DbSet<MonitorLight> MonitorLights { get; set; }

    public virtual DbSet<MonitorMultiPointProbe> MonitorMultiPointProbes { get; set; }

    public virtual DbSet<MonitorPowerDetect> MonitorPowerDetects { get; set; }

    public virtual DbSet<MonitorPowerReduction> MonitorPowerReductions { get; set; }

    public virtual DbSet<MonitorPowerReductionV2configuration> MonitorPowerReductionV2configurations { get; set; }

    public virtual DbSet<MonitorPowerReductionV2configurationMonitorPowerReductionV2detail> MonitorPowerReductionV2configurationMonitorPowerReductionV2details { get; set; }

    public virtual DbSet<MonitorPowerReductionV2detail> MonitorPowerReductionV2details { get; set; }

    public virtual DbSet<MonitorPowerReductionV2estimatedTempConfiguration> MonitorPowerReductionV2estimatedTempConfigurations { get; set; }

    public virtual DbSet<MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail> MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails { get; set; }

    public virtual DbSet<MonitorPowerReductionV2estimatedTempDetail> MonitorPowerReductionV2estimatedTempDetails { get; set; }

    public virtual DbSet<MonitorPowerReductionV2powerRedConfiguration> MonitorPowerReductionV2powerRedConfigurations { get; set; }

    public virtual DbSet<MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail> MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails { get; set; }

    public virtual DbSet<MonitorPowerReductionV2powerRedDetail> MonitorPowerReductionV2powerRedDetails { get; set; }

    public virtual DbSet<MonitorSteam> MonitorSteams { get; set; }

    public virtual DbSet<MonitorSteamDescale> MonitorSteamDescales { get; set; }

    public virtual DbSet<MonitorSteamDrain> MonitorSteamDrains { get; set; }

    public virtual DbSet<MonitorSteamHumidityTargetMapping> MonitorSteamHumidityTargetMappings { get; set; }

    public virtual DbSet<MonitorSteamParam> MonitorSteamParams { get; set; }

    public virtual DbSet<MonitorSteamWaterLevelSensor> MonitorSteamWaterLevelSensors { get; set; }

    public virtual DbSet<MonitorSteamerParam> MonitorSteamerParams { get; set; }

    public virtual DbSet<MonitorVent> MonitorVents { get; set; }

    public virtual DbSet<MonitorWarmingZone> MonitorWarmingZones { get; set; }

    public virtual DbSet<MultiDriverPilotType> MultiDriverPilotTypes { get; set; }

    public virtual DbSet<MultiInputReadType> MultiInputReadTypes { get; set; }

    public virtual DbSet<MultiSequencePilotType> MultiSequencePilotTypes { get; set; }

    public virtual DbSet<OffPositionDetectionMethod> OffPositionDetectionMethods { get; set; }

    public virtual DbSet<OnPositionDetectionMethod> OnPositionDetectionMethods { get; set; }

    public virtual DbSet<OpCode> OpCodes { get; set; }

    public virtual DbSet<OpenDoorHeatingCyclesConfiguration> OpenDoorHeatingCyclesConfigurations { get; set; }

    public virtual DbSet<OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail> OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails { get; set; }

    public virtual DbSet<OpenDoorHeatingCyclesDetail> OpenDoorHeatingCyclesDetails { get; set; }

    public virtual DbSet<Operator> Operators { get; set; }

    public virtual DbSet<PartialControlOption> PartialControlOptions { get; set; }

    public virtual DbSet<PartializedPilotActivationEdge> PartializedPilotActivationEdges { get; set; }

    public virtual DbSet<PhaseName> PhaseNames { get; set; }

    public virtual DbSet<PilotGeneralizedProfile> PilotGeneralizedProfiles { get; set; }

    public virtual DbSet<PilotMultiSequenceConfig> PilotMultiSequenceConfigs { get; set; }

    public virtual DbSet<PilotMultiSequenceConfigDetail> PilotMultiSequenceConfigDetails { get; set; }

    public virtual DbSet<PilotMultiSequenceDetail> PilotMultiSequenceDetails { get; set; }

    public virtual DbSet<PilotMultiSequenceDetailsStep> PilotMultiSequenceDetailsSteps { get; set; }

    public virtual DbSet<PilotMultiSequenceStep> PilotMultiSequenceSteps { get; set; }

    public virtual DbSet<PilotType> PilotTypes { get; set; }

    public virtual DbSet<PowerDeliveryConfigDatum> PowerDeliveryConfigData { get; set; }

    public virtual DbSet<PowerReductionTimerConfiguration> PowerReductionTimerConfigurations { get; set; }

    public virtual DbSet<PrmGianalogToTemperature> PrmGianalogToTemperatures { get; set; }

    public virtual DbSet<PrmGianyLliToConvert> PrmGianyLliToConverts { get; set; }

    public virtual DbSet<PrmGianyLliToFeedback> PrmGianyLliToFeedbacks { get; set; }

    public virtual DbSet<PrmGianyLliToPhase> PrmGianyLliToPhases { get; set; }

    public virtual DbSet<PrmGianyLliToSwitch> PrmGianyLliToSwitches { get; set; }

    public virtual DbSet<PrmGii2cinfraredToIrtemperature> PrmGii2cinfraredToIrtemperatures { get; set; }

    public virtual DbSet<PrmGiinputCaptureToSpeed> PrmGiinputCaptureToSpeeds { get; set; }

    public virtual DbSet<PrmLoadFanConfiguration> PrmLoadFanConfigurations { get; set; }

    public virtual DbSet<PrmLoadFanConfigurationPrmLoadFanDetail> PrmLoadFanConfigurationPrmLoadFanDetails { get; set; }

    public virtual DbSet<PrmLoadFanDetail> PrmLoadFanDetails { get; set; }

    public virtual DbSet<PrmPilotAnalog> PrmPilotAnalogs { get; set; }

    public virtual DbSet<PrmPilotConstantPwm> PrmPilotConstantPwms { get; set; }

    public virtual DbSet<PrmPilotExpansion> PrmPilotExpansions { get; set; }

    public virtual DbSet<PrmPilotImpulsive> PrmPilotImpulsives { get; set; }

    public virtual DbSet<PrmPilotMagnetron> PrmPilotMagnetrons { get; set; }

    public virtual DbSet<PrmPilotMultiDriver> PrmPilotMultiDrivers { get; set; }

    public virtual DbSet<PrmPilotMultiSequence> PrmPilotMultiSequences { get; set; }

    public virtual DbSet<PrmPilotPartialized> PrmPilotPartializeds { get; set; }

    public virtual DbSet<PrmPilotPwm> PrmPilotPwms { get; set; }

    public virtual DbSet<PrmPilotReleZc> PrmPilotReleZcs { get; set; }

    public virtual DbSet<PrmPilotStepByStep> PrmPilotStepBySteps { get; set; }

    public virtual DbSet<PrmPilotThreePhaseMotor> PrmPilotThreePhaseMotors { get; set; }

    public virtual DbSet<PrmPilotUniversalMotor> PrmPilotUniversalMotors { get; set; }

    public virtual DbSet<PrmPilotVent> PrmPilotVents { get; set; }

    public virtual DbSet<PrmPilotWax> PrmPilotWaxes { get; set; }

    public virtual DbSet<PrmReadAccellerometer> PrmReadAccellerometers { get; set; }

    public virtual DbSet<PrmReadAccellerometerStlisxDh> PrmReadAccellerometerStlisxDhs { get; set; }

    public virtual DbSet<PrmReadAnalog> PrmReadAnalogs { get; set; }

    public virtual DbSet<PrmReadAnalogFeedback> PrmReadAnalogFeedbacks { get; set; }

    public virtual DbSet<PrmReadConductivitySensor> PrmReadConductivitySensors { get; set; }

    public virtual DbSet<PrmReadDigitalMatrix> PrmReadDigitalMatrices { get; set; }

    public virtual DbSet<PrmReadI2cinfrared> PrmReadI2cinfrareds { get; set; }

    public virtual DbSet<PrmReadI2cpressureSensor> PrmReadI2cpressureSensors { get; set; }

    public virtual DbSet<PrmReadInputCapture> PrmReadInputCaptures { get; set; }

    public virtual DbSet<PrmReadL2crhthumiditySensor> PrmReadL2crhthumiditySensors { get; set; }

    public virtual DbSet<PrmReadL2crhttempSensor> PrmReadL2crhttempSensors { get; set; }

    public virtual DbSet<PrmReadMultiInput> PrmReadMultiInputs { get; set; }

    public virtual DbSet<PrmReadPeakToPeakAnalog> PrmReadPeakToPeakAnalogs { get; set; }

    public virtual DbSet<PrmReadSranalog> PrmReadSranalogs { get; set; }

    public virtual DbSet<PrmReadSrdigitalMatrix> PrmReadSrdigitalMatrices { get; set; }

    public virtual DbSet<PrmReadSri2cpressureSensor> PrmReadSri2cpressureSensors { get; set; }

    public virtual DbSet<PrmReadSrmultiplex> PrmReadSrmultiplexes { get; set; }

    public virtual DbSet<PrmReadSrpeakToPeakAnalog> PrmReadSrpeakToPeakAnalogs { get; set; }

    public virtual DbSet<PrmReadSrtouchKey> PrmReadSrtouchKeys { get; set; }

    public virtual DbSet<PrmReadTouchKey> PrmReadTouchKeys { get; set; }

    public virtual DbSet<PrmReadVirtualDigital> PrmReadVirtualDigitals { get; set; }

    public virtual DbSet<PrmTouchSlider> PrmTouchSliders { get; set; }

    public virtual DbSet<PrmUiaudioBuzzer> PrmUiaudioBuzzers { get; set; }

    public virtual DbSet<PrmUiaudioExpansion> PrmUiaudioExpansions { get; set; }

    public virtual DbSet<PrmUiaudioNuvoton> PrmUiaudioNuvotons { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<ProductTypesHighStatement> ProductTypesHighStatements { get; set; }

    public virtual DbSet<ProductTypesHighStatement1> ProductTypesHighStatements1 { get; set; }

    public virtual DbSet<ProductTypesHighStatementsView> ProductTypesHighStatementsViews { get; set; }

    public virtual DbSet<ProductTypesTask> ProductTypesTasks { get; set; }

    public virtual DbSet<ProductTypesTask1> ProductTypesTasks1 { get; set; }

    public virtual DbSet<ProductTypesTasksView> ProductTypesTasksViews { get; set; }

    public virtual DbSet<ProductTypesVariable> ProductTypesVariables { get; set; }

    public virtual DbSet<ProductTypesVariablesVariableGroupsView> ProductTypesVariablesVariableGroupsViews { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectsFullView> ProjectsFullViews { get; set; }

    public virtual DbSet<ProjectsLastRevisionView> ProjectsLastRevisionViews { get; set; }

    public virtual DbSet<PrtimerBroilConfiguration> PrtimerBroilConfigurations { get; set; }

    public virtual DbSet<PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration> PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations { get; set; }

    public virtual DbSet<PrtimerBroilTimerDecrement> PrtimerBroilTimerDecrements { get; set; }

    public virtual DbSet<PrtimerBroilTimerLimitConfiguration> PrtimerBroilTimerLimitConfigurations { get; set; }

    public virtual DbSet<PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail> PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails { get; set; }

    public virtual DbSet<PrtimerBroilTimerLimitDetail> PrtimerBroilTimerLimitDetails { get; set; }

    public virtual DbSet<PrtimerBroilUserPhaseNameConfiguration> PrtimerBroilUserPhaseNameConfigurations { get; set; }

    public virtual DbSet<PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail> PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails { get; set; }

    public virtual DbSet<PrtimerBroilUserPhaseNameDetail> PrtimerBroilUserPhaseNameDetails { get; set; }

    public virtual DbSet<PrtimerConvectConfiguration> PrtimerConvectConfigurations { get; set; }

    public virtual DbSet<PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration> PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations { get; set; }

    public virtual DbSet<PrtimerConvectTimerDecrement> PrtimerConvectTimerDecrements { get; set; }

    public virtual DbSet<PrtimerConvectTimerLimitConfiguration> PrtimerConvectTimerLimitConfigurations { get; set; }

    public virtual DbSet<PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail> PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails { get; set; }

    public virtual DbSet<PrtimerConvectTimerLimitDetail> PrtimerConvectTimerLimitDetails { get; set; }

    public virtual DbSet<PrtimerConvectUserPhaseNameConfiguration> PrtimerConvectUserPhaseNameConfigurations { get; set; }

    public virtual DbSet<PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail> PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails { get; set; }

    public virtual DbSet<PrtimerConvectUserPhaseNameDetail> PrtimerConvectUserPhaseNameDetails { get; set; }

    public virtual DbSet<PrtimerMagnetronConfiguration> PrtimerMagnetronConfigurations { get; set; }

    public virtual DbSet<PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration> PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations { get; set; }

    public virtual DbSet<PrtimerMagnetronTimerDecrement> PrtimerMagnetronTimerDecrements { get; set; }

    public virtual DbSet<PrtimerMagnetronTimerLimitConfiguration> PrtimerMagnetronTimerLimitConfigurations { get; set; }

    public virtual DbSet<PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail> PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails { get; set; }

    public virtual DbSet<PrtimerMagnetronTimerLimitDetail> PrtimerMagnetronTimerLimitDetails { get; set; }

    public virtual DbSet<PrtimerMagnetronUserPhaseNameConfiguration> PrtimerMagnetronUserPhaseNameConfigurations { get; set; }

    public virtual DbSet<PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail> PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails { get; set; }

    public virtual DbSet<PrtimerMagnetronUserPhaseNameDetail> PrtimerMagnetronUserPhaseNameDetails { get; set; }

    public virtual DbSet<ReadType> ReadTypes { get; set; }

    public virtual DbSet<RefreshRate> RefreshRates { get; set; }

    public virtual DbSet<RestoreMode> RestoreModes { get; set; }

    public virtual DbSet<Selector> Selectors { get; set; }

    public virtual DbSet<SelectorConfiguration> SelectorConfigurations { get; set; }

    public virtual DbSet<SelectorConfigurationsSelector> SelectorConfigurationsSelectors { get; set; }

    public virtual DbSet<SelectorToMacroStatement> SelectorToMacroStatements { get; set; }

    public virtual DbSet<SelectorsCycle> SelectorsCycles { get; set; }

    public virtual DbSet<SetStateEndCompletionType> SetStateEndCompletionTypes { get; set; }

    public virtual DbSet<SetVariableOperation> SetVariableOperations { get; set; }

    public virtual DbSet<SettingFileExtension> SettingFileExtensions { get; set; }

    public virtual DbSet<SettingsFileSize> SettingsFileSizes { get; set; }

    public virtual DbSet<SrboilerOverTempCheckParameter> SrboilerOverTempCheckParameters { get; set; }

    public virtual DbSet<SrexpansionConfiguration> SrexpansionConfigurations { get; set; }

    public virtual DbSet<SrexpansionConfigurationsSrexpansionDetail> SrexpansionConfigurationsSrexpansionDetails { get; set; }

    public virtual DbSet<SrexpansionDetail> SrexpansionDetails { get; set; }

    public virtual DbSet<SrfanSpeedCheckParameter> SrfanSpeedCheckParameters { get; set; }

    public virtual DbSet<SrhmieventCheckParameter> SrhmieventCheckParameters { get; set; }

    public virtual DbSet<SroverTempCheckParameter> SroverTempCheckParameters { get; set; }

    public virtual DbSet<SrpcbcheckParameter> SrpcbcheckParameters { get; set; }

    public virtual DbSet<SrpinShortCheckParameter> SrpinShortCheckParameters { get; set; }

    public virtual DbSet<SrplausibilityCheckParameter> SrplausibilityCheckParameters { get; set; }

    public virtual DbSet<SrsafetyRelevantParameter> SrsafetyRelevantParameters { get; set; }

    public virtual DbSet<SrstuckProbeCheckParameter> SrstuckProbeCheckParameters { get; set; }

    public virtual DbSet<Statement> Statements { get; set; }

    public virtual DbSet<StatementModifier> StatementModifiers { get; set; }

    public virtual DbSet<StatementTableModifier> StatementTableModifiers { get; set; }

    public virtual DbSet<StatusVariable> StatusVariables { get; set; }

    public virtual DbSet<SteamSystemType> SteamSystemTypes { get; set; }

    public virtual DbSet<StmActivateTask> StmActivateTasks { get; set; }

    public virtual DbSet<StmHeat> StmHeats { get; set; }

    public virtual DbSet<StmHeatInitializeSelector> StmHeatInitializeSelectors { get; set; }

    public virtual DbSet<StmHeatRun> StmHeatRuns { get; set; }

    public virtual DbSet<StmHeatRunView> StmHeatRunViews { get; set; }

    public virtual DbSet<StmInduction> StmInductions { get; set; }

    public virtual DbSet<StmJumpIf> StmJumpIfs { get; set; }

    public virtual DbSet<StmLoadsControl> StmLoadsControls { get; set; }

    public virtual DbSet<StmMaintain> StmMaintains { get; set; }

    public virtual DbSet<StmSetState> StmSetStates { get; set; }

    public virtual DbSet<StmSetVariable> StmSetVariables { get; set; }

    public virtual DbSet<StmSetupMeatProbe> StmSetupMeatProbes { get; set; }

    public virtual DbSet<StmSetupTempSelector> StmSetupTempSelectors { get; set; }

    public virtual DbSet<Structure> Structures { get; set; }

    public virtual DbSet<TableTarget> TableTargets { get; set; }

    public virtual DbSet<Target> Targets { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<TemperatureNodeName> TemperatureNodeNames { get; set; }

    public virtual DbSet<ThermalConfigDatum> ThermalConfigData { get; set; }

    public virtual DbSet<TimeEstimation> TimeEstimations { get; set; }

    public virtual DbSet<TimeEstimationConfiguration> TimeEstimationConfigurations { get; set; }

    public virtual DbSet<TimeEstimationConfigurationsTimeEstimationDetail> TimeEstimationConfigurationsTimeEstimationDetails { get; set; }

    public virtual DbSet<TimeEstimationDetail> TimeEstimationDetails { get; set; }

    public virtual DbSet<UianimationBlinkType> UianimationBlinkTypes { get; set; }

    public virtual DbSet<UianimationConfiguration> UianimationConfigurations { get; set; }

    public virtual DbSet<UianimationConfigurationsUianimationDetail> UianimationConfigurationsUianimationDetails { get; set; }

    public virtual DbSet<UianimationDetail> UianimationDetails { get; set; }

    public virtual DbSet<UianimationFadingType> UianimationFadingTypes { get; set; }

    public virtual DbSet<UianimationFrameConfiguration> UianimationFrameConfigurations { get; set; }

    public virtual DbSet<UianimationFrameConfigurationsUianimationFrameDetail> UianimationFrameConfigurationsUianimationFrameDetails { get; set; }

    public virtual DbSet<UianimationFrameDetail> UianimationFrameDetails { get; set; }

    public virtual DbSet<UianimationFunction> UianimationFunctions { get; set; }

    public virtual DbSet<UianimationSequenceType> UianimationSequenceTypes { get; set; }

    public virtual DbSet<UianimationType> UianimationTypes { get; set; }

    public virtual DbSet<UiaudioBuzzerDetail> UiaudioBuzzerDetails { get; set; }

    public virtual DbSet<UiaudioBuzzerUiaudioBuzzerDetail> UiaudioBuzzerUiaudioBuzzerDetails { get; set; }

    public virtual DbSet<UiaudioChimeType> UiaudioChimeTypes { get; set; }

    public virtual DbSet<UiaudioConfiguration> UiaudioConfigurations { get; set; }

    public virtual DbSet<UiaudioConfigurationsUiaudioDetail> UiaudioConfigurationsUiaudioDetails { get; set; }

    public virtual DbSet<UiaudioDetail> UiaudioDetails { get; set; }

    public virtual DbSet<UiaudioDeviceType> UiaudioDeviceTypes { get; set; }

    public virtual DbSet<UiaudioFunction> UiaudioFunctions { get; set; }

    public virtual DbSet<UiboolOperator> UiboolOperators { get; set; }

    public virtual DbSet<UiclassBeventConfiguration> UiclassBeventConfigurations { get; set; }

    public virtual DbSet<UiclassBeventConfigurationsUiclassBeventDetail> UiclassBeventConfigurationsUiclassBeventDetails { get; set; }

    public virtual DbSet<UiclassBeventDetail> UiclassBeventDetails { get; set; }

    public virtual DbSet<Uicondition> Uiconditions { get; set; }

    public virtual DbSet<UiconditionBlock> UiconditionBlocks { get; set; }

    public virtual DbSet<UicypressTouchParameter> UicypressTouchParameters { get; set; }

    public virtual DbSet<UidataModelKeyMapping> UidataModelKeyMappings { get; set; }

    public virtual DbSet<UidataModelTranslationConfiguration> UidataModelTranslationConfigurations { get; set; }

    public virtual DbSet<UidataModelTranslationConfigurationsUidataModelTranslationDetail> UidataModelTranslationConfigurationsUidataModelTranslationDetails { get; set; }

    public virtual DbSet<UidataModelTranslationDetail> UidataModelTranslationDetails { get; set; }

    public virtual DbSet<UidefaultPinConfiguration> UidefaultPinConfigurations { get; set; }

    public virtual DbSet<UidefaultPinConfigurationsUidefaultPinDetail> UidefaultPinConfigurationsUidefaultPinDetails { get; set; }

    public virtual DbSet<UidefaultPinDetail> UidefaultPinDetails { get; set; }

    public virtual DbSet<UifunctionCondition> UifunctionConditions { get; set; }

    public virtual DbSet<UifunctionConfiguration> UifunctionConfigurations { get; set; }

    public virtual DbSet<UifunctionConfigurationsUifunctionDetail> UifunctionConfigurationsUifunctionDetails { get; set; }

    public virtual DbSet<UifunctionDetail> UifunctionDetails { get; set; }

    public virtual DbSet<UigenericInputConfiguration> UigenericInputConfigurations { get; set; }

    public virtual DbSet<UigenericInputConfigurationsUigenericInputDetail> UigenericInputConfigurationsUigenericInputDetails { get; set; }

    public virtual DbSet<UigenericInputDetail> UigenericInputDetails { get; set; }

    public virtual DbSet<UigenericInputReadType> UigenericInputReadTypes { get; set; }

    public virtual DbSet<UihighStatement> UihighStatements { get; set; }

    public virtual DbSet<Uiinput> Uiinputs { get; set; }

    public virtual DbSet<UiinputEvent> UiinputEvents { get; set; }

    public virtual DbSet<UiinputEventMappingConfiguration> UiinputEventMappingConfigurations { get; set; }

    public virtual DbSet<UiinputEventMappingConfigurationsUiinputEventMappingDetail> UiinputEventMappingConfigurationsUiinputEventMappingDetails { get; set; }

    public virtual DbSet<UiinputEventMappingDetail> UiinputEventMappingDetails { get; set; }

    public virtual DbSet<UiledConfiguration> UiledConfigurations { get; set; }

    public virtual DbSet<UiledConfigurationsUiledDriverParameter> UiledConfigurationsUiledDriverParameters { get; set; }

    public virtual DbSet<UiledDriverParameter> UiledDriverParameters { get; set; }

    public virtual DbSet<UiledDriverType> UiledDriverTypes { get; set; }

    public virtual DbSet<UiledFunction> UiledFunctions { get; set; }

    public virtual DbSet<UiledFunctionMappingConfiguration> UiledFunctionMappingConfigurations { get; set; }

    public virtual DbSet<UiledFunctionMappingConfigurationsUiledFunctionMappingDetail> UiledFunctionMappingConfigurationsUiledFunctionMappingDetails { get; set; }

    public virtual DbSet<UiledFunctionMappingDetail> UiledFunctionMappingDetails { get; set; }

    public virtual DbSet<UiledGroup> UiledGroups { get; set; }

    public virtual DbSet<UiledGroupsConfiguration> UiledGroupsConfigurations { get; set; }

    public virtual DbSet<UiledGroupsConfigurationsUiledGroup> UiledGroupsConfigurationsUiledGroups { get; set; }

    public virtual DbSet<UiledGroupsDetail> UiledGroupsDetails { get; set; }

    public virtual DbSet<UiledGroupsUiledGroupsDetail> UiledGroupsUiledGroupsDetails { get; set; }

    public virtual DbSet<UilowPowerTime> UilowPowerTimes { get; set; }

    public virtual DbSet<Uimacro> Uimacros { get; set; }

    public virtual DbSet<UimacrosUistatement> UimacrosUistatements { get; set; }

    public virtual DbSet<UimonitorListType> UimonitorListTypes { get; set; }

    public virtual DbSet<UiopCode> UiopCodes { get; set; }

    public virtual DbSet<Uioperator> Uioperators { get; set; }

    public virtual DbSet<UiprmGiabsoluteEncoder> UiprmGiabsoluteEncoders { get; set; }

    public virtual DbSet<UiprmGianalogEncoder> UiprmGianalogEncoders { get; set; }

    public virtual DbSet<UiprmGianalogPotentiometer> UiprmGianalogPotentiometers { get; set; }

    public virtual DbSet<UiprmGidiscretePotentiometer> UiprmGidiscretePotentiometers { get; set; }

    public virtual DbSet<UiprmGiincrementalEncoder> UiprmGiincrementalEncoders { get; set; }

    public virtual DbSet<UiprmGitouchSlider> UiprmGitouchSliders { get; set; }

    public virtual DbSet<UiregulationTable> UiregulationTables { get; set; }

    public virtual DbSet<Uisequence> Uisequences { get; set; }

    public virtual DbSet<UisequenceConfiguration> UisequenceConfigurations { get; set; }

    public virtual DbSet<UisequenceConfigurationsUisequence> UisequenceConfigurationsUisequences { get; set; }

    public virtual DbSet<UisequencesUistep> UisequencesUisteps { get; set; }

    public virtual DbSet<UisreventConfiguration> UisreventConfigurations { get; set; }

    public virtual DbSet<UisreventConfigurationsUisreventDetail> UisreventConfigurationsUisreventDetails { get; set; }

    public virtual DbSet<UisreventDetail> UisreventDetails { get; set; }

    public virtual DbSet<UisreventPrmAnalog> UisreventPrmAnalogs { get; set; }

    public virtual DbSet<UisreventPrmDigital> UisreventPrmDigitals { get; set; }

    public virtual DbSet<UisreventPrmEncoder> UisreventPrmEncoders { get; set; }

    public virtual DbSet<Uistatement> Uistatements { get; set; }

    public virtual DbSet<Uistep> Uisteps { get; set; }

    public virtual DbSet<UistepsUicondition> UistepsUiconditions { get; set; }

    public virtual DbSet<UistmSetAnimation> UistmSetAnimations { get; set; }

    public virtual DbSet<UistmSetAudio> UistmSetAudios { get; set; }

    public virtual DbSet<UistmSetFunction> UistmSetFunctions { get; set; }

    public virtual DbSet<UistmSetIncompatibility> UistmSetIncompatibilities { get; set; }

    public virtual DbSet<UistmSetObject> UistmSetObjects { get; set; }

    public virtual DbSet<UistmSetTimer> UistmSetTimers { get; set; }

    public virtual DbSet<UistmSetVariable> UistmSetVariables { get; set; }

    public virtual DbSet<UistmVisualJumpIf> UistmVisualJumpIfs { get; set; }

    public virtual DbSet<UitimeToEndVisualizerConfiguration> UitimeToEndVisualizerConfigurations { get; set; }

    public virtual DbSet<UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail> UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetails { get; set; }

    public virtual DbSet<UitimeToEndVisualizerDetail> UitimeToEndVisualizerDetails { get; set; }

    public virtual DbSet<UitouchDevice> UitouchDevices { get; set; }

    public virtual DbSet<UitouchLean> UitouchLeans { get; set; }

    public virtual DbSet<UiviewEngineControlStateConfiguration> UiviewEngineControlStateConfigurations { get; set; }

    public virtual DbSet<UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail> UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails { get; set; }

    public virtual DbSet<UiviewEngineControlStateDetail> UiviewEngineControlStateDetails { get; set; }

    public virtual DbSet<UiviewEngineViewsConfiguratio> UiviewEngineViewsConfiguratios { get; set; }

    public virtual DbSet<UiviewEngineViewsConfigurationsUiviewEngineViewsDetail> UiviewEngineViewsConfigurationsUiviewEngineViewsDetails { get; set; }

    public virtual DbSet<UiviewEngineViewsDetail> UiviewEngineViewsDetails { get; set; }

    public virtual DbSet<UserPhaseName> UserPhaseNames { get; set; }

    public virtual DbSet<Variable> Variables { get; set; }

    public virtual DbSet<VariableBaseTrack> VariableBaseTracks { get; set; }

    public virtual DbSet<VariableGroup> VariableGroups { get; set; }

    public virtual DbSet<VisualBoardType> VisualBoardTypes { get; set; }

    public virtual DbSet<VwPlatformGenericInputConfiguration> VwPlatformGenericInputConfigurations { get; set; }

    public virtual DbSet<VwPlatformLoadConfiguration> VwPlatformLoadConfigurations { get; set; }

    public virtual DbSet<VwPlatformLowLevelInputConfiguration> VwPlatformLowLevelInputConfigurations { get; set; }

    public virtual DbSet<VwVisualFunctionConfiguration> VwVisualFunctionConfigurations { get; set; }

    public virtual DbSet<VwVisualGenericInputConfiguration> VwVisualGenericInputConfigurations { get; set; }

    public virtual DbSet<VwVisualLowLevelInputConfiguration> VwVisualLowLevelInputConfigurations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=AWN-MSSQLN3P1;Initial Catalog=GESE_Cooking; TrustServerCertificate=true; User ID=gese_user; Password=GESEus3r; MultipleActiveResultSets=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcuexpansionBoardConfiguration>(entity =>
        {
            entity.Property(e => e.AcuexpansionBoardConfigId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<AcuexpansionBoardConfigurationsBoard>(entity =>
        {
            entity.HasOne(d => d.AcuexpansionBoardConfig).WithMany(p => p.AcuexpansionBoardConfigurationsBoards)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACUExpansionBoardConfigurations_Boards_ACUExpansionBoardConfigurations");

            entity.HasOne(d => d.Board).WithMany(p => p.AcuexpansionBoardConfigurationsBoards)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACUExpansionBoardConfigurations_Boards_Boards");
        });

        modelBuilder.Entity<AppConfigCompartmentDetail>(entity =>
        {
            entity.Property(e => e.AppConfigCompartmentDetailsId).ValueGeneratedNever();

            entity.HasOne(d => d.OvenCoolingFanComp).WithMany(p => p.AppConfigCompartmentDetails).HasConstraintName("FK_AppConfigCompartmentDetails_AppConfigCoolingFanCompartment");

            entity.HasOne(d => d.OvenMwcompartment).WithMany(p => p.AppConfigCompartmentDetails).HasConstraintName("FK_AppConfigCompartmentDetails_AppConfigOvenMWCompartment");
        });

        modelBuilder.Entity<AppConfigCoolingFanCompartment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AppConfigMicrowaveCompartment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AppConfigOvenMwcompartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AppConfigOvenCompartment");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BakeFeedbackIndex).HasDefaultValueSql("((255))");
            entity.Property(e => e.BakeRelayEnable).HasDefaultValueSql("((255))");
            entity.Property(e => e.Broil1FeedbackIndex).HasDefaultValueSql("((255))");
            entity.Property(e => e.Broil1RelayEnable).HasDefaultValueSql("((255))");
            entity.Property(e => e.Broil2FeedbackIndex).HasDefaultValueSql("((255))");
            entity.Property(e => e.Broil2RelayEnable).HasDefaultValueSql("((255))");
            entity.Property(e => e.ConvElement1FeedbackIndex).HasDefaultValueSql("((255))");
            entity.Property(e => e.ConvElement1RelayEnable).HasDefaultValueSql("((255))");
            entity.Property(e => e.ConvElement2FeedbackIndex).HasDefaultValueSql("((255))");
            entity.Property(e => e.ConvElement2RelayEnable).HasDefaultValueSql("((255))");
            entity.Property(e => e.DlbfeedbackIndex).HasDefaultValueSql("((255))");
            entity.Property(e => e.ForcedConvValve).HasDefaultValueSql("((255))");
            entity.Property(e => e.HumiditySensor).HasDefaultValueSql("((255))");
            entity.Property(e => e.LatchFeedbackIndex).HasDefaultValueSql("((255))");
            entity.Property(e => e.LatchRelayEnable).HasDefaultValueSql("((255))");
            entity.Property(e => e.Light2).HasDefaultValueSql("((255))");
            entity.Property(e => e.LoadsFeedbackIndex).HasDefaultValueSql("((255))");
            entity.Property(e => e.Magnetron).HasDefaultValueSql("((255))");
            entity.Property(e => e.MagnetronFeedbackIndex).HasDefaultValueSql("((255))");
            entity.Property(e => e.MagnetronRelayEnable).HasDefaultValueSql("((255))");
            entity.Property(e => e.SecondaryDlb).HasDefaultValueSql("((255))");
            entity.Property(e => e.SecondaryDlbFeedbackIndex).HasDefaultValueSql("((255))");
            entity.Property(e => e.SecondaryDoorSwitch).HasDefaultValueSql("((255))");
            entity.Property(e => e.SecondaryRelayEnable).HasDefaultValueSql("((255))");
            entity.Property(e => e.ToastSensor).HasDefaultValueSql("((255))");
            entity.Property(e => e.TurnTable).HasDefaultValueSql("((255))");
            entity.Property(e => e.TurnTableFeedbackIndex).HasDefaultValueSql("((255))");
            entity.Property(e => e.TurnTableRelayEnable).HasDefaultValueSql("((255))");
        });

        modelBuilder.Entity<ApplianceConfiguration>(entity =>
        {
            entity.Property(e => e.ApplianceConfigurationId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ApplianceConfigurationAppConfigCompartmentDetail>(entity =>
        {
            entity.HasOne(d => d.AppConfigCompartmentDetails).WithMany(p => p.ApplianceConfigurationAppConfigCompartmentDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplianceConfiguration_AppConfigCompartmentDetails_AppConfigCompartmentDetails");

            entity.HasOne(d => d.ApplianceConfiguration).WithMany(p => p.ApplianceConfigurationAppConfigCompartmentDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplianceConfiguration_AppConfigCompartmentDetails_ApplianceConfiguration");
        });

        modelBuilder.Entity<AssistedCookingConfigDatum>(entity =>
        {
            entity.Property(e => e.AssistedCookingConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Attribute>(entity =>
        {
            entity.Property(e => e.AttributeId).ValueGeneratedNever();

            entity.HasOne(d => d.AttributeType).WithMany(p => p.Attributes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attributes_AttributeTypes");

            entity.HasMany(d => d.AttributeValueEnumerations).WithMany(p => p.Attributes)
                .UsingEntity<Dictionary<string, object>>(
                    "AttributesAttributesValueEnumeration",
                    r => r.HasOne<AttributeValueEnumeration>().WithMany()
                        .HasForeignKey("AttributeValueEnumerationId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Attributes_AttributesValueEnumerations_AttributeValueEnumerations"),
                    l => l.HasOne<Attribute>().WithMany()
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Attributes_AttributesValueEnumerations_Attributes"),
                    j =>
                    {
                        j.HasKey("AttributeId", "AttributeValueEnumerationId");
                        j.ToTable("Attributes_AttributesValueEnumerations");
                    });
        });

        modelBuilder.Entity<AttributeValueEnumeration>(entity =>
        {
            entity.Property(e => e.AttributeValueEnumerationId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Board>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_Boards_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.BoardId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Code).HasDefaultValueSql("('00000000000')");
            entity.Property(e => e.NodeAddress).HasDefaultValueSql("((5))");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Size).HasDefaultValueSql("((8192))");
            entity.Property(e => e.StartPosition).HasDefaultValueSql("((4294946816.))");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.AcuexpansionBoardConfiguration).WithMany(p => p.Boards).HasConstraintName("FK_Boards_ACUExpansionBoardConfigurations");

            entity.HasOne(d => d.CrossLoadConfiguration).WithMany(p => p.Boards).HasConstraintName("FK_Boards_CrossLoadConfigurations");

            entity.HasOne(d => d.DefaultPinConfiguration).WithMany(p => p.Boards).HasConstraintName("FK_Boards_DefaultPinConfigurations");

            entity.HasOne(d => d.GenericInputConfiguration).WithMany(p => p.Boards).HasConstraintName("FK_Boards_GenericInputConfigurations");

            entity.HasOne(d => d.LoadConfiguration).WithMany(p => p.Boards).HasConstraintName("FK_Boards_LoadConfigurations");

            entity.HasOne(d => d.LowLevelInputConfiguration).WithMany(p => p.Boards).HasConstraintName("FK_Boards_LowLevelInputConfigurations");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.Boards)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Boards_TableTargets");
        });

        modelBuilder.Entity<CodeBuilder>(entity =>
        {
            entity.Property(e => e.CodeBuilderId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<CodeBuilderContainer>(entity =>
        {
            entity.Property(e => e.CodeBuilderContainerId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<CodeBuilderContainersElement>(entity =>
        {
            entity.HasOne(d => d.CodeBuilderContainer).WithMany(p => p.CodeBuilderContainersElements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodeBuilderContainers_Elements_CodeBuilderContainers");
        });

        modelBuilder.Entity<CodeBuildersCodeBuilderContainer>(entity =>
        {
            entity.HasOne(d => d.CodeBuilderContainer).WithMany(p => p.CodeBuildersCodeBuilderContainers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodeBuilders_CodeBuilderContainers_CodeBuilderContainers");

            entity.HasOne(d => d.CodeBuilder).WithMany(p => p.CodeBuildersCodeBuilderContainers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodeBuilders_CodeBuilderContainers_CodeBuilders");
        });

        modelBuilder.Entity<CoilOperationConfigDatum>(entity =>
        {
            entity.Property(e => e.CoilOperationConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CoilSpecificConfigDatum>(entity =>
        {
            entity.Property(e => e.CoilSpecificConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CompartmentNamesAndLoadsView>(entity =>
        {
            entity.ToView("CompartmentNamesAndLoadsView");
        });

        modelBuilder.Entity<CompiledResourceMetaDatum>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Project).WithMany(p => p.CompiledResourceMetaData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompiledResourceMetaData_Projects");
        });

        modelBuilder.Entity<Condition>(entity =>
        {
            entity.Property(e => e.ConditionId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ConditionBlock1).WithMany(p => p.ConditionConditionBlock1s).HasConstraintName("FK_Conditions_ConditionBlocks");

            entity.HasOne(d => d.ConditionBlock2).WithMany(p => p.ConditionConditionBlock2s).HasConstraintName("FK_Conditions_ConditionBlocks1");

            entity.HasOne(d => d.ConditionBlock3).WithMany(p => p.ConditionConditionBlock3s).HasConstraintName("FK_Conditions_ConditionBlocks2");

            entity.HasOne(d => d.ConditionBlock4).WithMany(p => p.ConditionConditionBlock4s).HasConstraintName("FK_Conditions_ConditionBlocks3");

            entity.HasOne(d => d.ConditionBlock5).WithMany(p => p.ConditionConditionBlock5s).HasConstraintName("FK_Conditions_ConditionBlocks4");

            entity.HasOne(d => d.ConditionBlock6).WithMany(p => p.ConditionConditionBlock6s).HasConstraintName("FK_Conditions_ConditionBlocks5");

            entity.HasOne(d => d.ConditionBlock7).WithMany(p => p.ConditionConditionBlock7s).HasConstraintName("FK_Conditions_ConditionBlocks6");

            entity.HasOne(d => d.ConditionBlock8).WithMany(p => p.ConditionConditionBlock8s).HasConstraintName("FK_Conditions_ConditionBlocks7");
        });

        modelBuilder.Entity<ConditionBlock>(entity =>
        {
            entity.Property(e => e.ConditionBlockId).ValueGeneratedNever();
            entity.Property(e => e.FirstVariableGroupId).HasDefaultValueSql("((255))");
            entity.Property(e => e.Mask).HasDefaultValueSql("((255))");
        });

        modelBuilder.Entity<CrossLoadConfiguration>(entity =>
        {
            entity.Property(e => e.CrossLoadConfigurationId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.CrossLoadConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CrossLoadConfigurations_TableTargets");
        });

        modelBuilder.Entity<CrossLoadConfigurationsCrossLoadDetail>(entity =>
        {
            entity.HasOne(d => d.CrossLoadConfiguration).WithMany(p => p.CrossLoadConfigurationsCrossLoadDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CrossLoadConfigurations_CrossLoadDetails_CrossLoadConfigurations");

            entity.HasOne(d => d.CrossLoadDetail).WithMany(p => p.CrossLoadConfigurationsCrossLoadDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CrossLoadConfigurations_CrossLoadDetails_CrossLoadDetails");
        });

        modelBuilder.Entity<CrossLoadDetail>(entity =>
        {
            entity.Property(e => e.CrossLoadDetailId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CouplesNum).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.CrossLoadType).WithMany(p => p.CrossLoadDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CrossLoadDetails_CrossLoadTypes");

            entity.HasOne(d => d.Load).WithMany(p => p.CrossLoadDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CrossLoadDetails_Loads");
        });

        modelBuilder.Entity<Cycle>(entity =>
        {
            entity.Property(e => e.CycleId).ValueGeneratedNever();

            entity.HasOne(d => d.CycleNameNavigation).WithMany(p => p.Cycles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cycles_CycleNames");

            entity.HasOne(d => d.DelayMacro).WithMany(p => p.CycleDelayMacros).HasConstraintName("FK_Cycles_Macros_Delay");

            entity.HasOne(d => d.DelayUimacro).WithMany(p => p.CycleDelayUimacros).HasConstraintName("FK_Cycles_UIMacros_Delay");

            entity.HasOne(d => d.EndMacro).WithMany(p => p.CycleEndMacros).HasConstraintName("FK_Cycles_Macros_End");

            entity.HasOne(d => d.EndUimacro).WithMany(p => p.CycleEndUimacros).HasConstraintName("FK_Cycles_UIMacros_End");

            entity.HasOne(d => d.PauseMacro).WithMany(p => p.CyclePauseMacros).HasConstraintName("FK_Cycles_Macros_Pause");

            entity.HasOne(d => d.PauseUimacro).WithMany(p => p.CyclePauseUimacros).HasConstraintName("FK_Cycles_UIMacros_Pause");

            entity.HasOne(d => d.ProgrammingMacro).WithMany(p => p.CycleProgrammingMacros).HasConstraintName("FK_Cycles_Macros_Programming");

            entity.HasOne(d => d.ProgrammingUimacro).WithMany(p => p.CycleProgrammingUimacros).HasConstraintName("FK_Cycles_UIMacros_Programming");

            entity.HasOne(d => d.RunUimacro).WithMany(p => p.CycleRunUimacros).HasConstraintName("FK_Cycles_UIMacros_Run");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.Cycles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cycles_TableTargets");
        });

        modelBuilder.Entity<CycleMapping>(entity =>
        {
            entity.Property(e => e.CycleMappingId).ValueGeneratedNever();

            entity.HasOne(d => d.CycleMappingAcuTarget).WithMany(p => p.CycleMappings).HasConstraintName("FK_CycleMapping_CycleMappingAcuTargets");

            entity.HasOne(d => d.CycleMappingFileInfo).WithMany(p => p.CycleMappings).HasConstraintName("FK_CycleMapping_CycleMappingFileInfo");

            entity.HasOne(d => d.ExportOption).WithMany(p => p.CycleMappings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleMapping_CycleMappingExportOptions");
        });

        modelBuilder.Entity<CycleMappingAcuTarget>(entity =>
        {
            entity.Property(e => e.CycleMappingAcuTargetId).ValueGeneratedNever();

            entity.HasOne(d => d.CycleMappingCavityParamsId1Navigation).WithMany(p => p.CycleMappingAcuTargetCycleMappingCavityParamsId1Navigations).HasConstraintName("FK_CycleMappingAcuTargets_CycleMappingCavityParams");

            entity.HasOne(d => d.CycleMappingCavityParamsId2Navigation).WithMany(p => p.CycleMappingAcuTargetCycleMappingCavityParamsId2Navigations).HasConstraintName("FK_CycleMappingAcuTargets_CycleMappingCavityParams1");

            entity.HasOne(d => d.CycleMappingCavityParamsId3Navigation).WithMany(p => p.CycleMappingAcuTargetCycleMappingCavityParamsId3Navigations).HasConstraintName("FK_CycleMappingAcuTargets_CycleMappingCavityParams2");

            entity.HasOne(d => d.CycleMappingCavityParamsId4Navigation).WithMany(p => p.CycleMappingAcuTargetCycleMappingCavityParamsId4Navigations).HasConstraintName("FK_CycleMappingAcuTargets_CycleMappingCavityParams3");
        });

        modelBuilder.Entity<CycleMappingCavityParam>(entity =>
        {
            entity.Property(e => e.CycleMappingCavityParamsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleMappingCycleOptionsConfiguration>(entity =>
        {
            entity.HasOne(d => d.CycleMapping).WithMany(p => p.CycleMappingCycleOptionsConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleMapping_CycleOptionsConfigurations_CycleMapping");

            entity.HasOne(d => d.CycleOptionsConfigurations).WithMany(p => p.CycleMappingCycleOptionsConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleMapping_CycleOptionsConfigurations_CycleOptionsConfigurations");

            entity.HasOne(d => d.UriTree).WithMany(p => p.CycleMappingCycleOptionsConfigurations).HasConstraintName("FK_CycleMapping_CycleOptionsConfigurations_CycleMappingUris");
        });

        modelBuilder.Entity<CycleMappingFileInfo>(entity =>
        {
            entity.Property(e => e.CycleMappingFileInfoId).ValueGeneratedNever();

            entity.HasOne(d => d.ProductVariantNavigation).WithMany(p => p.CycleMappingFileInfos).HasConstraintName("FK_CycleMapping_CycleMappingProductVariants");
        });

        modelBuilder.Entity<CycleMappingFileInfoCycleMappingModelNumber>(entity =>
        {
            entity.HasOne(d => d.CycleMappingFileInfo).WithMany(p => p.CycleMappingFileInfoCycleMappingModelNumbers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleMappingFileInfo_CycleMappingModelNumber_CycleMappingFileInfo");

            entity.HasOne(d => d.CycleMappingModelNumber).WithMany(p => p.CycleMappingFileInfoCycleMappingModelNumbers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleMappingFileInfo_CycleMappingModelNumber_CycleMappingModelNumber");
        });

        modelBuilder.Entity<CycleMappingModelNumber>(entity =>
        {
            entity.Property(e => e.CycleMappingModelNumberId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleMappingSelector>(entity =>
        {
            entity.ToView("CycleMappingSelectors");
        });

        modelBuilder.Entity<CycleMappingUri>(entity =>
        {
            entity.Property(e => e.UriTreeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleMappingUriSelection>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleName>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CycleHeading).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.CycleGroupNavigation).WithMany(p => p.CycleNames)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleNames_CycleGroups");

            entity.HasOne(d => d.CycleHeadingNavigation).WithMany(p => p.CycleNames)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleNames_CycleHeadings");
        });

        modelBuilder.Entity<CycleOptionsAssistedFormula>(entity =>
        {
            entity.Property(e => e.AssistedFormulaParamsId).ValueGeneratedNever();

            entity.HasOne(d => d.InputId1Navigation).WithMany(p => p.CycleOptionsAssistedFormulaInputId1Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleOptionsAssistedFormula_CycleOptionsAssistedFormulaInputs");

            entity.HasOne(d => d.InputId2Navigation).WithMany(p => p.CycleOptionsAssistedFormulaInputId2Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleOptionsAssistedFormula_CycleOptionsAssistedFormulaInputs1");

            entity.HasOne(d => d.InputId3Navigation).WithMany(p => p.CycleOptionsAssistedFormulaInputId3Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleOptionsAssistedFormula_CycleOptionsAssistedFormulaInputs2");

            entity.HasOne(d => d.InputId4Navigation).WithMany(p => p.CycleOptionsAssistedFormulaInputId4Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleOptionsAssistedFormula_CycleOptionsAssistedFormulaInputs3");
        });

        modelBuilder.Entity<CycleOptionsBrowning>(entity =>
        {
            entity.Property(e => e.BrowningOptionsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsConfiguration>(entity =>
        {
            entity.Property(e => e.CycleOptionsConfigurationsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsConfigurationsCycleOptionsDetail>(entity =>
        {
            entity.HasOne(d => d.CycleOptionsConfigurations).WithMany(p => p.CycleOptionsConfigurationsCycleOptionsDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleOptionsConfigurations_CycleOptionsDetails_CycleOptionsConfigurations");

            entity.HasOne(d => d.CycleOptionsDetails).WithMany(p => p.CycleOptionsConfigurationsCycleOptionsDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleOptionsConfigurations_CycleOptionsDetails_CycleOptionsDetails");
        });

        modelBuilder.Entity<CycleOptionsDetail>(entity =>
        {
            entity.Property(e => e.CycleOptionsDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsDoneness>(entity =>
        {
            entity.Property(e => e.DonenessOptionsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsFullView>(entity =>
        {
            entity.ToView("CycleOptionsFullView");
        });

        modelBuilder.Entity<CycleOptionsPrmAmount>(entity =>
        {
            entity.HasKey(e => e.AmountOptionsId).HasName("PK_CycleOptionsLayers");

            entity.Property(e => e.AmountOptionsId).ValueGeneratedNever();
            entity.Property(e => e.Step).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<CycleOptionsPrmAmountDiscrete>(entity =>
        {
            entity.Property(e => e.AmountDiscreteOptionId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsPrmAtEnd>(entity =>
        {
            entity.HasKey(e => e.AtEndOptionsId).HasName("PK_CycleOptionsAtEnd");

            entity.Property(e => e.AtEndOptionsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsPrmBrowningDoneness>(entity =>
        {
            entity.HasKey(e => e.BrowningDonenessOptionsId).HasName("PK_CycleOptionsBrowningDoneness");

            entity.Property(e => e.BrowningDonenessOptionsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsPrmConvectConvert>(entity =>
        {
            entity.HasKey(e => e.ConvectConversionOptionsId).HasName("PK_CycleOptionsConvectConvert");

            entity.Property(e => e.ConvectConversionOptionsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsPrmDelay>(entity =>
        {
            entity.HasKey(e => e.DelayOptionsId).HasName("PK_CycleOptionsDelay");

            entity.Property(e => e.DelayOptionsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsPrmFoodType>(entity =>
        {
            entity.Property(e => e.FoodTypeOptionsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsPrmFormula>(entity =>
        {
            entity.HasKey(e => e.FormulaParamsId).HasName("PK_CycleOptionsFormula");

            entity.Property(e => e.FormulaParamsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsPrmFrozenBake>(entity =>
        {
            entity.HasKey(e => e.FrozenBakeParamsId).HasName("PK_CycleOptionsFrozenBake");

            entity.Property(e => e.FrozenBakeParamsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsPrmMaxStartTemperature>(entity =>
        {
            entity.Property(e => e.MaxTempOptionsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsPrmMeatProbeTemperature>(entity =>
        {
            entity.HasKey(e => e.MeatProbeOptionsId).HasName("PK_CycleOptionMeatProbeTemperature");

            entity.Property(e => e.MeatProbeOptionsId).ValueGeneratedNever();
            entity.Property(e => e.StepCelsius).HasDefaultValueSql("((5))");
            entity.Property(e => e.StepFahrenheit).HasDefaultValueSql("((25))");
        });

        modelBuilder.Entity<CycleOptionsPrmMwoPowerLevel>(entity =>
        {
            entity.Property(e => e.MwoPowerLevelsOptionsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsPrmPanSize>(entity =>
        {
            entity.HasKey(e => e.PanSizeOptionsId).HasName("PK_CycleOptionsPanSize");

            entity.Property(e => e.PanSizeOptionsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsPrmPreheat>(entity =>
        {
            entity.HasKey(e => e.PreheatOptionsId).HasName("PK_CycleOptionsPreheat");

            entity.Property(e => e.PreheatOptionsId).ValueGeneratedNever();
            entity.Property(e => e.DisplayRampStepC).HasDefaultValueSql("((1))");
            entity.Property(e => e.DisplayRampStepF).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<CycleOptionsPrmPyro>(entity =>
        {
            entity.Property(e => e.PyroOptionsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsPrmSize>(entity =>
        {
            entity.HasKey(e => e.SizeOptionsId).HasName("PK_CycleOptionsSize");

            entity.Property(e => e.SizeOptionsId).ValueGeneratedNever();
            entity.Property(e => e.Step).HasDefaultValueSql("((0.5))");
        });

        modelBuilder.Entity<CycleOptionsPrmStepsConfiguration>(entity =>
        {
            entity.HasKey(e => e.CycleOptionsPrmStepsConfigId).HasName("PK_CycleOptionsPrmMwStepsConfigurations");

            entity.Property(e => e.CycleOptionsPrmStepsConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail>(entity =>
        {
            entity.HasKey(e => new { e.CycleOptionsPrmStepsConfigId, e.CycleOptionsStepDetailsId, e.Index }).HasName("PK_CycleOptionsPrmStepsConfigurations_CycleOptionsStepDetailsV2");

            entity.HasOne(d => d.CycleOptionsPrmStepsConfig).WithMany(p => p.CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleOptionsPrmStepsConfigurations_CycleOptionsStepDetails_CycleOptionsPrmStepsConfigurations");

            entity.HasOne(d => d.CycleOptionsStepDetails).WithMany(p => p.CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleOptionsPrmStepsConfigurations_CycleOptionsStepDetails_CycleOptionsStepDetails");
        });

        modelBuilder.Entity<CycleOptionsPrmTemperature>(entity =>
        {
            entity.HasKey(e => e.TemperatureOptionsId).HasName("PK_CycleTemperatureOptions");

            entity.Property(e => e.TemperatureOptionsId).ValueGeneratedNever();
            entity.Property(e => e.ConfigureMaxTemp).HasDefaultValueSql("((1))");
            entity.Property(e => e.NumberOfSelections).HasDefaultValueSql("((3))");
            entity.Property(e => e.TemperatureSelectionDefaultName).HasDefaultValueSql("((2))");
            entity.Property(e => e.TemperatureSelectionName2).HasDefaultValueSql("((2))");
            entity.Property(e => e.TemperatureSelectionName3).HasDefaultValueSql("((4))");

            entity.HasOne(d => d.TemperatureSelectionBehaviorNavigation).WithMany(p => p.CycleOptionsPrmTemperatures)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleTemperatureOptions_CycleTemperatureOptions");
        });

        modelBuilder.Entity<CycleOptionsPrmTime>(entity =>
        {
            entity.HasKey(e => e.TimeOptionsId).HasName("PK_CycleTimeOptions");

            entity.Property(e => e.TimeOptionsId).ValueGeneratedNever();
            entity.Property(e => e.Name2).HasDefaultValueSql("((2))");
            entity.Property(e => e.Name3).HasDefaultValueSql("((4))");
            entity.Property(e => e.Step).HasDefaultValueSql("((1))");
            entity.Property(e => e.UserCookTimeDefaultSelection).HasDefaultValueSql("((180))");

            entity.HasOne(d => d.UserCookTimeDisplayBehaviorNavigation).WithMany(p => p.CycleOptionsPrmTimes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleTimeOptions_CycleTimeDisplayOptions");

            entity.HasOne(d => d.UserCookTimeSelectionBehaviorNavigation).WithMany(p => p.CycleOptionsPrmTimes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleTimeOptions_CycleTimeSelectionOptions");
        });

        modelBuilder.Entity<CycleOptionsPrmTip>(entity =>
        {
            entity.Property(e => e.TipsOptionsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsPrmWeight>(entity =>
        {
            entity.HasKey(e => e.WeightOptionsId).HasName("PK_CycleOptionsWeight");

            entity.Property(e => e.WeightOptionsId).ValueGeneratedNever();
            entity.Property(e => e.Step).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<CycleOptionsPrmWeightRange>(entity =>
        {
            entity.Property(e => e.WeightRangesOptionId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsStepDetail>(entity =>
        {
            entity.HasKey(e => e.CycleOptionsStepDetailsId).HasName("PK_CycleOptionsStepDetailsV2");

            entity.Property(e => e.CycleOptionsStepDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleOptionsStepUserInstruction>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CycleTemperatureOptionsBehaviorLabel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TemperatureOptionsBehaviorLabels");
        });

        modelBuilder.Entity<CycleTimeOptionsSelectionBehaviorLabel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CycleTimeOptionsBehaviorLabels");
        });

        modelBuilder.Entity<CyclesMacro>(entity =>
        {
            entity.HasOne(d => d.Cycle).WithMany(p => p.CyclesMacros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cycles_Macros_Cycles");

            entity.HasOne(d => d.Macro).WithMany(p => p.CyclesMacros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cycles_Macros_Macros");

            entity.HasOne(d => d.TimeEstimation).WithMany(p => p.CyclesMacros).HasConstraintName("FK_Cycles_Macros_TimeEstimation");

            entity.HasOne(d => d.Uimacro).WithMany(p => p.CyclesMacros).HasConstraintName("FK_Cycles_Macros_UIMacros");

            entity.HasOne(d => d.UserPhaseNameNavigation).WithMany(p => p.CyclesMacros).HasConstraintName("FK_Cycles_Macros_UserPhaseNames");
        });

        modelBuilder.Entity<CyclesToStatement>(entity =>
        {
            entity.ToView("CyclesToStatements");
        });

        modelBuilder.Entity<DataModelDefinitionConfiguration>(entity =>
        {
            entity.Property(e => e.DataModelDefinitionConfigurationId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<DataModelDefinitionConfigurationsDataModelDefinitionDetail>(entity =>
        {
            entity.HasOne(d => d.DataModelDefinitionConfiguration).WithMany(p => p.DataModelDefinitionConfigurationsDataModelDefinitionDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DataModelDefinitionConfigurations_DataModelDefinitionDetails_DataModelDefinitionConfigurations");

            entity.HasOne(d => d.DataModelDefinitionDetail).WithMany(p => p.DataModelDefinitionConfigurationsDataModelDefinitionDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DataModelDefinitionConfigurations_DataModelDefinitionDetails_DataModelDefinitionDetails");
        });

        modelBuilder.Entity<DataModelDefinitionDetail>(entity =>
        {
            entity.Property(e => e.DataModelDefinitionDetailId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<DataModelDefinitionView>(entity =>
        {
            entity.ToView("DataModelDefinitionView");
        });

        modelBuilder.Entity<DataModelEnumerationDefinition>(entity =>
        {
            entity.ToView("DataModelEnumerationDefinition");
        });

        modelBuilder.Entity<DebounceMethodParameter>(entity =>
        {
            entity.Property(e => e.DebounceMethodParametersId).ValueGeneratedNever();

            entity.HasOne(d => d.FaultDebounceMethod).WithMany(p => p.DebounceMethodParameterFaultDebounceMethods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebounceMethodParameters_DebounceMethods1");

            entity.HasOne(d => d.FaultPrescalar).WithMany(p => p.DebounceMethodParameterFaultPrescalars)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebounceMethodParameters_DebounceMethodPrescalars");

            entity.HasOne(d => d.PrefaultDebounceMethod).WithMany(p => p.DebounceMethodParameterPrefaultDebounceMethods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebounceMethodParameters_DebounceMethods");

            entity.HasOne(d => d.PrefaultPrescalar).WithMany(p => p.DebounceMethodParameterPrefaultPrescalars)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebounceMethodParameters_DebounceMethodPrescalars1");

            entity.HasOne(d => d.RemovedFaultPrescalar).WithMany(p => p.DebounceMethodParameterRemovedFaultPrescalars)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebounceMethodParameters_DebounceMethodPrescalars3");

            entity.HasOne(d => d.RemovedPrefaultPrescalar).WithMany(p => p.DebounceMethodParameterRemovedPrefaultPrescalars)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebounceMethodParameters_DebounceMethodPrescalars2");
        });

        modelBuilder.Entity<DebugDataDetail>(entity =>
        {
            entity.Property(e => e.DebugDataDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<DebugDisplacementConfiguration>(entity =>
        {
            entity.Property(e => e.DebugDisplacementConfigurationsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<DebugDisplacementConfigurationsDebugDataDetail>(entity =>
        {
            entity.HasOne(d => d.DebugDataDetails).WithMany(p => p.DebugDisplacementConfigurationsDebugDataDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebugDisplacementConfigurations_DebugDataDetails_DebugDataDetails");

            entity.HasOne(d => d.DebugDisplacementConfigurations).WithMany(p => p.DebugDisplacementConfigurationsDebugDataDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebugDisplacementConfigurations_DebugDataDetails_DebugDisplacementConfigurations");
        });

        modelBuilder.Entity<DebugPointerConfiguration>(entity =>
        {
            entity.Property(e => e.DebugPointerConfigurationsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<DebugPointerConfigurationsDebugDisplacementConfiguration>(entity =>
        {
            entity.HasOne(d => d.DebugDisplacementConfigurations).WithMany(p => p.DebugPointerConfigurationsDebugDisplacementConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebugPointerConfigurations_DebugDisplacementConfigurations_DebugDisplacementConfigurations");

            entity.HasOne(d => d.DebugPointerConfigurations).WithMany(p => p.DebugPointerConfigurationsDebugDisplacementConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebugPointerConfigurations_DebugDisplacementConfigurations_DebugPointerConfigurations");
        });

        modelBuilder.Entity<DefaultGpioPinType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<DefaultPinConfiguration>(entity =>
        {
            entity.Property(e => e.DefaultPinConfigurationId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<DefaultPinConfigurationsDefaultPinDetail>(entity =>
        {
            entity.HasOne(d => d.DefaultPinConfiguration).WithMany(p => p.DefaultPinConfigurationsDefaultPinDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DefaultPinConfigurations_DefaultPinDetails_DefaultPinConfigurations");

            entity.HasOne(d => d.DefaultPinDetail).WithMany(p => p.DefaultPinConfigurationsDefaultPinDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DefaultPinConfigurations_DefaultPinDetails_DefaultPinDetails");
        });

        modelBuilder.Entity<DefaultPinDetail>(entity =>
        {
            entity.Property(e => e.DefaultPinDetailId).ValueGeneratedNever();

            entity.HasOne(d => d.GpioPinType).WithMany(p => p.DefaultPinDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DefaultPinDetails_DefaultGpioPinTypes");
        });

        modelBuilder.Entity<DeprecatedMonitorWaterLevelThreshold>(entity =>
        {
            entity.Property(e => e.MonitorWaterLevelThresholdId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Display>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_Displays_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.DisplayId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Code).HasDefaultValueSql("('00000000000')");
            entity.Property(e => e.GoingToSleepTimeout).HasDefaultValueSql("((150))");
            entity.Property(e => e.NodeAddress).HasDefaultValueSql("((4))");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Brand).WithMany(p => p.Displays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Displays_Brands");

            entity.HasOne(d => d.DebugPointerConfigurations).WithMany(p => p.Displays).HasConstraintName("FK_Displays_DebugPointerConfigurations");

            entity.HasOne(d => d.FunctionConfiguration).WithMany(p => p.Displays).HasConstraintName("FK_Displays_UIFunctionConfigurations");

            entity.HasOne(d => d.GenericInputConfiguration).WithMany(p => p.Displays).HasConstraintName("FK_Displays_UIGenericInputConfigurations");

            entity.HasOne(d => d.HmiexpansionBoardConfigurations).WithMany(p => p.Displays).HasConstraintName("FK_Displays_HMIExpansionBoardConfigurations");

            entity.HasOne(d => d.LowLevelInputConfiguration).WithMany(p => p.Displays).HasConstraintName("FK_Displays_LowLevelInputConfigurations");

            entity.HasOne(d => d.NodeAddressNavigation).WithMany(p => p.Displays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Displays_HmiAvailableNodes");

            entity.HasOne(d => d.ProductVariantNavigation).WithMany(p => p.Displays).HasConstraintName("FK_Displays_CycleMappingProductVariants");

            entity.HasOne(d => d.SequenceConfiguration).WithMany(p => p.Displays).HasConstraintName("FK_Displays_UISequenceConfigurations");

            entity.HasOne(d => d.StatusVariables).WithMany(p => p.Displays).HasConstraintName("FK_Displays_StatusVariables");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.Displays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Displays_TableTargets");

            entity.HasOne(d => d.UianimationConfiguration).WithMany(p => p.Displays).HasConstraintName("FK_Displays_UIAnimationConfigurations");

            entity.HasOne(d => d.UiaudioConfiguration).WithMany(p => p.Displays).HasConstraintName("FK_Displays_UIAudioConfigurations");

            entity.HasOne(d => d.UidataModelTranslationConfiguration).WithMany(p => p.Displays).HasConstraintName("FK_Displays_UIDataModelTranslationConfigurations");

            entity.HasOne(d => d.UidefaultPinConfiguration).WithMany(p => p.Displays).HasConstraintName("FK_Displays_UIDefaultPinConfigurations");

            entity.HasOne(d => d.UiledGroupsConfigurations).WithMany(p => p.Displays).HasConstraintName("FK_Displays_UILedGroupsConfigurations");

            entity.HasOne(d => d.UilowPowerTime).WithMany(p => p.Displays).HasConstraintName("FK_Displays_UILowPowerTime");

            entity.HasOne(d => d.UisreventConfiguration).WithMany(p => p.Displays).HasConstraintName("FK_Displays_UISREventConfigurations");

            entity.HasOne(d => d.UitouchDevices).WithMany(p => p.Displays).HasConstraintName("FK_Displays_UITouchDevices");

            entity.HasOne(d => d.UiviewEngineControlStateConfigurations).WithMany(p => p.Displays).HasConstraintName("FK_Displays_UIViewEngineControlStateConfigurations");

            entity.HasOne(d => d.UiviewEngineViews).WithMany(p => p.Displays).HasConstraintName("FK_Displays_UIViewEngineViewsConfiguratios");

            entity.HasOne(d => d.VisualBoardType).WithMany(p => p.Displays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Displays_VisualBoardTypes");
        });

        modelBuilder.Entity<EepromCycleHeadingsExtendedView>(entity =>
        {
            entity.ToView("EepromCycleHeadingsExtendedView");
        });

        modelBuilder.Entity<EepromCycleHeadingsView>(entity =>
        {
            entity.ToView("EepromCycleHeadingsView");
        });

        modelBuilder.Entity<EepromCycleMappingView>(entity =>
        {
            entity.ToView("EepromCycleMappingView");
        });

        modelBuilder.Entity<EepromCycleMappingViewV2>(entity =>
        {
            entity.ToView("EepromCycleMappingViewV2");
        });

        modelBuilder.Entity<EepromCyclesView>(entity =>
        {
            entity.ToView("EepromCyclesView");
        });

        modelBuilder.Entity<EepromDelayStateCycleView>(entity =>
        {
            entity.ToView("EepromDelayStateCycleView");
        });

        modelBuilder.Entity<EepromDelayStateUicycleView>(entity =>
        {
            entity.ToView("EepromDelayStateUICycleView");
        });

        modelBuilder.Entity<EepromDelayUiselectorView>(entity =>
        {
            entity.ToView("EepromDelayUISelectorView");
        });

        modelBuilder.Entity<EepromEndStateCycleView>(entity =>
        {
            entity.ToView("EepromEndStateCycleView");
        });

        modelBuilder.Entity<EepromEndStateUicycleView>(entity =>
        {
            entity.ToView("EepromEndStateUICycleView");
        });

        modelBuilder.Entity<EepromEndUiselectorView>(entity =>
        {
            entity.ToView("EepromEndUISelectorView");
        });

        modelBuilder.Entity<EepromExpansionGenericInputConfigurationView>(entity =>
        {
            entity.ToView("EepromExpansionGenericInputConfigurationView");
        });

        modelBuilder.Entity<EepromExpansionLoadConfigurationView>(entity =>
        {
            entity.ToView("EepromExpansionLoadConfigurationView");
        });

        modelBuilder.Entity<EepromExpansionLowLevelInputConfigurationView>(entity =>
        {
            entity.ToView("EepromExpansionLowLevelInputConfigurationView");
        });

        modelBuilder.Entity<EepromExpansionUigenericInputConfigurationView>(entity =>
        {
            entity.ToView("EepromExpansionUIGenericInputConfigurationView");
        });

        modelBuilder.Entity<EepromExpansionUilowLevelInputConfigurationView>(entity =>
        {
            entity.ToView("EepromExpansionUILowLevelInputConfigurationView");
        });

        modelBuilder.Entity<EepromExpansionUisequenceConfigurationSupportView>(entity =>
        {
            entity.ToView("EepromExpansionUISequenceConfigurationSupportView");
        });

        modelBuilder.Entity<EepromExpansionUisequenceConfigurationView>(entity =>
        {
            entity.ToView("EepromExpansionUISequenceConfigurationView");
        });

        modelBuilder.Entity<EepromFaultSelectorView>(entity =>
        {
            entity.ToView("EepromFaultSelectorView");
        });

        modelBuilder.Entity<EepromGenericInputConfigurationView>(entity =>
        {
            entity.ToView("EepromGenericInputConfigurationView");
        });

        modelBuilder.Entity<EepromLoadConfigurationView>(entity =>
        {
            entity.ToView("EepromLoadConfigurationView");
        });

        modelBuilder.Entity<EepromLowLevelInputConfigurationView>(entity =>
        {
            entity.ToView("EepromLowLevelInputConfigurationView");
        });

        modelBuilder.Entity<EepromMainSelectorView>(entity =>
        {
            entity.ToView("EepromMainSelectorView");
        });

        modelBuilder.Entity<EepromOffselectorView>(entity =>
        {
            entity.ToView("EepromOFFSelectorView");
        });

        modelBuilder.Entity<EepromOffuiselectorView>(entity =>
        {
            entity.ToView("EepromOFFUISelectorView");
        });

        modelBuilder.Entity<EepromPauseStateCycleView>(entity =>
        {
            entity.ToView("EepromPauseStateCycleView");
        });

        modelBuilder.Entity<EepromPauseStateUicycleView>(entity =>
        {
            entity.ToView("EepromPauseStateUICycleView");
        });

        modelBuilder.Entity<EepromPauseUiselectorView>(entity =>
        {
            entity.ToView("EepromPauseUISelectorView");
        });

        modelBuilder.Entity<EepromProgrammingStateCycleView>(entity =>
        {
            entity.ToView("EepromProgrammingStateCycleView");
        });

        modelBuilder.Entity<EepromProgrammingStateUicycleView>(entity =>
        {
            entity.ToView("EepromProgrammingStateUICycleView");
        });

        modelBuilder.Entity<EepromProgrammingUiselectorView>(entity =>
        {
            entity.ToView("EepromProgrammingUISelectorView");
        });

        modelBuilder.Entity<EepromSortedFaulIdlistView>(entity =>
        {
            entity.ToView("EepromSortedFaulIDListView");
        });

        modelBuilder.Entity<EepromStateSelectorView>(entity =>
        {
            entity.ToView("EepromStateSelectorView");
        });

        modelBuilder.Entity<EepromStateUiselectorView>(entity =>
        {
            entity.ToView("EepromStateUISelectorView");
        });

        modelBuilder.Entity<EepromStatusVariableView>(entity =>
        {
            entity.ToView("EepromStatusVariableView");
        });

        modelBuilder.Entity<EepromTimeEstimationDetailsView>(entity =>
        {
            entity.ToView("EepromTimeEstimationDetailsView");
        });

        modelBuilder.Entity<EepromUicycleSelectorView>(entity =>
        {
            entity.ToView("EepromUICycleSelectorView");
        });

        modelBuilder.Entity<EepromUifunctionConfigurationView>(entity =>
        {
            entity.ToView("EepromUIFunctionConfigurationView");
        });

        modelBuilder.Entity<EepromUigenericInputConfigurationView>(entity =>
        {
            entity.ToView("EepromUIGenericInputConfigurationView");
        });

        modelBuilder.Entity<EepromUiglobalSelectorView>(entity =>
        {
            entity.ToView("EepromUIGlobalSelectorView");
        });

        modelBuilder.Entity<EepromUilowLevelInputConfigurationView>(entity =>
        {
            entity.ToView("EepromUILowLevelInputConfigurationView");
        });

        modelBuilder.Entity<EepromUiproductConfigurationFaultCodesView>(entity =>
        {
            entity.ToView("EepromUIProductConfigurationFaultCodesView");
        });

        modelBuilder.Entity<EepromUiselectorView>(entity =>
        {
            entity.ToView("EepromUISelectorView");
        });

        modelBuilder.Entity<EepromUisequenceConfigurationSupportView>(entity =>
        {
            entity.ToView("EepromUISequenceConfigurationSupportView");
        });

        modelBuilder.Entity<EepromUisequenceConfigurationView>(entity =>
        {
            entity.ToView("EepromUISequenceConfigurationView");
        });

        modelBuilder.Entity<EepromUiuserFunctionConfigurationView>(entity =>
        {
            entity.ToView("EepromUIUserFunctionConfigurationView");
        });

        modelBuilder.Entity<EmptyPotDetectionCoilConfig>(entity =>
        {
            entity.Property(e => e.EmptyPotDetectionCoilConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmptyPotDetectionCoilSafetyParam>(entity =>
        {
            entity.Property(e => e.EmptyPotDetectionCoilSafetyParamsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmptyPotDetectionConfig>(entity =>
        {
            entity.Property(e => e.EmptyPotDetectionConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Factory>(entity =>
        {
            entity.Property(e => e.FactoryCode).IsFixedLength();
        });

        modelBuilder.Entity<FaultConfiguration>(entity =>
        {
            entity.Property(e => e.FaultConfigurationsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<FaultConfigurationsFaultDetail>(entity =>
        {
            entity.HasOne(d => d.FaultConfigurations).WithMany(p => p.FaultConfigurationsFaultDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FaultConfigurations_FaultDetails_FaultConfigurations");

            entity.HasOne(d => d.FaultDetails).WithMany(p => p.FaultConfigurationsFaultDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FaultConfigurations_FaultDetails_FaultDetails");
        });

        modelBuilder.Entity<FaultDetail>(entity =>
        {
            entity.Property(e => e.FaultDetailsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.DebounceParameters).WithMany(p => p.FaultDetails).HasConstraintName("FK_FaultDetails_DebounceMethodParameters");

            entity.HasOne(d => d.Macro).WithMany(p => p.FaultDetails).HasConstraintName("FK_FaultDetails_Macros");

            entity.HasOne(d => d.Target).WithMany(p => p.FaultDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FaultDetails_Targets");
        });

        modelBuilder.Entity<FaultPrmFanOverSpeedFailure>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<FaultPrmFanStalledFailure>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<FaultPrmMeatProbeFailure>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<FaultPrmOverTemperatureFailure>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<FaultPrmRelayLoadFailure>(entity =>
        {
            entity.Property(e => e.FaultPrmRelayLoadFailureId).ValueGeneratedNever();
        });

        modelBuilder.Entity<FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition>(entity =>
        {
            entity.HasOne(d => d.FaultCondition).WithMany(p => p.FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FaultPrmRelayLoadFailure_FaultRelayLoadFailureFaultCondition_FaultRelayLoadFailureFaultCondition");

            entity.HasOne(d => d.FaultPrmRelayLoadFailure).WithMany(p => p.FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FaultPrmRelayLoadFailure_FaultRelayLoadFailureFaultCondition_FaultPrmRelayLoadFailure");
        });

        modelBuilder.Entity<FaultPrmTemperatureOpenShortFailure>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<FaultPrmTemperatureSensorOpenedFailure>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<FaultRelayLoadFailureFaultCondition>(entity =>
        {
            entity.Property(e => e.FaultConditionId).ValueGeneratedNever();
        });

        modelBuilder.Entity<FaultSubCode>(entity =>
        {
            entity.HasOne(d => d.FaultCodeNavigation).WithMany(p => p.FaultSubCodes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FaultSubCodes_FaultCodes");
        });

        modelBuilder.Entity<FeedbackParameter>(entity =>
        {
            entity.Property(e => e.FeedbackParametersId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<FkView>(entity =>
        {
            entity.ToView("FK_View");
        });

        modelBuilder.Entity<Flag>(entity =>
        {
            entity.Property(e => e.BitSize).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Variable).WithMany(p => p.Flags)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Flags_Variables");
        });

        modelBuilder.Entity<Function>(entity =>
        {
            entity.HasKey(e => e.FunctionId).HasName("PK_Functions_1");

            entity.Property(e => e.DataType).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<GenericInputConfiguration>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_GenericInputConfigurations_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.GenericInputConfigurationId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.GenericInputConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GenericInputConfigurations_TableTargets");
        });

        modelBuilder.Entity<GenericInputConfigurationsGenericInputDetail>(entity =>
        {
            entity.HasOne(d => d.GenericInputConfiguration).WithMany(p => p.GenericInputConfigurationsGenericInputDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GenericInputConfigurations_GenericInputDetails_GenericInputConfigurations");

            entity.HasOne(d => d.GenericInputDetail).WithMany(p => p.GenericInputConfigurationsGenericInputDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GenericInputConfigurations_GenericInputDetails_GenericInputDetails");
        });

        modelBuilder.Entity<GenericInputDetail>(entity =>
        {
            entity.HasKey(e => e.GenericInputDetailId).HasName("PK_GenericInputDetails_1");

            entity.Property(e => e.GenericInputDetailId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Input).WithMany(p => p.GenericInputDetails).HasConstraintName("FK_GenericInputDetails_Inputs");

            entity.HasOne(d => d.ReadType).WithMany(p => p.GenericInputDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GenericInputDetails_ReadTypes");
        });

        modelBuilder.Entity<HeatConvectionFanParameter>(entity =>
        {
            entity.HasKey(e => e.ConvectionFanId).HasName("PK_ConvectionFanParameters");

            entity.Property(e => e.ConvectionFanId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<HeatInitialize>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StmHeatInitialize");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<HeatLoadBalancingClosedLoop>(entity =>
        {
            entity.HasKey(e => e.LbclosedLoopId).HasName("PK_HeatLBLoadBalancingClosedLoop");

            entity.Property(e => e.LbclosedLoopId).ValueGeneratedNever();
            entity.Property(e => e.NumberOfLoads).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.ConvectionFan1).WithMany(p => p.HeatLoadBalancingClosedLoopConvectionFan1s).HasConstraintName("FK_HeatLoadBalancingClosedLoop_HeatConvectionFanParameters");

            entity.HasOne(d => d.ConvectionFan2).WithMany(p => p.HeatLoadBalancingClosedLoopConvectionFan2s).HasConstraintName("FK_HeatLoadBalancingClosedLoop_HeatConvectionFanParameters1");
        });

        modelBuilder.Entity<HeatLoadBalancingOpenLoop>(entity =>
        {
            entity.HasKey(e => e.LbopenLoopId).HasName("PK_HeatLBLoadBalancingOpenLoop");

            entity.Property(e => e.LbopenLoopId).ValueGeneratedNever();
            entity.Property(e => e.NumberOfLoads).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<HeatLoadBalancingParameter>(entity =>
        {
            entity.HasKey(e => e.LoadBalancingId).HasName("PK_LoadBalanceParameters");

            entity.Property(e => e.LoadBalancingId).ValueGeneratedNever();
            entity.Property(e => e.NumberOfLoads).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<HeatPidConfigurationParameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PidConfiguartionParameters");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<HighStatement>(entity =>
        {
            entity.HasKey(e => e.HighStatementId).HasName("PK_HighStatements_1");

            entity.Property(e => e.HighStatementId).ValueGeneratedNever();
        });

        modelBuilder.Entity<HmiexpansionBoardConfiguration>(entity =>
        {
            entity.Property(e => e.HmiexpansionBoardConfigurationId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<HmiexpansionBoardConfigurationsDisplay>(entity =>
        {
            entity.HasOne(d => d.Display).WithMany(p => p.HmiexpansionBoardConfigurationsDisplays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HMIExpansionBoardConfigurations_Displays_Displays");

            entity.HasOne(d => d.HmiexpansionBoardConfiguration).WithMany(p => p.HmiexpansionBoardConfigurationsDisplays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HMIExpansionBoardConfigurations_Displays_HMIExpansionBoardConfigurations");
        });

        modelBuilder.Entity<InductionCoilChannel>(entity =>
        {
            entity.HasKey(e => e.CoilChannelId).HasName("PK_InductionInverterChannelCoilConfigurations");

            entity.Property(e => e.CoilChannelId).ValueGeneratedNever();

            entity.HasOne(d => d.CoilPowerTable).WithMany(p => p.InductionCoilChannels).HasConstraintName("FK_InductionInverterChannelCoilConfigurations_InductionCoilChannels");

            entity.HasOne(d => d.CoilTypeNavigation).WithMany(p => p.InductionCoilChannels)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InductionCoilChannels_InductionCoilTypes");
        });

        modelBuilder.Entity<InductionCoilConfig>(entity =>
        {
            entity.Property(e => e.InductionCoilConfigId).ValueGeneratedNever();
            entity.Property(e => e.Acntcgiid).HasDefaultValueSql("((255))");
            entity.Property(e => e.CoilLoadId).HasDefaultValueSql("((255))");
            entity.Property(e => e.CoilNtcgiid).HasDefaultValueSql("((255))");
            entity.Property(e => e.HeatsinkFanLoadId).HasDefaultValueSql("((255))");
            entity.Property(e => e.HeatsinkNtcgiid).HasDefaultValueSql("((255))");
            entity.Property(e => e.IgbtTemperatureGiid).HasDefaultValueSql("((255))");

            entity.HasOne(d => d.Acntcspecific).WithMany(p => p.InductionCoilConfigAcntcspecifics).HasConstraintName("FK_InductionCoilConfig_InductionCoilNTCSpecific1");

            entity.HasOne(d => d.CoilNtcspecific).WithMany(p => p.InductionCoilConfigCoilNtcspecifics).HasConstraintName("FK_InductionCoilConfig_InductionCoilNTCSpecific2");

            entity.HasOne(d => d.CoilSripcsafety).WithMany(p => p.InductionCoilConfigs).HasConstraintName("FK_InductionCoilConfig_InductionCoilSRIPCSafety");

            entity.HasOne(d => d.EmptyPotDetectionCoilSafetyParams).WithMany(p => p.InductionCoilConfigs).HasConstraintName("FK_InductionCoilConfig_EmptyPotDetectionCoilSafetyParams");

            entity.HasOne(d => d.IgbtSafetyParams).WithMany(p => p.InductionCoilConfigIgbtSafetyParams).HasConstraintName("FK_InductionCoilConfig_InductionCoilNTCSpecific3");

            entity.HasOne(d => d.InductionCoilHeatsinkNtcspecific).WithMany(p => p.InductionCoilConfigInductionCoilHeatsinkNtcspecifics).HasConstraintName("FK_InductionCoilConfig_InductionCoilNTCSpecific");

            entity.HasOne(d => d.InductionCoilPowerTableConfig).WithMany(p => p.InductionCoilConfigs).HasConstraintName("FK_InductionCoilConfig_InductionCoilPowerTableConfigurations");

            entity.HasOne(d => d.InductionCoilSpecific).WithMany(p => p.InductionCoilConfigs).HasConstraintName("FK_InductionCoilConfig_InductionCoilSpecific");

            entity.HasOne(d => d.InductionInverterSpecificData).WithMany(p => p.InductionCoilConfigs).HasConstraintName("FK_InductionCoilConfig_InductionInverterSpecificData");
        });

        modelBuilder.Entity<InductionCoilInformationView>(entity =>
        {
            entity.ToView("InductionCoilInformationView");
        });

        modelBuilder.Entity<InductionCoilNtcspecific>(entity =>
        {
            entity.HasKey(e => e.InductionCoilNtcspecificId).HasName("PK_InductionCoilHeatsinkNTCSpecific");

            entity.Property(e => e.InductionCoilNtcspecificId).ValueGeneratedNever();
            entity.Property(e => e.OpenDebounceTime).HasDefaultValueSql("((3.0))");
            entity.Property(e => e.OpenThresholdMin).HasDefaultValueSql("((3072))");
            entity.Property(e => e.SafetyDebounceTime).HasDefaultValueSql("((1.0))");
            entity.Property(e => e.SafetyHysteresis).HasDefaultValueSql("((512))");
            entity.Property(e => e.SafetyHysteresisCelsius).HasDefaultValueSql("((5))");
            entity.Property(e => e.SafetyThreshold).HasDefaultValueSql("((2048))");
            entity.Property(e => e.ShortDebounceTime).HasDefaultValueSql("((5.0))");
            entity.Property(e => e.ShortThresholdMax).HasDefaultValueSql("((1023))");
            entity.Property(e => e.StuckExitDelta).HasDefaultValueSql("((512))");
            entity.Property(e => e.StuckExitDeltaCelsius).HasDefaultValueSql("((0.5))");
            entity.Property(e => e.StuckValidationTime).HasDefaultValueSql("((30))");
            entity.Property(e => e.StuckWindowMax).HasDefaultValueSql("((3071))");
            entity.Property(e => e.StuckWindowMin).HasDefaultValueSql("((1024))");
        });

        modelBuilder.Entity<InductionCoilPowerTableConfiguration>(entity =>
        {
            entity.Property(e => e.InductionCoilPowerTableConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail>(entity =>
        {
            entity.HasOne(d => d.InductionCoilPowerTableConfig).WithMany(p => p.InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InductionCoilPowerTableConfigurations_InductionCoilPowerTableDetails_InductionCoilPowerTableConfigurations");

            entity.HasOne(d => d.InductionCoilPowerTableDetail).WithMany(p => p.InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InductionCoilPowerTableConfigurations_InductionCoilPowerTableDetails_InductionCoilPowerTableDetails");
        });

        modelBuilder.Entity<InductionCoilPowerTableDetail>(entity =>
        {
            entity.Property(e => e.InductionCoilPowerTableDetailId).ValueGeneratedNever();
        });

        modelBuilder.Entity<InductionCoilSpecific>(entity =>
        {
            entity.Property(e => e.InductionCoilSpecificId).ValueGeneratedNever();
            entity.Property(e => e.BoosterPowerThreshold).HasDefaultValueSql("((5000))");
            entity.Property(e => e.MaxCurrentBooster).HasDefaultValueSql("((2000))");
            entity.Property(e => e.MaxCurrentNormal).HasDefaultValueSql("((2000))");
            entity.Property(e => e.MaxNominalIgbtPeakTurnOffCurrent).HasDefaultValueSql("((90))");
            entity.Property(e => e.MaxNominalIgbtPeakTurnOffCurrentBooster).HasDefaultValueSql("((90))");
            entity.Property(e => e.PanettoneElectricThreshold).HasDefaultValueSql("((1155))");
        });

        modelBuilder.Entity<InductionCoilSripcsafety>(entity =>
        {
            entity.Property(e => e.CoilSripcsafetyId).ValueGeneratedNever();
            entity.Property(e => e.CoverageAcceptance).HasDefaultValueSql("((0.070))");
            entity.Property(e => e.CoverageMove).HasDefaultValueSql("((0.100))");
            entity.Property(e => e.CoverageRejection).HasDefaultValueSql("((0.060))");
        });

        modelBuilder.Entity<InductionCooktopOrgConfiguration>(entity =>
        {
            entity.HasKey(e => e.CooktopOrgConfigurationId).HasName("PK_InductionCooktopOrganizationConfigurations");

            entity.Property(e => e.CooktopOrgConfigurationId).ValueGeneratedNever();
        });

        modelBuilder.Entity<InductionCooktopOrgConfigurationsInductionIpcdetail>(entity =>
        {
            entity.HasOne(d => d.CooktopOrgConfiguration).WithMany(p => p.InductionCooktopOrgConfigurationsInductionIpcdetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InductionCooktopOrgConfigurations_InductionIPCDetails_InductionCooktopOrgConfigurations");

            entity.HasOne(d => d.InductionIpc).WithMany(p => p.InductionCooktopOrgConfigurationsInductionIpcdetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InductionCooktopOrgConfigurations_InductionIPCDetails_InductionIPCDetails");
        });

        modelBuilder.Entity<InductionInverterChannelConfiguration>(entity =>
        {
            entity.HasKey(e => e.InverterChannelId).HasName("PK_InductionInverterChannel");

            entity.Property(e => e.InverterChannelId).ValueGeneratedNever();

            entity.HasOne(d => d.CoilChannel0).WithMany(p => p.InductionInverterChannelConfigurationCoilChannel0s).HasConstraintName("FK_InductionInverterChannelConfiguration_InductionCoilChannels");

            entity.HasOne(d => d.CoilChannel1).WithMany(p => p.InductionInverterChannelConfigurationCoilChannel1s).HasConstraintName("FK_InductionInverterChannelConfiguration_InductionCoilChannels1");
        });

        modelBuilder.Entity<InductionInverterSpecificDatum>(entity =>
        {
            entity.Property(e => e.InductionInverterSpecificDataId).ValueGeneratedNever();
        });

        modelBuilder.Entity<InductionIpcSpecificDatum>(entity =>
        {
            entity.Property(e => e.InductionIpcSpecificDataId).ValueGeneratedNever();
        });

        modelBuilder.Entity<InductionIpcdetail>(entity =>
        {
            entity.Property(e => e.InductionIpcid).ValueGeneratedNever();
            entity.Property(e => e.HeatsinkFanLoadIndex).HasDefaultValueSql("((255))");

            entity.HasOne(d => d.InductionIpcSpecificData).WithMany(p => p.InductionIpcdetails).HasConstraintName("FK_InductionIPCDetails_InductionIpcSpecificData");

            entity.HasOne(d => d.IpcSpecificSafetyParams).WithMany(p => p.InductionIpcdetails).HasConstraintName("FK_InductionIPCDetails_IpcSpecificSafetyParams");

            entity.HasOne(d => d.ZeroCrossChannel0).WithMany(p => p.InductionIpcdetailZeroCrossChannel0s).HasConstraintName("FK_InductionIPCDetails_InductionZeroCrossConfiguration");

            entity.HasOne(d => d.ZeroCrossChannel1).WithMany(p => p.InductionIpcdetailZeroCrossChannel1s).HasConstraintName("FK_InductionIPCDetails_InductionZeroCrossConfiguration1");

            entity.HasOne(d => d.ZeroCrossChannel2).WithMany(p => p.InductionIpcdetailZeroCrossChannel2s).HasConstraintName("FK_InductionIPCDetails_InductionZeroCrossConfiguration2");
        });

        modelBuilder.Entity<InductionIpcdetailsInductionCoilConfig>(entity =>
        {
            entity.HasOne(d => d.InductionCoilConfig).WithMany(p => p.InductionIpcdetailsInductionCoilConfigs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InductionIPCDetails_InductionCoilConfig_InductionCoilConfig");

            entity.HasOne(d => d.InductionIpc).WithMany(p => p.InductionIpcdetailsInductionCoilConfigs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InductionIPCDetails_InductionCoilConfig_InductionIPCDetails");
        });

        modelBuilder.Entity<InductionIsofrequencyConfiguration>(entity =>
        {
            entity.Property(e => e.InductionIsofreqConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<InductionIsofrequencyConfigurationsInductionIsofrequencyDetail>(entity =>
        {
            entity.HasOne(d => d.InductionIsofreqConfig).WithMany(p => p.InductionIsofrequencyConfigurationsInductionIsofrequencyDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InductionIsofrequencyConfigurations_InductionIsofrequencyDetails_InductionIsofrequencyConfigurations");

            entity.HasOne(d => d.InductionIsofreqDetails).WithMany(p => p.InductionIsofrequencyConfigurationsInductionIsofrequencyDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InductionIsofrequencyConfigurations_InductionIsofrequencyDetails_InductionIsofrequencyDetails");
        });

        modelBuilder.Entity<InductionIsofrequencyDetail>(entity =>
        {
            entity.HasKey(e => e.InductionIsofreqDetailsId).HasName("PK_InductionIsofrequencyCoilDetails");

            entity.Property(e => e.InductionIsofreqDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<InductionThermalNodeConfiguration>(entity =>
        {
            entity.Property(e => e.InductionThermalNodeConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<InductionZeroCrossConfiguration>(entity =>
        {
            entity.Property(e => e.ZeroCrossConfigId).ValueGeneratedNever();

            entity.HasOne(d => d.InverterChannel0).WithMany(p => p.InductionZeroCrossConfigurationInverterChannel0s).HasConstraintName("FK_InductionZeroCrossConfiguration_InductionInverterChannelConfiguration");

            entity.HasOne(d => d.InverterChannel1).WithMany(p => p.InductionZeroCrossConfigurationInverterChannel1s).HasConstraintName("FK_InductionZeroCrossConfiguration_InductionInverterChannelConfiguration1");
        });

        modelBuilder.Entity<Input>(entity =>
        {
            entity.HasOne(d => d.InputType).WithMany(p => p.Inputs).HasConstraintName("FK_Inputs_InputTypes");

            entity.HasMany(d => d.InputGroups).WithMany(p => p.Inputs)
                .UsingEntity<Dictionary<string, object>>(
                    "InputsInputGroup",
                    r => r.HasOne<InputGroup>().WithMany()
                        .HasForeignKey("InputGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Inputs_InputGroups_InputGroups"),
                    l => l.HasOne<Input>().WithMany()
                        .HasForeignKey("InputId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Inputs_InputGroups_Inputs"),
                    j =>
                    {
                        j.HasKey("InputId", "InputGroupId");
                        j.ToTable("Inputs_InputGroups");
                    });
        });

        modelBuilder.Entity<InputToInputGroupView>(entity =>
        {
            entity.ToView("InputToInputGroupView");
        });

        modelBuilder.Entity<InputTypesReadType>(entity =>
        {
            entity.HasOne(d => d.InputType).WithMany(p => p.InputTypesReadTypes).HasConstraintName("FK_InputTypes_ReadTypes_InputTypes");

            entity.HasOne(d => d.ReadType).WithMany(p => p.InputTypesReadTypes).HasConstraintName("FK_InputTypes_ReadTypes_ReadTypes");
        });

        modelBuilder.Entity<InverterConfigDatum>(entity =>
        {
            entity.Property(e => e.InverterConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<IpcControllerCoilConfiguration>(entity =>
        {
            entity.Property(e => e.IpcControllerCoilConfigurationsId).ValueGeneratedNever();

            entity.HasOne(d => d.HeatsinkThermalNodeConfig).WithMany(p => p.IpcControllerCoilConfigurationHeatsinkThermalNodeConfigs).HasConstraintName("FK_IpcControllerCoilConfigurations_HeatsinkThermalNodeConfig");

            entity.HasOne(d => d.IpcFanConfig).WithMany(p => p.IpcControllerCoilConfigurations).HasConstraintName("FK_IpcControllerCoilConfigurations_IpcFanConfigData");

            entity.HasOne(d => d.MicroThermalNodeConfig).WithMany(p => p.IpcControllerCoilConfigurationMicroThermalNodeConfigs).HasConstraintName("FK_IpcControllerCoilConfigurations_MicroThermalNodeConfig");
        });

        modelBuilder.Entity<IpcControllerCoilConfigurationsIpcControllerCoilDetail>(entity =>
        {
            entity.HasOne(d => d.IpcControllerCoilConfigurations).WithMany(p => p.IpcControllerCoilConfigurationsIpcControllerCoilDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IpcControllerCoilConfigurations_IpcControllerCoilDetails_IpcControllerCoilConfigurations");

            entity.HasOne(d => d.IpcControllerCoilDetails).WithMany(p => p.IpcControllerCoilConfigurationsIpcControllerCoilDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IpcControllerCoilConfigurations_IpcControllerCoilDetails_IpcControllerCoilDetails");
        });

        modelBuilder.Entity<IpcControllerCoilDetail>(entity =>
        {
            entity.Property(e => e.IpcControllerCoilDetailsId).ValueGeneratedNever();

            entity.HasOne(d => d.CoilCenterThermalNodeConfig).WithMany(p => p.IpcControllerCoilDetailCoilCenterThermalNodeConfigs).HasConstraintName("FK_IpcControllerCoilDetails_InductionThermalNodeConfiguration2");

            entity.HasOne(d => d.CoilGapThermalNodeConfig).WithMany(p => p.IpcControllerCoilDetailCoilGapThermalNodeConfigs).HasConstraintName("FK_IpcControllerCoilDetails_InductionThermalNodeConfiguration1");

            entity.HasOne(d => d.CoilSpecificConfig).WithMany(p => p.IpcControllerCoilDetails).HasConstraintName("FK_IpcControllerCoilDetails_CoilSpecificConfigData");

            entity.HasOne(d => d.EmptyPotDetectionCoilConfig).WithMany(p => p.IpcControllerCoilDetails).HasConstraintName("FK_IpcControllerCoilDetails_EmptyPotDetectionCoilConfig");

            entity.HasOne(d => d.IgbtThermalNodeConfig).WithMany(p => p.IpcControllerCoilDetailIgbtThermalNodeConfigs).HasConstraintName("FK_IpcControllerCoilDetails_InductionThermalNodeConfiguration");

            entity.HasOne(d => d.InverterConfig).WithMany(p => p.IpcControllerCoilDetails).HasConstraintName("FK_IpcControllerCoilDetails_InverterConfigData");
        });

        modelBuilder.Entity<IpcControllerConfiguration>(entity =>
        {
            entity.HasKey(e => e.IpcControllerConfigurationsId).HasName("PK_IpcControllerConfigurations_1");

            entity.Property(e => e.IpcControllerConfigurationsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<IpcControllerConfigurationsIpcControllerIpcConfiguration>(entity =>
        {
            entity.HasOne(d => d.IpcControllerConfigurations).WithMany(p => p.IpcControllerConfigurationsIpcControllerIpcConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IpcControllerConfigurations_IpcControllerIpcConfigurations_IpcControllerConfigurations");

            entity.HasOne(d => d.IpcControllerIpcConfigurations).WithMany(p => p.IpcControllerConfigurationsIpcControllerIpcConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IpcControllerConfigurations_IpcControllerIpcConfigurations_IpcControllerIpcConfigurations");
        });

        modelBuilder.Entity<IpcControllerIpcConfiguration>(entity =>
        {
            entity.Property(e => e.IpcControllerIpcConfigurationsId).ValueGeneratedNever();

            entity.HasOne(d => d.AssistedCookingConfig).WithMany(p => p.IpcControllerIpcConfigurations).HasConstraintName("FK_IpcControllerIpcConfigurations_AssistedCookingConfigData");

            entity.HasOne(d => d.CoilOperationConfig).WithMany(p => p.IpcControllerIpcConfigurations).HasConstraintName("FK_IpcControllerIpcConfigurations_CoilOperationConfigData");

            entity.HasOne(d => d.EmptyPotDetectionConfig).WithMany(p => p.IpcControllerIpcConfigurations).HasConstraintName("FK_IpcControllerIpcConfigurations_EmptyPotDetectionConfig");

            entity.HasOne(d => d.MainsLineConfig).WithMany(p => p.IpcControllerIpcConfigurations).HasConstraintName("FK_IpcControllerIpcConfigurations_MainsLineConfigData");

            entity.HasOne(d => d.PowerDeliveryConfig).WithMany(p => p.IpcControllerIpcConfigurations).HasConstraintName("FK_IpcControllerIpcConfigurations_PowerDeliveryConfigData");

            entity.HasOne(d => d.ThermalConfig).WithMany(p => p.IpcControllerIpcConfigurations).HasConstraintName("FK_IpcControllerIpcConfigurations_ThermalConfigData");
        });

        modelBuilder.Entity<IpcControllerIpcConfigurationsIpcControllerCoilConfiguration>(entity =>
        {
            entity.HasOne(d => d.IpcControllerCoilConfigurations).WithMany(p => p.IpcControllerIpcConfigurationsIpcControllerCoilConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IpcControllerIpcConfigurations_IpcControllerCoilConfigurations_IpcControllerCoilConfigurations");

            entity.HasOne(d => d.IpcControllerIpcConfigurations).WithMany(p => p.IpcControllerIpcConfigurationsIpcControllerCoilConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IpcControllerIpcConfigurations_IpcControllerCoilConfigurations_IpcControllerIpcConfigurations");
        });

        modelBuilder.Entity<IpcFanConfigDatum>(entity =>
        {
            entity.Property(e => e.IpcFanConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<IpcSpecificSafetyParam>(entity =>
        {
            entity.Property(e => e.IpcSpecificSafetyParamsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Load>(entity =>
        {
            entity.HasOne(d => d.LoadType).WithMany(p => p.Loads).HasConstraintName("FK_Loads_LoadTypes");

            entity.HasMany(d => d.LoadGroups).WithMany(p => p.Loads)
                .UsingEntity<Dictionary<string, object>>(
                    "LoadsLoadGroup",
                    r => r.HasOne<LoadGroup>().WithMany()
                        .HasForeignKey("LoadGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Loads_LoadGroups_LoadGroups"),
                    l => l.HasOne<Load>().WithMany()
                        .HasForeignKey("LoadId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Loads_LoadGroups_Loads"),
                    j =>
                    {
                        j.HasKey("LoadId", "LoadGroupId");
                        j.ToTable("Loads_LoadGroups");
                    });
        });

        modelBuilder.Entity<LoadConfiguration>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_LoadConfigurations_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.LoadConfigurationId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.LoadConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoadConfigurations_TableTargets");
        });

        modelBuilder.Entity<LoadConfigurationsLoadDetail>(entity =>
        {
            entity.HasKey(e => new { e.LoadConfigurationId, e.LoadDetailId, e.Index }).HasName("PK_LoadConfigurations_Loads");

            entity.HasOne(d => d.LoadConfiguration).WithMany(p => p.LoadConfigurationsLoadDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoadConfigurations_LoadDetails_LoadConfigurations");

            entity.HasOne(d => d.LoadDetail).WithMany(p => p.LoadConfigurationsLoadDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoadConfigurations_LoadDetails_LoadDetails");
        });

        modelBuilder.Entity<LoadDetail>(entity =>
        {
            entity.Property(e => e.LoadDetailId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.FeedbackParameters).WithMany(p => p.LoadDetails).HasConstraintName("FK_LoadDetails_FeedbackParameters");

            entity.HasOne(d => d.Load).WithMany(p => p.LoadDetails).HasConstraintName("FK_LoadDetails_Loads");

            entity.HasOne(d => d.PilotType).WithMany(p => p.LoadDetails).HasConstraintName("FK_LoadDetails_PilotTypes");
        });

        modelBuilder.Entity<LoadToLoadGroupView>(entity =>
        {
            entity.ToView("LoadToLoadGroupView");
        });

        modelBuilder.Entity<LoadType>(entity =>
        {
            entity.HasMany(d => d.PilotTypes).WithMany(p => p.LoadTypes)
                .UsingEntity<Dictionary<string, object>>(
                    "LoadTypesPilotType",
                    r => r.HasOne<PilotType>().WithMany()
                        .HasForeignKey("PilotTypeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LoadTypes_PilotTypes_PilotTypes"),
                    l => l.HasOne<LoadType>().WithMany()
                        .HasForeignKey("LoadTypeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LoadTypes_PilotTypes_LoadTypes"),
                    j =>
                    {
                        j.HasKey("LoadTypeId", "PilotTypeId");
                        j.ToTable("LoadTypes_PilotTypes");
                    });
        });

        modelBuilder.Entity<LoadsControlPilotParameter>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.LoadId0Navigation).WithMany(p => p.LoadsControlPilotParameterLoadId0Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Loads");

            entity.HasOne(d => d.LoadId1Navigation).WithMany(p => p.LoadsControlPilotParameterLoadId1Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Loads1");

            entity.HasOne(d => d.LoadId2Navigation).WithMany(p => p.LoadsControlPilotParameterLoadId2Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Loads2");

            entity.HasOne(d => d.LoadId3Navigation).WithMany(p => p.LoadsControlPilotParameterLoadId3Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Loads3");

            entity.HasOne(d => d.LoadId4Navigation).WithMany(p => p.LoadsControlPilotParameterLoadId4Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Loads4");

            entity.HasOne(d => d.LoadId5Navigation).WithMany(p => p.LoadsControlPilotParameterLoadId5Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Loads5");

            entity.HasOne(d => d.LoadId6Navigation).WithMany(p => p.LoadsControlPilotParameterLoadId6Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Loads6");

            entity.HasOne(d => d.LoadId7Navigation).WithMany(p => p.LoadsControlPilotParameterLoadId7Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Loads7");

            entity.HasOne(d => d.LoadId8Navigation).WithMany(p => p.LoadsControlPilotParameterLoadId8Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Loads8");

            entity.HasOne(d => d.LoadId9Navigation).WithMany(p => p.LoadsControlPilotParameterLoadId9Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Loads9");

            entity.HasOne(d => d.LoadModifierId0Navigation).WithMany(p => p.LoadsControlPilotParameterLoadModifierId0Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Modifiers");

            entity.HasOne(d => d.LoadModifierId1Navigation).WithMany(p => p.LoadsControlPilotParameterLoadModifierId1Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Modifiers1");

            entity.HasOne(d => d.LoadModifierId2Navigation).WithMany(p => p.LoadsControlPilotParameterLoadModifierId2Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Modifiers2");

            entity.HasOne(d => d.LoadModifierId3Navigation).WithMany(p => p.LoadsControlPilotParameterLoadModifierId3Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Modifiers3");

            entity.HasOne(d => d.LoadModifierId4Navigation).WithMany(p => p.LoadsControlPilotParameterLoadModifierId4Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Modifiers4");

            entity.HasOne(d => d.LoadModifierId5Navigation).WithMany(p => p.LoadsControlPilotParameterLoadModifierId5Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Modifiers5");

            entity.HasOne(d => d.LoadModifierId6Navigation).WithMany(p => p.LoadsControlPilotParameterLoadModifierId6Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Modifiers6");

            entity.HasOne(d => d.LoadModifierId7Navigation).WithMany(p => p.LoadsControlPilotParameterLoadModifierId7Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Modifiers7");

            entity.HasOne(d => d.LoadModifierId8Navigation).WithMany(p => p.LoadsControlPilotParameterLoadModifierId8Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Modifiers8");

            entity.HasOne(d => d.LoadModifierId9Navigation).WithMany(p => p.LoadsControlPilotParameterLoadModifierId9Navigations).HasConstraintName("FK_LoadsControlPilotParameters_Modifiers9");
        });

        modelBuilder.Entity<LowLevelInputConfiguration>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_LowLevelInputConfigurations_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.LowLevelInputConfigurationId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.LowLevelInputConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LowLevelInputConfigurations_TableTargets");
        });

        modelBuilder.Entity<LowLevelInputConfigurationsLowLevelInputDetail>(entity =>
        {
            entity.HasOne(d => d.LowLevelInputConfiguration).WithMany(p => p.LowLevelInputConfigurationsLowLevelInputDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LowLevelInputConfigurations_LowLevelInputDetails_LowLevelInputConfigurations");

            entity.HasOne(d => d.LowLevelInputDetail).WithMany(p => p.LowLevelInputConfigurationsLowLevelInputDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LowLevelInputConfigurations_LowLevelInputDetails_LowLevelInputDetails");
        });

        modelBuilder.Entity<LowLevelInputDetail>(entity =>
        {
            entity.HasKey(e => e.LowLevelInputDetailId).HasName("PK_LowLevelInputDetails_1");

            entity.Property(e => e.LowLevelInputDetailId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ReadType).WithMany(p => p.LowLevelInputDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LowLevelInputDetails_ReadTypes");
        });

        modelBuilder.Entity<MachineConfigTableAttribute>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<MachineConfiguration>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_MachineConfigurations_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.MachineConfigurationId).ValueGeneratedNever();
            entity.Property(e => e.Code).HasDefaultValueSql("('00000000000')");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ScaleTemperature).HasDefaultValueSql("((40))");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.ApplianceConfiguration).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_ApplianceConfiguration");

            entity.HasOne(d => d.AutoResumeMonitor).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorAutoResume");

            entity.HasOne(d => d.CooktopOrgConfiguration).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_InductionCooktopOrgConfigurations");

            entity.HasOne(d => d.CycleMapping).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_CycleMapping");

            entity.HasOne(d => d.DebugPointerConfigurations).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_DebugPointerConfigurations");

            entity.HasOne(d => d.DlbConfigMonitor).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorDlbConfiguration");

            entity.HasOne(d => d.FaultConfigurations).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_FaultConfigurations");

            entity.HasOne(d => d.IpcControllerConfigurations).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_IpcControllerConfigurations");

            entity.HasOne(d => d.IrshutterMonitor).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorIRShutter");

            entity.HasOne(d => d.IrtemperatureMonitor).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorIRTemperature");

            entity.HasOne(d => d.IsofrequencyTable).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_InductionIsofrequencyConfigurations");

            entity.HasOne(d => d.LatchControl).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorLatchControl");

            entity.HasOne(d => d.LightConfiguration).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorLight");

            entity.HasOne(d => d.MicrowavePowerTable).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MicrowavePowerTableConfigurations");

            entity.HasOne(d => d.MinimumDcSupply).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MinimumDcSupply");

            entity.HasOne(d => d.MonitorCoilDeratingConfiguration).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorCoilDeratingConfigurations");

            entity.HasOne(d => d.MonitorCoil).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorCoil");

            entity.HasOne(d => d.MonitorGfci).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorGfci");

            entity.HasOne(d => d.MonitorGfciV2).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorGfciV2");

            entity.HasOne(d => d.MonitorHeatsinkFan).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorHeatSinkFan");

            entity.HasOne(d => d.MonitorHoodFan).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorHoodFan");

            entity.HasOne(d => d.MonitorMultiPointProbe).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorMultiPointProbe");

            entity.HasOne(d => d.MonitorPowerReduction).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorPowerReduction");

            entity.HasOne(d => d.MonitorPowerReductionV2configuration).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorPowerReductionV2Configuration");

            entity.HasOne(d => d.MonitorSteam).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorSteam");

            entity.HasOne(d => d.MonitorVent).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorVent");

            entity.HasOne(d => d.MonitorWaterLevelThreshold).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_DeprecatedMonitorWaterLevelThreshold");

            entity.HasOne(d => d.OpenDoorHeatingCyclesConfig).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_OpenDoorHeatingCyclesConfigurations");

            entity.HasOne(d => d.PowerDetectMonitor).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorPowerDetect");

            entity.HasOne(d => d.SrsafetyParameters).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_SRSafetyRelevantParameters");

            entity.HasOne(d => d.TimeEstimationConfiguration).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_TimeEstimationConfigurations");

            entity.HasOne(d => d.WarmingZoneParams).WithMany(p => p.MachineConfigurations).HasConstraintName("FK_MachineConfigurations_MonitorWarmingZone");
        });

        modelBuilder.Entity<Macro>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_Macros_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.MacroId).ValueGeneratedNever();

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.Macros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Macros_TableTargets");
        });

        modelBuilder.Entity<MacrosStatement>(entity =>
        {
            entity.HasOne(d => d.Macro).WithMany(p => p.MacrosStatements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Macros_Statements_Macros");

            entity.HasOne(d => d.Statement).WithMany(p => p.MacrosStatements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Macros_Statements_Statements");
        });

        modelBuilder.Entity<MainsLineConfigDatum>(entity =>
        {
            entity.Property(e => e.MainsLineConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MicrowavePowerTableConfiguration>(entity =>
        {
            entity.Property(e => e.MicrowavePowerTableConfigId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<MicrowavePowerTableConfigurationsMicrowavePowerTableDetail>(entity =>
        {
            entity.HasOne(d => d.MicrowavePowerTableConfig).WithMany(p => p.MicrowavePowerTableConfigurationsMicrowavePowerTableDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MicrowavePowerTableConfigurations_MicrowavePowerTableDetails_MicrowavePowerTableConfigurations");

            entity.HasOne(d => d.MicrowavePowerTableDetails).WithMany(p => p.MicrowavePowerTableConfigurationsMicrowavePowerTableDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MicrowavePowerTableConfigurations_MicrowavePowerTableDetails_MicrowavePowerTableDetails");
        });

        modelBuilder.Entity<MicrowavePowerTableDetail>(entity =>
        {
            entity.Property(e => e.MicrowavePowerTableDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MicrowavePowerTableView>(entity =>
        {
            entity.ToView("MicrowavePowerTableView");
        });

        modelBuilder.Entity<MinimumDcSupply>(entity =>
        {
            entity.Property(e => e.MinimumDcSupplyId).ValueGeneratedNever();
            entity.Property(e => e.AclowerInputVoltage).HasDefaultValueSql("((102))");
            entity.Property(e => e.AcupperInputVoltage).HasDefaultValueSql("((132))");
            entity.Property(e => e.AcvoltageDebounceMilliseconds).HasDefaultValueSql("((3000))");
        });

        modelBuilder.Entity<Modifier>(entity =>
        {
            entity.Property(e => e.ModifiersId).ValueGeneratedNever();
            entity.Property(e => e.Description).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.NumModifiers).HasDefaultValueSql("((1))");
            entity.Property(e => e.OverallOperationId).HasDefaultValueSql("((1))");
            entity.Property(e => e.Owner).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(CONVERT([uniqueidentifier],CONVERT([binary],(0),0),0))");
            entity.Property(e => e.Timestamp).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.ModifierDetails1Navigation).WithMany(p => p.ModifierModifierDetails1Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifiersDetails");

            entity.HasOne(d => d.ModifierDetails2Navigation).WithMany(p => p.ModifierModifierDetails2Navigations).HasConstraintName("FK_Modifiers_ModifiersDetails1");

            entity.HasOne(d => d.ModifierDetails3Navigation).WithMany(p => p.ModifierModifierDetails3Navigations).HasConstraintName("FK_Modifiers_ModifiersDetails2");

            entity.HasOne(d => d.ModifierDetails4Navigation).WithMany(p => p.ModifierModifierDetails4Navigations).HasConstraintName("FK_Modifiers_ModifiersDetails3");

            entity.HasOne(d => d.ModifierDetails5Navigation).WithMany(p => p.ModifierModifierDetails5Navigations).HasConstraintName("FK_Modifiers_ModifiersDetails4");

            entity.HasOne(d => d.ModifierDetails6Navigation).WithMany(p => p.ModifierModifierDetails6Navigations).HasConstraintName("FK_Modifiers_ModifiersDetails5");

            entity.HasOne(d => d.ModifierDetails7Navigation).WithMany(p => p.ModifierModifierDetails7Navigations).HasConstraintName("FK_Modifiers_ModifiersDetails6");

            entity.HasOne(d => d.ModifierDetails8Navigation).WithMany(p => p.ModifierModifierDetails8Navigations).HasConstraintName("FK_Modifiers_ModifiersDetails7");

            entity.HasOne(d => d.ModifierOperator1Navigation).WithMany(p => p.ModifierModifierOperator1Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierOperators");

            entity.HasOne(d => d.ModifierOperator2Navigation).WithMany(p => p.ModifierModifierOperator2Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierOperators1");

            entity.HasOne(d => d.ModifierOperator3Navigation).WithMany(p => p.ModifierModifierOperator3Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierOperators2");

            entity.HasOne(d => d.ModifierOperator4Navigation).WithMany(p => p.ModifierModifierOperator4Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierOperators3");

            entity.HasOne(d => d.ModifierOperator7Navigation).WithMany(p => p.ModifierModifierOperator7Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierOperators6");

            entity.HasOne(d => d.ModifierOperator8Navigation).WithMany(p => p.ModifierModifierOperator8Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierOperators7");

            entity.HasOne(d => d.ModifierType1Navigation).WithMany(p => p.ModifierModifierType1Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierTypes");

            entity.HasOne(d => d.ModifierType2Navigation).WithMany(p => p.ModifierModifierType2Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierTypes1");

            entity.HasOne(d => d.ModifierType3Navigation).WithMany(p => p.ModifierModifierType3Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierTypes2");

            entity.HasOne(d => d.ModifierType4Navigation).WithMany(p => p.ModifierModifierType4Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierTypes3");

            entity.HasOne(d => d.ModifierType5Navigation).WithMany(p => p.ModifierModifierType5Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierOperators4");

            entity.HasOne(d => d.ModifierType51).WithMany(p => p.ModifierModifierType51s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierTypes4");

            entity.HasOne(d => d.ModifierType6Navigation).WithMany(p => p.ModifierModifierType6Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierOperators5");

            entity.HasOne(d => d.ModifierType61).WithMany(p => p.ModifierModifierType61s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierTypes5");

            entity.HasOne(d => d.ModifierType7Navigation).WithMany(p => p.ModifierModifierType7Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierTypes6");

            entity.HasOne(d => d.ModifierType8Navigation).WithMany(p => p.ModifierModifierType8Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modifiers_ModifierTypes7");
        });

        modelBuilder.Entity<ModifiersDetail>(entity =>
        {
            entity.Property(e => e.ModifiersDetailsId).ValueGeneratedNever();
            entity.Property(e => e.ModifierSearchMethodId).HasDefaultValueSql("((1))");
            entity.Property(e => e.NumItems).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.ModifierSearchMethod).WithMany(p => p.ModifiersDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ModifiersDetails_ModifierSearchMethods");
        });

        modelBuilder.Entity<MonitorAutoResume>(entity =>
        {
            entity.Property(e => e.AutoResumeMonitorId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorCoil>(entity =>
        {
            entity.Property(e => e.MonitorCoilId).ValueGeneratedNever();
            entity.Property(e => e.CoilHotSurfaceClear).HasDefaultValueSql("((50))");
            entity.Property(e => e.CoilHotSurfaceDebounceTime).HasDefaultValueSql("((5))");
            entity.Property(e => e.CoilHotSurfaceRaise).HasDefaultValueSql("((55))");
            entity.Property(e => e.CoilOvertemperatureClear).HasDefaultValueSql("((220))");
            entity.Property(e => e.CoilOvertemperatureRaise).HasDefaultValueSql("((230))");
            entity.Property(e => e.CoilPanDetectionTimeout).HasDefaultValueSql("((255))");
            entity.Property(e => e.CoilPanPresentDebounceTime).HasDefaultValueSql("((1))");
            entity.Property(e => e.HeatsinkOvertemperatureClear).HasDefaultValueSql("((96))");
            entity.Property(e => e.HeatsinkOvertemperatureRaise).HasDefaultValueSql("((98))");
            entity.Property(e => e.MainRelayOpenDelayTime).HasDefaultValueSql("((5))");
        });

        modelBuilder.Entity<MonitorCoilDeratingConfiguration>(entity =>
        {
            entity.Property(e => e.MonitorCoilDeratingConfigurationId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail>(entity =>
        {
            entity.HasOne(d => d.MonitorCoilDeratingConfiguration).WithMany(p => p.MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MonitorCoilDeratingConfigurations_MonitorCoilDeratingDetails_MonitorCoilDeratingConfigurations");

            entity.HasOne(d => d.MonitorCoilDeratingDetails).WithMany(p => p.MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MonitorCoilDeratingConfigurations_MonitorCoilDeratingDetails_MonitorCoilDeratingDetails");
        });

        modelBuilder.Entity<MonitorCoilDeratingDetail>(entity =>
        {
            entity.HasKey(e => e.MonitorCoilDeratingDetailsId).HasName("PK_MonitorCoilDerating");

            entity.Property(e => e.MonitorCoilDeratingDetailsId).ValueGeneratedNever();
            entity.Property(e => e.ControlDiCoil).HasDefaultValueSql("((200))");
            entity.Property(e => e.ControlDiHeatsinkHard).HasDefaultValueSql("((200))");
            entity.Property(e => e.ControlDiHeatsinkSoft).HasDefaultValueSql("((200))");
            entity.Property(e => e.ControlDpCoil).HasDefaultValueSql("((20))");
            entity.Property(e => e.ControlDpHeatsinkHard).HasDefaultValueSql("((20))");
            entity.Property(e => e.ControlDpHeatsinkSoft).HasDefaultValueSql("((20))");
            entity.Property(e => e.EnableCoil).HasDefaultValueSql("((1))");
            entity.Property(e => e.EnableHeatsink).HasDefaultValueSql("((1))");
            entity.Property(e => e.MaxPercentHard).HasDefaultValueSql("((40))");
            entity.Property(e => e.MaxPercentSoft).HasDefaultValueSql("((100))");
            entity.Property(e => e.MonoLocal).HasDefaultValueSql("((1))");
            entity.Property(e => e.PhaseTime).HasDefaultValueSql("((10))");
            entity.Property(e => e.TemperatureMaxCoil).HasDefaultValueSql("((300))");
            entity.Property(e => e.TemperatureMaxHeatsinkHard).HasDefaultValueSql("((300))");
            entity.Property(e => e.TemperatureMaxHeatsinkSoft).HasDefaultValueSql("((300))");
            entity.Property(e => e.TemperatureMinCoil).HasDefaultValueSql("((298))");
            entity.Property(e => e.TemperatureMinHeatsinkHard).HasDefaultValueSql("((298))");
            entity.Property(e => e.TemperatureMinHeatsinkSoft).HasDefaultValueSql("((298))");
            entity.Property(e => e.TemperatureRefCoil).HasDefaultValueSql("((299))");
            entity.Property(e => e.TemperatureRefHeatsinkHard).HasDefaultValueSql("((299))");
            entity.Property(e => e.TemperatureRefHeatsinkSoft).HasDefaultValueSql("((299))");
        });

        modelBuilder.Entity<MonitorDlbConfiguration>(entity =>
        {
            entity.Property(e => e.DlbConfigMonitorId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorGfci>(entity =>
        {
            entity.Property(e => e.MonitorGfciId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorGfciV2>(entity =>
        {
            entity.Property(e => e.MonitorGfciV2id).ValueGeneratedNever();
            entity.Property(e => e.Cav1DutyPeriod).HasDefaultValueSql("((60))");
            entity.Property(e => e.Cav1LoadId1).HasDefaultValueSql("((255))");
            entity.Property(e => e.Cav1LoadId2).HasDefaultValueSql("((255))");
            entity.Property(e => e.Cav1LoadId3).HasDefaultValueSql("((255))");
            entity.Property(e => e.Cav1LoadId4).HasDefaultValueSql("((255))");
            entity.Property(e => e.Cav1LoadId5).HasDefaultValueSql("((255))");
            entity.Property(e => e.Cav1NumberOfCycles).HasDefaultValueSql("((1))");
            entity.Property(e => e.NumberOfCavities).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<MonitorHeatSinkFan>(entity =>
        {
            entity.Property(e => e.MonitorHeatSinkFanId).ValueGeneratedNever();

            entity.HasOne(d => d.TemperatureDsp00ldNavigation).WithMany(p => p.MonitorHeatSinkFanTemperatureDsp00ldNavigations).HasConstraintName("FK_MonitorHeatSinkFan_MonitorHeatSinkFanTemperature");

            entity.HasOne(d => d.TemperatureDsp01ldNavigation).WithMany(p => p.MonitorHeatSinkFanTemperatureDsp01ldNavigations).HasConstraintName("FK_MonitorHeatSinkFan_MonitorHeatSinkFanTemperature1");

            entity.HasOne(d => d.TemperatureDsp02ldNavigation).WithMany(p => p.MonitorHeatSinkFanTemperatureDsp02ldNavigations).HasConstraintName("FK_MonitorHeatSinkFan_MonitorHeatSinkFanTemperature2");

            entity.HasOne(d => d.TemperatureDsp03ldNavigation).WithMany(p => p.MonitorHeatSinkFanTemperatureDsp03ldNavigations).HasConstraintName("FK_MonitorHeatSinkFan_MonitorHeatSinkFanTemperature3");

            entity.HasOne(d => d.TemperatureDsp04ldNavigation).WithMany(p => p.MonitorHeatSinkFanTemperatureDsp04ldNavigations).HasConstraintName("FK_MonitorHeatSinkFan_MonitorHeatSinkFanTemperature4");

            entity.HasOne(d => d.TemperatureDsp05ldNavigation).WithMany(p => p.MonitorHeatSinkFanTemperatureDsp05ldNavigations).HasConstraintName("FK_MonitorHeatSinkFan_MonitorHeatSinkFanTemperature5");

            entity.HasOne(d => d.TemperatureDsp06ldNavigation).WithMany(p => p.MonitorHeatSinkFanTemperatureDsp06ldNavigations).HasConstraintName("FK_MonitorHeatSinkFan_MonitorHeatSinkFanTemperature6");

            entity.HasOne(d => d.TemperatureDsp07ldNavigation).WithMany(p => p.MonitorHeatSinkFanTemperatureDsp07ldNavigations).HasConstraintName("FK_MonitorHeatSinkFan_MonitorHeatSinkFanTemperature7");

            entity.HasOne(d => d.TemperatureDsp08ldNavigation).WithMany(p => p.MonitorHeatSinkFanTemperatureDsp08ldNavigations).HasConstraintName("FK_MonitorHeatSinkFan_MonitorHeatSinkFanTemperature8");
        });

        modelBuilder.Entity<MonitorHeatSinkFanTemperature>(entity =>
        {
            entity.Property(e => e.MonitorHeatSinkFanTemperatureId).ValueGeneratedNever();
            entity.Property(e => e.Hysteresis).HasDefaultValueSql("((1))");
            entity.Property(e => e.PostMinimum).HasDefaultValueSql("((1))");
            entity.Property(e => e.PostThreshold).HasDefaultValueSql("((75.0))");
            entity.Property(e => e.PostTimeout).HasDefaultValueSql("((200))");
        });

        modelBuilder.Entity<MonitorHoodFan>(entity =>
        {
            entity.Property(e => e.MonitorHoodFanId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorIrshutter>(entity =>
        {
            entity.Property(e => e.IrshutterMonitorId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorIrtemperature>(entity =>
        {
            entity.Property(e => e.IrtemperatureMonitorId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorLatchControl>(entity =>
        {
            entity.Property(e => e.LatchControlId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorLight>(entity =>
        {
            entity.Property(e => e.LightConfigurationId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorMultiPointProbe>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorPowerDetect>(entity =>
        {
            entity.Property(e => e.PowerDetectMonitorId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorPowerReduction>(entity =>
        {
            entity.Property(e => e.MonitorPowerReductionId).ValueGeneratedNever();

            entity.HasOne(d => d.PowerReductionTimerConfig).WithMany(p => p.MonitorPowerReductions).HasConstraintName("FK_MonitorPowerReduction_PowerReductionTimerConfiguration");
        });

        modelBuilder.Entity<MonitorPowerReductionV2configuration>(entity =>
        {
            entity.HasKey(e => e.MonitorPowerReductionV2configurationId).HasName("PK_MonitorPowerReductionV2");

            entity.Property(e => e.MonitorPowerReductionV2configurationId).ValueGeneratedNever();
            entity.Property(e => e.CrispMaxTime).HasDefaultValueSql("((600))");
        });

        modelBuilder.Entity<MonitorPowerReductionV2configurationMonitorPowerReductionV2detail>(entity =>
        {
            entity.HasOne(d => d.MonitorPowerReductionV2configuration).WithMany(p => p.MonitorPowerReductionV2configurationMonitorPowerReductionV2details)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MonitorPowerReductionV2Configuration_MonitorPowerReductionV2Details_MonitorPowerReductionV2Configuration");

            entity.HasOne(d => d.MonitorPowerReductionV2details).WithMany(p => p.MonitorPowerReductionV2configurationMonitorPowerReductionV2details)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MonitorPowerReductionV2Configuration_MonitorPowerReductionV2Details_MonitorPowerReductionV2Details");
        });

        modelBuilder.Entity<MonitorPowerReductionV2detail>(entity =>
        {
            entity.Property(e => e.MonitorPowerReductionV2detailsId).ValueGeneratedNever();

            entity.HasOne(d => d.MonitorPowerReductionV2estimatedTempConfiguration).WithMany(p => p.MonitorPowerReductionV2details).HasConstraintName("FK_MonitorPowerReductionV2Details_MonitorPowerReductionV2EstimatedTempConfiguration");

            entity.HasOne(d => d.MonitorPowerReductionV2powerRedConfiguration).WithMany(p => p.MonitorPowerReductionV2details).HasConstraintName("FK_MonitorPowerReductionV2Details_MonitorPowerReductionV2PowerRedConfiguration");
        });

        modelBuilder.Entity<MonitorPowerReductionV2estimatedTempConfiguration>(entity =>
        {
            entity.Property(e => e.MonitorPowerReductionV2estimatedTempConfigurationId).ValueGeneratedNever();
            entity.Property(e => e.CavityTempTermApplies).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail>(entity =>
        {
            entity.HasOne(d => d.MonitorPowerReductionV2estimatedTempConfiguration).WithMany(p => p.MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MonitorPowerReductionV2EstimatedTempConfiguration_MonitorPow_MonitorPowerReductionV2EstimatedTempConfiguration");

            entity.HasOne(d => d.MonitorPowerReductionV2estimatedTempDetails).WithMany(p => p.MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MonitorPowerReductionV2EstimatedTempConfiguration_MonitorPow_MonitorPowerReductionV2EstimatedTempDetails");
        });

        modelBuilder.Entity<MonitorPowerReductionV2estimatedTempDetail>(entity =>
        {
            entity.Property(e => e.MonitorPowerReductionV2estimatedTempDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorPowerReductionV2powerRedConfiguration>(entity =>
        {
            entity.HasKey(e => e.MonitorPowerReductionV2powerRedConfigurationId).HasName("PK_MonitorPowerReductionV2PowerReductionConfiguration");

            entity.Property(e => e.MonitorPowerReductionV2powerRedConfigurationId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail>(entity =>
        {
            entity.HasOne(d => d.MonitorPowerReductionV2powerRedConfiguration).WithMany(p => p.MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MonitorPowerReductionV2PowerRedConfiguration_MonitorPowerRed_MonitorPowerReductionV2PowerRedConfiguration");

            entity.HasOne(d => d.MonitorPowerReductionV2powerRedDetails).WithMany(p => p.MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MonitorPowerReductionV2PowerRedConfiguration_MonitorPowerReductionV2PowerRedDetails_MonitorPowerReductionV2PowerRedDetails");
        });

        modelBuilder.Entity<MonitorPowerReductionV2powerRedDetail>(entity =>
        {
            entity.Property(e => e.MonitorPowerReductionV2powerRedDetailsId).ValueGeneratedNever();
            entity.Property(e => e.PowerLimitLoad0).HasDefaultValueSql("((100))");
            entity.Property(e => e.PowerLimitLoad1).HasDefaultValueSql("((100))");
            entity.Property(e => e.PowerLimitLoad2).HasDefaultValueSql("((100))");
            entity.Property(e => e.PowerLimitLoad3).HasDefaultValueSql("((100))");
            entity.Property(e => e.PowerLimitLoad4).HasDefaultValueSql("((100))");
        });

        modelBuilder.Entity<MonitorSteam>(entity =>
        {
            entity.HasKey(e => e.MonitorSteamId).HasName("PK_MonitorSteam2");

            entity.Property(e => e.MonitorSteamId).ValueGeneratedNever();

            entity.HasOne(d => d.MonitorSteamDescale).WithMany(p => p.MonitorSteams).HasConstraintName("FK_MonitorSteam_MonitorSteamDescale");

            entity.HasOne(d => d.MonitorSteamDrain).WithMany(p => p.MonitorSteams).HasConstraintName("FK_MonitorSteam_MonitorSteamDrain");

            entity.HasOne(d => d.MonitorSteamHumidityMap).WithMany(p => p.MonitorSteams).HasConstraintName("FK_MonitorSteam_MonitorSteamHumidityTargetMapping");

            entity.HasOne(d => d.MonitorSteamParams).WithMany(p => p.MonitorSteams).HasConstraintName("FK_MonitorSteam_MonitorSteamParams");

            entity.HasOne(d => d.MonitorSteamWaterLevelSensor).WithMany(p => p.MonitorSteams).HasConstraintName("FK_MonitorSteam_MonitorSteamWaterLevelSensor");

            entity.HasOne(d => d.MonitorSteamerParams).WithMany(p => p.MonitorSteams).HasConstraintName("FK_MonitorSteam_MonitorSteamerParams");
        });

        modelBuilder.Entity<MonitorSteamDescale>(entity =>
        {
            entity.Property(e => e.MonitorSteamDescaleId).ValueGeneratedNever();
            entity.Property(e => e.DescaleDetectionMethod).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<MonitorSteamDrain>(entity =>
        {
            entity.Property(e => e.MonitorSteamDrainId).ValueGeneratedNever();
            entity.Property(e => e.BoilerTempDebounceTime).HasDefaultValueSql("((255))");
        });

        modelBuilder.Entity<MonitorSteamHumidityTargetMapping>(entity =>
        {
            entity.Property(e => e.MonitorSteamHumidityMapId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorSteamParam>(entity =>
        {
            entity.Property(e => e.MonitorSteamParamsId).ValueGeneratedNever();
            entity.Property(e => e.RefillTimeThreshold).HasDefaultValueSql("((10))");
        });

        modelBuilder.Entity<MonitorSteamWaterLevelSensor>(entity =>
        {
            entity.HasKey(e => e.MonitorSteamWaterLevelSensorId).HasName("PK_MonitorSteamWaterLevelSensor2");

            entity.Property(e => e.MonitorSteamWaterLevelSensorId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorSteamerParam>(entity =>
        {
            entity.Property(e => e.MonitorSteamerParamsId).ValueGeneratedNever();
            entity.Property(e => e.Description).IsFixedLength();
        });

        modelBuilder.Entity<MonitorVent>(entity =>
        {
            entity.Property(e => e.MonitorVentId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitorWarmingZone>(entity =>
        {
            entity.Property(e => e.WarmingZoneParamsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MultiDriverPilotType>(entity =>
        {
            entity.HasOne(d => d.PilotType).WithOne(p => p.MultiDriverPilotType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MultiDriverPilotTypes_PilotTypes");
        });

        modelBuilder.Entity<MultiInputReadType>(entity =>
        {
            entity.HasOne(d => d.ReadType).WithOne(p => p.MultiInputReadType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MultiInputReadTypes_ReadTypes");
        });

        modelBuilder.Entity<MultiSequencePilotType>(entity =>
        {
            entity.HasOne(d => d.PilotType).WithOne(p => p.MultiSequencePilotType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MultiSequencePilotTypes_PilotTypes");
        });

        modelBuilder.Entity<OpenDoorHeatingCyclesConfiguration>(entity =>
        {
            entity.Property(e => e.OpenDoorHeatingCyclesConfigId).ValueGeneratedNever();
            entity.Property(e => e.Code).HasDefaultValueSql("('00000000000')");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail>(entity =>
        {
            entity.HasOne(d => d.OpenDoorHeatingCyclesConfig).WithMany(p => p.OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OpenDoorHeatingCyclesConfigurations_OpenDoorHeatingCyclesDetails_OpenDoorHeatingCyclesConfigurations");

            entity.HasOne(d => d.OpenDoorHeatingCyclesDetails).WithMany(p => p.OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OpenDoorHeatingCyclesConfigurations_OpenDoorHeatingCyclesDetails_OpenDoorHeatingCyclesDetails");
        });

        modelBuilder.Entity<OpenDoorHeatingCyclesDetail>(entity =>
        {
            entity.Property(e => e.OpenDoorHeatingCyclesDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PilotGeneralizedProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PilotPartializedProfiles");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nperiods).HasDefaultValueSql("((1))");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.PilotGeneralizedProfiles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PilotGeneralizedProfiles_TableTargets");
        });

        modelBuilder.Entity<PilotMultiSequenceConfig>(entity =>
        {
            entity.Property(e => e.ConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PilotMultiSequenceConfigDetail>(entity =>
        {
            entity.HasOne(d => d.Config).WithMany(p => p.PilotMultiSequenceConfigDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PilotMultiSequenceConfig_Details_PilotMultiSequenceConfig");

            entity.HasOne(d => d.Details).WithMany(p => p.PilotMultiSequenceConfigDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PilotMultiSequenceConfig_Details_PilotMultiSequenceDetails");
        });

        modelBuilder.Entity<PilotMultiSequenceDetail>(entity =>
        {
            entity.Property(e => e.DetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PilotMultiSequenceDetailsStep>(entity =>
        {
            entity.HasOne(d => d.Details).WithMany(p => p.PilotMultiSequenceDetailsSteps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PilotMultiSequenceDetails_Step_PilotMultiSequenceDetails");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.PilotMultiSequenceDetailsSteps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PilotMultiSequenceDetails_Step_PilotMultiSequenceStep");
        });

        modelBuilder.Entity<PilotMultiSequenceStep>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PowerDeliveryConfigDatum>(entity =>
        {
            entity.Property(e => e.PowerDeliveryConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PowerReductionTimerConfiguration>(entity =>
        {
            entity.Property(e => e.PowerReductionTimerConfigId).ValueGeneratedNever();

            entity.HasOne(d => d.PrtimerBroilConfig).WithMany(p => p.PowerReductionTimerConfigurations).HasConstraintName("FK_PowerReductionTimerConfiguration_PRTimerBroilConfiguration");

            entity.HasOne(d => d.PrtimerBroilTimerDecrement).WithMany(p => p.PowerReductionTimerConfigurations).HasConstraintName("FK_PowerReductionTimerConfiguration_PRTimerBroilTimerDecrement");

            entity.HasOne(d => d.PrtimerConvectConfig).WithMany(p => p.PowerReductionTimerConfigurations).HasConstraintName("FK_PowerReductionTimerConfiguration_PRTimerConvectConfiguration");

            entity.HasOne(d => d.PrtimerConvectTimerDecrement).WithMany(p => p.PowerReductionTimerConfigurations).HasConstraintName("FK_PowerReductionTimerConfiguration_PRTimerConvectTimerDecrement");

            entity.HasOne(d => d.PrtimerMagnetronConfig).WithMany(p => p.PowerReductionTimerConfigurations).HasConstraintName("FK_PowerReductionTimerConfiguration_PRTimerMagnetronConfiguration");

            entity.HasOne(d => d.PrtimerMagnetronTimerDecrement).WithMany(p => p.PowerReductionTimerConfigurations).HasConstraintName("FK_PowerReductionTimerConfiguration_PRTimerMagnetronTimerDecrement");
        });

        modelBuilder.Entity<PrmGianalogToTemperature>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.PrmGianalogToTemperatures)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrmGIAnalogToTemperature_TableTargets");
        });

        modelBuilder.Entity<PrmGianyLliToConvert>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.InputExtendValues).HasDefaultValueSql("(0x)");
            entity.Property(e => e.OutputExtendValues).HasDefaultValueSql("(0x)");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<PrmGianyLliToFeedback>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<PrmGianyLliToPhase>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmGianyLliToSwitch>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<PrmGii2cinfraredToIrtemperature>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DebounceThresholdTa).HasDefaultValueSql("((3))");
            entity.Property(e => e.DebounceThresholdTo).HasDefaultValueSql("((3))");
            entity.Property(e => e.DebounceThresholdVdd).HasDefaultValueSql("((3))");
            entity.Property(e => e.DissociateInputTa).HasDefaultValueSql("((1))");
            entity.Property(e => e.DissociateInputTo).HasDefaultValueSql("((1))");
            entity.Property(e => e.DissociateInputVdd).HasDefaultValueSql("((1))");
            entity.Property(e => e.RemoveThresholdTa).HasDefaultValueSql("((1))");
            entity.Property(e => e.RemoveThresholdTo).HasDefaultValueSql("((5))");
            entity.Property(e => e.RemoveThresholdVdd).HasDefaultValueSql("((0.5))");
        });

        modelBuilder.Entity<PrmGiinputCaptureToSpeed>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmLoadFanConfiguration>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmLoadFanConfigurationPrmLoadFanDetail>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.PrmLoadFanConfigurationPrmLoadFanDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrmLoadFanConfiguration_PrmLoadFanDetails_PrmLoadFanConfiguration");

            entity.HasOne(d => d.PrmLoadFanDetails).WithMany(p => p.PrmLoadFanConfigurationPrmLoadFanDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrmLoadFanConfiguration_PrmLoadFanDetails_PrmLoadFanDetails");
        });

        modelBuilder.Entity<PrmLoadFanDetail>(entity =>
        {
            entity.Property(e => e.PrmLoadFanDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmPilotAnalog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmPilotConstantPwm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmPilotExpansion>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmPilotImpulsive>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.UnlockWaitTime).HasDefaultValueSql("((750))");
        });

        modelBuilder.Entity<PrmPilotMagnetron>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.MicrowaveDoorInput).HasDefaultValueSql("((16))");
        });

        modelBuilder.Entity<PrmPilotMultiDriver>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.PilotTypeId0Navigation).WithMany(p => p.PrmPilotMultiDriverPilotTypeId0Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrmPilotMultiDriver_PilotTypes");

            entity.HasOne(d => d.PilotTypeId1Navigation).WithMany(p => p.PrmPilotMultiDriverPilotTypeId1Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrmPilotMultiDriver_PilotTypes1");

            entity.HasOne(d => d.PilotTypeId2Navigation).WithMany(p => p.PrmPilotMultiDriverPilotTypeId2Navigations).HasConstraintName("FK_PrmPilotMultiDriver_PilotTypes2");

            entity.HasOne(d => d.PilotTypeId3Navigation).WithMany(p => p.PrmPilotMultiDriverPilotTypeId3Navigations).HasConstraintName("FK_PrmPilotMultiDriver_PilotTypes3");
        });

        modelBuilder.Entity<PrmPilotMultiSequence>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.PilotTypeId0Navigation).WithMany(p => p.PrmPilotMultiSequencePilotTypeId0Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrmPilotMultiSequence_MultiSequencePilotTypes");

            entity.HasOne(d => d.PilotTypeId1Navigation).WithMany(p => p.PrmPilotMultiSequencePilotTypeId1Navigations).HasConstraintName("FK_PrmPilotMultiSequence_MultiSequencePilotTypes1");

            entity.HasOne(d => d.PilotTypeId2Navigation).WithMany(p => p.PrmPilotMultiSequencePilotTypeId2Navigations).HasConstraintName("FK_PrmPilotMultiSequence_MultiSequencePilotTypes2");

            entity.HasOne(d => d.PilotTypeId3Navigation).WithMany(p => p.PrmPilotMultiSequencePilotTypeId3Navigations).HasConstraintName("FK_PrmPilotMultiSequence_MultiSequencePilotTypes3");

            entity.HasOne(d => d.SequencesConfigurationNavigation).WithMany(p => p.PrmPilotMultiSequences).HasConstraintName("FK_PrmPilotMultiSequence_PilotMultiSequenceConfig");
        });

        modelBuilder.Entity<PrmPilotPartialized>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PrmPilotTriacPartialized");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.MinDeactivationPercentage).HasDefaultValueSql("((10))");
            entity.Property(e => e.PulseWidthPercentage).HasDefaultValueSql("((20))");
        });

        modelBuilder.Entity<PrmPilotPwm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmPilotReleZc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PrmPilotReleZeroCrossing");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<PrmPilotStepByStep>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmPilotThreePhaseMotor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmPilotUniversalMotor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AngleFbkThreshold).HasDefaultValueSql("((300))");
            entity.Property(e => e.FbkDebounceTime).HasDefaultValueSql("((500))");
            entity.Property(e => e.TachoTimeout).HasDefaultValueSql("((1000))");
            entity.Property(e => e.TapfieldSuspendTime).HasDefaultValueSql("((20))");
        });

        modelBuilder.Entity<PrmPilotVent>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.OnToOffPositionTimeOrZcNumber).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<PrmPilotWax>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DoorLockFilterTime).HasDefaultValueSql("((5))");
            entity.Property(e => e.DoorLockOffTime).HasDefaultValueSql("((10))");
            entity.Property(e => e.DoorLockOnTime).HasDefaultValueSql("((10))");
            entity.Property(e => e.MaxFaultWaitTime).HasDefaultValueSql("((12000))");
            entity.Property(e => e.MaxFaultWaitTimeClose).HasDefaultValueSql("((500))");
        });

        modelBuilder.Entity<PrmReadAccellerometer>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.AccellerometerParams).WithMany(p => p.PrmReadAccellerometers).HasConstraintName("FK_PrmReadAccellerometer_PrmReadAccellerometerSTLISxDH");
        });

        modelBuilder.Entity<PrmReadAccellerometerStlisxDh>(entity =>
        {
            entity.Property(e => e.PrmReadAccellerometerStlisxDhid).ValueGeneratedNever();
            entity.Property(e => e.Bdu).HasDefaultValueSql("((1))");
            entity.Property(e => e.DataRate).HasDefaultValueSql("((7))");
            entity.Property(e => e.I2caddress).HasDefaultValueSql("((24))");
            entity.Property(e => e.Res).HasDefaultValueSql("((2))");
            entity.Property(e => e.Xa).HasDefaultValueSql("((1))");
            entity.Property(e => e.Ya).HasDefaultValueSql("((1))");
            entity.Property(e => e.YaxisOptions).HasDefaultValueSql("((2))");
            entity.Property(e => e.Za).HasDefaultValueSql("((1))");
            entity.Property(e => e.ZaxisOptions).HasDefaultValueSql("((4))");
        });

        modelBuilder.Entity<PrmReadAnalog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmReadAnalogFeedback>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<PrmReadConductivitySensor>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Filter).HasDefaultValueSql("((32))");
            entity.Property(e => e.Period).HasDefaultValueSql("((4))");
        });

        modelBuilder.Entity<PrmReadDigitalMatrix>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmReadI2cinfrared>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.RefreshRateNavigation).WithMany(p => p.PrmReadI2cinfrareds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrmReadI2CInfrared_RefreshRates");
        });

        modelBuilder.Entity<PrmReadI2cpressureSensor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CommunicationFaultDebounce).HasDefaultValueSql("('8')");
            entity.Property(e => e.CommunicationFaultRetries).HasDefaultValueSql("('3')");
        });

        modelBuilder.Entity<PrmReadInputCapture>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<PrmReadL2crhthumiditySensor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.I2cslaveAddress).HasDefaultValueSql("((128))");
            entity.Property(e => e.L2cspeed).HasDefaultValueSql("((1))");
            entity.Property(e => e.NumReading).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<PrmReadL2crhttempSensor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.I2cslaveAddress).HasDefaultValueSql("((128))");
            entity.Property(e => e.L2cspeed).HasDefaultValueSql("((1))");
            entity.Property(e => e.NumReading).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<PrmReadMultiInput>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ReadTypeId0Navigation).WithMany(p => p.PrmReadMultiInputReadTypeId0Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrmReadMultiInput_ReadTypes");

            entity.HasOne(d => d.ReadTypeId1Navigation).WithMany(p => p.PrmReadMultiInputReadTypeId1Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrmReadMultiInput_ReadTypes1");

            entity.HasOne(d => d.ReadTypeId2Navigation).WithMany(p => p.PrmReadMultiInputReadTypeId2Navigations).HasConstraintName("FK_PrmReadMultiInput_ReadTypes2");

            entity.HasOne(d => d.ReadTypeId3Navigation).WithMany(p => p.PrmReadMultiInputReadTypeId3Navigations).HasConstraintName("FK_PrmReadMultiInput_ReadTypes3");
        });

        modelBuilder.Entity<PrmReadPeakToPeakAnalog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmReadSranalog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmReadSrdigitalMatrix>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmReadSri2cpressureSensor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CommunicationFaultDebounce).HasDefaultValueSql("('8')");
            entity.Property(e => e.CommunicationFaultRetries).HasDefaultValueSql("('3')");
        });

        modelBuilder.Entity<PrmReadSrmultiplex>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmReadSrpeakToPeakAnalog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmReadSrtouchKey>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmReadTouchKey>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmReadVirtualDigital>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmTouchSlider>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmUiaudioBuzzer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<PrmUiaudioExpansion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PrmUIAudioExpasion");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrmUiaudioNuvoton>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasMany(d => d.VisualBoardTypes).WithMany(p => p.ProductTypes)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductTypesVisualBoardType",
                    r => r.HasOne<VisualBoardType>().WithMany()
                        .HasForeignKey("VisualBoardTypeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductTypes_VisualBoardTypes_VisualBoardTypes"),
                    l => l.HasOne<ProductType>().WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductTypes_VisualBoardTypes_ProductTypes"),
                    j =>
                    {
                        j.HasKey("ProductTypeId", "VisualBoardTypeId");
                        j.ToTable("ProductTypes_VisualBoardTypes");
                    });
        });

        modelBuilder.Entity<ProductTypesHighStatement>(entity =>
        {
            entity.HasOne(d => d.HighStatement).WithMany(p => p.ProductTypesHighStatements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypes_HighStatements_HighStatements");

            entity.HasOne(d => d.OpCodeNavigation).WithMany(p => p.ProductTypesHighStatements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypes_HighStatements_OpCodes");

            entity.HasOne(d => d.ProductType).WithMany(p => p.ProductTypesHighStatements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypes_HighStatements_ProductTypes");
        });

        modelBuilder.Entity<ProductTypesHighStatement1>(entity =>
        {
            entity.ToView("ProductTypesHighStatements");
        });

        modelBuilder.Entity<ProductTypesHighStatementsView>(entity =>
        {
            entity.ToView("ProductTypesHighStatementsView");
        });

        modelBuilder.Entity<ProductTypesTask>(entity =>
        {
            entity.HasOne(d => d.ProductType).WithMany(p => p.ProductTypesTasks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypes_Tasks_ProductTypes");

            entity.HasOne(d => d.Task).WithMany(p => p.ProductTypesTasks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypes_Tasks_Tasks");
        });

        modelBuilder.Entity<ProductTypesTask1>(entity =>
        {
            entity.ToView("ProductTypesTasks");
        });

        modelBuilder.Entity<ProductTypesTasksView>(entity =>
        {
            entity.ToView("ProductTypesTasksView");
        });

        modelBuilder.Entity<ProductTypesVariable>(entity =>
        {
            entity.HasOne(d => d.ProductType).WithMany(p => p.ProductTypesVariables)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypes_Variables_ProductTypes");

            entity.HasOne(d => d.Variable).WithMany(p => p.ProductTypesVariables)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypes_Variables_Variables");
        });

        modelBuilder.Entity<ProductTypesVariablesVariableGroupsView>(entity =>
        {
            entity.ToView("ProductTypesVariablesVariableGroupsView");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("PK_Projects_1");

            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_Projects_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.ProjectId).ValueGeneratedNever();

            entity.HasOne(d => d.AcuConfiguration).WithMany(p => p.Projects).HasConstraintName("FK_Projects_Boards");

            entity.HasOne(d => d.HmiConfiguration).WithMany(p => p.Projects).HasConstraintName("FK_Projects_Displays");

            entity.HasOne(d => d.MachineConfiguration).WithMany(p => p.Projects).HasConstraintName("FK_Projects_MachineConfigurations");

            entity.HasOne(d => d.ProductType).WithMany(p => p.Projects)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Projects_ProductTypes");

            entity.HasOne(d => d.SelectorConfiguration).WithMany(p => p.Projects).HasConstraintName("FK_Projects_SelectorConfigurations");

            entity.HasOne(d => d.SettingFileExtensions).WithMany(p => p.Projects).HasConstraintName("FK_Projects_SettingFileExtensions");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.Projects)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Projects_TableTargets");
        });

        modelBuilder.Entity<ProjectsFullView>(entity =>
        {
            entity.ToView("ProjectsFullView");
        });

        modelBuilder.Entity<ProjectsLastRevisionView>(entity =>
        {
            entity.ToView("ProjectsLastRevisionView");
        });

        modelBuilder.Entity<PrtimerBroilConfiguration>(entity =>
        {
            entity.HasKey(e => e.PrtimerBroilConfigId).HasName("PK_PRTimerGrillConfiguration");

            entity.Property(e => e.PrtimerBroilConfigId).ValueGeneratedNever();

            entity.HasOne(d => d.PrtimerBroilTimerLimitConfig).WithMany(p => p.PrtimerBroilConfigurations).HasConstraintName("FK_PRTimerBroilConfiguration_PRTimerBroilTimerLimitConfiguration");
        });

        modelBuilder.Entity<PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration>(entity =>
        {
            entity.HasKey(e => new { e.PrtimerBroilConfigId, e.PrtimerBroilUserPhaseNameConfigId, e.Index }).HasName("PK_PRTimerGrillConfiguration_PRTimerGrillCookModeConfiguration");

            entity.HasOne(d => d.PrtimerBroilConfig).WithMany(p => p.PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerBroilConfiguration_PRTimerBroilUserPhaseNameConfiguration_PRTimerBroilConfiguration");

            entity.HasOne(d => d.PrtimerBroilUserPhaseNameConfig).WithMany(p => p.PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerBroilConfiguration_PRTimerBroilUserPhaseNameConfiguration_PRTimerBroilUserPhaseNameConfiguration");
        });

        modelBuilder.Entity<PrtimerBroilTimerDecrement>(entity =>
        {
            entity.Property(e => e.PrtimerBroilTimerDecrementId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrtimerBroilTimerLimitConfiguration>(entity =>
        {
            entity.Property(e => e.PrtimerBroilTimerLimitConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail>(entity =>
        {
            entity.HasOne(d => d.PrtimerBroilTimerLimitConfig).WithMany(p => p.PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerBroilTimerLimitConfiguration_PRTimerBroilTimerLimitDetails_PRTimerBroilTimerLimitConfiguration");

            entity.HasOne(d => d.PrtimerBroilTimerLimitDetails).WithMany(p => p.PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerBroilTimerLimitConfiguration_PRTimerBroilTimerLimitDetails_PRTimerBroilTimerLimitDetails");
        });

        modelBuilder.Entity<PrtimerBroilTimerLimitDetail>(entity =>
        {
            entity.Property(e => e.PrtimerBroilTimerLimitDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrtimerBroilUserPhaseNameConfiguration>(entity =>
        {
            entity.HasKey(e => e.PrtimerBroilUserPhaseNameConfigId).HasName("PK_PRTimerGrillCookModeConfiguration");

            entity.Property(e => e.PrtimerBroilUserPhaseNameConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail>(entity =>
        {
            entity.HasKey(e => new { e.PrtimerBroilUserPhaseNameConfigId, e.PrtimerBroilUserPhaseNameDetailsId, e.Index }).HasName("PK_PRTimerGrillCookModeConfiguration_PRTimerGrillCookModeDetails");

            entity.HasOne(d => d.PrtimerBroilUserPhaseNameConfig).WithMany(p => p.PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerBroilUserPhaseNameConfiguration_PRTimerBroilUserPhaseNameDetails_PRTimerBroilUserPhaseNameConfiguration");

            entity.HasOne(d => d.PrtimerBroilUserPhaseNameDetails).WithMany(p => p.PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerBroilUserPhaseNameConfiguration_PRTimerBroilUserPhaseNameDetails_PRTimerBroilUserPhaseNameDetails");
        });

        modelBuilder.Entity<PrtimerBroilUserPhaseNameDetail>(entity =>
        {
            entity.HasKey(e => e.PrtimerBroilUserPhaseNameDetailsId).HasName("PK_PRTimerGrillCookModeDetails");

            entity.Property(e => e.PrtimerBroilUserPhaseNameDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrtimerConvectConfiguration>(entity =>
        {
            entity.Property(e => e.PrtimerConvectConfigId).ValueGeneratedNever();

            entity.HasOne(d => d.PrtimerConvectTimerLimitConfig).WithMany(p => p.PrtimerConvectConfigurations).HasConstraintName("FK_PRTimerConvectConfiguration_PRTimerConvectTimerLimitConfiguration");
        });

        modelBuilder.Entity<PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration>(entity =>
        {
            entity.HasKey(e => new { e.PrtimerConvectConfigId, e.PrtimerConvectUserPhaseNameConfigId, e.Index }).HasName("PK_PRTimerConvectConfiguration_PRTimerConvectCookModeConfiguration");

            entity.HasOne(d => d.PrtimerConvectConfig).WithMany(p => p.PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerConvectConfiguration_PRTimerConvectUserPhaseNameConfiguration_PRTimerConvectConfiguration");

            entity.HasOne(d => d.PrtimerConvectUserPhaseNameConfig).WithMany(p => p.PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerConvectConfiguration_PRTimerConvectUserPhaseNameConfiguration_PRTimerConvectUserPhaseNameConfiguration");
        });

        modelBuilder.Entity<PrtimerConvectTimerDecrement>(entity =>
        {
            entity.Property(e => e.PrtimerConvectTimerDecrementId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrtimerConvectTimerLimitConfiguration>(entity =>
        {
            entity.Property(e => e.PrtimerConvectTimerLimitConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail>(entity =>
        {
            entity.HasOne(d => d.PrtimerConvectTimerLimitConfig).WithMany(p => p.PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerConvectTimerLimitConfiguration_PRTimerConvectTimerLimitDetails_PRTimerConvectTimerLimitConfiguration");

            entity.HasOne(d => d.PrtimerConvectTimerLimitDetails).WithMany(p => p.PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerConvectTimerLimitConfiguration_PRTimerConvectTimerLimitDetails_PRTimerConvectTimerLimitDetails");
        });

        modelBuilder.Entity<PrtimerConvectTimerLimitDetail>(entity =>
        {
            entity.Property(e => e.PrtimerConvectTimerLimitDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrtimerConvectUserPhaseNameConfiguration>(entity =>
        {
            entity.HasKey(e => e.PrtimerConvectUserPhaseNameConfigId).HasName("PK_PRTimerConvectCookModeConfiguration");

            entity.Property(e => e.PrtimerConvectUserPhaseNameConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail>(entity =>
        {
            entity.HasKey(e => new { e.PrtimerConvectUserPhaseNameConfigId, e.PrtimerConvectUserPhaseNameDetailsId, e.Index }).HasName("PK_PRTimerConvectCookModeConfiguration_PRTimerConvectCookModeDetails");

            entity.HasOne(d => d.PrtimerConvectUserPhaseNameConfig).WithMany(p => p.PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerConvectUserPhaseNameConfiguration_PRTimerConvectUserPhaseNameDetails_PRTimerConvectUserPhaseNameConfiguration");

            entity.HasOne(d => d.PrtimerConvectUserPhaseNameDetails).WithMany(p => p.PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerConvectUserPhaseNameConfiguration_PRTimerConvectUserPhaseNameDetails_PRTimerConvectUserPhaseNameDetails");
        });

        modelBuilder.Entity<PrtimerConvectUserPhaseNameDetail>(entity =>
        {
            entity.HasKey(e => e.PrtimerConvectUserPhaseNameDetailsId).HasName("PK_PRTimerConvectCookModeDetails");

            entity.Property(e => e.PrtimerConvectUserPhaseNameDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrtimerMagnetronConfiguration>(entity =>
        {
            entity.HasKey(e => e.PrtimerMagnetronConfigId).HasName("PK_TimerBasedMWConfiguration");

            entity.Property(e => e.PrtimerMagnetronConfigId).ValueGeneratedNever();

            entity.HasOne(d => d.PrtimerMagnetronTimerLimitConfig).WithMany(p => p.PrtimerMagnetronConfigurations).HasConstraintName("FK_PRTimerMagnetronConfiguration_PRTimerMagnetronTimerLimitConfiguration");
        });

        modelBuilder.Entity<PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration>(entity =>
        {
            entity.HasKey(e => new { e.PrtimerMagnetronConfigId, e.PrtimerMagnetronUserPhaseNameConfigId, e.Index }).HasName("PK_TimerBasedMWConfiguration_TimerBasedMWCookModeConfiguration");

            entity.HasOne(d => d.PrtimerMagnetronConfig).WithMany(p => p.PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerMagnetronConfiguration_PRTimerMagnetronUserPhaseNameConfiguration_PRTimerMagnetronConfiguration");

            entity.HasOne(d => d.PrtimerMagnetronUserPhaseNameConfig).WithMany(p => p.PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerMagnetronConfiguration_PRTimerMagnetronUserPhaseNameConfiguration_PRTimerMagnetronUserPhaseNameConfiguration");
        });

        modelBuilder.Entity<PrtimerMagnetronTimerDecrement>(entity =>
        {
            entity.HasKey(e => e.PrtimerMagnetronTimerDecrementId).HasName("PK_PRTimerCoolingFan");

            entity.Property(e => e.PrtimerMagnetronTimerDecrementId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrtimerMagnetronTimerLimitConfiguration>(entity =>
        {
            entity.HasKey(e => e.PrtimerMagnetronTimerLimitConfigId).HasName("PK_PRTimerCounterLimitsConfiguration");

            entity.Property(e => e.PrtimerMagnetronTimerLimitConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail>(entity =>
        {
            entity.HasKey(e => new { e.PrtimerMagnetronTimerLimitConfigId, e.PrtimerMagnetronTimerLimitDetailsId, e.Index }).HasName("PK_PRTimerCounterLimitsConfiguration_PRTimerCounterLimitsDetails");

            entity.HasOne(d => d.PrtimerMagnetronTimerLimitConfig).WithMany(p => p.PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerMagnetronTimerLimitConfiguration_PRTimerMagnetronTimerLimitDetails_PRTimerMagnetronTimerLimitConfiguration");

            entity.HasOne(d => d.PrtimerMagnetronTimerLimitDetails).WithMany(p => p.PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerMagnetronTimerLimitConfiguration_PRTimerMagnetronTimerLimitDetails_PRTimerMagnetronTimerLimitDetails");
        });

        modelBuilder.Entity<PrtimerMagnetronTimerLimitDetail>(entity =>
        {
            entity.HasKey(e => e.PrtimerMagnetronTimerLimitDetailsId).HasName("PK_PRTimerCounterLimitsDetails");

            entity.Property(e => e.PrtimerMagnetronTimerLimitDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrtimerMagnetronUserPhaseNameConfiguration>(entity =>
        {
            entity.HasKey(e => e.PrtimerMagnetronUserPhaseNameConfigId).HasName("PK_TimerBasedMWCookModeConfiguration");

            entity.Property(e => e.PrtimerMagnetronUserPhaseNameConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail>(entity =>
        {
            entity.HasKey(e => new { e.PrtimerMagnetronUserPhaseNameConfigId, e.PrtimerMagnetronUserPhaseNameDetailsId, e.Index }).HasName("PK_TimerBasedMWCookModeConfiguration_TimerBasedMWCookModeDetails");

            entity.HasOne(d => d.PrtimerMagnetronUserPhaseNameConfig).WithMany(p => p.PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerMagnetronUserPhaseNameConfiguration_PRTimerMagnetronUserPhaseNameDetails_PRTimerMagnetronUserPhaseNameConfiguration");

            entity.HasOne(d => d.PrtimerMagnetronUserPhaseNameDetails).WithMany(p => p.PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRTimerMagnetronUserPhaseNameConfiguration_PRTimerMagnetronUserPhaseNameDetails_PRTimerMagnetronUserPhaseNameDetails");
        });

        modelBuilder.Entity<PrtimerMagnetronUserPhaseNameDetail>(entity =>
        {
            entity.HasKey(e => e.PrtimerMagnetronUserPhaseNameDetailsId).HasName("PK_TimerBasedMWCookModeDetails");

            entity.Property(e => e.PrtimerMagnetronUserPhaseNameDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Selector>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_Selectors_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.SelectorId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Code).HasDefaultValueSql("((0))");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.DelayUimacro).WithMany(p => p.SelectorDelayUimacros).HasConstraintName("FK_Selectors_UIMacros2");

            entity.HasOne(d => d.EndUimacro).WithMany(p => p.SelectorEndUimacros).HasConstraintName("FK_Selectors_UIMacros4");

            entity.HasOne(d => d.GlobalUimacro).WithMany(p => p.SelectorGlobalUimacros).HasConstraintName("FK_Selectors_UIMacros");

            entity.HasOne(d => d.OffMacro).WithMany(p => p.Selectors).HasConstraintName("FK_Selectors_Macros");

            entity.HasOne(d => d.OffUimacro).WithMany(p => p.SelectorOffUimacros).HasConstraintName("FK_Selectors_UIMacros5");

            entity.HasOne(d => d.PauseUimacro).WithMany(p => p.SelectorPauseUimacros).HasConstraintName("FK_Selectors_UIMacros3");

            entity.HasOne(d => d.ProgrammingUimacro).WithMany(p => p.SelectorProgrammingUimacros).HasConstraintName("FK_Selectors_UIMacros1");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.Selectors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Selectors_TableTargets");

            entity.HasOne(d => d.UiuserFunctionConfiguration).WithMany(p => p.Selectors).HasConstraintName("FK_Selectors_UIFunctionConfigurations");
        });

        modelBuilder.Entity<SelectorConfiguration>(entity =>
        {
            entity.Property(e => e.SelectorConfigurationId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Code).HasDefaultValueSql("('00000000000')");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.GlobalUimacro).WithMany(p => p.SelectorConfigurations).HasConstraintName("FK_SelectorConfigurations_UIMacros");

            entity.HasOne(d => d.UiuserFunctionConfiguration).WithMany(p => p.SelectorConfigurations).HasConstraintName("FK_SelectorConfigurations_UIFunctionConfigurations");
        });

        modelBuilder.Entity<SelectorConfigurationsSelector>(entity =>
        {
            entity.HasOne(d => d.SelectorConfiguration).WithMany(p => p.SelectorConfigurationsSelectors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SelectorConfigurations_Selectors_SelectorConfigurations");

            entity.HasOne(d => d.Selector).WithMany(p => p.SelectorConfigurationsSelectors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SelectorConfigurations_Selectors_Selectors");
        });

        modelBuilder.Entity<SelectorToMacroStatement>(entity =>
        {
            entity.ToView("SelectorToMacroStatements");
        });

        modelBuilder.Entity<SelectorsCycle>(entity =>
        {
            entity.Property(e => e.Priority).HasDefaultValueSql("((255))");

            entity.HasOne(d => d.Condition).WithMany(p => p.SelectorsCycles).HasConstraintName("FK_Selectors_Cycles_Conditions");

            entity.HasOne(d => d.Cycle).WithMany(p => p.SelectorsCycles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Selectors_Cycles_Cycles");

            entity.HasOne(d => d.SelectorCondition).WithMany(p => p.SelectorsCycles).HasConstraintName("FK_Selectors_Cycles_UIFunctionConditions");

            entity.HasOne(d => d.Selector).WithMany(p => p.SelectorsCycles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Selectors_Cycles_Selectors");
        });

        modelBuilder.Entity<SetStateEndCompletionType>(entity =>
        {
            entity.Property(e => e.HighStatementId).HasDefaultValueSql("((2))");
        });

        modelBuilder.Entity<SetVariableOperation>(entity =>
        {
            entity.HasKey(e => e.OperationId).HasName("PK_StmSetVariableOperators");

            entity.Property(e => e.Operation).IsFixedLength();
        });

        modelBuilder.Entity<SettingFileExtension>(entity =>
        {
            entity.Property(e => e.SettingFileExtensionsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<SettingsFileSize>(entity =>
        {
            entity.Property(e => e.Size).ValueGeneratedNever();
        });

        modelBuilder.Entity<SrboilerOverTempCheckParameter>(entity =>
        {
            entity.Property(e => e.SrboilerOverTempCheckParamsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<SrexpansionConfiguration>(entity =>
        {
            entity.Property(e => e.SrexpansionConfigurationsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<SrexpansionConfigurationsSrexpansionDetail>(entity =>
        {
            entity.HasOne(d => d.SrexpansionConfigurations).WithMany(p => p.SrexpansionConfigurationsSrexpansionDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SRExpansionConfigurations_SRExpansionDetails_SRExpansionConfigurations");

            entity.HasOne(d => d.SrexpansionDetails).WithMany(p => p.SrexpansionConfigurationsSrexpansionDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SRExpansionConfigurations_SRExpansionDetails_SRExpansionDetails");
        });

        modelBuilder.Entity<SrexpansionDetail>(entity =>
        {
            entity.Property(e => e.SrexpansionDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<SrfanSpeedCheckParameter>(entity =>
        {
            entity.Property(e => e.SrFanSpeedCheckParamsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<SrhmieventCheckParameter>(entity =>
        {
            entity.Property(e => e.SrhmieventCheckParametersId).ValueGeneratedNever();
        });

        modelBuilder.Entity<SroverTempCheckParameter>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Rtd1openedSensorThreshold).HasDefaultValueSql("((3000))");
            entity.Property(e => e.Rtd1shortedSensorThreshold).HasDefaultValueSql("((1500))");
            entity.Property(e => e.Rtd2openedSensorThreshold).HasDefaultValueSql("((3000))");
            entity.Property(e => e.Rtd2shortedSensorThreshold).HasDefaultValueSql("((1500))");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<SrpcbcheckParameter>(entity =>
        {
            entity.Property(e => e.SrpcbcheckParamsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<SrpinShortCheckParameter>(entity =>
        {
            entity.Property(e => e.SrPinShortCheckParamsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<SrplausibilityCheckParameter>(entity =>
        {
            entity.Property(e => e.SrPlausibilityCheckParamsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<SrsafetyRelevantParameter>(entity =>
        {
            entity.Property(e => e.SrsafetyParametersId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.SrFanSpeedCheckParams).WithMany(p => p.SrsafetyRelevantParameters).HasConstraintName("FK_SRSafetyRelevantParameters_SRFanSpeedCheckParameters");

            entity.HasOne(d => d.SrPinShortCheckParams).WithMany(p => p.SrsafetyRelevantParameters).HasConstraintName("FK_SRSafetyRelevantParameters_SRPinShortCheckParameters");

            entity.HasOne(d => d.SrPlausibilityCheckParams).WithMany(p => p.SrsafetyRelevantParameters).HasConstraintName("FK_SRSafetyRelevantParameters_SRPlausibilityCheckParameters");

            entity.HasOne(d => d.SrStuckProbeCheckParams).WithMany(p => p.SrsafetyRelevantParameters).HasConstraintName("FK_SRSafetyRelevantParameters_SRStuckProbeCheckParameters");

            entity.HasOne(d => d.SrboilerOverTempCheckParams).WithMany(p => p.SrsafetyRelevantParameters).HasConstraintName("FK_SRSafetyRelevantParameters_SRBoilerOverTempCheckParameters");

            entity.HasOne(d => d.SrexpansionConfigurations).WithMany(p => p.SrsafetyRelevantParameters).HasConstraintName("FK_SRSafetyRelevantParameters_SRExpansionConfigurations");

            entity.HasOne(d => d.SrhmieventCheckParameters).WithMany(p => p.SrsafetyRelevantParameters).HasConstraintName("FK_SRSafetyRelevantParameters_SRHMIEventCheckParameters");

            entity.HasOne(d => d.SroverTempCheck).WithMany(p => p.SrsafetyRelevantParameters).HasConstraintName("FK_SRSafetyRelevantParameters_SROverTempCheckParameters");

            entity.HasOne(d => d.SrpcbcheckParams).WithMany(p => p.SrsafetyRelevantParameters).HasConstraintName("FK_SRSafetyRelevantParameters_SRPCBCheckParameters");
        });

        modelBuilder.Entity<SrstuckProbeCheckParameter>(entity =>
        {
            entity.Property(e => e.SrStuckProbeCheckParamsId).ValueGeneratedNever();
            entity.Property(e => e.DebounceThreshold).HasDefaultValueSql("((5))");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
            entity.Property(e => e.VarianceThreshold).HasDefaultValueSql("((4))");
        });

        modelBuilder.Entity<Statement>(entity =>
        {
            entity.Property(e => e.StatementId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<StatementModifier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StatementsModifier");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<StatementTableModifier>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<StatusVariable>(entity =>
        {
            entity.Property(e => e.StatusVariableId).ValueGeneratedNever();
            entity.Property(e => e.StatusVariableGroups).HasDefaultValueSql("(0x)");
            entity.Property(e => e.StatusVariables).HasDefaultValueSql("(0x)");

            entity.HasOne(d => d.ProductType).WithMany(p => p.StatusVariables)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StatusVariables_ProductTypes");
        });

        modelBuilder.Entity<StmActivateTask>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<StmHeat>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.PyroTargetTime).HasDefaultValueSql("((30))");

            entity.HasOne(d => d.ConvectionFan1).WithMany(p => p.StmHeatConvectionFan1s).HasConstraintName("FK_StmHeat_HeatConvectionFanParameters");

            entity.HasOne(d => d.ConvectionFan2).WithMany(p => p.StmHeatConvectionFan2s).HasConstraintName("FK_StmHeat_HeatConvectionFanParameters1");

            entity.HasOne(d => d.LbclosedLoop).WithMany(p => p.StmHeats).HasConstraintName("FK_StmHeat_HeatLoadBalancingClosedLoop");

            entity.HasOne(d => d.LbopenLoop).WithMany(p => p.StmHeats).HasConstraintName("FK_StmHeat_HeatLoadBalancingOpenLoop");

            entity.HasOne(d => d.PidConfiguration).WithMany(p => p.StmHeats).HasConstraintName("FK_StmHeat_HeatPidConfigurationParameters");
        });

        modelBuilder.Entity<StmHeatInitializeSelector>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.HeatInitialize).WithMany(p => p.StmHeatInitializeSelectors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StmHeatInitializeSelector_HeatInitialize");
        });

        modelBuilder.Entity<StmHeatRun>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StmHeatWithLoadBalancing");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ConvectionFan1).WithMany(p => p.StmHeatRunConvectionFan1s).HasConstraintName("FK_StmHeatRun_HeatLBConvectionFan1Parameters");

            entity.HasOne(d => d.ConvectionFan2).WithMany(p => p.StmHeatRunConvectionFan2s).HasConstraintName("FK_StmHeatRun_HeatLBConvectionFan2Parameters");

            entity.HasOne(d => d.LoadBalancing).WithMany(p => p.StmHeatRuns).HasConstraintName("FK_StmHeatWithLoadBalancing_LoadBalancingParameters");

            entity.HasOne(d => d.PidConfiguration).WithMany(p => p.StmHeatRuns).HasConstraintName("FK_StmHeatWithLoadBalancing_PidConfiguartionParameters");
        });

        modelBuilder.Entity<StmHeatRunView>(entity =>
        {
            entity.ToView("StmHeatRunView");
        });

        modelBuilder.Entity<StmInduction>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Level).HasDefaultValueSql("((0))");
            entity.Property(e => e.Mode).HasDefaultValueSql("((0))");
            entity.Property(e => e.Wattage).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<StmJumpIf>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Condition).WithMany(p => p.StmJumpIfs).HasConstraintName("FK_StmJumpIf_Conditions");

            entity.HasOne(d => d.JumpIfPredictionBehavior).WithMany(p => p.StmJumpIfs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StmJumpIf_JumpIfPredictionBehaviors");
        });

        modelBuilder.Entity<StmLoadsControl>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ActivateOptions).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Condition).WithMany(p => p.StmLoadsControlConditions).HasConstraintName("FK_StmLoadsControl_Conditions");

            entity.HasOne(d => d.DeactivationCondition).WithMany(p => p.StmLoadsControlDeactivationConditions).HasConstraintName("FK_StmLoadsControl_Conditions_Deactivation");

            entity.HasOne(d => d.PilotParameters).WithMany(p => p.StmLoadsControls).HasConstraintName("FK_StmLoadsControl_StmLoadsControlPilotParameters");
        });

        modelBuilder.Entity<StmMaintain>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Condition).WithMany(p => p.StmMaintains).HasConstraintName("FK_StmMaintain_Conditions");

            entity.HasOne(d => d.Modifiers).WithMany(p => p.StmMaintains).HasConstraintName("FK_StmMaintain_Modifiers");
        });

        modelBuilder.Entity<StmSetState>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<StmSetVariable>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ModifierNavigation).WithMany(p => p.StmSetVariableModifierNavigations).HasConstraintName("FK_StmSetVariable_Modifiers");

            entity.HasOne(d => d.Modifier1Navigation).WithMany(p => p.StmSetVariableModifier1Navigations).HasConstraintName("FK_StmSetVariable_Modifiers1");

            entity.HasOne(d => d.Modifier2Navigation).WithMany(p => p.StmSetVariableModifier2Navigations).HasConstraintName("FK_StmSetVariable_Modifiers2");

            entity.HasOne(d => d.Modifier3Navigation).WithMany(p => p.StmSetVariableModifier3Navigations).HasConstraintName("FK_StmSetVariable_Modifiers3");

            entity.HasOne(d => d.Modifier4Navigation).WithMany(p => p.StmSetVariableModifier4Navigations).HasConstraintName("FK_StmSetVariable_Modifiers4");

            entity.HasOne(d => d.Modifier5Navigation).WithMany(p => p.StmSetVariableModifier5Navigations).HasConstraintName("FK_StmSetVariable_Modifiers5");

            entity.HasOne(d => d.Modifier6Navigation).WithMany(p => p.StmSetVariableModifier6Navigations).HasConstraintName("FK_StmSetVariable_Modifiers6");

            entity.HasOne(d => d.Modifier7Navigation).WithMany(p => p.StmSetVariableModifier7Navigations).HasConstraintName("FK_StmSetVariable_Modifiers7");

            entity.HasOne(d => d.Modifier8Navigation).WithMany(p => p.StmSetVariableModifier8Navigations).HasConstraintName("FK_StmSetVariable_Modifiers8");

            entity.HasOne(d => d.Modifier9Navigation).WithMany(p => p.StmSetVariableModifier9Navigations).HasConstraintName("FK_StmSetVariable_Modifiers9");

            entity.HasOne(d => d.ProductType).WithMany(p => p.StmSetVariables)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StmSetVariable_ProductTypes");
        });

        modelBuilder.Entity<StmSetupMeatProbe>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<StmSetupTempSelector>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.HeatInitialize).WithMany(p => p.StmSetupTempSelectors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StmSetupTempSelector_HeatInitialize");
        });

        modelBuilder.Entity<Structure>(entity =>
        {
            entity.Property(e => e.StructureId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ThermalConfigDatum>(entity =>
        {
            entity.Property(e => e.ThermalConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<TimeEstimation>(entity =>
        {
            entity.Property(e => e.TimeEstimationId).ValueGeneratedNever();

            entity.HasOne(d => d.Modifier).WithMany(p => p.TimeEstimations).HasConstraintName("FK_TimeEstimation_Modifiers");
        });

        modelBuilder.Entity<TimeEstimationConfiguration>(entity =>
        {
            entity.Property(e => e.TimeEstimationConfigurationId).ValueGeneratedNever();
        });

        modelBuilder.Entity<TimeEstimationConfigurationsTimeEstimationDetail>(entity =>
        {
            entity.HasOne(d => d.TimeEstimationConfiguration).WithMany(p => p.TimeEstimationConfigurationsTimeEstimationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeEstimationConfigurations_TimeEstimationDetails_TimeEstimationConfigurations");

            entity.HasOne(d => d.TimeEstimationDetail).WithMany(p => p.TimeEstimationConfigurationsTimeEstimationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeEstimationConfigurations_TimeEstimationDetails_TimeEstimationDetails");
        });

        modelBuilder.Entity<TimeEstimationDetail>(entity =>
        {
            entity.Property(e => e.TimeEstimationDetailId).ValueGeneratedNever();

            entity.HasOne(d => d.Modifiers).WithMany(p => p.TimeEstimationDetails).HasConstraintName("FK_TimeEstimationDetails_Modifiers");
        });

        modelBuilder.Entity<UianimationBlinkType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<UianimationConfiguration>(entity =>
        {
            entity.HasKey(e => e.UianimationConfigurationId).HasName("PK_UIAnimationConfiguration");

            entity.Property(e => e.UianimationConfigurationId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UianimationConfigurationsUianimationDetail>(entity =>
        {
            entity.HasOne(d => d.UianimationConfiguration).WithMany(p => p.UianimationConfigurationsUianimationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIAnimationConfigurations_UIAnimationDetails_UIAnimationConfigurations");

            entity.HasOne(d => d.UianimationDetails).WithMany(p => p.UianimationConfigurationsUianimationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIAnimationConfigurations_UIAnimationDetails_UIAnimationDetails");
        });

        modelBuilder.Entity<UianimationDetail>(entity =>
        {
            entity.Property(e => e.UianimationDetailsId).ValueGeneratedNever();
            entity.Property(e => e.AnimationFunction).HasDefaultValueSql("((4095))");
            entity.Property(e => e.Compartment).HasDefaultValueSql("((15))");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.UianimationBlinkType).WithMany(p => p.UianimationDetails).HasConstraintName("FK_UIAnimationDetails_UIAnimationBlinkType");

            entity.HasOne(d => d.UianimationFadingType).WithMany(p => p.UianimationDetails).HasConstraintName("FK_UIAnimationDetails_UIAnimationFadingType");

            entity.HasOne(d => d.UianimationFrameType).WithMany(p => p.UianimationDetails).HasConstraintName("FK_UIAnimationDetails_UIAnimationFrameConfigurations");

            entity.HasOne(d => d.UianimationSequenceType).WithMany(p => p.UianimationDetails).HasConstraintName("FK_UIAnimationDetails_UIAnimationSequenceType");
        });

        modelBuilder.Entity<UianimationFadingType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UIAnimationFadingType_1");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UianimationFrameConfiguration>(entity =>
        {
            entity.HasKey(e => e.UianimationFrameConfigurationsId).HasName("PK_UIAnimationFrame");

            entity.Property(e => e.UianimationFrameConfigurationsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UianimationFrameConfigurationsUianimationFrameDetail>(entity =>
        {
            entity.HasOne(d => d.UianimationFrameConfigurations).WithMany(p => p.UianimationFrameConfigurationsUianimationFrameDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIAnimationFrameConfigurations_UIAnimationFrameDetails_UIAnimationFrameConfigurations");

            entity.HasOne(d => d.UianimationFrameDetails).WithMany(p => p.UianimationFrameConfigurationsUianimationFrameDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIAnimationFrameConfigurations_UIAnimationFrameDetails_UIAnimationFrameDetails");
        });

        modelBuilder.Entity<UianimationFrameDetail>(entity =>
        {
            entity.Property(e => e.UianimationFrameDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UianimationSequenceType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UiaudioBuzzerDetail>(entity =>
        {
            entity.HasKey(e => e.PrmUiaudioBuzzerDetailsId).HasName("PK_PrmUIAudioBuzzerDetails");

            entity.Property(e => e.PrmUiaudioBuzzerDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UiaudioBuzzerUiaudioBuzzerDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.PrmUiaudioBuzzerDetailsId, e.Index }).HasName("PK_PrmUIAudioBuzzer_PrmUIAudioBuzzerDetails");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.UiaudioBuzzerUiaudioBuzzerDetails).HasConstraintName("FK_PrmUIAudioBuzzer_PrmUIAudioBuzzerDetails_PrmUIAudioBuzzer");

            entity.HasOne(d => d.PrmUiaudioBuzzerDetails).WithMany(p => p.UiaudioBuzzerUiaudioBuzzerDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrmUIAudioBuzzer_PrmUIAudioBuzzerDetails_PrmUIAudioBuzzerDetails");
        });

        modelBuilder.Entity<UiaudioConfiguration>(entity =>
        {
            entity.Property(e => e.UiaudioConfigurationsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UiaudioConfigurationsUiaudioDetail>(entity =>
        {
            entity.HasOne(d => d.UiaudioConfigurations).WithMany(p => p.UiaudioConfigurationsUiaudioDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIAudioConfigurations_UIAudioDetails_UIAudioConfigurations");

            entity.HasOne(d => d.UiaudioDetails).WithMany(p => p.UiaudioConfigurationsUiaudioDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIAudioConfigurations_UIAudioDetails_UIAudioDetails");
        });

        modelBuilder.Entity<UiaudioDetail>(entity =>
        {
            entity.Property(e => e.UiaudioDetailsId).ValueGeneratedNever();
            entity.Property(e => e.AudioFunction).HasDefaultValueSql("((4095))");
            entity.Property(e => e.Compartment).HasDefaultValueSql("((15))");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UiaudioFunction>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<UiclassBeventConfiguration>(entity =>
        {
            entity.Property(e => e.UiclassBeventConfigurationId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.UiclassBeventConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIClassBEventConfigurations_TableTargets");
        });

        modelBuilder.Entity<UiclassBeventConfigurationsUiclassBeventDetail>(entity =>
        {
            entity.HasOne(d => d.UiclassBeventConfiguration).WithMany(p => p.UiclassBeventConfigurationsUiclassBeventDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIClassBEventConfigurations_UIClassBEventDetails_UIClassBEventConfigurations");

            entity.HasOne(d => d.UiclassBeventDetail).WithMany(p => p.UiclassBeventConfigurationsUiclassBeventDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIClassBEventConfigurations_UIClassBEventDetails_UIClassBEventDetails");
        });

        modelBuilder.Entity<UiclassBeventDetail>(entity =>
        {
            entity.HasKey(e => e.UiclassBeventDetailId).HasName("PK_GenericInputDetails");

            entity.Property(e => e.UiclassBeventDetailId).ValueGeneratedNever();

            entity.HasOne(d => d.Srinput).WithMany(p => p.UiclassBeventDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIClassBEventDetails_UIGenericInputReadTypes");
        });

        modelBuilder.Entity<Uicondition>(entity =>
        {
            entity.Property(e => e.UiconditionId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UiconditionBlock>(entity =>
        {
            entity.Property(e => e.UiconditionBlockId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.VariableGroups).HasDefaultValueSql("((255))");

            entity.HasOne(d => d.Uioperator).WithMany(p => p.UiconditionBlocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIConditionBlocks_UIOperators");
        });

        modelBuilder.Entity<UicypressTouchParameter>(entity =>
        {
            entity.HasKey(e => e.UicypressTouchId).HasName("PK_CypressTouchParameters");

            entity.Property(e => e.UicypressTouchId).ValueGeneratedNever();
            entity.Property(e => e.I2cspeed).HasDefaultValueSql("((1))");
            entity.Property(e => e.LpmsensorBitmap)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.PositionsTouchSliders1).HasDefaultValueSql("(0x00000000)");
            entity.Property(e => e.PositionsTouchSliders2).HasDefaultValueSql("(0x00000000)");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.SensorsDataTouchSliders1).HasDefaultValueSql("(0x000000000000000000000000000000000000000000000000)");
            entity.Property(e => e.SensorsDataTouchSliders2).HasDefaultValueSql("(0x000000000000000000000000000000000000000000000000)");
            entity.Property(e => e.SensorsTouchSliders1).HasDefaultValueSql("(0x00000000)");
            entity.Property(e => e.SensorsTouchSliders2).HasDefaultValueSql("(0x00000000)");
            entity.Property(e => e.StuckKeyTimeout).HasDefaultValueSql("((20))");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UidataModelKeyMapping>(entity =>
        {
            entity.Property(e => e.UidataModelKeyMappingId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.KeyModifierId0Navigation).WithMany(p => p.UidataModelKeyMappingKeyModifierId0Navigations).HasConstraintName("FK_UIDataModelKeyMapping_Modifiers");

            entity.HasOne(d => d.KeyModifierId1Navigation).WithMany(p => p.UidataModelKeyMappingKeyModifierId1Navigations).HasConstraintName("FK_UIDataModelKeyMapping_Modifiers1");

            entity.HasOne(d => d.KeyModifierId2Navigation).WithMany(p => p.UidataModelKeyMappingKeyModifierId2Navigations).HasConstraintName("FK_UIDataModelKeyMapping_Modifiers2");

            entity.HasOne(d => d.KeyModifierId3Navigation).WithMany(p => p.UidataModelKeyMappingKeyModifierId3Navigations).HasConstraintName("FK_UIDataModelKeyMapping_Modifiers3");

            entity.HasOne(d => d.KeyModifierId4Navigation).WithMany(p => p.UidataModelKeyMappingKeyModifierId4Navigations).HasConstraintName("FK_UIDataModelKeyMapping_Modifiers4");

            entity.HasOne(d => d.KeyModifierId5Navigation).WithMany(p => p.UidataModelKeyMappingKeyModifierId5Navigations).HasConstraintName("FK_UIDataModelKeyMapping_Modifiers5");

            entity.HasOne(d => d.KeyModifierId6Navigation).WithMany(p => p.UidataModelKeyMappingKeyModifierId6Navigations).HasConstraintName("FK_UIDataModelKeyMapping_Modifiers6");

            entity.HasOne(d => d.KeyModifierId7Navigation).WithMany(p => p.UidataModelKeyMappingKeyModifierId7Navigations).HasConstraintName("FK_UIDataModelKeyMapping_Modifiers7");

            entity.HasOne(d => d.KeyModifierId8Navigation).WithMany(p => p.UidataModelKeyMappingKeyModifierId8Navigations).HasConstraintName("FK_UIDataModelKeyMapping_Modifiers8");

            entity.HasOne(d => d.KeyModifierId9Navigation).WithMany(p => p.UidataModelKeyMappingKeyModifierId9Navigations).HasConstraintName("FK_UIDataModelKeyMapping_Modifiers9");
        });

        modelBuilder.Entity<UidataModelTranslationConfiguration>(entity =>
        {
            entity.Property(e => e.UidataModelTranslationConfigurationId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UidataModelTranslationConfigurationsUidataModelTranslationDetail>(entity =>
        {
            entity.HasOne(d => d.UidataModelTranslationConfiguration).WithMany(p => p.UidataModelTranslationConfigurationsUidataModelTranslationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIDataModelTranslationConfigurations_UIDataModelTranslationDetails_UIDataModelTranslationConfigurations");

            entity.HasOne(d => d.UidataModelTranslationDetail).WithMany(p => p.UidataModelTranslationConfigurationsUidataModelTranslationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIDataModelTranslationConfigurations_UIDataModelTranslationDetails_UIDataModelTranslationDetails");
        });

        modelBuilder.Entity<UidataModelTranslationDetail>(entity =>
        {
            entity.Property(e => e.UidataModelTranslationDetailId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.UidataModelKeyMapping).WithMany(p => p.UidataModelTranslationDetails).HasConstraintName("FK_UIDataModelTranslationDetails_UIDataModelKeyMapping");
        });

        modelBuilder.Entity<UidefaultPinConfiguration>(entity =>
        {
            entity.Property(e => e.UidefaultPinConfigurationId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UidefaultPinConfigurationsUidefaultPinDetail>(entity =>
        {
            entity.HasOne(d => d.UidefaultPinConfiguration).WithMany(p => p.UidefaultPinConfigurationsUidefaultPinDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIDefaultPinConfigurations_UIDefaultPinDetails_UIDefaultPinConfigurations");

            entity.HasOne(d => d.UidefaultPinDetail).WithMany(p => p.UidefaultPinConfigurationsUidefaultPinDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIDefaultPinConfigurations_UIDefaultPinDetails_UIDefaultPinDetails");
        });

        modelBuilder.Entity<UidefaultPinDetail>(entity =>
        {
            entity.Property(e => e.UidefaultPinDetailId).ValueGeneratedNever();

            entity.HasOne(d => d.GpioPinType).WithMany(p => p.UidefaultPinDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIDefaultPinDetails_DefaultGpioPinTypes");
        });

        modelBuilder.Entity<UifunctionCondition>(entity =>
        {
            entity.Property(e => e.ConditionId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ConditionBlock1).WithMany(p => p.UifunctionConditionConditionBlock1s).HasConstraintName("FK_UIFunctionConditions_UIConditionBlocks_1");

            entity.HasOne(d => d.ConditionBlock2).WithMany(p => p.UifunctionConditionConditionBlock2s).HasConstraintName("FK_UIFunctionConditions_UIConditionBlocks_2");

            entity.HasOne(d => d.ConditionBlock3).WithMany(p => p.UifunctionConditionConditionBlock3s).HasConstraintName("FK_UIFunctionConditions_UIConditionBlocks_3");

            entity.HasOne(d => d.ConditionBlock4).WithMany(p => p.UifunctionConditionConditionBlock4s).HasConstraintName("FK_UIFunctionConditions_UIConditionBlocks_4");

            entity.HasOne(d => d.ConditionBlock5).WithMany(p => p.UifunctionConditionConditionBlock5s).HasConstraintName("FK_UIFunctionConditions_UIConditionBlocks_5");

            entity.HasOne(d => d.ConditionBlock6).WithMany(p => p.UifunctionConditionConditionBlock6s).HasConstraintName("FK_UIFunctionConditions_UIConditionBlocks_6");

            entity.HasOne(d => d.ConditionBlock7).WithMany(p => p.UifunctionConditionConditionBlock7s).HasConstraintName("FK_UIFunctionConditions_UIConditionBlocks_7");

            entity.HasOne(d => d.ConditionBlock8).WithMany(p => p.UifunctionConditionConditionBlock8s).HasConstraintName("FK_UIFunctionConditions_UIConditionBlocks_8");
        });

        modelBuilder.Entity<UifunctionConfiguration>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_UIFunctionConfigurations_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.UifunctionConfigurationId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.UifunctionConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIFunctionConfigurations_TableTargets");
        });

        modelBuilder.Entity<UifunctionConfigurationsUifunctionDetail>(entity =>
        {
            entity.HasOne(d => d.FunctionLabelNavigation).WithMany(p => p.UifunctionConfigurationsUifunctionDetails).HasConstraintName("FK_UIFunctionConfigurations_UIFunctionDetails_FunctionLabels");

            entity.HasOne(d => d.UifunctionConfiguration).WithMany(p => p.UifunctionConfigurationsUifunctionDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIFunctionConfigurations_UIFunctionDetails_UIFunctionConfigurations");

            entity.HasOne(d => d.UifunctionDetail).WithMany(p => p.UifunctionConfigurationsUifunctionDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIFunctionConfigurations_UIFunctionDetails_UIFunctionDetails");

            entity.HasOne(d => d.UiregulationTable).WithMany(p => p.UifunctionConfigurationsUifunctionDetails).HasConstraintName("FK_UIFunctionConfigurations_UIFunctionDetails_UIRegulationTables");
        });

        modelBuilder.Entity<UifunctionDetail>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_UIFunctionDetails_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.UifunctionDetailId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.FactoryRestoreIndex).HasDefaultValueSql("((1))");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.UifunctionDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIFunctionDetails_TableTargets");
        });

        modelBuilder.Entity<UigenericInputConfiguration>(entity =>
        {
            entity.HasKey(e => e.UigenericInputConfigurationId).HasName("PK_UIGenericInputConfiguration");

            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_UIGenericInputConfigurations_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.UigenericInputConfigurationId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.UigenericInputConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIGenericInputConfigurations_TableTargets");

            entity.HasOne(d => d.UiinputEventMappingConfiguration).WithMany(p => p.UigenericInputConfigurations).HasConstraintName("FK_UIGenericInputConfigurations_UIInputEventMappingConfigurations");
        });

        modelBuilder.Entity<UigenericInputConfigurationsUigenericInputDetail>(entity =>
        {
            entity.HasOne(d => d.UigenericInputConfiguration).WithMany(p => p.UigenericInputConfigurationsUigenericInputDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIGenericInputConfigurations_UIGenericInputDetails_UIGenericInputConfiguration");

            entity.HasOne(d => d.UigenericInputDetail).WithMany(p => p.UigenericInputConfigurationsUigenericInputDetails).HasConstraintName("FK_UIGenericInputConfigurations_UIGenericInputDetails_UIGenericInputDetails");
        });

        modelBuilder.Entity<UigenericInputDetail>(entity =>
        {
            entity.Property(e => e.UigenericInputDetailId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.LlireadType).WithMany(p => p.UigenericInputDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIGenericInputDetails_ReadTypes");

            entity.HasOne(d => d.Uiinput).WithMany(p => p.UigenericInputDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIGenericInputDetails_UIInputs");
        });

        modelBuilder.Entity<UigenericInputReadType>(entity =>
        {
            entity.HasKey(e => e.UireadTypeId).HasName("PK_UIReadTypes");
        });

        modelBuilder.Entity<UihighStatement>(entity =>
        {
            entity.HasOne(d => d.OpCodeNavigation).WithMany(p => p.UihighStatements).HasConstraintName("FK_UIHighStatements_UIOpCodes");
        });

        modelBuilder.Entity<Uiinput>(entity =>
        {
            entity.HasOne(d => d.GireadType).WithMany(p => p.Uiinputs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIInputs_UIGenericInputReadTypes");

            entity.HasOne(d => d.LlireadType).WithMany(p => p.Uiinputs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIInputs_ReadTypes");

            entity.HasMany(d => d.ReadTypes).WithMany(p => p.UiinputsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "UiinputsReadType",
                    r => r.HasOne<ReadType>().WithMany()
                        .HasForeignKey("ReadTypeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UIInputs_ReadTypes_ReadTypes"),
                    l => l.HasOne<Uiinput>().WithMany()
                        .HasForeignKey("UiinputId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UIInputs_ReadTypes_UIInputs"),
                    j =>
                    {
                        j.HasKey("UiinputId", "ReadTypeId");
                        j.ToTable("UIInputs_ReadTypes");
                        j.IndexerProperty<byte>("UiinputId").HasColumnName("UIInputId");
                    });
        });

        modelBuilder.Entity<UiinputEvent>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<UiinputEventMappingConfiguration>(entity =>
        {
            entity.Property(e => e.UiinputEventMappingConfigurationId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UiinputEventMappingConfigurationsUiinputEventMappingDetail>(entity =>
        {
            entity.HasOne(d => d.UiinputEventMappingConfiguration).WithMany(p => p.UiinputEventMappingConfigurationsUiinputEventMappingDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIInputEventMappingConfigurations_UIInputEventMappingDetails_UIInputEventMappingConfigurations");

            entity.HasOne(d => d.UiinputEventMappingDetails).WithMany(p => p.UiinputEventMappingConfigurationsUiinputEventMappingDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIInputEventMappingConfigurations_UIInputEventMappingDetails_UIInputEventMappingDetails");
        });

        modelBuilder.Entity<UiinputEventMappingDetail>(entity =>
        {
            entity.Property(e => e.UiinputEventMappingDetailsId).ValueGeneratedNever();
            entity.Property(e => e.UigireadTypePosition).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value11).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value12).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value13).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value14).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value15).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value16).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value17).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value18).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value19).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value20).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value21).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value22).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value23).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value24).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value25).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value26).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value27).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value28).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value29).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value30).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value31).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value32).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UiledConfiguration>(entity =>
        {
            entity.Property(e => e.UiledConfigurationsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.UiledFunctionMappingConfig).WithMany(p => p.UiledConfigurations).HasConstraintName("FK_UILedConfigurations_UILedFunctionMappingConfigurations");
        });

        modelBuilder.Entity<UiledConfigurationsUiledDriverParameter>(entity =>
        {
            entity.HasOne(d => d.UiledConfigurations).WithMany(p => p.UiledConfigurationsUiledDriverParameters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UILedConfigurations_UILedDriverParameters_UILedConfigurations");

            entity.HasOne(d => d.UiledDriverParameters).WithMany(p => p.UiledConfigurationsUiledDriverParameters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UILedConfigurations_UILedDriverParameters_UILedDriverParameters");
        });

        modelBuilder.Entity<UiledDriverParameter>(entity =>
        {
            entity.Property(e => e.UiledDriverParametersId).ValueGeneratedNever();

            entity.HasOne(d => d.LedType).WithMany(p => p.UiledDriverParameters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UILedDriverParameters_UILedDriverTypes");
        });

        modelBuilder.Entity<UiledFunction>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<UiledFunctionMappingConfiguration>(entity =>
        {
            entity.Property(e => e.UiledFunctionMappingConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UiledFunctionMappingConfigurationsUiledFunctionMappingDetail>(entity =>
        {
            entity.HasKey(e => new { e.UiledFunctionMappingConfigId, e.UiledFunctionMappingDetailId, e.Index }).HasName("PK_UILedGroupFunctionConfigurations_UILedGroupFunctionDetails");

            entity.HasOne(d => d.UiledFunctionMappingConfig).WithMany(p => p.UiledFunctionMappingConfigurationsUiledFunctionMappingDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UILedFunctionMappingConfigurations_UILedFunctionMappingDetails_UILedFunctionMappingConfigurations");

            entity.HasOne(d => d.UiledFunctionMappingDetail).WithMany(p => p.UiledFunctionMappingConfigurationsUiledFunctionMappingDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UILedFunctionMappingConfigurations_UILedFunctionMappingDetails_UILedFunctionMappingDetails");
        });

        modelBuilder.Entity<UiledFunctionMappingDetail>(entity =>
        {
            entity.Property(e => e.UiledFunctionMappingDetailId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UiledGroup>(entity =>
        {
            entity.Property(e => e.UiledGroupsId).ValueGeneratedNever();
            entity.Property(e => e.Compartment).HasDefaultValueSql("((15))");
            entity.Property(e => e.LedFunctionId).HasDefaultValueSql("((4095))");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UiledGroupsConfiguration>(entity =>
        {
            entity.Property(e => e.UiledGroupsConfigurationsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.UiledConfigurations).WithMany(p => p.UiledGroupsConfigurations).HasConstraintName("FK_UILedGroupsConfigurations_UILedConfigurations");
        });

        modelBuilder.Entity<UiledGroupsConfigurationsUiledGroup>(entity =>
        {
            entity.HasOne(d => d.UiledGroupsConfigurations).WithMany(p => p.UiledGroupsConfigurationsUiledGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UILedGroupsConfigurations_UILedGroups_UILedGroupsConfigurations");

            entity.HasOne(d => d.UiledGroups).WithMany(p => p.UiledGroupsConfigurationsUiledGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UILedGroupsConfigurations_UILedGroups_UILedGroups");
        });

        modelBuilder.Entity<UiledGroupsDetail>(entity =>
        {
            entity.Property(e => e.UiledGroupsDetailsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UiledGroupsUiledGroupsDetail>(entity =>
        {
            entity.HasOne(d => d.UiledGroupsDetails).WithMany(p => p.UiledGroupsUiledGroupsDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UILedGroups_UILedGroupsDetails_UILedGroupsDetails");

            entity.HasOne(d => d.UiledGroups).WithMany(p => p.UiledGroupsUiledGroupsDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UILedGroups_UILedGroupsDetails_UILedGroups");
        });

        modelBuilder.Entity<UilowPowerTime>(entity =>
        {
            entity.Property(e => e.UilowPowerTimeId).ValueGeneratedNever();
            entity.Property(e => e.CommunicationErrorDetectionTime).HasDefaultValueSql("((65535))");
            entity.Property(e => e.DisableCommunicationErrorDetection).HasDefaultValueSql("((1))");
            entity.Property(e => e.DisableEndToOffTransitionTime).HasDefaultValueSql("((1))");
            entity.Property(e => e.DisableProgrammingToOffTransitionTime).HasDefaultValueSql("((1))");
            entity.Property(e => e.EndToOffTransitionTime).HasDefaultValueSql("((65535))");
            entity.Property(e => e.LowPowerTime).HasDefaultValueSql("((60))");
            entity.Property(e => e.PasueToOffTransitionTime).HasDefaultValueSql("((30))");
            entity.Property(e => e.ProgrammingToOffTransitionTime).HasDefaultValueSql("((65535))");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<Uimacro>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_UIMacros_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.UimacroId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.Uimacros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIMacros_TableTargets");
        });

        modelBuilder.Entity<UimacrosUistatement>(entity =>
        {
            entity.HasOne(d => d.Uimacro).WithMany(p => p.UimacrosUistatements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIMacros_UIStatements_UIMacros");

            entity.HasOne(d => d.Uistatement).WithMany(p => p.UimacrosUistatements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIMacros_UIStatements_UIStatements");
        });

        modelBuilder.Entity<UiprmGiabsoluteEncoder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PrmUIAbsoluteEncoder");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<UiprmGianalogEncoder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PrmUIAnalogEncoder");

            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_PrmUIAnalogEncoder_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.UiprmGianalogEncoders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrmUIAnalogEncoder_TableTargets");
        });

        modelBuilder.Entity<UiprmGianalogPotentiometer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PrmUIAnalogPotentiometer");

            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_PrmUIAnalogPotentiometer_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.A).HasDefaultValueSql("((1))");
            entity.Property(e => e.B).HasDefaultValueSql("((1))");
            entity.Property(e => e.Max).HasDefaultValueSql("((255))");
            entity.Property(e => e.RangeMax).HasDefaultValueSql("((255))");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.SatMax).HasDefaultValueSql("((255))");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
            entity.Property(e => e.ValMax).HasDefaultValueSql("((255))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.UiprmGianalogPotentiometers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrmUIAnalogPotentiometer_TableTargets");
        });

        modelBuilder.Entity<UiprmGidiscretePotentiometer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PrmUIDiscretePotentiometer");

            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_PrmUIDiscretePotentiometer_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.UiprmGidiscretePotentiometers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrmUIDiscretePotentiometer_TableTargets");
        });

        modelBuilder.Entity<UiprmGiincrementalEncoder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PrmUIIncrementalEncoder");

            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_PrmUIIncrementalEncoder_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.UiprmGiincrementalEncoders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrmUIIncrementalEncoder_TableTargets");
        });

        modelBuilder.Entity<UiprmGitouchSlider>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.UiprmGitouchSliders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIPrmGITouchSlider_TableTargets");
        });

        modelBuilder.Entity<UiregulationTable>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_UIRegulationTables_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.UiregulationTableId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.MainExtendValues).HasDefaultValueSql("(0x)");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");
            entity.Property(e => e.VisualExtendValues).HasDefaultValueSql("(0x)");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.UiregulationTables)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIRegulationTables_TableTargets");
        });

        modelBuilder.Entity<Uisequence>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_UISequences_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.UisequenceId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.Uisequences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UISequences_TableTargets");
        });

        modelBuilder.Entity<UisequenceConfiguration>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_UISequenceConfigurations_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.UisequenceConfigurationId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.UisequenceConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UISequenceConfigurations_TableTargets");
        });

        modelBuilder.Entity<UisequenceConfigurationsUisequence>(entity =>
        {
            entity.HasOne(d => d.Uicondition).WithMany(p => p.UisequenceConfigurationsUisequences).HasConstraintName("FK_UISequenceConfigurations_UISequences_UIConditions");

            entity.HasOne(d => d.UisequenceConfiguration).WithMany(p => p.UisequenceConfigurationsUisequences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UISequenceConfigurations_UISequences_UISequenceConfigurations");

            entity.HasOne(d => d.Uisequence).WithMany(p => p.UisequenceConfigurationsUisequences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UISequenceConfigurations_UISequences_UISequences");
        });

        modelBuilder.Entity<UisequencesUistep>(entity =>
        {
            entity.HasOne(d => d.Uisequence).WithMany(p => p.UisequencesUisteps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UISequences_UISteps_UISequences");

            entity.HasOne(d => d.Uistep).WithMany(p => p.UisequencesUisteps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UISequences_UISteps_UISteps");
        });

        modelBuilder.Entity<UisreventConfiguration>(entity =>
        {
            entity.Property(e => e.UisreventConfigurationId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.UisreventConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UISREventConfigurations_TableTargets");
        });

        modelBuilder.Entity<UisreventConfigurationsUisreventDetail>(entity =>
        {
            entity.HasOne(d => d.UisreventConfiguration).WithMany(p => p.UisreventConfigurationsUisreventDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UISREventConfigurations_UISREventDetails_UISREventConfigurations");

            entity.HasOne(d => d.UisreventDetail).WithMany(p => p.UisreventConfigurationsUisreventDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UISREventConfigurations_UISREventDetails_UISREventDetails");
        });

        modelBuilder.Entity<UisreventDetail>(entity =>
        {
            entity.Property(e => e.UisreventDetailId).ValueGeneratedNever();

            entity.HasOne(d => d.Srinput).WithMany(p => p.UisreventDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UISREventDetails_UIGenericInputReadTypes");
        });

        modelBuilder.Entity<UisreventPrmAnalog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<UisreventPrmDigital>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<UisreventPrmEncoder>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Uistatement>(entity =>
        {
            entity.HasKey(e => e.UistatementId).HasName("PK_UIStatements_1");

            entity.Property(e => e.UistatementId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Uistep>(entity =>
        {
            entity.HasIndex(e => new { e.RevisionGroup, e.Revision }, "IX_UISteps_RevisionGroupRevision")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.UistepId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TableTarget).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TableTargetNavigation).WithMany(p => p.Uisteps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UISteps_TableTargets");
        });

        modelBuilder.Entity<UistepsUicondition>(entity =>
        {
            entity.HasOne(d => d.Uicondition).WithMany(p => p.UistepsUiconditions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UISteps_UIConditions_UIConditions");

            entity.HasOne(d => d.Uistep).WithMany(p => p.UistepsUiconditions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UISteps_UIConditions_UISteps");
        });

        modelBuilder.Entity<UistmSetAnimation>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<UistmSetAudio>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<UistmSetFunction>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UistmSetIncompatibility>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Condition).WithMany(p => p.UistmSetIncompatibilities).HasConstraintName("FK_UIStmSetIncompatibility_UIFunctionConditions");
        });

        modelBuilder.Entity<UistmSetObject>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Intensity).HasDefaultValueSql("((100))");
            entity.Property(e => e.VisualValueFlag).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UistmSetTimer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<UistmSetVariable>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Condition).WithMany(p => p.UistmSetVariables).HasConstraintName("FK_UIStmSetVariable_UIFunctionConditions");
        });

        modelBuilder.Entity<UistmVisualJumpIf>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Condition).WithMany(p => p.UistmVisualJumpIfs).HasConstraintName("FK_UIStmVisualJumpIf_UIFunctionConditions");
        });

        modelBuilder.Entity<UitimeToEndVisualizerConfiguration>(entity =>
        {
            entity.Property(e => e.UitimeToEndVisualizerId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail>(entity =>
        {
            entity.HasOne(d => d.UitimeToEndVisualizerDetail).WithMany(p => p.UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UITimeToEndVisualizerConfigurations_UITimeToEndVisualizerDetails_UITimeToEndVisualizerDetails");

            entity.HasOne(d => d.UitimeToEndVisualizer).WithMany(p => p.UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UITimeToEndVisualizerConfigurations_UITimeToEndVisualizerDetails_UITimeToEndVisualizerConfigurations");
        });

        modelBuilder.Entity<UitimeToEndVisualizerDetail>(entity =>
        {
            entity.Property(e => e.UitimeToEndVisualizerDetailId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UitouchDevice>(entity =>
        {
            entity.Property(e => e.UitouchDevicesId).ValueGeneratedNever();

            entity.HasOne(d => d.UicypressTouch).WithMany(p => p.UitouchDevices).HasConstraintName("FK_UITouchDevices_UICypressTouchParameters");

            entity.HasOne(d => d.UitouchLean).WithMany(p => p.UitouchDevices).HasConstraintName("FK_UITouchDevices_UITouchLean");
        });

        modelBuilder.Entity<UitouchLean>(entity =>
        {
            entity.Property(e => e.UitouchLeanId).ValueGeneratedNever();
            entity.Property(e => e.MaxZoneSensorBufferSize).HasDefaultValueSql("((5))");
        });

        modelBuilder.Entity<UiviewEngineControlStateConfiguration>(entity =>
        {
            entity.HasKey(e => e.UiviewEngineControlStateConfigurationsId).HasName("PK_UIViewEngineControlState");

            entity.Property(e => e.UiviewEngineControlStateConfigurationsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail>(entity =>
        {
            entity.HasOne(d => d.UiviewEngineControlStateConfigurations).WithMany(p => p.UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIViewEngineControlStateConfigurations_UIViewEngineControlStateDetails_UIViewEngineControlStateConfigurations");

            entity.HasOne(d => d.UiviewEngineControlStateDetails).WithMany(p => p.UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIViewEngineControlStateConfigurations_UIViewEngineControlStateDetails_UIViewEngineControlStateDetails");
        });

        modelBuilder.Entity<UiviewEngineControlStateDetail>(entity =>
        {
            entity.Property(e => e.UiviewEngineControlStateDetailsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DoMacro).WithMany(p => p.UiviewEngineControlStateDetailDoMacros).HasConstraintName("FK_UIViewEngineControlStateDetails_UIMacros");

            entity.HasOne(d => d.OnEntryMacro).WithMany(p => p.UiviewEngineControlStateDetailOnEntryMacros).HasConstraintName("FK_UIViewEngineControlStateDetails_UIMacros1");

            entity.HasOne(d => d.OnExitMacro).WithMany(p => p.UiviewEngineControlStateDetailOnExitMacros).HasConstraintName("FK_UIViewEngineControlStateDetails_UIMacros2");
        });

        modelBuilder.Entity<UiviewEngineViewsConfiguratio>(entity =>
        {
            entity.Property(e => e.UiviewEngineViewsConfigurationsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UiviewEngineViewsConfigurationsUiviewEngineViewsDetail>(entity =>
        {
            entity.HasOne(d => d.UiviewEngineViewsConfigurations).WithMany(p => p.UiviewEngineViewsConfigurationsUiviewEngineViewsDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIViewEngineViewsConfigurations_UIViewEngineViewsDetails_UIViewEngineViewsConfiguratios");

            entity.HasOne(d => d.UiviewEngineViewsDetails).WithMany(p => p.UiviewEngineViewsConfigurationsUiviewEngineViewsDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UIViewEngineViewsConfigurations_UIViewEngineViewsDetails_UIViewEngineViewsDetails");
        });

        modelBuilder.Entity<UiviewEngineViewsDetail>(entity =>
        {
            entity.Property(e => e.UiviewEngineViewsDetailsId).ValueGeneratedNever();
            entity.Property(e => e.RevisionGroup).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DoMacro).WithMany(p => p.UiviewEngineViewsDetailDoMacros).HasConstraintName("FK_UIViewEngineViewsDetails_UIMacros");

            entity.HasOne(d => d.OnEntryMacro).WithMany(p => p.UiviewEngineViewsDetailOnEntryMacros).HasConstraintName("FK_UIViewEngineViewsDetails_UIMacros1");

            entity.HasOne(d => d.OnExitMacro).WithMany(p => p.UiviewEngineViewsDetailOnExitMacros).HasConstraintName("FK_UIViewEngineViewsDetails_UIMacros2");
        });

        modelBuilder.Entity<UserPhaseName>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Variable>(entity =>
        {
            entity.Property(e => e.VariableId).ValueGeneratedNever();
            entity.Property(e => e.Offset).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<VariableBaseTrack>(entity =>
        {
            entity.Property(e => e.DisplayName).IsFixedLength();
            entity.Property(e => e.Tag).IsFixedLength();
            entity.Property(e => e.TrackFormula).IsFixedLength();
            entity.Property(e => e.TrackHelpLabel).IsFixedLength();
            entity.Property(e => e.TrackMeasUnit).IsFixedLength();
            entity.Property(e => e.TrackName).IsFixedLength();
        });

        modelBuilder.Entity<VariableGroup>(entity =>
        {
            entity.HasMany(d => d.Variables).WithMany(p => p.VariableGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "VariableGroupsVariable",
                    r => r.HasOne<Variable>().WithMany()
                        .HasForeignKey("VariableId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_VariableGroups_Variables_Variables"),
                    l => l.HasOne<VariableGroup>().WithMany()
                        .HasForeignKey("VariableGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_VariableGroups_Variables_VariableGroups"),
                    j =>
                    {
                        j.HasKey("VariableGroupId", "VariableId");
                        j.ToTable("VariableGroups_Variables");
                    });
        });

        modelBuilder.Entity<VwPlatformGenericInputConfiguration>(entity =>
        {
            entity.ToView("vw_platform_GenericInputConfigurations");
        });

        modelBuilder.Entity<VwPlatformLoadConfiguration>(entity =>
        {
            entity.ToView("vw_platform_LoadConfigurations");
        });

        modelBuilder.Entity<VwPlatformLowLevelInputConfiguration>(entity =>
        {
            entity.ToView("vw_platform_LowLevelInputConfigurations");
        });

        modelBuilder.Entity<VwVisualFunctionConfiguration>(entity =>
        {
            entity.ToView("vw_visual_FunctionConfigurations");
        });

        modelBuilder.Entity<VwVisualGenericInputConfiguration>(entity =>
        {
            entity.ToView("vw_visual_GenericInputConfigurations");
        });

        modelBuilder.Entity<VwVisualLowLevelInputConfiguration>(entity =>
        {
            entity.ToView("vw_visual_LowLevelInputConfigurations");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
