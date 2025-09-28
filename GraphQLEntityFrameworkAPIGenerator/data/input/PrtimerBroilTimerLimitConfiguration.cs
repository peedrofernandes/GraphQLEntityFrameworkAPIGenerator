using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerBroilTimerLimitConfiguration")]
public partial class PrtimerBroilTimerLimitConfiguration
{
    [Key]
    [Column("PRTimerBroilTimerLimitConfigId")]
    public Guid PrtimerBroilTimerLimitConfigId { get; set; }

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

    [InverseProperty("PrtimerBroilTimerLimitConfig")]
    public virtual ICollection<PrtimerBroilConfiguration> PrtimerBroilConfigurations { get; set; } = new List<PrtimerBroilConfiguration>();

    [InverseProperty("PrtimerBroilTimerLimitConfig")]
    public virtual ICollection<PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail> PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails { get; set; } = new List<PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail>();
}
