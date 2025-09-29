using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerMagnetronTimerLimitDetails")]
public partial class PrtimerMagnetronTimerLimitDetail
{
    [Key]
    [Column("PRTimerMagnetronTimerLimitDetailsId")]
    public Guid PrtimerMagnetronTimerLimitDetailsId { get; set; }

    public long TimerLimit { get; set; }

    [InverseProperty("PrtimerMagnetronTimerLimitDetails")]
    public virtual ICollection<PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail> PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails { get; set; } = new List<PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail>();
}
