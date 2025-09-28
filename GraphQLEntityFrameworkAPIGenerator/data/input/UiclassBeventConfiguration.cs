using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIClassBEventConfigurations")]
public partial class UiclassBeventConfiguration
{
    [Key]
    [Column("UIClassBEventConfigurationId")]
    public Guid UiclassBeventConfigurationId { get; set; }

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

    [ForeignKey("TableTarget")]
    [InverseProperty("UiclassBeventConfigurations")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;

    [InverseProperty("UiclassBeventConfiguration")]
    public virtual ICollection<UiclassBeventConfigurationsUiclassBeventDetail> UiclassBeventConfigurationsUiclassBeventDetails { get; set; } = new List<UiclassBeventConfigurationsUiclassBeventDetail>();
}
