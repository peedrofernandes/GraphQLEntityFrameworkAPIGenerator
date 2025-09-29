using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("PrtimerBroilConfigId", "PrtimerBroilUserPhaseNameConfigId", "Index")]
[Table("PRTimerBroilConfiguration_PRTimerBroilUserPhaseNameConfiguration")]
public partial class PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration
{
    [Key]
    [Column("PRTimerBroilConfigId")]
    public Guid PrtimerBroilConfigId { get; set; }

    [Key]
    [Column("PRTimerBroilUserPhaseNameConfigId")]
    public Guid PrtimerBroilUserPhaseNameConfigId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("PrtimerBroilConfigId")]
    [InverseProperty("PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations")]
    public virtual PrtimerBroilConfiguration PrtimerBroilConfig { get; set; } = null!;

    [ForeignKey("PrtimerBroilUserPhaseNameConfigId")]
    [InverseProperty("PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations")]
    public virtual PrtimerBroilUserPhaseNameConfiguration PrtimerBroilUserPhaseNameConfig { get; set; } = null!;
}
