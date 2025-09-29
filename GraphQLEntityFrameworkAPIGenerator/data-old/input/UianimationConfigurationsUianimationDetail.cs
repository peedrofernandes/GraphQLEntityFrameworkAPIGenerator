using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UianimationConfigurationId", "UianimationDetailsId", "Index")]
[Table("UIAnimationConfigurations_UIAnimationDetails")]
public partial class UianimationConfigurationsUianimationDetail
{
    [Key]
    [Column("UIAnimationConfigurationId")]
    public Guid UianimationConfigurationId { get; set; }

    [Key]
    [Column("UIAnimationDetailsId")]
    public Guid UianimationDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UianimationConfigurationId")]
    [InverseProperty("UianimationConfigurationsUianimationDetails")]
    public virtual UianimationConfiguration UianimationConfiguration { get; set; } = null!;

    [ForeignKey("UianimationDetailsId")]
    [InverseProperty("UianimationConfigurationsUianimationDetails")]
    public virtual UianimationDetail UianimationDetails { get; set; } = null!;
}
