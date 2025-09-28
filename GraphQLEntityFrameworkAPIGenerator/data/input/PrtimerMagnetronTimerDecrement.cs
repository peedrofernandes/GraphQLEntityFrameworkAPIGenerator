using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PRTimerMagnetronTimerDecrement")]
public partial class PrtimerMagnetronTimerDecrement
{
    [Key]
    [Column("PRTimerMagnetronTimerDecrementId")]
    public Guid PrtimerMagnetronTimerDecrementId { get; set; }

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

    public byte NumberOfFanSpeeds { get; set; }

    public byte FanSpeed0 { get; set; }

    public byte FanSpeed1 { get; set; }

    public byte FanSpeed2 { get; set; }

    public byte FanSpeed3 { get; set; }

    public byte FanSpeed4 { get; set; }

    public byte FanSpeed5 { get; set; }

    public byte FanSpeed6 { get; set; }

    [InverseProperty("PrtimerMagnetronTimerDecrement")]
    public virtual ICollection<PowerReductionTimerConfiguration> PowerReductionTimerConfigurations { get; set; } = new List<PowerReductionTimerConfiguration>();
}
