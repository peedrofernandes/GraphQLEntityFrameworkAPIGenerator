using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerBroilTimerLimitDetails")]
public partial class PrtimerBroilTimerLimitDetail
{
    [Key]
    [Column("PRTimerBroilTimerLimitDetailsId")]
    public Guid PrtimerBroilTimerLimitDetailsId { get; set; }

    public long TimerLimit { get; set; }

    [InverseProperty("PrtimerBroilTimerLimitDetails")]
    public virtual ICollection<PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail> PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails { get; set; } = new List<PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail>();
}
