using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("EmptyPotDetectionCoilConfig")]
public partial class EmptyPotDetectionCoilConfig
{
    [Key]
    public Guid EmptyPotDetectionCoilConfigId { get; set; }

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

    public bool UseGapTempSensorForEmptyPotHandling { get; set; }

    public float KiTemperatureControl { get; set; }

    public float KpTemperatureControl { get; set; }

    public float FixedDeratingFactor { get; set; }

    public float TemperatureControlSetpointSlope { get; set; }

    [InverseProperty("EmptyPotDetectionCoilConfig")]
    public virtual ICollection<IpcControllerCoilDetail> IpcControllerCoilDetails { get; set; } = new List<IpcControllerCoilDetail>();
}
