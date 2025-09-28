using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UILedGroupsDetails")]
public partial class UiledGroupsDetail
{
    [Key]
    [Column("UILedGroupsDetailsId")]
    public Guid UiledGroupsDetailsId { get; set; }

    public byte Led { get; set; }

    [InverseProperty("UiledGroupsDetails")]
    public virtual ICollection<UiledGroupsUiledGroupsDetail> UiledGroupsUiledGroupsDetails { get; set; } = new List<UiledGroupsUiledGroupsDetail>();
}
