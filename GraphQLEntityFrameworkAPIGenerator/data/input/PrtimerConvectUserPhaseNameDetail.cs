using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerConvectUserPhaseNameDetails")]
public partial class PrtimerConvectUserPhaseNameDetail
{
    [Key]
    [Column("PRTimerConvectUserPhaseNameDetailsId")]
    public Guid PrtimerConvectUserPhaseNameDetailsId { get; set; }

    public byte TimerIncrement { get; set; }

    public byte PowerLimit { get; set; }

    [InverseProperty("PrtimerConvectUserPhaseNameDetails")]
    public virtual ICollection<PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail> PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails { get; set; } = new List<PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail>();
}
