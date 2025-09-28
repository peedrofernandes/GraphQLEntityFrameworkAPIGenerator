using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class LoadConfiguration
{
    [Key]
    public Guid LoadConfigurationId { get; set; }

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

    [InverseProperty("LoadConfiguration")]
    public virtual ICollection<Board> Boards { get; set; } = new List<Board>();

    [InverseProperty("LoadConfiguration")]
    public virtual ICollection<LoadConfigurationsLoadDetail> LoadConfigurationsLoadDetails { get; set; } = new List<LoadConfigurationsLoadDetail>();

    [ForeignKey("TableTarget")]
    [InverseProperty("LoadConfigurations")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;
}
