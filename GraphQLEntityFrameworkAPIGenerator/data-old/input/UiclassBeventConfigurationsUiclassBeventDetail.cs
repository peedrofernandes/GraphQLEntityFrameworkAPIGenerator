using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UiclassBeventConfigurationId", "UiclassBeventDetailId", "Index")]
[Table("UIClassBEventConfigurations_UIClassBEventDetails")]
public partial class UiclassBeventConfigurationsUiclassBeventDetail
{
    [Key]
    [Column("UIClassBEventConfigurationId")]
    public Guid UiclassBeventConfigurationId { get; set; }

    [Key]
    [Column("UIClassBEventDetailId")]
    public Guid UiclassBeventDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UiclassBeventConfigurationId")]
    [InverseProperty("UiclassBeventConfigurationsUiclassBeventDetails")]
    public virtual UiclassBeventConfiguration UiclassBeventConfiguration { get; set; } = null!;

    [ForeignKey("UiclassBeventDetailId")]
    [InverseProperty("UiclassBeventConfigurationsUiclassBeventDetails")]
    public virtual UiclassBeventDetail UiclassBeventDetail { get; set; } = null!;
}
