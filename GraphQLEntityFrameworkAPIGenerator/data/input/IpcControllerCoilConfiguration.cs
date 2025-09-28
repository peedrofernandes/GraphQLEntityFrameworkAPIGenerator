using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class IpcControllerCoilConfiguration
{
    [Key]
    public Guid IpcControllerCoilConfigurationsId { get; set; }

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

    public Guid? IpcFanConfigId { get; set; }

    public Guid? HeatsinkThermalNodeConfigId { get; set; }

    public Guid? MicroThermalNodeConfigId { get; set; }

    [ForeignKey("HeatsinkThermalNodeConfigId")]
    [InverseProperty("IpcControllerCoilConfigurationHeatsinkThermalNodeConfigs")]
    public virtual InductionThermalNodeConfiguration? HeatsinkThermalNodeConfig { get; set; }

    [InverseProperty("IpcControllerCoilConfigurations")]
    public virtual ICollection<IpcControllerCoilConfigurationsIpcControllerCoilDetail> IpcControllerCoilConfigurationsIpcControllerCoilDetails { get; set; } = new List<IpcControllerCoilConfigurationsIpcControllerCoilDetail>();

    [InverseProperty("IpcControllerCoilConfigurations")]
    public virtual ICollection<IpcControllerIpcConfigurationsIpcControllerCoilConfiguration> IpcControllerIpcConfigurationsIpcControllerCoilConfigurations { get; set; } = new List<IpcControllerIpcConfigurationsIpcControllerCoilConfiguration>();

    [ForeignKey("IpcFanConfigId")]
    [InverseProperty("IpcControllerCoilConfigurations")]
    public virtual IpcFanConfigDatum? IpcFanConfig { get; set; }

    [ForeignKey("MicroThermalNodeConfigId")]
    [InverseProperty("IpcControllerCoilConfigurationMicroThermalNodeConfigs")]
    public virtual InductionThermalNodeConfiguration? MicroThermalNodeConfig { get; set; }
}
