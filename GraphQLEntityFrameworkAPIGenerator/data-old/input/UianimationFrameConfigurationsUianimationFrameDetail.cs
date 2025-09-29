using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UianimationFrameConfigurationsId", "UianimationFrameDetailsId", "Index")]
[Table("UIAnimationFrameConfigurations_UIAnimationFrameDetails")]
public partial class UianimationFrameConfigurationsUianimationFrameDetail
{
    [Key]
    [Column("UIAnimationFrameConfigurationsId")]
    public Guid UianimationFrameConfigurationsId { get; set; }

    [Key]
    [Column("UIAnimationFrameDetailsId")]
    public Guid UianimationFrameDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UianimationFrameConfigurationsId")]
    [InverseProperty("UianimationFrameConfigurationsUianimationFrameDetails")]
    public virtual UianimationFrameConfiguration UianimationFrameConfigurations { get; set; } = null!;

    [ForeignKey("UianimationFrameDetailsId")]
    [InverseProperty("UianimationFrameConfigurationsUianimationFrameDetails")]
    public virtual UianimationFrameDetail UianimationFrameDetails { get; set; } = null!;
}
