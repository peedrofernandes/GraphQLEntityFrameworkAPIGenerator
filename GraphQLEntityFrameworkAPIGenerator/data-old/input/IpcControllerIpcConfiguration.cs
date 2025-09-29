using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class IpcControllerIpcConfiguration
{
    [Key]
    public Guid IpcControllerIpcConfigurationsId { get; set; }

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

    public Guid? MainsLineConfigId { get; set; }

    public Guid? PowerDeliveryConfigId { get; set; }

    public Guid? ThermalConfigId { get; set; }

    public Guid? CoilOperationConfigId { get; set; }

    public Guid? AssistedCookingConfigId { get; set; }

    public Guid? EmptyPotDetectionConfigId { get; set; }

    [ForeignKey("AssistedCookingConfigId")]
    [InverseProperty("IpcControllerIpcConfigurations")]
    public virtual AssistedCookingConfigDatum? AssistedCookingConfig { get; set; }

    [ForeignKey("CoilOperationConfigId")]
    [InverseProperty("IpcControllerIpcConfigurations")]
    public virtual CoilOperationConfigDatum? CoilOperationConfig { get; set; }

    [ForeignKey("EmptyPotDetectionConfigId")]
    [InverseProperty("IpcControllerIpcConfigurations")]
    public virtual EmptyPotDetectionConfig? EmptyPotDetectionConfig { get; set; }

    [InverseProperty("IpcControllerIpcConfigurations")]
    public virtual ICollection<IpcControllerConfigurationsIpcControllerIpcConfiguration> IpcControllerConfigurationsIpcControllerIpcConfigurations { get; set; } = new List<IpcControllerConfigurationsIpcControllerIpcConfiguration>();

    [InverseProperty("IpcControllerIpcConfigurations")]
    public virtual ICollection<IpcControllerIpcConfigurationsIpcControllerCoilConfiguration> IpcControllerIpcConfigurationsIpcControllerCoilConfigurations { get; set; } = new List<IpcControllerIpcConfigurationsIpcControllerCoilConfiguration>();

    [ForeignKey("MainsLineConfigId")]
    [InverseProperty("IpcControllerIpcConfigurations")]
    public virtual MainsLineConfigDatum? MainsLineConfig { get; set; }

    [ForeignKey("PowerDeliveryConfigId")]
    [InverseProperty("IpcControllerIpcConfigurations")]
    public virtual PowerDeliveryConfigDatum? PowerDeliveryConfig { get; set; }

    [ForeignKey("ThermalConfigId")]
    [InverseProperty("IpcControllerIpcConfigurations")]
    public virtual ThermalConfigDatum? ThermalConfig { get; set; }
}
