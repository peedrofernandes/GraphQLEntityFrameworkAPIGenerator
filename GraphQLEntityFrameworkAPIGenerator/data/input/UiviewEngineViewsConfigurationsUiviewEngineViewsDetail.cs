using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UiviewEngineViewsConfigurationsId", "UiviewEngineViewsDetailsId", "Index")]
[Table("UIViewEngineViewsConfigurations_UIViewEngineViewsDetails")]
public partial class UiviewEngineViewsConfigurationsUiviewEngineViewsDetail
{
    [Key]
    [Column("UIViewEngineViewsConfigurationsId")]
    public Guid UiviewEngineViewsConfigurationsId { get; set; }

    [Key]
    [Column("UIViewEngineViewsDetailsId")]
    public Guid UiviewEngineViewsDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UiviewEngineViewsConfigurationsId")]
    [InverseProperty("UiviewEngineViewsConfigurationsUiviewEngineViewsDetails")]
    public virtual UiviewEngineViewsConfiguratio UiviewEngineViewsConfigurations { get; set; } = null!;

    [ForeignKey("UiviewEngineViewsDetailsId")]
    [InverseProperty("UiviewEngineViewsConfigurationsUiviewEngineViewsDetails")]
    public virtual UiviewEngineViewsDetail UiviewEngineViewsDetails { get; set; } = null!;
}
