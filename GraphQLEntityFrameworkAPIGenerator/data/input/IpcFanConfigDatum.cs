using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class IpcFanConfigDatum
{
    [Key]
    public Guid IpcFanConfigId { get; set; }

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

    public byte Version { get; set; }

    public int FanMaximumSpeed { get; set; }

    public int FanMinimumSpeed { get; set; }

    public float FanActivationTempThresholdNotDelivering { get; set; }

    public float MaxTempForSpeedLinearInterpolation { get; set; }

    public float MinTempForSpeedLinearInterpolation { get; set; }

    [InverseProperty("IpcFanConfig")]
    public virtual ICollection<IpcControllerCoilConfiguration> IpcControllerCoilConfigurations { get; set; } = new List<IpcControllerCoilConfiguration>();
}
