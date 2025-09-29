using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("PrtimerConvectConfigId", "PrtimerConvectUserPhaseNameConfigId", "Index")]
[Table("PRTimerConvectConfiguration_PRTimerConvectUserPhaseNameConfiguration")]
public partial class PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration
{
    [Key]
    [Column("PRTimerConvectConfigId")]
    public Guid PrtimerConvectConfigId { get; set; }

    [Key]
    [Column("PRTimerConvectUserPhaseNameConfigId")]
    public Guid PrtimerConvectUserPhaseNameConfigId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("PrtimerConvectConfigId")]
    [InverseProperty("PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations")]
    public virtual PrtimerConvectConfiguration PrtimerConvectConfig { get; set; } = null!;

    [ForeignKey("PrtimerConvectUserPhaseNameConfigId")]
    [InverseProperty("PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations")]
    public virtual PrtimerConvectUserPhaseNameConfiguration PrtimerConvectUserPhaseNameConfig { get; set; } = null!;
}
