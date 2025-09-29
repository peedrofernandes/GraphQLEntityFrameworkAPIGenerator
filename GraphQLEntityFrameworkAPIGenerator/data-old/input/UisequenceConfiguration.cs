using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UISequenceConfigurations")]
public partial class UisequenceConfiguration
{
    [Key]
    [Column("UISequenceConfigurationId")]
    public Guid UisequenceConfigurationId { get; set; }

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

    [InverseProperty("SequenceConfiguration")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();

    [ForeignKey("TableTarget")]
    [InverseProperty("UisequenceConfigurations")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;

    [InverseProperty("UisequenceConfiguration")]
    public virtual ICollection<UisequenceConfigurationsUisequence> UisequenceConfigurationsUisequences { get; set; } = new List<UisequenceConfigurationsUisequence>();
}
