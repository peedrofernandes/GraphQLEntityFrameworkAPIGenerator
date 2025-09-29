using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UidefaultPinConfigurationId", "UidefaultPinDetailId", "Index")]
[Table("UIDefaultPinConfigurations_UIDefaultPinDetails")]
public partial class UidefaultPinConfigurationsUidefaultPinDetail
{
    [Key]
    [Column("UIDefaultPinConfigurationId")]
    public Guid UidefaultPinConfigurationId { get; set; }

    [Key]
    [Column("UIDefaultPinDetailId")]
    public Guid UidefaultPinDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UidefaultPinConfigurationId")]
    [InverseProperty("UidefaultPinConfigurationsUidefaultPinDetails")]
    public virtual UidefaultPinConfiguration UidefaultPinConfiguration { get; set; } = null!;

    [ForeignKey("UidefaultPinDetailId")]
    [InverseProperty("UidefaultPinConfigurationsUidefaultPinDetails")]
    public virtual UidefaultPinDetail UidefaultPinDetail { get; set; } = null!;
}
