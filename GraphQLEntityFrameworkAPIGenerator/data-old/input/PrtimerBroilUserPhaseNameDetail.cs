using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerBroilUserPhaseNameDetails")]
public partial class PrtimerBroilUserPhaseNameDetail
{
    [Key]
    [Column("PRTimerBroilUserPhaseNameDetailsId")]
    public Guid PrtimerBroilUserPhaseNameDetailsId { get; set; }

    public byte TimerIncrement { get; set; }

    public byte PowerLimit { get; set; }

    [InverseProperty("PrtimerBroilUserPhaseNameDetails")]
    public virtual ICollection<PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail> PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails { get; set; } = new List<PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail>();
}
