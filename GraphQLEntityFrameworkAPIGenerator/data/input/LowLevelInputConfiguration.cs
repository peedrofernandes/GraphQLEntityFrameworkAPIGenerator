using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class LowLevelInputConfiguration
{
    [Key]
    public Guid LowLevelInputConfigurationId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public byte Board { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [InverseProperty("LowLevelInputConfiguration")]
    public virtual ICollection<Board> Boards { get; set; } = new List<Board>();

    [InverseProperty("LowLevelInputConfiguration")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();

    [InverseProperty("LowLevelInputConfiguration")]
    public virtual ICollection<LowLevelInputConfigurationsLowLevelInputDetail> LowLevelInputConfigurationsLowLevelInputDetails { get; set; } = new List<LowLevelInputConfigurationsLowLevelInputDetail>();

    [ForeignKey("TableTarget")]
    [InverseProperty("LowLevelInputConfigurations")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;
}
