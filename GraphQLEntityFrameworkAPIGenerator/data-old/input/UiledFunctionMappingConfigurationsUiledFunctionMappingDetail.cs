using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UiledFunctionMappingConfigId", "UiledFunctionMappingDetailId", "Index")]
[Table("UILedFunctionMappingConfigurations_UILedFunctionMappingDetails")]
public partial class UiledFunctionMappingConfigurationsUiledFunctionMappingDetail
{
    [Key]
    [Column("UILedFunctionMappingConfigId")]
    public Guid UiledFunctionMappingConfigId { get; set; }

    [Key]
    [Column("UILedFunctionMappingDetailId")]
    public Guid UiledFunctionMappingDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UiledFunctionMappingConfigId")]
    [InverseProperty("UiledFunctionMappingConfigurationsUiledFunctionMappingDetails")]
    public virtual UiledFunctionMappingConfiguration UiledFunctionMappingConfig { get; set; } = null!;

    [ForeignKey("UiledFunctionMappingDetailId")]
    [InverseProperty("UiledFunctionMappingConfigurationsUiledFunctionMappingDetails")]
    public virtual UiledFunctionMappingDetail UiledFunctionMappingDetail { get; set; } = null!;
}
