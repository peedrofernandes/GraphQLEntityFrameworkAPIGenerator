using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UiledGroupsConfigurationsId", "UiledGroupsId", "Index")]
[Table("UILedGroupsConfigurations_UILedGroups")]
public partial class UiledGroupsConfigurationsUiledGroup
{
    [Key]
    [Column("UILedGroupsConfigurationsId")]
    public Guid UiledGroupsConfigurationsId { get; set; }

    [Key]
    [Column("UILedGroupsId")]
    public Guid UiledGroupsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UiledGroupsId")]
    [InverseProperty("UiledGroupsConfigurationsUiledGroups")]
    public virtual UiledGroup UiledGroups { get; set; } = null!;

    [ForeignKey("UiledGroupsConfigurationsId")]
    [InverseProperty("UiledGroupsConfigurationsUiledGroups")]
    public virtual UiledGroupsConfiguration UiledGroupsConfigurations { get; set; } = null!;
}
