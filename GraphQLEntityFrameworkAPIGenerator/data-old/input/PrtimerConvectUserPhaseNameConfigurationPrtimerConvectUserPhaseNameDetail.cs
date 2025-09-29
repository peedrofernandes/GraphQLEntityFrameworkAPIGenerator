using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("PrtimerConvectUserPhaseNameConfigId", "PrtimerConvectUserPhaseNameDetailsId", "Index")]
[Table("PRTimerConvectUserPhaseNameConfiguration_PRTimerConvectUserPhaseNameDetails")]
public partial class PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail
{
    [Key]
    [Column("PRTimerConvectUserPhaseNameConfigId")]
    public Guid PrtimerConvectUserPhaseNameConfigId { get; set; }

    [Key]
    [Column("PRTimerConvectUserPhaseNameDetailsId")]
    public Guid PrtimerConvectUserPhaseNameDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("PrtimerConvectUserPhaseNameConfigId")]
    [InverseProperty("PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails")]
    public virtual PrtimerConvectUserPhaseNameConfiguration PrtimerConvectUserPhaseNameConfig { get; set; } = null!;

    [ForeignKey("PrtimerConvectUserPhaseNameDetailsId")]
    [InverseProperty("PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails")]
    public virtual PrtimerConvectUserPhaseNameDetail PrtimerConvectUserPhaseNameDetails { get; set; } = null!;
}
