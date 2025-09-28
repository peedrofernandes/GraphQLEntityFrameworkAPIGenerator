using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerBroilConfiguration")]
public partial class PrtimerBroilConfiguration
{
    [Key]
    [Column("PRTimerBroilConfigId")]
    public Guid PrtimerBroilConfigId { get; set; }

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

    [Column("PRTimerBroilTimerLimitConfigId")]
    public Guid? PrtimerBroilTimerLimitConfigId { get; set; }

    [InverseProperty("PrtimerBroilConfig")]
    public virtual ICollection<PowerReductionTimerConfiguration> PowerReductionTimerConfigurations { get; set; } = new List<PowerReductionTimerConfiguration>();

    [InverseProperty("PrtimerBroilConfig")]
    public virtual ICollection<PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration> PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations { get; set; } = new List<PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration>();

    [ForeignKey("PrtimerBroilTimerLimitConfigId")]
    [InverseProperty("PrtimerBroilConfigurations")]
    public virtual PrtimerBroilTimerLimitConfiguration? PrtimerBroilTimerLimitConfig { get; set; }
}
