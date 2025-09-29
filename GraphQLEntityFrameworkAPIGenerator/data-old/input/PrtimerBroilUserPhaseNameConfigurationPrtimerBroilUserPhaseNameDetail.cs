using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("PrtimerBroilUserPhaseNameConfigId", "PrtimerBroilUserPhaseNameDetailsId", "Index")]
[Table("PRTimerBroilUserPhaseNameConfiguration_PRTimerBroilUserPhaseNameDetails")]
public partial class PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail
{
    [Key]
    [Column("PRTimerBroilUserPhaseNameConfigId")]
    public Guid PrtimerBroilUserPhaseNameConfigId { get; set; }

    [Key]
    [Column("PRTimerBroilUserPhaseNameDetailsId")]
    public Guid PrtimerBroilUserPhaseNameDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("PrtimerBroilUserPhaseNameConfigId")]
    [InverseProperty("PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails")]
    public virtual PrtimerBroilUserPhaseNameConfiguration PrtimerBroilUserPhaseNameConfig { get; set; } = null!;

    [ForeignKey("PrtimerBroilUserPhaseNameDetailsId")]
    [InverseProperty("PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails")]
    public virtual PrtimerBroilUserPhaseNameDetail PrtimerBroilUserPhaseNameDetails { get; set; } = null!;
}
