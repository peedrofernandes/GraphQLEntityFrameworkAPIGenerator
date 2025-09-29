using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class MachineConfiguration
{
    [Key]
    public Guid MachineConfigurationId { get; set; }

    [StringLength(22)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    public short ScaleTemperature { get; set; }

    public Guid? FaultConfigurationsId { get; set; }

    public Guid? DebugPointerConfigurationsId { get; set; }

    [Column("ApplianceConfigurationID")]
    public Guid? ApplianceConfigurationId { get; set; }

    public Guid? LatchControlId { get; set; }

    public Guid? CooktopOrgConfigurationId { get; set; }

    public Guid? TimeEstimationConfigurationId { get; set; }

    public bool UnitsAreMetric { get; set; }

    public Guid? IsofrequencyTableId { get; set; }

    public Guid? LightConfigurationId { get; set; }

    [Column("SRSafetyParametersId")]
    public Guid? SrsafetyParametersId { get; set; }

    public Guid? MicrowavePowerTableId { get; set; }

    public Guid? MonitorPowerReductionId { get; set; }

    public string? AttributeTable { get; set; }

    public Guid? CycleMappingId { get; set; }

    public Guid? WarmingZoneParamsId { get; set; }

    [Column("IRShutterMonitorId")]
    public Guid? IrshutterMonitorId { get; set; }

    [Column("IRTemperatureMonitorId")]
    public Guid? IrtemperatureMonitorId { get; set; }

    public Guid? AutoResumeMonitorId { get; set; }

    public Guid? OpenDoorHeatingCyclesConfigId { get; set; }

    public Guid? MonitorHoodFanId { get; set; }

    public Guid? MinimumDcSupplyId { get; set; }

    public Guid? DlbConfigMonitorId { get; set; }

    public Guid? PowerDetectMonitorId { get; set; }

    public byte StatusLedSolidOn { get; set; }

    public Guid? MonitorCoilDeratingConfigurationId { get; set; }

    public Guid? MonitorCoilId { get; set; }

    public Guid? MonitorHeatsinkFanId { get; set; }

    [Column("MonitorPowerReductionV2ConfigurationId")]
    public Guid? MonitorPowerReductionV2configurationId { get; set; }

    public Guid? MonitorVentId { get; set; }

    public Guid? MonitorMultiPointProbeId { get; set; }

    public Guid? MonitorSteamId { get; set; }

    public Guid? MonitorWaterLevelThresholdId { get; set; }

    public Guid? MonitorGfciId { get; set; }

    public Guid? IpcControllerConfigurationsId { get; set; }

    [Column("MonitorGfciV2Id")]
    public Guid? MonitorGfciV2id { get; set; }

    [ForeignKey("ApplianceConfigurationId")]
    [InverseProperty("MachineConfigurations")]
    public virtual ApplianceConfiguration? ApplianceConfiguration { get; set; }

    [ForeignKey("AutoResumeMonitorId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorAutoResume? AutoResumeMonitor { get; set; }

    [ForeignKey("CooktopOrgConfigurationId")]
    [InverseProperty("MachineConfigurations")]
    public virtual InductionCooktopOrgConfiguration? CooktopOrgConfiguration { get; set; }

    [ForeignKey("CycleMappingId")]
    [InverseProperty("MachineConfigurations")]
    public virtual CycleMapping? CycleMapping { get; set; }

    [ForeignKey("DebugPointerConfigurationsId")]
    [InverseProperty("MachineConfigurations")]
    public virtual DebugPointerConfiguration? DebugPointerConfigurations { get; set; }

    [ForeignKey("DlbConfigMonitorId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorDlbConfiguration? DlbConfigMonitor { get; set; }

    [ForeignKey("FaultConfigurationsId")]
    [InverseProperty("MachineConfigurations")]
    public virtual FaultConfiguration? FaultConfigurations { get; set; }

    [ForeignKey("IpcControllerConfigurationsId")]
    [InverseProperty("MachineConfigurations")]
    public virtual IpcControllerConfiguration? IpcControllerConfigurations { get; set; }

    [ForeignKey("IrshutterMonitorId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorIrshutter? IrshutterMonitor { get; set; }

    [ForeignKey("IrtemperatureMonitorId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorIrtemperature? IrtemperatureMonitor { get; set; }

    [ForeignKey("IsofrequencyTableId")]
    [InverseProperty("MachineConfigurations")]
    public virtual InductionIsofrequencyConfiguration? IsofrequencyTable { get; set; }

    [ForeignKey("LatchControlId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorLatchControl? LatchControl { get; set; }

    [ForeignKey("LightConfigurationId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorLight? LightConfiguration { get; set; }

    [ForeignKey("MicrowavePowerTableId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MicrowavePowerTableConfiguration? MicrowavePowerTable { get; set; }

    [ForeignKey("MinimumDcSupplyId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MinimumDcSupply? MinimumDcSupply { get; set; }

    [ForeignKey("MonitorCoilId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorCoil? MonitorCoil { get; set; }

    [ForeignKey("MonitorCoilDeratingConfigurationId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorCoilDeratingConfiguration? MonitorCoilDeratingConfiguration { get; set; }

    [ForeignKey("MonitorGfciId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorGfci? MonitorGfci { get; set; }

    [ForeignKey("MonitorGfciV2id")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorGfciV2? MonitorGfciV2 { get; set; }

    [ForeignKey("MonitorHeatsinkFanId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorHeatSinkFan? MonitorHeatsinkFan { get; set; }

    [ForeignKey("MonitorHoodFanId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorHoodFan? MonitorHoodFan { get; set; }

    [ForeignKey("MonitorMultiPointProbeId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorMultiPointProbe? MonitorMultiPointProbe { get; set; }

    [ForeignKey("MonitorPowerReductionId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorPowerReduction? MonitorPowerReduction { get; set; }

    [ForeignKey("MonitorPowerReductionV2configurationId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorPowerReductionV2configuration? MonitorPowerReductionV2configuration { get; set; }

    [ForeignKey("MonitorSteamId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorSteam? MonitorSteam { get; set; }

    [ForeignKey("MonitorVentId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorVent? MonitorVent { get; set; }

    [ForeignKey("MonitorWaterLevelThresholdId")]
    [InverseProperty("MachineConfigurations")]
    public virtual DeprecatedMonitorWaterLevelThreshold? MonitorWaterLevelThreshold { get; set; }

    [ForeignKey("OpenDoorHeatingCyclesConfigId")]
    [InverseProperty("MachineConfigurations")]
    public virtual OpenDoorHeatingCyclesConfiguration? OpenDoorHeatingCyclesConfig { get; set; }

    [ForeignKey("PowerDetectMonitorId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorPowerDetect? PowerDetectMonitor { get; set; }

    [InverseProperty("MachineConfiguration")]
    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    [ForeignKey("SrsafetyParametersId")]
    [InverseProperty("MachineConfigurations")]
    public virtual SrsafetyRelevantParameter? SrsafetyParameters { get; set; }

    [ForeignKey("TimeEstimationConfigurationId")]
    [InverseProperty("MachineConfigurations")]
    public virtual TimeEstimationConfiguration? TimeEstimationConfiguration { get; set; }

    [ForeignKey("WarmingZoneParamsId")]
    [InverseProperty("MachineConfigurations")]
    public virtual MonitorWarmingZone? WarmingZoneParams { get; set; }
}
