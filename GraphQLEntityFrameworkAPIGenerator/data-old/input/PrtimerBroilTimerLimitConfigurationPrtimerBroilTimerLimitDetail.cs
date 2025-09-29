using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("PrtimerBroilTimerLimitConfigId", "PrtimerBroilTimerLimitDetailsId", "Index")]
[Table("PRTimerBroilTimerLimitConfiguration_PRTimerBroilTimerLimitDetails")]
public partial class PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail
{
    [Key]
    [Column("PRTimerBroilTimerLimitConfigId")]
    public Guid PrtimerBroilTimerLimitConfigId { get; set; }

    [Key]
    [Column("PRTimerBroilTimerLimitDetailsId")]
    public Guid PrtimerBroilTimerLimitDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("PrtimerBroilTimerLimitConfigId")]
    [InverseProperty("PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails")]
    public virtual PrtimerBroilTimerLimitConfiguration PrtimerBroilTimerLimitConfig { get; set; } = null!;

    [ForeignKey("PrtimerBroilTimerLimitDetailsId")]
    [InverseProperty("PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails")]
    public virtual PrtimerBroilTimerLimitDetail PrtimerBroilTimerLimitDetails { get; set; } = null!;
}
