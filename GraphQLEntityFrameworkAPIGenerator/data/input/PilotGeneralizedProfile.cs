using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class PilotGeneralizedProfile
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

    [Column("NPeriods")]
    public byte Nperiods { get; set; }

    [MaxLength(32)]
    public byte[] StartPoint { get; set; } = null!;

    public bool StartFromNegative { get; set; }

    public bool Compensated { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [ForeignKey("TableTarget")]
    [InverseProperty("PilotGeneralizedProfiles")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;
}
