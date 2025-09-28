using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerConvectTimerLimitDetails")]
public partial class PrtimerConvectTimerLimitDetail
{
    [Key]
    [Column("PRTimerConvectTimerLimitDetailsId")]
    public Guid PrtimerConvectTimerLimitDetailsId { get; set; }

    public long TimerLimit { get; set; }

    [InverseProperty("PrtimerConvectTimerLimitDetails")]
    public virtual ICollection<PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail> PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails { get; set; } = new List<PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail>();
}
