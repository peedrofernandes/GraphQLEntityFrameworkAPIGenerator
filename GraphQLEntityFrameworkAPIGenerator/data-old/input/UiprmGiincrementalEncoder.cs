using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIPrmGIIncrementalEncoder")]
public partial class UiprmGiincrementalEncoder
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public byte PulseCountTimeout { get; set; }

    public byte ToIncreasePulseNumber { get; set; }

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
    [InverseProperty("UiprmGiincrementalEncoders")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;
}
