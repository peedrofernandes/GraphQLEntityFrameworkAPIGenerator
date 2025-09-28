using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("PrtimerMagnetronUserPhaseNameConfigId", "PrtimerMagnetronUserPhaseNameDetailsId", "Index")]
[Table("PRTimerMagnetronUserPhaseNameConfiguration_PRTimerMagnetronUserPhaseNameDetails")]
public partial class PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail
{
    [Key]
    [Column("PRTimerMagnetronUserPhaseNameConfigId")]
    public Guid PrtimerMagnetronUserPhaseNameConfigId { get; set; }

    [Key]
    [Column("PRTimerMagnetronUserPhaseNameDetailsId")]
    public Guid PrtimerMagnetronUserPhaseNameDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("PrtimerMagnetronUserPhaseNameConfigId")]
    [InverseProperty("PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails")]
    public virtual PrtimerMagnetronUserPhaseNameConfiguration PrtimerMagnetronUserPhaseNameConfig { get; set; } = null!;

    [ForeignKey("PrtimerMagnetronUserPhaseNameDetailsId")]
    [InverseProperty("PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails")]
    public virtual PrtimerMagnetronUserPhaseNameDetail PrtimerMagnetronUserPhaseNameDetails { get; set; } = null!;
}
