using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerMagnetronConfiguration")]
public partial class PrtimerMagnetronConfiguration
{
    [Key]
    [Column("PRTimerMagnetronConfigId")]
    public Guid PrtimerMagnetronConfigId { get; set; }

    public byte Version { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    public byte NumberOfLevels { get; set; }

    [Column("PRTimerMagnetronTimerLimitConfigId")]
    public Guid? PrtimerMagnetronTimerLimitConfigId { get; set; }

    [InverseProperty("PrtimerMagnetronConfig")]
    public virtual ICollection<PowerReductionTimerConfiguration> PowerReductionTimerConfigurations { get; set; } = new List<PowerReductionTimerConfiguration>();

    [InverseProperty("PrtimerMagnetronConfig")]
    public virtual ICollection<PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration> PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations { get; set; } = new List<PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration>();

    [ForeignKey("PrtimerMagnetronTimerLimitConfigId")]
    [InverseProperty("PrtimerMagnetronConfigurations")]
    public virtual PrtimerMagnetronTimerLimitConfiguration? PrtimerMagnetronTimerLimitConfig { get; set; }
}
