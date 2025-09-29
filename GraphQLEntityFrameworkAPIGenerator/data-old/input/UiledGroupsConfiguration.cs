using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UILedGroupsConfigurations")]
public partial class UiledGroupsConfiguration
{
    [Key]
    [Column("UILedGroupsConfigurationsId")]
    public Guid UiledGroupsConfigurationsId { get; set; }

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

    [Column("UILedConfigurationsId")]
    public Guid? UiledConfigurationsId { get; set; }

    [InverseProperty("UiledGroupsConfigurations")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();

    [ForeignKey("UiledConfigurationsId")]
    [InverseProperty("UiledGroupsConfigurations")]
    public virtual UiledConfiguration? UiledConfigurations { get; set; }

    [InverseProperty("UiledGroupsConfigurations")]
    public virtual ICollection<UiledGroupsConfigurationsUiledGroup> UiledGroupsConfigurationsUiledGroups { get; set; } = new List<UiledGroupsConfigurationsUiledGroup>();
}
