using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UiledConfigurationsId", "UiledDriverParametersId", "Index")]
[Table("UILedConfigurations_UILedDriverParameters")]
public partial class UiledConfigurationsUiledDriverParameter
{
    [Key]
    [Column("UILedConfigurationsId")]
    public Guid UiledConfigurationsId { get; set; }

    [Key]
    [Column("UILedDriverParametersId")]
    public Guid UiledDriverParametersId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UiledConfigurationsId")]
    [InverseProperty("UiledConfigurationsUiledDriverParameters")]
    public virtual UiledConfiguration UiledConfigurations { get; set; } = null!;

    [ForeignKey("UiledDriverParametersId")]
    [InverseProperty("UiledConfigurationsUiledDriverParameters")]
    public virtual UiledDriverParameter UiledDriverParameters { get; set; } = null!;
}
