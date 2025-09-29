using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UisreventConfigurationId", "UisreventDetailId", "Index")]
[Table("UISREventConfigurations_UISREventDetails")]
public partial class UisreventConfigurationsUisreventDetail
{
    [Key]
    [Column("UISREventConfigurationId")]
    public Guid UisreventConfigurationId { get; set; }

    [Key]
    [Column("UISREventDetailId")]
    public Guid UisreventDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UisreventConfigurationId")]
    [InverseProperty("UisreventConfigurationsUisreventDetails")]
    public virtual UisreventConfiguration UisreventConfiguration { get; set; } = null!;

    [ForeignKey("UisreventDetailId")]
    [InverseProperty("UisreventConfigurationsUisreventDetails")]
    public virtual UisreventDetail UisreventDetail { get; set; } = null!;
}
