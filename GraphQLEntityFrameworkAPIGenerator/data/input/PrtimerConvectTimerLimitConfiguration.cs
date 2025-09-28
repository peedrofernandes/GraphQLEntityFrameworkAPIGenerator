using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerConvectTimerLimitConfiguration")]
public partial class PrtimerConvectTimerLimitConfiguration
{
    [Key]
    [Column("PRTimerConvectTimerLimitConfigId")]
    public Guid PrtimerConvectTimerLimitConfigId { get; set; }

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

    [InverseProperty("PrtimerConvectTimerLimitConfig")]
    public virtual ICollection<PrtimerConvectConfiguration> PrtimerConvectConfigurations { get; set; } = new List<PrtimerConvectConfiguration>();

    [InverseProperty("PrtimerConvectTimerLimitConfig")]
    public virtual ICollection<PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail> PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails { get; set; } = new List<PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail>();
}
