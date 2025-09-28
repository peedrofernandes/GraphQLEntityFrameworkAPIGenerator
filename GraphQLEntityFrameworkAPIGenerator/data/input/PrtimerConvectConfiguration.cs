using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerConvectConfiguration")]
public partial class PrtimerConvectConfiguration
{
    [Key]
    [Column("PRTimerConvectConfigId")]
    public Guid PrtimerConvectConfigId { get; set; }

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

    [Column("PRTimerConvectTimerLimitConfigId")]
    public Guid? PrtimerConvectTimerLimitConfigId { get; set; }

    [InverseProperty("PrtimerConvectConfig")]
    public virtual ICollection<PowerReductionTimerConfiguration> PowerReductionTimerConfigurations { get; set; } = new List<PowerReductionTimerConfiguration>();

    [InverseProperty("PrtimerConvectConfig")]
    public virtual ICollection<PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration> PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations { get; set; } = new List<PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration>();

    [ForeignKey("PrtimerConvectTimerLimitConfigId")]
    [InverseProperty("PrtimerConvectConfigurations")]
    public virtual PrtimerConvectTimerLimitConfiguration? PrtimerConvectTimerLimitConfig { get; set; }
}
