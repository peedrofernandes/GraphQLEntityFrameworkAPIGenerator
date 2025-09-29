using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIPrmGIAnalogPotentiometer")]
public partial class UiprmGianalogPotentiometer
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public byte Min { get; set; }

    public byte Max { get; set; }

    public byte ValMin { get; set; }

    public byte ValMax { get; set; }

    public byte SatMin { get; set; }

    public byte SatMax { get; set; }

    public byte RangeMin { get; set; }

    public byte RangeMax { get; set; }

    public bool EnableRangeDetection { get; set; }

    public byte A { get; set; }

    public byte B { get; set; }

    public byte C { get; set; }

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

    [ForeignKey("TableTarget")]
    [InverseProperty("UiprmGianalogPotentiometers")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;
}
