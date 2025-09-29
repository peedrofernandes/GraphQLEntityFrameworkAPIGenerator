using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PowerReductionTimerConfiguration")]
public partial class PowerReductionTimerConfiguration
{
    [Key]
    public Guid PowerReductionTimerConfigId { get; set; }

    public byte Version { get; set; }

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

    [Column("PRTimerMagnetronConfigId")]
    public Guid? PrtimerMagnetronConfigId { get; set; }

    [Column("PRTimerBroilConfigId")]
    public Guid? PrtimerBroilConfigId { get; set; }

    [Column("PRTimerMagnetronTimerDecrementId")]
    public Guid? PrtimerMagnetronTimerDecrementId { get; set; }

    [Column("PRTimerBroilTimerDecrementId")]
    public Guid? PrtimerBroilTimerDecrementId { get; set; }

    [StringLength(50)]
    public string Compartment { get; set; } = null!;

    [Column("PRTimerConvectConfigId")]
    public Guid? PrtimerConvectConfigId { get; set; }

    [Column("PRTimerConvectTimerDecrementId")]
    public Guid? PrtimerConvectTimerDecrementId { get; set; }

    [InverseProperty("PowerReductionTimerConfig")]
    public virtual ICollection<MonitorPowerReduction> MonitorPowerReductions { get; set; } = new List<MonitorPowerReduction>();

    [ForeignKey("PrtimerBroilConfigId")]
    [InverseProperty("PowerReductionTimerConfigurations")]
    public virtual PrtimerBroilConfiguration? PrtimerBroilConfig { get; set; }

    [ForeignKey("PrtimerBroilTimerDecrementId")]
    [InverseProperty("PowerReductionTimerConfigurations")]
    public virtual PrtimerBroilTimerDecrement? PrtimerBroilTimerDecrement { get; set; }

    [ForeignKey("PrtimerConvectConfigId")]
    [InverseProperty("PowerReductionTimerConfigurations")]
    public virtual PrtimerConvectConfiguration? PrtimerConvectConfig { get; set; }

    [ForeignKey("PrtimerConvectTimerDecrementId")]
    [InverseProperty("PowerReductionTimerConfigurations")]
    public virtual PrtimerConvectTimerDecrement? PrtimerConvectTimerDecrement { get; set; }

    [ForeignKey("PrtimerMagnetronConfigId")]
    [InverseProperty("PowerReductionTimerConfigurations")]
    public virtual PrtimerMagnetronConfiguration? PrtimerMagnetronConfig { get; set; }

    [ForeignKey("PrtimerMagnetronTimerDecrementId")]
    [InverseProperty("PowerReductionTimerConfigurations")]
    public virtual PrtimerMagnetronTimerDecrement? PrtimerMagnetronTimerDecrement { get; set; }
}
