using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIViewEngineViewsConfiguratios")]
public partial class UiviewEngineViewsConfiguratio
{
    [Key]
    [Column("UIViewEngineViewsConfigurationsId")]
    public Guid UiviewEngineViewsConfigurationsId { get; set; }

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

    [InverseProperty("UiviewEngineViews")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();

    [InverseProperty("UiviewEngineViewsConfigurations")]
    public virtual ICollection<UiviewEngineViewsConfigurationsUiviewEngineViewsDetail> UiviewEngineViewsConfigurationsUiviewEngineViewsDetails { get; set; } = new List<UiviewEngineViewsConfigurationsUiviewEngineViewsDetail>();
}
