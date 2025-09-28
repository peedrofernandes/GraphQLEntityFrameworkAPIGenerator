using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIAnimationFadingType")]
public partial class UianimationFadingType
{
    [Key]
    public Guid Id { get; set; }

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

    public byte InitialIntensity { get; set; }

    public byte FinalIntensity { get; set; }

    [InverseProperty("UianimationFadingType")]
    public virtual ICollection<UianimationDetail> UianimationDetails { get; set; } = new List<UianimationDetail>();
}
