using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmGIAnalogToTemperature")]
public partial class PrmGianalogToTemperature
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    [Column("N_Points")]
    public byte NPoints { get; set; }

    [MaxLength(256)]
    public byte[] AnalogValues { get; set; } = null!;

    [MaxLength(512)]
    public byte[] TemperatureValues { get; set; } = null!;

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    public bool Interpolation { get; set; }

    public byte? GlitchRemoveThreshold { get; set; }

    public byte? GlitchDebounceThreshold { get; set; }

    [Column("IIR_InvertedBeta")]
    public int? IirInvertedBeta { get; set; }

    [ForeignKey("TableTarget")]
    [InverseProperty("PrmGianalogToTemperatures")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;
}
