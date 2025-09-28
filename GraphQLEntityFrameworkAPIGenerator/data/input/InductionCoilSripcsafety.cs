using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("InductionCoilSRIPCSafety")]
public partial class InductionCoilSripcsafety
{
    [Key]
    [Column("CoilSRIPCSafetyId")]
    public Guid CoilSripcsafetyId { get; set; }

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

    public byte DualZoneRole { get; set; }

    public byte CoilModelId { get; set; }

    public float CoverageAcceptance { get; set; }

    public float CoverageRejection { get; set; }

    public float CoverageMove { get; set; }

    [InverseProperty("CoilSripcsafety")]
    public virtual ICollection<InductionCoilConfig> InductionCoilConfigs { get; set; } = new List<InductionCoilConfig>();
}
