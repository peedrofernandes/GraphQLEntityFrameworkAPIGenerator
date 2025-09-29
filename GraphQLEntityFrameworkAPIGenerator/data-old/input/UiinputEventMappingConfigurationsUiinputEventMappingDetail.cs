using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UiinputEventMappingConfigurationId", "UiinputEventMappingDetailsId", "Index")]
[Table("UIInputEventMappingConfigurations_UIInputEventMappingDetails")]
public partial class UiinputEventMappingConfigurationsUiinputEventMappingDetail
{
    [Key]
    [Column("UIInputEventMappingConfigurationId")]
    public Guid UiinputEventMappingConfigurationId { get; set; }

    [Key]
    [Column("UIInputEventMappingDetailsId")]
    public Guid UiinputEventMappingDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UiinputEventMappingConfigurationId")]
    [InverseProperty("UiinputEventMappingConfigurationsUiinputEventMappingDetails")]
    public virtual UiinputEventMappingConfiguration UiinputEventMappingConfiguration { get; set; } = null!;

    [ForeignKey("UiinputEventMappingDetailsId")]
    [InverseProperty("UiinputEventMappingConfigurationsUiinputEventMappingDetails")]
    public virtual UiinputEventMappingDetail UiinputEventMappingDetails { get; set; } = null!;
}
