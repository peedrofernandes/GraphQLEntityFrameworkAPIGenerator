using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIPrmGIDiscretePotentiometer")]
public partial class UiprmGidiscretePotentiometer
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public byte RegulationNum { get; set; }

    public bool Size { get; set; }

    [MaxLength(128)]
    public byte[] Threshold { get; set; } = null!;

    [MaxLength(128)]
    public byte[] RegulationValue { get; set; } = null!;

    public byte Hysteresis { get; set; }

    public bool EnableRangeDetection { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    public byte Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TimeStamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    public bool Interpolation { get; set; }

    [ForeignKey("TableTarget")]
    [InverseProperty("UiprmGidiscretePotentiometers")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;
}
