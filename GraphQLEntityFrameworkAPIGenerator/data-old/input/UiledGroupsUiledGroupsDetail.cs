using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UiledGroupsId", "UiledGroupsDetailsId", "Index")]
[Table("UILedGroups_UILedGroupsDetails")]
public partial class UiledGroupsUiledGroupsDetail
{
    [Key]
    [Column("UILedGroupsId")]
    public Guid UiledGroupsId { get; set; }

    [Key]
    [Column("UILedGroupsDetailsId")]
    public Guid UiledGroupsDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UiledGroupsId")]
    [InverseProperty("UiledGroupsUiledGroupsDetails")]
    public virtual UiledGroup UiledGroups { get; set; } = null!;

    [ForeignKey("UiledGroupsDetailsId")]
    [InverseProperty("UiledGroupsUiledGroupsDetails")]
    public virtual UiledGroupsDetail UiledGroupsDetails { get; set; } = null!;
}
