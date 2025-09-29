using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerBroilUserPhaseNameConfiguration")]
public partial class PrtimerBroilUserPhaseNameConfiguration
{
    [Key]
    [Column("PRTimerBroilUserPhaseNameConfigId")]
    public Guid PrtimerBroilUserPhaseNameConfigId { get; set; }

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

    public short UserPhaseName { get; set; }

    public byte NumberOfLevels { get; set; }

    [InverseProperty("PrtimerBroilUserPhaseNameConfig")]
    public virtual ICollection<PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration> PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations { get; set; } = new List<PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration>();

    [InverseProperty("PrtimerBroilUserPhaseNameConfig")]
    public virtual ICollection<PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail> PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails { get; set; } = new List<PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail>();
}
