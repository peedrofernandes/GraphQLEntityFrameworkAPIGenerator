using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerConvectUserPhaseNameConfiguration")]
public partial class PrtimerConvectUserPhaseNameConfiguration
{
    [Key]
    [Column("PRTimerConvectUserPhaseNameConfigId")]
    public Guid PrtimerConvectUserPhaseNameConfigId { get; set; }

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

    [InverseProperty("PrtimerConvectUserPhaseNameConfig")]
    public virtual ICollection<PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration> PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations { get; set; } = new List<PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration>();

    [InverseProperty("PrtimerConvectUserPhaseNameConfig")]
    public virtual ICollection<PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail> PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails { get; set; } = new List<PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail>();
}
