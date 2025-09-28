using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class ThermalConfigDatum
{
    [Key]
    public Guid ThermalConfigId { get; set; }

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

    public float MaxDeratingFactor { get; set; }

    public float MinDeratingFactor { get; set; }

    public float InitialValueDeratingFactor { get; set; }

    public float ToleranceFromOverHeatingToWarm { get; set; }

    public int HysteresysBandwidthHotIndicator { get; set; }

    [InverseProperty("ThermalConfig")]
    public virtual ICollection<IpcControllerIpcConfiguration> IpcControllerIpcConfigurations { get; set; } = new List<IpcControllerIpcConfiguration>();
}
