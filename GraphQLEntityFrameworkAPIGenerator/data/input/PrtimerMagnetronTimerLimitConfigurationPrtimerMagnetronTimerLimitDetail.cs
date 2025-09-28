using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("PrtimerMagnetronTimerLimitConfigId", "PrtimerMagnetronTimerLimitDetailsId", "Index")]
[Table("PRTimerMagnetronTimerLimitConfiguration_PRTimerMagnetronTimerLimitDetails")]
public partial class PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail
{
    [Key]
    [Column("PRTimerMagnetronTimerLimitConfigId")]
    public Guid PrtimerMagnetronTimerLimitConfigId { get; set; }

    [Key]
    [Column("PRTimerMagnetronTimerLimitDetailsId")]
    public Guid PrtimerMagnetronTimerLimitDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("PrtimerMagnetronTimerLimitConfigId")]
    [InverseProperty("PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails")]
    public virtual PrtimerMagnetronTimerLimitConfiguration PrtimerMagnetronTimerLimitConfig { get; set; } = null!;

    [ForeignKey("PrtimerMagnetronTimerLimitDetailsId")]
    [InverseProperty("PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails")]
    public virtual PrtimerMagnetronTimerLimitDetail PrtimerMagnetronTimerLimitDetails { get; set; } = null!;
}
