using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UISequences")]
public partial class Uisequence
{
    [Key]
    [Column("UISequenceId")]
    public Guid UisequenceId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    [Column("GIReadTypeId")]
    public byte GireadTypeId { get; set; }

    [Column("GIReadTypePosition")]
    public byte GireadTypePosition { get; set; }

    [Column("GIValue")]
    public byte Givalue { get; set; }

    public bool UseNewBuffer { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [ForeignKey("TableTarget")]
    [InverseProperty("Uisequences")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;

    [InverseProperty("Uisequence")]
    public virtual ICollection<UisequenceConfigurationsUisequence> UisequenceConfigurationsUisequences { get; set; } = new List<UisequenceConfigurationsUisequence>();

    [InverseProperty("Uisequence")]
    public virtual ICollection<UisequencesUistep> UisequencesUisteps { get; set; } = new List<UisequencesUistep>();
}
