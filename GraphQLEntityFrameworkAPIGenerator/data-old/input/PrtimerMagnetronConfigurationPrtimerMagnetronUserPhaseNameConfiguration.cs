using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("PrtimerMagnetronConfigId", "PrtimerMagnetronUserPhaseNameConfigId", "Index")]
[Table("PRTimerMagnetronConfiguration_PRTimerMagnetronUserPhaseNameConfiguration")]
public partial class PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration
{
    [Key]
    [Column("PRTimerMagnetronConfigId")]
    public Guid PrtimerMagnetronConfigId { get; set; }

    [Key]
    [Column("PRTimerMagnetronUserPhaseNameConfigId")]
    public Guid PrtimerMagnetronUserPhaseNameConfigId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("PrtimerMagnetronConfigId")]
    [InverseProperty("PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations")]
    public virtual PrtimerMagnetronConfiguration PrtimerMagnetronConfig { get; set; } = null!;

    [ForeignKey("PrtimerMagnetronUserPhaseNameConfigId")]
    [InverseProperty("PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations")]
    public virtual PrtimerMagnetronUserPhaseNameConfiguration PrtimerMagnetronUserPhaseNameConfig { get; set; } = null!;
}
