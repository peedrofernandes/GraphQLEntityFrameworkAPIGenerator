using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerMagnetronUserPhaseNameDetails")]
public partial class PrtimerMagnetronUserPhaseNameDetail
{
    [Key]
    [Column("PRTimerMagnetronUserPhaseNameDetailsId")]
    public Guid PrtimerMagnetronUserPhaseNameDetailsId { get; set; }

    public byte TimerIncrement { get; set; }

    public byte PowerLimit { get; set; }

    [InverseProperty("PrtimerMagnetronUserPhaseNameDetails")]
    public virtual ICollection<PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail> PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails { get; set; } = new List<PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail>();
}
