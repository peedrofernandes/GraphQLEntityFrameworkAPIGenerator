using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerMagnetronUserPhaseNameConfiguration")]
public partial class PrtimerMagnetronUserPhaseNameConfiguration
{
    [Key]
    [Column("PRTimerMagnetronUserPhaseNameConfigId")]
    public Guid PrtimerMagnetronUserPhaseNameConfigId { get; set; }

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

    [InverseProperty("PrtimerMagnetronUserPhaseNameConfig")]
    public virtual ICollection<PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration> PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations { get; set; } = new List<PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration>();

    [InverseProperty("PrtimerMagnetronUserPhaseNameConfig")]
    public virtual ICollection<PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail> PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails { get; set; } = new List<PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail>();
}
