using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class IpcControllerCoilDetail
{
    [Key]
    public Guid IpcControllerCoilDetailsId { get; set; }

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

    public Guid? InverterConfigId { get; set; }

    public Guid? CoilSpecificConfigId { get; set; }

    public Guid? IgbtThermalNodeConfigId { get; set; }

    public Guid? CoilGapThermalNodeConfigId { get; set; }

    public Guid? CoilCenterThermalNodeConfigId { get; set; }

    public Guid? EmptyPotDetectionCoilConfigId { get; set; }

    [ForeignKey("CoilCenterThermalNodeConfigId")]
    [InverseProperty("IpcControllerCoilDetailCoilCenterThermalNodeConfigs")]
    public virtual InductionThermalNodeConfiguration? CoilCenterThermalNodeConfig { get; set; }

    [ForeignKey("CoilGapThermalNodeConfigId")]
    [InverseProperty("IpcControllerCoilDetailCoilGapThermalNodeConfigs")]
    public virtual InductionThermalNodeConfiguration? CoilGapThermalNodeConfig { get; set; }

    [ForeignKey("CoilSpecificConfigId")]
    [InverseProperty("IpcControllerCoilDetails")]
    public virtual CoilSpecificConfigDatum? CoilSpecificConfig { get; set; }

    [ForeignKey("EmptyPotDetectionCoilConfigId")]
    [InverseProperty("IpcControllerCoilDetails")]
    public virtual EmptyPotDetectionCoilConfig? EmptyPotDetectionCoilConfig { get; set; }

    [ForeignKey("IgbtThermalNodeConfigId")]
    [InverseProperty("IpcControllerCoilDetailIgbtThermalNodeConfigs")]
    public virtual InductionThermalNodeConfiguration? IgbtThermalNodeConfig { get; set; }

    [ForeignKey("InverterConfigId")]
    [InverseProperty("IpcControllerCoilDetails")]
    public virtual InverterConfigDatum? InverterConfig { get; set; }

    [InverseProperty("IpcControllerCoilDetails")]
    public virtual ICollection<IpcControllerCoilConfigurationsIpcControllerCoilDetail> IpcControllerCoilConfigurationsIpcControllerCoilDetails { get; set; } = new List<IpcControllerCoilConfigurationsIpcControllerCoilDetail>();
}
