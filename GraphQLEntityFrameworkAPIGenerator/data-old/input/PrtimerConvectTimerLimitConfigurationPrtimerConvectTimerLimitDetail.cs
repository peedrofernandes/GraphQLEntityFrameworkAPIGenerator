using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("PrtimerConvectTimerLimitConfigId", "PrtimerConvectTimerLimitDetailsId", "Index")]
[Table("PRTimerConvectTimerLimitConfiguration_PRTimerConvectTimerLimitDetails")]
public partial class PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail
{
    [Key]
    [Column("PRTimerConvectTimerLimitConfigId")]
    public Guid PrtimerConvectTimerLimitConfigId { get; set; }

    [Key]
    [Column("PRTimerConvectTimerLimitDetailsId")]
    public Guid PrtimerConvectTimerLimitDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("PrtimerConvectTimerLimitConfigId")]
    [InverseProperty("PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails")]
    public virtual PrtimerConvectTimerLimitConfiguration PrtimerConvectTimerLimitConfig { get; set; } = null!;

    [ForeignKey("PrtimerConvectTimerLimitDetailsId")]
    [InverseProperty("PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails")]
    public virtual PrtimerConvectTimerLimitDetail PrtimerConvectTimerLimitDetails { get; set; } = null!;
}
