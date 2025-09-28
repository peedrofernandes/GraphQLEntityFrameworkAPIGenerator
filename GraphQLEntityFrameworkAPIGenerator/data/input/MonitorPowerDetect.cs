using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorPowerDetect")]
public partial class MonitorPowerDetect
{
    [Key]
    public Guid PowerDetectMonitorId { get; set; }

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

    public byte Version { get; set; }

    public byte Volts120Maximum { get; set; }

    public short Degrees120Minimum { get; set; }

    public short Degrees120Maximum { get; set; }

    public short Degrees180Minimum { get; set; }

    public short Degrees180Maximum { get; set; }

    public short Degrees240Minimum { get; set; }

    public short Degrees240Maximum { get; set; }

    public short Degrees360Minimum { get; set; }

    public short Degrees0Maximum { get; set; }

    [InverseProperty("PowerDetectMonitor")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();
}
