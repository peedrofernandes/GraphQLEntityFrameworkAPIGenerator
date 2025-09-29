using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class CycleOptionsFullView
{
    public Guid CycleMappingId { get; set; }

    [StringLength(50)]
    public string CycleMappingDescription { get; set; } = null!;

    public byte Compartment0 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CycleName { get; set; } = null!;

    public long? KeyValue { get; set; }

    public string? KeyName0 { get; set; }

    public int? ConnectivityCycleEnumeration0 { get; set; }

    public string? EnumDescription { get; set; }

    public byte NumberOfModifiers { get; set; }

    [StringLength(100)]
    public string? Modifier1 { get; set; }

    [StringLength(100)]
    public string? Modifier1Value { get; set; }

    [StringLength(100)]
    public string? Modifier2 { get; set; }

    [StringLength(100)]
    public string? Modifier2Value { get; set; }

    public byte OptionTypeId { get; set; }

    public byte CycleMapIndex { get; set; }

    public byte CycleOptionsIndex { get; set; }

    public Guid CycleOptionsConfigurationsId { get; set; }

    public bool IsConnected { get; set; }

    [StringLength(100)]
    public string? HmiCycleName { get; set; }

    public float Version { get; set; }

    public byte? HexEncoding { get; set; }

    [StringLength(100)]
    public string? FileId { get; set; }

    public int Revision { get; set; }

    public Guid? CycleMappingFileInfoId { get; set; }

    [StringLength(50)]
    public string CycleOptionsDescription { get; set; } = null!;

    public byte? TemperatureSelectionBehavior { get; set; }

    [Column("UPO")]
    public bool? Upo { get; set; }

    public float? TemperatureSelectionCelsiusMinimum { get; set; }

    public float? TemperatureSelectionCelsiusDefault { get; set; }

    public float? TemperatureSelectionCelsiusMaximum { get; set; }

    public double? MaximumStartTemperature { get; set; }

    public byte? StepCelsius { get; set; }

    public byte? StepFahrenheit { get; set; }

    public byte? NumberOfTemperatureSelections { get; set; }

    public float? TemperatureSelection4 { get; set; }

    public float? TemperatureSelection5 { get; set; }

    public float? TemperatureSelection6 { get; set; }

    public byte? Units { get; set; }

    [StringLength(50)]
    public string? TempSelectionName1 { get; set; }

    [StringLength(50)]
    public string? TempSelectionName2 { get; set; }

    [StringLength(50)]
    public string? TempSelectionName3 { get; set; }

    [StringLength(50)]
    public string? TemperatureSelectionDefaultName { get; set; }

    public byte? TemperatureSelectionName3 { get; set; }

    public byte? TemperatureSelectionName4 { get; set; }

    public byte? TemperatureSelectionName5 { get; set; }

    public byte? TemperatureSelectionName6 { get; set; }

    public byte? NumberOfTimeSelections { get; set; }

    public byte? UserCookTimeSelectionBehavior { get; set; }

    public byte? UserCookTimeDisplayBehavior { get; set; }

    public int? UserCookTime1 { get; set; }

    public int? UserCookTime2 { get; set; }

    public int? UserCookTime3 { get; set; }

    public int? UserCookTime4 { get; set; }

    public int? UserCookTime5 { get; set; }

    public int? UserCookTime6 { get; set; }

    public int? Step { get; set; }

    public byte? TimeUnits { get; set; }

    public int? UserCookTimeDefaultSelection { get; set; }

    [StringLength(50)]
    public string? TimeSelectionName1 { get; set; }

    [StringLength(50)]
    public string? TimeSelectionName2 { get; set; }

    [StringLength(50)]
    public string? TimeSelectionName3 { get; set; }

    [StringLength(50)]
    public string? TimeSelectionNameDefault { get; set; }

    public float? TempSelectionCelsiusMin { get; set; }

    public float? TempSelectionCelsiusDefault { get; set; }

    public float? TempSelectionCelsiusMax { get; set; }

    public byte? MeatProbeStepCelsius { get; set; }

    public byte? MeatProbeStepFahrenheit { get; set; }

    public float? WeightSelectionMin { get; set; }

    public float? WeightSelectionDefault { get; set; }

    public float? WeightSelectionMax { get; set; }

    public float? WeightStep { get; set; }

    public float? SizeSelectionMin { get; set; }

    public float? SizeSelectionDefault { get; set; }

    public float? SizeSelectionMax { get; set; }

    public float? SizeStep { get; set; }

    [StringLength(50)]
    public string? DonenessDefaultSelection { get; set; }

    [StringLength(50)]
    public string? DonenessOption1 { get; set; }

    [StringLength(50)]
    public string? DonenessOption2 { get; set; }

    [StringLength(50)]
    public string? DonenessOption3 { get; set; }

    [StringLength(50)]
    public string? DonenessOption4 { get; set; }

    [StringLength(50)]
    public string? DonenessOption5 { get; set; }

    [StringLength(50)]
    public string? BrowningDefaultSelection { get; set; }

    [StringLength(50)]
    public string? BrowningOption1 { get; set; }

    [StringLength(50)]
    public string? BrowningOption2 { get; set; }

    [StringLength(50)]
    public string? BrowningOption3 { get; set; }

    [StringLength(50)]
    public string? BrowningOption4 { get; set; }

    [StringLength(50)]
    public string? BrowningOption5 { get; set; }

    public float? AmountMin { get; set; }

    public float? AmountDefault { get; set; }

    public float? AmountMax { get; set; }

    public byte? AmountUnits { get; set; }

    public float? AmountStep { get; set; }

    public byte? AmountDisplayUnitsId { get; set; }

    [StringLength(50)]
    public string? AmountDisplayUnits { get; set; }

    public byte? NumberOfTimeBands { get; set; }

    public byte? AddTime1 { get; set; }

    public byte? FrozenBakeTime1 { get; set; }

    public byte? AddTime2 { get; set; }

    public byte? FrozenBakeTime2 { get; set; }

    public byte? AddTime3 { get; set; }

    public byte? FrozenBakeTime3 { get; set; }

    public byte? AddTime4 { get; set; }

    public byte? FrozenBakeTime4 { get; set; }

    public byte? AddTime5 { get; set; }

    public byte? FrozenBakeTime5 { get; set; }

    public byte? AddTime6 { get; set; }

    public byte? FrozenBakeTime6 { get; set; }

    public byte? AddTime7 { get; set; }

    public byte? FrozenBakeTime7 { get; set; }

    public byte? AddTime8 { get; set; }

    public byte? FrozenBakeTime8 { get; set; }

    public byte? AddTime9 { get; set; }

    public byte? FrozenBakeTime9 { get; set; }

    public byte? AddTime10 { get; set; }

    public byte? TimeAdjustValue { get; set; }

    public float? TemperatureAdjustValue { get; set; }

    [StringLength(50)]
    public string? AtEndDefault { get; set; }

    [StringLength(50)]
    public string? HoldTemp { get; set; }

    [StringLength(50)]
    public string? TurnOff { get; set; }

    [StringLength(50)]
    public string? KeepWarm { get; set; }

    public bool? UserEditable { get; set; }

    [StringLength(50)]
    public string? NoPreheat { get; set; }

    [StringLength(50)]
    public string? Preheat { get; set; }

    [StringLength(50)]
    public string? RapidPreheat { get; set; }

    public byte? DisplayRampStepF { get; set; }

    public byte? DisplayRampStepC { get; set; }

    [StringLength(50)]
    public string? PreheatDefault { get; set; }

    [StringLength(50)]
    public string? PanSizeDefault { get; set; }

    [StringLength(50)]
    public string? PanSizeOption8 { get; set; }

    [StringLength(50)]
    public string? PanSizeOption9 { get; set; }

    [StringLength(50)]
    public string? PanSizeOption10 { get; set; }

    [StringLength(50)]
    public string? PanSizeOption8x8 { get; set; }

    [StringLength(50)]
    public string? PanSizeOption9x9 { get; set; }

    [StringLength(50)]
    public string? PanSizeOption9x13 { get; set; }

    public int? DelayMin { get; set; }

    public int? DelayDefault { get; set; }

    public int? DelayMax { get; set; }

    public int? DelayStep { get; set; }

    public bool? ConfigureMaxTemp { get; set; }

    public byte? NumberOfInputs { get; set; }

    public byte? ResultingAttributeId { get; set; }

    public float? Constant { get; set; }

    public float? Coefficient1 { get; set; }

    public float? Coefficient2 { get; set; }

    public float? Coefficient3 { get; set; }

    public float? Coefficient4 { get; set; }

    [StringLength(100)]
    public string? ResultingAttDescription { get; set; }

    [StringLength(50)]
    public string? Input1Description { get; set; }

    [StringLength(50)]
    public string? Input2Description { get; set; }

    [StringLength(50)]
    public string? Input3Description { get; set; }

    [StringLength(50)]
    public string? Input4Description { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FormulaCycleName { get; set; }

    public byte? AmountDiscreteUnits { get; set; }

    public byte? AmountDiscreteNumberOfLevels { get; set; }

    public byte? AmountDiscreteNumberOfDecimals { get; set; }

    public byte? AmountDiscreteVersion { get; set; }

    public float? AmountDiscreteDefault { get; set; }

    public float? Amount1 { get; set; }

    public float? Amount2 { get; set; }

    public float? Amount3 { get; set; }

    public float? Amount4 { get; set; }

    public float? Amount5 { get; set; }

    public float? Amount6 { get; set; }

    public float? Amount7 { get; set; }

    public float? Amount8 { get; set; }

    public byte? WeightRangesVersion { get; set; }

    public float? WeightRangesStep { get; set; }

    public float? WeightRangesDefault { get; set; }

    public byte? WeightRangesNumberOfLevels { get; set; }

    public float? Weight1 { get; set; }

    public float? Weight2 { get; set; }

    public float? Weight3 { get; set; }

    public float? Weight4 { get; set; }

    public float? Weight5 { get; set; }

    public float? Weight6 { get; set; }

    public Guid? CycleOptionsPrmStepsConfigId { get; set; }

    public byte? PyroCompletePercent { get; set; }

    public int? CleanBackToBackTime { get; set; }

    public byte? PowerLevelTypeSelection { get; set; }

    public int? MwoPowerLevelsMin { get; set; }

    public int? MwoPowerLevelsDefault { get; set; }

    public int? MwoPowerLevelsMax { get; set; }

    public int? MwoPowerLevelsStep { get; set; }

    [MaxLength(50)]
    public byte[]? MwoPowerLevelsList { get; set; }

    public byte? NumberOfTips { get; set; }

    [StringLength(50)]
    public string? TipKey1 { get; set; }

    [StringLength(200)]
    public string? TipValue1 { get; set; }

    [StringLength(50)]
    public string? TipKey2 { get; set; }

    [StringLength(200)]
    public string? TipValue2 { get; set; }

    [StringLength(50)]
    public string? TipKey3 { get; set; }

    [StringLength(200)]
    public string? TipValue3 { get; set; }

    [StringLength(50)]
    public string? TipKey4 { get; set; }

    [StringLength(200)]
    public string? TipValue4 { get; set; }

    [StringLength(50)]
    public string? TipKey5 { get; set; }

    [StringLength(200)]
    public string? TipValue5 { get; set; }

    [StringLength(100)]
    public string? FoodTypeDefault { get; set; }

    [MaxLength(50)]
    public byte[]? FoodTypeOptions { get; set; }
}
