using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorPowerReduction")]
public partial class MonitorPowerReduction
{
    [Key]
    public Guid MonitorPowerReductionId { get; set; }

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

    public Guid? PowerReductionTimerConfigId { get; set; }

    [InverseProperty("MonitorPowerReduction")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();

    [ForeignKey("PowerReductionTimerConfigId")]
    [InverseProperty("MonitorPowerReductions")]
    public virtual PowerReductionTimerConfiguration? PowerReductionTimerConfig { get; set; }
}
