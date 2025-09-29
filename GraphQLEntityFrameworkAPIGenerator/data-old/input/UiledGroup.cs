using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UILedGroups")]
public partial class UiledGroup
{
    [Key]
    [Column("UILedGroupsId")]
    public Guid UiledGroupsId { get; set; }

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

    public int LedFunctionId { get; set; }

    public byte Compartment { get; set; }

    [InverseProperty("UiledGroups")]
    public virtual ICollection<UiledGroupsConfigurationsUiledGroup> UiledGroupsConfigurationsUiledGroups { get; set; } = new List<UiledGroupsConfigurationsUiledGroup>();

    [InverseProperty("UiledGroups")]
    public virtual ICollection<UiledGroupsUiledGroupsDetail> UiledGroupsUiledGroupsDetails { get; set; } = new List<UiledGroupsUiledGroupsDetail>();
}
