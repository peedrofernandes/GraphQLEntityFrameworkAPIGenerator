using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("InductionThermalNodeConfiguration")]
public partial class InductionThermalNodeConfiguration
{
    [Key]
    public Guid InductionThermalNodeConfigId { get; set; }

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

    public byte? Version { get; set; }

    public float TempThresholdNominalToWarmState { get; set; }

    public float TempThresholdWarmToOverheatState { get; set; }

    public float TempTresholdHotIndicator { get; set; }

    public float ThermalDeratingPiControllerTempSetPoint { get; set; }

    public double ThermalDeratingPiControllerKp { get; set; }

    public double ThermalDeratingPiControllerKi { get; set; }

    [InverseProperty("HeatsinkThermalNodeConfig")]
    public virtual ICollection<IpcControllerCoilConfiguration> IpcControllerCoilConfigurationHeatsinkThermalNodeConfigs { get; set; } = new List<IpcControllerCoilConfiguration>();

    [InverseProperty("MicroThermalNodeConfig")]
    public virtual ICollection<IpcControllerCoilConfiguration> IpcControllerCoilConfigurationMicroThermalNodeConfigs { get; set; } = new List<IpcControllerCoilConfiguration>();

    [InverseProperty("CoilCenterThermalNodeConfig")]
    public virtual ICollection<IpcControllerCoilDetail> IpcControllerCoilDetailCoilCenterThermalNodeConfigs { get; set; } = new List<IpcControllerCoilDetail>();

    [InverseProperty("CoilGapThermalNodeConfig")]
    public virtual ICollection<IpcControllerCoilDetail> IpcControllerCoilDetailCoilGapThermalNodeConfigs { get; set; } = new List<IpcControllerCoilDetail>();

    [InverseProperty("IgbtThermalNodeConfig")]
    public virtual ICollection<IpcControllerCoilDetail> IpcControllerCoilDetailIgbtThermalNodeConfigs { get; set; } = new List<IpcControllerCoilDetail>();
}
