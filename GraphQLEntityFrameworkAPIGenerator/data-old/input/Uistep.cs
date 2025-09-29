using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UISteps")]
public partial class Uistep
{
    [Key]
    [Column("UIStepId")]
    public Guid UistepId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public byte Timer { get; set; }

    public byte Timeout { get; set; }

    public bool DisableFunctionLayer { get; set; }

    public byte FeedbackCode { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [ForeignKey("TableTarget")]
    [InverseProperty("Uisteps")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;

    [InverseProperty("Uistep")]
    public virtual ICollection<UisequencesUistep> UisequencesUisteps { get; set; } = new List<UisequencesUistep>();

    [InverseProperty("Uistep")]
    public virtual ICollection<UistepsUicondition> UistepsUiconditions { get; set; } = new List<UistepsUicondition>();
}
